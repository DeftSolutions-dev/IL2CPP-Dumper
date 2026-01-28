// ========================================================
// Dumped by @desirepro
// Assembly: System.dll
// Classes:  909
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000B
    public struct unitytls_error_code
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_SUCCESS;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_INVALID_ARGUMENT;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_INVALID_FORMAT;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_INVALID_PASSWORD;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_INVALID_STATE;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_BUFFER_OVERFLOW;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_OUT_OF_MEMORY;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_INTERNAL_ERROR;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_NOT_SUPPORTED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_ENTROPY_SOURCE_FAILED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_STREAM_CLOSED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_USER_WOULD_BLOCK;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_USER_READ_FAILED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_USER_WRITE_FAILED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct unitytls_errorstate
    {
        // Fields
        private System.UInt32 magic;        // 0x10
        public Mono.Unity.UnityTls.unitytls_error_code code;        // 0x14
        private System.UInt64 reserved;        // 0x18

    }

    // TypeToken: 0x200000D
    public struct unitytls_key
    {
    }

    // TypeToken: 0x200000E
    public struct unitytls_key_ref
    {
        // Fields
        public System.UInt64 handle;        // 0x10

    }

    // TypeToken: 0x200000F
    public struct unitytls_x509_ref
    {
        // Fields
        public System.UInt64 handle;        // 0x10

    }

    // TypeToken: 0x2000010
    public struct unitytls_x509list
    {
    }

    // TypeToken: 0x2000011
    public struct unitytls_x509list_ref
    {
        // Fields
        public System.UInt64 handle;        // 0x10

    }

    // TypeToken: 0x2000012
    public struct unitytls_x509verify_result
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_SUCCESS;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_NOT_DONE;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FATAL_ERROR;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_EXPIRED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_REVOKED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR1;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR2;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR3;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR4;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR5;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR6;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR7;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR8;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR;        // 0x0

    }

    // TypeToken: 0x2000013
    public class unitytls_x509verify_callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000014
    public struct unitytls_tlsctx
    {
    }

    // TypeToken: 0x2000015
    public struct unitytls_x509name
    {
    }

    // TypeToken: 0x2000016
    public struct unitytls_ciphersuite
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Mono.Unity.UnityTls.unitytls_ciphersuite UNITYTLS_CIPHERSUITE_INVALID;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct unitytls_protocol
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Mono.Unity.UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_0;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_1;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_2;        // 0x0
        public static Mono.Unity.UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_INVALID;        // 0x0

    }

    // TypeToken: 0x2000018
    public struct unitytls_tlsctx_protocolrange
    {
        // Fields
        public Mono.Unity.UnityTls.unitytls_protocol min;        // 0x10
        public Mono.Unity.UnityTls.unitytls_protocol max;        // 0x14

    }

    // TypeToken: 0x2000019
    public class unitytls_tlsctx_write_callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.IntPtr Invoke(System.Void* userData, System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200001A
    public class unitytls_tlsctx_read_callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.IntPtr Invoke(System.Void* userData, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200001B
    public class unitytls_tlsctx_trace_callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* traceMessage, System.IntPtr traceMessageLen) { }

    }

    // TypeToken: 0x200001C
    public class unitytls_tlsctx_certificate_callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, System.IntPtr caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200001D
    public class unitytls_tlsctx_x509verify_callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200001E
    public struct unitytls_tlsctx_callbacks
    {
        // Fields
        public Mono.Unity.UnityTls.unitytls_tlsctx_read_callback read;        // 0x10
        public Mono.Unity.UnityTls.unitytls_tlsctx_write_callback write;        // 0x18
        public System.Void* data;        // 0x20

    }

    // TypeToken: 0x2000020
    public class unitytls_errorstate_create_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_errorstate Invoke() { }

    }

    // TypeToken: 0x2000021
    public class unitytls_errorstate_raise_error_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode) { }

    }

    // TypeToken: 0x2000022
    public class unitytls_key_get_ref_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000023
    public class unitytls_key_parse_der_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_key* Invoke(System.Byte* buffer, System.IntPtr bufferLen, System.Byte* password, System.IntPtr passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000024
    public class unitytls_key_parse_pem_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_key* Invoke(System.Byte* buffer, System.IntPtr bufferLen, System.Byte* password, System.IntPtr passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000025
    public class unitytls_key_free_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_key* key) { }

    }

    // TypeToken: 0x2000026
    public class unitytls_x509_export_der_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.IntPtr Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000027
    public class unitytls_x509list_get_ref_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000028
    public class unitytls_x509list_get_x509_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, System.IntPtr index, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000029
    public class unitytls_x509list_create_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200002A
    public class unitytls_x509list_append_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200002B
    public class unitytls_x509list_append_der_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200002C
    public class unitytls_x509list_free_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list) { }

    }

    // TypeToken: 0x200002D
    public class unitytls_x509verify_default_ca_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200002E
    public class unitytls_x509verify_explicit_ca_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200002F
    public class unitytls_tlsctx_create_server_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, System.UInt64 certChain, System.UInt64 leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000030
    public class unitytls_tlsctx_create_client_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000031
    public class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000032
    public class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000033
    public class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000034
    public class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000035
    public class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, System.IntPtr supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000036
    public class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000037
    public class unitytls_tlsctx_get_protocol_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000038
    public class unitytls_tlsctx_process_handshake_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000039
    public class unitytls_tlsctx_read_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.IntPtr Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200003A
    public class unitytls_tlsctx_write_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.IntPtr Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200003B
    public class unitytls_tlsctx_notify_close_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200003C
    public class unitytls_tlsctx_free_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx) { }

    }

    // TypeToken: 0x200003D
    public class unitytls_random_generate_bytes_t : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200001F
    public class unitytls_interface_struct
    {
        // Fields
        public readonly System.UInt64 UNITYTLS_INVALID_HANDLE;        // 0x10
        public readonly Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;        // 0x18
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;        // 0x20
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;        // 0x28
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;        // 0x30
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;        // 0x38
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;        // 0x40
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;        // 0x48
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;        // 0x50
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;        // 0x58
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;        // 0x60
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;        // 0x68
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;        // 0x70
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;        // 0x78
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;        // 0x80
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;        // 0x88
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;        // 0x90
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;        // 0x98
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;        // 0xA0
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;        // 0xA8
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;        // 0xB0
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;        // 0xB8
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;        // 0xC0
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;        // 0xC8
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;        // 0xD0
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;        // 0xD8
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;        // 0xE0
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;        // 0xE8
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;        // 0xF0
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;        // 0xF8
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;        // 0x100
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;        // 0x108
        public Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;        // 0x110

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public struct Operation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation None;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation Handshake;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation Authenticated;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation Renegotiate;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation Read;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation Write;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.Operation Close;        // 0x0

    }

    // TypeToken: 0x2000053
    public struct OperationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Net.Security.MobileAuthenticatedStream.OperationType Read;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.OperationType Write;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.OperationType Renegotiate;        // 0x0
        public static Mono.Net.Security.MobileAuthenticatedStream.OperationType Shutdown;        // 0x0

    }

    // TypeToken: 0x2000069
    public class BoringBioHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x200006D
    public struct ControlCommand
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsBioMono.ControlCommand Flush;        // 0x0

    }

    // TypeToken: 0x200006E
    public class BioReadFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr bio, System.IntPtr data, System.Int32 dataLength, System.Int32& wantMore) { }

    }

    // TypeToken: 0x200006F
    public class BioWriteFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr bio, System.IntPtr data, System.Int32 dataLength) { }

    }

    // TypeToken: 0x2000070
    public class BioControlFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int64 Invoke(System.IntPtr bio, Mono.Btls.MonoBtlsBioMono.ControlCommand command, System.Int64 arg) { }

    }

    // TypeToken: 0x2000075
    public class BoringKeyHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000077
    public class MonoBtlsHandle : SafeHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle, System.Boolean ownsHandle) { }
        private System.Boolean get_IsInvalid() { }

    }

    // TypeToken: 0x2000079
    public class BoringPkcs12Handle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x200007F
    public class BoringSslHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000080
    public class PrintErrorsCallbackFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr str, System.IntPtr len, System.IntPtr ctx) { }

    }

    // TypeToken: 0x2000082
    public class BoringSslCtxHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000083
    public class NativeVerifyFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr instance, System.Int32 preverify_ok, System.IntPtr ctx) { }

    }

    // TypeToken: 0x2000084
    public class NativeSelectFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr instance, System.Int32 count, System.IntPtr sizes, System.IntPtr data) { }

    }

    // TypeToken: 0x2000085
    public class NativeServerNameFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr instance) { }

    }

    // TypeToken: 0x200008B
    public class BoringX509Handle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }
        private System.IntPtr StealHandle() { }

    }

    // TypeToken: 0x200008D
    public class BoringX509ChainHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000092
    public class BoringX509LookupHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000094
    public class BoringX509LookupMonoHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000095
    public class BySubjectFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr instance, System.IntPtr name, System.IntPtr& x509_ptr) { }

    }

    // TypeToken: 0x2000099
    public class BoringX509NameHandle : MonoBtlsHandle
    {
        // Fields
        private System.Boolean dontFree;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr handle, System.Boolean ownsHandle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x200009C
    public class BoringX509StoreHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x200009E
    public class BoringX509StoreCtxHandle : MonoBtlsHandle
    {
        // Fields
        private System.Boolean dontFree;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr handle, System.Boolean ownsHandle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x20000A3
    public class BoringX509VerifyParamHandle : MonoBtlsHandle
    {
        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x20000AD
    public struct AlgorithmIdentifier
    {
        // Fields
        private System.String AlgorithmId;        // 0x10
        private System.Byte[] Parameters;        // 0x18

    }

    // TypeToken: 0x20000B9
    public struct Flags
    {
        // Fields
        public System.UInt64 value__;        // 0x10
        public static System.Uri.Flags Zero;        // 0x0
        public static System.Uri.Flags SchemeNotCanonical;        // 0x0
        public static System.Uri.Flags UserNotCanonical;        // 0x0
        public static System.Uri.Flags HostNotCanonical;        // 0x0
        public static System.Uri.Flags PortNotCanonical;        // 0x0
        public static System.Uri.Flags PathNotCanonical;        // 0x0
        public static System.Uri.Flags QueryNotCanonical;        // 0x0
        public static System.Uri.Flags FragmentNotCanonical;        // 0x0
        public static System.Uri.Flags CannotDisplayCanonical;        // 0x0
        public static System.Uri.Flags E_UserNotCanonical;        // 0x0
        public static System.Uri.Flags E_HostNotCanonical;        // 0x0
        public static System.Uri.Flags E_PortNotCanonical;        // 0x0
        public static System.Uri.Flags E_PathNotCanonical;        // 0x0
        public static System.Uri.Flags E_QueryNotCanonical;        // 0x0
        public static System.Uri.Flags E_FragmentNotCanonical;        // 0x0
        public static System.Uri.Flags E_CannotDisplayCanonical;        // 0x0
        public static System.Uri.Flags ShouldBeCompressed;        // 0x0
        public static System.Uri.Flags FirstSlashAbsent;        // 0x0
        public static System.Uri.Flags BackslashInPath;        // 0x0
        public static System.Uri.Flags IndexMask;        // 0x0
        public static System.Uri.Flags HostTypeMask;        // 0x0
        public static System.Uri.Flags HostNotParsed;        // 0x0
        public static System.Uri.Flags IPv6HostType;        // 0x0
        public static System.Uri.Flags IPv4HostType;        // 0x0
        public static System.Uri.Flags DnsHostType;        // 0x0
        public static System.Uri.Flags UncHostType;        // 0x0
        public static System.Uri.Flags BasicHostType;        // 0x0
        public static System.Uri.Flags UnusedHostType;        // 0x0
        public static System.Uri.Flags UnknownHostType;        // 0x0
        public static System.Uri.Flags UserEscaped;        // 0x0
        public static System.Uri.Flags AuthorityFound;        // 0x0
        public static System.Uri.Flags HasUserInfo;        // 0x0
        public static System.Uri.Flags LoopbackHost;        // 0x0
        public static System.Uri.Flags NotDefaultPort;        // 0x0
        public static System.Uri.Flags UserDrivenParsing;        // 0x0
        public static System.Uri.Flags CanonicalDnsHost;        // 0x0
        public static System.Uri.Flags ErrorOrParsingRecursion;        // 0x0
        public static System.Uri.Flags DosPath;        // 0x0
        public static System.Uri.Flags UncPath;        // 0x0
        public static System.Uri.Flags ImplicitFile;        // 0x0
        public static System.Uri.Flags MinimalUriInfoSet;        // 0x0
        public static System.Uri.Flags AllUriInfoSet;        // 0x0
        public static System.Uri.Flags IdnHost;        // 0x0
        public static System.Uri.Flags HasUnicode;        // 0x0
        public static System.Uri.Flags HostUnicodeNormalized;        // 0x0
        public static System.Uri.Flags RestUnicodeNormalized;        // 0x0
        public static System.Uri.Flags UnicodeHost;        // 0x0
        public static System.Uri.Flags IntranetUri;        // 0x0
        public static System.Uri.Flags UseOrigUncdStrOffset;        // 0x0
        public static System.Uri.Flags UserIriCanonical;        // 0x0
        public static System.Uri.Flags PathIriCanonical;        // 0x0
        public static System.Uri.Flags QueryIriCanonical;        // 0x0
        public static System.Uri.Flags FragmentIriCanonical;        // 0x0
        public static System.Uri.Flags IriCanonical;        // 0x0
        public static System.Uri.Flags CompressedSlashes;        // 0x0

    }

    // TypeToken: 0x20000BA
    public class UriInfo
    {
        // Fields
        public System.String Host;        // 0x10
        public System.String ScopeId;        // 0x18
        public System.String String;        // 0x20
        public System.Uri.Offset Offset;        // 0x28
        public System.String DnsSafeHost;        // 0x38
        public System.Uri.MoreInfo MoreInfo;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public struct Offset
    {
        // Fields
        public System.UInt16 Scheme;        // 0x10
        public System.UInt16 User;        // 0x12
        public System.UInt16 Host;        // 0x14
        public System.UInt16 PortValue;        // 0x16
        public System.UInt16 Path;        // 0x18
        public System.UInt16 Query;        // 0x1A
        public System.UInt16 Fragment;        // 0x1C
        public System.UInt16 End;        // 0x1E

    }

    // TypeToken: 0x20000BC
    public class MoreInfo
    {
        // Fields
        public System.String Path;        // 0x10
        public System.String Query;        // 0x18
        public System.String Fragment;        // 0x20
        public System.String AbsoluteUri;        // 0x28
        public System.Int32 Hash;        // 0x30
        public System.String RemoteUrl;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public struct Check
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Uri.Check None;        // 0x0
        public static System.Uri.Check EscapedCanonical;        // 0x0
        public static System.Uri.Check DisplayCanonical;        // 0x0
        public static System.Uri.Check DotSlashAttn;        // 0x0
        public static System.Uri.Check DotSlashEscaped;        // 0x0
        public static System.Uri.Check BackslashInPath;        // 0x0
        public static System.Uri.Check ReservedFound;        // 0x0
        public static System.Uri.Check NotIriCanonical;        // 0x0
        public static System.Uri.Check FoundNonAscii;        // 0x0

    }

    // TypeToken: 0x20000C8
    public struct UriQuirksVersion
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriParser.UriQuirksVersion V2;        // 0x0
        public static System.UriParser.UriQuirksVersion V3;        // 0x0

    }

    // TypeToken: 0x20000C9
    public class BuiltInUriParser : UriParser
    {
        // Methods
        private System.Void .ctor(System.String lwrCaseScheme, System.Int32 defaultPort, System.UriSyntaxFlags syntaxFlags) { }

    }

    // TypeToken: 0x20000D6
    public class Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private readonly System.Text.RegularExpressions.CaptureCollection _collection;        // 0x10
        private System.Int32 _index;        // 0x18

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.CaptureCollection collection) { }
        private System.Boolean MoveNext() { }
        private System.Text.RegularExpressions.Capture get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x20000DA
    public class Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private readonly System.Text.RegularExpressions.GroupCollection _collection;        // 0x10
        private System.Int32 _index;        // 0x18

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.GroupCollection collection) { }
        private System.Boolean MoveNext() { }
        private System.Text.RegularExpressions.Group get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x20000DE
    public class Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private readonly System.Text.RegularExpressions.MatchCollection _collection;        // 0x10
        private System.Int32 _index;        // 0x18

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.MatchCollection collection) { }
        private System.Boolean MoveNext() { }
        private System.Text.RegularExpressions.Match get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x20000E1
    public struct CachedCodeEntryKey, IEquatable`1
    {
        // Fields
        private readonly System.Text.RegularExpressions.RegexOptions _options;        // 0x10
        private readonly System.String _cultureKey;        // 0x18
        private readonly System.String _pattern;        // 0x20

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.RegexOptions options, System.String cultureKey, System.String pattern) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other) { }
        private System.Boolean op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20000E2
    public class CachedCodeEntry
    {
        // Fields
        public System.Text.RegularExpressions.Regex.CachedCodeEntry Next;        // 0x10
        public System.Text.RegularExpressions.Regex.CachedCodeEntry Previous;        // 0x18
        public readonly System.Text.RegularExpressions.Regex.CachedCodeEntryKey Key;        // 0x20
        public System.Text.RegularExpressions.RegexCode Code;        // 0x38
        public readonly System.Collections.Hashtable Caps;        // 0x40
        public readonly System.Collections.Hashtable Capnames;        // 0x48
        public readonly System.String[] Capslist;        // 0x50
        public readonly System.Int32 Capsize;        // 0x58
        public readonly System.Text.RegularExpressions.ExclusiveReference Runnerref;        // 0x60
        public readonly System.WeakReference<System.Text.RegularExpressions.RegexReplacement> ReplRef;        // 0x68

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, System.String[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, System.Int32 capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref) { }

    }

    // TypeToken: 0x20000E6
    public struct LowerCaseMapping
    {
        // Fields
        public readonly System.Char ChMin;        // 0x10
        public readonly System.Char ChMax;        // 0x12
        public readonly System.Int32 LcOp;        // 0x14
        public readonly System.Int32 Data;        // 0x18

        // Methods
        private System.Void .ctor(System.Char chMin, System.Char chMax, System.Int32 lcOp, System.Int32 data) { }

    }

    // TypeToken: 0x20000E7
    public class SingleRangeComparer, IComparer`1
    {
        // Fields
        public static readonly System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E8
    public struct SingleRange
    {
        // Fields
        public readonly System.Char First;        // 0x10
        public readonly System.Char Last;        // 0x12

        // Methods
        private System.Void .ctor(System.Char first, System.Char last) { }

    }

    // TypeToken: 0x20000FF
    public struct StreamReadMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Diagnostics.Process.StreamReadMode undefined;        // 0x0
        public static System.Diagnostics.Process.StreamReadMode syncMode;        // 0x0
        public static System.Diagnostics.Process.StreamReadMode asyncMode;        // 0x0

    }

    // TypeToken: 0x2000100
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Diagnostics.Process.State HaveId;        // 0x0
        public static System.Diagnostics.Process.State IsLocal;        // 0x0
        public static System.Diagnostics.Process.State IsNt;        // 0x0
        public static System.Diagnostics.Process.State HaveProcessInfo;        // 0x0
        public static System.Diagnostics.Process.State Exited;        // 0x0
        public static System.Diagnostics.Process.State Associated;        // 0x0
        public static System.Diagnostics.Process.State IsWin2k;        // 0x0
        public static System.Diagnostics.Process.State HaveNtProcessInfo;        // 0x0

    }

    // TypeToken: 0x2000101
    public struct ProcInfo
    {
        // Fields
        public System.IntPtr process_handle;        // 0x10
        public System.Int32 pid;        // 0x18
        public System.String[] envVariables;        // 0x20
        public System.String UserName;        // 0x28
        public System.String Domain;        // 0x30
        public System.IntPtr Password;        // 0x38
        public System.Boolean LoadUserProfile;        // 0x40

    }

    // TypeToken: 0x200010E
    public struct DerTag
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Security.Cryptography.DerSequenceReader.DerTag Boolean;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag Integer;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag BitString;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag OctetString;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag Null;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag ObjectIdentifier;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag UTF8String;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag Sequence;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag Set;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag PrintableString;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag T61String;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag IA5String;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag UTCTime;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag GeneralizedTime;        // 0x0
        public static System.Security.Cryptography.DerSequenceReader.DerTag BMPString;        // 0x0

    }

    // TypeToken: 0x200012C
    public class X509CertificateEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.IEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x200013F
    public struct StateFlags
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Net.ContextAwareResult.StateFlags None;        // 0x0
        public static System.Net.ContextAwareResult.StateFlags CaptureIdentity;        // 0x0
        public static System.Net.ContextAwareResult.StateFlags CaptureContext;        // 0x0
        public static System.Net.ContextAwareResult.StateFlags ThreadSafeContextCopy;        // 0x0
        public static System.Net.ContextAwareResult.StateFlags PostBlockStarted;        // 0x0
        public static System.Net.ContextAwareResult.StateFlags PostBlockFinished;        // 0x0

    }

    // TypeToken: 0x2000144
    public class Keywords
    {
        // Fields
        public static System.Diagnostics.Tracing.EventKeywords Default;        // 0x0
        public static System.Diagnostics.Tracing.EventKeywords Debug;        // 0x0
        public static System.Diagnostics.Tracing.EventKeywords EnterExit;        // 0x0

    }

    // TypeToken: 0x200014A
    public class ReadOnlyIPAddress : IPAddress
    {
        // Methods
        private System.Void .ctor(System.Int64 newAddress) { }

    }

    // TypeToken: 0x200014E
    public struct PipelineInstruction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.CommandStream.PipelineInstruction Abort;        // 0x0
        public static System.Net.CommandStream.PipelineInstruction Advance;        // 0x0
        public static System.Net.CommandStream.PipelineInstruction Pause;        // 0x0
        public static System.Net.CommandStream.PipelineInstruction Reread;        // 0x0
        public static System.Net.CommandStream.PipelineInstruction GiveStream;        // 0x0

    }

    // TypeToken: 0x200014F
    public struct PipelineEntryFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.CommandStream.PipelineEntryFlags UserCommand;        // 0x0
        public static System.Net.CommandStream.PipelineEntryFlags GiveDataStream;        // 0x0
        public static System.Net.CommandStream.PipelineEntryFlags CreateDataConnection;        // 0x0
        public static System.Net.CommandStream.PipelineEntryFlags DontLogParameter;        // 0x0

    }

    // TypeToken: 0x2000150
    public class PipelineEntry
    {
        // Fields
        private System.String Command;        // 0x10
        private System.Net.CommandStream.PipelineEntryFlags Flags;        // 0x18

        // Methods
        private System.Void .ctor(System.String command) { }
        private System.Void .ctor(System.String command, System.Net.CommandStream.PipelineEntryFlags flags) { }
        private System.Boolean HasFlag(System.Net.CommandStream.PipelineEntryFlags flags) { }

    }

    // TypeToken: 0x2000155
    public struct GetPathOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.FtpControlStream.GetPathOption Normal;        // 0x0
        public static System.Net.FtpControlStream.GetPathOption AssumeFilename;        // 0x0
        public static System.Net.FtpControlStream.GetPathOption AssumeNoFilename;        // 0x0

    }

    // TypeToken: 0x200015C
    public struct RequestStage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.FtpWebRequest.RequestStage CheckForError;        // 0x0
        public static System.Net.FtpWebRequest.RequestStage RequestStarted;        // 0x0
        public static System.Net.FtpWebRequest.RequestStage WriteReady;        // 0x0
        public static System.Net.FtpWebRequest.RequestStage ReadReady;        // 0x0
        public static System.Net.FtpWebRequest.RequestStage ReleaseConnection;        // 0x0

    }

    // TypeToken: 0x2000161
    public class EmptyStream : MemoryStream
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000181
    public struct RfcChar
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Net.WebHeaderCollection.RfcChar High;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar Reg;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar Ctl;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar CR;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar LF;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar WS;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar Colon;        // 0x0
        public static System.Net.WebHeaderCollection.RfcChar Delim;        // 0x0

    }

    // TypeToken: 0x2000184
    public class DesignerWebRequestCreate, IWebRequestCreate
    {
        // Methods
        private System.Net.WebRequest Create(System.Uri uri) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018F
    public class ThreadContext
    {
        // Fields
        private System.Int32 m_NestedIOCount;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000192
    public class Queue
    {
        // Fields
        private readonly System.Int32 m_DurationMilliseconds;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 durationMilliseconds) { }
        private System.Int32 get_Duration() { }
        private System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, System.Object context) { }

    }

    // TypeToken: 0x2000193
    public class Timer, IDisposable
    {
        // Fields
        private readonly System.Int32 m_StartTimeMilliseconds;        // 0x10
        private readonly System.Int32 m_DurationMilliseconds;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 durationMilliseconds) { }
        private System.Int32 get_StartTime() { }
        private System.Int32 get_Expiration() { }
        private System.Boolean Cancel() { }
        private System.Boolean get_HasExpired() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000194
    public class Callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Net.TimerThread.Timer timer, System.Int32 timeNoticed, System.Object context) { }

    }

    // TypeToken: 0x2000195
    public class TimerQueue : Queue
    {
        // Fields
        private System.IntPtr m_ThisHandle;        // 0x18
        private readonly System.Net.TimerThread.TimerNode m_Timers;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 durationMilliseconds) { }
        private System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, System.Object context) { }
        private System.Boolean Fire(System.Int32& nextExpiration) { }

    }

    // TypeToken: 0x2000196
    public class InfiniteTimerQueue : Queue
    {
        // Methods
        private System.Void .ctor() { }
        private System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, System.Object context) { }

    }

    // TypeToken: 0x2000198
    public struct TimerState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.TimerThread.TimerNode.TimerState Ready;        // 0x0
        public static System.Net.TimerThread.TimerNode.TimerState Fired;        // 0x0
        public static System.Net.TimerThread.TimerNode.TimerState Cancelled;        // 0x0
        public static System.Net.TimerThread.TimerNode.TimerState Sentinel;        // 0x0

    }

    // TypeToken: 0x2000197
    public class TimerNode : Timer
    {
        // Fields
        private System.Net.TimerThread.TimerNode.TimerState m_TimerState;        // 0x18
        private System.Net.TimerThread.Callback m_Callback;        // 0x20
        private System.Object m_Context;        // 0x28
        private System.Object m_QueueLock;        // 0x30
        private System.Net.TimerThread.TimerNode next;        // 0x38
        private System.Net.TimerThread.TimerNode prev;        // 0x40

        // Methods
        private System.Void .ctor(System.Net.TimerThread.Callback callback, System.Object context, System.Int32 durationMilliseconds, System.Object queueLock) { }
        private System.Void .ctor() { }
        private System.Boolean get_HasExpired() { }
        private System.Net.TimerThread.TimerNode get_Next() { }
        private System.Void set_Next(System.Net.TimerThread.TimerNode value) { }
        private System.Net.TimerThread.TimerNode get_Prev() { }
        private System.Void set_Prev(System.Net.TimerThread.TimerNode value) { }
        private System.Boolean Cancel() { }
        private System.Boolean Fire() { }

    }

    // TypeToken: 0x2000199
    public class InfiniteTimer : Timer
    {
        // Fields
        private System.Int32 cancelled;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_HasExpired() { }
        private System.Boolean Cancel() { }

    }

    // TypeToken: 0x200019E
    public struct RecognizedAttribute
    {
        // Fields
        private System.String m_name;        // 0x10
        private System.Net.CookieToken m_token;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.Net.CookieToken token) { }
        private System.Net.CookieToken get_Token() { }
        private System.Boolean IsEqualTo(System.String value) { }

    }

    // TypeToken: 0x20001A2
    public struct Stamp
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.CookieCollection.Stamp Check;        // 0x0
        public static System.Net.CookieCollection.Stamp Set;        // 0x0
        public static System.Net.CookieCollection.Stamp SetToUnused;        // 0x0
        public static System.Net.CookieCollection.Stamp SetToMaxUsed;        // 0x0

    }

    // TypeToken: 0x20001A3
    public class CookieCollectionEnumerator, IEnumerator
    {
        // Fields
        private System.Net.CookieCollection m_cookies;        // 0x10
        private System.Int32 m_count;        // 0x18
        private System.Int32 m_index;        // 0x1C
        private System.Int32 m_version;        // 0x20

        // Methods
        private System.Void .ctor(System.Net.CookieCollection cookies) { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20001A7
    public class PathListComparer, IComparer
    {
        // Fields
        private static readonly System.Net.PathList.PathListComparer StaticInstance;        // 0x0

        // Methods
        private System.Int32 System.Collections.IComparer.Compare(System.Object ol, System.Object or) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001B2
    public class HTTP_REQUEST_HEADER_ID
    {
        // Fields
        private static System.String[] m_Strings;        // 0x0

        // Methods
        private System.String ToString(System.Int32 position) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001B1
    public class HttpApi
    {
        // Fields
        private static System.String[] m_Strings;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001B3
    public class SecureStringHelper
    {
        // Methods
        private System.String CreateString(System.Security.SecureString secureString) { }
        private System.Security.SecureString CreateSecureString(System.String plainString) { }

    }

    // TypeToken: 0x20001B6
    public class CallbackContext
    {
        // Fields
        private readonly System.Object request;        // 0x10
        private readonly System.Security.Cryptography.X509Certificates.X509Certificate certificate;        // 0x18
        private readonly System.Security.Cryptography.X509Certificates.X509Chain chain;        // 0x20
        private readonly System.Net.Security.SslPolicyErrors sslPolicyErrors;        // 0x28
        private System.Boolean result;        // 0x2C

        // Methods
        private System.Void .ctor(System.Object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { }

    }

    // TypeToken: 0x20001BD
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.ContentDecodeStream.Mode GZip;        // 0x0
        public static System.Net.ContentDecodeStream.Mode Deflate;        // 0x0

    }

    // TypeToken: 0x20001C4
    public class GetHostAddressesCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Net.IPAddress[] Invoke(System.String hostName) { }
        private System.IAsyncResult BeginInvoke(System.String hostName, System.AsyncCallback callback, System.Object object) { }
        private System.Net.IPAddress[] EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C9
    public struct NtlmAuthState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.HttpWebRequest.NtlmAuthState None;        // 0x0
        public static System.Net.HttpWebRequest.NtlmAuthState Challenge;        // 0x0
        public static System.Net.HttpWebRequest.NtlmAuthState Response;        // 0x0

    }

    // TypeToken: 0x20001CA
    public struct AuthorizationState
    {
        // Fields
        private readonly System.Net.HttpWebRequest request;        // 0x10
        private readonly System.Boolean isProxy;        // 0x18
        private System.Boolean isCompleted;        // 0x19
        private System.Net.HttpWebRequest.NtlmAuthState ntlm_auth_state;        // 0x1C

        // Methods
        private System.Boolean get_IsCompleted() { }
        private System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }
        private System.Boolean get_IsNtlmAuthenticated() { }
        private System.Void .ctor(System.Net.HttpWebRequest request, System.Boolean isProxy) { }
        private System.Boolean CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code) { }
        private System.Void Reset() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20001D3
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.MonoChunkParser.State None;        // 0x0
        public static System.Net.MonoChunkParser.State PartialSize;        // 0x0
        public static System.Net.MonoChunkParser.State Body;        // 0x0
        public static System.Net.MonoChunkParser.State BodyFinished;        // 0x0
        public static System.Net.MonoChunkParser.State Trailer;        // 0x0

    }

    // TypeToken: 0x20001D4
    public class Chunk
    {
        // Fields
        public System.Byte[] Bytes;        // 0x10
        public System.Int32 Offset;        // 0x18

        // Methods
        private System.Void .ctor(System.Byte[] chunk) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }

    }

    // TypeToken: 0x20001DB
    public class SPKey
    {
        // Fields
        private System.Uri uri;        // 0x10
        private System.Uri proxy;        // 0x18
        private System.Boolean use_connect;        // 0x20

        // Methods
        private System.Void .ctor(System.Uri uri, System.Uri proxy, System.Boolean use_connect) { }
        private System.Boolean get_UsesProxy() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x20001DD
    public class ConnectionGroup
    {
        // Fields
        private readonly System.Net.ServicePointScheduler <Scheduler>k__BackingField;        // 0x10
        private readonly System.String <Name>k__BackingField;        // 0x18
        private static System.Int32 nextId;        // 0x0
        public readonly System.Int32 ID;        // 0x20
        private System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;        // 0x28
        private System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;        // 0x30

        // Methods
        private System.Net.ServicePointScheduler get_Scheduler() { }
        private System.Void .ctor(System.Net.ServicePointScheduler scheduler, System.String name) { }
        private System.Boolean IsEmpty() { }
        private System.Void RemoveConnection(System.Net.WebConnection connection) { }
        private System.Void Cleanup() { }
        private System.Void Close() { }
        private System.Void EnqueueOperation(System.Net.WebOperation operation) { }
        private System.Net.WebOperation GetNextOperation() { }
        private System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation) { }
        private System.ValueTuple<System.Net.WebConnection,System.Boolean> CreateOrReuseConnection(System.Net.WebOperation operation, System.Boolean force) { }

    }

    // TypeToken: 0x20001DE
    public class AsyncManualResetEvent
    {
        // Fields
        private System.Threading.Tasks.TaskCompletionSource<System.Boolean> m_tcs;        // 0x10

        // Methods
        private System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Int32 millisecondTimeout) { }
        private System.Void Set() { }
        private System.Void Reset() { }
        private System.Void .ctor(System.Boolean state) { }

    }

    // TypeToken: 0x20001E3
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static System.Net.WebCompletionSource.Status<T> Running;        // 0x0
        public static System.Net.WebCompletionSource.Status<T> Completed;        // 0x0
        public static System.Net.WebCompletionSource.Status<T> Canceled;        // 0x0
        public static System.Net.WebCompletionSource.Status<T> Faulted;        // 0x0

    }

    // TypeToken: 0x20001E4
    public class Result
    {
        // Fields
        private readonly System.Net.WebCompletionSource.Status<T> <Status>k__BackingField;        // 0x0
        private readonly System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;        // 0x0
        private readonly T <Argument>k__BackingField;        // 0x0

        // Methods
        private System.Net.WebCompletionSource.Status<T> get_Status() { }
        private System.Boolean get_Success() { }
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error() { }
        private T get_Argument() { }
        private System.Void .ctor(T argument) { }
        private System.Void .ctor(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error) { }

    }

    // TypeToken: 0x20001EF
    public struct NtlmAuthState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebConnectionTunnel.NtlmAuthState None;        // 0x0
        public static System.Net.WebConnectionTunnel.NtlmAuthState Challenge;        // 0x0
        public static System.Net.WebConnectionTunnel.NtlmAuthState Response;        // 0x0

    }

    // TypeToken: 0x2000239
    public class CachedEventArgs
    {
        // Fields
        public System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept;        // 0x10
        public System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskReceive;        // 0x18
        public System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskSend;        // 0x20
        public System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;        // 0x28
        public System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023A
    public class TaskSocketAsyncEventArgs`1 : SocketAsyncEventArgs
    {
        // Fields
        private System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder;        // 0x0
        private System.Boolean _accessed;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(System.Boolean& responsibleForReturningToPool) { }

    }

    // TypeToken: 0x200023B
    public class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs`1
    {
        // Fields
        private System.Boolean _wrapExceptionsInIOExceptions;        // 0xA0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023C
    public class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource`1
    {
        // Fields
        private static readonly System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs Reserved;        // 0x0
        private static readonly System.Action<System.Object> s_completedSentinel;        // 0x8
        private static readonly System.Action<System.Object> s_availableSentinel;        // 0x10
        private System.Action<System.Object> _continuation;        // 0x80
        private System.Threading.ExecutionContext _executionContext;        // 0x88
        private System.Object _scheduler;        // 0x90
        private System.Int16 _token;        // 0x98
        private System.Boolean <WrapExceptionsInIOExceptions>k__BackingField;        // 0x9A

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_WrapExceptionsInIOExceptions() { }
        private System.Void set_WrapExceptionsInIOExceptions(System.Boolean value) { }
        private System.Boolean Reserve() { }
        private System.Void Release() { }
        private System.Void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _) { }
        private System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Net.Sockets.Socket socket) { }
        private System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket) { }
        private System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(System.Int16 token) { }
        private System.Void OnCompleted(System.Action<System.Object> continuation, System.Object state, System.Int16 token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags) { }
        private System.Void InvokeContinuation(System.Action<System.Object> continuation, System.Object state, System.Boolean forceAsync) { }
        private System.Int32 GetResult(System.Int16 token) { }
        private System.Void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(System.Int16 token) { }
        private System.Void ThrowIncorrectTokenException() { }
        private System.Void ThrowMultipleContinuationsException() { }
        private System.Void ThrowException(System.Net.Sockets.SocketError error) { }
        private System.Exception CreateException(System.Net.Sockets.SocketError error) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200023E
    public struct WSABUF
    {
        // Fields
        public System.Int32 len;        // 0x10
        public System.IntPtr buf;        // 0x18

    }

    // TypeToken: 0x200025A
    public class Utf8MessageState
    {
        // Fields
        private System.Boolean SequenceInProgress;        // 0x10
        private System.Int32 AdditionalBytesExpected;        // 0x14
        private System.Int32 ExpectedValueMin;        // 0x18
        private System.Int32 CurrentDecodeBits;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025B
    public struct MessageOpcode
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Net.WebSockets.ManagedWebSocket.MessageOpcode Continuation;        // 0x0
        public static System.Net.WebSockets.ManagedWebSocket.MessageOpcode Text;        // 0x0
        public static System.Net.WebSockets.ManagedWebSocket.MessageOpcode Binary;        // 0x0
        public static System.Net.WebSockets.ManagedWebSocket.MessageOpcode Close;        // 0x0
        public static System.Net.WebSockets.ManagedWebSocket.MessageOpcode Ping;        // 0x0
        public static System.Net.WebSockets.ManagedWebSocket.MessageOpcode Pong;        // 0x0

    }

    // TypeToken: 0x200025C
    public struct MessageHeader
    {
        // Fields
        private System.Net.WebSockets.ManagedWebSocket.MessageOpcode Opcode;        // 0x10
        private System.Boolean Fin;        // 0x11
        private System.Int64 PayloadLength;        // 0x18
        private System.Int32 Mask;        // 0x20

    }

    // TypeToken: 0x200025D
    public interface IWebSocketReceiveResultGetter`1
    {
        // Methods
        private TResult GetResult(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, System.String closeDescription) { }

    }

    // TypeToken: 0x200025E
    public struct WebSocketReceiveResultGetter, IWebSocketReceiveResultGetter`1
    {
        // Methods
        private System.Net.WebSockets.WebSocketReceiveResult GetResult(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, System.String closeDescription) { }

    }

    // TypeToken: 0x200026C
    public struct InternalState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebSockets.ClientWebSocket.InternalState Created;        // 0x0
        public static System.Net.WebSockets.ClientWebSocket.InternalState Connecting;        // 0x0
        public static System.Net.WebSockets.ClientWebSocket.InternalState Connected;        // 0x0
        public static System.Net.WebSockets.ClientWebSocket.InternalState Disposed;        // 0x0

    }

    // TypeToken: 0x200026D
    public class DefaultWebProxy, IWebProxy
    {
        // Fields
        private static readonly System.Net.WebSockets.ClientWebSocket.DefaultWebProxy <Instance>k__BackingField;        // 0x0

        // Methods
        private System.Net.WebSockets.ClientWebSocket.DefaultWebProxy get_Instance() { }
        private System.Net.ICredentials get_Credentials() { }
        private System.Uri GetProxy(System.Uri destination) { }
        private System.Boolean IsBypassed(System.Uri host) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200029F
    public class ListEntry
    {
        // Fields
        private System.ComponentModel.EventHandlerList.ListEntry _next;        // 0x10
        private System.Object _key;        // 0x18
        private System.Delegate _handler;        // 0x20

    }

    // TypeToken: 0x20002A7
    public class ArrayPropertyDescriptor : SimplePropertyDescriptor
    {
        // Fields
        private readonly System.Int32 _index;        // 0x98

        // Methods
        private System.Void .ctor(System.Type arrayType, System.Type elementType, System.Int32 index) { }
        private System.Object GetValue(System.Object instance) { }
        private System.Void SetValue(System.Object instance, System.Object value) { }

    }

    // TypeToken: 0x20002A9
    public struct AttributeEntry
    {
        // Fields
        public System.Type type;        // 0x10
        public System.Int32 index;        // 0x18

    }

    // TypeToken: 0x20002B3
    public class CultureComparer, IComparer
    {
        // Fields
        private System.ComponentModel.CultureInfoConverter _converter;        // 0x10

        // Methods
        private System.Void .ctor(System.ComponentModel.CultureInfoConverter cultureConverter) { }
        private System.Int32 Compare(System.Object item1, System.Object item2) { }

    }

    // TypeToken: 0x20002B4
    public class CultureInfoMapper
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_cultureInfoNameMap;        // 0x0

        // Methods
        private System.Collections.Generic.Dictionary<System.String,System.String> CreateMap() { }
        private System.String GetCultureInfoName(System.String cultureInfoDisplayName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002C1
    public class ArraySubsetEnumerator, IEnumerator
    {
        // Fields
        private readonly System.Array _array;        // 0x10
        private readonly System.Int32 _total;        // 0x18
        private System.Int32 _current;        // 0x1C

        // Methods
        private System.Void .ctor(System.Array array, System.Int32 count) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Object get_Current() { }

    }

    // TypeToken: 0x20002D6
    public class PropertyDescriptorEnumerator, IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private System.ComponentModel.PropertyDescriptorCollection _owner;        // 0x10
        private System.Int32 _index;        // 0x18

        // Methods
        private System.Void .ctor(System.ComponentModel.PropertyDescriptorCollection owner) { }
        private System.Object get_Current() { }
        private System.Collections.DictionaryEntry get_Entry() { }
        private System.Object get_Key() { }
        private System.Object get_Value() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20002D9
    public class ReferenceComparer, IComparer
    {
        // Fields
        private System.ComponentModel.ReferenceConverter _converter;        // 0x10

        // Methods
        private System.Void .ctor(System.ComponentModel.ReferenceConverter converter) { }
        private System.Int32 Compare(System.Object item1, System.Object item2) { }

    }

    // TypeToken: 0x20002E3
    public class EmptyCustomTypeDescriptor : CustomTypeDescriptor
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FA
    public class ReflectedTypeData
    {
        // Fields
        private System.Type _type;        // 0x10
        private System.ComponentModel.AttributeCollection _attributes;        // 0x18
        private System.ComponentModel.EventDescriptorCollection _events;        // 0x20
        private System.ComponentModel.PropertyDescriptorCollection _properties;        // 0x28
        private System.ComponentModel.TypeConverter _converter;        // 0x30
        private System.Object[] _editors;        // 0x38
        private System.Type[] _editorTypes;        // 0x40
        private System.Int32 _editorCount;        // 0x48

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Boolean get_IsPopulated() { }
        private System.ComponentModel.AttributeCollection GetAttributes() { }
        private System.ComponentModel.TypeConverter GetConverter(System.Object instance) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties() { }
        private System.Type GetTypeFromName(System.String typeName) { }
        private System.Void Refresh() { }

    }

    // TypeToken: 0x20002FC
    public class SimplePropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private System.Type componentType;        // 0x88
        private System.Type propertyType;        // 0x90

        // Methods
        private System.Void .ctor(System.Type componentType, System.String name, System.Type propertyType) { }
        private System.Void .ctor(System.Type componentType, System.String name, System.Type propertyType, System.Attribute[] attributes) { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x20002FD
    public class StandardValuesCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.ICollection values;        // 0x10
        private System.Array valueArray;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.ICollection values) { }
        private System.Int32 get_Count() { }
        private System.Object get_Item(System.Int32 index) { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20002FF
    public class AttributeFilterCacheItem
    {
        // Fields
        private System.Attribute[] _filter;        // 0x10
        private System.Collections.ICollection FilteredMembers;        // 0x18

        // Methods
        private System.Void .ctor(System.Attribute[] filter, System.Collections.ICollection filteredMembers) { }
        private System.Boolean IsValid(System.Attribute[] filter) { }

    }

    // TypeToken: 0x2000300
    public class FilterCacheItem
    {
        // Fields
        private System.ComponentModel.Design.ITypeDescriptorFilterService _filterService;        // 0x10
        private System.Collections.ICollection FilteredMembers;        // 0x18

        // Methods
        private System.Void .ctor(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers) { }
        private System.Boolean IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService) { }

    }

    // TypeToken: 0x2000301
    public interface IUnimplemented
    {
    }

    // TypeToken: 0x2000302
    public class MemberDescriptorComparer, IComparer
    {
        // Fields
        public static readonly System.ComponentModel.TypeDescriptor.MemberDescriptorComparer Instance;        // 0x0

        // Methods
        private System.Int32 Compare(System.Object left, System.Object right) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000303
    public class MergedTypeDescriptor, ICustomTypeDescriptor
    {
        // Fields
        private System.ComponentModel.ICustomTypeDescriptor _primary;        // 0x10
        private System.ComponentModel.ICustomTypeDescriptor _secondary;        // 0x18

        // Methods
        private System.Void .ctor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary) { }
        private System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }
        private System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { }
        private System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }

    }

    // TypeToken: 0x2000305
    public struct DefaultExtendedTypeDescriptor, ICustomTypeDescriptor
    {
        // Fields
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;        // 0x10
        private System.Object _instance;        // 0x18

        // Methods
        private System.Void .ctor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Object instance) { }
        private System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }
        private System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { }
        private System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }

    }

    // TypeToken: 0x2000306
    public struct DefaultTypeDescriptor, ICustomTypeDescriptor
    {
        // Fields
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;        // 0x10
        private System.Type _objectType;        // 0x18
        private System.Object _instance;        // 0x20

        // Methods
        private System.Void .ctor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, System.Object instance) { }
        private System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }
        private System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { }
        private System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }

    }

    // TypeToken: 0x2000304
    public class TypeDescriptionNode : TypeDescriptionProvider
    {
        // Fields
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode Next;        // 0x20
        private System.ComponentModel.TypeDescriptionProvider Provider;        // 0x28

        // Methods
        private System.Void .ctor(System.ComponentModel.TypeDescriptionProvider provider) { }
        private System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { }
        private System.Collections.IDictionary GetCache(System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance) { }
        private System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance) { }
        private System.Type GetReflectionType(System.Type objectType, System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance) { }

    }

    // TypeToken: 0x2000307
    public class TypeDescriptorComObject
    {
    }

    // TypeToken: 0x2000308
    public class TypeDescriptorInterface
    {
    }

    // TypeToken: 0x200030E
    public class WeakKeyComparer, IEqualityComparer
    {
        // Methods
        private System.Boolean System.Collections.IEqualityComparer.Equals(System.Object x, System.Object y) { }
        private System.Int32 System.Collections.IEqualityComparer.GetHashCode(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000319
    public class WrappedPropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private System.Object target;        // 0x88
        private System.ComponentModel.PropertyDescriptor property;        // 0x90

        // Methods
        private System.Void .ctor(System.ComponentModel.PropertyDescriptor property, System.Object target) { }
        private System.ComponentModel.AttributeCollection get_Attributes() { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x2000318
    public class DesignerOptionCollection, ICollection
    {
        // Fields
        private System.ComponentModel.Design.DesignerOptionService _service;        // 0x10
        private System.String _name;        // 0x18
        private System.Object _value;        // 0x20
        private System.Collections.ArrayList _children;        // 0x28
        private System.ComponentModel.PropertyDescriptorCollection _properties;        // 0x30

        // Methods
        private System.Int32 get_Count() { }
        private System.String get_Name() { }
        private System.ComponentModel.PropertyDescriptorCollection get_Properties() { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Void EnsurePopulated() { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }

    }

    // TypeToken: 0x200031B
    public class OptionPropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection _option;        // 0x88

        // Methods
        private System.Void .ctor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option) { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x200031A
    public class DesignerOptionConverter : TypeConverter
    {
        // Methods
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, System.Object value, System.Attribute[] attributes) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000320
    public class SimpleMonitor, IDisposable
    {
        // Fields
        private System.Int32 _busyCount;        // 0x0
        private System.Collections.ObjectModel.ObservableCollection<T> _collection;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.ObjectModel.ObservableCollection<T> collection) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000325
    public class NodeEnumerator, IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.Specialized.ListDictionary _list;        // 0x10
        private System.Collections.Specialized.ListDictionary.DictionaryNode _current;        // 0x18
        private System.Int32 _version;        // 0x20
        private System.Boolean _start;        // 0x24

        // Methods
        private System.Void .ctor(System.Collections.Specialized.ListDictionary list) { }
        private System.Object get_Current() { }
        private System.Collections.DictionaryEntry get_Entry() { }
        private System.Object get_Key() { }
        private System.Object get_Value() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000327
    public class NodeKeyValueEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.Specialized.ListDictionary _list;        // 0x10
        private System.Collections.Specialized.ListDictionary.DictionaryNode _current;        // 0x18
        private System.Int32 _version;        // 0x20
        private System.Boolean _isKeys;        // 0x24
        private System.Boolean _start;        // 0x25

        // Methods
        private System.Void .ctor(System.Collections.Specialized.ListDictionary list, System.Boolean isKeys) { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000326
    public class NodeKeyValueCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.Specialized.ListDictionary _list;        // 0x10
        private System.Boolean _isKeys;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.Specialized.ListDictionary list, System.Boolean isKeys) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000328
    public class DictionaryNode
    {
        // Fields
        public System.Object key;        // 0x10
        public System.Object value;        // 0x18
        public System.Collections.Specialized.ListDictionary.DictionaryNode next;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032B
    public class OrderedDictionaryEnumerator, IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private System.Int32 _objectReturnType;        // 0x10
        private System.Collections.IEnumerator _arrayEnumerator;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.ArrayList array, System.Int32 objectReturnType) { }
        private System.Object get_Current() { }
        private System.Collections.DictionaryEntry get_Entry() { }
        private System.Object get_Key() { }
        private System.Object get_Value() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x200032C
    public class OrderedDictionaryKeyValueCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.ArrayList _objects;        // 0x10
        private System.Boolean _isKeys;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.ArrayList array, System.Boolean isKeys) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000336
    public class NameObjectEntry
    {
        // Fields
        private System.String Key;        // 0x10
        private System.Object Value;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.Object value) { }

    }

    // TypeToken: 0x2000337
    public class NameObjectKeysEnumerator, IEnumerator
    {
        // Fields
        private System.Int32 _pos;        // 0x10
        private System.Collections.Specialized.NameObjectCollectionBase _coll;        // 0x18
        private System.Int32 _version;        // 0x20

        // Methods
        private System.Void .ctor(System.Collections.Specialized.NameObjectCollectionBase coll) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Object get_Current() { }

    }

    // TypeToken: 0x2000338
    public class KeysCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.Specialized.NameObjectCollectionBase _coll;        // 0x10

        // Methods
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 get_Count() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200033D
    public class WorkStealingQueue
    {
        // Fields
        private System.Int32 _headIndex;        // 0x0
        private System.Int32 _tailIndex;        // 0x0
        private T[] _array;        // 0x0
        private System.Int32 _mask;        // 0x0
        private System.Int32 _addTakeCount;        // 0x0
        private System.Int32 _stealCount;        // 0x0
        private System.Int32 _currentOp;        // 0x0
        private System.Boolean _frozen;        // 0x0
        private readonly System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _nextQueue;        // 0x0
        private readonly System.Int32 _ownerThreadId;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> nextQueue) { }
        private System.Void LocalPush(T item, System.Int64& emptyToNonEmptyListTransitionCount) { }
        private System.Void LocalClear() { }
        private System.Boolean TrySteal(T& result, System.Boolean take) { }
        private System.Int32 DangerousCopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Int32 get_DangerousCount() { }

    }

    // TypeToken: 0x200033E
    public class Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private readonly T[] _array;        // 0x0
        private T _current;        // 0x0
        private System.Int32 _index;        // 0x0

        // Methods
        private System.Void .ctor(T[] array) { }
        private System.Boolean MoveNext() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000345
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
    {
        // Fields
        private System.Collections.Generic.LinkedList<T> _list;        // 0x0
        private System.Collections.Generic.LinkedListNode<T> _node;        // 0x0
        private System.Int32 _version;        // 0x0
        private T _current;        // 0x0
        private System.Int32 _index;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.LinkedList<T> list) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Void Dispose() { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender) { }

    }

    // TypeToken: 0x2000348
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator, IDictionaryEnumerator
    {
        // Fields
        private System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> _treeEnum;        // 0x0
        private System.Int32 _getEnumeratorRetType;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, System.Int32 getEnumeratorRetType) { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }
        private System.Boolean get_NotStartedOrEnded() { }
        private System.Void Reset() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Object System.Collections.IDictionaryEnumerator.get_Key() { }
        private System.Object System.Collections.IDictionaryEnumerator.get_Value() { }
        private System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

    }

    // TypeToken: 0x200034A
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private System.Collections.Generic.SortedDictionary.Enumerator<TKey,TValue> _dictEnum;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private TKey get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000349
    public class KeyCollection, ICollection`1, IEnumerable`1, IEnumerable, ICollection, IReadOnlyCollection`1
    {
        // Fields
        private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }
        private System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void CopyTo(TKey[] array, System.Int32 index) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
        private System.Void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
        private System.Void System.Collections.Generic.ICollection<TKey>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
        private System.Boolean System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }

    }

    // TypeToken: 0x200034E
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private System.Collections.Generic.SortedDictionary.Enumerator<TKey,TValue> _dictEnum;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private TValue get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200034D
    public class ValueCollection, ICollection`1, IEnumerable`1, IEnumerable, ICollection, IReadOnlyCollection`1
    {
        // Fields
        private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }
        private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void CopyTo(TValue[] array, System.Int32 index) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
        private System.Void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
        private System.Void System.Collections.Generic.ICollection<TValue>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
        private System.Boolean System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }

    }

    // TypeToken: 0x2000351
    public class KeyValuePairComparer : Comparer`1
    {
        // Fields
        private System.Collections.Generic.IComparer<TKey> keyComparer;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer) { }
        private System.Int32 Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y) { }

    }

    // TypeToken: 0x2000356
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator, IDictionaryEnumerator
    {
        // Fields
        private System.Collections.Generic.SortedList<TKey,TValue> _sortedList;        // 0x0
        private TKey _key;        // 0x0
        private TValue _value;        // 0x0
        private System.Int32 _index;        // 0x0
        private System.Int32 _version;        // 0x0
        private System.Int32 _getEnumeratorRetType;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, System.Int32 getEnumeratorRetType) { }
        private System.Void Dispose() { }
        private System.Object System.Collections.IDictionaryEnumerator.get_Key() { }
        private System.Boolean MoveNext() { }
        private System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
        private System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Object System.Collections.IDictionaryEnumerator.get_Value() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000357
    public class SortedListKeyEnumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private System.Collections.Generic.SortedList<TKey,TValue> _sortedList;        // 0x0
        private System.Int32 _index;        // 0x0
        private System.Int32 _version;        // 0x0
        private TKey _currentKey;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private TKey get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000358
    public class SortedListValueEnumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private System.Collections.Generic.SortedList<TKey,TValue> _sortedList;        // 0x0
        private System.Int32 _index;        // 0x0
        private System.Int32 _version;        // 0x0
        private TValue _currentValue;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private TValue get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000359
    public class KeyList, IList`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection
    {
        // Fields
        private System.Collections.Generic.SortedList<TKey,TValue> _dict;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void Add(TKey key) { }
        private System.Void Clear() { }
        private System.Boolean Contains(TKey key) { }
        private System.Void CopyTo(TKey[] array, System.Int32 arrayIndex) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Void Insert(System.Int32 index, TKey value) { }
        private TKey get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, TKey value) { }
        private System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 IndexOf(TKey key) { }
        private System.Boolean Remove(TKey key) { }
        private System.Void RemoveAt(System.Int32 index) { }

    }

    // TypeToken: 0x200035A
    public class ValueList, IList`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection
    {
        // Fields
        private System.Collections.Generic.SortedList<TKey,TValue> _dict;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void Add(TValue key) { }
        private System.Void Clear() { }
        private System.Boolean Contains(TValue value) { }
        private System.Void CopyTo(TValue[] array, System.Int32 arrayIndex) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Void Insert(System.Int32 index, TValue value) { }
        private TValue get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, TValue value) { }
        private System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 IndexOf(TValue value) { }
        private System.Boolean Remove(TValue value) { }
        private System.Void RemoveAt(System.Int32 index) { }

    }

    // TypeToken: 0x200035C
    public class Node
    {
        // Fields
        private T <Item>k__BackingField;        // 0x0
        private System.Collections.Generic.SortedSet.Node<T> <Left>k__BackingField;        // 0x0
        private System.Collections.Generic.SortedSet.Node<T> <Right>k__BackingField;        // 0x0
        private System.Collections.Generic.NodeColor <Color>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(T item, System.Collections.Generic.NodeColor color) { }
        private System.Boolean IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node) { }
        private System.Boolean IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node) { }
        private T get_Item() { }
        private System.Void set_Item(T value) { }
        private System.Collections.Generic.SortedSet.Node<T> get_Left() { }
        private System.Void set_Left(System.Collections.Generic.SortedSet.Node<T> value) { }
        private System.Collections.Generic.SortedSet.Node<T> get_Right() { }
        private System.Void set_Right(System.Collections.Generic.SortedSet.Node<T> value) { }
        private System.Collections.Generic.NodeColor get_Color() { }
        private System.Void set_Color(System.Collections.Generic.NodeColor value) { }
        private System.Boolean get_IsBlack() { }
        private System.Boolean get_IsRed() { }
        private System.Boolean get_Is2Node() { }
        private System.Boolean get_Is4Node() { }
        private System.Void ColorBlack() { }
        private System.Void ColorRed() { }
        private System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling) { }
        private System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node) { }
        private System.Void Split4Node() { }
        private System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation) { }
        private System.Collections.Generic.SortedSet.Node<T> RotateLeft() { }
        private System.Collections.Generic.SortedSet.Node<T> RotateLeftRight() { }
        private System.Collections.Generic.SortedSet.Node<T> RotateRight() { }
        private System.Collections.Generic.SortedSet.Node<T> RotateRightLeft() { }
        private System.Void Merge2Nodes() { }
        private System.Void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild) { }

    }

    // TypeToken: 0x200035D
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
    {
        // Fields
        private static readonly System.Collections.Generic.SortedSet.Node<T> s_dummyNode;        // 0x0
        private System.Collections.Generic.SortedSet<T> _tree;        // 0x0
        private System.Int32 _version;        // 0x0
        private System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack;        // 0x0
        private System.Collections.Generic.SortedSet.Node<T> _current;        // 0x0
        private System.Boolean _reverse;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.SortedSet<T> set) { }
        private System.Void .ctor(System.Collections.Generic.SortedSet<T> set, System.Boolean reverse) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender) { }
        private System.Void Initialize() { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean get_NotStartedOrEnded() { }
        private System.Void Reset() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200036A
    public class ReadMethod : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.IAsyncResult BeginInvoke(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200036B
    public class WriteMethod : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.IAsyncResult BeginInvoke(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200036D
    public class UnmanagedReadOrWrite : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.IntPtr buffer, System.Int32 length, System.IntPtr data) { }

    }

    // TypeToken: 0x200036E
    public class SafeDeflateStreamHandle : SafeHandle
    {
        // Methods
        private System.Boolean get_IsInvalid() { }
        private System.Void .ctor() { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000370
    public struct __StaticArrayInitTypeSize=6
    {
    }

    // TypeToken: 0x2000371
    public struct __StaticArrayInitTypeSize=9
    {
    }

    // TypeToken: 0x2000372
    public struct __StaticArrayInitTypeSize=10
    {
    }

    // TypeToken: 0x2000373
    public struct __StaticArrayInitTypeSize=12
    {
    }

    // TypeToken: 0x2000374
    public struct __StaticArrayInitTypeSize=14
    {
    }

    // TypeToken: 0x2000375
    public struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x2000376
    public struct __StaticArrayInitTypeSize=44
    {
    }

    // TypeToken: 0x2000377
    public struct __StaticArrayInitTypeSize=128
    {
    }

    // TypeToken: 0x2000378
    public struct __StaticArrayInitTypeSize=256
    {
    }

namespace Internal.Cryptography
{

    // TypeToken: 0x20000A9
    public class OidLookup
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String,System.String> s_lateBoundOidToFriendlyName;        // 0x0
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String,System.String> s_lateBoundFriendlyNameToOid;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_friendlyNameToOid;        // 0x10
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_oidToFriendlyName;        // 0x18
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_compatOids;        // 0x20

        // Methods
        private System.String ToFriendlyName(System.String oid, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups) { }
        private System.String ToOid(System.String friendlyName, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups) { }
        private System.Boolean ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup) { }
        private System.String NativeOidToFriendlyName(System.String oid, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups) { }
        private System.String NativeFriendlyNameToOid(System.String friendlyName, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups) { }
        private System.Void .cctor() { }

    }

}

namespace Internal.Cryptography.Pal
{

    // TypeToken: 0x20000AB
    public struct GeneralNameType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Internal.Cryptography.Pal.GeneralNameType OtherName;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType Rfc822Name;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType Email;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType DnsName;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType X400Address;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType DirectoryName;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType EdiPartyName;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType UniformResourceIdentifier;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType IPAddress;        // 0x0
        public static Internal.Cryptography.Pal.GeneralNameType RegisteredId;        // 0x0

    }

    // TypeToken: 0x20000AC
    public struct CertificateData
    {
        // Fields
        private System.Byte[] RawData;        // 0x10
        private System.Byte[] SubjectPublicKeyInfo;        // 0x18
        private System.Int32 Version;        // 0x20
        private System.Byte[] SerialNumber;        // 0x28
        private Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier TbsSignature;        // 0x30
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName Issuer;        // 0x40
        private System.DateTime NotBefore;        // 0x48
        private System.DateTime NotAfter;        // 0x50
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName Subject;        // 0x58
        private Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier PublicKeyAlgorithm;        // 0x60
        private System.Byte[] PublicKey;        // 0x70
        private System.Byte[] IssuerUniqueId;        // 0x78
        private System.Byte[] SubjectUniqueId;        // 0x80
        private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Extension> Extensions;        // 0x88
        private Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier SignatureAlgorithm;        // 0x90
        private System.Byte[] SignatureValue;        // 0xA0

        // Methods
        private System.Void .ctor(System.Byte[] rawData) { }
        private System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer) { }
        private System.String GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name) { }
        private System.String FindAltNameMatch(System.Byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, System.String otherOid) { }
        private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name) { }

    }

}

namespace Microsoft.Win32
{

    // TypeToken: 0x20000A7
    public class NativeMethods
    {
        // Methods
        private System.Boolean DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.SafeHandle hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, Microsoft.Win32.SafeHandles.SafeWaitHandle& targetHandle, System.Int32 dwDesiredAccess, System.Boolean bInheritHandle, System.Int32 dwOptions) { }
        private System.Boolean DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, Microsoft.Win32.SafeHandles.SafeProcessHandle& targetHandle, System.Int32 dwDesiredAccess, System.Boolean bInheritHandle, System.Int32 dwOptions) { }
        private System.IntPtr GetCurrentProcess() { }
        private System.Boolean GetExitCodeProcess(System.IntPtr processHandle, System.Int32& exitCode) { }
        private System.Boolean GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, System.Int32& exitCode) { }
        private System.Int32 GetCurrentProcessId() { }
        private System.Boolean CloseProcess(System.IntPtr handle) { }

    }

}

namespace Microsoft.Win32.SafeHandles
{

    // TypeToken: 0x20000A8
    public class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // Fields
        private static Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;        // 0x0

        // Methods
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Void .ctor(System.IntPtr existingHandle, System.Boolean ownsHandle) { }
        private System.Boolean ReleaseHandle() { }
        private System.Void .cctor() { }

    }

}

namespace Mono
{

    // TypeToken: 0x2000002
    public class SystemCertificateProvider, ISystemCertificateProvider
    {
        // Fields
        private static Mono.Security.Interface.MonoTlsProvider provider;        // 0x0
        private static System.Int32 initialized;        // 0x8
        private static Mono.X509PalImpl x509pal;        // 0x10
        private static System.Object syncRoot;        // 0x18

        // Methods
        private Mono.X509PalImpl GetX509Pal() { }
        private System.Void EnsureInitialized() { }
        private Mono.X509PalImpl get_X509Pal() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data, Mono.CertificateImportFlags importFlags) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000003
    public class SystemDependencyProvider, ISystemDependencyProvider
    {
        // Fields
        private static Mono.SystemDependencyProvider instance;        // 0x0
        private static System.Object syncRoot;        // 0x8
        private readonly Mono.SystemCertificateProvider <CertificateProvider>k__BackingField;        // 0x10

        // Methods
        private Mono.SystemDependencyProvider get_Instance() { }
        private System.Void Initialize() { }
        private Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }
        private Mono.SystemCertificateProvider get_CertificateProvider() { }
        private Mono.X509PalImpl get_X509Pal() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class X509Pal
    {
        // Methods
        private Mono.X509PalImpl get_Instance() { }

    }

    // TypeToken: 0x2000005
    public class X509PalImplMono : X509PalImpl
    {
        // Methods
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class X509PalImpl
    {
        // Fields
        private static System.Byte[] signedData;        // 0x0

        // Methods
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
        private System.Byte[] PEM(System.String type, System.Byte[] data) { }
        private System.Byte[] ConvertData(System.Byte[] data) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(System.Byte[] data) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        private System.Boolean get_SupportsLegacyBasicConstraintsExtension() { }
        private System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(System.Byte[] rawData) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace Mono.Btls
{

    // TypeToken: 0x2000068
    public class MonoBtlsBio : MonoBtlsObject
    {
        // Methods
        private System.Void .ctor(Mono.Btls.MonoBtlsBio.BoringBioHandle handle) { }
        private Mono.Btls.MonoBtlsBio.BoringBioHandle get_Handle() { }
        private System.Void mono_btls_bio_free(System.IntPtr handle) { }

    }

    // TypeToken: 0x200006A
    public class MonoBtlsBioMemory : MonoBtlsBio
    {
        // Methods
        private System.IntPtr mono_btls_bio_mem_new() { }
        private System.Int32 mono_btls_bio_mem_get_data(System.IntPtr handle, System.IntPtr& data) { }
        private System.Void .ctor() { }
        private System.Byte[] GetData() { }

    }

    // TypeToken: 0x200006B
    public interface IMonoBtlsBioMono
    {
        // Methods
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean& wantMore) { }
        private System.Boolean Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Flush() { }
        private System.Void Close() { }

    }

    // TypeToken: 0x200006C
    public class MonoBtlsBioMono : MonoBtlsBio
    {
        // Fields
        private System.Runtime.InteropServices.GCHandle handle;        // 0x20
        private System.IntPtr instance;        // 0x28
        private Mono.Btls.MonoBtlsBioMono.BioReadFunc readFunc;        // 0x30
        private Mono.Btls.MonoBtlsBioMono.BioWriteFunc writeFunc;        // 0x38
        private Mono.Btls.MonoBtlsBioMono.BioControlFunc controlFunc;        // 0x40
        private System.IntPtr readFuncPtr;        // 0x48
        private System.IntPtr writeFuncPtr;        // 0x50
        private System.IntPtr controlFuncPtr;        // 0x58
        private Mono.Btls.IMonoBtlsBioMono backend;        // 0x60

        // Methods
        private System.Void .ctor(Mono.Btls.IMonoBtlsBioMono backend) { }
        private System.IntPtr mono_btls_bio_mono_new() { }
        private System.Void mono_btls_bio_mono_initialize(System.IntPtr handle, System.IntPtr instance, System.IntPtr readFunc, System.IntPtr writeFunc, System.IntPtr controlFunc) { }
        private System.Int64 Control(Mono.Btls.MonoBtlsBioMono.ControlCommand command, System.Int64 arg) { }
        private System.Int32 OnRead(System.IntPtr data, System.Int32 dataLength, System.Int32& wantMore) { }
        private System.Int32 OnRead(System.IntPtr instance, System.IntPtr data, System.Int32 dataLength, System.Int32& wantMore) { }
        private System.Int32 OnWrite(System.IntPtr data, System.Int32 dataLength) { }
        private System.Int32 OnWrite(System.IntPtr instance, System.IntPtr data, System.Int32 dataLength) { }
        private System.Int64 Control(System.IntPtr instance, Mono.Btls.MonoBtlsBioMono.ControlCommand command, System.Int64 arg) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x2000071
    public class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate;        // 0x58
        private System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate;        // 0x60
        private Mono.Btls.X509CertificateImplBtls nativeServerCertificate;        // 0x68
        private Mono.Btls.X509CertificateImplBtls nativeClientCertificate;        // 0x70
        private Mono.Btls.MonoBtlsSslCtx ctx;        // 0x78
        private Mono.Btls.MonoBtlsSsl ssl;        // 0x80
        private Mono.Btls.MonoBtlsBio bio;        // 0x88
        private Mono.Btls.MonoBtlsBio errbio;        // 0x90
        private Mono.Security.Interface.MonoTlsConnectionInfo connectionInfo;        // 0x98
        private System.Boolean certificateValidated;        // 0xA0
        private System.Boolean isAuthenticated;        // 0xA1
        private System.Boolean connected;        // 0xA2

        // Methods
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options) { }
        private Mono.Btls.X509CertificateImplBtls GetPrivateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        private System.Int32 VerifyCallback(Mono.Btls.MonoBtlsX509StoreCtx storeCtx) { }
        private System.Int32 SelectCallback(System.String[] acceptableIssuers) { }
        private System.Int32 ServerNameCallback() { }
        private System.Void StartHandshake() { }
        private System.Void SetPrivateCertificate(Mono.Btls.X509CertificateImplBtls privateCert) { }
        private System.Exception GetException(Mono.Btls.MonoBtlsSslError status) { }
        private System.Boolean ProcessHandshake() { }
        private Mono.Btls.MonoBtlsSslError DoProcessHandshake() { }
        private System.Void FinishHandshake() { }
        private System.Void InitializeConnection() { }
        private System.Void GetPeerCertificate() { }
        private System.Void InitializeSession() { }
        private Mono.Security.Interface.TlsProtocols GetProtocol(Mono.Security.Interface.TlsProtocolCode protocol) { }
        private System.Void Flush() { }
        private System.ValueTuple<System.Int32,System.Boolean> Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.ValueTuple<System.Int32,System.Boolean> Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Renegotiate() { }
        private System.Void Shutdown() { }
        private System.Boolean PendingRenegotiation() { }
        private System.Void Dispose(T& disposable) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int32 Mono.Btls.IMonoBtlsBioMono.Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean& wantMore) { }
        private System.Boolean Mono.Btls.IMonoBtlsBioMono.Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Mono.Btls.IMonoBtlsBioMono.Flush() { }
        private System.Void Mono.Btls.IMonoBtlsBioMono.Close() { }
        private System.Boolean get_IsAuthenticated() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate() { }

    }

    // TypeToken: 0x2000072
    public class MonoBtlsError
    {
        // Methods
        private System.Void mono_btls_error_clear_error() { }
        private System.Int32 mono_btls_error_get_error_line(System.IntPtr& file, System.Int32& line) { }
        private System.Void mono_btls_error_get_error_string_n(System.Int32 error, System.IntPtr buf, System.Int32 len) { }
        private System.Int32 mono_btls_error_get_reason(System.Int32 error) { }
        private System.Void ClearError() { }
        private System.String GetErrorString(System.Int32 error) { }
        private System.Int32 GetError(System.String& file, System.Int32& line) { }
        private System.Int32 GetErrorReason(System.Int32 error) { }

    }

    // TypeToken: 0x2000073
    public class MonoBtlsException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsSslError error) { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String format, System.Object[] args) { }

    }

    // TypeToken: 0x2000074
    public class MonoBtlsKey : MonoBtlsObject
    {
        // Methods
        private System.IntPtr mono_btls_key_new() { }
        private System.Void mono_btls_key_free(System.IntPtr handle) { }
        private System.IntPtr mono_btls_key_up_ref(System.IntPtr handle) { }
        private System.Int32 mono_btls_key_get_bytes(System.IntPtr handle, System.IntPtr& data, System.Int32& size, System.Int32 include_private_bits) { }
        private System.Int32 mono_btls_key_assign_rsa_private_key(System.IntPtr handle, System.Byte[] der, System.Int32 der_length) { }
        private Mono.Btls.MonoBtlsKey.BoringKeyHandle get_Handle() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsKey.BoringKeyHandle handle) { }
        private System.Byte[] GetBytes(System.Boolean include_private_bits) { }
        private Mono.Btls.MonoBtlsKey Copy() { }
        private Mono.Btls.MonoBtlsKey CreateFromRSAPrivateKey(System.Security.Cryptography.RSA privateKey) { }

    }

    // TypeToken: 0x2000076
    public class MonoBtlsObject, IDisposable
    {
        // Fields
        private Mono.Btls.MonoBtlsObject.MonoBtlsHandle handle;        // 0x10
        private System.Exception lastError;        // 0x18

        // Methods
        private System.Void .ctor(Mono.Btls.MonoBtlsObject.MonoBtlsHandle handle) { }
        private Mono.Btls.MonoBtlsObject.MonoBtlsHandle get_Handle() { }
        private System.Boolean get_IsValid() { }
        private System.Void CheckThrow() { }
        private System.Exception SetException(System.Exception ex) { }
        private System.Void CheckError(System.Boolean ok, System.String callerName) { }
        private System.Void CheckError(System.Int32 ret, System.String callerName) { }
        private System.Void CheckLastError(System.String callerName) { }
        private System.Void mono_btls_free(System.IntPtr data) { }
        private System.Void FreeDataPtr(System.IntPtr data) { }
        private System.Void Close() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x2000078
    public class MonoBtlsPkcs12 : MonoBtlsObject
    {
        // Fields
        private Mono.Btls.MonoBtlsKey privateKey;        // 0x20

        // Methods
        private Mono.Btls.MonoBtlsPkcs12.BoringPkcs12Handle get_Handle() { }
        private System.Void mono_btls_pkcs12_free(System.IntPtr handle) { }
        private System.IntPtr mono_btls_pkcs12_new() { }
        private System.Int32 mono_btls_pkcs12_get_count(System.IntPtr handle) { }
        private System.IntPtr mono_btls_pkcs12_get_cert(System.IntPtr Handle, System.Int32 index) { }
        private System.Int32 mono_btls_pkcs12_import(System.IntPtr chain, System.Void* data, System.Int32 len, Microsoft.Win32.SafeHandles.SafePasswordHandle password) { }
        private System.Int32 mono_btls_pkcs12_has_private_key(System.IntPtr pkcs12) { }
        private System.IntPtr mono_btls_pkcs12_get_private_key(System.IntPtr pkcs12) { }
        private System.Void .ctor() { }
        private System.Int32 get_Count() { }
        private Mono.Btls.MonoBtlsX509 GetCertificate(System.Int32 index) { }
        private System.Void Import(System.Byte[] buffer, Microsoft.Win32.SafeHandles.SafePasswordHandle password) { }
        private System.Boolean get_HasPrivateKey() { }
        private Mono.Btls.MonoBtlsKey GetPrivateKey() { }

    }

    // TypeToken: 0x200007A
    public class MonoBtlsProvider : MobileTlsProvider
    {
        // Methods
        private System.Guid get_ID() { }
        private System.String get_Name() { }
        private System.Void .ctor() { }
        private System.Boolean get_SupportsSslStream() { }
        private System.Boolean get_SupportsMonoExtensions() { }
        private System.Boolean get_SupportsConnectionInfo() { }
        private System.Boolean get_SupportsCleanShutdown() { }
        private System.Security.Authentication.SslProtocols get_SupportedProtocols() { }
        private Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl GetNativeCertificate(System.Byte[] data, System.String password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags flags) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl GetNativeCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl GetNativeCertificate(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags flags) { }
        private Mono.Btls.MonoBtlsX509VerifyParam GetVerifyParam(Mono.Security.Interface.MonoTlsSettings settings, System.String targetHost, System.Boolean serverMode) { }
        private System.Boolean ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11) { }
        private System.Boolean ValidateCertificate(Mono.Btls.MonoBtlsX509Chain chain, Mono.Btls.MonoBtlsX509VerifyParam param) { }
        private System.Void CheckValidationResult(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Btls.MonoBtlsX509StoreCtx storeCtx, System.Boolean success, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11) { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags MapVerifyErrorToChainStatus(Mono.Btls.MonoBtlsX509Error code) { }
        private System.Void SetupCertificateStore(Mono.Btls.MonoBtlsX509Store store, Mono.Security.Interface.MonoTlsSettings settings, System.Boolean server) { }
        private System.Void SetupDefaultCertificateStore(Mono.Btls.MonoBtlsX509Store store) { }
        private System.Void AddUserStore(Mono.Btls.MonoBtlsX509Store store) { }
        private System.Void AddMachineStore(Mono.Btls.MonoBtlsX509Store store) { }
        private System.Void AddTrustedRoots(Mono.Btls.MonoBtlsX509Store store, Mono.Security.Interface.MonoTlsSettings settings, System.Boolean server) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 CreateCertificate(Mono.Btls.MonoBtlsX509 x509) { }
        private System.Security.Cryptography.X509Certificates.X509Chain GetManagedChain(Mono.Btls.MonoBtlsX509Chain chain) { }
        private Mono.Btls.MonoBtlsX509 GetBtlsCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        private Mono.Btls.MonoBtlsX509Chain GetNativeChain(System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates) { }

    }

    // TypeToken: 0x200007B
    public class MonoBtlsVerifyCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(Mono.Btls.MonoBtlsX509StoreCtx ctx) { }

    }

    // TypeToken: 0x200007C
    public class MonoBtlsSelectCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x200007D
    public class MonoBtlsServerNameCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke() { }

    }

    // TypeToken: 0x200007E
    public class MonoBtlsSsl : MonoBtlsObject
    {
        // Fields
        private Mono.Btls.MonoBtlsBio bio;        // 0x20
        private Mono.Btls.MonoBtlsSsl.PrintErrorsCallbackFunc printErrorsFunc;        // 0x28
        private System.IntPtr printErrorsFuncPtr;        // 0x30

        // Methods
        private System.Void mono_btls_ssl_destroy(System.IntPtr handle) { }
        private System.IntPtr mono_btls_ssl_new(System.IntPtr handle) { }
        private System.Int32 mono_btls_ssl_use_certificate(System.IntPtr handle, System.IntPtr x509) { }
        private System.Int32 mono_btls_ssl_use_private_key(System.IntPtr handle, System.IntPtr key) { }
        private System.Int32 mono_btls_ssl_add_chain_certificate(System.IntPtr handle, System.IntPtr x509) { }
        private System.Int32 mono_btls_ssl_accept(System.IntPtr handle) { }
        private System.Int32 mono_btls_ssl_connect(System.IntPtr handle) { }
        private System.Int32 mono_btls_ssl_handshake(System.IntPtr handle) { }
        private System.Void mono_btls_ssl_close(System.IntPtr handle) { }
        private System.Int32 mono_btls_ssl_shutdown(System.IntPtr handle) { }
        private System.Void mono_btls_ssl_set_quiet_shutdown(System.IntPtr handle, System.Int32 mode) { }
        private System.Void mono_btls_ssl_set_bio(System.IntPtr handle, System.IntPtr bio) { }
        private System.Int32 mono_btls_ssl_read(System.IntPtr handle, System.IntPtr data, System.Int32 len) { }
        private System.Int32 mono_btls_ssl_write(System.IntPtr handle, System.IntPtr data, System.Int32 len) { }
        private System.Int32 mono_btls_ssl_get_error(System.IntPtr handle, System.Int32 ret_code) { }
        private System.Int32 mono_btls_ssl_get_version(System.IntPtr handle) { }
        private System.Int32 mono_btls_ssl_get_cipher(System.IntPtr handle) { }
        private System.IntPtr mono_btls_ssl_get_peer_certificate(System.IntPtr handle) { }
        private System.Void mono_btls_ssl_print_errors_cb(System.IntPtr func, System.IntPtr ctx) { }
        private System.Int32 mono_btls_ssl_set_server_name(System.IntPtr handle, System.IntPtr name) { }
        private System.IntPtr mono_btls_ssl_get_server_name(System.IntPtr handle) { }
        private System.Void mono_btls_ssl_set_renegotiate_mode(System.IntPtr handle, System.Int32 mode) { }
        private System.Int32 mono_btls_ssl_renegotiate_pending(System.IntPtr handle) { }
        private Mono.Btls.MonoBtlsSsl.BoringSslHandle Create_internal(Mono.Btls.MonoBtlsSslCtx ctx) { }
        private System.Void .ctor(Mono.Btls.MonoBtlsSslCtx ctx) { }
        private Mono.Btls.MonoBtlsSsl.BoringSslHandle get_Handle() { }
        private System.Void SetBio(Mono.Btls.MonoBtlsBio bio) { }
        private System.Exception ThrowError(System.String callerName) { }
        private Mono.Btls.MonoBtlsSslError GetError(System.Int32 ret_code) { }
        private System.Void SetCertificate(Mono.Btls.MonoBtlsX509 x509) { }
        private System.Void SetPrivateKey(Mono.Btls.MonoBtlsKey key) { }
        private System.Void AddIntermediateCertificate(Mono.Btls.MonoBtlsX509 x509) { }
        private Mono.Btls.MonoBtlsSslError Accept() { }
        private Mono.Btls.MonoBtlsSslError Connect() { }
        private Mono.Btls.MonoBtlsSslError Handshake() { }
        private System.Int32 PrintErrorsCallback(System.IntPtr str, System.IntPtr len, System.IntPtr ctx) { }
        private System.String GetErrors() { }
        private System.Void PrintErrors() { }
        private Mono.Btls.MonoBtlsSslError Read(System.IntPtr data, System.Int32& dataSize) { }
        private Mono.Btls.MonoBtlsSslError Write(System.IntPtr data, System.Int32& dataSize) { }
        private System.Int32 GetVersion() { }
        private System.Int32 GetCipher() { }
        private Mono.Btls.MonoBtlsX509 GetPeerCertificate() { }
        private System.Void SetServerName(System.String name) { }
        private System.String GetServerName() { }
        private System.Void Shutdown() { }
        private System.Void SetQuietShutdown() { }
        private System.Void Close() { }
        private System.Void SetRenegotiateMode(Mono.Btls.MonoBtlsSslRenegotiateMode mode) { }
        private System.Boolean RenegotiatePending() { }

    }

    // TypeToken: 0x2000081
    public class MonoBtlsSslCtx : MonoBtlsObject
    {
        // Fields
        private Mono.Btls.MonoBtlsSslCtx.NativeVerifyFunc verifyFunc;        // 0x20
        private Mono.Btls.MonoBtlsSslCtx.NativeSelectFunc selectFunc;        // 0x28
        private Mono.Btls.MonoBtlsSslCtx.NativeServerNameFunc serverNameFunc;        // 0x30
        private System.IntPtr verifyFuncPtr;        // 0x38
        private System.IntPtr selectFuncPtr;        // 0x40
        private System.IntPtr serverNameFuncPtr;        // 0x48
        private Mono.Btls.MonoBtlsVerifyCallback verifyCallback;        // 0x50
        private Mono.Btls.MonoBtlsSelectCallback selectCallback;        // 0x58
        private Mono.Btls.MonoBtlsServerNameCallback serverNameCallback;        // 0x60
        private Mono.Btls.MonoBtlsX509Store store;        // 0x68
        private System.Runtime.InteropServices.GCHandle instance;        // 0x70
        private System.IntPtr instancePtr;        // 0x78

        // Methods
        private Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle get_Handle() { }
        private System.IntPtr mono_btls_ssl_ctx_new() { }
        private System.Int32 mono_btls_ssl_ctx_free(System.IntPtr handle) { }
        private System.Void mono_btls_ssl_ctx_initialize(System.IntPtr handle, System.IntPtr instance) { }
        private System.Void mono_btls_ssl_ctx_set_cert_verify_callback(System.IntPtr handle, System.IntPtr func, System.Int32 cert_required) { }
        private System.Void mono_btls_ssl_ctx_set_cert_select_callback(System.IntPtr handle, System.IntPtr func) { }
        private System.Void mono_btls_ssl_ctx_set_min_version(System.IntPtr handle, System.Int32 version) { }
        private System.Void mono_btls_ssl_ctx_set_max_version(System.IntPtr handle, System.Int32 version) { }
        private System.Int32 mono_btls_ssl_ctx_set_ciphers(System.IntPtr handle, System.Int32 count, System.IntPtr data, System.Int32 allow_unsupported) { }
        private System.Int32 mono_btls_ssl_ctx_set_verify_param(System.IntPtr handle, System.IntPtr param) { }
        private System.Int32 mono_btls_ssl_ctx_set_client_ca_list(System.IntPtr handle, System.Int32 count, System.IntPtr sizes, System.IntPtr data) { }
        private System.Void mono_btls_ssl_ctx_set_server_name_callback(System.IntPtr handle, System.IntPtr func) { }
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle handle) { }
        private Mono.Btls.MonoBtlsX509Store get_CertificateStore() { }
        private System.Int32 VerifyCallback(System.Boolean preverify_ok, Mono.Btls.MonoBtlsX509StoreCtx ctx) { }
        private System.Int32 NativeVerifyCallback(System.IntPtr instance, System.Int32 preverify_ok, System.IntPtr store_ctx) { }
        private System.Int32 NativeSelectCallback(System.IntPtr instance, System.Int32 count, System.IntPtr sizes, System.IntPtr data) { }
        private System.String[] CopyIssuers(System.Int32 count, System.IntPtr sizesPtr, System.IntPtr dataPtr) { }
        private System.Void SetVerifyCallback(Mono.Btls.MonoBtlsVerifyCallback callback, System.Boolean client_cert_required) { }
        private System.Void SetSelectCallback(Mono.Btls.MonoBtlsSelectCallback callback) { }
        private System.Void SetMinVersion(System.Int32 version) { }
        private System.Void SetMaxVersion(System.Int32 version) { }
        private System.Void SetCiphers(System.Int16[] ciphers, System.Boolean allow_unsupported) { }
        private System.Void SetVerifyParam(Mono.Btls.MonoBtlsX509VerifyParam param) { }
        private System.Void SetClientCertificateIssuers(System.String[] acceptableIssuers) { }
        private System.Void SetServerNameCallback(Mono.Btls.MonoBtlsServerNameCallback callback) { }
        private System.Int32 NativeServerNameCallback(System.IntPtr instance) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x2000086
    public struct MonoBtlsSslError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsSslError None;        // 0x0
        public static Mono.Btls.MonoBtlsSslError Ssl;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantRead;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantWrite;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantX509Lookup;        // 0x0
        public static Mono.Btls.MonoBtlsSslError Syscall;        // 0x0
        public static Mono.Btls.MonoBtlsSslError ZeroReturn;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantConnect;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantAccept;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantChannelIdLookup;        // 0x0
        public static Mono.Btls.MonoBtlsSslError PendingSession;        // 0x0
        public static Mono.Btls.MonoBtlsSslError PendingCertificate;        // 0x0
        public static Mono.Btls.MonoBtlsSslError WantPrivateKeyOperation;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct MonoBtlsSslRenegotiateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsSslRenegotiateMode NEVER;        // 0x0
        public static Mono.Btls.MonoBtlsSslRenegotiateMode ONCE;        // 0x0
        public static Mono.Btls.MonoBtlsSslRenegotiateMode FREELY;        // 0x0
        public static Mono.Btls.MonoBtlsSslRenegotiateMode IGNORE;        // 0x0

    }

    // TypeToken: 0x2000088
    public class MonoBtlsStream : MobileAuthenticatedStream
    {
        // Methods
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider) { }
        private Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options) { }

    }

    // TypeToken: 0x2000089
    public class MonoBtlsUtils
    {
        // Fields
        private static System.Byte[] emailOid;        // 0x0

        // Methods
        private System.Boolean Compare(System.Byte[] a, System.Byte[] b) { }
        private System.Boolean AppendEntry(System.Text.StringBuilder sb, Mono.Btls.MonoBtlsX509Name name, System.Int32 index, System.String separator, System.Boolean quotes) { }
        private System.String FormatName(Mono.Btls.MonoBtlsX509Name name, System.Boolean reversed, System.String separator, System.Boolean quotes) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008A
    public class MonoBtlsX509 : MonoBtlsObject
    {
        // Methods
        private Mono.Btls.MonoBtlsX509.BoringX509Handle get_Handle() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509.BoringX509Handle handle) { }
        private System.IntPtr mono_btls_x509_up_ref(System.IntPtr handle) { }
        private System.IntPtr mono_btls_x509_from_data(System.IntPtr data, System.Int32 len, Mono.Btls.MonoBtlsX509Format format) { }
        private System.IntPtr mono_btls_x509_get_subject_name(System.IntPtr handle) { }
        private System.Int32 mono_btls_x509_get_raw_data(System.IntPtr handle, System.IntPtr bio, Mono.Btls.MonoBtlsX509Format format) { }
        private System.Int32 mono_btls_x509_cmp(System.IntPtr a, System.IntPtr b) { }
        private System.Void mono_btls_x509_free(System.IntPtr handle) { }
        private System.Int32 mono_btls_x509_add_explicit_trust(System.IntPtr handle, Mono.Btls.MonoBtlsX509TrustKind kind) { }
        private Mono.Btls.MonoBtlsX509 Copy() { }
        private Mono.Btls.MonoBtlsX509 LoadFromData(System.Byte[] buffer, Mono.Btls.MonoBtlsX509Format format) { }
        private Mono.Btls.MonoBtlsX509Name GetSubjectName() { }
        private System.Int64 GetSubjectNameHash() { }
        private System.Byte[] GetRawData(Mono.Btls.MonoBtlsX509Format format) { }
        private System.Int32 Compare(Mono.Btls.MonoBtlsX509 a, Mono.Btls.MonoBtlsX509 b) { }
        private System.Void AddExplicitTrust(Mono.Btls.MonoBtlsX509TrustKind kind) { }

    }

    // TypeToken: 0x200008C
    public class MonoBtlsX509Chain : MonoBtlsObject
    {
        // Methods
        private Mono.Btls.MonoBtlsX509Chain.BoringX509ChainHandle get_Handle() { }
        private System.IntPtr mono_btls_x509_chain_new() { }
        private System.Int32 mono_btls_x509_chain_get_count(System.IntPtr handle) { }
        private System.IntPtr mono_btls_x509_chain_get_cert(System.IntPtr Handle, System.Int32 index) { }
        private System.Int32 mono_btls_x509_chain_add_cert(System.IntPtr chain, System.IntPtr x509) { }
        private System.IntPtr mono_btls_x509_chain_up_ref(System.IntPtr handle) { }
        private System.Void mono_btls_x509_chain_free(System.IntPtr handle) { }
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509Chain.BoringX509ChainHandle handle) { }
        private System.Int32 get_Count() { }
        private Mono.Btls.MonoBtlsX509 GetCertificate(System.Int32 index) { }
        private System.Void AddCertificate(Mono.Btls.MonoBtlsX509 x509) { }
        private Mono.Btls.MonoBtlsX509Chain Copy() { }

    }

    // TypeToken: 0x200008E
    public struct MonoBtlsX509Error
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509Error OK;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_GET_ISSUER_CERT;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_GET_CRL;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_DECRYPT_CERT_SIGNATURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_DECRYPT_CRL_SIGNATURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_DECODE_ISSUER_PUBLIC_KEY;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_SIGNATURE_FAILURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CRL_SIGNATURE_FAILURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_NOT_YET_VALID;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_HAS_EXPIRED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CRL_NOT_YET_VALID;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CRL_HAS_EXPIRED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error ERROR_IN_CERT_NOT_BEFORE_FIELD;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error ERROR_IN_CERT_NOT_AFTER_FIELD;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error ERROR_IN_CRL_LAST_UPDATE_FIELD;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error ERROR_IN_CRL_NEXT_UPDATE_FIELD;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error OUT_OF_MEM;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error DEPTH_ZERO_SELF_SIGNED_CERT;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SELF_SIGNED_CERT_IN_CHAIN;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_GET_ISSUER_CERT_LOCALLY;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_VERIFY_LEAF_SIGNATURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_CHAIN_TOO_LONG;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_REVOKED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error INVALID_CA;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error PATH_LENGTH_EXCEEDED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error INVALID_PURPOSE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_UNTRUSTED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CERT_REJECTED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUBJECT_ISSUER_MISMATCH;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error AKID_SKID_MISMATCH;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error AKID_ISSUER_SERIAL_MISMATCH;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error KEYUSAGE_NO_CERTSIGN;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNABLE_TO_GET_CRL_ISSUER;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNHANDLED_CRITICAL_EXTENSION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error KEYUSAGE_NO_CRL_SIGN;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNHANDLED_CRITICAL_CRL_EXTENSION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error INVALID_NON_CA;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error PROXY_PATH_LENGTH_EXCEEDED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error KEYUSAGE_NO_DIGITAL_SIGNATURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error PROXY_CERTIFICATES_NOT_ALLOWED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error INVALID_EXTENSION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error INVALID_POLICY_EXTENSION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error NO_EXPLICIT_POLICY;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error DIFFERENT_CRL_SCOPE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNSUPPORTED_EXTENSION_FEATURE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNNESTED_RESOURCE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error PERMITTED_VIOLATION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error EXCLUDED_VIOLATION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUBTREE_MINMAX;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNSUPPORTED_CONSTRAINT_TYPE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNSUPPORTED_CONSTRAINT_SYNTAX;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error UNSUPPORTED_NAME_SYNTAX;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error CRL_PATH_VALIDATION_ERROR;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUITE_B_INVALID_VERSION;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUITE_B_INVALID_ALGORITHM;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUITE_B_INVALID_CURVE;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUITE_B_INVALID_SIGNATURE_ALGORITHM;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUITE_B_LOS_NOT_ALLOWED;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error SUITE_B_CANNOT_SIGN_P_384_WITH_P_256;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error HOSTNAME_MISMATCH;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error EMAIL_MISMATCH;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error IP_ADDRESS_MISMATCH;        // 0x0
        public static Mono.Btls.MonoBtlsX509Error APPLICATION_VERIFICATION;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct MonoBtlsX509FileType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509FileType PEM;        // 0x0
        public static Mono.Btls.MonoBtlsX509FileType ASN1;        // 0x0
        public static Mono.Btls.MonoBtlsX509FileType DEFAULT;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct MonoBtlsX509Format
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509Format DER;        // 0x0
        public static Mono.Btls.MonoBtlsX509Format PEM;        // 0x0

    }

    // TypeToken: 0x2000091
    public class MonoBtlsX509Lookup : MonoBtlsObject
    {
        // Fields
        private Mono.Btls.MonoBtlsX509Store store;        // 0x20
        private Mono.Btls.MonoBtlsX509LookupType type;        // 0x28
        private System.Collections.Generic.List<Mono.Btls.MonoBtlsX509LookupMono> monoLookups;        // 0x30

        // Methods
        private Mono.Btls.MonoBtlsX509Lookup.BoringX509LookupHandle get_Handle() { }
        private System.IntPtr mono_btls_x509_lookup_new(System.IntPtr store, Mono.Btls.MonoBtlsX509LookupType type) { }
        private System.Int32 mono_btls_x509_lookup_add_dir(System.IntPtr handle, System.IntPtr dir, Mono.Btls.MonoBtlsX509FileType type) { }
        private System.Int32 mono_btls_x509_lookup_add_mono(System.IntPtr handle, System.IntPtr monoLookup) { }
        private System.Void mono_btls_x509_lookup_free(System.IntPtr handle) { }
        private System.IntPtr mono_btls_x509_lookup_peek_lookup(System.IntPtr handle) { }
        private Mono.Btls.MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(Mono.Btls.MonoBtlsX509Store store, Mono.Btls.MonoBtlsX509LookupType type) { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509Store store, Mono.Btls.MonoBtlsX509LookupType type) { }
        private System.IntPtr GetNativeLookup() { }
        private System.Void AddDirectory(System.String dir, Mono.Btls.MonoBtlsX509FileType type) { }
        private System.Void AddMono(Mono.Btls.MonoBtlsX509LookupMono monoLookup) { }
        private System.Void AddCertificate(Mono.Btls.MonoBtlsX509 certificate) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x2000093
    public class MonoBtlsX509LookupMono : MonoBtlsObject
    {
        // Fields
        private System.Runtime.InteropServices.GCHandle gch;        // 0x20
        private System.IntPtr instance;        // 0x28
        private Mono.Btls.MonoBtlsX509LookupMono.BySubjectFunc bySubjectFunc;        // 0x30
        private System.IntPtr bySubjectFuncPtr;        // 0x38
        private Mono.Btls.MonoBtlsX509Lookup lookup;        // 0x40

        // Methods
        private Mono.Btls.MonoBtlsX509LookupMono.BoringX509LookupMonoHandle get_Handle() { }
        private System.IntPtr mono_btls_x509_lookup_mono_new() { }
        private System.Void mono_btls_x509_lookup_mono_init(System.IntPtr handle, System.IntPtr instance, System.IntPtr by_subject_func) { }
        private System.Int32 mono_btls_x509_lookup_mono_free(System.IntPtr handle) { }
        private System.Void .ctor() { }
        private System.Void Install(Mono.Btls.MonoBtlsX509Lookup lookup) { }
        private System.Void AddCertificate(Mono.Btls.MonoBtlsX509 certificate) { }
        private Mono.Btls.MonoBtlsX509 OnGetBySubject(Mono.Btls.MonoBtlsX509Name name) { }
        private System.Int32 OnGetBySubject(System.IntPtr instance, System.IntPtr name_ptr, System.IntPtr& x509_ptr) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x2000096
    public class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
    {
        // Fields
        private System.Int64[] hashes;        // 0x48
        private Mono.Btls.MonoBtlsX509[] certificates;        // 0x50
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection collection;        // 0x58
        private Mono.Btls.MonoBtlsX509TrustKind trust;        // 0x60

        // Methods
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateCollection collection, Mono.Btls.MonoBtlsX509TrustKind trust) { }
        private System.Void Initialize() { }
        private Mono.Btls.MonoBtlsX509 OnGetBySubject(Mono.Btls.MonoBtlsX509Name name) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x2000097
    public struct MonoBtlsX509LookupType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509LookupType UNKNOWN;        // 0x0
        public static Mono.Btls.MonoBtlsX509LookupType FILE;        // 0x0
        public static Mono.Btls.MonoBtlsX509LookupType HASH_DIR;        // 0x0
        public static Mono.Btls.MonoBtlsX509LookupType MONO;        // 0x0

    }

    // TypeToken: 0x2000098
    public class MonoBtlsX509Name : MonoBtlsObject
    {
        // Methods
        private System.Int64 mono_btls_x509_name_hash(System.IntPtr handle) { }
        private System.Int32 mono_btls_x509_name_get_entry_count(System.IntPtr handle) { }
        private Mono.Btls.MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(System.IntPtr name, System.Int32 index) { }
        private System.Int32 mono_btls_x509_name_get_entry_oid(System.IntPtr name, System.Int32 index, System.IntPtr buffer, System.Int32 size) { }
        private System.Int32 mono_btls_x509_name_get_entry_oid_data(System.IntPtr name, System.Int32 index, System.IntPtr& data) { }
        private System.Int32 mono_btls_x509_name_get_entry_value(System.IntPtr name, System.Int32 index, System.Int32& tag, System.IntPtr& str) { }
        private System.IntPtr mono_btls_x509_name_from_data(System.Void* data, System.Int32 len, System.Int32 use_canon_enc) { }
        private System.Void mono_btls_x509_name_free(System.IntPtr handle) { }
        private Mono.Btls.MonoBtlsX509Name.BoringX509NameHandle get_Handle() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509Name.BoringX509NameHandle handle) { }
        private System.Int64 GetHash() { }
        private System.Int32 GetEntryCount() { }
        private Mono.Btls.MonoBtlsX509NameEntryType GetEntryType(System.Int32 index) { }
        private System.String GetEntryOid(System.Int32 index) { }
        private System.Byte[] GetEntryOidData(System.Int32 index) { }
        private System.String GetEntryValue(System.Int32 index, System.Int32& tag) { }
        private Mono.Btls.MonoBtlsX509Name CreateFromData(System.Byte[] data, System.Boolean use_canon_enc) { }

    }

    // TypeToken: 0x200009A
    public struct MonoBtlsX509NameEntryType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509NameEntryType Unknown;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType CountryName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType OrganizationName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType OrganizationalUnitName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType CommonName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType LocalityName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType StateOrProvinceName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType StreetAddress;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType SerialNumber;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType DomainComponent;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType UserId;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType Email;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType DnQualifier;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType Title;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType Surname;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType GivenName;        // 0x0
        public static Mono.Btls.MonoBtlsX509NameEntryType Initial;        // 0x0

    }

    // TypeToken: 0x200009B
    public class MonoBtlsX509Store : MonoBtlsObject
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash;        // 0x20

        // Methods
        private Mono.Btls.MonoBtlsX509Store.BoringX509StoreHandle get_Handle() { }
        private System.IntPtr mono_btls_x509_store_new() { }
        private System.IntPtr mono_btls_x509_store_from_ssl_ctx(System.IntPtr handle) { }
        private System.Int32 mono_btls_x509_store_add_cert(System.IntPtr handle, System.IntPtr x509) { }
        private System.Void mono_btls_x509_store_free(System.IntPtr handle) { }
        private Mono.Btls.MonoBtlsX509Store.BoringX509StoreHandle Create_internal() { }
        private Mono.Btls.MonoBtlsX509Store.BoringX509StoreHandle Create_internal(Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle ctx) { }
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle ctx) { }
        private System.Void AddCertificate(Mono.Btls.MonoBtlsX509 x509) { }
        private Mono.Btls.MonoBtlsX509Lookup AddLookup(Mono.Btls.MonoBtlsX509LookupType type) { }
        private System.Void AddDirectoryLookup(System.String dir, Mono.Btls.MonoBtlsX509FileType type) { }
        private System.Void AddCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection collection, Mono.Btls.MonoBtlsX509TrustKind trust) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x200009D
    public class MonoBtlsX509StoreCtx : MonoBtlsObject
    {
        // Fields
        private System.Nullable<System.Int32> verifyResult;        // 0x20

        // Methods
        private Mono.Btls.MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle get_Handle() { }
        private System.IntPtr mono_btls_x509_store_ctx_new() { }
        private System.IntPtr mono_btls_x509_store_ctx_from_ptr(System.IntPtr ctx) { }
        private Mono.Btls.MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(System.IntPtr handle, System.IntPtr& error_string) { }
        private System.IntPtr mono_btls_x509_store_ctx_get_chain(System.IntPtr handle) { }
        private System.Int32 mono_btls_x509_store_ctx_init(System.IntPtr handle, System.IntPtr store, System.IntPtr chain) { }
        private System.Int32 mono_btls_x509_store_ctx_set_param(System.IntPtr handle, System.IntPtr param) { }
        private System.Int32 mono_btls_x509_store_ctx_verify_cert(System.IntPtr handle) { }
        private System.IntPtr mono_btls_x509_store_ctx_get_untrusted(System.IntPtr handle) { }
        private System.IntPtr mono_btls_x509_store_ctx_up_ref(System.IntPtr handle) { }
        private System.Void mono_btls_x509_store_ctx_free(System.IntPtr handle) { }
        private System.Void .ctor() { }
        private Mono.Btls.MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(System.IntPtr store_ctx) { }
        private System.Void .ctor(System.Int32 preverify_ok, System.IntPtr store_ctx) { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult) { }
        private Mono.Btls.MonoBtlsX509Error GetError() { }
        private Mono.Btls.MonoBtlsX509Chain GetChain() { }
        private Mono.Btls.MonoBtlsX509Chain GetUntrusted() { }
        private System.Void Initialize(Mono.Btls.MonoBtlsX509Store store, Mono.Btls.MonoBtlsX509Chain chain) { }
        private System.Void SetVerifyParam(Mono.Btls.MonoBtlsX509VerifyParam param) { }
        private System.Int32 get_VerifyResult() { }
        private System.Int32 Verify() { }
        private Mono.Btls.MonoBtlsX509StoreCtx Copy() { }

    }

    // TypeToken: 0x200009F
    public class MonoBtlsX509StoreManager
    {
        // Fields
        private static System.Boolean initialized;        // 0x0
        private static System.String machineTrustedRootPath;        // 0x8
        private static System.String machineIntermediateCAPath;        // 0x10
        private static System.String machineUntrustedPath;        // 0x18
        private static System.String userTrustedRootPath;        // 0x20
        private static System.String userIntermediateCAPath;        // 0x28
        private static System.String userUntrustedPath;        // 0x30

        // Methods
        private System.Void Initialize() { }
        private System.Void DoInitialize() { }
        private System.String GetStorePath(Mono.Btls.MonoBtlsX509StoreType type) { }

    }

    // TypeToken: 0x20000A0
    public struct MonoBtlsX509StoreType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509StoreType Custom;        // 0x0
        public static Mono.Btls.MonoBtlsX509StoreType MachineTrustedRoots;        // 0x0
        public static Mono.Btls.MonoBtlsX509StoreType MachineIntermediateCA;        // 0x0
        public static Mono.Btls.MonoBtlsX509StoreType MachineUntrusted;        // 0x0
        public static Mono.Btls.MonoBtlsX509StoreType UserTrustedRoots;        // 0x0
        public static Mono.Btls.MonoBtlsX509StoreType UserIntermediateCA;        // 0x0
        public static Mono.Btls.MonoBtlsX509StoreType UserUntrusted;        // 0x0

    }

    // TypeToken: 0x20000A1
    public struct MonoBtlsX509TrustKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Btls.MonoBtlsX509TrustKind DEFAULT;        // 0x0
        public static Mono.Btls.MonoBtlsX509TrustKind TRUST_CLIENT;        // 0x0
        public static Mono.Btls.MonoBtlsX509TrustKind TRUST_SERVER;        // 0x0
        public static Mono.Btls.MonoBtlsX509TrustKind TRUST_ALL;        // 0x0
        public static Mono.Btls.MonoBtlsX509TrustKind REJECT_CLIENT;        // 0x0
        public static Mono.Btls.MonoBtlsX509TrustKind REJECT_SERVER;        // 0x0
        public static Mono.Btls.MonoBtlsX509TrustKind REJECT_ALL;        // 0x0

    }

    // TypeToken: 0x20000A2
    public class MonoBtlsX509VerifyParam : MonoBtlsObject
    {
        // Methods
        private Mono.Btls.MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle get_Handle() { }
        private System.IntPtr mono_btls_x509_verify_param_copy(System.IntPtr handle) { }
        private System.IntPtr mono_btls_x509_verify_param_lookup(System.IntPtr name) { }
        private System.Int32 mono_btls_x509_verify_param_can_modify(System.IntPtr param) { }
        private System.Int32 mono_btls_x509_verify_param_set_host(System.IntPtr handle, System.IntPtr name, System.Int32 namelen) { }
        private System.Int32 mono_btls_x509_verify_param_set_time(System.IntPtr handle, System.Int64 time) { }
        private System.Void mono_btls_x509_verify_param_free(System.IntPtr handle) { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle) { }
        private Mono.Btls.MonoBtlsX509VerifyParam Copy() { }
        private Mono.Btls.MonoBtlsX509VerifyParam GetSslClient() { }
        private Mono.Btls.MonoBtlsX509VerifyParam GetSslServer() { }
        private Mono.Btls.MonoBtlsX509VerifyParam Lookup(System.String name, System.Boolean fail) { }
        private System.Boolean get_CanModify() { }
        private System.Void WantToModify() { }
        private System.Void SetHost(System.String name) { }
        private System.Void SetTime(System.DateTime time) { }

    }

    // TypeToken: 0x20000A4
    public class X509CertificateImplBtls : X509Certificate2ImplUnix
    {
        // Fields
        private Mono.Btls.MonoBtlsX509 x509;        // 0xB0
        private Mono.Btls.MonoBtlsKey nativePrivateKey;        // 0xB8
        private System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;        // 0xC0

        // Methods
        private System.Void .ctor(Mono.Btls.MonoBtlsX509 x509) { }
        private System.Void .ctor(Mono.Btls.X509CertificateImplBtls other) { }
        private System.Void .ctor(System.Byte[] data, Mono.Btls.MonoBtlsX509Format format) { }
        private System.Void .ctor(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        private System.Boolean get_IsValid() { }
        private Mono.Btls.MonoBtlsX509 get_X509() { }
        private Mono.Btls.MonoBtlsKey get_NativePrivateKey() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone() { }
        private System.Byte[] GetRawCertData() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_HasPrivateKey() { }
        private System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey() { }
        private System.Void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value) { }
        private System.Security.Cryptography.RSA GetRSAPrivateKey() { }
        private System.Security.Cryptography.DSA GetDSAPrivateKey() { }
        private System.Void Import(System.Byte[] data) { }
        private System.Void ImportPkcs12(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password) { }
        private System.Void ImportAuthenticode(System.Byte[] data) { }
        private System.Boolean Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate) { }

    }

    // TypeToken: 0x20000A5
    public class X509ChainImplBtls : X509ChainImpl
    {
        // Fields
        private Mono.Btls.MonoBtlsX509StoreCtx storeCtx;        // 0x10
        private Mono.Btls.MonoBtlsX509Chain chain;        // 0x18
        private Mono.Btls.MonoBtlsX509Chain untrustedChain;        // 0x20
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;        // 0x28
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection untrusted;        // 0x30
        private System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates;        // 0x38
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;        // 0x40
        private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;        // 0x48

        // Methods
        private System.Void .ctor(Mono.Btls.MonoBtlsX509Chain chain) { }
        private System.Void .ctor(Mono.Btls.MonoBtlsX509StoreCtx storeCtx) { }
        private System.Boolean get_IsValid() { }
        private Mono.Btls.MonoBtlsX509StoreCtx get_StoreCtx() { }
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements() { }
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy() { }
        private System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode) { }
        private System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void Reset() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20000A6
    public class X509PalImplBtls : X509PalImpl
    {
        // Fields
        private readonly Mono.Btls.MonoBtlsProvider <Provider>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(Mono.Security.Interface.MonoTlsProvider provider) { }
        private Mono.Btls.MonoBtlsProvider get_Provider() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }

    }

}

namespace Mono.Http
{

    // TypeToken: 0x2000065
    public class NtlmSession
    {
        // Fields
        private Mono.Security.Protocol.Ntlm.MessageBase message;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }

    }

    // TypeToken: 0x2000066
    public class NtlmClient, IAuthenticationModule
    {
        // Fields
        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache;        // 0x0

        // Methods
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.String get_AuthenticationType() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace Mono.Net.Security
{

    // TypeToken: 0x2000043
    public class BufferOffsetSize
    {
        // Fields
        public System.Byte[] Buffer;        // 0x10
        public System.Int32 Offset;        // 0x18
        public System.Int32 Size;        // 0x1C
        public System.Int32 TotalBytes;        // 0x20
        public System.Boolean Complete;        // 0x24

        // Methods
        private System.Int32 get_EndOffset() { }
        private System.Int32 get_Remaining() { }
        private System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000044
    public class BufferOffsetSize2 : BufferOffsetSize
    {
        // Fields
        public readonly System.Int32 InitialSize;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 size) { }
        private System.Void Reset() { }
        private System.Void MakeRoom(System.Int32 size) { }
        private System.Void AppendData(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }

    }

    // TypeToken: 0x2000045
    public struct AsyncOperationStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Net.Security.AsyncOperationStatus Initialize;        // 0x0
        public static Mono.Net.Security.AsyncOperationStatus Continue;        // 0x0
        public static Mono.Net.Security.AsyncOperationStatus ReadDone;        // 0x0
        public static Mono.Net.Security.AsyncOperationStatus Complete;        // 0x0

    }

    // TypeToken: 0x2000046
    public class AsyncProtocolResult
    {
        // Fields
        private readonly System.Int32 <UserResult>k__BackingField;        // 0x10
        private readonly System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;        // 0x18

        // Methods
        private System.Int32 get_UserResult() { }
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error() { }
        private System.Void .ctor(System.Int32 result) { }
        private System.Void .ctor(System.Runtime.ExceptionServices.ExceptionDispatchInfo error) { }

    }

    // TypeToken: 0x2000047
    public class AsyncProtocolRequest
    {
        // Fields
        private readonly Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField;        // 0x10
        private readonly System.Boolean <RunSynchronously>k__BackingField;        // 0x18
        private System.Int32 <UserResult>k__BackingField;        // 0x1C
        private System.Int32 Started;        // 0x20
        private System.Int32 RequestedSize;        // 0x24
        private System.Int32 WriteRequested;        // 0x28
        private readonly System.Object locker;        // 0x30

        // Methods
        private Mono.Net.Security.MobileAuthenticatedStream get_Parent() { }
        private System.Boolean get_RunSynchronously() { }
        private System.String get_Name() { }
        private System.Int32 get_UserResult() { }
        private System.Void set_UserResult(System.Int32 value) { }
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync) { }
        private System.Void RequestRead(System.Int32 size) { }
        private System.Void RequestWrite() { }
        private System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(System.Threading.CancellationToken cancellationToken) { }
        private Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004B
    public class AsyncHandshakeRequest : AsyncProtocolRequest
    {
        // Methods
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync) { }
        private Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status) { }

    }

    // TypeToken: 0x200004C
    public class AsyncReadOrWriteRequest : AsyncProtocolRequest
    {
        // Fields
        private readonly Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;        // 0x38
        private System.Int32 <CurrentSize>k__BackingField;        // 0x40

        // Methods
        private Mono.Net.Security.BufferOffsetSize get_UserBuffer() { }
        private System.Int32 get_CurrentSize() { }
        private System.Void set_CurrentSize(System.Int32 value) { }
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync, System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004D
    public class AsyncReadRequest : AsyncReadOrWriteRequest
    {
        // Methods
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync, System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status) { }

    }

    // TypeToken: 0x200004E
    public class AsyncWriteRequest : AsyncReadOrWriteRequest
    {
        // Methods
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync, System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status) { }

    }

    // TypeToken: 0x200004F
    public class ChainValidationHelper, ICertificateValidator
    {
        // Fields
        private readonly System.WeakReference<System.Net.Security.SslStream> owner;        // 0x10
        private readonly Mono.Security.Interface.MonoTlsSettings settings;        // 0x18
        private readonly Mono.Net.Security.MobileTlsProvider provider;        // 0x20
        private readonly System.Net.ServerCertValidationCallback certValidationCallback;        // 0x28
        private readonly System.Net.Security.LocalCertSelectionCallback certSelectionCallback;        // 0x30
        private readonly Mono.Net.Security.MonoTlsStream tlsStream;        // 0x38
        private readonly System.Net.HttpWebRequest request;        // 0x40

        // Methods
        private Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings) { }
        private Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings& settings, Mono.Net.Security.MonoTlsStream stream) { }
        private System.Void .ctor(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, System.Boolean cloneSettings, Mono.Net.Security.MonoTlsStream stream) { }
        private System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }
        private Mono.Security.Interface.MonoTlsSettings get_Settings() { }
        private System.Boolean SelectClientCertificate(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers, System.Security.Cryptography.X509Certificates.X509Certificate& clientCertificate) { }
        private Mono.Security.Interface.ValidationResult ValidateCertificate(System.String host, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain) { }
        private Mono.Security.Interface.ValidationResult ValidateChain(System.String host, System.Boolean server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors) { }
        private Mono.Security.Interface.ValidationResult ValidateChain(System.String host, System.Boolean server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors) { }
        private System.Boolean InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors) { }

    }

    // TypeToken: 0x2000051
    public class MobileAuthenticatedStream : AuthenticatedStream, IDisposable
    {
        // Fields
        private Mono.Net.Security.MobileTlsContext xobileTlsContext;        // 0x38
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo lastException;        // 0x40
        private Mono.Net.Security.AsyncProtocolRequest asyncHandshakeRequest;        // 0x48
        private Mono.Net.Security.AsyncProtocolRequest asyncReadRequest;        // 0x50
        private Mono.Net.Security.AsyncProtocolRequest asyncWriteRequest;        // 0x58
        private Mono.Net.Security.BufferOffsetSize2 readBuffer;        // 0x60
        private Mono.Net.Security.BufferOffsetSize2 writeBuffer;        // 0x68
        private System.Object ioLock;        // 0x70
        private System.Int32 closeRequested;        // 0x78
        private System.Boolean shutdown;        // 0x7C
        private Mono.Net.Security.MobileAuthenticatedStream.Operation operation;        // 0x80
        private static System.Int32 uniqueNameInteger;        // 0x0
        private readonly System.Net.Security.SslStream <SslStream>k__BackingField;        // 0x88
        private readonly Mono.Security.Interface.MonoTlsSettings <Settings>k__BackingField;        // 0x90
        private readonly Mono.Net.Security.MobileTlsProvider <Provider>k__BackingField;        // 0x98
        private System.String <TargetHost>k__BackingField;        // 0xA0
        private static System.Int32 nextId;        // 0x4
        private readonly System.Int32 ID;        // 0xA8

        // Methods
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider) { }
        private System.Net.Security.SslStream get_SslStream() { }
        private Mono.Security.Interface.MonoTlsSettings get_Settings() { }
        private Mono.Net.Security.MobileTlsProvider get_Provider() { }
        private System.String get_TargetHost() { }
        private System.Void set_TargetHost(System.String value) { }
        private System.Void CheckThrow(System.Boolean authSuccessCheck, System.Boolean shutdownCheck) { }
        private System.Exception GetSSPIException(System.Exception e) { }
        private System.Exception GetIOException(System.Exception e, System.String message) { }
        private System.Exception GetInternalError() { }
        private System.Exception GetInvalidNestedCallException() { }
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e) { }
        private System.Void AuthenticateAsClient(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation) { }
        private System.Threading.Tasks.Task AuthenticateAsClientAsync(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation) { }
        private System.Threading.Tasks.Task ProcessAuthentication(System.Boolean runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken) { }
        private Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Int32> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken) { }
        private System.Int32 InternalRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean& outWantMore) { }
        private System.ValueTuple<System.Int32,System.Boolean> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Boolean InternalWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Boolean InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Threading.Tasks.Task<System.Int32> InnerRead(System.Boolean sync, System.Int32 requestedSize, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task InnerWrite(System.Boolean sync, System.Threading.CancellationToken cancellationToken) { }
        private Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, System.Boolean renegotiate) { }
        private System.ValueTuple<System.Int32,System.Boolean> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer) { }
        private System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer) { }
        private System.Boolean get_IsAuthenticated() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Flush() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate() { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanTimeout() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_CanSeek() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Int32 get_ReadTimeout() { }
        private System.Void set_ReadTimeout(System.Int32 value) { }
        private System.Int32 get_WriteTimeout() { }
        private System.Void set_WriteTimeout(System.Int32 value) { }
        private System.Void .cctor() { }
        private System.Void <InnerWrite>b__67_0() { }

    }

    // TypeToken: 0x2000059
    public class MobileTlsContext, IDisposable
    {
        // Fields
        private Mono.Net.Security.ChainValidationHelper certificateValidator;        // 0x10
        private readonly Mono.Net.Security.MonoSslAuthenticationOptions <Options>k__BackingField;        // 0x18
        private readonly Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField;        // 0x20
        private readonly System.Boolean <IsServer>k__BackingField;        // 0x28
        private readonly System.String <TargetHost>k__BackingField;        // 0x30
        private readonly System.String <ServerName>k__BackingField;        // 0x38
        private readonly System.Boolean <AskForClientCertificate>k__BackingField;        // 0x40
        private readonly System.Security.Authentication.SslProtocols <EnabledProtocols>k__BackingField;        // 0x44
        private readonly System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;        // 0x48
        private System.Security.Cryptography.X509Certificates.X509Certificate <LocalServerCertificate>k__BackingField;        // 0x50

        // Methods
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options) { }
        private Mono.Net.Security.MonoSslAuthenticationOptions get_Options() { }
        private Mono.Net.Security.MobileAuthenticatedStream get_Parent() { }
        private Mono.Security.Interface.MonoTlsSettings get_Settings() { }
        private System.Boolean get_IsAuthenticated() { }
        private System.Boolean get_IsServer() { }
        private System.String get_TargetHost() { }
        private System.String get_ServerName() { }
        private System.Boolean get_AskForClientCertificate() { }
        private System.Security.Authentication.SslProtocols get_EnabledProtocols() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Void GetProtocolVersions(System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max) { }
        private System.Void StartHandshake() { }
        private System.Boolean ProcessHandshake() { }
        private System.Void FinishHandshake() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate() { }
        private System.Void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate() { }
        private System.Void Flush() { }
        private System.ValueTuple<System.Int32,System.Boolean> Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.ValueTuple<System.Int32,System.Boolean> Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Shutdown() { }
        private System.Boolean PendingRenegotiation() { }
        private System.Boolean ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate SelectServerCertificate(System.String serverIdentity) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(System.String[] acceptableIssuers) { }
        private System.Void Renegotiate() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x200005A
    public class MobileTlsProvider : MonoTlsProvider
    {
        // Methods
        private Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings) { }
        private System.Boolean ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class MonoSslAuthenticationOptions
    {
        // Fields
        private System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_ServerMode() { }
        private System.Boolean get_AllowRenegotiation() { }
        private System.Security.Authentication.SslProtocols get_EnabledSslProtocols() { }
        private System.Void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value) { }
        private System.Void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value) { }
        private System.Void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value) { }
        private System.String get_TargetHost() { }
        private System.Void set_TargetHost(System.String value) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        private System.Boolean get_ClientCertificateRequired() { }
        private System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
    {
        // Fields
        private readonly System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;        // 0x18

        // Methods
        private System.Net.Security.SslClientAuthenticationOptions get_Options() { }
        private System.Boolean get_ServerMode() { }
        private System.Void .ctor() { }
        private System.Boolean get_AllowRenegotiation() { }
        private System.Void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value) { }
        private System.Void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value) { }
        private System.Security.Authentication.SslProtocols get_EnabledSslProtocols() { }
        private System.Void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value) { }
        private System.String get_TargetHost() { }
        private System.Void set_TargetHost(System.String value) { }
        private System.Boolean get_ClientCertificateRequired() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate() { }

    }

    // TypeToken: 0x200005D
    public class MonoTlsProviderFactory
    {
        // Fields
        private static System.Object locker;        // 0x0
        private static System.Boolean initialized;        // 0x8
        private static Mono.Net.Security.MobileTlsProvider defaultProvider;        // 0x10
        private static System.Collections.Generic.Dictionary<System.String,System.Tuple<System.Guid,System.String>> providerRegistration;        // 0x18
        private static System.Collections.Generic.Dictionary<System.Guid,Mono.Net.Security.MobileTlsProvider> providerCache;        // 0x20
        private static readonly System.Guid UnityTlsId;        // 0x28
        private static readonly System.Guid AppleTlsId;        // 0x38
        private static readonly System.Guid BtlsId;        // 0x48

        // Methods
        private Mono.Net.Security.MobileTlsProvider GetProviderInternal() { }
        private System.Void InitializeInternal() { }
        private Mono.Net.Security.MobileTlsProvider LookupProvider(System.String name, System.Boolean throwOnError) { }
        private System.Void InitializeProviderRegistration() { }
        private System.Void PopulateUnityProviders() { }
        private System.Void PopulateProviders() { }
        private System.Boolean IsBtlsSupported() { }
        private Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl() { }
        private Mono.Net.Security.MobileTlsProvider GetProvider() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005E
    public class MonoTlsStream, IDisposable
    {
        // Fields
        private readonly Mono.Net.Security.MobileTlsProvider provider;        // 0x10
        private readonly System.Net.Sockets.NetworkStream networkStream;        // 0x18
        private readonly System.Net.HttpWebRequest request;        // 0x20
        private readonly Mono.Security.Interface.MonoTlsSettings settings;        // 0x28
        private System.Net.Security.SslStream sslStream;        // 0x30
        private readonly System.Object sslStreamLock;        // 0x38
        private System.Net.WebExceptionStatus status;        // 0x40
        private System.Boolean <CertificateValidationFailed>k__BackingField;        // 0x44

        // Methods
        private System.Net.HttpWebRequest get_Request() { }
        private System.Net.WebExceptionStatus get_ExceptionStatus() { }
        private System.Boolean get_CertificateValidationFailed() { }
        private System.Void set_CertificateValidationFailed(System.Boolean value) { }
        private System.Void .ctor(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream) { }
        private System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Dispose() { }
        private System.Void CloseSslStream() { }

    }

    // TypeToken: 0x2000060
    public class NoReflectionHelper
    {
        // Methods
        private System.Object GetProvider() { }

    }

    // TypeToken: 0x2000061
    public class SystemCertificateValidator
    {
        // Fields
        private static System.Boolean is_macosx;        // 0x0
        private static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;        // 0x4

        // Methods
        private System.Void .cctor() { }
        private System.Boolean NeedsChain(Mono.Security.Interface.MonoTlsSettings settings) { }

    }

}

namespace Mono.Net.Security.Private
{

    // TypeToken: 0x2000062
    public class CallbackHelpers
    {
        // Methods
        private Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback) { }
        private System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback) { }

    }

}

namespace Mono.Unity
{

    // TypeToken: 0x2000008
    public class CertHelper
    {
        // Methods
        private System.Void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.Void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x2000009
    public class Debug
    {
        // Methods
        private System.Void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, System.String context, Mono.Security.Interface.AlertDescription defaultAlert) { }
        private System.Void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, System.String context, Mono.Security.Interface.AlertDescription defaultAlert) { }

    }

    // TypeToken: 0x200000A
    public class UnityTls
    {
        // Fields
        private static Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;        // 0x0

        // Methods
        private System.IntPtr GetUnityTlsInterface() { }
        private System.Boolean get_IsSupported() { }
        private Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface() { }

    }

    // TypeToken: 0x200003E
    public class UnityTlsContext : MobileTlsContext
    {
        // Fields
        private Mono.Unity.UnityTls.unitytls_tlsctx* tlsContext;        // 0x58
        private Mono.Unity.UnityTls.unitytls_x509list* requestedClientCertChain;        // 0x60
        private Mono.Unity.UnityTls.unitytls_key* requestedClientKey;        // 0x68
        private Mono.Unity.UnityTls.unitytls_tlsctx_read_callback readCallback;        // 0x70
        private Mono.Unity.UnityTls.unitytls_tlsctx_write_callback writeCallback;        // 0x78
        private Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;        // 0x80
        private Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;        // 0x88
        private System.Security.Cryptography.X509Certificates.X509Certificate localClientCertificate;        // 0x90
        private System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate;        // 0x98
        private Mono.Security.Interface.MonoTlsConnectionInfo connectioninfo;        // 0xA0
        private System.Boolean isAuthenticated;        // 0xA8
        private System.Boolean hasContext;        // 0xA9
        private System.Boolean closedGraceful;        // 0xAA
        private System.Byte[] writeBuffer;        // 0xB0
        private System.Byte[] readBuffer;        // 0xB8
        private System.Runtime.InteropServices.GCHandle handle;        // 0xC0
        private System.Exception lastException;        // 0xC8

        // Methods
        private System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options) { }
        private System.Void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_x509list*& nativeCertChain, Mono.Unity.UnityTls.unitytls_key*& nativeKey) { }
        private System.Boolean get_IsAuthenticated() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate() { }
        private System.Void Flush() { }
        private System.ValueTuple<System.Int32,System.Boolean> Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.ValueTuple<System.Int32,System.Boolean> Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Renegotiate() { }
        private System.Boolean PendingRenegotiation() { }
        private System.Void Shutdown() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void StartHandshake() { }
        private System.Boolean ProcessHandshake() { }
        private System.Void FinishHandshake() { }
        private System.IntPtr WriteCallback(System.Void* userData, System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.IntPtr WriteCallback(System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.IntPtr ReadCallback(System.Void* userData, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.IntPtr ReadCallback(System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.Void CertificateCallback(System.Void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, System.IntPtr caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.Void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, System.IntPtr caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }

    }

    // TypeToken: 0x200003F
    public class UnityTlsConversions
    {
        // Methods
        private Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols) { }
        private Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols) { }
        private Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol) { }
        private Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert) { }
        private System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult) { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult) { }

    }

    // TypeToken: 0x2000040
    public class UnityTlsProvider : MobileTlsProvider
    {
        // Methods
        private System.String get_Name() { }
        private System.Guid get_ID() { }
        private System.Boolean get_SupportsSslStream() { }
        private System.Boolean get_SupportsMonoExtensions() { }
        private System.Boolean get_SupportsConnectionInfo() { }
        private System.Boolean get_SupportsCleanShutdown() { }
        private System.Security.Authentication.SslProtocols get_SupportedProtocols() { }
        private Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings) { }
        private Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState) { }
        private System.Boolean ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class UnityTlsStream : MobileAuthenticatedStream
    {
        // Methods
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider) { }
        private Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options) { }

    }

    // TypeToken: 0x2000042
    public class X509ChainImplUnityTls : X509ChainImpl
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;        // 0x10
        private Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;        // 0x18
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;        // 0x20
        private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;        // 0x28
        private System.Boolean reverseOrder;        // 0x30

        // Methods
        private System.Void .ctor(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, System.Boolean reverseOrder) { }
        private System.Boolean get_IsValid() { }
        private Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain() { }
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements() { }
        private System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error) { }
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy() { }
        private System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void Reset() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

}

namespace Mono.Util
{

    // TypeToken: 0x2000007
    public class MonoPInvokeCallbackAttribute : Attribute
    {
        // Methods
        private System.Void .ctor(System.Type t) { }

    }

}

namespace System
{

    // TypeToken: 0x20000AF
    public class IPv4AddressHelper
    {
        // Methods
        private System.Int32 ParseHostNumber(System.ReadOnlySpan<System.Char> str, System.Int32 start, System.Int32 end) { }
        private System.Boolean IsValid(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean allowIPv6, System.Boolean notImplicitFile, System.Boolean unknownScheme) { }
        private System.Boolean ParseCanonical(System.ReadOnlySpan<System.Char> name, System.Byte* numbers, System.Int32 start, System.Int32 end) { }
        private System.Boolean IsValidCanonical(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean allowIPv6, System.Boolean notImplicitFile) { }
        private System.Int64 ParseNonCanonical(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean notImplicitFile) { }
        private System.String ParseCanonicalName(System.String str, System.Int32 start, System.Int32 end, System.Boolean& isLoopback) { }
        private System.Boolean Parse(System.String name, System.Byte* numbers, System.Int32 start, System.Int32 end) { }

    }

    // TypeToken: 0x20000B0
    public class IPv6AddressHelper
    {
        // Methods
        private System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers) { }
        private System.Boolean ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers) { }
        private System.Boolean IsValidStrict(System.Char* name, System.Int32 start, System.Int32& end) { }
        private System.Void Parse(System.ReadOnlySpan<System.Char> address, System.UInt16* numbers, System.Int32 start, System.String& scopeId) { }
        private System.String ParseCanonicalName(System.String str, System.Int32 start, System.Boolean& isLoopback, System.String& scopeId) { }
        private System.Boolean IsLoopback(System.ReadOnlySpan<System.UInt16> numbers) { }
        private System.Boolean InternalIsValid(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean validateStrictAddress) { }
        private System.Boolean IsValid(System.Char* name, System.Int32 start, System.Int32& end) { }

    }

    // TypeToken: 0x20000B1
    public class NotImplemented
    {
        // Methods
        private System.Exception ByDesignWithMessage(System.String message) { }

    }

    // TypeToken: 0x20000B2
    public class PasteArguments
    {
        // Methods
        private System.Void AppendArgument(System.Text.StringBuilder stringBuilder, System.String argument) { }
        private System.Boolean ContainsNoWhitespaceOrQuotes(System.String s) { }

    }

    // TypeToken: 0x20000B3
    public class StringExtensions
    {
        // Methods
        private System.String SubstringTrim(System.String value, System.Int32 startIndex) { }
        private System.String SubstringTrim(System.String value, System.Int32 startIndex, System.Int32 length) { }

    }

    // TypeToken: 0x20000B4
    public class UriBuilder
    {
        // Fields
        private System.Boolean _changed;        // 0x10
        private System.String _fragment;        // 0x18
        private System.String _host;        // 0x20
        private System.String _password;        // 0x28
        private System.String _path;        // 0x30
        private System.Int32 _port;        // 0x38
        private System.String _query;        // 0x40
        private System.String _scheme;        // 0x48
        private System.String _schemeDelimiter;        // 0x50
        private System.Uri _uri;        // 0x58
        private System.String _username;        // 0x60

        // Methods
        private System.Void .ctor(System.Uri uri) { }
        private System.Void Init(System.Uri uri) { }
        private System.Void set_Path(System.String value) { }
        private System.Uri get_Uri() { }
        private System.Boolean Equals(System.Object rparam) { }
        private System.Int32 GetHashCode() { }
        private System.Void SetFieldsFromUri(System.Uri uri) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000B5
    public class SecurityUtils
    {
        // Methods
        private System.Void DemandReflectionAccess(System.Type type) { }
        private System.Void DemandGrantSet(System.Reflection.Assembly assembly) { }
        private System.Boolean HasReflectionPermission(System.Type type) { }
        private System.Object SecureCreateInstance(System.Type type) { }
        private System.Object SecureCreateInstance(System.Type type, System.Object[] args, System.Boolean allowNonPublic) { }
        private System.Object SecureCreateInstance(System.Type type, System.Object[] args) { }
        private System.Object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, System.Object[] args, System.Boolean allowNonPublic) { }
        private System.Object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, System.Object[] args, System.Boolean allowNonPublic, System.Reflection.BindingFlags extraFlags) { }
        private System.Boolean GenericArgumentsAreVisible(System.Reflection.MethodInfo method) { }
        private System.Object MethodInfoInvoke(System.Reflection.MethodInfo method, System.Object target, System.Object[] args) { }

    }

    // TypeToken: 0x20000B6
    public class InvariantComparer, IComparer
    {
        // Fields
        private System.Globalization.CompareInfo m_compareInfo;        // 0x10
        private static readonly System.InvariantComparer Default;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 Compare(System.Object a, System.Object b) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B7
    public class IriHelper
    {
        // Methods
        private System.Boolean CheckIriUnicodeRange(System.Char unicode, System.Boolean isQuery) { }
        private System.Boolean CheckIriUnicodeRange(System.Char highSurr, System.Char lowSurr, System.Boolean& surrogatePair, System.Boolean isQuery) { }
        private System.Boolean CheckIsReserved(System.Char ch, System.UriComponents component) { }
        private System.String EscapeUnescapeIri(System.Char* pInput, System.Int32 start, System.Int32 end, System.UriComponents component) { }

    }

    // TypeToken: 0x20000B8
    public class Uri, ISerializable
    {
        // Fields
        public static readonly System.String UriSchemeFile;        // 0x0
        public static readonly System.String UriSchemeFtp;        // 0x8
        public static readonly System.String UriSchemeGopher;        // 0x10
        public static readonly System.String UriSchemeHttp;        // 0x18
        public static readonly System.String UriSchemeHttps;        // 0x20
        private static readonly System.String UriSchemeWs;        // 0x28
        private static readonly System.String UriSchemeWss;        // 0x30
        public static readonly System.String UriSchemeMailto;        // 0x38
        public static readonly System.String UriSchemeNews;        // 0x40
        public static readonly System.String UriSchemeNntp;        // 0x48
        public static readonly System.String UriSchemeNetTcp;        // 0x50
        public static readonly System.String UriSchemeNetPipe;        // 0x58
        public static readonly System.String SchemeDelimiter;        // 0x60
        private static System.Int32 c_Max16BitUtf8SequenceLength;        // 0x0
        private static System.Int32 c_MaxUriBufferSize;        // 0x0
        private static System.Int32 c_MaxUriSchemeName;        // 0x0
        private System.String m_String;        // 0x10
        private System.String m_originalUnicodeString;        // 0x18
        private System.UriParser m_Syntax;        // 0x20
        private System.String m_DnsSafeHost;        // 0x28
        private System.Uri.Flags m_Flags;        // 0x30
        private System.Uri.UriInfo m_Info;        // 0x38
        private System.Boolean m_iriParsing;        // 0x40
        private static System.Boolean s_ConfigInitialized;        // 0x68
        private static System.Boolean s_ConfigInitializing;        // 0x69
        private static System.UriIdnScope s_IdnScope;        // 0x6C
        private static System.Boolean s_IriParsing;        // 0x70
        private static System.Boolean useDotNetRelativeOrAbsolute;        // 0x71
        private static System.UriKind DotNetRelativeOrAbsolute;        // 0x0
        private static readonly System.Boolean IsWindowsFileSystem;        // 0x72
        private static System.Object s_initLock;        // 0x78
        private static System.UriFormat V1ToStringUnescape;        // 0x0
        private static System.Char c_DummyChar;        // 0x0
        private static System.Char c_EOL;        // 0x0
        private static readonly System.Char[] HexLowerChars;        // 0x80
        private static readonly System.Char[] _WSchars;        // 0x88

        // Methods
        private System.Boolean get_IsImplicitFile() { }
        private System.Boolean get_IsUncOrDosPath() { }
        private System.Boolean get_IsDosPath() { }
        private System.Boolean get_IsUncPath() { }
        private System.Uri.Flags get_HostType() { }
        private System.UriParser get_Syntax() { }
        private System.Boolean get_IsNotAbsoluteUri() { }
        private System.Boolean IriParsingStatic(System.UriParser syntax) { }
        private System.Boolean get_AllowIdn() { }
        private System.Boolean AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags) { }
        private System.Boolean IsIntranet(System.String schemeHost) { }
        private System.Boolean get_UserDrivenParsing() { }
        private System.Void SetUserDrivenParsing() { }
        private System.UInt16 get_SecuredPathIndex() { }
        private System.Boolean NotAny(System.Uri.Flags flags) { }
        private System.Boolean InFact(System.Uri.Flags flags) { }
        private System.Boolean StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags) { }
        private System.Boolean StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags) { }
        private System.Uri.UriInfo EnsureUriInfo() { }
        private System.Void EnsureParseRemaining() { }
        private System.Void EnsureHostString(System.Boolean allowDnsOptimization) { }
        private System.Void .ctor(System.String uriString) { }
        private System.Void .ctor(System.String uriString, System.UriKind uriKind) { }
        private System.Void .ctor(System.Uri baseUri, System.String relativeUri) { }
        private System.Void CreateUri(System.Uri baseUri, System.String relativeUri, System.Boolean dontEscape) { }
        private System.Void .ctor(System.Uri baseUri, System.Uri relativeUri) { }
        private System.ParsingError GetCombinedString(System.Uri baseUri, System.String relativeStr, System.Boolean dontEscape, System.String& result) { }
        private System.UriFormatException GetException(System.ParsingError err) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.String get_AbsolutePath() { }
        private System.String get_PrivateAbsolutePath() { }
        private System.String get_AbsoluteUri() { }
        private System.String get_LocalPath() { }
        private System.String get_Authority() { }
        private System.UriHostNameType get_HostNameType() { }
        private System.Boolean get_IsDefaultPort() { }
        private System.Boolean get_IsFile() { }
        private System.Boolean get_IsLoopback() { }
        private System.String get_PathAndQuery() { }
        private System.String[] get_Segments() { }
        private System.Boolean get_IsUnc() { }
        private System.String get_Host() { }
        private System.Boolean StaticIsFile(System.UriParser syntax) { }
        private System.Object get_InitializeLock() { }
        private System.Void InitializeUriConfig() { }
        private System.String GetLocalPath() { }
        private System.Int32 get_Port() { }
        private System.String get_Query() { }
        private System.String get_Fragment() { }
        private System.String get_Scheme() { }
        private System.Boolean get_OriginalStringSwitched() { }
        private System.String get_OriginalString() { }
        private System.String get_DnsSafeHost() { }
        private System.String get_IdnHost() { }
        private System.Boolean get_IsAbsoluteUri() { }
        private System.Boolean get_UserEscaped() { }
        private System.String get_UserInfo() { }
        private System.String HexEscape(System.Char character) { }
        private System.Boolean IsGenDelim(System.Char ch) { }
        private System.Boolean IsHexDigit(System.Char character) { }
        private System.Int32 FromHex(System.Char digit) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean op_Equality(System.Uri uri1, System.Uri uri2) { }
        private System.Boolean op_Inequality(System.Uri uri1, System.Uri uri2) { }
        private System.Boolean Equals(System.Object comparand) { }
        private System.Uri MakeRelativeUri(System.Uri uri) { }
        private System.Boolean CheckForColonInFirstPathSegment(System.String uriString) { }
        private System.String InternalEscapeString(System.String rawString) { }
        private System.ParsingError ParseScheme(System.String uriString, System.Uri.Flags& flags, System.UriParser& syntax) { }
        private System.UriFormatException ParseMinimal() { }
        private System.ParsingError PrivateParseMinimal() { }
        private System.Void PrivateParseMinimalIri(System.String newHost, System.UInt16 idx) { }
        private System.Void CreateUriInfo(System.Uri.Flags cF) { }
        private System.Void CreateHostString() { }
        private System.String CreateHostStringHelper(System.String str, System.UInt16 idx, System.UInt16 end, System.Uri.Flags& flags, System.String& scopeId) { }
        private System.Void GetHostViaCustomSyntax() { }
        private System.String GetParts(System.UriComponents uriParts, System.UriFormat formatAs) { }
        private System.String GetEscapedParts(System.UriComponents uriParts) { }
        private System.String GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs) { }
        private System.String ReCreateParts(System.UriComponents parts, System.UInt16 nonCanonical, System.UriFormat formatAs) { }
        private System.String GetUriPartsFromUserString(System.UriComponents uriParts) { }
        private System.Void ParseRemaining() { }
        private System.UInt16 ParseSchemeCheckImplicitFile(System.Char* uriString, System.UInt16 length, System.ParsingError& err, System.Uri.Flags& flags, System.UriParser& syntax) { }
        private System.Boolean CheckKnownSchemes(System.Int64* lptr, System.UInt16 nChars, System.UriParser& syntax) { }
        private System.ParsingError CheckSchemeSyntax(System.Char* ptr, System.UInt16 length, System.UriParser& syntax) { }
        private System.UInt16 CheckAuthorityHelper(System.Char* pString, System.UInt16 idx, System.UInt16 length, System.ParsingError& err, System.Uri.Flags& flags, System.UriParser syntax, System.String& newHost) { }
        private System.Void CheckAuthorityHelperHandleDnsIri(System.Char* pString, System.UInt16 start, System.Int32 end, System.Int32 startInput, System.Boolean iriParsing, System.Boolean hasUnicode, System.UriParser syntax, System.String userInfoString, System.Uri.Flags& flags, System.Boolean& justNormalized, System.String& newHost, System.ParsingError& err) { }
        private System.Void CheckAuthorityHelperHandleAnyHostIri(System.Char* pString, System.Int32 startInput, System.Int32 end, System.Boolean iriParsing, System.Boolean hasUnicode, System.UriParser syntax, System.Uri.Flags& flags, System.String& newHost, System.ParsingError& err) { }
        private System.Void FindEndOfComponent(System.String input, System.UInt16& idx, System.UInt16 end, System.Char delim) { }
        private System.Void FindEndOfComponent(System.Char* str, System.UInt16& idx, System.UInt16 end, System.Char delim) { }
        private System.Uri.Check CheckCanonical(System.Char* str, System.UInt16& idx, System.UInt16 end, System.Char delim) { }
        private System.Char[] GetCanonicalPath(System.Char[] dest, System.Int32& pos, System.UriFormat formatAs) { }
        private System.Void UnescapeOnly(System.Char* pch, System.Int32 start, System.Int32& end, System.Char ch1, System.Char ch2, System.Char ch3) { }
        private System.Char[] Compress(System.Char[] dest, System.UInt16 start, System.Int32& destLength, System.UriParser syntax) { }
        private System.Int32 CalculateCaseInsensitiveHashCode(System.String text) { }
        private System.String CombineUri(System.Uri basePart, System.String relativePart, System.UriFormat uriFormat) { }
        private System.String PathDifference(System.String path1, System.String path2, System.Boolean compareCase) { }
        private System.Boolean get_HasAuthority() { }
        private System.Boolean IsLWS(System.Char ch) { }
        private System.Boolean IsAsciiLetter(System.Char character) { }
        private System.Boolean IsAsciiLetterOrDigit(System.Char character) { }
        private System.Boolean IsBidiControlCharacter(System.Char ch) { }
        private System.String StripBidiControlCharacter(System.Char* strToClean, System.Int32 start, System.Int32 length) { }
        private System.Void CreateThis(System.String uri, System.Boolean dontEscape, System.UriKind uriKind) { }
        private System.Void InitializeUri(System.ParsingError err, System.UriKind uriKind, System.UriFormatException& e) { }
        private System.Boolean CheckForConfigLoad(System.String data) { }
        private System.Boolean CheckForUnicode(System.String data) { }
        private System.Boolean CheckForEscapedUnreserved(System.String data) { }
        private System.Boolean TryCreate(System.String uriString, System.UriKind uriKind, System.Uri& result) { }
        private System.Boolean TryCreate(System.Uri baseUri, System.String relativeUri, System.Uri& result) { }
        private System.Boolean TryCreate(System.Uri baseUri, System.Uri relativeUri, System.Uri& result) { }
        private System.String GetComponents(System.UriComponents components, System.UriFormat format) { }
        private System.String UnescapeDataString(System.String stringToUnescape) { }
        private System.String EscapeUnescapeIri(System.String input, System.Int32 start, System.Int32 end, System.UriComponents component) { }
        private System.Void .ctor(System.Uri.Flags flags, System.UriParser uriParser, System.String uri) { }
        private System.Uri CreateHelper(System.String uriString, System.Boolean dontEscape, System.UriKind uriKind, System.UriFormatException& e) { }
        private System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, System.String& newUriString, System.Boolean& userEscaped, System.UriFormatException& e) { }
        private System.String GetRelativeSerializationString(System.UriFormat format) { }
        private System.String GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat) { }
        private System.Boolean IsBaseOf(System.Uri uri) { }
        private System.Boolean IsBaseOfHelper(System.Uri uriLink) { }
        private System.Void CreateThisFromUri(System.Uri otherUri) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE
    public class UriFormatException : FormatException, ISerializable
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String textString) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }

    }

    // TypeToken: 0x20000BF
    public struct UriKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriKind RelativeOrAbsolute;        // 0x0
        public static System.UriKind Absolute;        // 0x0
        public static System.UriKind Relative;        // 0x0

    }

    // TypeToken: 0x20000C0
    public struct UriComponents
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriComponents Scheme;        // 0x0
        public static System.UriComponents UserInfo;        // 0x0
        public static System.UriComponents Host;        // 0x0
        public static System.UriComponents Port;        // 0x0
        public static System.UriComponents Path;        // 0x0
        public static System.UriComponents Query;        // 0x0
        public static System.UriComponents Fragment;        // 0x0
        public static System.UriComponents StrongPort;        // 0x0
        public static System.UriComponents NormalizedHost;        // 0x0
        public static System.UriComponents KeepDelimiter;        // 0x0
        public static System.UriComponents SerializationInfoString;        // 0x0
        public static System.UriComponents AbsoluteUri;        // 0x0
        public static System.UriComponents HostAndPort;        // 0x0
        public static System.UriComponents StrongAuthority;        // 0x0
        public static System.UriComponents SchemeAndServer;        // 0x0
        public static System.UriComponents HttpRequestUrl;        // 0x0
        public static System.UriComponents PathAndQuery;        // 0x0

    }

    // TypeToken: 0x20000C1
    public struct UriFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriFormat UriEscaped;        // 0x0
        public static System.UriFormat Unescaped;        // 0x0
        public static System.UriFormat SafeUnescaped;        // 0x0

    }

    // TypeToken: 0x20000C2
    public struct UriIdnScope
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriIdnScope None;        // 0x0
        public static System.UriIdnScope AllExceptIntranet;        // 0x0
        public static System.UriIdnScope All;        // 0x0

    }

    // TypeToken: 0x20000C3
    public struct ParsingError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.ParsingError None;        // 0x0
        public static System.ParsingError BadFormat;        // 0x0
        public static System.ParsingError BadScheme;        // 0x0
        public static System.ParsingError BadAuthority;        // 0x0
        public static System.ParsingError EmptyUriString;        // 0x0
        public static System.ParsingError LastRelativeUriOkErrIndex;        // 0x0
        public static System.ParsingError SchemeLimit;        // 0x0
        public static System.ParsingError SizeLimit;        // 0x0
        public static System.ParsingError MustRootedPath;        // 0x0
        public static System.ParsingError BadHostName;        // 0x0
        public static System.ParsingError NonEmptyHost;        // 0x0
        public static System.ParsingError BadPort;        // 0x0
        public static System.ParsingError BadAuthorityTerminator;        // 0x0
        public static System.ParsingError CannotCreateRelative;        // 0x0

    }

    // TypeToken: 0x20000C4
    public struct UnescapeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UnescapeMode CopyOnly;        // 0x0
        public static System.UnescapeMode Escape;        // 0x0
        public static System.UnescapeMode Unescape;        // 0x0
        public static System.UnescapeMode EscapeUnescape;        // 0x0
        public static System.UnescapeMode V1ToStringFlag;        // 0x0
        public static System.UnescapeMode UnescapeAll;        // 0x0
        public static System.UnescapeMode UnescapeAllOrThrow;        // 0x0

    }

    // TypeToken: 0x20000C5
    public class UriHelper
    {
        // Fields
        private static readonly System.Char[] HexUpperChars;        // 0x0

        // Methods
        private System.Boolean TestForSubPath(System.Char* pMe, System.UInt16 meLength, System.Char* pShe, System.UInt16 sheLength, System.Boolean ignoreCase) { }
        private System.Char[] EscapeString(System.String input, System.Int32 start, System.Int32 end, System.Char[] dest, System.Int32& destPos, System.Boolean isUriString, System.Char force1, System.Char force2, System.Char rsvd) { }
        private System.Char[] EnsureDestinationSize(System.Char* pStr, System.Char[] dest, System.Int32 currentInputPos, System.Int16 charsToAdd, System.Int16 minReallocateChars, System.Int32& destPos, System.Int32 prevInputPos) { }
        private System.Char[] UnescapeString(System.String input, System.Int32 start, System.Int32 end, System.Char[] dest, System.Int32& destPosition, System.Char rsvd1, System.Char rsvd2, System.Char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, System.Boolean isQuery) { }
        private System.Char[] UnescapeString(System.Char* pStr, System.Int32 start, System.Int32 end, System.Char[] dest, System.Int32& destPosition, System.Char rsvd1, System.Char rsvd2, System.Char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, System.Boolean isQuery) { }
        private System.Void MatchUTF8Sequence(System.Char* pDest, System.Char[] dest, System.Int32& destOffset, System.Char[] unescapedChars, System.Int32 charCount, System.Byte[] bytes, System.Int32 byteCount, System.Boolean isQuery, System.Boolean iriParsing) { }
        private System.Void EscapeAsciiChar(System.Char ch, System.Char[] to, System.Int32& pos) { }
        private System.Char EscapedAscii(System.Char digit, System.Char next) { }
        private System.Boolean IsNotSafeForUnescape(System.Char ch) { }
        private System.Boolean IsReservedUnreservedOrHash(System.Char c) { }
        private System.Boolean IsUnreserved(System.Char c) { }
        private System.Boolean Is3986Unreserved(System.Char c) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C6
    public struct UriHostNameType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriHostNameType Unknown;        // 0x0
        public static System.UriHostNameType Basic;        // 0x0
        public static System.UriHostNameType Dns;        // 0x0
        public static System.UriHostNameType IPv4;        // 0x0
        public static System.UriHostNameType IPv6;        // 0x0

    }

    // TypeToken: 0x20000C7
    public class UriParser
    {
        // Fields
        private static System.UriSyntaxFlags SchemeOnlyFlags;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.String,System.UriParser> m_Table;        // 0x0
        private static System.Collections.Generic.Dictionary<System.String,System.UriParser> m_TempTable;        // 0x8
        private System.UriSyntaxFlags m_Flags;        // 0x10
        private System.UriSyntaxFlags m_UpdatableFlags;        // 0x14
        private System.Boolean m_UpdatableFlagsUsed;        // 0x18
        private static System.UriSyntaxFlags c_UpdatableFlags;        // 0x0
        private System.Int32 m_Port;        // 0x1C
        private System.String m_Scheme;        // 0x20
        private static System.Int32 NoDefaultPort;        // 0x0
        private static System.Int32 c_InitialTableSize;        // 0x0
        private static System.UriParser HttpUri;        // 0x10
        private static System.UriParser HttpsUri;        // 0x18
        private static System.UriParser WsUri;        // 0x20
        private static System.UriParser WssUri;        // 0x28
        private static System.UriParser FtpUri;        // 0x30
        private static System.UriParser FileUri;        // 0x38
        private static System.UriParser GopherUri;        // 0x40
        private static System.UriParser NntpUri;        // 0x48
        private static System.UriParser NewsUri;        // 0x50
        private static System.UriParser MailToUri;        // 0x58
        private static System.UriParser UuidUri;        // 0x60
        private static System.UriParser TelnetUri;        // 0x68
        private static System.UriParser LdapUri;        // 0x70
        private static System.UriParser NetTcpUri;        // 0x78
        private static System.UriParser NetPipeUri;        // 0x80
        private static System.UriParser VsMacrosUri;        // 0x88
        private static readonly System.UriParser.UriQuirksVersion s_QuirksVersion;        // 0x90
        private static System.Int32 c_MaxCapacity;        // 0x0
        private static System.UriSyntaxFlags UnknownV1SyntaxFlags;        // 0x0
        private static readonly System.UriSyntaxFlags HttpSyntaxFlags;        // 0x94
        private static System.UriSyntaxFlags FtpSyntaxFlags;        // 0x0
        private static readonly System.UriSyntaxFlags FileSyntaxFlags;        // 0x98
        private static System.UriSyntaxFlags VsmacrosSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags GopherSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags NewsSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags NntpSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags TelnetSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags LdapSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags MailtoSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags NetPipeSyntaxFlags;        // 0x0
        private static System.UriSyntaxFlags NetTcpSyntaxFlags;        // 0x0

        // Methods
        private System.String get_SchemeName() { }
        private System.Int32 get_DefaultPort() { }
        private System.UriParser OnNewUri() { }
        private System.Void InitializeAndValidate(System.Uri uri, System.UriFormatException& parsingError) { }
        private System.String Resolve(System.Uri baseUri, System.Uri relativeUri, System.UriFormatException& parsingError) { }
        private System.Boolean IsBaseOf(System.Uri baseUri, System.Uri relativeUri) { }
        private System.String GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format) { }
        private System.Boolean get_ShouldUseLegacyV2Quirks() { }
        private System.Void .cctor() { }
        private System.UriSyntaxFlags get_Flags() { }
        private System.Boolean NotAny(System.UriSyntaxFlags flags) { }
        private System.Boolean InFact(System.UriSyntaxFlags flags) { }
        private System.Boolean IsAllSet(System.UriSyntaxFlags flags) { }
        private System.Boolean IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected) { }
        private System.Void .ctor(System.UriSyntaxFlags flags) { }
        private System.UriParser FindOrFetchAsUnknownV1Syntax(System.String lwrCaseScheme) { }
        private System.UriParser GetSyntax(System.String lwrCaseScheme) { }
        private System.Boolean get_IsSimple() { }
        private System.UriParser InternalOnNewUri() { }
        private System.Void InternalValidate(System.Uri thisUri, System.UriFormatException& parsingError) { }
        private System.String InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, System.UriFormatException& parsingError) { }
        private System.Boolean InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink) { }
        private System.String InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat) { }

    }

    // TypeToken: 0x20000CA
    public class DomainNameHelper
    {
        // Methods
        private System.String ParseCanonicalName(System.String str, System.Int32 start, System.Int32 end, System.Boolean& loopback) { }
        private System.Boolean IsValid(System.Char* name, System.UInt16 pos, System.Int32& returnedEnd, System.Boolean& notCanonical, System.Boolean notImplicitFile) { }
        private System.Boolean IsValidByIri(System.Char* name, System.UInt16 pos, System.Int32& returnedEnd, System.Boolean& notCanonical, System.Boolean notImplicitFile) { }
        private System.String IdnEquivalent(System.String hostname) { }
        private System.String IdnEquivalent(System.Char* hostname, System.Int32 start, System.Int32 end, System.Boolean& allAscii, System.Boolean& atLeastOneValidIdn) { }
        private System.String IdnEquivalent(System.Char* hostname, System.Int32 start, System.Int32 end, System.Boolean& allAscii, System.String& bidiStrippedHost) { }
        private System.Boolean IsIdnAce(System.String input, System.Int32 index) { }
        private System.Boolean IsIdnAce(System.Char* input, System.Int32 index) { }
        private System.String UnicodeEquivalent(System.String idnHost, System.Char* hostname, System.Int32 start, System.Int32 end) { }
        private System.String UnicodeEquivalent(System.Char* hostname, System.Int32 start, System.Int32 end, System.Boolean& allAscii, System.Boolean& atLeastOneValidIdn) { }
        private System.Boolean IsASCIILetterOrDigit(System.Char character, System.Boolean& notCanonical) { }
        private System.Boolean IsValidDomainLabelCharacter(System.Char character, System.Boolean& notCanonical) { }

    }

    // TypeToken: 0x20000CB
    public class UncNameHelper
    {
        // Methods
        private System.String ParseCanonicalName(System.String str, System.Int32 start, System.Int32 end, System.Boolean& loopback) { }
        private System.Boolean IsValid(System.Char* name, System.UInt16 start, System.Int32& returnedEnd, System.Boolean notImplicitFile) { }

    }

    // TypeToken: 0x20000CC
    public struct UriSyntaxFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.UriSyntaxFlags None;        // 0x0
        public static System.UriSyntaxFlags MustHaveAuthority;        // 0x0
        public static System.UriSyntaxFlags OptionalAuthority;        // 0x0
        public static System.UriSyntaxFlags MayHaveUserInfo;        // 0x0
        public static System.UriSyntaxFlags MayHavePort;        // 0x0
        public static System.UriSyntaxFlags MayHavePath;        // 0x0
        public static System.UriSyntaxFlags MayHaveQuery;        // 0x0
        public static System.UriSyntaxFlags MayHaveFragment;        // 0x0
        public static System.UriSyntaxFlags AllowEmptyHost;        // 0x0
        public static System.UriSyntaxFlags AllowUncHost;        // 0x0
        public static System.UriSyntaxFlags AllowDnsHost;        // 0x0
        public static System.UriSyntaxFlags AllowIPv4Host;        // 0x0
        public static System.UriSyntaxFlags AllowIPv6Host;        // 0x0
        public static System.UriSyntaxFlags AllowAnInternetHost;        // 0x0
        public static System.UriSyntaxFlags AllowAnyOtherHost;        // 0x0
        public static System.UriSyntaxFlags FileLikeUri;        // 0x0
        public static System.UriSyntaxFlags MailToLikeUri;        // 0x0
        public static System.UriSyntaxFlags V1_UnknownUri;        // 0x0
        public static System.UriSyntaxFlags SimpleUserSyntax;        // 0x0
        public static System.UriSyntaxFlags BuiltInSyntax;        // 0x0
        public static System.UriSyntaxFlags ParserSchemeOnly;        // 0x0
        public static System.UriSyntaxFlags AllowDOSPath;        // 0x0
        public static System.UriSyntaxFlags PathIsRooted;        // 0x0
        public static System.UriSyntaxFlags ConvertPathSlashes;        // 0x0
        public static System.UriSyntaxFlags CompressPath;        // 0x0
        public static System.UriSyntaxFlags CanonicalizeAsFilePath;        // 0x0
        public static System.UriSyntaxFlags UnEscapeDotsAndSlashes;        // 0x0
        public static System.UriSyntaxFlags AllowIdn;        // 0x0
        public static System.UriSyntaxFlags AllowIriParsing;        // 0x0

    }

    // TypeToken: 0x20000CD
    public class LocalAppContextSwitches
    {
        // Fields
        public static readonly System.Boolean MemberDescriptorEqualsReturnsFalseIfEquivalent;        // 0x0

    }

    // TypeToken: 0x20000CE
    public struct IOOperation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IOOperation Read;        // 0x0
        public static System.IOOperation Write;        // 0x0

    }

    // TypeToken: 0x20000CF
    public class IOAsyncCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IOAsyncResult ioares) { }

    }

    // TypeToken: 0x20000D0
    public class IOAsyncResult, IAsyncResult
    {
        // Fields
        private System.AsyncCallback async_callback;        // 0x10
        private System.Object async_state;        // 0x18
        private System.Threading.ManualResetEvent wait_handle;        // 0x20
        private System.Boolean completed_synchronously;        // 0x28
        private System.Boolean completed;        // 0x29

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(System.AsyncCallback async_callback, System.Object async_state) { }
        private System.Void .ctor(System.AsyncCallback async_callback, System.Object async_state) { }
        private System.AsyncCallback get_AsyncCallback() { }
        private System.Object get_AsyncState() { }
        private System.Threading.WaitHandle get_AsyncWaitHandle() { }
        private System.Boolean get_CompletedSynchronously() { }
        private System.Void set_CompletedSynchronously(System.Boolean value) { }
        private System.Boolean get_IsCompleted() { }
        private System.Void set_IsCompleted(System.Boolean value) { }
        private System.Void CompleteDisposed() { }

    }

    // TypeToken: 0x20000D1
    public class IOSelectorJob, IThreadPoolWorkItem
    {
        // Fields
        private System.IOOperation operation;        // 0x10
        private System.IOAsyncCallback callback;        // 0x18
        private System.IOAsyncResult state;        // 0x20

        // Methods
        private System.Void .ctor(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state) { }
        private System.Void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }
        private System.Void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae) { }
        private System.Void MarkDisposed() { }

    }

    // TypeToken: 0x20000D2
    public class IOSelector
    {
        // Methods
        private System.Void Add(System.IntPtr handle, System.IOSelectorJob job) { }

    }

    // TypeToken: 0x20000D3
    public class UriTypeConverter : TypeConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean CanConvert(System.Type type) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }

    }

}

namespace System.CodeDom.Compiler
{

    // TypeToken: 0x20000F7
    public class GeneratedCodeAttribute : Attribute
    {
        // Fields
        private readonly System.String tool;        // 0x10
        private readonly System.String version;        // 0x18

        // Methods
        private System.Void .ctor(System.String tool, System.String version) { }

    }

}

namespace System.Collections
{

    // TypeToken: 0x200031E
    public class HashtableExtensions
    {
        // Methods
        private System.Boolean TryGetValue(System.Collections.Hashtable table, System.Object key, T& value) { }

    }

}

namespace System.Collections.Concurrent
{

    // TypeToken: 0x200033A
    public class BlockingCollection`1, IEnumerable`1, IEnumerable, ICollection, IDisposable, IReadOnlyCollection`1
    {
        // Fields
        private System.Collections.Concurrent.IProducerConsumerCollection<T> _collection;        // 0x0
        private System.Int32 _boundedCapacity;        // 0x0
        private System.Threading.SemaphoreSlim _freeNodes;        // 0x0
        private System.Threading.SemaphoreSlim _occupiedNodes;        // 0x0
        private System.Boolean _isDisposed;        // 0x0
        private System.Threading.CancellationTokenSource _consumersCancellationTokenSource;        // 0x0
        private System.Threading.CancellationTokenSource _producersCancellationTokenSource;        // 0x0
        private System.Int32 _currentAdders;        // 0x0

        // Methods
        private System.Boolean get_IsAddingCompleted() { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Concurrent.IProducerConsumerCollection<T> collection) { }
        private System.Void Initialize(System.Collections.Concurrent.IProducerConsumerCollection<T> collection, System.Int32 boundedCapacity, System.Int32 collectionCount) { }
        private System.Void Add(T item) { }
        private System.Boolean TryAddWithNoTimeValidation(T item, System.Int32 millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void CheckDisposed() { }

    }

    // TypeToken: 0x200033B
    public class BlockingCollectionDebugView`1
    {
    }

    // TypeToken: 0x200033C
    public class ConcurrentBag`1, IProducerConsumerCollection`1, IEnumerable`1, IEnumerable, ICollection, IReadOnlyCollection`1
    {
        // Fields
        private readonly System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals;        // 0x0
        private System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _workStealingQueues;        // 0x0
        private System.Int64 _emptyToNonEmptyListTransitionCount;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Add(T item) { }
        private System.Boolean System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }
        private System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(System.Boolean forceCreate) { }
        private System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread() { }
        private System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue() { }
        private System.Void CopyTo(T[] array, System.Int32 index) { }
        private System.Int32 CopyFromEachQueueToArray(T[] array, System.Int32 index) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private T[] ToArray() { }
        private System.Void Clear() { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_DangerousCount() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Object get_GlobalQueuesLock() { }
        private System.Void FreezeBag(System.Boolean& lockTaken) { }
        private System.Void UnfreezeBag(System.Boolean lockTaken) { }

    }

}

namespace System.Collections.Generic
{

    // TypeToken: 0x200033F
    public struct ValueListBuilder`1
    {
        // Fields
        private System.Span<T> _span;        // 0x0
        private T[] _arrayFromPool;        // 0x0
        private System.Int32 _pos;        // 0x0

        // Methods
        private System.Void .ctor(System.Span<T> initialSpan) { }
        private System.Int32 get_Length() { }
        private T& get_Item(System.Int32 index) { }
        private System.Void Append(T item) { }
        private System.ReadOnlySpan<T> AsSpan() { }
        private System.Void Dispose() { }
        private System.Void Grow() { }
        private T Pop() { }

    }

    // TypeToken: 0x2000340
    public class ICollectionDebugView`1
    {
    }

    // TypeToken: 0x2000341
    public class IDictionaryDebugView`2
    {
    }

    // TypeToken: 0x2000342
    public class DictionaryKeyCollectionDebugView`2
    {
    }

    // TypeToken: 0x2000343
    public class DictionaryValueCollectionDebugView`2
    {
    }

    // TypeToken: 0x2000344
    public class LinkedList`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection, IReadOnlyCollection`1, ISerializable, IDeserializationCallback
    {
        // Fields
        private System.Collections.Generic.LinkedListNode<T> head;        // 0x0
        private System.Int32 count;        // 0x0
        private System.Int32 version;        // 0x0
        private System.Object _syncRoot;        // 0x0
        private System.Runtime.Serialization.SerializationInfo _siInfo;        // 0x0
        private static System.String VersionName;        // 0x0
        private static System.String CountName;        // 0x0
        private static System.String ValuesName;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Int32 get_Count() { }
        private System.Collections.Generic.LinkedListNode<T> get_First() { }
        private System.Collections.Generic.LinkedListNode<T> get_Last() { }
        private System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
        private System.Void System.Collections.Generic.ICollection<T>.Add(T value) { }
        private System.Void AddAfter(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
        private System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> node, T value) { }
        private System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { }
        private System.Void AddFirst(System.Collections.Generic.LinkedListNode<T> node) { }
        private System.Collections.Generic.LinkedListNode<T> AddLast(T value) { }
        private System.Void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T value) { }
        private System.Void CopyTo(T[] array, System.Int32 index) { }
        private System.Collections.Generic.LinkedListNode<T> Find(T value) { }
        private System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Boolean Remove(T value) { }
        private System.Void Remove(System.Collections.Generic.LinkedListNode<T> node) { }
        private System.Void RemoveFirst() { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void OnDeserialization(System.Object sender) { }
        private System.Void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
        private System.Void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode) { }
        private System.Void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node) { }
        private System.Void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node) { }
        private System.Void ValidateNode(System.Collections.Generic.LinkedListNode<T> node) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000346
    public class LinkedListNode`1
    {
        // Fields
        private System.Collections.Generic.LinkedList<T> list;        // 0x0
        private System.Collections.Generic.LinkedListNode<T> next;        // 0x0
        private System.Collections.Generic.LinkedListNode<T> prev;        // 0x0
        private T item;        // 0x0

        // Methods
        private System.Void .ctor(T value) { }
        private System.Void .ctor(System.Collections.Generic.LinkedList<T> list, T value) { }
        private System.Collections.Generic.LinkedList<T> get_List() { }
        private System.Collections.Generic.LinkedListNode<T> get_Next() { }
        private System.Collections.Generic.LinkedListNode<T> get_Previous() { }
        private T get_Value() { }
        private System.Void set_Value(T value) { }
        private System.Void Invalidate() { }

    }

    // TypeToken: 0x2000347
    public class SortedDictionary`2, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary`2, IReadOnlyCollection`1
    {
        // Fields
        private System.Collections.Generic.SortedDictionary.KeyCollection<TKey,TValue> _keys;        // 0x0
        private System.Collections.Generic.SortedDictionary.ValueCollection<TKey,TValue> _values;        // 0x0
        private System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey,TValue>> _set;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Int32 get_Count() { }
        private System.Collections.Generic.SortedDictionary.KeyCollection<TKey,TValue> get_Keys() { }
        private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
        private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
        private System.Collections.Generic.SortedDictionary.ValueCollection<TKey,TValue> get_Values() { }
        private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
        private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Void Clear() { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Boolean ContainsValue(TValue value) { }
        private System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 index) { }
        private System.Collections.Generic.SortedDictionary.Enumerator<TKey,TValue> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
        private System.Boolean Remove(TKey key) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.IDictionary.get_IsFixedSize() { }
        private System.Boolean System.Collections.IDictionary.get_IsReadOnly() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values() { }
        private System.Object System.Collections.IDictionary.get_Item(System.Object key) { }
        private System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value) { }
        private System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        private System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        private System.Boolean IsCompatibleKey(System.Object key) { }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        private System.Void System.Collections.IDictionary.Remove(System.Object key) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000354
    public class TreeSet`1 : SortedSet`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<T> comparer) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context) { }
        private System.Boolean AddIfNotPresent(T item) { }

    }

    // TypeToken: 0x2000355
    public class SortedList`2, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary`2, IReadOnlyCollection`1
    {
        // Fields
        private TKey[] keys;        // 0x0
        private TValue[] values;        // 0x0
        private System.Int32 _size;        // 0x0
        private System.Int32 version;        // 0x0
        private System.Collections.Generic.IComparer<TKey> comparer;        // 0x0
        private System.Collections.Generic.SortedList.KeyList<TKey,TValue> keyList;        // 0x0
        private System.Collections.Generic.SortedList.ValueList<TKey,TValue> valueList;        // 0x0
        private System.Object _syncRoot;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }
        private System.Void .ctor(System.Int32 capacity, System.Collections.Generic.IComparer<TKey> comparer) { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        private System.Int32 get_Count() { }
        private System.Collections.Generic.IList<TKey> get_Keys() { }
        private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys() { }
        private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
        private System.Collections.Generic.IList<TValue> get_Values() { }
        private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values() { }
        private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
        private System.Collections.Generic.SortedList.KeyList<TKey,TValue> GetKeyListHelper() { }
        private System.Collections.Generic.SortedList.ValueList<TKey,TValue> GetValueListHelper() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
        private System.Boolean System.Collections.IDictionary.get_IsReadOnly() { }
        private System.Boolean System.Collections.IDictionary.get_IsFixedSize() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void Clear() { }
        private System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Boolean ContainsValue(TValue value) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Void EnsureCapacity(System.Int32 min) { }
        private TValue GetByIndex(System.Int32 index) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private TKey GetKey(System.Int32 index) { }
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Object System.Collections.IDictionary.get_Item(System.Object key) { }
        private System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value) { }
        private System.Int32 IndexOfKey(TKey key) { }
        private System.Int32 IndexOfValue(TValue value) { }
        private System.Void Insert(System.Int32 index, TKey key, TValue value) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Boolean Remove(TKey key) { }
        private System.Void System.Collections.IDictionary.Remove(System.Object key) { }
        private System.Boolean IsCompatibleKey(System.Object key) { }

    }

    // TypeToken: 0x200035B
    public class SortedSet`1, ISet`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection, IReadOnlyCollection`1, ISerializable, IDeserializationCallback
    {
        // Fields
        private System.Collections.Generic.SortedSet.Node<T> root;        // 0x0
        private System.Collections.Generic.IComparer<T> comparer;        // 0x0
        private System.Int32 count;        // 0x0
        private System.Int32 version;        // 0x0
        private System.Object _syncRoot;        // 0x0
        private System.Runtime.Serialization.SerializationInfo siInfo;        // 0x0
        private static System.String ComparerName;        // 0x0
        private static System.String CountName;        // 0x0
        private static System.String ItemsName;        // 0x0
        private static System.String VersionName;        // 0x0
        private static System.String TreeName;        // 0x0
        private static System.String NodeValueName;        // 0x0
        private static System.String EnumStartName;        // 0x0
        private static System.String ReverseName;        // 0x0
        private static System.String EnumVersionName;        // 0x0
        private static System.String MinName;        // 0x0
        private static System.String MaxName;        // 0x0
        private static System.String LowerBoundActiveName;        // 0x0
        private static System.String UpperBoundActiveName;        // 0x0
        private static System.Int32 StackAllocThreshold;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IComparer<T> comparer) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Boolean InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void VersionCheck() { }
        private System.Boolean IsWithinRange(T item) { }
        private System.Boolean Add(T item) { }
        private System.Void System.Collections.Generic.ICollection<T>.Add(T item) { }
        private System.Boolean AddIfNotPresent(T item) { }
        private System.Boolean Remove(T item) { }
        private System.Boolean DoRemove(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 index) { }
        private System.Void CopyTo(T[] array, System.Int32 index, System.Int32 count) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T>& parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent) { }
        private System.Void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild) { }
        private System.Void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor) { }
        private System.Collections.Generic.SortedSet.Node<T> FindNode(T item) { }
        private System.Void UpdateVersion() { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender) { }
        private System.Void OnDeserialization(System.Object sender) { }
        private System.Int32 Log2(System.Int32 value) { }

    }

    // TypeToken: 0x2000360
    public struct NodeColor
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Collections.Generic.NodeColor Black;        // 0x0
        public static System.Collections.Generic.NodeColor Red;        // 0x0

    }

    // TypeToken: 0x2000361
    public class TreeWalkPredicate`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Collections.Generic.SortedSet.Node<T> node) { }

    }

    // TypeToken: 0x2000362
    public struct TreeRotation
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Collections.Generic.TreeRotation Left;        // 0x0
        public static System.Collections.Generic.TreeRotation LeftRight;        // 0x0
        public static System.Collections.Generic.TreeRotation Right;        // 0x0
        public static System.Collections.Generic.TreeRotation RightLeft;        // 0x0

    }

    // TypeToken: 0x2000363
    public class CollectionDebugView`1
    {
    }

    // TypeToken: 0x2000364
    public interface ISet`1 : ICollection`1, IEnumerable`1, IEnumerable
    {
        // Methods
        private System.Boolean Add(T item) { }

    }

}

namespace System.Collections.ObjectModel
{

    // TypeToken: 0x200031F
    public class ObservableCollection`1 : Collection`1, INotifyCollectionChanged, INotifyPropertyChanged
    {
        // Fields
        private System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> _monitor;        // 0x0
        private System.Int32 _blockReentrancyCount;        // 0x0
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;        // 0x0
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }
        private System.Collections.Generic.List<T> CreateCopy(System.Collections.Generic.IEnumerable<T> collection, System.String paramName) { }
        private System.Void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void ClearItems() { }
        private System.Void RemoveItem(System.Int32 index) { }
        private System.Void InsertItem(System.Int32 index, T item) { }
        private System.Void SetItem(System.Int32 index, T item) { }
        private System.Void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
        private System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
        private System.Void CheckReentrancy() { }
        private System.Void OnCountPropertyChanged() { }
        private System.Void OnIndexerPropertyChanged() { }
        private System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object item, System.Int32 index) { }
        private System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object oldItem, System.Object newItem, System.Int32 index) { }
        private System.Void OnCollectionReset() { }
        private System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> EnsureMonitorInitialized() { }
        private System.Void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x2000321
    public class EventArgsCache
    {
        // Fields
        private static readonly System.ComponentModel.PropertyChangedEventArgs CountPropertyChanged;        // 0x0
        private static readonly System.ComponentModel.PropertyChangedEventArgs IndexerPropertyChanged;        // 0x8
        private static readonly System.Collections.Specialized.NotifyCollectionChangedEventArgs ResetCollectionChanged;        // 0x10

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000322
    public class ReadOnlyObservableCollection`1 : ReadOnlyCollection`1, INotifyCollectionChanged, INotifyPropertyChanged
    {
        // Fields
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;        // 0x0
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.ObjectModel.ObservableCollection<T> list) { }
        private System.Void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args) { }
        private System.Void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args) { }
        private System.Void HandleCollectionChanged(System.Object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
        private System.Void HandlePropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e) { }

    }

}

namespace System.Collections.Specialized
{

    // TypeToken: 0x2000323
    public struct BitVector32
    {
        // Fields
        private System.UInt32 _data;        // 0x10

        // Methods
        private System.Boolean get_Item(System.Int32 bit) { }
        private System.Void set_Item(System.Int32 bit, System.Boolean value) { }
        private System.Int32 CreateMask() { }
        private System.Int32 CreateMask(System.Int32 previous) { }
        private System.Boolean Equals(System.Object o) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString(System.Collections.Specialized.BitVector32 value) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000324
    public class ListDictionary, IDictionary, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.Specialized.ListDictionary.DictionaryNode head;        // 0x10
        private System.Int32 version;        // 0x18
        private System.Int32 count;        // 0x1C
        private readonly System.Collections.IComparer comparer;        // 0x20
        private System.Object _syncRoot;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.IComparer comparer) { }
        private System.Object get_Item(System.Object key) { }
        private System.Void set_Item(System.Object key, System.Object value) { }
        private System.Int32 get_Count() { }
        private System.Collections.ICollection get_Keys() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean get_IsFixedSize() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Collections.ICollection get_Values() { }
        private System.Void Add(System.Object key, System.Object value) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Object key) { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.IDictionaryEnumerator GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Remove(System.Object key) { }

    }

    // TypeToken: 0x2000329
    public class NameValueCollection : NameObjectCollectionBase
    {
        // Fields
        private System.String[] _all;        // 0x58
        private System.String[] _allKeys;        // 0x60

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity, System.Collections.IEqualityComparer equalityComparer) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void InvalidateCachedArrays() { }
        private System.String GetAsOneString(System.Collections.ArrayList list) { }
        private System.String[] GetAsStringArray(System.Collections.ArrayList list) { }
        private System.Void Add(System.String name, System.String value) { }
        private System.String Get(System.String name) { }
        private System.String[] GetValues(System.String name) { }
        private System.Void Set(System.String name, System.String value) { }
        private System.Void Remove(System.String name) { }
        private System.String get_Item(System.String name) { }
        private System.Void set_Item(System.String name, System.String value) { }
        private System.String Get(System.Int32 index) { }
        private System.String[] GetValues(System.Int32 index) { }
        private System.String GetKey(System.Int32 index) { }
        private System.String[] get_AllKeys() { }
        private System.Void .ctor(System.DBNull dummy) { }

    }

    // TypeToken: 0x200032A
    public class OrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
    {
        // Fields
        private System.Collections.ArrayList _objectsArray;        // 0x10
        private System.Collections.Hashtable _objectsTable;        // 0x18
        private System.Int32 _initialCapacity;        // 0x20
        private System.Collections.IEqualityComparer _comparer;        // 0x28
        private System.Boolean _readOnly;        // 0x30
        private System.Object _syncRoot;        // 0x38
        private System.Runtime.Serialization.SerializationInfo _siInfo;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Int32 capacity, System.Collections.IEqualityComparer comparer) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.IDictionary.get_IsFixedSize() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Collections.ICollection get_Keys() { }
        private System.Collections.ArrayList get_objectsArray() { }
        private System.Collections.Hashtable get_objectsTable() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Object get_Item(System.Object key) { }
        private System.Void set_Item(System.Object key, System.Object value) { }
        private System.Collections.ICollection get_Values() { }
        private System.Void Add(System.Object key, System.Object value) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Object key) { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Int32 IndexOfKey(System.Object key) { }
        private System.Void Remove(System.Object key) { }
        private System.Collections.IDictionaryEnumerator GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender) { }
        private System.Void OnDeserialization(System.Object sender) { }

    }

    // TypeToken: 0x200032D
    public class StringCollection, IList, ICollection, IEnumerable
    {
        // Fields
        private readonly System.Collections.ArrayList data;        // 0x10

        // Methods
        private System.String get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.String value) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.IList.get_IsReadOnly() { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Int32 Add(System.String value) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.String value) { }
        private System.Void CopyTo(System.String[] array, System.Int32 index) { }
        private System.Int32 IndexOf(System.String value) { }
        private System.Void Insert(System.Int32 index, System.String value) { }
        private System.Boolean get_IsSynchronized() { }
        private System.Void Remove(System.String value) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Object get_SyncRoot() { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032E
    public class StringDictionary, IEnumerable
    {
        // Fields
        private System.Collections.Hashtable contents;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.String key, System.String value) { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x200032F
    public interface INotifyCollectionChanged
    {
        // Methods
        private System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }

    }

    // TypeToken: 0x2000330
    public struct NotifyCollectionChangedAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Collections.Specialized.NotifyCollectionChangedAction Add;        // 0x0
        public static System.Collections.Specialized.NotifyCollectionChangedAction Remove;        // 0x0
        public static System.Collections.Specialized.NotifyCollectionChangedAction Replace;        // 0x0
        public static System.Collections.Specialized.NotifyCollectionChangedAction Move;        // 0x0
        public static System.Collections.Specialized.NotifyCollectionChangedAction Reset;        // 0x0

    }

    // TypeToken: 0x2000331
    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        // Fields
        private System.Collections.Specialized.NotifyCollectionChangedAction _action;        // 0x10
        private System.Collections.IList _newItems;        // 0x18
        private System.Collections.IList _oldItems;        // 0x20
        private System.Int32 _newStartingIndex;        // 0x28
        private System.Int32 _oldStartingIndex;        // 0x2C

        // Methods
        private System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action) { }
        private System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object changedItem, System.Int32 index) { }
        private System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object newItem, System.Object oldItem, System.Int32 index) { }
        private System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, System.Int32 startingIndex) { }
        private System.Void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, System.Int32 startingIndex) { }
        private System.Void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Int32 newStartingIndex) { }
        private System.Void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, System.Int32 oldStartingIndex) { }
        private System.Void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, System.Int32 startingIndex, System.Int32 oldStartingIndex) { }

    }

    // TypeToken: 0x2000332
    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }

    }

    // TypeToken: 0x2000333
    public class ReadOnlyList, IList, ICollection, IEnumerable
    {
        // Fields
        private readonly System.Collections.IList _list;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.IList list) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean get_IsFixedSize() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Object value) { }
        private System.Object get_SyncRoot() { }
        private System.Int32 Add(System.Object value) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Object value) { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 IndexOf(System.Object value) { }
        private System.Void Insert(System.Int32 index, System.Object value) { }
        private System.Void Remove(System.Object value) { }
        private System.Void RemoveAt(System.Int32 index) { }

    }

    // TypeToken: 0x2000334
    public class CaseSensitiveStringDictionary : StringDictionary
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.String key, System.String value) { }

    }

    // TypeToken: 0x2000335
    public class NameObjectCollectionBase, ICollection, IEnumerable, ISerializable, IDeserializationCallback
    {
        // Fields
        private static System.String ReadOnlyName;        // 0x0
        private static System.String CountName;        // 0x0
        private static System.String ComparerName;        // 0x0
        private static System.String HashCodeProviderName;        // 0x0
        private static System.String KeysName;        // 0x0
        private static System.String ValuesName;        // 0x0
        private static System.String KeyComparerName;        // 0x0
        private static System.String VersionName;        // 0x0
        private System.Boolean _readOnly;        // 0x10
        private System.Collections.ArrayList _entriesArray;        // 0x18
        private System.Collections.IEqualityComparer _keyComparer;        // 0x20
        private System.Collections.Hashtable _entriesTable;        // 0x28
        private System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;        // 0x30
        private System.Collections.Specialized.NameObjectCollectionBase.KeysCollection _keys;        // 0x38
        private System.Runtime.Serialization.SerializationInfo _serializationInfo;        // 0x40
        private System.Int32 _version;        // 0x48
        private System.Object _syncRoot;        // 0x50
        private static System.StringComparer defaultComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.IEqualityComparer equalityComparer) { }
        private System.Void .ctor(System.Int32 capacity, System.Collections.IEqualityComparer equalityComparer) { }
        private System.Void .ctor(System.DBNull dummy) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void OnDeserialization(System.Object sender) { }
        private System.Void Reset() { }
        private System.Void Reset(System.Int32 capacity) { }
        private System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(System.String key) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void BaseAdd(System.String name, System.Object value) { }
        private System.Void BaseRemove(System.String name) { }
        private System.Object BaseGet(System.String name) { }
        private System.Void BaseSet(System.String name, System.Object value) { }
        private System.Object BaseGet(System.Int32 index) { }
        private System.String BaseGetKey(System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 get_Count() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.String[] BaseGetAllKeys() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000339
    public class CompatibleComparer, IEqualityComparer
    {
        // Fields
        private System.Collections.IComparer _comparer;        // 0x10
        private static System.Collections.IComparer defaultComparer;        // 0x0
        private System.Collections.IHashCodeProvider _hcp;        // 0x18
        private static System.Collections.IHashCodeProvider defaultHashProvider;        // 0x8

        // Methods
        private System.Void .ctor(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider) { }
        private System.Boolean Equals(System.Object a, System.Object b) { }
        private System.Int32 GetHashCode(System.Object obj) { }
        private System.Collections.IComparer get_Comparer() { }
        private System.Collections.IHashCodeProvider get_HashCodeProvider() { }
        private System.Collections.IComparer get_DefaultComparer() { }
        private System.Collections.IHashCodeProvider get_DefaultHashCodeProvider() { }

    }

}

namespace System.ComponentModel
{

    // TypeToken: 0x2000293
    public class DefaultValueAttribute : Attribute
    {
        // Fields
        private System.Object _value;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Boolean value) { }
        private System.Void .ctor(System.String value) { }
        private System.Void .ctor(System.Object value) { }
        private System.Void .ctor(System.UInt32 value) { }
        private System.Object get_Value() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000294
    public class EditorBrowsableAttribute : Attribute
    {
        // Fields
        private System.ComponentModel.EditorBrowsableState browsableState;        // 0x10

        // Methods
        private System.Void .ctor(System.ComponentModel.EditorBrowsableState state) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000295
    public struct EditorBrowsableState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.ComponentModel.EditorBrowsableState Always;        // 0x0
        public static System.ComponentModel.EditorBrowsableState Never;        // 0x0
        public static System.ComponentModel.EditorBrowsableState Advanced;        // 0x0

    }

    // TypeToken: 0x2000296
    public class BrowsableAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.BrowsableAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.BrowsableAttribute No;        // 0x8
        public static readonly System.ComponentModel.BrowsableAttribute Default;        // 0x10
        private readonly System.Boolean <Browsable>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean browsable) { }
        private System.Boolean get_Browsable() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000297
    public class ComponentCollection : ReadOnlyCollectionBase
    {
        // Methods
        private System.ComponentModel.IComponent get_Item(System.String name) { }

    }

    // TypeToken: 0x2000298
    public class DescriptionAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.DescriptionAttribute Default;        // 0x0
        private System.String <DescriptionValue>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String description) { }
        private System.String get_Description() { }
        private System.String get_DescriptionValue() { }
        private System.Void set_DescriptionValue(System.String value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000299
    public class DesignOnlyAttribute : Attribute
    {
        // Fields
        private readonly System.Boolean <IsDesignOnly>k__BackingField;        // 0x10
        public static readonly System.ComponentModel.DesignOnlyAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.DesignOnlyAttribute No;        // 0x8
        public static readonly System.ComponentModel.DesignOnlyAttribute Default;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean isDesignOnly) { }
        private System.Boolean get_IsDesignOnly() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200029A
    public class DesignerCategoryAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.DesignerCategoryAttribute Component;        // 0x0
        public static readonly System.ComponentModel.DesignerCategoryAttribute Default;        // 0x8
        public static readonly System.ComponentModel.DesignerCategoryAttribute Form;        // 0x10
        public static readonly System.ComponentModel.DesignerCategoryAttribute Generic;        // 0x18
        private readonly System.String <Category>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String category) { }
        private System.String get_Category() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Object get_TypeId() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200029B
    public struct DesignerSerializationVisibility
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.ComponentModel.DesignerSerializationVisibility Hidden;        // 0x0
        public static System.ComponentModel.DesignerSerializationVisibility Visible;        // 0x0
        public static System.ComponentModel.DesignerSerializationVisibility Content;        // 0x0

    }

    // TypeToken: 0x200029C
    public class DesignerSerializationVisibilityAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Content;        // 0x0
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden;        // 0x8
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Visible;        // 0x10
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Default;        // 0x18
        private readonly System.ComponentModel.DesignerSerializationVisibility <Visibility>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.ComponentModel.DesignerSerializationVisibility visibility) { }
        private System.ComponentModel.DesignerSerializationVisibility get_Visibility() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200029D
    public class DisplayNameAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.DisplayNameAttribute Default;        // 0x0
        private System.String <DisplayNameValue>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String displayName) { }
        private System.String get_DisplayName() { }
        private System.String get_DisplayNameValue() { }
        private System.Void set_DisplayNameValue(System.String value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200029E
    public class EventHandlerList
    {
        // Fields
        private System.ComponentModel.EventHandlerList.ListEntry _head;        // 0x10
        private System.ComponentModel.Component _parent;        // 0x18

        // Methods
        private System.Delegate get_Item(System.Object key) { }
        private System.ComponentModel.EventHandlerList.ListEntry Find(System.Object key) { }

    }

    // TypeToken: 0x20002A0
    public interface IContainer : IDisposable
    {
        // Methods
        private System.ComponentModel.ComponentCollection get_Components() { }
        private System.Void Remove(System.ComponentModel.IComponent component) { }

    }

    // TypeToken: 0x20002A1
    public interface ISite : IServiceProvider
    {
        // Methods
        private System.ComponentModel.IContainer get_Container() { }
        private System.Boolean get_DesignMode() { }
        private System.String get_Name() { }

    }

    // TypeToken: 0x20002A2
    public interface ISynchronizeInvoke
    {
        // Methods
        private System.Boolean get_InvokeRequired() { }
        private System.IAsyncResult BeginInvoke(System.Delegate method, System.Object[] args) { }

    }

    // TypeToken: 0x20002A3
    public class InvalidEnumArgumentException : ArgumentException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String argumentName, System.Int32 invalidValue, System.Type enumClass) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x20002A4
    public class ReadOnlyAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.ReadOnlyAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.ReadOnlyAttribute No;        // 0x8
        public static readonly System.ComponentModel.ReadOnlyAttribute Default;        // 0x10
        private readonly System.Boolean <IsReadOnly>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean isReadOnly) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002A5
    public class AmbientValueAttribute : Attribute
    {
        // Fields
        private readonly System.Object <Value>k__BackingField;        // 0x10

        // Methods
        private System.Object get_Value() { }

    }

    // TypeToken: 0x20002A6
    public class ArrayConverter : CollectionConverter
    {
        // Methods
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A8
    public class AttributeCollection, ICollection, IEnumerable
    {
        // Fields
        public static readonly System.ComponentModel.AttributeCollection Empty;        // 0x0
        private static System.Collections.Hashtable s_defaultAttributes;        // 0x8
        private readonly System.Attribute[] _attributes;        // 0x10
        private static readonly System.Object s_internalSyncObject;        // 0x10
        private System.ComponentModel.AttributeCollection.AttributeEntry[] _foundAttributeTypes;        // 0x18
        private System.Int32 _index;        // 0x20

        // Methods
        private System.Void .ctor(System.Attribute[] attributes) { }
        private System.Attribute[] get_Attributes() { }
        private System.Int32 get_Count() { }
        private System.Attribute get_Item(System.Type attributeType) { }
        private System.Boolean Contains(System.Attribute attribute) { }
        private System.Attribute GetDefaultAttribute(System.Type attributeType) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002AA
    public class AttributeProviderAttribute : Attribute
    {
        // Fields
        private readonly System.String <TypeName>k__BackingField;        // 0x10
        private readonly System.String <PropertyName>k__BackingField;        // 0x18

        // Methods
        private System.String get_TypeName() { }
        private System.String get_PropertyName() { }

    }

    // TypeToken: 0x20002AB
    public class BaseNumberConverter : TypeConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_AllowHex() { }
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }

    }

    // TypeToken: 0x20002AC
    public class BooleanConverter : TypeConverter
    {
        // Fields
        private static System.ComponentModel.TypeConverter.StandardValuesCollection s_values;        // 0x0

        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AD
    public class ByteConverter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AE
    public class CharConverter : TypeConverter
    {
        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AF
    public struct CollectionChangeAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.ComponentModel.CollectionChangeAction Add;        // 0x0
        public static System.ComponentModel.CollectionChangeAction Remove;        // 0x0
        public static System.ComponentModel.CollectionChangeAction Refresh;        // 0x0

    }

    // TypeToken: 0x20002B0
    public class CollectionChangeEventArgs : EventArgs
    {
        // Fields
        private readonly System.ComponentModel.CollectionChangeAction <Action>k__BackingField;        // 0x10
        private readonly System.Object <Element>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.ComponentModel.CollectionChangeAction action, System.Object element) { }
        private System.ComponentModel.CollectionChangeAction get_Action() { }
        private System.Object get_Element() { }

    }

    // TypeToken: 0x20002B1
    public class CollectionChangeEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }

    }

    // TypeToken: 0x20002B2
    public class CultureInfoConverter : TypeConverter
    {
        // Fields
        private System.ComponentModel.TypeConverter.StandardValuesCollection _values;        // 0x10
        private static System.String DefaultInvariantCultureString;        // 0x0

        // Methods
        private System.String get_DefaultCultureString() { }
        private System.String GetCultureName(System.Globalization.CultureInfo culture) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B5
    public class CustomTypeDescriptor, ICustomTypeDescriptor
    {
        // Fields
        private readonly System.ComponentModel.ICustomTypeDescriptor _parent;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.ComponentModel.AttributeCollection GetAttributes() { }
        private System.ComponentModel.TypeConverter GetConverter() { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) { }
        private System.Object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }

    }

    // TypeToken: 0x20002B6
    public class DateTimeConverter : TypeConverter
    {
        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B7
    public class DecimalConverter : BaseNumberConverter
    {
        // Methods
        private System.Boolean get_AllowHex() { }
        private System.Type get_TargetType() { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B8
    public class DefaultEventAttribute : Attribute
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x10
        public static readonly System.ComponentModel.DefaultEventAttribute Default;        // 0x0

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.String get_Name() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002B9
    public class DefaultPropertyAttribute : Attribute
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x10
        public static readonly System.ComponentModel.DefaultPropertyAttribute Default;        // 0x0

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.String get_Name() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002BA
    public class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
    {
        // Fields
        private readonly System.Type _type;        // 0x20

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.ComponentModel.TypeDescriptionProvider get_Provider() { }
        private System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { }
        private System.Collections.IDictionary GetCache(System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance) { }
        private System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance) { }
        private System.Type GetReflectionType(System.Type objectType, System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance) { }

    }

    // TypeToken: 0x20002BB
    public class ToolboxItemAttribute : Attribute
    {
        // Fields
        private System.String _toolboxItemTypeName;        // 0x10
        public static readonly System.ComponentModel.ToolboxItemAttribute Default;        // 0x0
        public static readonly System.ComponentModel.ToolboxItemAttribute None;        // 0x8

        // Methods
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .ctor(System.Boolean defaultType) { }
        private System.Void .ctor(System.String toolboxItemTypeName) { }
        private System.String get_ToolboxItemTypeName() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002BC
    public class DesignTimeVisibleAttribute : Attribute
    {
        // Fields
        private readonly System.Boolean <Visible>k__BackingField;        // 0x10
        public static readonly System.ComponentModel.DesignTimeVisibleAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.DesignTimeVisibleAttribute No;        // 0x8
        public static readonly System.ComponentModel.DesignTimeVisibleAttribute Default;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean visible) { }
        private System.Boolean get_Visible() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002BD
    public class DoubleConverter : BaseNumberConverter
    {
        // Methods
        private System.Boolean get_AllowHex() { }
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BE
    public class EditorAttribute : Attribute
    {
        // Fields
        private System.String _typeId;        // 0x10
        private readonly System.String <EditorBaseTypeName>k__BackingField;        // 0x18
        private readonly System.String <EditorTypeName>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.String typeName, System.String baseTypeName) { }
        private System.String get_EditorBaseTypeName() { }
        private System.String get_EditorTypeName() { }
        private System.Object get_TypeId() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20002BF
    public class EventDescriptor : MemberDescriptor
    {
    }

    // TypeToken: 0x20002C0
    public class EventDescriptorCollection, ICollection, IEnumerable, IList
    {
        // Fields
        private System.ComponentModel.EventDescriptor[] _events;        // 0x10
        private System.String[] _namedSort;        // 0x18
        private readonly System.Collections.IComparer _comparer;        // 0x20
        private System.Boolean _eventsOwned;        // 0x28
        private System.Boolean _needSort;        // 0x29
        private readonly System.Boolean _readOnly;        // 0x2A
        public static readonly System.ComponentModel.EventDescriptorCollection Empty;        // 0x0
        private System.Int32 <Count>k__BackingField;        // 0x2C

        // Methods
        private System.Void .ctor(System.ComponentModel.EventDescriptor[] events) { }
        private System.Void .ctor(System.ComponentModel.EventDescriptor[] events, System.Boolean readOnly) { }
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.ComponentModel.EventDescriptor get_Item(System.Int32 index) { }
        private System.Int32 Add(System.ComponentModel.EventDescriptor value) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.ComponentModel.EventDescriptor value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Void EnsureEventsOwned() { }
        private System.Void EnsureSize(System.Int32 sizeNeeded) { }
        private System.Int32 IndexOf(System.ComponentModel.EventDescriptor value) { }
        private System.Void Insert(System.Int32 index, System.ComponentModel.EventDescriptor value) { }
        private System.Void Remove(System.ComponentModel.EventDescriptor value) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Void InternalSort(System.String[] names) { }
        private System.Void InternalSort(System.Collections.IComparer sorter) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Boolean System.Collections.IList.get_IsReadOnly() { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002C2
    public class ExpandableObjectConverter : TypeConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }

    }

    // TypeToken: 0x20002C3
    public class ExtendedPropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private readonly System.ComponentModel.ReflectPropertyDescriptor _extenderInfo;        // 0x88
        private readonly System.ComponentModel.IExtenderProvider _provider;        // 0x90

        // Methods
        private System.Void .ctor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes) { }
        private System.Boolean CanResetValue(System.Object comp) { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.String get_DisplayName() { }
        private System.Object GetValue(System.Object comp) { }
        private System.Void ResetValue(System.Object comp) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object comp) { }

    }

    // TypeToken: 0x20002C4
    public class ExtenderProvidedPropertyAttribute : Attribute
    {
        // Fields
        private System.ComponentModel.PropertyDescriptor <ExtenderProperty>k__BackingField;        // 0x10
        private System.ComponentModel.IExtenderProvider <Provider>k__BackingField;        // 0x18
        private System.Type <ReceiverType>k__BackingField;        // 0x20

        // Methods
        private System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider) { }
        private System.Void .ctor() { }
        private System.ComponentModel.PropertyDescriptor get_ExtenderProperty() { }
        private System.Void set_ExtenderProperty(System.ComponentModel.PropertyDescriptor value) { }
        private System.ComponentModel.IExtenderProvider get_Provider() { }
        private System.Void set_Provider(System.ComponentModel.IExtenderProvider value) { }
        private System.Type get_ReceiverType() { }
        private System.Void set_ReceiverType(System.Type value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }

    }

    // TypeToken: 0x20002C5
    public class GuidConverter : TypeConverter
    {
        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C6
    public interface IBindingList : IList, ICollection, IEnumerable
    {
    }

    // TypeToken: 0x20002C7
    public interface ICustomTypeDescriptor
    {
        // Methods
        private System.ComponentModel.AttributeCollection GetAttributes() { }
        private System.ComponentModel.TypeConverter GetConverter() { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) { }
        private System.Object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }

    }

    // TypeToken: 0x20002C8
    public interface IExtenderProvider
    {
        // Methods
        private System.Boolean CanExtend(System.Object extendee) { }

    }

    // TypeToken: 0x20002C9
    public interface ITypeDescriptorContext : IServiceProvider
    {
        // Methods
        private System.ComponentModel.IContainer get_Container() { }

    }

    // TypeToken: 0x20002CA
    public class Int16Converter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CB
    public class Int32Converter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CC
    public class Int64Converter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CD
    public class ListBindableAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.ListBindableAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.ListBindableAttribute No;        // 0x8
        public static readonly System.ComponentModel.ListBindableAttribute Default;        // 0x10
        private System.Boolean _isDefault;        // 0x10
        private readonly System.Boolean <ListBindable>k__BackingField;        // 0x11

        // Methods
        private System.Void .ctor(System.Boolean listBindable) { }
        private System.Boolean get_ListBindable() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002CE
    public class ListChangedEventArgs : EventArgs
    {
        // Fields
        private readonly System.ComponentModel.ListChangedType <ListChangedType>k__BackingField;        // 0x10
        private readonly System.Int32 <NewIndex>k__BackingField;        // 0x14
        private readonly System.Int32 <OldIndex>k__BackingField;        // 0x18
        private readonly System.ComponentModel.PropertyDescriptor <PropertyDescriptor>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.Int32 newIndex) { }
        private System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.Int32 newIndex, System.ComponentModel.PropertyDescriptor propDesc) { }
        private System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc) { }
        private System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.Int32 newIndex, System.Int32 oldIndex) { }
        private System.ComponentModel.ListChangedType get_ListChangedType() { }
        private System.Int32 get_NewIndex() { }
        private System.Int32 get_OldIndex() { }

    }

    // TypeToken: 0x20002CF
    public class ListChangedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.ComponentModel.ListChangedEventArgs e) { }

    }

    // TypeToken: 0x20002D0
    public struct ListChangedType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.ComponentModel.ListChangedType Reset;        // 0x0
        public static System.ComponentModel.ListChangedType ItemAdded;        // 0x0
        public static System.ComponentModel.ListChangedType ItemDeleted;        // 0x0
        public static System.ComponentModel.ListChangedType ItemMoved;        // 0x0
        public static System.ComponentModel.ListChangedType ItemChanged;        // 0x0
        public static System.ComponentModel.ListChangedType PropertyDescriptorAdded;        // 0x0
        public static System.ComponentModel.ListChangedType PropertyDescriptorDeleted;        // 0x0
        public static System.ComponentModel.ListChangedType PropertyDescriptorChanged;        // 0x0

    }

    // TypeToken: 0x20002D1
    public class MarshalByValueComponent, IComponent, IDisposable, IServiceProvider
    {
        // Fields
        private static readonly System.Object s_eventDisposed;        // 0x0
        private System.ComponentModel.ISite _site;        // 0x10
        private System.ComponentModel.EventHandlerList _events;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.ComponentModel.ISite get_Site() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Object GetService(System.Type service) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002D2
    public class MultilineStringConverter : TypeConverter
    {
        // Methods
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D3
    public class NullableConverter : TypeConverter
    {
        // Fields
        private readonly System.Type <NullableType>k__BackingField;        // 0x10
        private readonly System.Type <UnderlyingType>k__BackingField;        // 0x18
        private readonly System.ComponentModel.TypeConverter <UnderlyingTypeConverter>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { }
        private System.Boolean GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean IsValid(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }
        private System.Type get_NullableType() { }
        private System.Type get_UnderlyingType() { }
        private System.ComponentModel.TypeConverter get_UnderlyingTypeConverter() { }

    }

    // TypeToken: 0x20002D4
    public class PropertyDescriptor : MemberDescriptor
    {
        // Fields
        private System.ComponentModel.TypeConverter _converter;        // 0x60
        private System.Collections.Hashtable _valueChangedHandlers;        // 0x68
        private System.Object[] _editors;        // 0x70
        private System.Type[] _editorTypes;        // 0x78
        private System.Int32 _editorCount;        // 0x80

        // Methods
        private System.Void .ctor(System.String name, System.Attribute[] attrs) { }
        private System.Void .ctor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs) { }
        private System.Type get_ComponentType() { }
        private System.ComponentModel.TypeConverter get_Converter() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Object CreateInstance(System.Type type) { }
        private System.Void FillAttributes(System.Collections.IList attributeList) { }
        private System.Int32 GetHashCode() { }
        private System.Object GetInvocationTarget(System.Type type, System.Object instance) { }
        private System.Type GetTypeFromName(System.String typeName) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void OnValueChanged(System.Object component, System.EventArgs e) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x20002D5
    public class PropertyDescriptorCollection, ICollection, IEnumerable, IList, IDictionary
    {
        // Fields
        public static readonly System.ComponentModel.PropertyDescriptorCollection Empty;        // 0x0
        private System.Collections.IDictionary _cachedFoundProperties;        // 0x10
        private System.Boolean _cachedIgnoreCase;        // 0x18
        private System.ComponentModel.PropertyDescriptor[] _properties;        // 0x20
        private readonly System.String[] _namedSort;        // 0x28
        private readonly System.Collections.IComparer _comparer;        // 0x30
        private System.Boolean _propsOwned;        // 0x38
        private System.Boolean _needSort;        // 0x39
        private System.Boolean _readOnly;        // 0x3A
        private readonly System.Object _internalSyncObject;        // 0x40
        private System.Int32 <Count>k__BackingField;        // 0x48

        // Methods
        private System.Void .ctor(System.ComponentModel.PropertyDescriptor[] properties) { }
        private System.Void .ctor(System.ComponentModel.PropertyDescriptor[] properties, System.Boolean readOnly) { }
        private System.Void .ctor(System.ComponentModel.PropertyDescriptor[] properties, System.Int32 propCount, System.String[] namedSort, System.Collections.IComparer comparer) { }
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.ComponentModel.PropertyDescriptor get_Item(System.Int32 index) { }
        private System.ComponentModel.PropertyDescriptor get_Item(System.String name) { }
        private System.Int32 Add(System.ComponentModel.PropertyDescriptor value) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.ComponentModel.PropertyDescriptor value) { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Void EnsurePropsOwned() { }
        private System.Void EnsureSize(System.Int32 sizeNeeded) { }
        private System.ComponentModel.PropertyDescriptor Find(System.String name, System.Boolean ignoreCase) { }
        private System.Int32 IndexOf(System.ComponentModel.PropertyDescriptor value) { }
        private System.Void Insert(System.Int32 index, System.ComponentModel.PropertyDescriptor value) { }
        private System.Void Remove(System.ComponentModel.PropertyDescriptor value) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.ComponentModel.PropertyDescriptorCollection Sort(System.String[] names) { }
        private System.Void InternalSort(System.String[] names) { }
        private System.Void InternalSort(System.Collections.IComparer sorter) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Void System.Collections.IDictionary.Clear() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        private System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        private System.Boolean System.Collections.IDictionary.get_IsFixedSize() { }
        private System.Boolean System.Collections.IDictionary.get_IsReadOnly() { }
        private System.Object System.Collections.IDictionary.get_Item(System.Object key) { }
        private System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value) { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values() { }
        private System.Void System.Collections.IDictionary.Remove(System.Object key) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsReadOnly() { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002D7
    public class ProvidePropertyAttribute : Attribute
    {
        // Fields
        private readonly System.String <PropertyName>k__BackingField;        // 0x10
        private readonly System.String <ReceiverTypeName>k__BackingField;        // 0x18

        // Methods
        private System.String get_PropertyName() { }
        private System.String get_ReceiverTypeName() { }

    }

    // TypeToken: 0x20002D8
    public class ReferenceConverter : TypeConverter
    {
        // Fields
        private static readonly System.String s_none;        // 0x0
        private System.Type _type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002DA
    public class RefreshEventArgs : EventArgs
    {
        // Fields
        private readonly System.Type <TypeChanged>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Type typeChanged) { }

    }

    // TypeToken: 0x20002DB
    public class RefreshEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.ComponentModel.RefreshEventArgs e) { }

    }

    // TypeToken: 0x20002DC
    public class SByteConverter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DD
    public class SettingsBindableAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.SettingsBindableAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.SettingsBindableAttribute No;        // 0x8
        private readonly System.Boolean <Bindable>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean bindable) { }
        private System.Boolean get_Bindable() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002DE
    public class SingleConverter : BaseNumberConverter
    {
        // Methods
        private System.Boolean get_AllowHex() { }
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DF
    public class StringConverter : TypeConverter
    {
        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E0
    public class TimeSpanConverter : TypeConverter
    {
        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E1
    public class TypeConverterAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.TypeConverterAttribute Default;        // 0x0
        private readonly System.String <ConverterTypeName>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type type) { }
        private System.Void .ctor(System.String typeName) { }
        private System.String get_ConverterTypeName() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002E2
    public class TypeDescriptionProvider
    {
        // Fields
        private readonly System.ComponentModel.TypeDescriptionProvider _parent;        // 0x10
        private System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { }
        private System.Collections.IDictionary GetCache(System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance) { }
        private System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance) { }
        private System.Type GetReflectionType(System.Type objectType) { }
        private System.Type GetReflectionType(System.Type objectType, System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType) { }
        private System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Object instance) { }
        private System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance) { }

    }

    // TypeToken: 0x20002E4
    public class TypeDescriptionProviderAttribute : Attribute
    {
        // Fields
        private readonly System.String <TypeName>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.String typeName) { }
        private System.String get_TypeName() { }

    }

    // TypeToken: 0x20002E5
    public class TypeListConverter : TypeConverter
    {
        // Fields
        private readonly System.Type[] _types;        // 0x10
        private System.ComponentModel.TypeConverter.StandardValuesCollection _values;        // 0x18

        // Methods
        private System.Void .ctor(System.Type[] types) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }

    }

    // TypeToken: 0x20002E6
    public class UInt16Converter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E7
    public class UInt32Converter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E8
    public class UInt64Converter : BaseNumberConverter
    {
        // Methods
        private System.Type get_TargetType() { }
        private System.Object FromString(System.String value, System.Int32 radix) { }
        private System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E9
    public interface IChangeTracking
    {
        // Methods
        private System.Boolean get_IsChanged() { }
        private System.Void AcceptChanges() { }

    }

    // TypeToken: 0x20002EA
    public interface IRevertibleChangeTracking : IChangeTracking
    {
        // Methods
        private System.Void RejectChanges() { }

    }

    // TypeToken: 0x20002EB
    public interface INotifyPropertyChanged
    {
        // Methods
        private System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }

    }

    // TypeToken: 0x20002EC
    public class PropertyChangedEventArgs : EventArgs
    {
        // Fields
        private readonly System.String _propertyName;        // 0x10

        // Methods
        private System.Void .ctor(System.String propertyName) { }

    }

    // TypeToken: 0x20002ED
    public class PropertyChangedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e) { }

    }

    // TypeToken: 0x20002EE
    public class PropertyChangingEventArgs : EventArgs
    {
        // Fields
        private readonly System.String _propertyName;        // 0x10

        // Methods
        private System.Void .ctor(System.String propertyName) { }

    }

    // TypeToken: 0x20002EF
    public class PropertyChangingEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.ComponentModel.PropertyChangingEventArgs e) { }

    }

    // TypeToken: 0x20002F0
    public class CategoryAttribute : Attribute
    {
        // Fields
        private System.Boolean localized;        // 0x10
        private System.String categoryValue;        // 0x18

        // Methods
        private System.String get_Category() { }
        private System.String GetLocalizedString(System.String value) { }

    }

    // TypeToken: 0x20002F1
    public class CollectionConverter : TypeConverter
    {
        // Methods
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F2
    public class Component : MarshalByRefObject, IComponent, IDisposable
    {
        // Fields
        private static readonly System.Object EventDisposed;        // 0x0
        private System.ComponentModel.ISite site;        // 0x18
        private System.ComponentModel.EventHandlerList events;        // 0x20

        // Methods
        private System.Void Finalize() { }
        private System.Boolean get_CanRaiseEvents() { }
        private System.Boolean get_CanRaiseEventsInternal() { }
        private System.ComponentModel.ISite get_Site() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Object GetService(System.Type service) { }
        private System.Boolean get_DesignMode() { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002F3
    public class ComponentConverter : ReferenceConverter
    {
        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }

    }

    // TypeToken: 0x20002F4
    public class DateTimeOffsetConverter : TypeConverter
    {
        // Methods
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F5
    public class EnumConverter : TypeConverter
    {
        // Fields
        private System.ComponentModel.TypeConverter.StandardValuesCollection values;        // 0x10
        private System.Type type;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Type get_EnumType() { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection get_Values() { }
        private System.Void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Collections.IComparer get_Comparer() { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean IsValid(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }

    }

    // TypeToken: 0x20002F6
    public interface IComponent : IDisposable
    {
        // Methods
        private System.ComponentModel.ISite get_Site() { }

    }

    // TypeToken: 0x20002F7
    public class MemberDescriptor
    {
        // Fields
        private System.String name;        // 0x10
        private System.String displayName;        // 0x18
        private System.Int32 nameHash;        // 0x20
        private System.ComponentModel.AttributeCollection attributeCollection;        // 0x28
        private System.Attribute[] attributes;        // 0x30
        private System.Attribute[] originalAttributes;        // 0x38
        private System.Boolean attributesFiltered;        // 0x40
        private System.Boolean attributesFilled;        // 0x41
        private System.Int32 metadataVersion;        // 0x44
        private System.String category;        // 0x48
        private System.String description;        // 0x50
        private System.Object lockCookie;        // 0x58

        // Methods
        private System.Void .ctor(System.String name, System.Attribute[] attributes) { }
        private System.Void .ctor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes) { }
        private System.Attribute[] get_AttributeArray() { }
        private System.Void set_AttributeArray(System.Attribute[] value) { }
        private System.ComponentModel.AttributeCollection get_Attributes() { }
        private System.String get_Name() { }
        private System.Int32 get_NameHashCode() { }
        private System.String get_DisplayName() { }
        private System.Void CheckAttributesValid() { }
        private System.ComponentModel.AttributeCollection CreateAttributeCollection() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Void FillAttributes(System.Collections.IList attributeList) { }
        private System.Void FilterAttributesIfNeeded() { }
        private System.Reflection.MethodInfo FindMethod(System.Type componentClass, System.String name, System.Type[] args, System.Type returnType) { }
        private System.Reflection.MethodInfo FindMethod(System.Type componentClass, System.String name, System.Type[] args, System.Type returnType, System.Boolean publicOnly) { }
        private System.Int32 GetHashCode() { }
        private System.Object GetInvocationTarget(System.Type type, System.Object instance) { }
        private System.ComponentModel.ISite GetSite(System.Object component) { }

    }

    // TypeToken: 0x20002F8
    public class ReflectPropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private static readonly System.Type[] argsNone;        // 0x0
        private static readonly System.Object noValue;        // 0x8
        private static System.Diagnostics.TraceSwitch PropDescCreateSwitch;        // 0x10
        private static System.Diagnostics.TraceSwitch PropDescUsageSwitch;        // 0x18
        private static readonly System.Int32 BitDefaultValueQueried;        // 0x20
        private static readonly System.Int32 BitGetQueried;        // 0x24
        private static readonly System.Int32 BitSetQueried;        // 0x28
        private static readonly System.Int32 BitShouldSerializeQueried;        // 0x2C
        private static readonly System.Int32 BitResetQueried;        // 0x30
        private static readonly System.Int32 BitChangedQueried;        // 0x34
        private static readonly System.Int32 BitIPropChangedQueried;        // 0x38
        private static readonly System.Int32 BitReadOnlyChecked;        // 0x3C
        private static readonly System.Int32 BitAmbientValueQueried;        // 0x40
        private static readonly System.Int32 BitSetOnDemand;        // 0x44
        private System.Collections.Specialized.BitVector32 state;        // 0x88
        private System.Type componentClass;        // 0x90
        private System.Type type;        // 0x98
        private System.Object defaultValue;        // 0xA0
        private System.Object ambientValue;        // 0xA8
        private System.Reflection.PropertyInfo propInfo;        // 0xB0
        private System.Reflection.MethodInfo getMethod;        // 0xB8
        private System.Reflection.MethodInfo setMethod;        // 0xC0
        private System.Reflection.MethodInfo shouldSerializeMethod;        // 0xC8
        private System.Reflection.MethodInfo resetMethod;        // 0xD0
        private System.ComponentModel.EventDescriptor realChangedEvent;        // 0xD8
        private System.Type receiverType;        // 0xE0

        // Methods
        private System.Void .ctor(System.Type componentClass, System.String name, System.Type type, System.Attribute[] attributes) { }
        private System.Void .ctor(System.Type componentClass, System.String name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs) { }
        private System.Void .ctor(System.Type componentClass, System.String name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs) { }
        private System.Object get_AmbientValue() { }
        private System.Type get_ComponentType() { }
        private System.Object get_DefaultValue() { }
        private System.Reflection.MethodInfo get_GetMethodValue() { }
        private System.Boolean get_IsExtender() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Reflection.MethodInfo get_ResetMethodValue() { }
        private System.Reflection.MethodInfo get_SetMethodValue() { }
        private System.Reflection.MethodInfo get_ShouldSerializeMethodValue() { }
        private System.Boolean ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, System.Object component) { }
        private System.Type ExtenderGetReceiverType() { }
        private System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider) { }
        private System.Object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, System.Object component) { }
        private System.Void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, System.Object component, System.ComponentModel.PropertyDescriptor notifyDesc) { }
        private System.Void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, System.Object component, System.Object value, System.ComponentModel.PropertyDescriptor notifyDesc) { }
        private System.Boolean ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, System.Object component) { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Void FillAttributes(System.Collections.IList attributes) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void OnValueChanged(System.Object component, System.EventArgs e) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002F9
    public class ReflectTypeDescriptionProvider : TypeDescriptionProvider
    {
        // Fields
        private System.Collections.Hashtable _typeData;        // 0x20
        private static System.Type[] _typeConstructor;        // 0x0
        private static System.Collections.Hashtable _intrinsicTypeConverters;        // 0x8
        private static System.Object _intrinsicReferenceKey;        // 0x10
        private static System.Object _intrinsicNullableKey;        // 0x18
        private static System.Object _dictionaryKey;        // 0x20
        private static System.Collections.Hashtable _propertyCache;        // 0x28
        private static System.Collections.Hashtable _attributeCache;        // 0x30
        private static System.Collections.Hashtable _extendedPropertyCache;        // 0x38
        private static readonly System.Guid _extenderProviderKey;        // 0x40
        private static readonly System.Guid _extenderPropertiesKey;        // 0x50
        private static readonly System.Guid _extenderProviderPropertiesKey;        // 0x60
        private static readonly System.Type[] _skipInterfaceAttributeList;        // 0x70
        private static System.Object _internalSyncObject;        // 0x78

        // Methods
        private System.Void .ctor() { }
        private System.Collections.Hashtable get_IntrinsicTypeConverters() { }
        private System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { }
        private System.Object CreateInstance(System.Type objectType, System.Type callingType) { }
        private System.ComponentModel.AttributeCollection GetAttributes(System.Type type) { }
        private System.Collections.IDictionary GetCache(System.Object instance) { }
        private System.ComponentModel.TypeConverter GetConverter(System.Type type, System.Object instance) { }
        private System.ComponentModel.AttributeCollection GetExtendedAttributes(System.Object instance) { }
        private System.ComponentModel.TypeConverter GetExtendedConverter(System.Object instance) { }
        private System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(System.Object instance) { }
        private System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance) { }
        private System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, System.Object instance, System.Collections.IDictionary cache) { }
        private System.Object GetExtendedPropertyOwner(System.Object instance, System.ComponentModel.PropertyDescriptor pd) { }
        private System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type) { }
        private System.Object GetPropertyOwner(System.Type type, System.Object instance, System.ComponentModel.PropertyDescriptor pd) { }
        private System.Type GetReflectionType(System.Type objectType, System.Object instance) { }
        private System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, System.Boolean createIfNeeded) { }
        private System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance) { }
        private System.Type GetTypeFromName(System.String typeName) { }
        private System.Boolean IsPopulated(System.Type type) { }
        private System.Attribute[] ReflectGetAttributes(System.Type type) { }
        private System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member) { }
        private System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider) { }
        private System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type) { }
        private System.Void Refresh(System.Type type) { }
        private System.Object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002FB
    public class TypeConverter
    {
        // Fields
        private static System.String s_UseCompatibleTypeConverterBehavior;        // 0x0
        private static System.Boolean useCompatibleTypeConversion;        // 0x0

        // Methods
        private System.Boolean get_UseCompatibleTypeConversion() { }
        private System.Boolean CanConvertFrom(System.Type sourceType) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Boolean CanConvertTo(System.Type destinationType) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertFrom(System.Object value) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object ConvertFromInvariantString(System.String text) { }
        private System.Object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, System.String text) { }
        private System.Object ConvertFromString(System.String text) { }
        private System.Object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.String text) { }
        private System.Object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.String text) { }
        private System.Object ConvertTo(System.Object value, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.String ConvertToInvariantString(System.Object value) { }
        private System.String ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }
        private System.String ConvertToString(System.Object value) { }
        private System.String ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }
        private System.String ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.Object CreateInstance(System.Collections.IDictionary propertyValues) { }
        private System.Object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { }
        private System.Exception GetConvertFromException(System.Object value) { }
        private System.Exception GetConvertToException(System.Object value, System.Type destinationType) { }
        private System.Boolean GetCreateInstanceSupported() { }
        private System.Boolean GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object value) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes) { }
        private System.Boolean GetPropertiesSupported() { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Collections.ICollection GetStandardValues() { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive() { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported() { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean IsValid(System.Object value) { }
        private System.Boolean IsValid(System.ComponentModel.ITypeDescriptorContext context, System.Object value) { }
        private System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, System.String[] names) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FE
    public class TypeDescriptor
    {
        // Fields
        private static System.ComponentModel.WeakHashtable _providerTable;        // 0x0
        private static System.Collections.Hashtable _providerTypeTable;        // 0x8
        private static System.Collections.Hashtable _defaultProviders;        // 0x10
        private static System.ComponentModel.WeakHashtable _associationTable;        // 0x18
        private static System.Int32 _metadataVersion;        // 0x20
        private static System.Int32 _collisionIndex;        // 0x24
        private static System.Diagnostics.BooleanSwitch TraceDescriptor;        // 0x28
        private static readonly System.Guid[] _pipelineInitializeKeys;        // 0x30
        private static readonly System.Guid[] _pipelineMergeKeys;        // 0x38
        private static readonly System.Guid[] _pipelineFilterKeys;        // 0x40
        private static readonly System.Guid[] _pipelineAttributeFilterKeys;        // 0x48
        private static System.Object _internalSyncObject;        // 0x50
        private static System.ComponentModel.RefreshEventHandler Refreshed;        // 0x58

        // Methods
        private System.Type get_ComObjectType() { }
        private System.Type get_InterfaceType() { }
        private System.Int32 get_MetadataVersion() { }
        private System.Void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
        private System.Void CheckDefaultProvider(System.Type type) { }
        private System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { }
        private System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes) { }
        private System.Object GetAssociation(System.Type type, System.Object primary) { }
        private System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType) { }
        private System.ComponentModel.AttributeCollection GetAttributes(System.Object component) { }
        private System.ComponentModel.AttributeCollection GetAttributes(System.Object component, System.Boolean noCustomTypeDesc) { }
        private System.Collections.IDictionary GetCache(System.Object instance) { }
        private System.ComponentModel.TypeConverter GetConverter(System.Type type) { }
        private System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, System.String typeName) { }
        private System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Object component, System.Boolean noCustomTypeDesc) { }
        private System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(System.Object component) { }
        private System.String GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member) { }
        private System.Type GetNodeForBaseType(System.Type searchType) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component, System.Boolean noCustomTypeDesc) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component, System.Attribute[] attributes) { }
        private System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component, System.Attribute[] attributes, System.Boolean noCustomTypeDesc) { }
        private System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(System.Object component, System.Attribute[] attributes, System.Boolean noCustomTypeDesc, System.Boolean noAttributes) { }
        private System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type) { }
        private System.Type GetReflectionType(System.Type type) { }
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type) { }
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, System.Boolean createDelegator) { }
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Object instance) { }
        private System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Object instance, System.Boolean createDelegator) { }
        private System.Collections.ICollection PipelineAttributeFilter(System.Int32 pipelineType, System.Collections.ICollection members, System.Attribute[] filter, System.Object instance, System.Collections.IDictionary cache) { }
        private System.Collections.ICollection PipelineFilter(System.Int32 pipelineType, System.Collections.ICollection members, System.Object instance, System.Collections.IDictionary cache) { }
        private System.Collections.ICollection PipelineInitialize(System.Int32 pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache) { }
        private System.Collections.ICollection PipelineMerge(System.Int32 pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, System.Object instance, System.Collections.IDictionary cache) { }
        private System.Void RaiseRefresh(System.Type type) { }
        private System.Void Refresh(System.Type type) { }
        private System.Boolean ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute) { }
        private System.Void SortDescriptorArray(System.Collections.IList infos) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000309
    public class Win32Exception : ExternalException, ISerializable
    {
        // Fields
        private readonly System.Int32 nativeErrorCode;        // 0x90

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 error) { }
        private System.Void .ctor(System.Int32 error, System.String message) { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Int32 get_NativeErrorCode() { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.String GetErrorMessage(System.Int32 error) { }

    }

    // TypeToken: 0x200030A
    public class NotifyParentPropertyAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.NotifyParentPropertyAttribute Yes;        // 0x0
        public static readonly System.ComponentModel.NotifyParentPropertyAttribute No;        // 0x8
        public static readonly System.ComponentModel.NotifyParentPropertyAttribute Default;        // 0x10
        private System.Boolean notifyParent;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean notifyParent) { }
        private System.Boolean get_NotifyParent() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200030B
    public struct RefreshProperties
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.ComponentModel.RefreshProperties None;        // 0x0
        public static System.ComponentModel.RefreshProperties All;        // 0x0
        public static System.ComponentModel.RefreshProperties Repaint;        // 0x0

    }

    // TypeToken: 0x200030C
    public class RefreshPropertiesAttribute : Attribute
    {
        // Fields
        public static readonly System.ComponentModel.RefreshPropertiesAttribute All;        // 0x0
        public static readonly System.ComponentModel.RefreshPropertiesAttribute Repaint;        // 0x8
        public static readonly System.ComponentModel.RefreshPropertiesAttribute Default;        // 0x10
        private System.ComponentModel.RefreshProperties refresh;        // 0x10

        // Methods
        private System.Void .ctor(System.ComponentModel.RefreshProperties refresh) { }
        private System.ComponentModel.RefreshProperties get_RefreshProperties() { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean IsDefaultAttribute() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200030D
    public class WeakHashtable : Hashtable
    {
        // Fields
        private static System.Collections.IEqualityComparer _comparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Clear() { }
        private System.Void Remove(System.Object key) { }
        private System.Void .cctor() { }

    }

}

namespace System.ComponentModel.Design
{

    // TypeToken: 0x200030F
    public class CheckoutException : ExternalException
    {
        // Fields
        public static readonly System.ComponentModel.Design.CheckoutException Canceled;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message, System.Int32 errorCode) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000310
    public interface IComponentChangeService
    {
        // Methods
        private System.Void OnComponentChanged(System.Object component, System.ComponentModel.MemberDescriptor member, System.Object oldValue, System.Object newValue) { }
        private System.Void OnComponentChanging(System.Object component, System.ComponentModel.MemberDescriptor member) { }

    }

    // TypeToken: 0x2000311
    public interface IDesigner : IDisposable
    {
    }

    // TypeToken: 0x2000312
    public interface IDesignerHost : IServiceProvider
    {
        // Methods
        private System.ComponentModel.IComponent get_RootComponent() { }
        private System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component) { }

    }

    // TypeToken: 0x2000313
    public interface IDictionaryService
    {
        // Methods
        private System.Object GetValue(System.Object key) { }
        private System.Void SetValue(System.Object key, System.Object value) { }

    }

    // TypeToken: 0x2000314
    public interface IExtenderListService
    {
        // Methods
        private System.ComponentModel.IExtenderProvider[] GetExtenderProviders() { }

    }

    // TypeToken: 0x2000315
    public interface IReferenceService
    {
        // Methods
        private System.Object GetReference(System.String name) { }
        private System.String GetName(System.Object reference) { }
        private System.Object[] GetReferences(System.Type baseType) { }

    }

    // TypeToken: 0x2000316
    public interface ITypeDescriptorFilterService
    {
        // Methods
        private System.Boolean FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes) { }
        private System.Boolean FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events) { }
        private System.Boolean FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties) { }

    }

    // TypeToken: 0x2000317
    public class DesignerOptionService
    {
        // Methods
        private System.Void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }

    }

}

namespace System.ComponentModel.Design.Serialization
{

    // TypeToken: 0x200031C
    public class InstanceDescriptor
    {
        // Fields
        private readonly System.Collections.ICollection <Arguments>k__BackingField;        // 0x10
        private readonly System.Boolean <IsComplete>k__BackingField;        // 0x18
        private readonly System.Reflection.MemberInfo <MemberInfo>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments) { }
        private System.Void .ctor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, System.Boolean isComplete) { }
        private System.Collections.ICollection get_Arguments() { }
        private System.Reflection.MemberInfo get_MemberInfo() { }
        private System.Object Invoke() { }

    }

    // TypeToken: 0x200031D
    public class RootDesignerSerializerAttribute : Attribute
    {
        // Fields
        private System.String _typeId;        // 0x10
        private readonly System.Boolean <Reloadable>k__BackingField;        // 0x18
        private readonly System.String <SerializerTypeName>k__BackingField;        // 0x20
        private readonly System.String <SerializerBaseTypeName>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.String serializerTypeName, System.String baseSerializerTypeName, System.Boolean reloadable) { }
        private System.String get_SerializerBaseTypeName() { }
        private System.Object get_TypeId() { }

    }

}

namespace System.Configuration
{

    // TypeToken: 0x2000379
    public interface IConfigurationSectionHandler
    {
    }

}

namespace System.Diagnostics
{

    // TypeToken: 0x20000F8
    public class BooleanSwitch : Switch
    {
        // Methods
        private System.Void .ctor(System.String displayName, System.String description) { }

    }

    // TypeToken: 0x20000F9
    public class Switch
    {
        // Fields
        private readonly System.String description;        // 0x10
        private readonly System.String displayName;        // 0x18
        private System.String switchValueString;        // 0x20
        private System.String defaultValue;        // 0x28
        private static System.Collections.Generic.List<System.WeakReference> switches;        // 0x0
        private static System.Int32 s_LastCollectionCount;        // 0x8

        // Methods
        private System.Void .ctor(System.String displayName, System.String description) { }
        private System.Void .ctor(System.String displayName, System.String description, System.String defaultSwitchValue) { }
        private System.Void _pruneCachedSwitches() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FA
    public class SwitchLevelAttribute : Attribute
    {
        // Fields
        private System.Type type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type switchLevelType) { }
        private System.Void set_SwitchLevelType(System.Type value) { }

    }

    // TypeToken: 0x20000FB
    public struct TraceLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Diagnostics.TraceLevel Off;        // 0x0
        public static System.Diagnostics.TraceLevel Error;        // 0x0
        public static System.Diagnostics.TraceLevel Warning;        // 0x0
        public static System.Diagnostics.TraceLevel Info;        // 0x0
        public static System.Diagnostics.TraceLevel Verbose;        // 0x0

    }

    // TypeToken: 0x20000FC
    public class TraceSwitch : Switch
    {
        // Methods
        private System.Void .ctor(System.String displayName, System.String description) { }

    }

    // TypeToken: 0x20000FD
    public class AsyncStreamReader
    {
        // Fields
        private System.IO.Stream stream;        // 0x10
        private System.Text.Encoding encoding;        // 0x18
        private System.Text.Decoder decoder;        // 0x20
        private System.Byte[] byteBuffer;        // 0x28
        private System.Char[] charBuffer;        // 0x30
        private System.Boolean cancelOperation;        // 0x38
        private System.Threading.ManualResetEvent eofEvent;        // 0x40
        private System.Object syncObject;        // 0x48
        private System.IAsyncResult asyncReadResult;        // 0x50

        // Methods
        private System.Void Close() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void CancelOperation() { }
        private System.Void WaitUtilEOF() { }

    }

    // TypeToken: 0x20000FE
    public class Process : Component
    {
        // Fields
        private System.Boolean haveProcessId;        // 0x28
        private System.Int32 processId;        // 0x2C
        private System.Boolean haveProcessHandle;        // 0x30
        private Microsoft.Win32.SafeHandles.SafeProcessHandle m_processHandle;        // 0x38
        private System.Boolean isRemoteMachine;        // 0x40
        private System.String machineName;        // 0x48
        private System.Int32 m_processAccess;        // 0x50
        private System.Diagnostics.ProcessThreadCollection threads;        // 0x58
        private System.Diagnostics.ProcessModuleCollection modules;        // 0x60
        private System.Boolean haveWorkingSetLimits;        // 0x68
        private System.Boolean havePriorityClass;        // 0x69
        private System.Diagnostics.ProcessStartInfo startInfo;        // 0x70
        private System.Boolean watchForExit;        // 0x78
        private System.Boolean watchingForExit;        // 0x79
        private System.EventHandler onExited;        // 0x80
        private System.Boolean exited;        // 0x88
        private System.Int32 exitCode;        // 0x8C
        private System.Boolean signaled;        // 0x90
        private System.Boolean haveExitTime;        // 0x91
        private System.Boolean raisedOnExited;        // 0x92
        private System.Threading.RegisteredWaitHandle registeredWaitHandle;        // 0x98
        private System.Threading.WaitHandle waitHandle;        // 0xA0
        private System.ComponentModel.ISynchronizeInvoke synchronizingObject;        // 0xA8
        private System.IO.StreamReader standardOutput;        // 0xB0
        private System.IO.StreamWriter standardInput;        // 0xB8
        private System.IO.StreamReader standardError;        // 0xC0
        private System.Boolean disposed;        // 0xC8
        private System.Diagnostics.Process.StreamReadMode outputStreamReadMode;        // 0xCC
        private System.Diagnostics.Process.StreamReadMode errorStreamReadMode;        // 0xD0
        private System.Diagnostics.Process.StreamReadMode inputStreamReadMode;        // 0xD4
        private System.Diagnostics.AsyncStreamReader output;        // 0xD8
        private System.Diagnostics.AsyncStreamReader error;        // 0xE0
        private System.String process_name;        // 0xE8

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String machineName, System.Boolean isRemoteMachine, System.Int32 processId, System.Diagnostics.ProcessInfo processInfo) { }
        private System.Boolean get_Associated() { }
        private System.Int32 get_ExitCode() { }
        private System.Boolean get_HasExited() { }
        private System.IntPtr get_Handle() { }
        private System.Int32 get_Id() { }
        private System.Diagnostics.ProcessStartInfo get_StartInfo() { }
        private System.Void set_StartInfo(System.Diagnostics.ProcessStartInfo value) { }
        private System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject() { }
        private System.IO.StreamReader get_StandardOutput() { }
        private System.Void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle) { }
        private System.Void CompletionCallback(System.Object context, System.Boolean wasSignaled) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Close() { }
        private System.Void EnsureState(System.Diagnostics.Process.State state) { }
        private System.Void EnsureWatchingForExit() { }
        private System.Diagnostics.Process GetProcessById(System.Int32 processId) { }
        private System.Diagnostics.Process GetCurrentProcess() { }
        private System.Void OnExited() { }
        private Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(System.Int32 access, System.Boolean throwIfExited) { }
        private Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(System.Int32 access) { }
        private Microsoft.Win32.SafeHandles.SafeProcessHandle OpenProcessHandle(System.Int32 access) { }
        private System.Void Refresh() { }
        private System.Void SetProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle) { }
        private System.Void SetProcessId(System.Int32 processId) { }
        private System.Boolean Start() { }
        private System.Diagnostics.Process Start(System.String fileName) { }
        private System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo) { }
        private System.Void StopWatchingForExit() { }
        private System.String ToString() { }
        private System.Boolean WaitForExit(System.Int32 milliseconds) { }
        private System.Void WaitForExit() { }
        private System.Void .ctor(Microsoft.Win32.SafeHandles.SafeProcessHandle handle, System.Int32 id) { }
        private System.String ProcessName_icall(System.IntPtr handle) { }
        private System.String ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle) { }
        private System.String get_ProcessName() { }
        private System.IntPtr GetProcess_internal(System.Int32 pid) { }
        private System.Diagnostics.Process GetProcessById(System.Int32 processId, System.String machineName) { }
        private System.Boolean IsLocalMachine(System.String machineName) { }
        private System.Boolean ShellExecuteEx_internal(System.Diagnostics.ProcessStartInfo startInfo, System.Diagnostics.Process.ProcInfo& procInfo) { }
        private System.Boolean CreateProcess_internal(System.Diagnostics.ProcessStartInfo startInfo, System.IntPtr stdin, System.IntPtr stdout, System.IntPtr stderr, System.Diagnostics.Process.ProcInfo& procInfo) { }
        private System.Boolean StartWithShellExecuteEx(System.Diagnostics.ProcessStartInfo startInfo) { }
        private System.Void CreatePipe(System.IntPtr& read, System.IntPtr& write, System.Boolean writeDirection) { }
        private System.Boolean get_IsWindows() { }
        private System.Boolean StartWithCreateProcess(System.Diagnostics.ProcessStartInfo startInfo) { }
        private System.Void FillUserInfo(System.Diagnostics.ProcessStartInfo startInfo, System.Diagnostics.Process.ProcInfo& procInfo) { }
        private System.Void RaiseOnExited() { }

    }

    // TypeToken: 0x2000102
    public class ProcessInfo
    {
    }

    // TypeToken: 0x2000103
    public class ProcessModuleCollection : ReadOnlyCollectionBase
    {
    }

    // TypeToken: 0x2000104
    public class ProcessStartInfo
    {
        // Fields
        private System.String fileName;        // 0x10
        private System.String arguments;        // 0x18
        private System.String directory;        // 0x20
        private System.String verb;        // 0x28
        private System.Diagnostics.ProcessWindowStyle windowStyle;        // 0x30
        private System.Boolean errorDialog;        // 0x34
        private System.IntPtr errorDialogParentHandle;        // 0x38
        private System.Boolean useShellExecute;        // 0x40
        private System.String userName;        // 0x48
        private System.String domain;        // 0x50
        private System.Security.SecureString password;        // 0x58
        private System.String passwordInClearText;        // 0x60
        private System.Boolean loadUserProfile;        // 0x68
        private System.Boolean redirectStandardInput;        // 0x69
        private System.Boolean redirectStandardOutput;        // 0x6A
        private System.Boolean redirectStandardError;        // 0x6B
        private System.Text.Encoding standardOutputEncoding;        // 0x70
        private System.Text.Encoding standardErrorEncoding;        // 0x78
        private System.Boolean createNoWindow;        // 0x80
        private System.WeakReference weakParentProcess;        // 0x88
        private System.Collections.Specialized.StringDictionary environmentVariables;        // 0x90
        private static readonly System.String[] empty;        // 0x0
        private System.Collections.ObjectModel.Collection<System.String> _argumentList;        // 0x98
        private System.Collections.Generic.IDictionary<System.String,System.String> environment;        // 0xA0
        private System.Text.Encoding <StandardInputEncoding>k__BackingField;        // 0xA8

        // Methods
        private System.Void .ctor(System.Diagnostics.Process parent) { }
        private System.Void .ctor(System.String fileName) { }
        private System.Collections.ObjectModel.Collection<System.String> get_ArgumentList() { }
        private System.String get_Arguments() { }
        private System.Void set_Arguments(System.String value) { }
        private System.Void set_CreateNoWindow(System.Boolean value) { }
        private System.Collections.Specialized.StringDictionary get_EnvironmentVariables() { }
        private System.Boolean get_RedirectStandardInput() { }
        private System.Boolean get_RedirectStandardOutput() { }
        private System.Void set_RedirectStandardOutput(System.Boolean value) { }
        private System.Boolean get_RedirectStandardError() { }
        private System.Text.Encoding get_StandardErrorEncoding() { }
        private System.Text.Encoding get_StandardOutputEncoding() { }
        private System.Boolean get_UseShellExecute() { }
        private System.Void set_UseShellExecute(System.Boolean value) { }
        private System.String get_UserName() { }
        private System.Security.SecureString get_Password() { }
        private System.String get_Domain() { }
        private System.Boolean get_LoadUserProfile() { }
        private System.String get_FileName() { }
        private System.Void set_FileName(System.String value) { }
        private System.String get_WorkingDirectory() { }
        private System.Boolean get_HaveEnvVars() { }
        private System.Text.Encoding get_StandardInputEncoding() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000105
    public class ProcessThreadCollection : ReadOnlyCollectionBase
    {
    }

    // TypeToken: 0x2000106
    public class ProcessWaitHandle : WaitHandle
    {
        // Methods
        private System.Void .ctor(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle) { }

    }

    // TypeToken: 0x2000107
    public class MonitoringDescriptionAttribute : DescriptionAttribute
    {
        // Methods
        private System.Void .ctor(System.String description) { }
        private System.String get_Description() { }

    }

    // TypeToken: 0x2000108
    public struct ProcessWindowStyle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Diagnostics.ProcessWindowStyle Hidden;        // 0x0
        public static System.Diagnostics.ProcessWindowStyle Maximized;        // 0x0
        public static System.Diagnostics.ProcessWindowStyle Minimized;        // 0x0
        public static System.Diagnostics.ProcessWindowStyle Normal;        // 0x0

    }

    // TypeToken: 0x2000109
    public class Stopwatch
    {
        // Fields
        public static readonly System.Int64 Frequency;        // 0x0
        public static readonly System.Boolean IsHighResolution;        // 0x8
        private System.Int64 elapsed;        // 0x10
        private System.Int64 started;        // 0x18
        private System.Boolean is_running;        // 0x20

        // Methods
        private System.Int64 GetTimestamp() { }
        private System.Diagnostics.Stopwatch StartNew() { }
        private System.Void .ctor() { }
        private System.TimeSpan get_Elapsed() { }
        private System.Int64 get_ElapsedMilliseconds() { }
        private System.Int64 get_ElapsedTicks() { }
        private System.Boolean get_IsRunning() { }
        private System.Void Reset() { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Void Restart() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200038C
    public class DiagnosticsConfigurationHandler, IConfigurationSectionHandler
    {
        // Methods
        private System.Void .ctor() { }
        private System.Object Create(System.Object parent, System.Object configContext, System.Xml.XmlNode section) { }

    }

}

namespace System.Diagnostics.CodeAnalysis
{

    // TypeToken: 0x200010A
    public class ExcludeFromCodeCoverageAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.IO
{

    // TypeToken: 0x2000365
    public class InvalidDataException : SystemException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

}

namespace System.IO.Compression
{

    // TypeToken: 0x2000366
    public struct CompressionLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.Compression.CompressionLevel Optimal;        // 0x0
        public static System.IO.Compression.CompressionLevel Fastest;        // 0x0
        public static System.IO.Compression.CompressionLevel NoCompression;        // 0x0

    }

    // TypeToken: 0x2000367
    public struct CompressionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.Compression.CompressionMode Decompress;        // 0x0
        public static System.IO.Compression.CompressionMode Compress;        // 0x0

    }

    // TypeToken: 0x2000368
    public class GZipStream : Stream
    {
        // Fields
        private System.IO.Compression.DeflateStream _deflateStream;        // 0x28

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_CanSeek() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Void Flush() { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Int32 ReadByte() { }
        private System.IAsyncResult BeginRead(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.Int32 Read(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Int32 Read(System.Span<System.Byte> buffer) { }
        private System.IAsyncResult BeginWrite(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Void Write(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Void Write(System.ReadOnlySpan<System.Byte> buffer) { }
        private System.Void CopyTo(System.IO.Stream destination, System.Int32 bufferSize) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] array, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] array, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, System.Int32 bufferSize, System.Threading.CancellationToken cancellationToken) { }
        private System.Void CheckDeflateStream() { }
        private System.Void ThrowStreamClosedException() { }

    }

    // TypeToken: 0x2000369
    public class DeflateStream : Stream
    {
        // Fields
        private System.IO.Stream base_stream;        // 0x28
        private System.IO.Compression.CompressionMode mode;        // 0x30
        private System.Boolean leaveOpen;        // 0x34
        private System.Boolean disposed;        // 0x35
        private System.IO.Compression.DeflateStreamNative native;        // 0x38

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen, System.Int32 windowsBits) { }
        private System.Void .ctor(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen, System.Boolean gzip) { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int32 ReadInternal(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, System.Threading.CancellationToken cancellationToken) { }
        private System.Int32 ReadCore(System.Span<System.Byte> destination) { }
        private System.Int32 Read(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Void WriteInternal(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, System.Threading.CancellationToken cancellationToken) { }
        private System.Void WriteCore(System.ReadOnlySpan<System.Byte> source) { }
        private System.Void Write(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Void Flush() { }
        private System.IAsyncResult BeginRead(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.IAsyncResult BeginWrite(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }

    }

    // TypeToken: 0x200036C
    public class DeflateStreamNative
    {
        // Fields
        private System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder;        // 0x10
        private System.IO.Stream base_stream;        // 0x18
        private System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle z_stream;        // 0x20
        private System.Runtime.InteropServices.GCHandle data;        // 0x28
        private System.Boolean disposed;        // 0x30
        private System.Byte[] io_buffer;        // 0x38
        private System.Exception last_error;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, System.Boolean gzip) { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Flush() { }
        private System.Int32 ReadZStream(System.IntPtr buffer, System.Int32 length) { }
        private System.Void WriteZStream(System.IntPtr buffer, System.Int32 length) { }
        private System.Int32 UnmanagedRead(System.IntPtr buffer, System.Int32 length, System.IntPtr data) { }
        private System.Int32 UnmanagedRead(System.IntPtr buffer, System.Int32 length) { }
        private System.Int32 UnmanagedWrite(System.IntPtr buffer, System.Int32 length, System.IntPtr data) { }
        private System.Int32 UnmanagedWrite(System.IntPtr buffer, System.Int32 length) { }
        private System.Void CheckResult(System.Int32 result, System.String where) { }
        private System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, System.Boolean gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, System.IntPtr data) { }
        private System.Int32 CloseZStream(System.IntPtr stream) { }
        private System.Int32 Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream) { }
        private System.Int32 ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, System.IntPtr buffer, System.Int32 length) { }
        private System.Int32 WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, System.IntPtr buffer, System.Int32 length) { }

    }

}

namespace System.Net
{

    // TypeToken: 0x200013E
    public class ContextAwareResult : LazyAsyncResult
    {
        // Fields
        private System.Threading.ExecutionContext _context;        // 0x40
        private System.Object _lock;        // 0x48
        private System.Net.ContextAwareResult.StateFlags _flags;        // 0x50

        // Methods
        private System.Void SafeCaptureIdentity() { }
        private System.Void CleanupInternal() { }
        private System.Void .ctor(System.Object myObject, System.Object myState, System.AsyncCallback myCallBack) { }
        private System.Void .ctor(System.Boolean captureIdentity, System.Boolean forceCaptureContext, System.Object myObject, System.Object myState, System.AsyncCallback myCallBack) { }
        private System.Void .ctor(System.Boolean captureIdentity, System.Boolean forceCaptureContext, System.Boolean threadSafeContextCopy, System.Object myObject, System.Object myState, System.AsyncCallback myCallBack) { }
        private System.Object StartPostingAsyncOp() { }
        private System.Object StartPostingAsyncOp(System.Boolean lockCapture) { }
        private System.Boolean FinishPostingAsyncOp() { }
        private System.Void Cleanup() { }
        private System.Boolean CaptureOrComplete(System.Threading.ExecutionContext& cachedContext, System.Boolean returnContext) { }
        private System.Void Complete(System.IntPtr userToken) { }
        private System.Void CompleteCallback() { }

    }

    // TypeToken: 0x2000141
    public class HttpStatusDescription
    {
        // Methods
        private System.String Get(System.Net.HttpStatusCode code) { }
        private System.String Get(System.Int32 code) { }

    }

    // TypeToken: 0x2000142
    public class HttpValidationHelpers
    {
        // Fields
        private static readonly System.Char[] s_httpTrimCharacters;        // 0x0

        // Methods
        private System.Boolean IsInvalidMethodOrHeaderString(System.String stringValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000143
    public class NetEventSource : EventSource
    {
        // Fields
        public static readonly System.Net.NetEventSource Log;        // 0x0

        // Methods
        private System.Void Enter(System.Object thisOrContextObject, System.FormattableString formattableString, System.String memberName) { }
        private System.Void Enter(System.Object thisOrContextObject, System.Object arg0, System.String memberName) { }
        private System.Void Enter(System.Object thisOrContextObject, System.Object arg0, System.Object arg1, System.Object arg2, System.String memberName) { }
        private System.Void Enter(System.String thisOrContextObject, System.String memberName, System.String parameters) { }
        private System.Void Exit(System.Object thisOrContextObject, System.FormattableString formattableString, System.String memberName) { }
        private System.Void Exit(System.Object thisOrContextObject, System.Object arg0, System.String memberName) { }
        private System.Void Exit(System.String thisOrContextObject, System.String memberName, System.String result) { }
        private System.Void Info(System.Object thisOrContextObject, System.FormattableString formattableString, System.String memberName) { }
        private System.Void Info(System.Object thisOrContextObject, System.Object message, System.String memberName) { }
        private System.Void Info(System.String thisOrContextObject, System.String memberName, System.String message) { }
        private System.Void Error(System.Object thisOrContextObject, System.Object message, System.String memberName) { }
        private System.Void ErrorMessage(System.String thisOrContextObject, System.String memberName, System.String message) { }
        private System.Void Fail(System.Object thisOrContextObject, System.Object message, System.String memberName) { }
        private System.Void CriticalFailure(System.String thisOrContextObject, System.String memberName, System.String message) { }
        private System.Void Associate(System.Object first, System.Object second, System.String memberName) { }
        private System.Void Associate(System.String thisOrContextObject, System.String memberName, System.String first, System.String second) { }
        private System.Boolean get_IsEnabled() { }
        private System.String IdOf(System.Object value) { }
        private System.Int32 GetHashCode(System.Object value) { }
        private System.Object Format(System.Object value) { }
        private System.String Format(System.FormattableString s) { }
        private System.Void WriteEvent(System.Int32 eventId, System.String arg1, System.String arg2, System.String arg3, System.String arg4) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000145
    public class TcpValidationHelpers
    {
        // Methods
        private System.Boolean ValidatePortNumber(System.Int32 port) { }

    }

    // TypeToken: 0x2000146
    public class TlsStream : NetworkStream
    {
        // Fields
        private System.Net.Security.SslStream _sslStream;        // 0x48
        private System.String _host;        // 0x50
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;        // 0x58

        // Methods
        private System.Void .ctor(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, System.String host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) { }
        private System.Void AuthenticateAsClient() { }
        private System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, System.Object state) { }
        private System.Void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult result) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x2000147
    public struct HttpStatusCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.HttpStatusCode Continue;        // 0x0
        public static System.Net.HttpStatusCode SwitchingProtocols;        // 0x0
        public static System.Net.HttpStatusCode Processing;        // 0x0
        public static System.Net.HttpStatusCode EarlyHints;        // 0x0
        public static System.Net.HttpStatusCode OK;        // 0x0
        public static System.Net.HttpStatusCode Created;        // 0x0
        public static System.Net.HttpStatusCode Accepted;        // 0x0
        public static System.Net.HttpStatusCode NonAuthoritativeInformation;        // 0x0
        public static System.Net.HttpStatusCode NoContent;        // 0x0
        public static System.Net.HttpStatusCode ResetContent;        // 0x0
        public static System.Net.HttpStatusCode PartialContent;        // 0x0
        public static System.Net.HttpStatusCode MultiStatus;        // 0x0
        public static System.Net.HttpStatusCode AlreadyReported;        // 0x0
        public static System.Net.HttpStatusCode IMUsed;        // 0x0
        public static System.Net.HttpStatusCode MultipleChoices;        // 0x0
        public static System.Net.HttpStatusCode Ambiguous;        // 0x0
        public static System.Net.HttpStatusCode MovedPermanently;        // 0x0
        public static System.Net.HttpStatusCode Moved;        // 0x0
        public static System.Net.HttpStatusCode Found;        // 0x0
        public static System.Net.HttpStatusCode Redirect;        // 0x0
        public static System.Net.HttpStatusCode SeeOther;        // 0x0
        public static System.Net.HttpStatusCode RedirectMethod;        // 0x0
        public static System.Net.HttpStatusCode NotModified;        // 0x0
        public static System.Net.HttpStatusCode UseProxy;        // 0x0
        public static System.Net.HttpStatusCode Unused;        // 0x0
        public static System.Net.HttpStatusCode TemporaryRedirect;        // 0x0
        public static System.Net.HttpStatusCode RedirectKeepVerb;        // 0x0
        public static System.Net.HttpStatusCode PermanentRedirect;        // 0x0
        public static System.Net.HttpStatusCode BadRequest;        // 0x0
        public static System.Net.HttpStatusCode Unauthorized;        // 0x0
        public static System.Net.HttpStatusCode PaymentRequired;        // 0x0
        public static System.Net.HttpStatusCode Forbidden;        // 0x0
        public static System.Net.HttpStatusCode NotFound;        // 0x0
        public static System.Net.HttpStatusCode MethodNotAllowed;        // 0x0
        public static System.Net.HttpStatusCode NotAcceptable;        // 0x0
        public static System.Net.HttpStatusCode ProxyAuthenticationRequired;        // 0x0
        public static System.Net.HttpStatusCode RequestTimeout;        // 0x0
        public static System.Net.HttpStatusCode Conflict;        // 0x0
        public static System.Net.HttpStatusCode Gone;        // 0x0
        public static System.Net.HttpStatusCode LengthRequired;        // 0x0
        public static System.Net.HttpStatusCode PreconditionFailed;        // 0x0
        public static System.Net.HttpStatusCode RequestEntityTooLarge;        // 0x0
        public static System.Net.HttpStatusCode RequestUriTooLong;        // 0x0
        public static System.Net.HttpStatusCode UnsupportedMediaType;        // 0x0
        public static System.Net.HttpStatusCode RequestedRangeNotSatisfiable;        // 0x0
        public static System.Net.HttpStatusCode ExpectationFailed;        // 0x0
        public static System.Net.HttpStatusCode MisdirectedRequest;        // 0x0
        public static System.Net.HttpStatusCode UnprocessableEntity;        // 0x0
        public static System.Net.HttpStatusCode Locked;        // 0x0
        public static System.Net.HttpStatusCode FailedDependency;        // 0x0
        public static System.Net.HttpStatusCode UpgradeRequired;        // 0x0
        public static System.Net.HttpStatusCode PreconditionRequired;        // 0x0
        public static System.Net.HttpStatusCode TooManyRequests;        // 0x0
        public static System.Net.HttpStatusCode RequestHeaderFieldsTooLarge;        // 0x0
        public static System.Net.HttpStatusCode UnavailableForLegalReasons;        // 0x0
        public static System.Net.HttpStatusCode InternalServerError;        // 0x0
        public static System.Net.HttpStatusCode NotImplemented;        // 0x0
        public static System.Net.HttpStatusCode BadGateway;        // 0x0
        public static System.Net.HttpStatusCode ServiceUnavailable;        // 0x0
        public static System.Net.HttpStatusCode GatewayTimeout;        // 0x0
        public static System.Net.HttpStatusCode HttpVersionNotSupported;        // 0x0
        public static System.Net.HttpStatusCode VariantAlsoNegotiates;        // 0x0
        public static System.Net.HttpStatusCode InsufficientStorage;        // 0x0
        public static System.Net.HttpStatusCode LoopDetected;        // 0x0
        public static System.Net.HttpStatusCode NotExtended;        // 0x0
        public static System.Net.HttpStatusCode NetworkAuthenticationRequired;        // 0x0

    }

    // TypeToken: 0x2000148
    public class HttpVersion
    {
        // Fields
        public static readonly System.Version Unknown;        // 0x0
        public static readonly System.Version Version10;        // 0x8
        public static readonly System.Version Version11;        // 0x10
        public static readonly System.Version Version20;        // 0x18

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000149
    public class IPAddress
    {
        // Fields
        public static readonly System.Net.IPAddress Any;        // 0x0
        public static readonly System.Net.IPAddress Loopback;        // 0x8
        public static readonly System.Net.IPAddress Broadcast;        // 0x10
        public static readonly System.Net.IPAddress None;        // 0x18
        private static System.Int64 LoopbackMask;        // 0x0
        public static readonly System.Net.IPAddress IPv6Any;        // 0x20
        public static readonly System.Net.IPAddress IPv6Loopback;        // 0x28
        public static readonly System.Net.IPAddress IPv6None;        // 0x30
        private System.UInt32 _addressOrScopeId;        // 0x10
        private readonly System.UInt16[] _numbers;        // 0x18
        private System.String _toString;        // 0x20
        private System.Int32 _hashCode;        // 0x28
        private static System.Int32 NumberOfLabels;        // 0x0

        // Methods
        private System.Boolean get_IsIPv4() { }
        private System.Boolean get_IsIPv6() { }
        private System.UInt32 get_PrivateAddress() { }
        private System.Void set_PrivateAddress(System.UInt32 value) { }
        private System.UInt32 get_PrivateScopeId() { }
        private System.Void set_PrivateScopeId(System.UInt32 value) { }
        private System.Void .ctor(System.Int64 newAddress) { }
        private System.Void .ctor(System.Byte[] address, System.Int64 scopeid) { }
        private System.Void .ctor(System.ReadOnlySpan<System.Byte> address, System.Int64 scopeid) { }
        private System.Void .ctor(System.UInt16* numbers, System.Int32 numbersLength, System.UInt32 scopeid) { }
        private System.Void .ctor(System.UInt16[] numbers, System.UInt32 scopeid) { }
        private System.Void .ctor(System.Byte[] address) { }
        private System.Void .ctor(System.ReadOnlySpan<System.Byte> address) { }
        private System.Boolean TryParse(System.String ipString, System.Net.IPAddress& address) { }
        private System.Net.IPAddress Parse(System.String ipString) { }
        private System.Boolean TryWriteBytes(System.Span<System.Byte> destination, System.Int32& bytesWritten) { }
        private System.Void WriteIPv6Bytes(System.Span<System.Byte> destination) { }
        private System.Void WriteIPv4Bytes(System.Span<System.Byte> destination) { }
        private System.Byte[] GetAddressBytes() { }
        private System.Net.Sockets.AddressFamily get_AddressFamily() { }
        private System.Int64 get_ScopeId() { }
        private System.String ToString() { }
        private System.Boolean IsLoopback(System.Net.IPAddress address) { }
        private System.Boolean Equals(System.Object comparandObj, System.Boolean compareScopeId) { }
        private System.Boolean Equals(System.Object comparand) { }
        private System.Int32 GetHashCode() { }
        private System.Net.IPAddress MapToIPv6() { }
        private System.Byte[] ThrowAddressNullException() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014B
    public class IPAddressParser
    {
        // Methods
        private System.Net.IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, System.Boolean tryParse) { }
        private System.String IPv4AddressToString(System.UInt32 address) { }
        private System.Void IPv4AddressToString(System.UInt32 address, System.Text.StringBuilder destination) { }
        private System.Int32 IPv4AddressToStringHelper(System.UInt32 address, System.Char* addressString) { }
        private System.String IPv6AddressToString(System.UInt16[] address, System.UInt32 scopeId) { }
        private System.Text.StringBuilder IPv6AddressToStringHelper(System.UInt16[] address, System.UInt32 scopeId) { }
        private System.Void FormatIPv4AddressNumber(System.Int32 number, System.Char* addressString, System.Int32& offset) { }
        private System.Boolean Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, System.Int64& address) { }
        private System.Boolean Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, System.UInt16* numbers, System.Int32 numbersLength, System.UInt32& scope) { }
        private System.Void AppendSections(System.UInt16[] address, System.Int32 fromInclusive, System.Int32 toExclusive, System.Text.StringBuilder buffer) { }
        private System.Void AppendHex(System.UInt16 value, System.Text.StringBuilder buffer) { }
        private System.UInt32 ExtractIPv4Address(System.UInt16[] address) { }
        private System.UInt16 Reverse(System.UInt16 number) { }

    }

    // TypeToken: 0x200014C
    public class IPEndPoint : EndPoint
    {
        // Fields
        private System.Net.IPAddress _address;        // 0x10
        private System.Int32 _port;        // 0x18
        private static System.Net.IPEndPoint Any;        // 0x0
        private static System.Net.IPEndPoint IPv6Any;        // 0x8

        // Methods
        private System.Net.Sockets.AddressFamily get_AddressFamily() { }
        private System.Void .ctor(System.Net.IPAddress address, System.Int32 port) { }
        private System.Net.IPAddress get_Address() { }
        private System.Int32 get_Port() { }
        private System.String ToString() { }
        private System.Net.SocketAddress Serialize() { }
        private System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { }
        private System.Boolean Equals(System.Object comparand) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014D
    public class CommandStream : NetworkStreamWrapper
    {
        // Fields
        private static readonly System.AsyncCallback s_writeCallbackDelegate;        // 0x0
        private static readonly System.AsyncCallback s_readCallbackDelegate;        // 0x8
        private System.Boolean _recoverableFailure;        // 0x38
        protected System.Net.WebRequest _request;        // 0x40
        protected System.Boolean _isAsync;        // 0x48
        private System.Boolean _aborted;        // 0x49
        protected System.Net.CommandStream.PipelineEntry[] _commands;        // 0x50
        protected System.Int32 _index;        // 0x58
        private System.Boolean _doRead;        // 0x5C
        private System.Boolean _doSend;        // 0x5D
        private System.Net.ResponseDescription _currentResponseDescription;        // 0x60
        protected System.String _abortReason;        // 0x68
        private System.String _buffer;        // 0x70
        private System.Text.Encoding _encoding;        // 0x78
        private System.Text.Decoder _decoder;        // 0x80

        // Methods
        private System.Void .ctor(System.Net.Sockets.TcpClient client) { }
        private System.Void Abort(System.Exception e) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void InvokeRequestCallback(System.Object obj) { }
        private System.Boolean get_RecoverableFailure() { }
        private System.Void MarkAsRecoverableFailure() { }
        private System.IO.Stream SubmitRequest(System.Net.WebRequest request, System.Boolean isAsync, System.Boolean readInitalResponseOnConnect) { }
        private System.Void ClearState() { }
        private System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request) { }
        private System.Exception GenerateException(System.String message, System.Net.WebExceptionStatus status, System.Exception innerException) { }
        private System.Exception GenerateException(System.Net.FtpStatusCode code, System.String statusDescription, System.Exception innerException) { }
        private System.Void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, System.Boolean isAsync) { }
        private System.Void CheckContinuePipeline() { }
        private System.IO.Stream ContinueCommandPipeline() { }
        private System.Boolean PostSendCommandProcessing(System.IO.Stream& stream) { }
        private System.Boolean PostReadCommandProcessing(System.IO.Stream& stream) { }
        private System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, System.Boolean timeout, System.IO.Stream& stream) { }
        private System.Void ReadCallback(System.IAsyncResult asyncResult) { }
        private System.Void WriteCallback(System.IAsyncResult asyncResult) { }
        private System.Text.Encoding get_Encoding() { }
        private System.Void set_Encoding(System.Text.Encoding value) { }
        private System.Boolean CheckValid(System.Net.ResponseDescription response, System.Int32& validThrough, System.Int32& completeLength) { }
        private System.Net.ResponseDescription ReceiveCommandResponse() { }
        private System.Void ReceiveCommandResponseCallback(System.Net.ReceiveState state, System.Int32 bytesRead) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000151
    public class ResponseDescription
    {
        // Fields
        private System.Boolean Multiline;        // 0x10
        private System.Int32 Status;        // 0x14
        private System.String StatusDescription;        // 0x18
        private System.Text.StringBuilder StatusBuffer;        // 0x20
        private System.String StatusCodeString;        // 0x28

        // Methods
        private System.Boolean get_PositiveIntermediate() { }
        private System.Boolean get_PositiveCompletion() { }
        private System.Boolean get_TransientFailure() { }
        private System.Boolean get_PermanentFailure() { }
        private System.Boolean get_InvalidStatusCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000152
    public class ReceiveState
    {
        // Fields
        private System.Net.ResponseDescription Resp;        // 0x10
        private System.Int32 ValidThrough;        // 0x18
        private System.Byte[] Buffer;        // 0x20
        private System.Net.CommandStream Connection;        // 0x28

        // Methods
        private System.Void .ctor(System.Net.CommandStream connection) { }

    }

    // TypeToken: 0x2000153
    public struct FtpLoginState
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static System.Net.FtpLoginState NotLoggedIn;        // 0x0
        public static System.Net.FtpLoginState LoggedIn;        // 0x0
        public static System.Net.FtpLoginState LoggedInButNeedsRelogin;        // 0x0
        public static System.Net.FtpLoginState ReloginFailed;        // 0x0

    }

    // TypeToken: 0x2000154
    public class FtpControlStream : CommandStream
    {
        // Fields
        private System.Net.Sockets.Socket _dataSocket;        // 0x88
        private System.Net.IPEndPoint _passiveEndPoint;        // 0x90
        private System.Net.TlsStream _tlsStream;        // 0x98
        private System.Text.StringBuilder _bannerMessage;        // 0xA0
        private System.Text.StringBuilder _welcomeMessage;        // 0xA8
        private System.Text.StringBuilder _exitMessage;        // 0xB0
        private System.WeakReference _credentials;        // 0xB8
        private System.String _currentTypeSetting;        // 0xC0
        private System.Int64 _contentLength;        // 0xC8
        private System.DateTime _lastModified;        // 0xD0
        private System.Boolean _dataHandshakeStarted;        // 0xD8
        private System.String _loginDirectory;        // 0xE0
        private System.String _establishedServerDirectory;        // 0xE8
        private System.String _requestedServerDirectory;        // 0xF0
        private System.Uri _responseUri;        // 0xF8
        private System.Net.FtpLoginState _loginState;        // 0x100
        private System.Net.FtpStatusCode StatusCode;        // 0x104
        private System.String StatusLine;        // 0x108
        private static readonly System.AsyncCallback s_acceptCallbackDelegate;        // 0x0
        private static readonly System.AsyncCallback s_connectCallbackDelegate;        // 0x8
        private static readonly System.AsyncCallback s_SSLHandshakeCallback;        // 0x10

        // Methods
        private System.Net.NetworkCredential get_Credentials() { }
        private System.Void set_Credentials(System.Net.NetworkCredential value) { }
        private System.Void .ctor(System.Net.Sockets.TcpClient client) { }
        private System.Void AbortConnect() { }
        private System.Void AcceptCallback(System.IAsyncResult asyncResult) { }
        private System.Void ConnectCallback(System.IAsyncResult asyncResult) { }
        private System.Void SSLHandshakeCallback(System.IAsyncResult asyncResult) { }
        private System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(System.IO.Stream& stream) { }
        private System.Void ClearState() { }
        private System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, System.Boolean timeout, System.IO.Stream& stream) { }
        private System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req) { }
        private System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, System.Boolean timeout, System.IO.Stream& stream, System.Boolean& isSocketReady) { }
        private System.Void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, System.String& path, System.String& directory, System.String& filename) { }
        private System.String FormatAddress(System.Net.IPAddress address, System.Int32 Port) { }
        private System.String FormatAddressV6(System.Net.IPAddress address, System.Int32 port) { }
        private System.Int64 get_ContentLength() { }
        private System.DateTime get_LastModified() { }
        private System.Uri get_ResponseUri() { }
        private System.String get_BannerMessage() { }
        private System.String get_WelcomeMessage() { }
        private System.String get_ExitMessage() { }
        private System.Int64 GetContentLengthFrom213Response(System.String responseString) { }
        private System.DateTime GetLastModifiedFrom213Response(System.String str) { }
        private System.Void TryUpdateResponseUri(System.String str, System.Net.FtpWebRequest request) { }
        private System.Void TryUpdateContentLength(System.String str) { }
        private System.String GetLoginDirectory(System.String str) { }
        private System.Int32 GetPortV4(System.String responseString) { }
        private System.Int32 GetPortV6(System.String responseString) { }
        private System.Void CreateFtpListenerSocket(System.Net.FtpWebRequest request) { }
        private System.String GetPortCommandLine(System.Net.FtpWebRequest request) { }
        private System.String FormatFtpCommand(System.String command, System.String parameter) { }
        private System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket) { }
        private System.Boolean CheckValid(System.Net.ResponseDescription response, System.Int32& validThrough, System.Int32& completeLength) { }
        private System.Net.TriState IsFtpDataStreamWriteable() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000157
    public class FtpDataStream : Stream, ICloseEx
    {
        // Fields
        private System.Net.FtpWebRequest _request;        // 0x28
        private System.Net.Sockets.NetworkStream _networkStream;        // 0x30
        private System.Boolean _writeable;        // 0x38
        private System.Boolean _readable;        // 0x39
        private System.Boolean _isFullyRead;        // 0x3A
        private System.Boolean _closing;        // 0x3B

        // Methods
        private System.Void .ctor(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState) { }
        private System.Void CheckError() { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void AsyncReadCallback(System.IAsyncResult ar) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult ar) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Void Flush() { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Boolean get_CanTimeout() { }
        private System.Int32 get_ReadTimeout() { }
        private System.Void set_ReadTimeout(System.Int32 value) { }
        private System.Int32 get_WriteTimeout() { }
        private System.Void set_WriteTimeout(System.Int32 value) { }
        private System.Void SetSocketTimeoutOption(System.Int32 timeout) { }

    }

    // TypeToken: 0x2000158
    public struct FtpOperation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.FtpOperation DownloadFile;        // 0x0
        public static System.Net.FtpOperation ListDirectory;        // 0x0
        public static System.Net.FtpOperation ListDirectoryDetails;        // 0x0
        public static System.Net.FtpOperation UploadFile;        // 0x0
        public static System.Net.FtpOperation UploadFileUnique;        // 0x0
        public static System.Net.FtpOperation AppendFile;        // 0x0
        public static System.Net.FtpOperation DeleteFile;        // 0x0
        public static System.Net.FtpOperation GetDateTimestamp;        // 0x0
        public static System.Net.FtpOperation GetFileSize;        // 0x0
        public static System.Net.FtpOperation Rename;        // 0x0
        public static System.Net.FtpOperation MakeDirectory;        // 0x0
        public static System.Net.FtpOperation RemoveDirectory;        // 0x0
        public static System.Net.FtpOperation PrintWorkingDirectory;        // 0x0
        public static System.Net.FtpOperation Other;        // 0x0

    }

    // TypeToken: 0x2000159
    public struct FtpMethodFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.FtpMethodFlags None;        // 0x0
        public static System.Net.FtpMethodFlags IsDownload;        // 0x0
        public static System.Net.FtpMethodFlags IsUpload;        // 0x0
        public static System.Net.FtpMethodFlags TakesParameter;        // 0x0
        public static System.Net.FtpMethodFlags MayTakeParameter;        // 0x0
        public static System.Net.FtpMethodFlags DoesNotTakeParameter;        // 0x0
        public static System.Net.FtpMethodFlags ParameterIsDirectory;        // 0x0
        public static System.Net.FtpMethodFlags ShouldParseForResponseUri;        // 0x0
        public static System.Net.FtpMethodFlags HasHttpCommand;        // 0x0
        public static System.Net.FtpMethodFlags MustChangeWorkingDirectoryToPath;        // 0x0

    }

    // TypeToken: 0x200015A
    public class FtpMethodInfo
    {
        // Fields
        private System.String Method;        // 0x10
        private System.Net.FtpOperation Operation;        // 0x18
        private System.Net.FtpMethodFlags Flags;        // 0x1C
        private System.String HttpCommand;        // 0x20
        private static readonly System.Net.FtpMethodInfo[] s_knownMethodInfo;        // 0x0

        // Methods
        private System.Void .ctor(System.String method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, System.String httpCommand) { }
        private System.Boolean HasFlag(System.Net.FtpMethodFlags flags) { }
        private System.Boolean get_IsCommandOnly() { }
        private System.Boolean get_IsUpload() { }
        private System.Boolean get_IsDownload() { }
        private System.Boolean get_ShouldParseForResponseUri() { }
        private System.Net.FtpMethodInfo GetMethodInfo(System.String method) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200015B
    public class FtpWebRequest : WebRequest
    {
        // Fields
        private System.Object _syncObject;        // 0x38
        private System.Net.ICredentials _authInfo;        // 0x40
        private readonly System.Uri _uri;        // 0x48
        private System.Net.FtpMethodInfo _methodInfo;        // 0x50
        private System.String _renameTo;        // 0x58
        private System.Boolean _getRequestStreamStarted;        // 0x60
        private System.Boolean _getResponseStarted;        // 0x61
        private System.DateTime _startTime;        // 0x68
        private System.Int32 _timeout;        // 0x70
        private System.Int32 _remainingTimeout;        // 0x74
        private System.Int64 _contentLength;        // 0x78
        private System.Int64 _contentOffset;        // 0x80
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;        // 0x88
        private System.Boolean _passive;        // 0x90
        private System.Boolean _binary;        // 0x91
        private System.String _connectionGroupName;        // 0x98
        private System.Boolean _async;        // 0xA0
        private System.Boolean _aborted;        // 0xA1
        private System.Boolean _timedOut;        // 0xA2
        private System.Exception _exception;        // 0xA8
        private System.Net.TimerThread.Queue _timerQueue;        // 0xB0
        private System.Net.TimerThread.Callback _timerCallback;        // 0xB8
        private System.Boolean _enableSsl;        // 0xC0
        private System.Net.FtpControlStream _connection;        // 0xC8
        private System.IO.Stream _stream;        // 0xD0
        private System.Net.FtpWebRequest.RequestStage _requestStage;        // 0xD8
        private System.Boolean _onceFailed;        // 0xDC
        private System.Net.WebHeaderCollection _ftpRequestHeaders;        // 0xE0
        private System.Net.FtpWebResponse _ftpWebResponse;        // 0xE8
        private System.Int32 _readWriteTimeout;        // 0xF0
        private System.Net.ContextAwareResult _writeAsyncResult;        // 0xF8
        private System.Net.LazyAsyncResult _readAsyncResult;        // 0x100
        private System.Net.LazyAsyncResult _requestCompleteAsyncResult;        // 0x108
        private static readonly System.Net.NetworkCredential s_defaultFtpNetworkCredential;        // 0x0
        private static readonly System.Net.TimerThread.Queue s_DefaultTimerQueue;        // 0x8

        // Methods
        private System.Net.FtpMethodInfo get_MethodInfo() { }
        private System.String get_Method() { }
        private System.Void set_Method(System.String value) { }
        private System.String get_RenameTo() { }
        private System.Net.ICredentials get_Credentials() { }
        private System.Void set_Credentials(System.Net.ICredentials value) { }
        private System.Uri get_RequestUri() { }
        private System.Int32 get_Timeout() { }
        private System.Void set_Timeout(System.Int32 value) { }
        private System.Int32 get_RemainingTimeout() { }
        private System.Int32 get_ReadWriteTimeout() { }
        private System.Int64 get_ContentOffset() { }
        private System.Int64 get_ContentLength() { }
        private System.Void set_ContentLength(System.Int64 value) { }
        private System.Net.IWebProxy get_Proxy() { }
        private System.Void set_Proxy(System.Net.IWebProxy value) { }
        private System.Void set_ConnectionGroupName(System.String value) { }
        private System.Boolean get_Aborted() { }
        private System.Void .ctor(System.Uri uri) { }
        private System.Net.WebResponse GetResponse() { }
        private System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state) { }
        private System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { }
        private System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state) { }
        private System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { }
        private System.Void SubmitRequest(System.Boolean isAsync) { }
        private System.Exception TranslateConnectException(System.Exception e) { }
        private System.Void CreateConnectionAsync() { }
        private System.Net.FtpControlStream CreateConnection() { }
        private System.IO.Stream TimedSubmitRequestHelper(System.Boolean isAsync) { }
        private System.Void TimerCallback(System.Net.TimerThread.Timer timer, System.Int32 timeNoticed, System.Object context) { }
        private System.Net.TimerThread.Queue get_TimerQueue() { }
        private System.Boolean AttemptedRecovery(System.Exception e) { }
        private System.Void SetException(System.Exception exception) { }
        private System.Void CheckError() { }
        private System.Void RequestCallback(System.Object obj) { }
        private System.Void SyncRequestCallback(System.Object obj) { }
        private System.Void AsyncRequestCallback(System.Object obj) { }
        private System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage) { }
        private System.Void Abort() { }
        private System.Void set_CachePolicy(System.Net.Cache.RequestCachePolicy value) { }
        private System.Boolean get_UseBinary() { }
        private System.Boolean get_UsePassive() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Boolean get_EnableSsl() { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Boolean get_UseDefaultCredentials() { }
        private System.Void set_PreAuthenticate(System.Boolean value) { }
        private System.Boolean get_InUse() { }
        private System.Void EnsureFtpWebResponse(System.Exception exception) { }
        private System.Void DataStreamClosed(System.Net.CloseExState closeState) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200015F
    public class FtpWebRequestCreator, IWebRequestCreate
    {
        // Methods
        private System.Void .ctor() { }
        private System.Net.WebRequest Create(System.Uri uri) { }

    }

    // TypeToken: 0x2000160
    public class FtpWebResponse : WebResponse, IDisposable
    {
        // Fields
        private System.IO.Stream _responseStream;        // 0x20
        private System.Int64 _contentLength;        // 0x28
        private System.Uri _responseUri;        // 0x30
        private System.Net.FtpStatusCode _statusCode;        // 0x38
        private System.String _statusLine;        // 0x40
        private System.Net.WebHeaderCollection _ftpRequestHeaders;        // 0x48
        private System.DateTime _lastModified;        // 0x50
        private System.String _bannerMessage;        // 0x58
        private System.String _welcomeMessage;        // 0x60
        private System.String _exitMessage;        // 0x68

        // Methods
        private System.Void .ctor(System.IO.Stream responseStream, System.Int64 contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, System.String statusLine, System.DateTime lastModified, System.String bannerMessage, System.String welcomeMessage, System.String exitMessage) { }
        private System.Void UpdateStatus(System.Net.FtpStatusCode statusCode, System.String statusLine, System.String exitMessage) { }
        private System.IO.Stream GetResponseStream() { }
        private System.Void SetResponseStream(System.IO.Stream stream) { }
        private System.Void Close() { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Uri get_ResponseUri() { }
        private System.Net.FtpStatusCode get_StatusCode() { }

    }

    // TypeToken: 0x2000162
    public class NetworkStreamWrapper : Stream
    {
        // Fields
        private System.Net.Sockets.TcpClient _client;        // 0x28
        private System.Net.Sockets.NetworkStream _networkStream;        // 0x30

        // Methods
        private System.Void .ctor(System.Net.Sockets.TcpClient client) { }
        private System.Boolean get_UsingSecureStream() { }
        private System.Net.IPAddress get_ServerAddress() { }
        private System.Net.Sockets.Socket get_Socket() { }
        private System.Net.Sockets.NetworkStream get_NetworkStream() { }
        private System.Void set_NetworkStream(System.Net.Sockets.NetworkStream value) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_CanTimeout() { }
        private System.Int32 get_ReadTimeout() { }
        private System.Void set_ReadTimeout(System.Int32 value) { }
        private System.Int32 get_WriteTimeout() { }
        private System.Void set_WriteTimeout(System.Int32 value) { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void CloseSocket() { }
        private System.Void Close(System.Int32 timeout) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Flush() { }
        private System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Void SetSocketTimeoutOption(System.Int32 timeout) { }

    }

    // TypeToken: 0x2000163
    public struct SecurityProtocolType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.SecurityProtocolType SystemDefault;        // 0x0
        public static System.Net.SecurityProtocolType Ssl3;        // 0x0
        public static System.Net.SecurityProtocolType Tls;        // 0x0
        public static System.Net.SecurityProtocolType Tls11;        // 0x0
        public static System.Net.SecurityProtocolType Tls12;        // 0x0
        public static System.Net.SecurityProtocolType Tls13;        // 0x0

    }

    // TypeToken: 0x2000164
    public class Authorization
    {
        // Fields
        private System.String m_Message;        // 0x10
        private System.Boolean m_Complete;        // 0x18
        private System.String ModuleAuthenticationType;        // 0x20

        // Methods
        private System.Void .ctor(System.String token) { }
        private System.Void .ctor(System.String token, System.Boolean finished) { }
        private System.String get_Message() { }
        private System.Boolean get_Complete() { }

    }

    // TypeToken: 0x2000165
    public class CredentialCache
    {
        // Methods
        private System.Net.ICredentials get_DefaultCredentials() { }
        private System.Net.NetworkCredential get_DefaultNetworkCredentials() { }

    }

    // TypeToken: 0x2000166
    public class SystemNetworkCredential : NetworkCredential
    {
        // Fields
        private static readonly System.Net.SystemNetworkCredential defaultCredential;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000167
    public class EndPoint
    {
        // Methods
        private System.Net.Sockets.AddressFamily get_AddressFamily() { }
        private System.Net.SocketAddress Serialize() { }
        private System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000168
    public struct FtpStatusCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.FtpStatusCode Undefined;        // 0x0
        public static System.Net.FtpStatusCode RestartMarker;        // 0x0
        public static System.Net.FtpStatusCode ServiceTemporarilyNotAvailable;        // 0x0
        public static System.Net.FtpStatusCode DataAlreadyOpen;        // 0x0
        public static System.Net.FtpStatusCode OpeningData;        // 0x0
        public static System.Net.FtpStatusCode CommandOK;        // 0x0
        public static System.Net.FtpStatusCode CommandExtraneous;        // 0x0
        public static System.Net.FtpStatusCode DirectoryStatus;        // 0x0
        public static System.Net.FtpStatusCode FileStatus;        // 0x0
        public static System.Net.FtpStatusCode SystemType;        // 0x0
        public static System.Net.FtpStatusCode SendUserCommand;        // 0x0
        public static System.Net.FtpStatusCode ClosingControl;        // 0x0
        public static System.Net.FtpStatusCode ClosingData;        // 0x0
        public static System.Net.FtpStatusCode EnteringPassive;        // 0x0
        public static System.Net.FtpStatusCode LoggedInProceed;        // 0x0
        public static System.Net.FtpStatusCode ServerWantsSecureSession;        // 0x0
        public static System.Net.FtpStatusCode FileActionOK;        // 0x0
        public static System.Net.FtpStatusCode PathnameCreated;        // 0x0
        public static System.Net.FtpStatusCode SendPasswordCommand;        // 0x0
        public static System.Net.FtpStatusCode NeedLoginAccount;        // 0x0
        public static System.Net.FtpStatusCode FileCommandPending;        // 0x0
        public static System.Net.FtpStatusCode ServiceNotAvailable;        // 0x0
        public static System.Net.FtpStatusCode CantOpenData;        // 0x0
        public static System.Net.FtpStatusCode ConnectionClosed;        // 0x0
        public static System.Net.FtpStatusCode ActionNotTakenFileUnavailableOrBusy;        // 0x0
        public static System.Net.FtpStatusCode ActionAbortedLocalProcessingError;        // 0x0
        public static System.Net.FtpStatusCode ActionNotTakenInsufficientSpace;        // 0x0
        public static System.Net.FtpStatusCode CommandSyntaxError;        // 0x0
        public static System.Net.FtpStatusCode ArgumentSyntaxError;        // 0x0
        public static System.Net.FtpStatusCode CommandNotImplemented;        // 0x0
        public static System.Net.FtpStatusCode BadCommandSequence;        // 0x0
        public static System.Net.FtpStatusCode NotLoggedIn;        // 0x0
        public static System.Net.FtpStatusCode AccountNeeded;        // 0x0
        public static System.Net.FtpStatusCode ActionNotTakenFileUnavailable;        // 0x0
        public static System.Net.FtpStatusCode ActionAbortedUnknownPageType;        // 0x0
        public static System.Net.FtpStatusCode FileActionAborted;        // 0x0
        public static System.Net.FtpStatusCode ActionNotTakenFilenameNotAllowed;        // 0x0

    }

    // TypeToken: 0x2000169
    public struct HttpRequestHeader
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.HttpRequestHeader CacheControl;        // 0x0
        public static System.Net.HttpRequestHeader Connection;        // 0x0
        public static System.Net.HttpRequestHeader Date;        // 0x0
        public static System.Net.HttpRequestHeader KeepAlive;        // 0x0
        public static System.Net.HttpRequestHeader Pragma;        // 0x0
        public static System.Net.HttpRequestHeader Trailer;        // 0x0
        public static System.Net.HttpRequestHeader TransferEncoding;        // 0x0
        public static System.Net.HttpRequestHeader Upgrade;        // 0x0
        public static System.Net.HttpRequestHeader Via;        // 0x0
        public static System.Net.HttpRequestHeader Warning;        // 0x0
        public static System.Net.HttpRequestHeader Allow;        // 0x0
        public static System.Net.HttpRequestHeader ContentLength;        // 0x0
        public static System.Net.HttpRequestHeader ContentType;        // 0x0
        public static System.Net.HttpRequestHeader ContentEncoding;        // 0x0
        public static System.Net.HttpRequestHeader ContentLanguage;        // 0x0
        public static System.Net.HttpRequestHeader ContentLocation;        // 0x0
        public static System.Net.HttpRequestHeader ContentMd5;        // 0x0
        public static System.Net.HttpRequestHeader ContentRange;        // 0x0
        public static System.Net.HttpRequestHeader Expires;        // 0x0
        public static System.Net.HttpRequestHeader LastModified;        // 0x0
        public static System.Net.HttpRequestHeader Accept;        // 0x0
        public static System.Net.HttpRequestHeader AcceptCharset;        // 0x0
        public static System.Net.HttpRequestHeader AcceptEncoding;        // 0x0
        public static System.Net.HttpRequestHeader AcceptLanguage;        // 0x0
        public static System.Net.HttpRequestHeader Authorization;        // 0x0
        public static System.Net.HttpRequestHeader Cookie;        // 0x0
        public static System.Net.HttpRequestHeader Expect;        // 0x0
        public static System.Net.HttpRequestHeader From;        // 0x0
        public static System.Net.HttpRequestHeader Host;        // 0x0
        public static System.Net.HttpRequestHeader IfMatch;        // 0x0
        public static System.Net.HttpRequestHeader IfModifiedSince;        // 0x0
        public static System.Net.HttpRequestHeader IfNoneMatch;        // 0x0
        public static System.Net.HttpRequestHeader IfRange;        // 0x0
        public static System.Net.HttpRequestHeader IfUnmodifiedSince;        // 0x0
        public static System.Net.HttpRequestHeader MaxForwards;        // 0x0
        public static System.Net.HttpRequestHeader ProxyAuthorization;        // 0x0
        public static System.Net.HttpRequestHeader Referer;        // 0x0
        public static System.Net.HttpRequestHeader Range;        // 0x0
        public static System.Net.HttpRequestHeader Te;        // 0x0
        public static System.Net.HttpRequestHeader Translate;        // 0x0
        public static System.Net.HttpRequestHeader UserAgent;        // 0x0

    }

    // TypeToken: 0x200016A
    public interface IAuthenticationModule
    {
        // Methods
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { }
        private System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials) { }
        private System.String get_AuthenticationType() { }

    }

    // TypeToken: 0x200016B
    public interface ICertificatePolicy
    {
        // Methods
        private System.Boolean CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, System.Int32 certificateProblem) { }

    }

    // TypeToken: 0x200016C
    public interface ICredentials
    {
        // Methods
        private System.Net.NetworkCredential GetCredential(System.Uri uri, System.String authType) { }

    }

    // TypeToken: 0x200016D
    public class IPHostEntry
    {
        // Fields
        private System.String hostName;        // 0x10
        private System.String[] aliases;        // 0x18
        private System.Net.IPAddress[] addressList;        // 0x20
        private System.Boolean isTrustedHost;        // 0x28

        // Methods
        private System.String get_HostName() { }
        private System.Void set_HostName(System.String value) { }
        private System.Void set_Aliases(System.String[] value) { }
        private System.Net.IPAddress[] get_AddressList() { }
        private System.Void set_AddressList(System.Net.IPAddress[] value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016E
    public interface IWebRequestCreate
    {
        // Methods
        private System.Net.WebRequest Create(System.Uri uri) { }

    }

    // TypeToken: 0x200016F
    public class InternalException : SystemException
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000170
    public class NclUtilities
    {
        // Fields
        private static System.Net.IPAddress[] _LocalAddresses;        // 0x0
        private static System.Object _LocalAddressesLock;        // 0x8
        private static System.String _LocalDomainName;        // 0x10

        // Methods
        private System.Boolean IsFatal(System.Exception exception) { }
        private System.Boolean IsAddressLocal(System.Net.IPAddress ipAddress) { }
        private System.Net.IPHostEntry GetLocalHost() { }
        private System.Net.IPAddress[] get_LocalAddresses() { }
        private System.Object get_LocalAddressesLock() { }

    }

    // TypeToken: 0x2000171
    public class ValidationHelper
    {
        // Fields
        public static System.String[] EmptyArray;        // 0x0
        private static readonly System.Char[] InvalidMethodChars;        // 0x8
        private static readonly System.Char[] InvalidParamChars;        // 0x10

        // Methods
        private System.String MakeStringNull(System.String stringValue) { }
        private System.Boolean IsBlankString(System.String stringValue) { }
        private System.Boolean ValidateTcpPort(System.Int32 port) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000172
    public class ExceptionHelper
    {
        // Methods
        private System.NotImplementedException get_MethodNotImplementedException() { }
        private System.NotImplementedException get_PropertyNotImplementedException() { }
        private System.Net.WebException get_TimeoutException() { }
        private System.NotSupportedException get_PropertyNotSupportedException() { }
        private System.Net.WebException get_RequestAbortedException() { }

    }

    // TypeToken: 0x2000173
    public class WebRequestPrefixElement
    {
        // Fields
        public System.String Prefix;        // 0x10
        private System.Net.IWebRequestCreate creator;        // 0x18
        private System.Type creatorType;        // 0x20

        // Methods
        private System.Net.IWebRequestCreate get_Creator() { }
        private System.Void set_Creator(System.Net.IWebRequestCreate value) { }
        private System.Void .ctor(System.String P, System.Net.IWebRequestCreate C) { }

    }

    // TypeToken: 0x2000174
    public class HttpContinueDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Int32 StatusCode, System.Net.WebHeaderCollection httpHeaders) { }

    }

    // TypeToken: 0x2000175
    public class KnownHttpVerb
    {
        // Fields
        private System.String Name;        // 0x10
        private System.Boolean RequireContentBody;        // 0x18
        private System.Boolean ContentBodyNotAllowed;        // 0x19
        private System.Boolean ConnectRequest;        // 0x1A
        private System.Boolean ExpectNoContentResponse;        // 0x1B
        private static System.Collections.Specialized.ListDictionary NamedHeaders;        // 0x0
        private static System.Net.KnownHttpVerb Get;        // 0x8
        private static System.Net.KnownHttpVerb Connect;        // 0x10
        private static System.Net.KnownHttpVerb Head;        // 0x18
        private static System.Net.KnownHttpVerb Put;        // 0x20
        private static System.Net.KnownHttpVerb Post;        // 0x28
        private static System.Net.KnownHttpVerb MkCol;        // 0x30

        // Methods
        private System.Void .ctor(System.String name, System.Boolean requireContentBody, System.Boolean contentBodyNotAllowed, System.Boolean connectRequest, System.Boolean expectNoContentResponse) { }
        private System.Void .cctor() { }
        private System.Net.KnownHttpVerb Parse(System.String name) { }

    }

    // TypeToken: 0x2000176
    public struct TriState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.TriState Unspecified;        // 0x0
        public static System.Net.TriState False;        // 0x0
        public static System.Net.TriState True;        // 0x0

    }

    // TypeToken: 0x2000177
    public class NetworkCredential, ICredentials
    {
        // Fields
        private System.String m_domain;        // 0x10
        private System.String m_userName;        // 0x18
        private System.Security.SecureString m_password;        // 0x20

        // Methods
        private System.Void .ctor(System.String userName, System.String password) { }
        private System.Void .ctor(System.String userName, System.String password, System.String domain) { }
        private System.String get_UserName() { }
        private System.Void set_UserName(System.String value) { }
        private System.String get_Password() { }
        private System.Void set_Password(System.String value) { }
        private System.String get_Domain() { }
        private System.Void set_Domain(System.String value) { }
        private System.String InternalGetUserName() { }
        private System.String InternalGetPassword() { }
        private System.String InternalGetDomain() { }
        private System.Net.NetworkCredential GetCredential(System.Uri uri, System.String authType) { }

    }

    // TypeToken: 0x2000178
    public class ProtocolViolationException : InvalidOperationException, ISerializable
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }

    }

    // TypeToken: 0x2000179
    public class SocketAddress
    {
        // Fields
        private System.Int32 m_Size;        // 0x10
        private System.Byte[] m_Buffer;        // 0x18
        private System.Boolean m_changed;        // 0x20
        private System.Int32 m_hash;        // 0x24

        // Methods
        private System.Net.Sockets.AddressFamily get_Family() { }
        private System.Int32 get_Size() { }
        private System.Byte get_Item(System.Int32 offset) { }
        private System.Void .ctor(System.Net.Sockets.AddressFamily family, System.Int32 size) { }
        private System.Void .ctor(System.Net.IPAddress ipAddress) { }
        private System.Void .ctor(System.Net.IPAddress ipaddress, System.Int32 port) { }
        private System.Net.IPAddress GetIPAddress() { }
        private System.Net.IPEndPoint GetIPEndPoint() { }
        private System.Boolean Equals(System.Object comparand) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200017A
    public class TransportContext
    {
    }

    // TypeToken: 0x200017B
    public class WebException : InvalidOperationException, ISerializable
    {
        // Fields
        private System.Net.WebExceptionStatus m_Status;        // 0x90
        private System.Net.WebResponse m_Response;        // 0x98
        private System.Net.WebExceptionInternalStatus m_InternalStatus;        // 0xA0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.String message, System.Net.WebExceptionStatus status) { }
        private System.Void .ctor(System.String message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException) { }
        private System.Void .ctor(System.String message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response) { }
        private System.Void .ctor(System.String message, System.String data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response) { }
        private System.Void .ctor(System.String message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus) { }
        private System.Void .ctor(System.String message, System.String data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Net.WebExceptionStatus get_Status() { }
        private System.Net.WebResponse get_Response() { }

    }

    // TypeToken: 0x200017C
    public struct WebExceptionInternalStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebExceptionInternalStatus RequestFatal;        // 0x0
        public static System.Net.WebExceptionInternalStatus ServicePointFatal;        // 0x0
        public static System.Net.WebExceptionInternalStatus Recoverable;        // 0x0
        public static System.Net.WebExceptionInternalStatus Isolated;        // 0x0

    }

    // TypeToken: 0x200017D
    public struct WebExceptionStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebExceptionStatus Success;        // 0x0
        public static System.Net.WebExceptionStatus NameResolutionFailure;        // 0x0
        public static System.Net.WebExceptionStatus ConnectFailure;        // 0x0
        public static System.Net.WebExceptionStatus ReceiveFailure;        // 0x0
        public static System.Net.WebExceptionStatus SendFailure;        // 0x0
        public static System.Net.WebExceptionStatus PipelineFailure;        // 0x0
        public static System.Net.WebExceptionStatus RequestCanceled;        // 0x0
        public static System.Net.WebExceptionStatus ProtocolError;        // 0x0
        public static System.Net.WebExceptionStatus ConnectionClosed;        // 0x0
        public static System.Net.WebExceptionStatus TrustFailure;        // 0x0
        public static System.Net.WebExceptionStatus SecureChannelFailure;        // 0x0
        public static System.Net.WebExceptionStatus ServerProtocolViolation;        // 0x0
        public static System.Net.WebExceptionStatus KeepAliveFailure;        // 0x0
        public static System.Net.WebExceptionStatus Pending;        // 0x0
        public static System.Net.WebExceptionStatus Timeout;        // 0x0
        public static System.Net.WebExceptionStatus ProxyNameResolutionFailure;        // 0x0
        public static System.Net.WebExceptionStatus UnknownError;        // 0x0
        public static System.Net.WebExceptionStatus MessageLengthLimitExceeded;        // 0x0
        public static System.Net.WebExceptionStatus CacheEntryNotFound;        // 0x0
        public static System.Net.WebExceptionStatus RequestProhibitedByCachePolicy;        // 0x0
        public static System.Net.WebExceptionStatus RequestProhibitedByProxy;        // 0x0

    }

    // TypeToken: 0x200017E
    public class WebExceptionMapping
    {
        // Fields
        private static readonly System.String[] s_Mapping;        // 0x0

        // Methods
        private System.String GetWebStatusString(System.Net.WebExceptionStatus status) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200017F
    public struct WebHeaderCollectionType
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static System.Net.WebHeaderCollectionType Unknown;        // 0x0
        public static System.Net.WebHeaderCollectionType WebRequest;        // 0x0
        public static System.Net.WebHeaderCollectionType WebResponse;        // 0x0
        public static System.Net.WebHeaderCollectionType HttpWebRequest;        // 0x0
        public static System.Net.WebHeaderCollectionType HttpWebResponse;        // 0x0
        public static System.Net.WebHeaderCollectionType HttpListenerRequest;        // 0x0
        public static System.Net.WebHeaderCollectionType HttpListenerResponse;        // 0x0
        public static System.Net.WebHeaderCollectionType FtpWebRequest;        // 0x0
        public static System.Net.WebHeaderCollectionType FtpWebResponse;        // 0x0
        public static System.Net.WebHeaderCollectionType FileWebRequest;        // 0x0
        public static System.Net.WebHeaderCollectionType FileWebResponse;        // 0x0

    }

    // TypeToken: 0x2000180
    public class WebHeaderCollection : NameValueCollection, ISerializable
    {
        // Fields
        private static System.Int32 ApproxAveHeaderLineSize;        // 0x0
        private static System.Int32 ApproxHighAvgNumHeaders;        // 0x0
        private static readonly System.Net.HeaderInfoTable HInfo;        // 0x0
        private System.String[] m_CommonHeaders;        // 0x68
        private System.Int32 m_NumCommonHeaders;        // 0x70
        private static readonly System.String[] s_CommonHeaderNames;        // 0x8
        private static readonly System.SByte[] s_CommonHeaderHints;        // 0x10
        private static System.Int32 c_AcceptRanges;        // 0x0
        private static System.Int32 c_ContentLength;        // 0x0
        private static System.Int32 c_CacheControl;        // 0x0
        private static System.Int32 c_ContentType;        // 0x0
        private static System.Int32 c_Date;        // 0x0
        private static System.Int32 c_Expires;        // 0x0
        private static System.Int32 c_ETag;        // 0x0
        private static System.Int32 c_LastModified;        // 0x0
        private static System.Int32 c_Location;        // 0x0
        private static System.Int32 c_ProxyAuthenticate;        // 0x0
        private static System.Int32 c_P3P;        // 0x0
        private static System.Int32 c_SetCookie2;        // 0x0
        private static System.Int32 c_SetCookie;        // 0x0
        private static System.Int32 c_Server;        // 0x0
        private static System.Int32 c_Via;        // 0x0
        private static System.Int32 c_WwwAuthenticate;        // 0x0
        private static System.Int32 c_XAspNetVersion;        // 0x0
        private static System.Int32 c_XPoweredBy;        // 0x0
        private System.Collections.Specialized.NameValueCollection m_InnerCollection;        // 0x78
        private System.Net.WebHeaderCollectionType m_Type;        // 0x80
        private static readonly System.Char[] HttpTrimCharacters;        // 0x18
        private static System.Net.WebHeaderCollection.RfcChar[] RfcCharMap;        // 0x20

        // Methods
        private System.Void NormalizeCommonHeaders() { }
        private System.Collections.Specialized.NameValueCollection get_InnerCollection() { }
        private System.Boolean AllowMultiValues(System.String name) { }
        private System.Boolean get_AllowHttpRequestHeader() { }
        private System.Void Remove(System.Net.HttpRequestHeader header) { }
        private System.Void AddInternal(System.String name, System.String value) { }
        private System.Void ChangeInternal(System.String name, System.String value) { }
        private System.Void RemoveInternal(System.String name) { }
        private System.String CheckBadChars(System.String name, System.Boolean isHeaderValue) { }
        private System.Boolean ContainsNonAsciiChars(System.String token) { }
        private System.Void ThrowOnRestrictedHeader(System.String headerName) { }
        private System.Void Add(System.String name, System.String value) { }
        private System.Void Add(System.String header) { }
        private System.Void Set(System.String name, System.String value) { }
        private System.Void SetInternal(System.String name, System.String value) { }
        private System.Void Remove(System.String name) { }
        private System.String[] GetValues(System.String header) { }
        private System.String ToString() { }
        private System.String GetAsString(System.Collections.Specialized.NameValueCollection cc, System.Boolean winInetCompat, System.Boolean forTrace) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.WebHeaderCollectionType type) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void OnDeserialization(System.Object sender) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.String Get(System.String name) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 get_Count() { }
        private System.String Get(System.Int32 index) { }
        private System.String[] GetValues(System.Int32 index) { }
        private System.String GetKey(System.Int32 index) { }
        private System.String[] get_AllKeys() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000182
    public class CaseInsensitiveAscii, IEqualityComparer, IComparer
    {
        // Fields
        private static readonly System.Net.CaseInsensitiveAscii StaticInstance;        // 0x0
        private static readonly System.Byte[] AsciiToLower;        // 0x8

        // Methods
        private System.Int32 GetHashCode(System.Object myObject) { }
        private System.Int32 Compare(System.Object firstObject, System.Object secondObject) { }
        private System.Int32 FastGetHashCode(System.String myString) { }
        private System.Boolean Equals(System.Object firstObject, System.Object secondObject) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000183
    public class WebRequest : MarshalByRefObject, ISerializable
    {
        // Fields
        private static System.Collections.ArrayList s_PrefixList;        // 0x0
        private static System.Object s_InternalSyncObject;        // 0x8
        private static System.Net.TimerThread.Queue s_DefaultTimerQueue;        // 0x10
        private System.Net.Security.AuthenticationLevel m_AuthenticationLevel;        // 0x18
        private System.Security.Principal.TokenImpersonationLevel m_ImpersonationLevel;        // 0x1C
        private System.Net.Cache.RequestCachePolicy m_CachePolicy;        // 0x20
        private System.Net.Cache.RequestCacheProtocol m_CacheProtocol;        // 0x28
        private System.Net.Cache.RequestCacheBinding m_CacheBinding;        // 0x30
        private static System.Net.WebRequest.DesignerWebRequestCreate webRequestCreate;        // 0x18
        private static System.Net.IWebProxy s_DefaultWebProxy;        // 0x20
        private static System.Boolean s_DefaultWebProxyInitialized;        // 0x28

        // Methods
        private System.Object get_InternalSyncObject() { }
        private System.Net.WebRequest Create(System.Uri requestUri, System.Boolean useUriBase) { }
        private System.Net.WebRequest Create(System.String requestUriString) { }
        private System.Net.WebRequest Create(System.Uri requestUri) { }
        private System.Collections.ArrayList get_PrefixList() { }
        private System.Collections.ArrayList PopulatePrefixList() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Net.Cache.RequestCachePolicy get_DefaultCachePolicy() { }
        private System.Void set_CachePolicy(System.Net.Cache.RequestCachePolicy value) { }
        private System.Void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy) { }
        private System.String get_Method() { }
        private System.Void set_Method(System.String value) { }
        private System.Uri get_RequestUri() { }
        private System.Void set_ConnectionGroupName(System.String value) { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Int64 get_ContentLength() { }
        private System.Void set_ContentLength(System.Int64 value) { }
        private System.Net.ICredentials get_Credentials() { }
        private System.Void set_Credentials(System.Net.ICredentials value) { }
        private System.Boolean get_UseDefaultCredentials() { }
        private System.Net.IWebProxy get_Proxy() { }
        private System.Void set_Proxy(System.Net.IWebProxy value) { }
        private System.Void set_PreAuthenticate(System.Boolean value) { }
        private System.Int32 get_Timeout() { }
        private System.Void set_Timeout(System.Int32 value) { }
        private System.Net.WebResponse GetResponse() { }
        private System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state) { }
        private System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { }
        private System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state) { }
        private System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync() { }
        private System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { }
        private System.Security.Principal.WindowsIdentity SafeCaptureIdenity() { }
        private System.Void Abort() { }
        private System.Net.Cache.RequestCacheProtocol get_CacheProtocol() { }
        private System.Void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value) { }
        private System.Net.IWebProxy get_InternalDefaultWebProxy() { }
        private System.Void .cctor() { }
        private System.Threading.Tasks.Task<System.IO.Stream> <GetRequestStreamAsync>b__78_0() { }
        private System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0() { }

    }

    // TypeToken: 0x2000187
    public class WebResponse : MarshalByRefObject, ISerializable, IDisposable
    {
        // Fields
        private System.Boolean m_IsFromCache;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void Close() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_IsFromCache() { }
        private System.IO.Stream GetResponseStream() { }
        private System.Uri get_ResponseUri() { }
        private System.Net.WebHeaderCollection get_Headers() { }

    }

    // TypeToken: 0x2000188
    public class BufferOffsetSize
    {
        // Fields
        private System.Byte[] Buffer;        // 0x10
        private System.Int32 Offset;        // 0x18
        private System.Int32 Size;        // 0x1C

        // Methods
        private System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean copyBuffer) { }
        private System.Void .ctor(System.Byte[] buffer, System.Boolean copyBuffer) { }

    }

    // TypeToken: 0x2000189
    public class HeaderParser : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String[] Invoke(System.String value) { }

    }

    // TypeToken: 0x200018A
    public class HeaderInfo
    {
        // Fields
        private readonly System.Boolean IsRequestRestricted;        // 0x10
        private readonly System.Boolean IsResponseRestricted;        // 0x11
        private readonly System.Net.HeaderParser Parser;        // 0x18
        private readonly System.String HeaderName;        // 0x20
        private readonly System.Boolean AllowMultiValues;        // 0x28

        // Methods
        private System.Void .ctor(System.String name, System.Boolean requestRestricted, System.Boolean responseRestricted, System.Boolean multi, System.Net.HeaderParser p) { }

    }

    // TypeToken: 0x200018B
    public class HeaderInfoTable
    {
        // Fields
        private static System.Collections.Hashtable HeaderHashTable;        // 0x0
        private static System.Net.HeaderInfo UnknownHeaderInfo;        // 0x8
        private static System.Net.HeaderParser SingleParser;        // 0x10
        private static System.Net.HeaderParser MultiParser;        // 0x18

        // Methods
        private System.String[] ParseSingleValue(System.String value) { }
        private System.String[] ParseMultiValue(System.String value) { }
        private System.Void .cctor() { }
        private System.Net.HeaderInfo get_Item(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018C
    public struct CloseExState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.CloseExState Normal;        // 0x0
        public static System.Net.CloseExState Abort;        // 0x0
        public static System.Net.CloseExState Silent;        // 0x0

    }

    // TypeToken: 0x200018D
    public interface ICloseEx
    {
        // Methods
        private System.Void CloseEx(System.Net.CloseExState closeState) { }

    }

    // TypeToken: 0x200018E
    public class LazyAsyncResult, IAsyncResult
    {
        // Fields
        private static System.Net.LazyAsyncResult.ThreadContext t_ThreadContext;        // 0xFFFFFFFF
        private System.Object m_AsyncObject;        // 0x10
        private System.Object m_AsyncState;        // 0x18
        private System.AsyncCallback m_AsyncCallback;        // 0x20
        private System.Object m_Result;        // 0x28
        private System.Int32 m_IntCompleted;        // 0x30
        private System.Boolean m_EndCalled;        // 0x34
        private System.Boolean m_UserEvent;        // 0x35
        private System.Object m_Event;        // 0x38

        // Methods
        private System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }
        private System.Void .ctor(System.Object myObject, System.Object myState, System.AsyncCallback myCallBack) { }
        private System.Object get_AsyncObject() { }
        private System.Object get_AsyncState() { }
        private System.AsyncCallback get_AsyncCallback() { }
        private System.Threading.WaitHandle get_AsyncWaitHandle() { }
        private System.Boolean LazilyCreateEvent(System.Threading.ManualResetEvent& waitHandle) { }
        private System.Boolean get_CompletedSynchronously() { }
        private System.Boolean get_IsCompleted() { }
        private System.Boolean get_InternalPeekCompleted() { }
        private System.Boolean get_EndCalled() { }
        private System.Void set_EndCalled(System.Boolean value) { }
        private System.Void ProtectedInvokeCallback(System.Object result, System.IntPtr userToken) { }
        private System.Void InvokeCallback(System.Object result) { }
        private System.Void InvokeCallback() { }
        private System.Void Complete(System.IntPtr userToken) { }
        private System.Void WorkerThreadComplete(System.Object state) { }
        private System.Void Cleanup() { }
        private System.Object InternalWaitForCompletion() { }
        private System.Object WaitForCompletion(System.Boolean snap) { }

    }

    // TypeToken: 0x2000190
    public class NetRes
    {
        // Methods
        private System.String GetWebStatusString(System.String Res, System.Net.WebExceptionStatus Status) { }
        private System.String GetWebStatusString(System.Net.WebExceptionStatus Status) { }
        private System.String GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, System.String statusDescription) { }

    }

    // TypeToken: 0x2000191
    public class TimerThread
    {
        // Fields
        private static System.Collections.Generic.LinkedList<System.WeakReference> s_Queues;        // 0x0
        private static System.Collections.Generic.LinkedList<System.WeakReference> s_NewQueues;        // 0x8
        private static System.Int32 s_ThreadState;        // 0x10
        private static System.Threading.AutoResetEvent s_ThreadReadyEvent;        // 0x18
        private static System.Threading.ManualResetEvent s_ThreadShutdownEvent;        // 0x20
        private static System.Threading.WaitHandle[] s_ThreadEvents;        // 0x28
        private static System.Int32 s_CacheScanIteration;        // 0x30
        private static System.Collections.Hashtable s_QueuesCache;        // 0x38

        // Methods
        private System.Void .cctor() { }
        private System.Net.TimerThread.Queue CreateQueue(System.Int32 durationMilliseconds) { }
        private System.Net.TimerThread.Queue GetOrCreateQueue(System.Int32 durationMilliseconds) { }
        private System.Void Prod() { }
        private System.Void ThreadProc() { }
        private System.Void StopTimerThread() { }
        private System.Boolean IsTickBetween(System.Int32 start, System.Int32 end, System.Int32 comparand) { }
        private System.Void OnDomainUnload(System.Object sender, System.EventArgs e) { }

    }

    // TypeToken: 0x200019A
    public struct CookieVariant
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.CookieVariant Unknown;        // 0x0
        public static System.Net.CookieVariant Plain;        // 0x0
        public static System.Net.CookieVariant Rfc2109;        // 0x0
        public static System.Net.CookieVariant Rfc2965;        // 0x0
        public static System.Net.CookieVariant Default;        // 0x0

    }

    // TypeToken: 0x200019B
    public class Cookie
    {
        // Fields
        private static readonly System.Char[] PortSplitDelimiters;        // 0x0
        private static readonly System.Char[] Reserved2Name;        // 0x8
        private static readonly System.Char[] Reserved2Value;        // 0x10
        private static System.Net.Comparer staticComparer;        // 0x18
        private System.String m_comment;        // 0x10
        private System.Uri m_commentUri;        // 0x18
        private System.Net.CookieVariant m_cookieVariant;        // 0x20
        private System.Boolean m_discard;        // 0x24
        private System.String m_domain;        // 0x28
        private System.Boolean m_domain_implicit;        // 0x30
        private System.DateTime m_expires;        // 0x38
        private System.String m_name;        // 0x40
        private System.String m_path;        // 0x48
        private System.Boolean m_path_implicit;        // 0x50
        private System.String m_port;        // 0x58
        private System.Boolean m_port_implicit;        // 0x60
        private System.Int32[] m_port_list;        // 0x68
        private System.Boolean m_secure;        // 0x70
        private System.Boolean m_httpOnly;        // 0x71
        private System.DateTime m_timeStamp;        // 0x78
        private System.String m_value;        // 0x80
        private System.Int32 m_version;        // 0x88
        private System.String m_domainKey;        // 0x90
        private System.Boolean IsQuotedVersion;        // 0x98
        private System.Boolean IsQuotedDomain;        // 0x99

        // Methods
        private System.Void .ctor() { }
        private System.String get_Comment() { }
        private System.Void set_Comment(System.String value) { }
        private System.Void set_CommentUri(System.Uri value) { }
        private System.Void set_HttpOnly(System.Boolean value) { }
        private System.Void set_Discard(System.Boolean value) { }
        private System.String get_Domain() { }
        private System.Void set_Domain(System.String value) { }
        private System.String get__Domain() { }
        private System.Boolean get_Expired() { }
        private System.Void set_Expires(System.DateTime value) { }
        private System.String get_Name() { }
        private System.Boolean InternalSetName(System.String value) { }
        private System.String get_Path() { }
        private System.Void set_Path(System.String value) { }
        private System.String get__Path() { }
        private System.Boolean get_Plain() { }
        private System.Boolean IsDomainEqualToHost(System.String domain, System.String host) { }
        private System.Boolean VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, System.Boolean isLocalDomain, System.String localDomain, System.Boolean set_default, System.Boolean isThrow) { }
        private System.Boolean DomainCharsTest(System.String name) { }
        private System.Void set_Port(System.String value) { }
        private System.Int32[] get_PortList() { }
        private System.String get__Port() { }
        private System.Boolean get_Secure() { }
        private System.Void set_Secure(System.Boolean value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Net.CookieVariant get_Variant() { }
        private System.String get_DomainKey() { }
        private System.Int32 get_Version() { }
        private System.Void set_Version(System.Int32 value) { }
        private System.String get__Version() { }
        private System.Collections.IComparer GetComparer() { }
        private System.Boolean Equals(System.Object comparand) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200019C
    public struct CookieToken
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.CookieToken Nothing;        // 0x0
        public static System.Net.CookieToken NameValuePair;        // 0x0
        public static System.Net.CookieToken Attribute;        // 0x0
        public static System.Net.CookieToken EndToken;        // 0x0
        public static System.Net.CookieToken EndCookie;        // 0x0
        public static System.Net.CookieToken End;        // 0x0
        public static System.Net.CookieToken Equals;        // 0x0
        public static System.Net.CookieToken Comment;        // 0x0
        public static System.Net.CookieToken CommentUrl;        // 0x0
        public static System.Net.CookieToken CookieName;        // 0x0
        public static System.Net.CookieToken Discard;        // 0x0
        public static System.Net.CookieToken Domain;        // 0x0
        public static System.Net.CookieToken Expires;        // 0x0
        public static System.Net.CookieToken MaxAge;        // 0x0
        public static System.Net.CookieToken Path;        // 0x0
        public static System.Net.CookieToken Port;        // 0x0
        public static System.Net.CookieToken Secure;        // 0x0
        public static System.Net.CookieToken HttpOnly;        // 0x0
        public static System.Net.CookieToken Unknown;        // 0x0
        public static System.Net.CookieToken Version;        // 0x0

    }

    // TypeToken: 0x200019D
    public class CookieTokenizer
    {
        // Fields
        private System.Boolean m_eofCookie;        // 0x10
        private System.Int32 m_index;        // 0x14
        private System.Int32 m_length;        // 0x18
        private System.String m_name;        // 0x20
        private System.Boolean m_quoted;        // 0x28
        private System.Int32 m_start;        // 0x2C
        private System.Net.CookieToken m_token;        // 0x30
        private System.Int32 m_tokenLength;        // 0x34
        private System.String m_tokenStream;        // 0x38
        private System.String m_value;        // 0x40
        private static System.Net.CookieTokenizer.RecognizedAttribute[] RecognizedAttributes;        // 0x0
        private static System.Net.CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes;        // 0x8

        // Methods
        private System.Void .ctor(System.String tokenStream) { }
        private System.Boolean get_EndOfCookie() { }
        private System.Void set_EndOfCookie(System.Boolean value) { }
        private System.Boolean get_Eof() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_Quoted() { }
        private System.Void set_Quoted(System.Boolean value) { }
        private System.Net.CookieToken get_Token() { }
        private System.Void set_Token(System.Net.CookieToken value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.String Extract() { }
        private System.Net.CookieToken FindNext(System.Boolean ignoreComma, System.Boolean ignoreEquals) { }
        private System.Net.CookieToken Next(System.Boolean first, System.Boolean parseResponseCookies) { }
        private System.Void Reset() { }
        private System.Net.CookieToken TokenFromName(System.Boolean parseResponseCookies) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200019F
    public class CookieParser
    {
        // Fields
        private System.Net.CookieTokenizer m_tokenizer;        // 0x10

        // Methods
        private System.Void .ctor(System.String cookieString) { }
        private System.Net.Cookie Get() { }
        private System.String CheckQuoted(System.String value) { }

    }

    // TypeToken: 0x20001A0
    public class Comparer, IComparer
    {
        // Methods
        private System.Int32 System.Collections.IComparer.Compare(System.Object ol, System.Object or) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A1
    public class CookieCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Int32 m_version;        // 0x10
        private System.Collections.ArrayList m_list;        // 0x18
        private System.DateTime m_TimeStamp;        // 0x20
        private System.Boolean m_has_other_versions;        // 0x28
        private System.Boolean m_IsReadOnly;        // 0x29

        // Methods
        private System.Void .ctor() { }
        private System.Net.Cookie get_Item(System.Int32 index) { }
        private System.Void Add(System.Net.Cookie cookie) { }
        private System.Void Add(System.Net.CookieCollection cookies) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how) { }
        private System.Boolean get_IsOtherVersionSeen() { }
        private System.Int32 InternalAdd(System.Net.Cookie cookie, System.Boolean isStrict) { }
        private System.Int32 IndexOf(System.Net.Cookie cookie) { }
        private System.Void RemoveAt(System.Int32 idx) { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x20001A4
    public struct HeaderVariantInfo
    {
        // Fields
        private System.String m_name;        // 0x10
        private System.Net.CookieVariant m_variant;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.Net.CookieVariant variant) { }
        private System.String get_Name() { }
        private System.Net.CookieVariant get_Variant() { }

    }

    // TypeToken: 0x20001A5
    public class CookieContainer
    {
        // Fields
        public static System.Int32 DefaultCookieLimit;        // 0x0
        public static System.Int32 DefaultPerDomainCookieLimit;        // 0x0
        public static System.Int32 DefaultCookieLengthLimit;        // 0x0
        private static readonly System.Net.HeaderVariantInfo[] HeaderInfo;        // 0x0
        private System.Collections.Hashtable m_domainTable;        // 0x10
        private System.Int32 m_maxCookieSize;        // 0x18
        private System.Int32 m_maxCookies;        // 0x1C
        private System.Int32 m_maxCookiesPerDomain;        // 0x20
        private System.Int32 m_count;        // 0x24
        private System.String m_fqdnMyDomain;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void AddRemoveDomain(System.String key, System.Net.PathList value) { }
        private System.Void Add(System.Net.Cookie cookie, System.Boolean throwOnError) { }
        private System.Boolean AgeCookies(System.String domain) { }
        private System.Int32 ExpireCollection(System.Net.CookieCollection cc) { }
        private System.Boolean IsLocalDomain(System.String host) { }
        private System.Net.CookieCollection CookieCutter(System.Uri uri, System.String headerName, System.String setCookieHeader, System.Boolean isThrow) { }
        private System.Net.CookieCollection InternalGetCookies(System.Uri uri) { }
        private System.Void BuildCookieCollectionFromDomainMatches(System.Uri uri, System.Boolean isSecure, System.Int32 port, System.Net.CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, System.Boolean matchOnlyPlainCookie) { }
        private System.Void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, System.Int32 port, System.Boolean isSecure, System.Boolean isPlainOnly) { }
        private System.String GetCookieHeader(System.Uri uri) { }
        private System.String GetCookieHeader(System.Uri uri, System.String& optCookie2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001A6
    public class PathList
    {
        // Fields
        private System.Collections.SortedList m_list;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_Count() { }
        private System.Int32 GetCookiesCount() { }
        private System.Collections.ICollection get_Values() { }
        private System.Object get_Item(System.String s) { }
        private System.Void set_Item(System.String s, System.Object value) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Object get_SyncRoot() { }

    }

    // TypeToken: 0x20001A8
    public class CookieException : FormatException, ISerializable
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception inner) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }

    }

    // TypeToken: 0x20001A9
    public class FileWebRequest : WebRequest, ISerializable
    {
        // Fields
        private static System.Threading.WaitCallback s_GetRequestStreamCallback;        // 0x0
        private static System.Threading.WaitCallback s_GetResponseCallback;        // 0x8
        private System.String m_connectionGroupName;        // 0x38
        private System.Int64 m_contentLength;        // 0x40
        private System.Net.ICredentials m_credentials;        // 0x48
        private System.IO.FileAccess m_fileAccess;        // 0x50
        private System.Net.WebHeaderCollection m_headers;        // 0x58
        private System.String m_method;        // 0x60
        private System.Boolean m_preauthenticate;        // 0x68
        private System.Net.IWebProxy m_proxy;        // 0x70
        private System.Threading.ManualResetEvent m_readerEvent;        // 0x78
        private System.Boolean m_readPending;        // 0x80
        private System.Net.WebResponse m_response;        // 0x88
        private System.IO.Stream m_stream;        // 0x90
        private System.Boolean m_syncHint;        // 0x98
        private System.Int32 m_timeout;        // 0x9C
        private System.Uri m_uri;        // 0xA0
        private System.Boolean m_writePending;        // 0xA8
        private System.Boolean m_writing;        // 0xA9
        private System.Net.LazyAsyncResult m_WriteAResult;        // 0xB0
        private System.Net.LazyAsyncResult m_ReadAResult;        // 0xB8
        private System.Int32 m_Aborted;        // 0xC0

        // Methods
        private System.Void .ctor(System.Uri uri) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Boolean get_Aborted() { }
        private System.Void set_ConnectionGroupName(System.String value) { }
        private System.Int64 get_ContentLength() { }
        private System.Void set_ContentLength(System.Int64 value) { }
        private System.Net.ICredentials get_Credentials() { }
        private System.Void set_Credentials(System.Net.ICredentials value) { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.String get_Method() { }
        private System.Void set_Method(System.String value) { }
        private System.Void set_PreAuthenticate(System.Boolean value) { }
        private System.Net.IWebProxy get_Proxy() { }
        private System.Void set_Proxy(System.Net.IWebProxy value) { }
        private System.Int32 get_Timeout() { }
        private System.Void set_Timeout(System.Int32 value) { }
        private System.Uri get_RequestUri() { }
        private System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state) { }
        private System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state) { }
        private System.Boolean CanGetRequestStream() { }
        private System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { }
        private System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { }
        private System.Net.WebResponse GetResponse() { }
        private System.Void GetRequestStreamCallback(System.Object state) { }
        private System.Void GetResponseCallback(System.Object state) { }
        private System.Void UnblockReader() { }
        private System.Boolean get_UseDefaultCredentials() { }
        private System.Void Abort() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001AA
    public class FileWebRequestCreator, IWebRequestCreate
    {
        // Methods
        private System.Void .ctor() { }
        private System.Net.WebRequest Create(System.Uri uri) { }

    }

    // TypeToken: 0x20001AB
    public class FileWebStream : FileStream, ICloseEx
    {
        // Fields
        private System.Net.FileWebRequest m_request;        // 0x70

        // Methods
        private System.Void .ctor(System.Net.FileWebRequest request, System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing) { }
        private System.Void .ctor(System.Net.FileWebRequest request, System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, System.Int32 length, System.Boolean async) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult ar) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult ar) { }
        private System.Void CheckError() { }

    }

    // TypeToken: 0x20001AC
    public class FileWebResponse : WebResponse, ISerializable, ICloseEx
    {
        // Fields
        private System.Boolean m_closed;        // 0x20
        private System.Int64 m_contentLength;        // 0x28
        private System.IO.FileAccess m_fileAccess;        // 0x30
        private System.Net.WebHeaderCollection m_headers;        // 0x38
        private System.IO.Stream m_stream;        // 0x40
        private System.Uri m_uri;        // 0x48

        // Methods
        private System.Void .ctor(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, System.Boolean asyncHint) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Uri get_ResponseUri() { }
        private System.Void CheckDisposed() { }
        private System.Void Close() { }
        private System.Void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState) { }
        private System.IO.Stream GetResponseStream() { }

    }

    // TypeToken: 0x20001AD
    public interface IWebProxy
    {
        // Methods
        private System.Uri GetProxy(System.Uri destination) { }
        private System.Boolean IsBypassed(System.Uri host) { }
        private System.Net.ICredentials get_Credentials() { }

    }

    // TypeToken: 0x20001AE
    public class WebProxy, IWebProxy, ISerializable
    {
        // Fields
        private System.Boolean _UseRegistry;        // 0x10
        private System.Boolean _BypassOnLocal;        // 0x11
        private System.Boolean m_EnableAutoproxy;        // 0x12
        private System.Uri _ProxyAddress;        // 0x18
        private System.Collections.ArrayList _BypassList;        // 0x20
        private System.Net.ICredentials _Credentials;        // 0x28
        private System.Text.RegularExpressions.Regex[] _RegExBypassList;        // 0x30
        private System.Collections.Hashtable _ProxyHostAddresses;        // 0x38
        private System.Net.AutoWebProxyScriptEngine m_ScriptEngine;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Uri Address, System.Boolean BypassOnLocal, System.String[] BypassList, System.Net.ICredentials Credentials) { }
        private System.Net.ICredentials get_Credentials() { }
        private System.Boolean get_UseDefaultCredentials() { }
        private System.Void set_UseDefaultCredentials(System.Boolean value) { }
        private System.Uri GetProxy(System.Uri destination) { }
        private System.Void UpdateRegExList(System.Boolean canThrow) { }
        private System.Boolean IsMatchInBypassList(System.Uri input) { }
        private System.Boolean IsLocal(System.Uri host) { }
        private System.Boolean IsLocalInProxyHash(System.Uri host) { }
        private System.Boolean IsBypassed(System.Uri host) { }
        private System.Boolean IsBypassedManual(System.Uri host) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Net.AutoWebProxyScriptEngine get_ScriptEngine() { }
        private System.Net.IWebProxy CreateDefaultProxy() { }
        private System.Void .ctor(System.Boolean enableAutoproxy) { }
        private System.Void UnsafeUpdateFromRegistry() { }
        private System.Boolean GetProxyAuto(System.Uri destination, System.Uri& proxyUri) { }
        private System.Boolean IsBypassedAuto(System.Uri destination, System.Boolean& isBypassed) { }
        private System.Boolean AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, System.Boolean checkFirstOnly) { }
        private System.Uri ProxyUri(System.String proxyName) { }

    }

    // TypeToken: 0x20001AF
    public class AutoWebProxyScriptEngine
    {
        // Methods
        private System.Boolean GetProxies(System.Uri destination, System.Collections.Generic.IList<System.String>& proxyList) { }
        private System.Boolean GetProxies(System.Uri destination, System.Collections.Generic.IList<System.String>& proxyList, System.Int32& syncStatus) { }

    }

    // TypeToken: 0x20001B0
    public class UnsafeNclNativeMethods
    {
    }

    // TypeToken: 0x20001B4
    public class Logging
    {
        // Methods
        private System.Boolean get_On() { }

    }

    // TypeToken: 0x20001B5
    public class ServerCertValidationCallback
    {
        // Fields
        private readonly System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;        // 0x10
        private readonly System.Threading.ExecutionContext m_Context;        // 0x18

        // Methods
        private System.Void .ctor(System.Net.Security.RemoteCertificateValidationCallback validationCallback) { }
        private System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback() { }
        private System.Void Callback(System.Object state) { }
        private System.Boolean Invoke(System.Object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { }

    }

    // TypeToken: 0x20001B7
    public class AuthenticationManager
    {
        // Fields
        private static System.Collections.ArrayList modules;        // 0x0
        private static System.Object locker;        // 0x8
        private static System.Net.ICredentialPolicy credential_policy;        // 0x10

        // Methods
        private System.Void EnsureModules() { }
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { }
        private System.Net.Authorization DoAuthenticate(System.String challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { }
        private System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001B8
    public class BasicClient, IAuthenticationModule
    {
        // Methods
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.Byte[] GetBytes(System.String str) { }
        private System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.String get_AuthenticationType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B9
    public class BindIPEndPoint : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, System.Int32 retryCount) { }

    }

    // TypeToken: 0x20001BA
    public class BufferedReadStream : WebReadStream
    {
        // Fields
        private readonly System.Net.BufferOffsetSize readBuffer;        // 0x40

        // Methods
        private System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer) { }
        private System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean TryReadFromBuffer(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Int32& result) { }

    }

    // TypeToken: 0x20001BC
    public class ContentDecodeStream : WebReadStream
    {
        // Fields
        private readonly System.IO.Stream <OriginalInnerStream>k__BackingField;        // 0x40

        // Methods
        private System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode) { }
        private System.IO.Stream get_OriginalInnerStream() { }
        private System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream) { }
        private System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x20001BE
    public struct DecompressionMethods
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.DecompressionMethods None;        // 0x0
        public static System.Net.DecompressionMethods GZip;        // 0x0
        public static System.Net.DecompressionMethods Deflate;        // 0x0

    }

    // TypeToken: 0x20001BF
    public class DefaultCertificatePolicy
    {
    }

    // TypeToken: 0x20001C0
    public class DigestHeaderParser
    {
        // Fields
        private System.String header;        // 0x10
        private System.Int32 length;        // 0x18
        private System.Int32 pos;        // 0x1C
        private static System.String[] keywords;        // 0x0
        private System.String[] values;        // 0x20

        // Methods
        private System.Void .ctor(System.String header) { }
        private System.String get_Realm() { }
        private System.String get_Opaque() { }
        private System.String get_Nonce() { }
        private System.String get_Algorithm() { }
        private System.String get_QOP() { }
        private System.Boolean Parse() { }
        private System.Void SkipWhitespace() { }
        private System.String GetKey() { }
        private System.Boolean GetKeywordAndValue(System.String& key, System.String& value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C1
    public class DigestSession
    {
        // Fields
        private static System.Security.Cryptography.RandomNumberGenerator rng;        // 0x0
        private System.DateTime lastUse;        // 0x10
        private System.Int32 _nc;        // 0x18
        private System.Security.Cryptography.HashAlgorithm hash;        // 0x20
        private System.Net.DigestHeaderParser parser;        // 0x28
        private System.String _cnonce;        // 0x30

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.String get_Algorithm() { }
        private System.String get_Realm() { }
        private System.String get_Nonce() { }
        private System.String get_Opaque() { }
        private System.String get_QOP() { }
        private System.String get_CNonce() { }
        private System.Boolean Parse(System.String challenge) { }
        private System.String HashToHexString(System.String toBeHashed) { }
        private System.String HA1(System.String username, System.String password) { }
        private System.String HA2(System.Net.HttpWebRequest webRequest) { }
        private System.String Response(System.String username, System.String password, System.Net.HttpWebRequest webRequest) { }
        private System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.DateTime get_LastUse() { }

    }

    // TypeToken: 0x20001C2
    public class DigestClient, IAuthenticationModule
    {
        // Fields
        private static readonly System.Collections.Hashtable cache;        // 0x0

        // Methods
        private System.Collections.Hashtable get_Cache() { }
        private System.Void CheckExpired(System.Int32 count) { }
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.String get_AuthenticationType() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C3
    public class Dns
    {
        // Methods
        private System.IAsyncResult BeginGetHostAddresses(System.String hostNameOrAddress, System.AsyncCallback requestCallback, System.Object state) { }
        private System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult) { }
        private System.Boolean GetHostByName_icall(System.String host, System.String& h_name, System.String[]& h_aliases, System.String[]& h_addr_list, System.Int32 hint) { }
        private System.Boolean GetHostByAddr_icall(System.String addr, System.String& h_name, System.String[]& h_aliases, System.String[]& h_addr_list, System.Int32 hint) { }
        private System.Boolean GetHostName_icall(System.String& h_name) { }
        private System.Void Error_11001(System.String hostName) { }
        private System.Net.IPHostEntry hostent_to_IPHostEntry(System.String originalHostName, System.String h_name, System.String[] h_aliases, System.String[] h_addrlist) { }
        private System.Net.IPHostEntry GetHostByAddressFromString(System.String address, System.Boolean parse) { }
        private System.Net.IPHostEntry GetHostEntry(System.String hostNameOrAddress) { }
        private System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address) { }
        private System.Net.IPAddress[] GetHostAddresses(System.String hostNameOrAddress) { }
        private System.Net.IPHostEntry GetHostByName(System.String hostName) { }
        private System.String GetHostName() { }
        private System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(System.String hostNameOrAddress) { }

    }

    // TypeToken: 0x20001C5
    public class FixedSizeReadStream : WebReadStream
    {
        // Fields
        private readonly System.Int64 <ContentLength>k__BackingField;        // 0x40
        private System.Int64 position;        // 0x48

        // Methods
        private System.Int64 get_ContentLength() { }
        private System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Int64 contentLength) { }
        private System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x20001C7
    public class HttpRequestCreator, IWebRequestCreate
    {
        // Methods
        private System.Void .ctor() { }
        private System.Net.WebRequest Create(System.Uri uri) { }

    }

    // TypeToken: 0x20001C8
    public class HttpWebRequest : WebRequest, ISerializable
    {
        // Fields
        private System.Uri requestUri;        // 0x38
        private System.Uri actualUri;        // 0x40
        private System.Boolean hostChanged;        // 0x48
        private System.Boolean allowAutoRedirect;        // 0x49
        private System.Boolean allowBuffering;        // 0x4A
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates;        // 0x50
        private System.String connectionGroup;        // 0x58
        private System.Boolean haveContentLength;        // 0x60
        private System.Int64 contentLength;        // 0x68
        private System.Net.HttpContinueDelegate continueDelegate;        // 0x70
        private System.Net.CookieContainer cookieContainer;        // 0x78
        private System.Net.ICredentials credentials;        // 0x80
        private System.Boolean haveResponse;        // 0x88
        private System.Boolean requestSent;        // 0x89
        private System.Net.WebHeaderCollection webHeaders;        // 0x90
        private System.Boolean keepAlive;        // 0x98
        private System.Int32 maxAutoRedirect;        // 0x9C
        private System.String mediaType;        // 0xA0
        private System.String method;        // 0xA8
        private System.String initialMethod;        // 0xB0
        private System.Boolean pipelined;        // 0xB8
        private System.Boolean preAuthenticate;        // 0xB9
        private System.Boolean usedPreAuth;        // 0xBA
        private System.Version version;        // 0xC0
        private System.Boolean force_version;        // 0xC8
        private System.Version actualVersion;        // 0xD0
        private System.Net.IWebProxy proxy;        // 0xD8
        private System.Boolean sendChunked;        // 0xE0
        private System.Net.ServicePoint servicePoint;        // 0xE8
        private System.Int32 timeout;        // 0xF0
        private System.Int32 continueTimeout;        // 0xF4
        private System.Net.WebRequestStream writeStream;        // 0xF8
        private System.Net.HttpWebResponse webResponse;        // 0x100
        private System.Net.WebCompletionSource responseTask;        // 0x108
        private System.Net.WebOperation currentOperation;        // 0x110
        private System.Int32 aborted;        // 0x118
        private System.Boolean gotRequestStream;        // 0x11C
        private System.Int32 redirects;        // 0x120
        private System.Boolean expectContinue;        // 0x124
        private System.Boolean getResponseCalled;        // 0x125
        private System.Object locker;        // 0x128
        private System.Boolean finished_reading;        // 0x130
        private System.Net.DecompressionMethods auto_decomp;        // 0x134
        private static System.Int32 defaultMaxResponseHeadersLength;        // 0x0
        private static System.Int32 defaultMaximumErrorResponseLength;        // 0x4
        private static System.Net.Cache.RequestCachePolicy defaultCachePolicy;        // 0x8
        private System.Int32 readWriteTimeout;        // 0x138
        private Mono.Net.Security.MobileTlsProvider tlsProvider;        // 0x140
        private Mono.Security.Interface.MonoTlsSettings tlsSettings;        // 0x148
        private System.Net.ServerCertValidationCallback certValidationCallback;        // 0x150
        private System.Boolean hostHasPort;        // 0x158
        private System.Uri hostUri;        // 0x160
        private System.Net.HttpWebRequest.AuthorizationState auth_state;        // 0x168
        private System.Net.HttpWebRequest.AuthorizationState proxy_auth_state;        // 0x178
        private System.Func<System.IO.Stream,System.Threading.Tasks.Task> ResendContentFactory;        // 0x188
        private System.Boolean <ThrowOnError>k__BackingField;        // 0x190
        private System.Boolean unsafe_auth_blah;        // 0x191

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor(System.Uri uri) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void ResetAuthorization() { }
        private System.Uri get_Address() { }
        private System.Void set_AllowAutoRedirect(System.Boolean value) { }
        private System.Boolean get_AllowWriteStreamBuffering() { }
        private System.Void set_AllowWriteStreamBuffering(System.Boolean value) { }
        private System.Net.DecompressionMethods get_AutomaticDecompression() { }
        private System.Void set_AutomaticDecompression(System.Net.DecompressionMethods value) { }
        private System.Boolean get_InternalAllowBuffering() { }
        private System.Boolean get_MethodWithBuffer() { }
        private Mono.Net.Security.MobileTlsProvider get_TlsProvider() { }
        private Mono.Security.Interface.MonoTlsSettings get_TlsSettings() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Void set_ConnectionGroupName(System.String value) { }
        private System.Int64 get_ContentLength() { }
        private System.Void set_ContentLength(System.Int64 value) { }
        private System.Void set_InternalContentLength(System.Int64 value) { }
        private System.Boolean get_ThrowOnError() { }
        private System.Void set_ThrowOnError(System.Boolean value) { }
        private System.Void set_CookieContainer(System.Net.CookieContainer value) { }
        private System.Net.ICredentials get_Credentials() { }
        private System.Void set_Credentials(System.Net.ICredentials value) { }
        private System.Int32 get_DefaultMaximumErrorResponseLength() { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.String get_Host() { }
        private System.Void set_Host(System.String value) { }
        private System.Boolean TryGetHostUri(System.String hostName, System.Uri& hostUri) { }
        private System.Boolean get_KeepAlive() { }
        private System.Void set_KeepAlive(System.Boolean value) { }
        private System.Void set_MaximumAutomaticRedirections(System.Int32 value) { }
        private System.Int32 get_DefaultMaximumResponseHeadersLength() { }
        private System.Int32 get_ReadWriteTimeout() { }
        private System.String get_Method() { }
        private System.Void set_Method(System.String value) { }
        private System.Void set_PreAuthenticate(System.Boolean value) { }
        private System.Version get_ProtocolVersion() { }
        private System.Void set_ProtocolVersion(System.Version value) { }
        private System.Net.IWebProxy get_Proxy() { }
        private System.Void set_Proxy(System.Net.IWebProxy value) { }
        private System.Uri get_RequestUri() { }
        private System.Boolean get_SendChunked() { }
        private System.Void set_SendChunked(System.Boolean value) { }
        private System.Net.ServicePoint get_ServicePoint() { }
        private System.Net.ServicePoint get_ServicePointNoLock() { }
        private System.Int32 get_Timeout() { }
        private System.Void set_Timeout(System.Int32 value) { }
        private System.String get_TransferEncoding() { }
        private System.Boolean get_UseDefaultCredentials() { }
        private System.Boolean get_UnsafeAuthenticatedConnectionSharing() { }
        private System.Boolean get_ExpectContinue() { }
        private System.Void set_ExpectContinue(System.Boolean value) { }
        private System.Uri get_AuthUri() { }
        private System.Boolean get_ProxyQuery() { }
        private System.Net.ServerCertValidationCallback get_ServerCertValidationCallback() { }
        private System.Net.ServicePoint GetServicePoint() { }
        private System.Net.WebOperation SendRequest(System.Boolean redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.IO.Stream> MyGetRequestStreamAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state) { }
        private System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync() { }
        private System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, System.Int32 timeout, System.Action abort, System.Func<System.Boolean> aborted, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, System.Int32 timeout, System.Action abort, System.Func<System.Boolean> aborted, System.Threading.CancellationTokenSource cts) { }
        private System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func) { }
        private System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken) { }
        private System.Exception FlattenException(System.Exception e) { }
        private System.Net.WebException GetWebException(System.Exception e) { }
        private System.Net.WebException GetWebException(System.Exception e, System.Boolean aborted) { }
        private System.Net.WebException CreateRequestAbortedException() { }
        private System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state) { }
        private System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { }
        private System.Net.WebResponse GetResponse() { }
        private System.Void set_FinishedReading(System.Boolean value) { }
        private System.Boolean get_Aborted() { }
        private System.Void Abort() { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void CheckRequestStarted() { }
        private System.Void DoContinueDelegate(System.Int32 statusCode, System.Net.WebHeaderCollection headers) { }
        private System.Void RewriteRedirectToGet() { }
        private System.Boolean Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response) { }
        private System.String GetHeaders() { }
        private System.Void DoPreAuthenticate() { }
        private System.Byte[] GetRequestHeaders() { }
        private System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code) { }
        private System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, System.Boolean redirect) { }
        private System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response) { }
        private System.Boolean <RunWithTimeout>b__242_0() { }
        private System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D0
    public class HttpWebResponse : WebResponse, ISerializable, IDisposable
    {
        // Fields
        private System.Uri uri;        // 0x20
        private System.Net.WebHeaderCollection webHeaders;        // 0x28
        private System.Net.CookieCollection cookieCollection;        // 0x30
        private System.String method;        // 0x38
        private System.Version version;        // 0x40
        private System.Net.HttpStatusCode statusCode;        // 0x48
        private System.String statusDescription;        // 0x50
        private System.Int64 contentLength;        // 0x58
        private System.String contentType;        // 0x60
        private System.Net.CookieContainer cookie_container;        // 0x68
        private System.Boolean disposed;        // 0x70
        private System.IO.Stream stream;        // 0x78

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Uri uri, System.String method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers) { }
        private System.Void .ctor(System.Uri uri, System.String method, System.Net.WebResponseStream stream, System.Net.CookieContainer container) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Uri get_ResponseUri() { }
        private System.Net.HttpStatusCode get_StatusCode() { }
        private System.String get_StatusDescription() { }
        private System.IO.Stream GetResponseStream() { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void Close() { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void CheckDisposed() { }
        private System.Void FillCookies() { }

    }

    // TypeToken: 0x20001D1
    public interface ICredentialPolicy
    {
    }

    // TypeToken: 0x20001D2
    public class MonoChunkParser
    {
        // Fields
        private System.Net.WebHeaderCollection headers;        // 0x10
        private System.Int32 chunkSize;        // 0x18
        private System.Int32 chunkRead;        // 0x1C
        private System.Int32 totalWritten;        // 0x20
        private System.Net.MonoChunkParser.State state;        // 0x24
        private System.Text.StringBuilder saved;        // 0x28
        private System.Boolean sawCR;        // 0x30
        private System.Boolean gotit;        // 0x31
        private System.Int32 trailerState;        // 0x34
        private System.Collections.ArrayList chunks;        // 0x38

        // Methods
        private System.Void .ctor(System.Net.WebHeaderCollection headers) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Int32 ReadFromChunks(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void InternalWrite(System.Byte[] buffer, System.Int32& offset, System.Int32 size) { }
        private System.Boolean get_WantMore() { }
        private System.Boolean get_DataAvailable() { }
        private System.Int32 get_ChunkLeft() { }
        private System.Net.MonoChunkParser.State ReadBody(System.Byte[] buffer, System.Int32& offset, System.Int32 size) { }
        private System.Net.MonoChunkParser.State GetChunkSize(System.Byte[] buffer, System.Int32& offset, System.Int32 size) { }
        private System.String RemoveChunkExtension(System.String input) { }
        private System.Net.MonoChunkParser.State ReadCRLF(System.Byte[] buffer, System.Int32& offset, System.Int32 size) { }
        private System.Net.MonoChunkParser.State ReadTrailer(System.Byte[] buffer, System.Int32& offset, System.Int32 size) { }
        private System.Void ThrowProtocolViolation(System.String message) { }

    }

    // TypeToken: 0x20001D5
    public class MonoChunkStream : WebReadStream
    {
        // Fields
        private readonly System.Net.WebHeaderCollection <Headers>k__BackingField;        // 0x40
        private readonly System.Net.MonoChunkParser <Decoder>k__BackingField;        // 0x48

        // Methods
        private System.Net.MonoChunkParser get_Decoder() { }
        private System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers) { }
        private System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken) { }
        private System.Void ThrowExpectingChunkTrailer() { }
        private System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x20001D8
    public class NtlmClient, IAuthenticationModule
    {
        // Fields
        private System.Net.IAuthenticationModule authObject;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { }
        private System.String get_AuthenticationType() { }

    }

    // TypeToken: 0x20001D9
    public class ServicePoint
    {
        // Fields
        private readonly System.Uri uri;        // 0x10
        private System.DateTime lastDnsResolve;        // 0x18
        private System.Version protocolVersion;        // 0x20
        private System.Net.IPHostEntry host;        // 0x28
        private System.Boolean usesProxy;        // 0x30
        private System.Boolean sendContinue;        // 0x31
        private System.Boolean useConnect;        // 0x32
        private System.Object hostE;        // 0x38
        private System.Boolean useNagle;        // 0x40
        private System.Net.BindIPEndPoint endPointCallback;        // 0x48
        private System.Boolean tcp_keepalive;        // 0x50
        private System.Int32 tcp_keepalive_time;        // 0x54
        private System.Int32 tcp_keepalive_interval;        // 0x58
        private System.Boolean disposed;        // 0x5C
        private System.Int32 connectionLeaseTimeout;        // 0x60
        private System.Int32 receiveBufferSize;        // 0x64
        private readonly System.Net.ServicePointManager.SPKey <Key>k__BackingField;        // 0x68
        private System.Net.ServicePointScheduler <Scheduler>k__BackingField;        // 0x70
        private System.Int32 connectionLimit;        // 0x78
        private System.Int32 maxIdleTime;        // 0x7C
        private System.Object m_ServerCertificateOrBytes;        // 0x80
        private System.Object m_ClientCertificateOrBytes;        // 0x88

        // Methods
        private System.Void .ctor(System.Net.ServicePointManager.SPKey key, System.Uri uri, System.Int32 connectionLimit, System.Int32 maxIdleTime) { }
        private System.Net.ServicePointManager.SPKey get_Key() { }
        private System.Net.ServicePointScheduler get_Scheduler() { }
        private System.Void set_Scheduler(System.Net.ServicePointScheduler value) { }
        private System.Uri get_Address() { }
        private System.Int32 get_ConnectionLimit() { }
        private System.Version get_ProtocolVersion() { }
        private System.Void set_Expect100Continue(System.Boolean value) { }
        private System.Boolean get_UseNagleAlgorithm() { }
        private System.Void set_UseNagleAlgorithm(System.Boolean value) { }
        private System.Boolean get_SendContinue() { }
        private System.Void set_SendContinue(System.Boolean value) { }
        private System.Void SetTcpKeepAlive(System.Boolean enabled, System.Int32 keepAliveTime, System.Int32 keepAliveInterval) { }
        private System.Void KeepAliveSetup(System.Net.Sockets.Socket socket) { }
        private System.Void PutBytes(System.Byte[] bytes, System.UInt32 v, System.Int32 offset) { }
        private System.Boolean get_UsesProxy() { }
        private System.Void set_UsesProxy(System.Boolean value) { }
        private System.Boolean get_UseConnect() { }
        private System.Void set_UseConnect(System.Boolean value) { }
        private System.Boolean get_HasTimedOut() { }
        private System.Net.IPHostEntry get_HostEntry() { }
        private System.Void SetVersion(System.Version version) { }
        private System.Void SendRequest(System.Net.WebOperation operation, System.String groupName) { }
        private System.Boolean CloseConnectionGroup(System.String connectionGroupName) { }
        private System.Void FreeServicePoint() { }
        private System.Void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        private System.Void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        private System.Boolean CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote) { }

    }

    // TypeToken: 0x20001DA
    public class ServicePointManager
    {
        // Fields
        private static System.Collections.Concurrent.ConcurrentDictionary<System.Net.ServicePointManager.SPKey,System.Net.ServicePoint> servicePoints;        // 0x0
        private static System.Net.ICertificatePolicy policy;        // 0x8
        private static System.Int32 defaultConnectionLimit;        // 0x10
        private static System.Int32 maxServicePointIdleTime;        // 0x14
        private static System.Int32 maxServicePoints;        // 0x18
        private static System.Int32 dnsRefreshTimeout;        // 0x1C
        private static System.Boolean _checkCRL;        // 0x20
        private static System.Net.SecurityProtocolType _securityProtocol;        // 0x24
        private static System.Boolean expectContinue;        // 0x28
        private static System.Boolean useNagle;        // 0x29
        private static System.Net.ServerCertValidationCallback server_cert_cb;        // 0x30
        private static System.Boolean tcp_keepalive;        // 0x38
        private static System.Int32 tcp_keepalive_time;        // 0x3C
        private static System.Int32 tcp_keepalive_interval;        // 0x40

        // Methods
        private System.Void .cctor() { }
        private System.Net.ICertificatePolicy GetLegacyCertificatePolicy() { }
        private System.Boolean get_CheckCertificateRevocationList() { }
        private System.Int32 get_DnsRefreshTimeout() { }
        private System.Net.SecurityProtocolType get_SecurityProtocol() { }
        private System.Net.ServerCertValidationCallback get_ServerCertValidationCallback() { }
        private System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }
        private System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy) { }
        private System.Void CloseConnectionGroup(System.String connectionGroupName) { }
        private System.Void RemoveServicePoint(System.Net.ServicePoint sp) { }

    }

    // TypeToken: 0x20001DC
    public class ServicePointScheduler
    {
        // Fields
        private System.Net.ServicePoint <ServicePoint>k__BackingField;        // 0x10
        private System.Int32 running;        // 0x18
        private System.Int32 maxIdleTime;        // 0x1C
        private System.Net.ServicePointScheduler.AsyncManualResetEvent schedulerEvent;        // 0x20
        private System.Net.ServicePointScheduler.ConnectionGroup defaultGroup;        // 0x28
        private System.Collections.Generic.Dictionary<System.String,System.Net.ServicePointScheduler.ConnectionGroup> groups;        // 0x30
        private System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebOperation>> operations;        // 0x38
        private System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebConnection,System.Threading.Tasks.Task>> idleConnections;        // 0x40
        private System.Int32 currentConnections;        // 0x48
        private System.Int32 connectionLimit;        // 0x4C
        private System.DateTime idleSince;        // 0x50
        private static System.Int32 nextId;        // 0x0
        public readonly System.Int32 ID;        // 0x58

        // Methods
        private System.Net.ServicePoint get_ServicePoint() { }
        private System.Void set_ServicePoint(System.Net.ServicePoint value) { }
        private System.Int32 get_MaxIdleTime() { }
        private System.Void .ctor(System.Net.ServicePoint servicePoint, System.Int32 connectionLimit, System.Int32 maxIdleTime) { }
        private System.Void Run() { }
        private System.Threading.Tasks.Task RunScheduler() { }
        private System.Void Cleanup() { }
        private System.Void RunSchedulerIteration() { }
        private System.Boolean OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation) { }
        private System.Void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection) { }
        private System.Boolean SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group) { }
        private System.Void RemoveOperation(System.Net.WebOperation operation) { }
        private System.Void RemoveIdleConnection(System.Net.WebConnection connection) { }
        private System.Void FinalCleanup() { }
        private System.Void SendRequest(System.Net.WebOperation operation, System.String groupName) { }
        private System.Boolean CloseConnectionGroup(System.String groupName) { }
        private System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(System.String name) { }
        private System.Void OnConnectionCreated(System.Net.WebConnection connection) { }
        private System.Void OnConnectionClosed(System.Net.WebConnection connection) { }
        private System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Threading.Tasks.Task workerTask, System.Int32 millisecondTimeout) { }
        private System.Threading.Tasks.Task <Run>b__31_0() { }

    }

    // TypeToken: 0x20001E2
    public class WebCompletionSource`1
    {
        // Fields
        private System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion;        // 0x0
        private System.Net.WebCompletionSource.Result<T> currentResult;        // 0x0

        // Methods
        private System.Void .ctor(System.Boolean runAsync) { }
        private System.Net.WebCompletionSource.Result<T> get_CurrentResult() { }
        private System.Threading.Tasks.Task get_Task() { }
        private System.Boolean TrySetCompleted(T argument) { }
        private System.Boolean TrySetCompleted() { }
        private System.Boolean TrySetCanceled() { }
        private System.Boolean TrySetCanceled(System.OperationCanceledException error) { }
        private System.Boolean TrySetException(System.Exception error) { }
        private System.Void ThrowOnError() { }
        private System.Threading.Tasks.Task<T> WaitForCompletion() { }

    }

    // TypeToken: 0x20001E6
    public class WebCompletionSource : WebCompletionSource`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E7
    public struct ReadState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.ReadState None;        // 0x0
        public static System.Net.ReadState Status;        // 0x0
        public static System.Net.ReadState Headers;        // 0x0
        public static System.Net.ReadState Content;        // 0x0
        public static System.Net.ReadState Aborted;        // 0x0

    }

    // TypeToken: 0x20001E8
    public class WebConnection, IDisposable
    {
        // Fields
        private System.Net.NetworkCredential ntlm_credentials;        // 0x10
        private System.Boolean ntlm_authenticated;        // 0x18
        private System.Boolean unsafe_sharing;        // 0x19
        private System.IO.Stream networkStream;        // 0x20
        private System.Net.Sockets.Socket socket;        // 0x28
        private Mono.Net.Security.MonoTlsStream monoTlsStream;        // 0x30
        private System.Net.WebConnectionTunnel tunnel;        // 0x38
        private System.Int32 disposed;        // 0x40
        private readonly System.Net.ServicePoint <ServicePoint>k__BackingField;        // 0x48
        private System.DateTime idleSince;        // 0x50
        private System.Net.WebOperation currentOperation;        // 0x58

        // Methods
        private System.Net.ServicePoint get_ServicePoint() { }
        private System.Void .ctor(System.Net.ServicePoint sPoint) { }
        private System.Boolean CanReuse() { }
        private System.Boolean CheckReusable() { }
        private System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Boolean> CreateStream(System.Net.WebOperation operation, System.Boolean reused, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken) { }
        private System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error) { }
        private System.Boolean ReadLine(System.Byte[] buffer, System.Int32& start, System.Int32 max, System.String& output) { }
        private System.Boolean CanReuseConnection(System.Net.WebOperation operation) { }
        private System.Boolean PrepareSharingNtlm(System.Net.WebOperation operation) { }
        private System.Void Reset() { }
        private System.Void Close(System.Boolean reset) { }
        private System.Void CloseSocket() { }
        private System.Boolean get_Closed() { }
        private System.DateTime get_IdleSince() { }
        private System.Boolean StartOperation(System.Net.WebOperation operation, System.Boolean reused) { }
        private System.Boolean Continue(System.Net.WebOperation next) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Void ResetNtlm() { }
        private System.Boolean get_NtlmAuthenticated() { }
        private System.Void set_NtlmAuthenticated(System.Boolean value) { }
        private System.Net.NetworkCredential get_NtlmCredential() { }
        private System.Void set_NtlmCredential(System.Net.NetworkCredential value) { }
        private System.Boolean get_UnsafeAuthenticatedConnectionSharing() { }
        private System.Void set_UnsafeAuthenticatedConnectionSharing(System.Boolean value) { }

    }

    // TypeToken: 0x20001ED
    public class WebConnectionStream : Stream
    {
        // Fields
        protected System.Boolean closed;        // 0x28
        private System.Boolean disposed;        // 0x29
        private System.Object locker;        // 0x30
        private System.Int32 read_timeout;        // 0x38
        private System.Int32 write_timeout;        // 0x3C
        private readonly System.Net.HttpWebRequest <Request>k__BackingField;        // 0x40
        private readonly System.Net.WebConnection <Connection>k__BackingField;        // 0x48
        private readonly System.Net.WebOperation <Operation>k__BackingField;        // 0x50

        // Methods
        private System.Void .ctor(System.Net.WebConnection cnc, System.Net.WebOperation operation) { }
        private System.Net.HttpWebRequest get_Request() { }
        private System.Net.WebConnection get_Connection() { }
        private System.Net.WebOperation get_Operation() { }
        private System.Net.ServicePoint get_ServicePoint() { }
        private System.Boolean get_CanTimeout() { }
        private System.Int32 get_ReadTimeout() { }
        private System.Void set_ReadTimeout(System.Int32 value) { }
        private System.Int32 get_WriteTimeout() { }
        private System.Void set_WriteTimeout(System.Int32 value) { }
        private System.Exception GetException(System.Exception e) { }
        private System.Boolean TryReadFromBufferedContent(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Int32& result) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback cb, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult r) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback cb, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult r) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Flush() { }
        private System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Void InternalClose() { }
        private System.Void Close_internal(System.Boolean& disposed) { }
        private System.Void Close() { }
        private System.Int64 Seek(System.Int64 a, System.IO.SeekOrigin b) { }
        private System.Void SetLength(System.Int64 a) { }
        private System.Boolean get_CanSeek() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }

    }

    // TypeToken: 0x20001EE
    public class WebConnectionTunnel
    {
        // Fields
        private readonly System.Net.HttpWebRequest <Request>k__BackingField;        // 0x10
        private readonly System.Uri <ConnectUri>k__BackingField;        // 0x18
        private System.Net.HttpWebRequest connectRequest;        // 0x20
        private System.Net.WebConnectionTunnel.NtlmAuthState ntlmAuthState;        // 0x28
        private System.Boolean <Success>k__BackingField;        // 0x2C
        private System.Boolean <CloseConnection>k__BackingField;        // 0x2D
        private System.Int32 <StatusCode>k__BackingField;        // 0x30
        private System.String <StatusDescription>k__BackingField;        // 0x38
        private System.String[] <Challenge>k__BackingField;        // 0x40
        private System.Net.WebHeaderCollection <Headers>k__BackingField;        // 0x48
        private System.Version <ProxyVersion>k__BackingField;        // 0x50
        private System.Byte[] <Data>k__BackingField;        // 0x58

        // Methods
        private System.Net.HttpWebRequest get_Request() { }
        private System.Uri get_ConnectUri() { }
        private System.Void .ctor(System.Net.HttpWebRequest request, System.Uri connectUri) { }
        private System.Boolean get_Success() { }
        private System.Void set_Success(System.Boolean value) { }
        private System.Boolean get_CloseConnection() { }
        private System.Void set_CloseConnection(System.Boolean value) { }
        private System.Int32 get_StatusCode() { }
        private System.Void set_StatusCode(System.Int32 value) { }
        private System.Void set_StatusDescription(System.String value) { }
        private System.String[] get_Challenge() { }
        private System.Void set_Challenge(System.String[] value) { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Void set_Headers(System.Net.WebHeaderCollection value) { }
        private System.Version get_ProxyVersion() { }
        private System.Void set_ProxyVersion(System.Version value) { }
        private System.Byte[] get_Data() { }
        private System.Void set_Data(System.Byte[] value) { }
        private System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }
        private System.Void FlushContents(System.IO.Stream stream, System.Int32 contentLength) { }

    }

    // TypeToken: 0x20001F2
    public class WebOperation
    {
        // Fields
        private readonly System.Net.HttpWebRequest <Request>k__BackingField;        // 0x10
        private System.Net.WebConnection <Connection>k__BackingField;        // 0x18
        private System.Net.ServicePoint <ServicePoint>k__BackingField;        // 0x20
        private readonly System.Net.BufferOffsetSize <WriteBuffer>k__BackingField;        // 0x28
        private readonly System.Boolean <IsNtlmChallenge>k__BackingField;        // 0x30
        private System.Threading.CancellationTokenSource cts;        // 0x38
        private System.Net.WebCompletionSource<System.Net.WebRequestStream> requestTask;        // 0x40
        private System.Net.WebCompletionSource<System.Net.WebRequestStream> requestWrittenTask;        // 0x48
        private System.Net.WebCompletionSource<System.Net.WebResponseStream> responseTask;        // 0x50
        private System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> finishedTask;        // 0x58
        private System.Net.WebRequestStream writeStream;        // 0x60
        private System.Net.WebResponseStream responseStream;        // 0x68
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo disposedInfo;        // 0x70
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo closedInfo;        // 0x78
        private System.Net.WebOperation priorityRequest;        // 0x80
        private System.Int32 requestSent;        // 0x88
        private System.Int32 finished;        // 0x8C

        // Methods
        private System.Net.HttpWebRequest get_Request() { }
        private System.Net.WebConnection get_Connection() { }
        private System.Void set_Connection(System.Net.WebConnection value) { }
        private System.Net.ServicePoint get_ServicePoint() { }
        private System.Void set_ServicePoint(System.Net.ServicePoint value) { }
        private System.Net.BufferOffsetSize get_WriteBuffer() { }
        private System.Boolean get_IsNtlmChallenge() { }
        private System.Void .ctor(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, System.Boolean isNtlmChallenge, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean get_Aborted() { }
        private System.Boolean get_Closed() { }
        private System.Void Abort() { }
        private System.Void Close() { }
        private System.Void SetCanceled() { }
        private System.Void SetError(System.Exception error) { }
        private System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(System.Runtime.ExceptionServices.ExceptionDispatchInfo& field) { }
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken) { }
        private System.Void ThrowIfDisposed() { }
        private System.Void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken) { }
        private System.Void ThrowIfClosedOrDisposed() { }
        private System.Void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken) { }
        private System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(System.Boolean throwIt, System.Runtime.ExceptionServices.ExceptionDispatchInfo& field) { }
        private System.Void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection) { }
        private System.Void SetPriorityRequest(System.Net.WebOperation operation) { }
        private System.Threading.Tasks.Task<System.IO.Stream> GetRequestStream() { }
        private System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal() { }
        private System.Net.WebRequestStream get_WriteStream() { }
        private System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream() { }
        private System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished() { }
        private System.Void Run() { }
        private System.Void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error) { }
        private System.Void Finish(System.Boolean ok, System.Exception error) { }
        private System.Void <RegisterRequest>b__48_0() { }

    }

    // TypeToken: 0x20001F5
    public class WebReadStream : Stream
    {
        // Fields
        private readonly System.Net.WebOperation <Operation>k__BackingField;        // 0x28
        private readonly System.IO.Stream <InnerStream>k__BackingField;        // 0x30
        private System.Boolean disposed;        // 0x38

        // Methods
        private System.Net.WebOperation get_Operation() { }
        private System.IO.Stream get_InnerStream() { }
        private System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream) { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Flush() { }
        private System.Exception GetException(System.Exception e) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback cb, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult r) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken) { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20001F7
    public class WebRequestStream : WebConnectionStream
    {
        // Fields
        private static System.Byte[] crlf;        // 0x0
        private System.IO.MemoryStream writeBuffer;        // 0x58
        private System.Boolean requestWritten;        // 0x60
        private System.Boolean allowBuffering;        // 0x61
        private System.Boolean sendChunked;        // 0x62
        private System.Net.WebCompletionSource pendingWrite;        // 0x68
        private System.Int64 totalWritten;        // 0x70
        private System.Byte[] headers;        // 0x78
        private System.Boolean headersSent;        // 0x80
        private System.Int32 completeRequestWritten;        // 0x84
        private System.Int32 chunkTrailerWritten;        // 0x88
        private readonly System.IO.Stream <InnerStream>k__BackingField;        // 0x90
        private readonly System.Boolean <KeepAlive>k__BackingField;        // 0x98

        // Methods
        private System.Void .ctor(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel) { }
        private System.IO.Stream get_InnerStream() { }
        private System.Boolean get_KeepAlive() { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_HasWriteBuffer() { }
        private System.Int32 get_WriteBufferLength() { }
        private System.Net.BufferOffsetSize GetWriteBuffer() { }
        private System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsyncInner(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task ProcessWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Void CheckWriteOverflow(System.Int64 contentLength, System.Int64 totalWritten, System.Int64 size) { }
        private System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task SetHeadersAsync(System.Boolean setInternalLength, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteChunkTrailer() { }
        private System.Void KillBuffer() { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean TryReadFromBufferedContent(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Int32& result) { }
        private System.Void Close_internal(System.Boolean& disposed) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000200
    public class WebResponseStream : WebConnectionStream
    {
        // Fields
        private System.Net.WebReadStream innerStream;        // 0x58
        private System.Boolean nextReadCalled;        // 0x60
        private System.Boolean bufferedEntireContent;        // 0x61
        private System.Net.WebCompletionSource pendingRead;        // 0x68
        private System.Object locker;        // 0x70
        private System.Int32 nestedRead;        // 0x78
        private System.Boolean read_eof;        // 0x7C
        private readonly System.Net.WebRequestStream <RequestStream>k__BackingField;        // 0x80
        private System.Net.WebHeaderCollection <Headers>k__BackingField;        // 0x88
        private System.Net.HttpStatusCode <StatusCode>k__BackingField;        // 0x90
        private System.String <StatusDescription>k__BackingField;        // 0x98
        private System.Version <Version>k__BackingField;        // 0xA0
        private System.Boolean <KeepAlive>k__BackingField;        // 0xA8
        private System.Boolean <ChunkedRead>k__BackingField;        // 0xA9

        // Methods
        private System.Net.WebRequestStream get_RequestStream() { }
        private System.Net.WebHeaderCollection get_Headers() { }
        private System.Void set_Headers(System.Net.WebHeaderCollection value) { }
        private System.Net.HttpStatusCode get_StatusCode() { }
        private System.Void set_StatusCode(System.Net.HttpStatusCode value) { }
        private System.String get_StatusDescription() { }
        private System.Void set_StatusDescription(System.String value) { }
        private System.Version get_Version() { }
        private System.Void set_Version(System.Version value) { }
        private System.Boolean get_KeepAlive() { }
        private System.Void set_KeepAlive(System.Boolean value) { }
        private System.Void .ctor(System.Net.WebRequestStream request) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_ChunkedRead() { }
        private System.Void set_ChunkedRead(System.Boolean value) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Int32> ProcessRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean TryReadFromBufferedContent(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Int32& result) { }
        private System.Boolean get_ExpectContent() { }
        private System.Void Initialize(System.Net.BufferOffsetSize buffer) { }
        private System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task ReadAllAsync(System.Boolean resending, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Close_internal(System.Boolean& disposed) { }
        private System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, System.String where) { }
        private System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean GetResponse(System.Net.BufferOffsetSize buffer, System.Int32& pos, System.Net.ReadState& state) { }

    }

}

namespace System.Net.Cache
{

    // TypeToken: 0x200022F
    public class RequestCache
    {
        // Fields
        private static readonly System.Char[] LineSplits;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000230
    public class RequestCacheManager
    {
        // Fields
        private static System.Net.Cache.RequestCachingSectionInternal s_CacheConfigSettings;        // 0x0
        private static readonly System.Net.Cache.RequestCacheBinding s_BypassCacheBinding;        // 0x8
        private static System.Net.Cache.RequestCacheBinding s_DefaultGlobalBinding;        // 0x10
        private static System.Net.Cache.RequestCacheBinding s_DefaultHttpBinding;        // 0x18
        private static System.Net.Cache.RequestCacheBinding s_DefaultFtpBinding;        // 0x20

        // Methods
        private System.Net.Cache.RequestCacheBinding GetBinding(System.String internedScheme) { }
        private System.Void LoadConfigSettings() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000231
    public class RequestCacheValidator
    {
        // Methods
        private System.Object CreateValidator() { }

    }

    // TypeToken: 0x2000232
    public class RequestCachingSectionInternal
    {
        // Fields
        public readonly System.Boolean DisableAllCaching;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000233
    public class RequestCacheBinding
    {
        // Fields
        private System.Net.Cache.RequestCache m_RequestCache;        // 0x10
        private System.Net.Cache.RequestCacheValidator m_CacheValidator;        // 0x18
        private System.Net.Cache.RequestCachePolicy m_Policy;        // 0x20

        // Methods
        private System.Void .ctor(System.Net.Cache.RequestCache requestCache, System.Net.Cache.RequestCacheValidator cacheValidator, System.Net.Cache.RequestCachePolicy policy) { }
        private System.Net.Cache.RequestCache get_Cache() { }
        private System.Net.Cache.RequestCacheValidator get_Validator() { }
        private System.Net.Cache.RequestCachePolicy get_Policy() { }

    }

    // TypeToken: 0x2000234
    public struct RequestCacheLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Cache.RequestCacheLevel Default;        // 0x0
        public static System.Net.Cache.RequestCacheLevel BypassCache;        // 0x0
        public static System.Net.Cache.RequestCacheLevel CacheOnly;        // 0x0
        public static System.Net.Cache.RequestCacheLevel CacheIfAvailable;        // 0x0
        public static System.Net.Cache.RequestCacheLevel Revalidate;        // 0x0
        public static System.Net.Cache.RequestCacheLevel Reload;        // 0x0
        public static System.Net.Cache.RequestCacheLevel NoCacheNoStore;        // 0x0

    }

    // TypeToken: 0x2000235
    public class RequestCachePolicy
    {
        // Fields
        private System.Net.Cache.RequestCacheLevel m_Level;        // 0x10

        // Methods
        private System.Void .ctor(System.Net.Cache.RequestCacheLevel level) { }
        private System.Net.Cache.RequestCacheLevel get_Level() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000236
    public class RequestCacheProtocol
    {
        // Methods
        private System.Void .ctor(System.Object arg1, System.Object arg2) { }

    }

}

namespace System.Net.Configuration
{

    // TypeToken: 0x200022D
    public class DefaultProxySectionInternal
    {
        // Fields
        private System.Net.IWebProxy webProxy;        // 0x10
        private static System.Object classSyncObject;        // 0x0

        // Methods
        private System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode() { }
        private System.Net.IWebProxy GetSystemWebProxy() { }
        private System.Object get_ClassSyncObject() { }
        private System.Net.Configuration.DefaultProxySectionInternal GetSection() { }
        private System.Net.IWebProxy get_WebProxy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022E
    public class SettingsSectionInternal
    {
        // Fields
        private static readonly System.Net.Configuration.SettingsSectionInternal instance;        // 0x0
        private readonly System.Boolean HttpListenerUnescapeRequestUrl;        // 0x10
        private readonly System.Net.Sockets.IPProtectionLevel IPProtectionLevel;        // 0x14

        // Methods
        private System.Net.Configuration.SettingsSectionInternal get_Section() { }
        private System.Boolean get_Ipv6Enabled() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200037A
    public class BypassElement : ConfigurationElement
    {
    }

    // TypeToken: 0x200037B
    public class BypassElementCollection : ConfigurationElementCollection
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200037C
    public class ConnectionManagementElement : ConfigurationElement
    {
    }

    // TypeToken: 0x200037D
    public class ConnectionManagementElementCollection : ConfigurationElementCollection
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200037E
    public class ConnectionManagementSection : ConfigurationSection
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x200037F
    public class DefaultProxySection : ConfigurationSection
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }
        private System.Void Reset(System.Configuration.ConfigurationElement parentElement) { }

    }

    // TypeToken: 0x2000380
    public class ProxyElement : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000381
    public class HttpWebRequestElement : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000382
    public class Ipv6Element : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000383
    public class NetSectionGroup : ConfigurationSectionGroup
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000384
    public class SettingsSection : ConfigurationSection
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000385
    public class PerformanceCountersElement : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000386
    public class ServicePointManagerElement : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000387
    public class SocketElement : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000388
    public class WebProxyScriptElement : ConfigurationElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x2000389
    public class WebRequestModulesSection : ConfigurationSection
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }

    }

    // TypeToken: 0x200038A
    public class WebRequestModuleElementCollection : ConfigurationElementCollection
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200038B
    public class WebRequestModuleElement : ConfigurationElement
    {
    }

}

namespace System.Net.Mail
{

    // TypeToken: 0x2000280
    public class DomainLiteralReader
    {
        // Methods
        private System.Int32 ReadReverse(System.String data, System.Int32 index) { }

    }

    // TypeToken: 0x2000281
    public class DotAtomReader
    {
        // Methods
        private System.Int32 ReadReverse(System.String data, System.Int32 index) { }

    }

    // TypeToken: 0x2000282
    public class MailAddressParser
    {
        // Methods
        private System.Net.Mail.MailAddress ParseAddress(System.String data) { }
        private System.Net.Mail.MailAddress ParseAddress(System.String data, System.Boolean expectMultipleAddresses, System.Int32& index) { }
        private System.Int32 ReadCfwsAndThrowIfIncomplete(System.String data, System.Int32 index) { }
        private System.String ParseDomain(System.String data, System.Int32& index) { }
        private System.String ParseLocalPart(System.String data, System.Int32& index, System.Boolean expectAngleBracket, System.Boolean expectMultipleAddresses) { }
        private System.String ParseDisplayName(System.String data, System.Int32& index, System.Boolean expectMultipleAddresses) { }
        private System.String NormalizeOrThrow(System.String input) { }

    }

    // TypeToken: 0x2000283
    public class QuotedPairReader
    {
        // Methods
        private System.Int32 CountQuotedChars(System.String data, System.Int32 index, System.Boolean permitUnicodeEscaping) { }
        private System.Int32 CountBackslashes(System.String data, System.Int32 index) { }

    }

    // TypeToken: 0x2000284
    public class QuotedStringFormatReader
    {
        // Methods
        private System.Int32 ReadReverseQuoted(System.String data, System.Int32 index, System.Boolean permitUnicode) { }
        private System.Int32 ReadReverseUnQuoted(System.String data, System.Int32 index, System.Boolean permitUnicode, System.Boolean expectCommaDelimiter) { }
        private System.Boolean IsValidQtext(System.Boolean allowUnicode, System.Char ch) { }

    }

    // TypeToken: 0x2000285
    public class WhitespaceReader
    {
        // Methods
        private System.Int32 ReadFwsReverse(System.String data, System.Int32 index) { }
        private System.Int32 ReadCfwsReverse(System.String data, System.Int32 index) { }

    }

    // TypeToken: 0x2000286
    public class MailAddress
    {
        // Fields
        private readonly System.Text.Encoding _displayNameEncoding;        // 0x10
        private readonly System.String _displayName;        // 0x18
        private readonly System.String _userName;        // 0x20
        private readonly System.String _host;        // 0x28
        private static readonly System.Net.Mime.EncodedStreamFactory s_encoderFactory;        // 0x0

        // Methods
        private System.Void .ctor(System.String displayName, System.String userName, System.String domain) { }
        private System.Void .ctor(System.String address) { }
        private System.Void .ctor(System.String address, System.String displayName, System.Text.Encoding displayNameEncoding) { }
        private System.String get_DisplayName() { }
        private System.String get_Address() { }
        private System.String get_SmtpAddress() { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

}

namespace System.Net.Mime
{

    // TypeToken: 0x200027E
    public class MailBnfHelper
    {
        // Fields
        private static readonly System.Boolean[] Atext;        // 0x0
        private static readonly System.Boolean[] Qtext;        // 0x8
        private static readonly System.Boolean[] Dtext;        // 0x10
        private static readonly System.Boolean[] Ftext;        // 0x18
        private static readonly System.Boolean[] Ttext;        // 0x20
        private static readonly System.Boolean[] Ctext;        // 0x28
        private static readonly System.Int32 Ascii7bitMaxValue;        // 0x30
        private static readonly System.Char Quote;        // 0x34
        private static readonly System.Char Space;        // 0x36
        private static readonly System.Char Tab;        // 0x38
        private static readonly System.Char CR;        // 0x3A
        private static readonly System.Char LF;        // 0x3C
        private static readonly System.Char StartComment;        // 0x3E
        private static readonly System.Char EndComment;        // 0x40
        private static readonly System.Char Backslash;        // 0x42
        private static readonly System.Char At;        // 0x44
        private static readonly System.Char EndAngleBracket;        // 0x46
        private static readonly System.Char StartAngleBracket;        // 0x48
        private static readonly System.Char StartSquareBracket;        // 0x4A
        private static readonly System.Char EndSquareBracket;        // 0x4C
        private static readonly System.Char Comma;        // 0x4E
        private static readonly System.Char Dot;        // 0x50
        private static readonly System.Char[] s_colonSeparator;        // 0x58
        private static System.String[] s_months;        // 0x60

        // Methods
        private System.Boolean[] CreateCharactersAllowedInAtoms() { }
        private System.Boolean[] CreateCharactersAllowedInQuotedStrings() { }
        private System.Boolean[] CreateCharactersAllowedInDomainLiterals() { }
        private System.Boolean[] CreateCharactersAllowedInHeaderNames() { }
        private System.Boolean[] CreateCharactersAllowedInTokens() { }
        private System.Boolean[] CreateCharactersAllowedInComments() { }
        private System.Boolean IsAllowedWhiteSpace(System.Char c) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200027F
    public class EncodedStreamFactory
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Net.NetworkInformation
{

    // TypeToken: 0x2000206
    public struct DuplicateAddressDetectionState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.DuplicateAddressDetectionState Invalid;        // 0x0
        public static System.Net.NetworkInformation.DuplicateAddressDetectionState Tentative;        // 0x0
        public static System.Net.NetworkInformation.DuplicateAddressDetectionState Duplicate;        // 0x0
        public static System.Net.NetworkInformation.DuplicateAddressDetectionState Deprecated;        // 0x0
        public static System.Net.NetworkInformation.DuplicateAddressDetectionState Preferred;        // 0x0

    }

    // TypeToken: 0x2000207
    public class IPAddressInformation
    {
        // Methods
        private System.Net.IPAddress get_Address() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000208
    public class IPGlobalProperties
    {
        // Methods
        private System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties() { }
        private System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties() { }
        private System.String get_DomainName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000209
    public class IPInterfaceProperties
    {
        // Methods
        private System.Net.NetworkInformation.UnicastIPAddressInformationCollection get_UnicastAddresses() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020A
    public class IPv4InterfaceStatistics
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020B
    public class NetworkInformationException : Win32Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 errorCode) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }

    }

    // TypeToken: 0x200020C
    public class NetworkInterface
    {
        // Methods
        private System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces() { }
        private System.Net.NetworkInformation.IPInterfaceProperties GetIPProperties() { }
        private System.Net.NetworkInformation.OperationalStatus get_OperationalStatus() { }
        private System.Net.NetworkInformation.NetworkInterfaceType get_NetworkInterfaceType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020D
    public struct NetworkInterfaceComponent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.NetworkInterfaceComponent IPv4;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceComponent IPv6;        // 0x0

    }

    // TypeToken: 0x200020E
    public struct OperationalStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.OperationalStatus Up;        // 0x0
        public static System.Net.NetworkInformation.OperationalStatus Down;        // 0x0
        public static System.Net.NetworkInformation.OperationalStatus Testing;        // 0x0
        public static System.Net.NetworkInformation.OperationalStatus Unknown;        // 0x0
        public static System.Net.NetworkInformation.OperationalStatus Dormant;        // 0x0
        public static System.Net.NetworkInformation.OperationalStatus NotPresent;        // 0x0
        public static System.Net.NetworkInformation.OperationalStatus LowerLayerDown;        // 0x0

    }

    // TypeToken: 0x200020F
    public struct PrefixOrigin
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.PrefixOrigin Other;        // 0x0
        public static System.Net.NetworkInformation.PrefixOrigin Manual;        // 0x0
        public static System.Net.NetworkInformation.PrefixOrigin WellKnown;        // 0x0
        public static System.Net.NetworkInformation.PrefixOrigin Dhcp;        // 0x0
        public static System.Net.NetworkInformation.PrefixOrigin RouterAdvertisement;        // 0x0

    }

    // TypeToken: 0x2000210
    public struct SuffixOrigin
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.SuffixOrigin Other;        // 0x0
        public static System.Net.NetworkInformation.SuffixOrigin Manual;        // 0x0
        public static System.Net.NetworkInformation.SuffixOrigin WellKnown;        // 0x0
        public static System.Net.NetworkInformation.SuffixOrigin OriginDhcp;        // 0x0
        public static System.Net.NetworkInformation.SuffixOrigin LinkLayerAddress;        // 0x0
        public static System.Net.NetworkInformation.SuffixOrigin Random;        // 0x0

    }

    // TypeToken: 0x2000211
    public class UnicastIPAddressInformation : IPAddressInformation
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000212
    public class UnicastIPAddressInformationCollection, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.ObjectModel.Collection<System.Net.NetworkInformation.UnicastIPAddressInformation> addresses;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void CopyTo(System.Net.NetworkInformation.UnicastIPAddressInformation[] array, System.Int32 offset) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void Add(System.Net.NetworkInformation.UnicastIPAddressInformation address) { }
        private System.Void InternalAdd(System.Net.NetworkInformation.UnicastIPAddressInformation address) { }
        private System.Boolean Contains(System.Net.NetworkInformation.UnicastIPAddressInformation address) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.UnicastIPAddressInformation> GetEnumerator() { }
        private System.Boolean Remove(System.Net.NetworkInformation.UnicastIPAddressInformation address) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000213
    public struct NetworkInterfaceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.NetworkInterfaceType Unknown;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Ethernet;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType TokenRing;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Fddi;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType BasicIsdn;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType PrimaryIsdn;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Ppp;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Loopback;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Ethernet3Megabit;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Slip;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Atm;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType GenericModem;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType FastEthernetT;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Isdn;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType FastEthernetFx;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Wireless80211;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType AsymmetricDsl;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType RateAdaptDsl;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType SymmetricDsl;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType VeryHighSpeedDsl;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType IPOverAtm;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType GigabitEthernet;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Tunnel;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType MultiRateSymmetricDsl;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType HighPerformanceSerialBus;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Wman;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Wwanpp;        // 0x0
        public static System.Net.NetworkInformation.NetworkInterfaceType Wwanpp2;        // 0x0

    }

    // TypeToken: 0x2000214
    public struct NetBiosNodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.NetworkInformation.NetBiosNodeType Unknown;        // 0x0
        public static System.Net.NetworkInformation.NetBiosNodeType Broadcast;        // 0x0
        public static System.Net.NetworkInformation.NetBiosNodeType Peer2Peer;        // 0x0
        public static System.Net.NetworkInformation.NetBiosNodeType Mixed;        // 0x0
        public static System.Net.NetworkInformation.NetBiosNodeType Hybrid;        // 0x0

    }

    // TypeToken: 0x2000215
    public class IPGlobalPropertiesFactoryPal
    {
        // Methods
        private System.Net.NetworkInformation.IPGlobalProperties Create() { }

    }

    // TypeToken: 0x2000216
    public class SystemNetworkInterface
    {
        // Fields
        private static readonly System.Net.NetworkInformation.NetworkInterfaceFactory nif;        // 0x0

        // Methods
        private System.Net.NetworkInformation.NetworkInterface[] GetNetworkInterfaces() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000217
    public class NetworkInterfaceFactory
    {
        // Methods
        private System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces() { }
        private System.Net.NetworkInformation.NetworkInterfaceFactory Create() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000218
    public class NetworkInterfaceFactoryPal
    {
        // Methods
        private System.Net.NetworkInformation.NetworkInterfaceFactory Create() { }

    }

    // TypeToken: 0x2000219
    public class Win32IPGlobalProperties : IPGlobalProperties
    {
        // Methods
        private System.String get_DomainName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021A
    public class Win32IPGlobalPropertiesFactoryPal
    {
        // Methods
        private System.Net.NetworkInformation.IPGlobalProperties Create() { }

    }

    // TypeToken: 0x200021B
    public class Win32IPInterfaceProperties2 : IPInterfaceProperties
    {
        // Fields
        private readonly System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr;        // 0x10
        private readonly System.Net.NetworkInformation.Win32_MIB_IFROW mib4;        // 0x118
        private readonly System.Net.NetworkInformation.Win32_MIB_IFROW mib6;        // 0x188

        // Methods
        private System.Void .ctor(System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr, System.Net.NetworkInformation.Win32_MIB_IFROW mib4, System.Net.NetworkInformation.Win32_MIB_IFROW mib6) { }
        private System.Net.NetworkInformation.UnicastIPAddressInformationCollection get_UnicastAddresses() { }
        private System.Net.NetworkInformation.UnicastIPAddressInformationCollection Win32FromUnicast(System.IntPtr ptr) { }

    }

    // TypeToken: 0x200021C
    public class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
    {
        // Fields
        private System.Net.NetworkInformation.Win32_MIB_IFROW info;        // 0x10

        // Methods
        private System.Void .ctor(System.Net.NetworkInformation.Win32_MIB_IFROW info) { }

    }

    // TypeToken: 0x200021D
    public class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
    {
        // Methods
        private System.Int32 GetAdaptersAddresses(System.UInt32 family, System.UInt32 flags, System.IntPtr reserved, System.IntPtr info, System.Int32& size) { }
        private System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() { }
        private System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021E
    public class Win32NetworkInterface2 : NetworkInterface
    {
        // Fields
        private System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr;        // 0x10
        private System.Net.NetworkInformation.Win32_MIB_IFROW mib4;        // 0x118
        private System.Net.NetworkInformation.Win32_MIB_IFROW mib6;        // 0x188
        private System.Net.NetworkInformation.Win32IPv4InterfaceStatistics ip4stats;        // 0x1F8
        private System.Net.NetworkInformation.IPInterfaceProperties ip_if_props;        // 0x200

        // Methods
        private System.Int32 GetIfEntry(System.Net.NetworkInformation.Win32_MIB_IFROW& row) { }
        private System.Void .ctor(System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr) { }
        private System.Net.NetworkInformation.IPInterfaceProperties GetIPProperties() { }
        private System.Net.NetworkInformation.NetworkInterfaceType get_NetworkInterfaceType() { }
        private System.Net.NetworkInformation.OperationalStatus get_OperationalStatus() { }

    }

    // TypeToken: 0x200021F
    public class Win32NetworkInterfaceFactoryPal
    {
        // Methods
        private System.Net.NetworkInformation.NetworkInterfaceFactory Create() { }

    }

    // TypeToken: 0x2000220
    public class Win32NetworkInterface
    {
        // Fields
        private static System.Net.NetworkInformation.Win32_FIXED_INFO fixedInfo;        // 0x0
        private static System.Boolean initialized;        // 0x58

        // Methods
        private System.Int32 GetNetworkParams(System.IntPtr ptr, System.Int32& size) { }
        private System.Net.NetworkInformation.Win32_FIXED_INFO get_FixedInfo() { }

    }

    // TypeToken: 0x2000221
    public struct Win32_FIXED_INFO
    {
        // Fields
        public System.String HostName;        // 0x10
        public System.String DomainName;        // 0x18
        public System.IntPtr CurrentDnsServer;        // 0x20
        public System.Net.NetworkInformation.Win32_IP_ADDR_STRING DnsServerList;        // 0x28
        public System.Net.NetworkInformation.NetBiosNodeType NodeType;        // 0x48
        public System.String ScopeId;        // 0x50
        public System.UInt32 EnableRouting;        // 0x58
        public System.UInt32 EnableProxy;        // 0x5C
        public System.UInt32 EnableDns;        // 0x60

    }

    // TypeToken: 0x2000222
    public struct AlignmentUnion
    {
        // Fields
        public System.UInt64 Alignment;        // 0x10
        public System.Int32 Length;        // 0x10
        public System.Int32 IfIndex;        // 0x14

    }

    // TypeToken: 0x2000223
    public struct Win32_IP_ADAPTER_ADDRESSES
    {
        // Fields
        public System.Net.NetworkInformation.AlignmentUnion Alignment;        // 0x10
        public System.IntPtr Next;        // 0x18
        public System.String AdapterName;        // 0x20
        public System.IntPtr FirstUnicastAddress;        // 0x28
        public System.IntPtr FirstAnycastAddress;        // 0x30
        public System.IntPtr FirstMulticastAddress;        // 0x38
        public System.IntPtr FirstDnsServerAddress;        // 0x40
        public System.String DnsSuffix;        // 0x48
        public System.String Description;        // 0x50
        public System.String FriendlyName;        // 0x58
        public System.Byte[] PhysicalAddress;        // 0x60
        public System.UInt32 PhysicalAddressLength;        // 0x68
        public System.UInt32 Flags;        // 0x6C
        public System.UInt32 Mtu;        // 0x70
        public System.Net.NetworkInformation.NetworkInterfaceType IfType;        // 0x74
        public System.Net.NetworkInformation.OperationalStatus OperStatus;        // 0x78
        public System.Int32 Ipv6IfIndex;        // 0x7C
        public System.UInt32[] ZoneIndices;        // 0x80
        public System.IntPtr FirstPrefix;        // 0x88
        public System.UInt64 TransmitLinkSpeed;        // 0x90
        public System.UInt64 ReceiveLinkSpeed;        // 0x98
        public System.IntPtr FirstWinsServerAddress;        // 0xA0
        public System.IntPtr FirstGatewayAddress;        // 0xA8
        public System.UInt32 Ipv4Metric;        // 0xB0
        public System.UInt32 Ipv6Metric;        // 0xB4
        public System.UInt64 Luid;        // 0xB8
        public System.Net.NetworkInformation.Win32_SOCKET_ADDRESS Dhcpv4Server;        // 0xC0
        public System.UInt32 CompartmentId;        // 0xD0
        public System.UInt64 NetworkGuid;        // 0xD8
        public System.Int32 ConnectionType;        // 0xE0
        public System.Int32 TunnelType;        // 0xE4
        public System.Net.NetworkInformation.Win32_SOCKET_ADDRESS Dhcpv6Server;        // 0xE8
        public System.Byte[] Dhcpv6ClientDuid;        // 0xF8
        public System.UInt64 Dhcpv6ClientDuidLength;        // 0x100
        public System.UInt64 Dhcpv6Iaid;        // 0x108
        public System.IntPtr FirstDnsSuffix;        // 0x110

    }

    // TypeToken: 0x2000224
    public struct Win32_MIB_IFROW
    {
        // Fields
        public System.Char[] Name;        // 0x10
        public System.Int32 Index;        // 0x18
        public System.Net.NetworkInformation.NetworkInterfaceType Type;        // 0x1C
        public System.Int32 Mtu;        // 0x20
        public System.UInt32 Speed;        // 0x24
        public System.Int32 PhysAddrLen;        // 0x28
        public System.Byte[] PhysAddr;        // 0x30
        public System.UInt32 AdminStatus;        // 0x38
        public System.UInt32 OperStatus;        // 0x3C
        public System.UInt32 LastChange;        // 0x40
        public System.Int32 InOctets;        // 0x44
        public System.Int32 InUcastPkts;        // 0x48
        public System.Int32 InNUcastPkts;        // 0x4C
        public System.Int32 InDiscards;        // 0x50
        public System.Int32 InErrors;        // 0x54
        public System.Int32 InUnknownProtos;        // 0x58
        public System.Int32 OutOctets;        // 0x5C
        public System.Int32 OutUcastPkts;        // 0x60
        public System.Int32 OutNUcastPkts;        // 0x64
        public System.Int32 OutDiscards;        // 0x68
        public System.Int32 OutErrors;        // 0x6C
        public System.Int32 OutQLen;        // 0x70
        public System.Int32 DescrLen;        // 0x74
        public System.Byte[] Descr;        // 0x78

    }

    // TypeToken: 0x2000225
    public struct Win32_IP_ADDR_STRING
    {
        // Fields
        public System.IntPtr Next;        // 0x10
        public System.String IpAddress;        // 0x18
        public System.String IpMask;        // 0x20
        public System.UInt32 Context;        // 0x28

    }

    // TypeToken: 0x2000226
    public struct Win32LengthFlagsUnion
    {
        // Fields
        public System.UInt32 Length;        // 0x10
        public System.UInt32 Flags;        // 0x14

    }

    // TypeToken: 0x2000227
    public struct Win32_IP_ADAPTER_UNICAST_ADDRESS
    {
        // Fields
        public System.Net.NetworkInformation.Win32LengthFlagsUnion LengthFlags;        // 0x10
        public System.IntPtr Next;        // 0x18
        public System.Net.NetworkInformation.Win32_SOCKET_ADDRESS Address;        // 0x20
        public System.Net.NetworkInformation.PrefixOrigin PrefixOrigin;        // 0x30
        public System.Net.NetworkInformation.SuffixOrigin SuffixOrigin;        // 0x34
        public System.Net.NetworkInformation.DuplicateAddressDetectionState DadState;        // 0x38
        public System.UInt32 ValidLifetime;        // 0x3C
        public System.UInt32 PreferredLifetime;        // 0x40
        public System.UInt32 LeaseLifetime;        // 0x44
        public System.Byte OnLinkPrefixLength;        // 0x48

    }

    // TypeToken: 0x2000228
    public struct Win32_SOCKADDR
    {
        // Fields
        public System.UInt16 AddressFamily;        // 0x10
        public System.Byte[] AddressData;        // 0x18

    }

    // TypeToken: 0x2000229
    public struct Win32_SOCKET_ADDRESS
    {
        // Fields
        public System.IntPtr Sockaddr;        // 0x10
        public System.Int32 SockaddrLength;        // 0x18

        // Methods
        private System.Net.IPAddress GetIPAddress() { }

    }

    // TypeToken: 0x200022A
    public class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
    {
        // Fields
        private System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS info;        // 0x10
        private System.Net.IPAddress ipv4Mask;        // 0x50

        // Methods
        private System.Void .ctor(System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS info) { }
        private System.Net.IPAddress get_Address() { }
        private System.Net.IPAddress PrefixLengthToSubnetMask(System.Byte prefixLength, System.Net.Sockets.AddressFamily family) { }

    }

    // TypeToken: 0x200022B
    public class UnixNetworkInterfaceFactoryPal
    {
        // Methods
        private System.Net.NetworkInformation.NetworkInterfaceFactory Create() { }

    }

    // TypeToken: 0x200022C
    public class UnixIPGlobalPropertiesFactoryPal
    {
        // Methods
        private System.Net.NetworkInformation.IPGlobalProperties Create() { }

    }

}

namespace System.Net.Security
{

    // TypeToken: 0x2000287
    public class CertificateHelper
    {
        // Methods
        private System.Security.Cryptography.X509Certificates.X509Certificate2 GetEligibleClientCertificate() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 GetEligibleClientCertificate(System.Security.Cryptography.X509Certificates.X509CertificateCollection candidateCerts) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 GetEligibleClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2Collection candidateCerts) { }

    }

    // TypeToken: 0x2000288
    public class SslClientAuthenticationOptions
    {
        // Fields
        private System.Net.Security.EncryptionPolicy _encryptionPolicy;        // 0x10
        private System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;        // 0x14
        private System.Security.Authentication.SslProtocols _enabledSslProtocols;        // 0x18
        private System.Boolean _allowRenegotiation;        // 0x1C
        private System.Net.Security.LocalCertificateSelectionCallback <LocalCertificateSelectionCallback>k__BackingField;        // 0x20
        private System.String <TargetHost>k__BackingField;        // 0x28
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;        // 0x30

        // Methods
        private System.Boolean get_AllowRenegotiation() { }
        private System.Void set_LocalCertificateSelectionCallback(System.Net.Security.LocalCertificateSelectionCallback value) { }
        private System.String get_TargetHost() { }
        private System.Void set_TargetHost(System.String value) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        private System.Void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value) { }
        private System.Void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value) { }
        private System.Security.Authentication.SslProtocols get_EnabledSslProtocols() { }
        private System.Void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000289
    public class AuthenticatedStream : Stream
    {
        // Fields
        private System.IO.Stream _InnerStream;        // 0x28
        private System.Boolean _LeaveStreamOpen;        // 0x30

        // Methods
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen) { }
        private System.IO.Stream get_InnerStream() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_IsAuthenticated() { }

    }

    // TypeToken: 0x200028A
    public struct AuthenticationLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Security.AuthenticationLevel None;        // 0x0
        public static System.Net.Security.AuthenticationLevel MutualAuthRequested;        // 0x0
        public static System.Net.Security.AuthenticationLevel MutualAuthRequired;        // 0x0

    }

    // TypeToken: 0x200028B
    public struct EncryptionPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Security.EncryptionPolicy RequireEncryption;        // 0x0
        public static System.Net.Security.EncryptionPolicy AllowNoEncryption;        // 0x0
        public static System.Net.Security.EncryptionPolicy NoEncryption;        // 0x0

    }

    // TypeToken: 0x200028C
    public class LocalCertificateSelectionCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x200028D
    public class RemoteCertificateValidationCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { }

    }

    // TypeToken: 0x200028E
    public struct SslPolicyErrors
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Security.SslPolicyErrors None;        // 0x0
        public static System.Net.Security.SslPolicyErrors RemoteCertificateNotAvailable;        // 0x0
        public static System.Net.Security.SslPolicyErrors RemoteCertificateNameMismatch;        // 0x0
        public static System.Net.Security.SslPolicyErrors RemoteCertificateChainErrors;        // 0x0

    }

    // TypeToken: 0x200028F
    public class LocalCertSelectionCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x2000290
    public class ServerCertSelectionCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String hostName) { }

    }

    // TypeToken: 0x2000291
    public class SslStream : AuthenticatedStream
    {
        // Fields
        private Mono.Net.Security.MobileTlsProvider provider;        // 0x38
        private Mono.Security.Interface.MonoTlsSettings settings;        // 0x40
        private System.Net.Security.RemoteCertificateValidationCallback validationCallback;        // 0x48
        private System.Net.Security.LocalCertificateSelectionCallback selectionCallback;        // 0x50
        private Mono.Net.Security.MobileAuthenticatedStream impl;        // 0x58
        private System.Boolean explicitSettings;        // 0x60

        // Methods
        private Mono.Net.Security.MobileAuthenticatedStream get_Impl() { }
        private System.String get_InternalTargetHost() { }
        private Mono.Net.Security.MobileTlsProvider GetProvider() { }
        private System.Void .ctor(System.IO.Stream innerStream) { }
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen) { }
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback) { }
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback) { }
        private System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings) { }
        private System.Void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback) { }
        private System.Void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback) { }
        private System.Void AuthenticateAsClient(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation) { }
        private System.IAsyncResult BeginAuthenticateAsClient(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.Void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task AuthenticateAsClientAsync(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation) { }
        private System.Boolean get_IsAuthenticated() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanTimeout() { }
        private System.Boolean get_CanWrite() { }
        private System.Int32 get_ReadTimeout() { }
        private System.Void set_ReadTimeout(System.Int32 value) { }
        private System.Int32 get_WriteTimeout() { }
        private System.Void set_WriteTimeout(System.Int32 value) { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Void Flush() { }
        private System.Void CheckDisposed() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }

    }

}

namespace System.Net.Sockets
{

    // TypeToken: 0x2000237
    public class NetworkStream : Stream
    {
        // Fields
        private readonly System.Net.Sockets.Socket _streamSocket;        // 0x28
        private readonly System.Boolean _ownsSocket;        // 0x30
        private System.Boolean _readable;        // 0x31
        private System.Boolean _writeable;        // 0x32
        private System.Int32 _closeTimeout;        // 0x34
        private System.Boolean _cleanedUp;        // 0x38
        private System.Int32 _currentReadTimeout;        // 0x3C
        private System.Int32 _currentWriteTimeout;        // 0x40

        // Methods
        private System.Void .ctor(System.Net.Sockets.Socket socket) { }
        private System.Void .ctor(System.Net.Sockets.Socket socket, System.Boolean ownsSocket) { }
        private System.Void .ctor(System.Net.Sockets.Socket socket, System.IO.FileAccess access, System.Boolean ownsSocket) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_CanTimeout() { }
        private System.Int32 get_ReadTimeout() { }
        private System.Void set_ReadTimeout(System.Int32 value) { }
        private System.Int32 get_WriteTimeout() { }
        private System.Void set_WriteTimeout(System.Int32 value) { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Int32 Read(System.Span<System.Byte> destination) { }
        private System.Int32 ReadByte() { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Write(System.ReadOnlySpan<System.Byte> source) { }
        private System.Void WriteByte(System.Byte value) { }
        private System.Void Close(System.Int32 timeout) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Finalize() { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Flush() { }
        private System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, System.Int32 timeout, System.Boolean silent) { }
        private System.Net.Sockets.Socket get_InternalSocket() { }

    }

    // TypeToken: 0x2000238
    public class Socket, IDisposable
    {
        // Fields
        private static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> AcceptCompletedHandler;        // 0x0
        private static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> ReceiveCompletedHandler;        // 0x8
        private static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> SendCompletedHandler;        // 0x10
        private static readonly System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> s_rentedSocketSentinel;        // 0x18
        private static readonly System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;        // 0x20
        private static readonly System.Threading.Tasks.Task<System.Int32> s_zeroTask;        // 0x28
        private System.Net.Sockets.Socket.CachedEventArgs _cachedTaskEventArgs;        // 0x10
        private static System.Object s_InternalSyncObject;        // 0x30
        private static System.Boolean s_SupportsIPv4;        // 0x38
        private static System.Boolean s_SupportsIPv6;        // 0x39
        private static System.Boolean s_OSSupportsIPv6;        // 0x3A
        private static System.Boolean s_Initialized;        // 0x3B
        private static System.Boolean s_LoggingEnabled;        // 0x3C
        private System.Boolean is_closed;        // 0x18
        private System.Boolean is_listening;        // 0x19
        private System.Int32 linger_timeout;        // 0x1C
        private System.Net.Sockets.AddressFamily addressFamily;        // 0x20
        private System.Net.Sockets.SocketType socketType;        // 0x24
        private System.Net.Sockets.ProtocolType protocolType;        // 0x28
        private System.Net.Sockets.SafeSocketHandle m_Handle;        // 0x30
        private System.Net.EndPoint seed_endpoint;        // 0x38
        private System.Threading.SemaphoreSlim ReadSem;        // 0x40
        private System.Threading.SemaphoreSlim WriteSem;        // 0x48
        private System.Boolean is_blocking;        // 0x50
        private System.Boolean is_bound;        // 0x51
        private System.Boolean is_connected;        // 0x52
        private System.Int32 m_IntCleanedUp;        // 0x54
        private System.Boolean connect_in_progress;        // 0x58
        private static System.AsyncCallback AcceptAsyncCallback;        // 0x40
        private static System.IOAsyncCallback BeginAcceptCallback;        // 0x48
        private static System.IOAsyncCallback BeginAcceptReceiveCallback;        // 0x50
        private static System.AsyncCallback ConnectAsyncCallback;        // 0x58
        private static System.IOAsyncCallback BeginConnectCallback;        // 0x60
        private static System.AsyncCallback DisconnectAsyncCallback;        // 0x68
        private static System.IOAsyncCallback BeginDisconnectCallback;        // 0x70
        private static System.AsyncCallback ReceiveAsyncCallback;        // 0x78
        private static System.IOAsyncCallback BeginReceiveCallback;        // 0x80
        private static System.IOAsyncCallback BeginReceiveGenericCallback;        // 0x88
        private static System.AsyncCallback ReceiveFromAsyncCallback;        // 0x90
        private static System.IOAsyncCallback BeginReceiveFromCallback;        // 0x98
        private static System.AsyncCallback SendAsyncCallback;        // 0xA0
        private static System.IOAsyncCallback BeginSendGenericCallback;        // 0xA8
        private static System.AsyncCallback SendToAsyncCallback;        // 0xB0

        // Methods
        private System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, System.Int32 port) { }
        private System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Boolean fromNetworkStream, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { }
        private System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { }
        private System.Void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }
        private System.Void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, System.Boolean isReceive) { }
        private System.Exception GetException(System.Net.Sockets.SocketError error, System.Boolean wrapExceptionsInIOExceptions) { }
        private System.Void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, System.Boolean isReceive) { }
        private System.Void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }
        private System.Void .ctor(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType) { }
        private System.Boolean get_OSSupportsIPv4() { }
        private System.Boolean get_OSSupportsIPv6() { }
        private System.IntPtr get_Handle() { }
        private System.Net.Sockets.AddressFamily get_AddressFamily() { }
        private System.Net.Sockets.SocketType get_SocketType() { }
        private System.Net.Sockets.ProtocolType get_ProtocolType() { }
        private System.Boolean get_ExclusiveAddressUse() { }
        private System.Void set_ExclusiveAddressUse(System.Boolean value) { }
        private System.Void set_DontFragment(System.Boolean value) { }
        private System.Boolean get_DualMode() { }
        private System.Void set_DualMode(System.Boolean value) { }
        private System.Boolean get_IsDualMode() { }
        private System.Boolean CanTryAddressFamily(System.Net.Sockets.AddressFamily family) { }
        private System.Void Connect(System.Net.IPAddress[] addresses, System.Int32 port) { }
        private System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { }
        private System.Int32 Send(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags) { }
        private System.Int32 Receive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags) { }
        private System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { }
        private System.Int32 IOControl(System.Net.Sockets.IOControlCode ioControlCode, System.Byte[] optionInValue, System.Byte[] optionOutValue) { }
        private System.Void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level) { }
        private System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.IAsyncResult BeginSend(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndSend(System.IAsyncResult asyncResult) { }
        private System.IAsyncResult BeginReceive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndReceive(System.IAsyncResult asyncResult) { }
        private System.Object get_InternalSyncObject() { }
        private System.Boolean get_CleanedUp() { }
        private System.Void InitializeSockets() { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void InternalShutdown(System.Net.Sockets.SocketShutdown how) { }
        private System.Void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Int32 optionValue, System.Boolean silent) { }
        private System.Void .ctor(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle) { }
        private System.Void SocketDefaults() { }
        private System.IntPtr Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Int32& error) { }
        private System.Int32 get_Available() { }
        private System.Int32 Available_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32& error) { }
        private System.Int32 Available_icall(System.IntPtr socket, System.Int32& error) { }
        private System.Boolean get_IsBound() { }
        private System.Net.EndPoint get_LocalEndPoint() { }
        private System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 family, System.Int32& error) { }
        private System.Net.SocketAddress LocalEndPoint_icall(System.IntPtr socket, System.Int32 family, System.Int32& error) { }
        private System.Boolean get_Blocking() { }
        private System.Void set_Blocking(System.Boolean value) { }
        private System.Void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Boolean block, System.Int32& error) { }
        private System.Void Blocking_icall(System.IntPtr socket, System.Boolean block, System.Int32& error) { }
        private System.Boolean get_Connected() { }
        private System.Void set_NoDelay(System.Boolean value) { }
        private System.Net.EndPoint get_RemoteEndPoint() { }
        private System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 family, System.Int32& error) { }
        private System.Net.SocketAddress RemoteEndPoint_icall(System.IntPtr socket, System.Int32 family, System.Int32& error) { }
        private System.Boolean Poll(System.Int32 microSeconds, System.Net.Sockets.SelectMode mode) { }
        private System.Boolean Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, System.Int32 timeout, System.Int32& error) { }
        private System.Boolean Poll_icall(System.IntPtr socket, System.Net.Sockets.SelectMode mode, System.Int32 timeout, System.Int32& error) { }
        private System.Net.Sockets.Socket Accept() { }
        private System.Void Accept(System.Net.Sockets.Socket acceptSocket) { }
        private System.IAsyncResult BeginAccept(System.AsyncCallback callback, System.Object state) { }
        private System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult) { }
        private System.Net.Sockets.Socket EndAccept(System.Byte[]& buffer, System.Int32& bytesTransferred, System.IAsyncResult asyncResult) { }
        private System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32& error, System.Boolean blocking) { }
        private System.IntPtr Accept_icall(System.IntPtr sock, System.Int32& error, System.Boolean blocking) { }
        private System.Void Bind(System.Net.EndPoint localEP) { }
        private System.Void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, System.Int32& error) { }
        private System.Void Bind_icall(System.IntPtr sock, System.Net.SocketAddress sa, System.Int32& error) { }
        private System.Void Listen(System.Int32 backlog) { }
        private System.Void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 backlog, System.Int32& error) { }
        private System.Void Listen_icall(System.IntPtr sock, System.Int32 backlog, System.Int32& error) { }
        private System.Void Connect(System.Net.IPAddress address, System.Int32 port) { }
        private System.Void Connect(System.Net.EndPoint remoteEP) { }
        private System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback callback, System.Object state) { }
        private System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, System.Object state) { }
        private System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.Boolean BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares) { }
        private System.Boolean BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares) { }
        private System.Void EndConnect(System.IAsyncResult asyncResult) { }
        private System.Void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, System.Int32& error, System.Boolean blocking) { }
        private System.Void Connect_icall(System.IntPtr sock, System.Net.SocketAddress sa, System.Int32& error, System.Boolean blocking) { }
        private System.Void Disconnect(System.Boolean reuseSocket) { }
        private System.Void EndDisconnect(System.IAsyncResult asyncResult) { }
        private System.Void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Boolean reuse, System.Int32& error) { }
        private System.Void Disconnect_icall(System.IntPtr sock, System.Boolean reuse, System.Int32& error) { }
        private System.Int32 Receive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Receive(System.Memory<System.Byte> buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Receive(System.Span<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Send(System.ReadOnlySpan<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Boolean ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e) { }
        private System.IAsyncResult BeginReceive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndReceive(System.IAsyncResult asyncResult, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Receive_array_icall(System.IntPtr sock, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Receive_icall(System.IntPtr sock, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 ReceiveFrom(System.Memory<System.Byte> buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint& remoteEP, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares) { }
        private System.Int32 ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Net.SocketAddress& sockaddr, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 ReceiveFrom_icall(System.IntPtr sock, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Net.SocketAddress& sockaddr, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Send(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode) { }
        private System.Boolean SendAsync(System.Net.Sockets.SocketAsyncEventArgs e) { }
        private System.IAsyncResult BeginSend(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode, System.AsyncCallback callback, System.Object state) { }
        private System.Void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, System.Int32 sent_so_far) { }
        private System.Int32 EndSend(System.IAsyncResult asyncResult, System.Net.Sockets.SocketError& errorCode) { }
        private System.Int32 Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Send_array_icall(System.IntPtr sock, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 Send_icall(System.IntPtr sock, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking) { }
        private System.Int32 EndSendTo(System.IAsyncResult asyncResult) { }
        private System.Object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName) { }
        private System.Void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object& obj_val, System.Int32& error) { }
        private System.Void GetSocketOption_obj_icall(System.IntPtr socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object& obj_val, System.Int32& error) { }
        private System.Void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Object optionValue) { }
        private System.Void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Int32 optionValue) { }
        private System.Void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object obj_val, System.Byte[] byte_val, System.Int32 int_val, System.Int32& error) { }
        private System.Void SetSocketOption_icall(System.IntPtr socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object obj_val, System.Byte[] byte_val, System.Int32 int_val, System.Int32& error) { }
        private System.Int32 IOControl(System.Int32 ioControlCode, System.Byte[] optionInValue, System.Byte[] optionOutValue) { }
        private System.Int32 IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 ioctl_code, System.Byte[] input, System.Byte[] output, System.Int32& error) { }
        private System.Int32 IOControl_icall(System.IntPtr sock, System.Int32 ioctl_code, System.Byte[] input, System.Byte[] output, System.Int32& error) { }
        private System.Void Close() { }
        private System.Void Close(System.Int32 timeout) { }
        private System.Void Close_icall(System.IntPtr socket, System.Int32& error) { }
        private System.Void Shutdown(System.Net.Sockets.SocketShutdown how) { }
        private System.Void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, System.Int32& error) { }
        private System.Void Shutdown_icall(System.IntPtr socket, System.Net.Sockets.SocketShutdown how, System.Int32& error) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Linger(System.IntPtr handle) { }
        private System.Void ThrowIfDisposedAndClosed() { }
        private System.Void ThrowIfBufferNull(System.Byte[] buffer) { }
        private System.Void ThrowIfBufferOutOfRange(System.Byte[] buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void ThrowIfUdp() { }
        private System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, System.String methodName, System.String argName) { }
        private System.Void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, System.IntPtr handle, System.IOSelectorJob job) { }
        private System.Void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, System.Object state, System.Net.Sockets.SocketOperation operation) { }
        private System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op) { }
        private System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input) { }
        private System.Void cancel_blocking_socket_operation(System.Threading.Thread thread) { }
        private System.Int32 get_FamilyHint() { }
        private System.Boolean IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface) { }
        private System.Boolean IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000243
    public class SocketException : Win32Exception
    {
        // Fields
        private System.Net.EndPoint m_EndPoint;        // 0x98

        // Methods
        private System.Int32 WSAGetLastError_icall() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 error, System.String message) { }
        private System.Void .ctor(System.Int32 errorCode) { }
        private System.Void .ctor(System.Net.Sockets.SocketError socketError) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.String get_Message() { }
        private System.Net.Sockets.SocketError get_SocketErrorCode() { }

    }

    // TypeToken: 0x2000244
    public struct AddressFamily
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.AddressFamily Unknown;        // 0x0
        public static System.Net.Sockets.AddressFamily Unspecified;        // 0x0
        public static System.Net.Sockets.AddressFamily Unix;        // 0x0
        public static System.Net.Sockets.AddressFamily InterNetwork;        // 0x0
        public static System.Net.Sockets.AddressFamily ImpLink;        // 0x0
        public static System.Net.Sockets.AddressFamily Pup;        // 0x0
        public static System.Net.Sockets.AddressFamily Chaos;        // 0x0
        public static System.Net.Sockets.AddressFamily NS;        // 0x0
        public static System.Net.Sockets.AddressFamily Ipx;        // 0x0
        public static System.Net.Sockets.AddressFamily Iso;        // 0x0
        public static System.Net.Sockets.AddressFamily Osi;        // 0x0
        public static System.Net.Sockets.AddressFamily Ecma;        // 0x0
        public static System.Net.Sockets.AddressFamily DataKit;        // 0x0
        public static System.Net.Sockets.AddressFamily Ccitt;        // 0x0
        public static System.Net.Sockets.AddressFamily Sna;        // 0x0
        public static System.Net.Sockets.AddressFamily DecNet;        // 0x0
        public static System.Net.Sockets.AddressFamily DataLink;        // 0x0
        public static System.Net.Sockets.AddressFamily Lat;        // 0x0
        public static System.Net.Sockets.AddressFamily HyperChannel;        // 0x0
        public static System.Net.Sockets.AddressFamily AppleTalk;        // 0x0
        public static System.Net.Sockets.AddressFamily NetBios;        // 0x0
        public static System.Net.Sockets.AddressFamily VoiceView;        // 0x0
        public static System.Net.Sockets.AddressFamily FireFox;        // 0x0
        public static System.Net.Sockets.AddressFamily Banyan;        // 0x0
        public static System.Net.Sockets.AddressFamily Atm;        // 0x0
        public static System.Net.Sockets.AddressFamily InterNetworkV6;        // 0x0
        public static System.Net.Sockets.AddressFamily Cluster;        // 0x0
        public static System.Net.Sockets.AddressFamily Ieee12844;        // 0x0
        public static System.Net.Sockets.AddressFamily Irda;        // 0x0
        public static System.Net.Sockets.AddressFamily NetworkDesigners;        // 0x0
        public static System.Net.Sockets.AddressFamily Max;        // 0x0

    }

    // TypeToken: 0x2000245
    public struct IOControlCode
    {
        // Fields
        public System.Int64 value__;        // 0x10
        public static System.Net.Sockets.IOControlCode AsyncIO;        // 0x0
        public static System.Net.Sockets.IOControlCode NonBlockingIO;        // 0x0
        public static System.Net.Sockets.IOControlCode DataToRead;        // 0x0
        public static System.Net.Sockets.IOControlCode OobDataRead;        // 0x0
        public static System.Net.Sockets.IOControlCode AssociateHandle;        // 0x0
        public static System.Net.Sockets.IOControlCode EnableCircularQueuing;        // 0x0
        public static System.Net.Sockets.IOControlCode Flush;        // 0x0
        public static System.Net.Sockets.IOControlCode GetBroadcastAddress;        // 0x0
        public static System.Net.Sockets.IOControlCode GetExtensionFunctionPointer;        // 0x0
        public static System.Net.Sockets.IOControlCode GetQos;        // 0x0
        public static System.Net.Sockets.IOControlCode GetGroupQos;        // 0x0
        public static System.Net.Sockets.IOControlCode MultipointLoopback;        // 0x0
        public static System.Net.Sockets.IOControlCode MulticastScope;        // 0x0
        public static System.Net.Sockets.IOControlCode SetQos;        // 0x0
        public static System.Net.Sockets.IOControlCode SetGroupQos;        // 0x0
        public static System.Net.Sockets.IOControlCode TranslateHandle;        // 0x0
        public static System.Net.Sockets.IOControlCode RoutingInterfaceQuery;        // 0x0
        public static System.Net.Sockets.IOControlCode RoutingInterfaceChange;        // 0x0
        public static System.Net.Sockets.IOControlCode AddressListQuery;        // 0x0
        public static System.Net.Sockets.IOControlCode AddressListChange;        // 0x0
        public static System.Net.Sockets.IOControlCode QueryTargetPnpHandle;        // 0x0
        public static System.Net.Sockets.IOControlCode NamespaceChange;        // 0x0
        public static System.Net.Sockets.IOControlCode AddressListSort;        // 0x0
        public static System.Net.Sockets.IOControlCode ReceiveAll;        // 0x0
        public static System.Net.Sockets.IOControlCode ReceiveAllMulticast;        // 0x0
        public static System.Net.Sockets.IOControlCode ReceiveAllIgmpMulticast;        // 0x0
        public static System.Net.Sockets.IOControlCode KeepAliveValues;        // 0x0
        public static System.Net.Sockets.IOControlCode AbsorbRouterAlert;        // 0x0
        public static System.Net.Sockets.IOControlCode UnicastInterface;        // 0x0
        public static System.Net.Sockets.IOControlCode LimitBroadcasts;        // 0x0
        public static System.Net.Sockets.IOControlCode BindToInterface;        // 0x0
        public static System.Net.Sockets.IOControlCode MulticastInterface;        // 0x0
        public static System.Net.Sockets.IOControlCode AddMulticastGroupOnInterface;        // 0x0
        public static System.Net.Sockets.IOControlCode DeleteMulticastGroupFromInterface;        // 0x0

    }

    // TypeToken: 0x2000246
    public struct IPProtectionLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.IPProtectionLevel Unspecified;        // 0x0
        public static System.Net.Sockets.IPProtectionLevel Unrestricted;        // 0x0
        public static System.Net.Sockets.IPProtectionLevel EdgeRestricted;        // 0x0
        public static System.Net.Sockets.IPProtectionLevel Restricted;        // 0x0

    }

    // TypeToken: 0x2000247
    public class LingerOption
    {
        // Fields
        private System.Boolean enabled;        // 0x10
        private System.Int32 lingerTime;        // 0x14

        // Methods
        private System.Void .ctor(System.Boolean enable, System.Int32 seconds) { }
        private System.Void set_Enabled(System.Boolean value) { }
        private System.Void set_LingerTime(System.Int32 value) { }

    }

    // TypeToken: 0x2000248
    public class MulticastOption
    {
    }

    // TypeToken: 0x2000249
    public class IPv6MulticastOption
    {
    }

    // TypeToken: 0x200024A
    public struct ProtocolType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.ProtocolType IP;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv6HopByHopOptions;        // 0x0
        public static System.Net.Sockets.ProtocolType Icmp;        // 0x0
        public static System.Net.Sockets.ProtocolType Igmp;        // 0x0
        public static System.Net.Sockets.ProtocolType Ggp;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv4;        // 0x0
        public static System.Net.Sockets.ProtocolType Tcp;        // 0x0
        public static System.Net.Sockets.ProtocolType Pup;        // 0x0
        public static System.Net.Sockets.ProtocolType Udp;        // 0x0
        public static System.Net.Sockets.ProtocolType Idp;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv6;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv6RoutingHeader;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv6FragmentHeader;        // 0x0
        public static System.Net.Sockets.ProtocolType IPSecEncapsulatingSecurityPayload;        // 0x0
        public static System.Net.Sockets.ProtocolType IPSecAuthenticationHeader;        // 0x0
        public static System.Net.Sockets.ProtocolType IcmpV6;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv6NoNextHeader;        // 0x0
        public static System.Net.Sockets.ProtocolType IPv6DestinationOptions;        // 0x0
        public static System.Net.Sockets.ProtocolType ND;        // 0x0
        public static System.Net.Sockets.ProtocolType Raw;        // 0x0
        public static System.Net.Sockets.ProtocolType Unspecified;        // 0x0
        public static System.Net.Sockets.ProtocolType Ipx;        // 0x0
        public static System.Net.Sockets.ProtocolType Spx;        // 0x0
        public static System.Net.Sockets.ProtocolType SpxII;        // 0x0
        public static System.Net.Sockets.ProtocolType Unknown;        // 0x0

    }

    // TypeToken: 0x200024B
    public struct SelectMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SelectMode SelectRead;        // 0x0
        public static System.Net.Sockets.SelectMode SelectWrite;        // 0x0
        public static System.Net.Sockets.SelectMode SelectError;        // 0x0

    }

    // TypeToken: 0x200024C
    public struct SocketAsyncOperation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketAsyncOperation None;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation Accept;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation Connect;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation Disconnect;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation Receive;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation ReceiveFrom;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation ReceiveMessageFrom;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation Send;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation SendPackets;        // 0x0
        public static System.Net.Sockets.SocketAsyncOperation SendTo;        // 0x0

    }

    // TypeToken: 0x200024D
    public struct SocketError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketError Success;        // 0x0
        public static System.Net.Sockets.SocketError SocketError;        // 0x0
        public static System.Net.Sockets.SocketError Interrupted;        // 0x0
        public static System.Net.Sockets.SocketError AccessDenied;        // 0x0
        public static System.Net.Sockets.SocketError Fault;        // 0x0
        public static System.Net.Sockets.SocketError InvalidArgument;        // 0x0
        public static System.Net.Sockets.SocketError TooManyOpenSockets;        // 0x0
        public static System.Net.Sockets.SocketError WouldBlock;        // 0x0
        public static System.Net.Sockets.SocketError InProgress;        // 0x0
        public static System.Net.Sockets.SocketError AlreadyInProgress;        // 0x0
        public static System.Net.Sockets.SocketError NotSocket;        // 0x0
        public static System.Net.Sockets.SocketError DestinationAddressRequired;        // 0x0
        public static System.Net.Sockets.SocketError MessageSize;        // 0x0
        public static System.Net.Sockets.SocketError ProtocolType;        // 0x0
        public static System.Net.Sockets.SocketError ProtocolOption;        // 0x0
        public static System.Net.Sockets.SocketError ProtocolNotSupported;        // 0x0
        public static System.Net.Sockets.SocketError SocketNotSupported;        // 0x0
        public static System.Net.Sockets.SocketError OperationNotSupported;        // 0x0
        public static System.Net.Sockets.SocketError ProtocolFamilyNotSupported;        // 0x0
        public static System.Net.Sockets.SocketError AddressFamilyNotSupported;        // 0x0
        public static System.Net.Sockets.SocketError AddressAlreadyInUse;        // 0x0
        public static System.Net.Sockets.SocketError AddressNotAvailable;        // 0x0
        public static System.Net.Sockets.SocketError NetworkDown;        // 0x0
        public static System.Net.Sockets.SocketError NetworkUnreachable;        // 0x0
        public static System.Net.Sockets.SocketError NetworkReset;        // 0x0
        public static System.Net.Sockets.SocketError ConnectionAborted;        // 0x0
        public static System.Net.Sockets.SocketError ConnectionReset;        // 0x0
        public static System.Net.Sockets.SocketError NoBufferSpaceAvailable;        // 0x0
        public static System.Net.Sockets.SocketError IsConnected;        // 0x0
        public static System.Net.Sockets.SocketError NotConnected;        // 0x0
        public static System.Net.Sockets.SocketError Shutdown;        // 0x0
        public static System.Net.Sockets.SocketError TimedOut;        // 0x0
        public static System.Net.Sockets.SocketError ConnectionRefused;        // 0x0
        public static System.Net.Sockets.SocketError HostDown;        // 0x0
        public static System.Net.Sockets.SocketError HostUnreachable;        // 0x0
        public static System.Net.Sockets.SocketError ProcessLimit;        // 0x0
        public static System.Net.Sockets.SocketError SystemNotReady;        // 0x0
        public static System.Net.Sockets.SocketError VersionNotSupported;        // 0x0
        public static System.Net.Sockets.SocketError NotInitialized;        // 0x0
        public static System.Net.Sockets.SocketError Disconnecting;        // 0x0
        public static System.Net.Sockets.SocketError TypeNotFound;        // 0x0
        public static System.Net.Sockets.SocketError HostNotFound;        // 0x0
        public static System.Net.Sockets.SocketError TryAgain;        // 0x0
        public static System.Net.Sockets.SocketError NoRecovery;        // 0x0
        public static System.Net.Sockets.SocketError NoData;        // 0x0
        public static System.Net.Sockets.SocketError IOPending;        // 0x0
        public static System.Net.Sockets.SocketError OperationAborted;        // 0x0

    }

    // TypeToken: 0x200024E
    public struct SocketFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketFlags None;        // 0x0
        public static System.Net.Sockets.SocketFlags OutOfBand;        // 0x0
        public static System.Net.Sockets.SocketFlags Peek;        // 0x0
        public static System.Net.Sockets.SocketFlags DontRoute;        // 0x0
        public static System.Net.Sockets.SocketFlags MaxIOVectorLength;        // 0x0
        public static System.Net.Sockets.SocketFlags Truncated;        // 0x0
        public static System.Net.Sockets.SocketFlags ControlDataTruncated;        // 0x0
        public static System.Net.Sockets.SocketFlags Broadcast;        // 0x0
        public static System.Net.Sockets.SocketFlags Multicast;        // 0x0
        public static System.Net.Sockets.SocketFlags Partial;        // 0x0

    }

    // TypeToken: 0x200024F
    public struct SocketOptionLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketOptionLevel Socket;        // 0x0
        public static System.Net.Sockets.SocketOptionLevel IP;        // 0x0
        public static System.Net.Sockets.SocketOptionLevel IPv6;        // 0x0
        public static System.Net.Sockets.SocketOptionLevel Tcp;        // 0x0
        public static System.Net.Sockets.SocketOptionLevel Udp;        // 0x0

    }

    // TypeToken: 0x2000250
    public struct SocketOptionName
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketOptionName Debug;        // 0x0
        public static System.Net.Sockets.SocketOptionName AcceptConnection;        // 0x0
        public static System.Net.Sockets.SocketOptionName ReuseAddress;        // 0x0
        public static System.Net.Sockets.SocketOptionName KeepAlive;        // 0x0
        public static System.Net.Sockets.SocketOptionName DontRoute;        // 0x0
        public static System.Net.Sockets.SocketOptionName Broadcast;        // 0x0
        public static System.Net.Sockets.SocketOptionName UseLoopback;        // 0x0
        public static System.Net.Sockets.SocketOptionName Linger;        // 0x0
        public static System.Net.Sockets.SocketOptionName OutOfBandInline;        // 0x0
        public static System.Net.Sockets.SocketOptionName DontLinger;        // 0x0
        public static System.Net.Sockets.SocketOptionName ExclusiveAddressUse;        // 0x0
        public static System.Net.Sockets.SocketOptionName SendBuffer;        // 0x0
        public static System.Net.Sockets.SocketOptionName ReceiveBuffer;        // 0x0
        public static System.Net.Sockets.SocketOptionName SendLowWater;        // 0x0
        public static System.Net.Sockets.SocketOptionName ReceiveLowWater;        // 0x0
        public static System.Net.Sockets.SocketOptionName SendTimeout;        // 0x0
        public static System.Net.Sockets.SocketOptionName ReceiveTimeout;        // 0x0
        public static System.Net.Sockets.SocketOptionName Error;        // 0x0
        public static System.Net.Sockets.SocketOptionName Type;        // 0x0
        public static System.Net.Sockets.SocketOptionName ReuseUnicastPort;        // 0x0
        public static System.Net.Sockets.SocketOptionName MaxConnections;        // 0x0
        public static System.Net.Sockets.SocketOptionName IPOptions;        // 0x0
        public static System.Net.Sockets.SocketOptionName HeaderIncluded;        // 0x0
        public static System.Net.Sockets.SocketOptionName TypeOfService;        // 0x0
        public static System.Net.Sockets.SocketOptionName IpTimeToLive;        // 0x0
        public static System.Net.Sockets.SocketOptionName MulticastInterface;        // 0x0
        public static System.Net.Sockets.SocketOptionName MulticastTimeToLive;        // 0x0
        public static System.Net.Sockets.SocketOptionName MulticastLoopback;        // 0x0
        public static System.Net.Sockets.SocketOptionName AddMembership;        // 0x0
        public static System.Net.Sockets.SocketOptionName DropMembership;        // 0x0
        public static System.Net.Sockets.SocketOptionName DontFragment;        // 0x0
        public static System.Net.Sockets.SocketOptionName AddSourceMembership;        // 0x0
        public static System.Net.Sockets.SocketOptionName DropSourceMembership;        // 0x0
        public static System.Net.Sockets.SocketOptionName BlockSource;        // 0x0
        public static System.Net.Sockets.SocketOptionName UnblockSource;        // 0x0
        public static System.Net.Sockets.SocketOptionName PacketInformation;        // 0x0
        public static System.Net.Sockets.SocketOptionName HopLimit;        // 0x0
        public static System.Net.Sockets.SocketOptionName IPProtectionLevel;        // 0x0
        public static System.Net.Sockets.SocketOptionName IPv6Only;        // 0x0
        public static System.Net.Sockets.SocketOptionName NoDelay;        // 0x0
        public static System.Net.Sockets.SocketOptionName BsdUrgent;        // 0x0
        public static System.Net.Sockets.SocketOptionName Expedited;        // 0x0
        public static System.Net.Sockets.SocketOptionName NoChecksum;        // 0x0
        public static System.Net.Sockets.SocketOptionName ChecksumCoverage;        // 0x0
        public static System.Net.Sockets.SocketOptionName UpdateAcceptContext;        // 0x0
        public static System.Net.Sockets.SocketOptionName UpdateConnectContext;        // 0x0

    }

    // TypeToken: 0x2000251
    public struct SocketShutdown
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketShutdown Receive;        // 0x0
        public static System.Net.Sockets.SocketShutdown Send;        // 0x0
        public static System.Net.Sockets.SocketShutdown Both;        // 0x0

    }

    // TypeToken: 0x2000252
    public struct SocketType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketType Stream;        // 0x0
        public static System.Net.Sockets.SocketType Dgram;        // 0x0
        public static System.Net.Sockets.SocketType Raw;        // 0x0
        public static System.Net.Sockets.SocketType Rdm;        // 0x0
        public static System.Net.Sockets.SocketType Seqpacket;        // 0x0
        public static System.Net.Sockets.SocketType Unknown;        // 0x0

    }

    // TypeToken: 0x2000253
    public class TcpClient, IDisposable
    {
        // Fields
        private System.Net.Sockets.Socket m_ClientSocket;        // 0x10
        private System.Boolean m_Active;        // 0x18
        private System.Net.Sockets.NetworkStream m_DataStream;        // 0x20
        private System.Net.Sockets.AddressFamily m_Family;        // 0x28
        private System.Boolean m_CleanedUp;        // 0x2C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.Sockets.AddressFamily family) { }
        private System.Net.Sockets.Socket get_Client() { }
        private System.Void set_Client(System.Net.Sockets.Socket value) { }
        private System.Boolean get_Connected() { }
        private System.Void Connect(System.String hostname, System.Int32 port) { }
        private System.Void Connect(System.Net.IPEndPoint remoteEP) { }
        private System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.Void EndConnect(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task ConnectAsync(System.String host, System.Int32 port) { }
        private System.Net.Sockets.NetworkStream GetStream() { }
        private System.Void Close() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void set_ReceiveTimeout(System.Int32 value) { }
        private System.Void set_SendTimeout(System.Int32 value) { }
        private System.Void set_NoDelay(System.Boolean value) { }
        private System.Void initialize() { }

    }

    // TypeToken: 0x2000254
    public class SafeSocketHandle : SafeHandleMinusOneIsInvalid
    {
        // Fields
        private System.Collections.Generic.List<System.Threading.Thread> blocking_threads;        // 0x20
        private System.Collections.Generic.Dictionary<System.Threading.Thread,System.Diagnostics.StackTrace> threads_stacktraces;        // 0x28
        private System.Boolean in_cleanup;        // 0x30
        private static System.Boolean THROW_ON_ABORT_RETRIES;        // 0x0

        // Methods
        private System.Void .ctor(System.IntPtr preexistingHandle, System.Boolean ownsHandle) { }
        private System.Boolean ReleaseHandle() { }
        private System.Void RegisterForBlockingSyscall() { }
        private System.Void UnRegisterForBlockingSyscall() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000255
    public class SocketAsyncEventArgs : EventArgs, IDisposable
    {
        // Fields
        private System.Boolean disposed;        // 0x10
        private System.Int32 in_progress;        // 0x14
        private System.Net.EndPoint remote_ep;        // 0x18
        private System.Net.Sockets.Socket current_socket;        // 0x20
        private System.Net.Sockets.SocketAsyncResult socket_async_result;        // 0x28
        private System.Net.Sockets.Socket <AcceptSocket>k__BackingField;        // 0x30
        private System.Int32 <BytesTransferred>k__BackingField;        // 0x38
        private System.Net.Sockets.SocketAsyncOperation <LastOperation>k__BackingField;        // 0x3C
        private System.Net.Sockets.SocketError <SocketError>k__BackingField;        // 0x40
        private System.Net.Sockets.SocketFlags <SocketFlags>k__BackingField;        // 0x44
        private System.Object <UserToken>k__BackingField;        // 0x48
        private System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed;        // 0x50
        private System.Memory<System.Byte> _buffer;        // 0x58
        private System.Int32 _offset;        // 0x68
        private System.Int32 _count;        // 0x6C
        private System.Boolean _bufferIsExplicitArray;        // 0x70
        private System.Collections.Generic.IList<System.ArraySegment<System.Byte>> _bufferList;        // 0x78

        // Methods
        private System.Net.Sockets.Socket get_AcceptSocket() { }
        private System.Void set_AcceptSocket(System.Net.Sockets.Socket value) { }
        private System.Int32 get_BytesTransferred() { }
        private System.Void set_BytesTransferred(System.Int32 value) { }
        private System.Void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value) { }
        private System.Void set_RemoteEndPoint(System.Net.EndPoint value) { }
        private System.Net.Sockets.SocketError get_SocketError() { }
        private System.Void set_SocketError(System.Net.Sockets.SocketError value) { }
        private System.Void set_SocketFlags(System.Net.Sockets.SocketFlags value) { }
        private System.Object get_UserToken() { }
        private System.Void set_UserToken(System.Object value) { }
        private System.Void .ctor(System.Boolean flowExecutionContext) { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Void SetBytesTransferred(System.Int32 value) { }
        private System.Net.Sockets.Socket get_CurrentSocket() { }
        private System.Void SetCurrentSocket(System.Net.Sockets.Socket socket) { }
        private System.Void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op) { }
        private System.Void Complete_internal() { }
        private System.Void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e) { }
        private System.Memory<System.Byte> get_MemoryBuffer() { }
        private System.Int32 get_Offset() { }
        private System.Int32 get_Count() { }
        private System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList() { }
        private System.Void SetBuffer(System.Memory<System.Byte> buffer) { }

    }

    // TypeToken: 0x2000256
    public class SocketAsyncResult : IOAsyncResult
    {
        // Fields
        public System.Net.Sockets.Socket socket;        // 0x30
        public System.Net.Sockets.SocketOperation operation;        // 0x38
        private System.Exception DelayedException;        // 0x40
        public System.Net.EndPoint EndPoint;        // 0x48
        public System.Memory<System.Byte> Buffer;        // 0x50
        public System.Int32 Offset;        // 0x60
        public System.Int32 Size;        // 0x64
        public System.Net.Sockets.SocketFlags SockFlags;        // 0x68
        public System.Net.Sockets.Socket AcceptSocket;        // 0x70
        public System.Net.IPAddress[] Addresses;        // 0x78
        public System.Int32 Port;        // 0x80
        public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> Buffers;        // 0x88
        public System.Boolean ReuseSocket;        // 0x90
        public System.Int32 CurrentAddress;        // 0x94
        public System.Net.Sockets.Socket AcceptedSocket;        // 0x98
        public System.Int32 Total;        // 0xA0
        private System.Int32 error;        // 0xA4
        public System.Int32 EndCalled;        // 0xA8

        // Methods
        private System.IntPtr get_Handle() { }
        private System.Void .ctor() { }
        private System.Void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, System.Object state, System.Net.Sockets.SocketOperation operation) { }
        private System.Void .ctor(System.Net.Sockets.Socket socket, System.AsyncCallback callback, System.Object state, System.Net.Sockets.SocketOperation operation) { }
        private System.Net.Sockets.SocketError get_ErrorCode() { }
        private System.Void CheckIfThrowDelayedException() { }
        private System.Void CompleteDisposed() { }
        private System.Void Complete() { }
        private System.Void Complete(System.Boolean synch) { }
        private System.Void Complete(System.Int32 total) { }
        private System.Void Complete(System.Exception e, System.Boolean synch) { }
        private System.Void Complete(System.Exception e) { }
        private System.Void Complete(System.Net.Sockets.Socket s) { }
        private System.Void Complete(System.Net.Sockets.Socket s, System.Int32 total) { }

    }

    // TypeToken: 0x2000258
    public struct SocketOperation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Sockets.SocketOperation Accept;        // 0x0
        public static System.Net.Sockets.SocketOperation Connect;        // 0x0
        public static System.Net.Sockets.SocketOperation Receive;        // 0x0
        public static System.Net.Sockets.SocketOperation ReceiveFrom;        // 0x0
        public static System.Net.Sockets.SocketOperation Send;        // 0x0
        public static System.Net.Sockets.SocketOperation SendTo;        // 0x0
        public static System.Net.Sockets.SocketOperation RecvJustCallback;        // 0x0
        public static System.Net.Sockets.SocketOperation SendJustCallback;        // 0x0
        public static System.Net.Sockets.SocketOperation Disconnect;        // 0x0
        public static System.Net.Sockets.SocketOperation AcceptReceive;        // 0x0
        public static System.Net.Sockets.SocketOperation ReceiveGeneric;        // 0x0
        public static System.Net.Sockets.SocketOperation SendGeneric;        // 0x0

    }

}

namespace System.Net.WebSockets
{

    // TypeToken: 0x2000259
    public class ManagedWebSocket : WebSocket
    {
        // Fields
        private static readonly System.Security.Cryptography.RandomNumberGenerator s_random;        // 0x0
        private static readonly System.Text.UTF8Encoding s_textEncoding;        // 0x8
        private static readonly System.Net.WebSockets.WebSocketState[] s_validSendStates;        // 0x10
        private static readonly System.Net.WebSockets.WebSocketState[] s_validReceiveStates;        // 0x18
        private static readonly System.Net.WebSockets.WebSocketState[] s_validCloseOutputStates;        // 0x20
        private static readonly System.Net.WebSockets.WebSocketState[] s_validCloseStates;        // 0x28
        private static readonly System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> s_cachedCloseTask;        // 0x30
        private readonly System.IO.Stream _stream;        // 0x10
        private readonly System.Boolean _isServer;        // 0x18
        private readonly System.String _subprotocol;        // 0x20
        private readonly System.Threading.Timer _keepAliveTimer;        // 0x28
        private readonly System.Threading.CancellationTokenSource _abortSource;        // 0x30
        private System.Memory<System.Byte> _receiveBuffer;        // 0x38
        private readonly System.Net.WebSockets.ManagedWebSocket.Utf8MessageState _utf8TextState;        // 0x48
        private readonly System.Threading.SemaphoreSlim _sendFrameAsyncLock;        // 0x50
        private System.Net.WebSockets.WebSocketState _state;        // 0x58
        private System.Boolean _disposed;        // 0x5C
        private System.Boolean _sentCloseFrame;        // 0x5D
        private System.Boolean _receivedCloseFrame;        // 0x5E
        private System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> _closeStatus;        // 0x60
        private System.String _closeStatusDescription;        // 0x68
        private System.Net.WebSockets.ManagedWebSocket.MessageHeader _lastReceiveHeader;        // 0x70
        private System.Int32 _receiveBufferOffset;        // 0x88
        private System.Int32 _receiveBufferCount;        // 0x8C
        private System.Int32 _receivedMaskOffsetOffset;        // 0x90
        private System.Byte[] _sendBuffer;        // 0x98
        private System.Boolean _lastSendWasFragment;        // 0xA0
        private System.Threading.Tasks.Task _lastReceiveAsync;        // 0xA8

        // Methods
        private System.Net.WebSockets.ManagedWebSocket CreateFromConnectedStream(System.IO.Stream stream, System.Boolean isServer, System.String subprotocol, System.TimeSpan keepAliveInterval) { }
        private System.Object get_StateUpdateLock() { }
        private System.Object get_ReceiveAsyncLock() { }
        private System.Void .ctor(System.IO.Stream stream, System.Boolean isServer, System.String subprotocol, System.TimeSpan keepAliveInterval) { }
        private System.Void Dispose() { }
        private System.Void DisposeCore() { }
        private System.Net.WebSockets.WebSocketState get_State() { }
        private System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask SendPrivateAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Abort() { }
        private System.Threading.Tasks.ValueTask SendFrameAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlyMemory<System.Byte> payloadBuffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask SendFrameLockAcquiredNonCancelableAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlyMemory<System.Byte> payloadBuffer) { }
        private System.Threading.Tasks.Task WaitForWriteTaskAsync(System.Threading.Tasks.ValueTask writeTask) { }
        private System.Threading.Tasks.Task SendFrameFallbackAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlyMemory<System.Byte> payloadBuffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Int32 WriteFrameToSendBuffer(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlySpan<System.Byte> payloadBuffer) { }
        private System.Void SendKeepAliveFrameAsync() { }
        private System.Int32 WriteHeader(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Byte[] sendBuffer, System.ReadOnlySpan<System.Byte> payload, System.Boolean endOfMessage, System.Boolean useMask) { }
        private System.Void WriteRandomMask(System.Byte[] buffer, System.Int32 offset) { }
        private System.Threading.Tasks.ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate(System.Memory<System.Byte> payloadBuffer, System.Threading.CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter) { }
        private System.Threading.Tasks.Task HandleReceivedCloseAsync(System.Net.WebSockets.ManagedWebSocket.MessageHeader header, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WaitForServerToCloseConnectionAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task HandleReceivedPingPongAsync(System.Net.WebSockets.ManagedWebSocket.MessageHeader header, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean IsValidCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus) { }
        private System.Threading.Tasks.Task CloseWithReceiveErrorAndThrowAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.Net.WebSockets.WebSocketError error, System.Exception innerException) { }
        private System.Boolean TryParseMessageHeaderFromReceiveBuffer(System.Net.WebSockets.ManagedWebSocket.MessageHeader& resultHeader) { }
        private System.Threading.Tasks.Task SendCloseFrameAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String closeStatusDescription, System.Threading.CancellationToken cancellationToken) { }
        private System.Void ConsumeFromBuffer(System.Int32 count) { }
        private System.Threading.Tasks.Task EnsureBufferContainsAsync(System.Int32 minimumRequiredBytes, System.Threading.CancellationToken cancellationToken, System.Boolean throwOnPrematureClosure) { }
        private System.Void ThrowIfEOFUnexpected(System.Boolean throwOnPrematureClosure) { }
        private System.Void AllocateSendBuffer(System.Int32 minLength) { }
        private System.Void ReleaseSendBuffer() { }
        private System.Int32 CombineMaskBytes(System.Span<System.Byte> buffer, System.Int32 maskOffset) { }
        private System.Int32 ApplyMask(System.Span<System.Byte> toMask, System.Byte[] mask, System.Int32 maskOffset, System.Int32 maskOffsetIndex) { }
        private System.Int32 ApplyMask(System.Span<System.Byte> toMask, System.Int32 mask, System.Int32 maskIndex) { }
        private System.Void ThrowIfOperationInProgress(System.Boolean operationCompleted, System.String methodName) { }
        private System.Void ThrowOperationInProgress(System.String methodName) { }
        private System.Exception CreateOperationCanceledException(System.Exception innerException, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean TryValidateUtf8(System.Span<System.Byte> span, System.Boolean endOfMessage, System.Net.WebSockets.ManagedWebSocket.Utf8MessageState state) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200026A
    public class WebSocketValidate
    {
        // Methods
        private System.Void ThrowIfInvalidState(System.Net.WebSockets.WebSocketState currentState, System.Boolean isDisposed, System.Net.WebSockets.WebSocketState[] validStates) { }
        private System.Void ValidateSubprotocol(System.String subProtocol) { }
        private System.Void ValidateCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription) { }
        private System.Void ValidateArraySegment(System.ArraySegment<System.Byte> arraySegment, System.String parameterName) { }

    }

    // TypeToken: 0x200026B
    public class ClientWebSocket : WebSocket
    {
        // Fields
        private readonly System.Net.WebSockets.ClientWebSocketOptions _options;        // 0x10
        private System.Net.WebSockets.WebSocketHandle _innerWebSocket;        // 0x18
        private System.Int32 _state;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Net.WebSockets.ClientWebSocketOptions get_Options() { }
        private System.Net.WebSockets.WebSocketState get_State() { }
        private System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Abort() { }
        private System.Void Dispose() { }
        private System.Void ThrowIfNotConnected() { }

    }

    // TypeToken: 0x200026F
    public class ClientWebSocketOptions
    {
        // Fields
        private System.Boolean _isReadOnly;        // 0x10
        private readonly System.Collections.Generic.List<System.String> _requestedSubProtocols;        // 0x18
        private readonly System.Net.WebHeaderCollection _requestHeaders;        // 0x20
        private System.TimeSpan _keepAliveInterval;        // 0x28
        private System.Boolean _useDefaultCredentials;        // 0x30
        private System.Net.ICredentials _credentials;        // 0x38
        private System.Net.IWebProxy _proxy;        // 0x40
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;        // 0x48
        private System.Net.CookieContainer _cookies;        // 0x50
        private System.Int32 _receiveBufferSize;        // 0x58
        private System.Int32 _sendBufferSize;        // 0x5C
        private System.Nullable<System.ArraySegment<System.Byte>> _buffer;        // 0x60
        private System.Net.Security.RemoteCertificateValidationCallback _remoteCertificateValidationCallback;        // 0x78

        // Methods
        private System.Void .ctor() { }
        private System.Net.WebHeaderCollection get_RequestHeaders() { }
        private System.Collections.Generic.List<System.String> get_RequestedSubProtocols() { }
        private System.Void set_Proxy(System.Net.IWebProxy value) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Net.CookieContainer get_Cookies() { }
        private System.Void AddSubProtocol(System.String subProtocol) { }
        private System.TimeSpan get_KeepAliveInterval() { }
        private System.Int32 get_ReceiveBufferSize() { }
        private System.Int32 get_SendBufferSize() { }
        private System.Nullable<System.ArraySegment<System.Byte>> get_Buffer() { }
        private System.Void SetToReadOnly() { }
        private System.Void ThrowIfReadOnly() { }

    }

    // TypeToken: 0x2000270
    public class WebSocketHandle
    {
        // Fields
        private static System.Text.StringBuilder t_cachedStringBuilder;        // 0xFFFFFFFF
        private static readonly System.Text.Encoding s_defaultHttpEncoding;        // 0x0
        private static System.Int32 DefaultReceiveBufferSize;        // 0x0
        private static System.String WSServerGuid;        // 0x0
        private readonly System.Threading.CancellationTokenSource _abortSource;        // 0x10
        private System.Net.WebSockets.WebSocketState _state;        // 0x18
        private System.Net.WebSockets.WebSocket _webSocket;        // 0x20

        // Methods
        private System.Net.WebSockets.WebSocketHandle Create() { }
        private System.Boolean IsValid(System.Net.WebSockets.WebSocketHandle handle) { }
        private System.Net.WebSockets.WebSocketState get_State() { }
        private System.Void CheckPlatformSupport() { }
        private System.Void Dispose() { }
        private System.Void Abort() { }
        private System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, System.Threading.CancellationToken cancellationToken, System.Net.WebSockets.ClientWebSocketOptions options) { }
        private System.Threading.Tasks.Task<System.Net.Sockets.Socket> ConnectSocketAsync(System.String host, System.Int32 port, System.Threading.CancellationToken cancellationToken) { }
        private System.Byte[] BuildRequestHeader(System.Uri uri, System.Net.WebSockets.ClientWebSocketOptions options, System.String secKey) { }
        private System.Collections.Generic.KeyValuePair<System.String,System.String> CreateSecKeyAndSecWebSocketAccept() { }
        private System.Threading.Tasks.Task<System.String> ParseAndValidateConnectResponseAsync(System.IO.Stream stream, System.Net.WebSockets.ClientWebSocketOptions options, System.String expectedSecWebSocketAccept, System.Threading.CancellationToken cancellationToken) { }
        private System.Void ValidateAndTrackHeader(System.String targetHeaderName, System.String targetHeaderValue, System.String foundHeaderName, System.String foundHeaderValue, System.Boolean& foundHeader) { }
        private System.Threading.Tasks.Task<System.String> ReadResponseHeaderLineAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000277
    public class WebSocket, IDisposable
    {
        // Methods
        private System.Net.WebSockets.WebSocketState get_State() { }
        private System.Void Abort() { }
        private System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Dispose() { }
        private System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken) { }
        private System.TimeSpan get_DefaultKeepAliveInterval() { }
        private System.Net.WebSockets.WebSocket CreateClientWebSocket(System.IO.Stream innerStream, System.String subProtocol, System.Int32 receiveBufferSize, System.Int32 sendBufferSize, System.TimeSpan keepAliveInterval, System.Boolean useZeroMaskingKey, System.ArraySegment<System.Byte> internalBuffer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000278
    public struct WebSocketCloseStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebSockets.WebSocketCloseStatus NormalClosure;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus EndpointUnavailable;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus ProtocolError;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus InvalidMessageType;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus Empty;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus InvalidPayloadData;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus PolicyViolation;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus MessageTooBig;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus MandatoryExtension;        // 0x0
        public static System.Net.WebSockets.WebSocketCloseStatus InternalServerError;        // 0x0

    }

    // TypeToken: 0x2000279
    public struct WebSocketError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebSockets.WebSocketError Success;        // 0x0
        public static System.Net.WebSockets.WebSocketError InvalidMessageType;        // 0x0
        public static System.Net.WebSockets.WebSocketError Faulted;        // 0x0
        public static System.Net.WebSockets.WebSocketError NativeError;        // 0x0
        public static System.Net.WebSockets.WebSocketError NotAWebSocket;        // 0x0
        public static System.Net.WebSockets.WebSocketError UnsupportedVersion;        // 0x0
        public static System.Net.WebSockets.WebSocketError UnsupportedProtocol;        // 0x0
        public static System.Net.WebSockets.WebSocketError HeaderError;        // 0x0
        public static System.Net.WebSockets.WebSocketError ConnectionClosedPrematurely;        // 0x0
        public static System.Net.WebSockets.WebSocketError InvalidState;        // 0x0

    }

    // TypeToken: 0x200027A
    public class WebSocketException : Win32Exception
    {
        // Fields
        private readonly System.Net.WebSockets.WebSocketError _webSocketErrorCode;        // 0x98

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.WebSockets.WebSocketError error) { }
        private System.Void .ctor(System.Net.WebSockets.WebSocketError error, System.String message) { }
        private System.Void .ctor(System.Net.WebSockets.WebSocketError error, System.Exception innerException) { }
        private System.Void .ctor(System.Net.WebSockets.WebSocketError error, System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Int32 nativeError) { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.String GetErrorMessage(System.Net.WebSockets.WebSocketError error) { }
        private System.Void SetErrorCodeOnError(System.Int32 nativeError) { }
        private System.Boolean Succeeded(System.Int32 hr) { }

    }

    // TypeToken: 0x200027B
    public struct WebSocketMessageType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebSockets.WebSocketMessageType Text;        // 0x0
        public static System.Net.WebSockets.WebSocketMessageType Binary;        // 0x0
        public static System.Net.WebSockets.WebSocketMessageType Close;        // 0x0

    }

    // TypeToken: 0x200027C
    public class WebSocketReceiveResult
    {
        // Fields
        private readonly System.Int32 <Count>k__BackingField;        // 0x10
        private readonly System.Boolean <EndOfMessage>k__BackingField;        // 0x14
        private readonly System.Net.WebSockets.WebSocketMessageType <MessageType>k__BackingField;        // 0x18
        private readonly System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> <CloseStatus>k__BackingField;        // 0x1C
        private readonly System.String <CloseStatusDescription>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage) { }
        private System.Void .ctor(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, System.String closeStatusDescription) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_EndOfMessage() { }
        private System.Net.WebSockets.WebSocketMessageType get_MessageType() { }
        private System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> get_CloseStatus() { }
        private System.String get_CloseStatusDescription() { }

    }

    // TypeToken: 0x200027D
    public struct WebSocketState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.WebSockets.WebSocketState None;        // 0x0
        public static System.Net.WebSockets.WebSocketState Connecting;        // 0x0
        public static System.Net.WebSockets.WebSocketState Open;        // 0x0
        public static System.Net.WebSockets.WebSocketState CloseSent;        // 0x0
        public static System.Net.WebSockets.WebSocketState CloseReceived;        // 0x0
        public static System.Net.WebSockets.WebSocketState Closed;        // 0x0
        public static System.Net.WebSockets.WebSocketState Aborted;        // 0x0

    }

}

namespace System.Security.Authentication
{

    // TypeToken: 0x200010B
    public class AuthenticationException : SystemException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }

    }

    // TypeToken: 0x200010C
    public struct SslProtocols
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Authentication.SslProtocols None;        // 0x0
        public static System.Security.Authentication.SslProtocols Ssl2;        // 0x0
        public static System.Security.Authentication.SslProtocols Ssl3;        // 0x0
        public static System.Security.Authentication.SslProtocols Tls;        // 0x0
        public static System.Security.Authentication.SslProtocols Tls11;        // 0x0
        public static System.Security.Authentication.SslProtocols Tls12;        // 0x0
        public static System.Security.Authentication.SslProtocols Tls13;        // 0x0
        public static System.Security.Authentication.SslProtocols Default;        // 0x0

    }

}

namespace System.Security.Cryptography
{

    // TypeToken: 0x200010D
    public class DerSequenceReader
    {
        // Fields
        private static System.Globalization.DateTimeFormatInfo s_validityDateTimeFormatInfo;        // 0x0
        private static System.Text.Encoding s_utf8EncodingWithExceptionFallback;        // 0x8
        private static System.Text.Encoding s_latin1Encoding;        // 0x10
        private readonly System.Byte[] _data;        // 0x10
        private readonly System.Int32 _end;        // 0x18
        private System.Int32 _position;        // 0x1C
        private System.Int32 <ContentLength>k__BackingField;        // 0x20

        // Methods
        private System.Void set_ContentLength(System.Int32 value) { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.Void .ctor(System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        private System.Void .ctor(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        private System.Boolean get_HasData() { }
        private System.Byte PeekTag() { }
        private System.Void SkipValue() { }
        private System.Byte[] ReadNextEncodedValue() { }
        private System.Boolean ReadBoolean() { }
        private System.Int32 ReadInteger() { }
        private System.Byte[] ReadIntegerBytes() { }
        private System.Byte[] ReadBitString() { }
        private System.Byte[] ReadOctetString() { }
        private System.String ReadOidAsString() { }
        private System.String ReadUtf8String() { }
        private System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected) { }
        private System.Security.Cryptography.DerSequenceReader ReadSequence() { }
        private System.Security.Cryptography.DerSequenceReader ReadSet() { }
        private System.String ReadPrintableString() { }
        private System.String ReadIA5String() { }
        private System.String ReadT61String() { }
        private System.DateTime ReadX509Date() { }
        private System.DateTime ReadUtcTime() { }
        private System.DateTime ReadGeneralizedTime() { }
        private System.String ReadBMPString() { }
        private System.String TrimTrailingNulls(System.String value) { }
        private System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, System.String formatString) { }
        private System.Byte[] ReadContentAsBytes() { }
        private System.Void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected) { }
        private System.Void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, System.Byte[] data, System.Int32 position) { }
        private System.Int32 EatLength() { }
        private System.Int32 ScanContentLength(System.Byte[] data, System.Int32 offset, System.Int32 end, System.Int32& bytesConsumed) { }

    }

    // TypeToken: 0x2000110
    public class Oid
    {
        // Fields
        private System.String _value;        // 0x10
        private System.String _friendlyName;        // 0x18
        private System.Security.Cryptography.OidGroup _group;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String oid) { }
        private System.Void .ctor(System.String value, System.String friendlyName) { }
        private System.Void .ctor(System.Security.Cryptography.Oid oid) { }
        private System.Security.Cryptography.Oid FromOidValue(System.String oidValue, System.Security.Cryptography.OidGroup group) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.String get_FriendlyName() { }
        private System.Void .ctor(System.String value, System.String friendlyName, System.Security.Cryptography.OidGroup group) { }

    }

    // TypeToken: 0x2000111
    public class OidCollection, ICollection, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Int32 Add(System.Security.Cryptography.Oid oid) { }
        private System.Security.Cryptography.Oid get_Item(System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Security.Cryptography.OidEnumerator GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }

    }

    // TypeToken: 0x2000112
    public class OidEnumerator, IEnumerator
    {
        // Fields
        private readonly System.Security.Cryptography.OidCollection _oids;        // 0x10
        private System.Int32 _current;        // 0x18

        // Methods
        private System.Void .ctor(System.Security.Cryptography.OidCollection oids) { }
        private System.Security.Cryptography.Oid get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000113
    public struct OidGroup
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.OidGroup All;        // 0x0
        public static System.Security.Cryptography.OidGroup HashAlgorithm;        // 0x0
        public static System.Security.Cryptography.OidGroup EncryptionAlgorithm;        // 0x0
        public static System.Security.Cryptography.OidGroup PublicKeyAlgorithm;        // 0x0
        public static System.Security.Cryptography.OidGroup SignatureAlgorithm;        // 0x0
        public static System.Security.Cryptography.OidGroup Attribute;        // 0x0
        public static System.Security.Cryptography.OidGroup ExtensionOrAttribute;        // 0x0
        public static System.Security.Cryptography.OidGroup EnhancedKeyUsage;        // 0x0
        public static System.Security.Cryptography.OidGroup Policy;        // 0x0
        public static System.Security.Cryptography.OidGroup Template;        // 0x0
        public static System.Security.Cryptography.OidGroup KeyDerivationFunction;        // 0x0

    }

    // TypeToken: 0x2000114
    public struct AsnDecodeStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.AsnDecodeStatus NotDecoded;        // 0x0
        public static System.Security.Cryptography.AsnDecodeStatus Ok;        // 0x0
        public static System.Security.Cryptography.AsnDecodeStatus BadAsn;        // 0x0
        public static System.Security.Cryptography.AsnDecodeStatus BadTag;        // 0x0
        public static System.Security.Cryptography.AsnDecodeStatus BadLength;        // 0x0
        public static System.Security.Cryptography.AsnDecodeStatus InformationNotAvailable;        // 0x0

    }

    // TypeToken: 0x2000115
    public class AsnEncodedData
    {
        // Fields
        private System.Security.Cryptography.Oid _oid;        // 0x10
        private System.Byte[] _raw;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String oid, System.Byte[] rawData) { }
        private System.Void .ctor(System.Security.Cryptography.Oid oid, System.Byte[] rawData) { }
        private System.Void .ctor(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.Security.Cryptography.Oid get_Oid() { }
        private System.Void set_Oid(System.Security.Cryptography.Oid value) { }
        private System.Byte[] get_RawData() { }
        private System.Void set_RawData(System.Byte[] value) { }
        private System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.String Format(System.Boolean multiLine) { }
        private System.String ToString(System.Boolean multiLine) { }
        private System.String Default(System.Boolean multiLine) { }
        private System.String BasicConstraintsExtension(System.Boolean multiLine) { }
        private System.String EnhancedKeyUsageExtension(System.Boolean multiLine) { }
        private System.String KeyUsageExtension(System.Boolean multiLine) { }
        private System.String SubjectKeyIdentifierExtension(System.Boolean multiLine) { }
        private System.String SubjectAltName(System.Boolean multiLine) { }
        private System.String NetscapeCertType(System.Boolean multiLine) { }

    }

}

namespace System.Security.Cryptography.X509Certificates
{

    // TypeToken: 0x2000116
    public struct OpenFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.OpenFlags ReadOnly;        // 0x0
        public static System.Security.Cryptography.X509Certificates.OpenFlags ReadWrite;        // 0x0
        public static System.Security.Cryptography.X509Certificates.OpenFlags MaxAllowed;        // 0x0
        public static System.Security.Cryptography.X509Certificates.OpenFlags OpenExistingOnly;        // 0x0
        public static System.Security.Cryptography.X509Certificates.OpenFlags IncludeArchived;        // 0x0

    }

    // TypeToken: 0x2000117
    public struct StoreLocation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.StoreLocation CurrentUser;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreLocation LocalMachine;        // 0x0

    }

    // TypeToken: 0x2000118
    public struct StoreName
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.StoreName AddressBook;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName AuthRoot;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName CertificateAuthority;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName Disallowed;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName My;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName Root;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName TrustedPeople;        // 0x0
        public static System.Security.Cryptography.X509Certificates.StoreName TrustedPublisher;        // 0x0

    }

    // TypeToken: 0x2000119
    public struct X500DistinguishedNameFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags None;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags Reversed;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags UseSemicolons;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags DoNotUsePlusSign;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags DoNotUseQuotes;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags UseCommas;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags UseNewLines;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags UseUTF8Encoding;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags UseT61Encoding;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags ForceUTF8Encoding;        // 0x0

    }

    // TypeToken: 0x200011A
    public struct X509ChainStatusFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags NoError;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags NotTimeValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags NotTimeNested;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags Revoked;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags NotSignatureValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags NotValidForUsage;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags UntrustedRoot;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags RevocationStatusUnknown;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags Cyclic;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags InvalidExtension;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags InvalidPolicyConstraints;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags InvalidBasicConstraints;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags InvalidNameConstraints;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags HasNotSupportedNameConstraint;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags HasNotDefinedNameConstraint;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags HasNotPermittedNameConstraint;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags HasExcludedNameConstraint;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags PartialChain;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CtlNotTimeValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CtlNotSignatureValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CtlNotValidForUsage;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags OfflineRevocation;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags NoIssuanceChainPolicy;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags ExplicitDistrust;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags HasNotSupportedCriticalExtension;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags HasWeakSignature;        // 0x0

    }

    // TypeToken: 0x200011B
    public struct X509FindType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByThumbprint;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindBySubjectName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindBySubjectDistinguishedName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByIssuerName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByIssuerDistinguishedName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindBySerialNumber;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByTimeValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByTimeNotYetValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByTimeExpired;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByTemplateName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByApplicationPolicy;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByCertificatePolicy;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByExtension;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindByKeyUsage;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509FindType FindBySubjectKeyIdentifier;        // 0x0

    }

    // TypeToken: 0x200011C
    public struct X509KeyUsageFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags None;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags EncipherOnly;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags CrlSign;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags KeyCertSign;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags KeyAgreement;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags DataEncipherment;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags KeyEncipherment;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags NonRepudiation;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags DigitalSignature;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags DecipherOnly;        // 0x0

    }

    // TypeToken: 0x200011D
    public struct X509NameType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509NameType SimpleName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509NameType EmailName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509NameType UpnName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509NameType DnsName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509NameType DnsFromAlternativeName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509NameType UrlName;        // 0x0

    }

    // TypeToken: 0x200011E
    public struct X509RevocationFlag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509RevocationFlag EndCertificateOnly;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509RevocationFlag EntireChain;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509RevocationFlag ExcludeRoot;        // 0x0

    }

    // TypeToken: 0x200011F
    public struct X509RevocationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509RevocationMode NoCheck;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509RevocationMode Online;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509RevocationMode Offline;        // 0x0

    }

    // TypeToken: 0x2000120
    public struct X509SubjectKeyIdentifierHashAlgorithm
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm Sha1;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm ShortSha1;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm CapiSha1;        // 0x0

    }

    // TypeToken: 0x2000121
    public struct X509VerificationFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags NoFlag;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreNotTimeValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreCtlNotTimeValid;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreNotTimeNested;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreInvalidBasicConstraints;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags AllowUnknownCertificateAuthority;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreWrongUsage;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreInvalidName;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreInvalidPolicy;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreEndRevocationUnknown;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreCtlSignerRevocationUnknown;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags IgnoreRootRevocationUnknown;        // 0x0
        public static System.Security.Cryptography.X509Certificates.X509VerificationFlags AllFlags;        // 0x0

    }

    // TypeToken: 0x2000122
    public class PublicKey
    {
        // Fields
        private System.Security.Cryptography.AsnEncodedData _keyValue;        // 0x10
        private System.Security.Cryptography.AsnEncodedData _params;        // 0x18
        private System.Security.Cryptography.Oid _oid;        // 0x20
        private static System.Byte[] Empty;        // 0x0

        // Methods
        private System.Void .ctor(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue) { }
        private System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue() { }
        private System.Security.Cryptography.AsnEncodedData get_EncodedParameters() { }
        private System.Security.Cryptography.AsymmetricAlgorithm get_Key() { }
        private System.Security.Cryptography.Oid get_Oid() { }
        private System.Byte[] GetUnsignedBigInteger(System.Byte[] integer) { }
        private System.Security.Cryptography.DSA DecodeDSA(System.Byte[] rawPublicKey, System.Byte[] rawParameters) { }
        private System.Security.Cryptography.RSA DecodeRSA(System.Byte[] rawPublicKey) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000123
    public class X500DistinguishedName : AsnEncodedData
    {
        // Fields
        private System.String name;        // 0x20
        private System.Byte[] canonEncoding;        // 0x28

        // Methods
        private System.Void .ctor(System.Byte[] encodedDistinguishedName) { }
        private System.Void .ctor(System.String distinguishedName) { }
        private System.Void .ctor(System.String distinguishedName, System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { }
        private System.String get_Name() { }
        private System.String Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { }
        private System.String Format(System.Boolean multiLine) { }
        private System.String GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { }
        private System.Void DecodeRawData() { }
        private System.String Canonize(System.String s) { }
        private System.Boolean AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2) { }

    }

    // TypeToken: 0x2000124
    public class X509BasicConstraintsExtension : X509Extension
    {
        // Fields
        private static System.String oid;        // 0x0
        private static System.String friendlyName;        // 0x0
        private System.Boolean _certificateAuthority;        // 0x28
        private System.Boolean _hasPathLengthConstraint;        // 0x29
        private System.Int32 _pathLengthConstraint;        // 0x2C
        private System.Security.Cryptography.AsnDecodeStatus _status;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, System.Boolean critical) { }
        private System.Void .ctor(System.Boolean certificateAuthority, System.Boolean hasPathLengthConstraint, System.Int32 pathLengthConstraint, System.Boolean critical) { }
        private System.Boolean get_CertificateAuthority() { }
        private System.Boolean get_HasPathLengthConstraint() { }
        private System.Int32 get_PathLengthConstraint() { }
        private System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension) { }
        private System.Byte[] Encode() { }
        private System.String ToString(System.Boolean multiLine) { }

    }

    // TypeToken: 0x2000125
    public class X509Certificate2 : X509Certificate
    {
        // Fields
        private System.Byte[] lazyRawData;        // 0x60
        private System.Security.Cryptography.Oid lazySignatureAlgorithm;        // 0x68
        private System.Int32 lazyVersion;        // 0x70
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName lazySubjectName;        // 0x78
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName lazyIssuerName;        // 0x80
        private System.Security.Cryptography.X509Certificates.PublicKey lazyPublicKey;        // 0x88
        private System.Security.Cryptography.AsymmetricAlgorithm lazyPrivateKey;        // 0x90
        private System.Security.Cryptography.X509Certificates.X509ExtensionCollection lazyExtensions;        // 0x98

        // Methods
        private System.Void Reset() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Byte[] rawData) { }
        private System.Void .ctor(System.Byte[] rawData, System.String password) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2Impl impl) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions() { }
        private System.Boolean get_HasPrivateKey() { }
        private System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey() { }
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName() { }
        private System.DateTime get_NotAfter() { }
        private System.DateTime get_NotBefore() { }
        private System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey() { }
        private System.Byte[] get_RawData() { }
        private System.String get_SerialNumber() { }
        private System.Security.Cryptography.Oid get_SignatureAlgorithm() { }
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName() { }
        private System.String get_Thumbprint() { }
        private System.Int32 get_Version() { }
        private System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(System.Byte[] rawData) { }
        private System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer) { }
        private System.String ToString() { }
        private System.String ToString(System.Boolean verbose) { }
        private System.Boolean Verify() { }
        private System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl() { }

    }

    // TypeToken: 0x2000126
    public class X509Certificate2Collection : X509CertificateCollection
    {
        // Fields
        private static System.String[] newline_split;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(System.Int32 index) { }
        private System.Int32 Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        private System.Boolean Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.String GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, System.Object findValue, System.Boolean validOnly) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000127
    public class X509Certificate2Enumerator, IEnumerator
    {
        // Fields
        private System.Collections.IEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000128
    public class X509Certificate2Impl : X509CertificateImpl
    {
        // Methods
        private System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName() { }
        private System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey() { }
        private System.Void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value) { }
        private System.String get_SignatureAlgorithm() { }
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName() { }
        private System.Int32 get_Version() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates() { }
        private System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer) { }
        private System.Boolean Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate) { }
        private System.Void AppendPrivateKeyInfo(System.Text.StringBuilder sb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000129
    public class X509Certificate2ImplMono : X509Certificate2ImplUnix
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;        // 0xB0
        private Mono.Security.X509.X509Certificate _cert;        // 0xB8
        private static System.String empty_error;        // 0x0
        private static System.Byte[] signedData;        // 0x8

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Void .ctor(Mono.Security.X509.X509Certificate cert) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other) { }
        private System.Void .ctor(System.Byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone() { }
        private Mono.Security.X509.X509Certificate get_Cert() { }
        private System.Byte[] GetRawCertData() { }
        private System.Boolean get_HasPrivateKey() { }
        private System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey() { }
        private System.Void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value) { }
        private System.Security.Cryptography.RSA GetRSAPrivateKey() { }
        private System.Security.Cryptography.DSA GetDSAPrivateKey() { }
        private Mono.Security.X509.X509Certificate ImportPkcs12(System.Byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password) { }
        private Mono.Security.X509.X509Certificate ImportPkcs12(System.Byte[] rawData, System.String password) { }
        private System.Boolean Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates() { }
        private Mono.Security.X509.X509Certificate get_MonoCertificate() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200012A
    public class X509Certificate2ImplUnix : X509Certificate2Impl
    {
        // Fields
        private System.Boolean readCertData;        // 0x10
        private Internal.Cryptography.Pal.CertificateData certData;        // 0x18

        // Methods
        private System.Void EnsureCertData() { }
        private System.Byte[] GetRawCertData() { }
        private System.String get_KeyAlgorithm() { }
        private System.Byte[] get_KeyAlgorithmParameters() { }
        private System.Byte[] get_PublicKeyValue() { }
        private System.Byte[] get_SerialNumber() { }
        private System.String get_SignatureAlgorithm() { }
        private System.Int32 get_Version() { }
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName() { }
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName() { }
        private System.String get_Subject() { }
        private System.String get_Issuer() { }
        private System.Byte[] get_RawData() { }
        private System.Byte[] get_Thumbprint() { }
        private System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer) { }
        private System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }
        private System.DateTime get_NotAfter() { }
        private System.DateTime get_NotBefore() { }
        private System.Void AppendPrivateKeyInfo(System.Text.StringBuilder sb) { }
        private System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, Microsoft.Win32.SafeHandles.SafePasswordHandle password) { }
        private System.Byte[] ExportPkcs12(Microsoft.Win32.SafeHandles.SafePasswordHandle password) { }
        private System.Byte[] ExportPkcs12(System.String password) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012B
    public class X509CertificateCollection : CollectionBase
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate get_Item(System.Int32 index) { }
        private System.Int32 Add(System.Security.Cryptography.X509Certificates.X509Certificate value) { }
        private System.Void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200012D
    public class X509CertificateImplCollection, IDisposable
    {
        // Fields
        private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other) { }
        private System.Int32 get_Count() { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(System.Int32 index) { }
        private System.Void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, System.Boolean takeOwnership) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x200012E
    public class X509Chain, IDisposable
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.X509ChainImpl impl;        // 0x10

        // Methods
        private System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean useMachineContext) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509ChainImpl impl) { }
        private System.Void .ctor(System.IntPtr chainContext) { }
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements() { }
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy() { }
        private System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void Reset() { }
        private System.Security.Cryptography.X509Certificates.X509Chain Create() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x200012F
    public class X509ChainElement
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;        // 0x10
        private System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;        // 0x18
        private System.String info;        // 0x20
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags;        // 0x28

        // Methods
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate() { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus() { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags() { }
        private System.Void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value) { }
        private System.Int32 Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags) { }
        private System.Void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, System.Int32& position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask) { }
        private System.Void UncompressFlags() { }

    }

    // TypeToken: 0x2000130
    public class X509ChainElementCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.ArrayList _list;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(System.Int32 index) { }
        private System.Object get_SyncRoot() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }

    }

    // TypeToken: 0x2000131
    public class X509ChainElementEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.IEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.IEnumerable enumerable) { }
        private System.Security.Cryptography.X509Certificates.X509ChainElement get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000132
    public class X509ChainImpl, IDisposable
    {
        // Methods
        private System.Boolean get_IsValid() { }
        private System.Void ThrowIfContextInvalid() { }
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements() { }
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy() { }
        private System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode) { }
        private System.Void Reset() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Finalize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000133
    public class X509ChainImplMono : X509ChainImpl
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.StoreLocation location;        // 0x10
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;        // 0x18
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;        // 0x20
        private System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;        // 0x28
        private static System.Security.Cryptography.X509Certificates.X509ChainStatus[] Empty;        // 0x0
        private System.Int32 max_path_length;        // 0x30
        private System.Security.Cryptography.X509Certificates.X500DistinguishedName working_issuer_name;        // 0x38
        private System.Security.Cryptography.AsymmetricAlgorithm working_public_key;        // 0x40
        private System.Security.Cryptography.X509Certificates.X509ChainElement bce_restriction;        // 0x48
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection roots;        // 0x50
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection cas;        // 0x58
        private System.Security.Cryptography.X509Certificates.X509Store root_store;        // 0x60
        private System.Security.Cryptography.X509Certificates.X509Store ca_store;        // 0x68
        private System.Security.Cryptography.X509Certificates.X509Store user_root_store;        // 0x70
        private System.Security.Cryptography.X509Certificates.X509Store user_ca_store;        // 0x78
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection;        // 0x80

        // Methods
        private System.Void .ctor(System.Boolean useMachineContext) { }
        private System.Boolean get_IsValid() { }
        private System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements() { }
        private System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy() { }
        private System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error) { }
        private System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void Reset() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities() { }
        private System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore() { }
        private System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore() { }
        private System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore() { }
        private System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection() { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Boolean IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Boolean IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag) { }
        private System.Void Process(System.Int32 n) { }
        private System.Void PrepareForNextCertificate(System.Int32 n) { }
        private System.Void WrapUp() { }
        private System.Void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element) { }
        private System.Boolean IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey) { }
        private System.String GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.String GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.String GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl) { }
        private System.String GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext) { }
        private System.Void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag) { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Int32 ca, System.Boolean online) { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, System.Boolean online) { }
        private Mono.Security.X509.X509Crl CheckCrls(System.String subject, System.String ski, Mono.Security.X509.X509Store store) { }
        private Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate) { }
        private System.Boolean ProcessCrlExtensions(Mono.Security.X509.X509Crl crl) { }
        private System.Boolean ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000134
    public class X509ChainPolicy
    {
        // Fields
        private System.Security.Cryptography.OidCollection apps;        // 0x10
        private System.Security.Cryptography.OidCollection cert;        // 0x18
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection store;        // 0x20
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection store2;        // 0x28
        private System.Security.Cryptography.X509Certificates.X509RevocationFlag rflag;        // 0x30
        private System.Security.Cryptography.X509Certificates.X509RevocationMode mode;        // 0x34
        private System.TimeSpan timeout;        // 0x38
        private System.Security.Cryptography.X509Certificates.X509VerificationFlags vflags;        // 0x40
        private System.DateTime vtime;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore() { }
        private System.Void set_ExtraStore(System.Security.Cryptography.X509Certificates.X509Certificate2Collection value) { }
        private System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag() { }
        private System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode() { }
        private System.Void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value) { }
        private System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags() { }
        private System.Void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value) { }
        private System.DateTime get_VerificationTime() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000135
    public struct X509ChainStatus
    {
        // Fields
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;        // 0x10
        private System.String info;        // 0x18

        // Methods
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag) { }
        private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status() { }
        private System.Void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value) { }
        private System.Void set_StatusInformation(System.String value) { }
        private System.String GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags) { }

    }

    // TypeToken: 0x2000136
    public class X509EnhancedKeyUsageExtension : X509Extension
    {
        // Fields
        private System.Security.Cryptography.OidCollection _enhKeyUsage;        // 0x28
        private System.Security.Cryptography.AsnDecodeStatus _status;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, System.Boolean critical) { }
        private System.Void .ctor(System.Security.Cryptography.OidCollection enhancedKeyUsages, System.Boolean critical) { }
        private System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension) { }
        private System.Byte[] Encode() { }
        private System.String ToString(System.Boolean multiLine) { }

    }

    // TypeToken: 0x2000137
    public class X509Extension : AsnEncodedData
    {
        // Fields
        private System.Boolean _critical;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String oid, System.Byte[] rawData, System.Boolean critical) { }
        private System.Boolean get_Critical() { }
        private System.Void set_Critical(System.Boolean value) { }
        private System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.String FormatUnkownData(System.Byte[] data) { }

    }

    // TypeToken: 0x2000138
    public class X509ExtensionCollection, ICollection, IEnumerable
    {
        // Fields
        private static System.Byte[] Empty;        // 0x0
        private System.Collections.ArrayList _list;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Security.Cryptography.X509Certificates.X509Extension get_Item(System.String oid) { }
        private System.Int32 Add(System.Security.Cryptography.X509Certificates.X509Extension extension) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000139
    public class X509ExtensionEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.IEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.ArrayList list) { }
        private System.Security.Cryptography.X509Certificates.X509Extension get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x200013A
    public class X509Helper2
    {
        // Methods
        private Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        private System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(System.Boolean useMachineContext) { }
        private System.Boolean IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl) { }
        private System.Void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl) { }
        private System.Exception GetInvalidChainContextException() { }

    }

    // TypeToken: 0x200013B
    public class X509KeyUsageExtension : X509Extension
    {
        // Fields
        private static System.String oid;        // 0x0
        private static System.String friendlyName;        // 0x0
        private static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all;        // 0x0
        private System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;        // 0x28
        private System.Security.Cryptography.AsnDecodeStatus _status;        // 0x2C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, System.Boolean critical) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, System.Boolean critical) { }
        private System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages() { }
        private System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags) { }
        private System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension) { }
        private System.Byte[] Encode() { }
        private System.String ToString(System.Boolean multiLine) { }

    }

    // TypeToken: 0x200013C
    public class X509Store, IDisposable
    {
        // Fields
        private System.String _name;        // 0x10
        private System.Security.Cryptography.X509Certificates.StoreLocation _location;        // 0x18
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;        // 0x20
        private System.Security.Cryptography.X509Certificates.OpenFlags _flags;        // 0x28
        private Mono.Security.X509.X509Store store;        // 0x30

        // Methods
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates() { }
        private Mono.Security.X509.X509Stores get_Factory() { }
        private Mono.Security.X509.X509Store get_Store() { }
        private System.Void Close() { }
        private System.Void Dispose() { }
        private System.Void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags) { }

    }

    // TypeToken: 0x200013D
    public class X509SubjectKeyIdentifierExtension : X509Extension
    {
        // Fields
        private static System.String oid;        // 0x0
        private static System.String friendlyName;        // 0x0
        private System.Byte[] _subjectKeyIdentifier;        // 0x28
        private System.String _ski;        // 0x30
        private System.Security.Cryptography.AsnDecodeStatus _status;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, System.Boolean critical) { }
        private System.Void .ctor(System.Byte[] subjectKeyIdentifier, System.Boolean critical) { }
        private System.Void .ctor(System.String subjectKeyIdentifier, System.Boolean critical) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.PublicKey key, System.Boolean critical) { }
        private System.Void .ctor(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, System.Boolean critical) { }
        private System.String get_SubjectKeyIdentifier() { }
        private System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        private System.Byte FromHexChar(System.Char c) { }
        private System.Byte FromHexChars(System.Char c1, System.Char c2) { }
        private System.Byte[] FromHex(System.String hex) { }
        private System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension) { }
        private System.Byte[] Encode() { }
        private System.String ToString(System.Boolean multiLine) { }

    }

}

namespace System.Text.RegularExpressions
{

    // TypeToken: 0x20000D4
    public class Capture
    {
        // Fields
        private System.Int32 <Index>k__BackingField;        // 0x10
        private System.Int32 <Length>k__BackingField;        // 0x14
        private System.String <Text>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String text, System.Int32 index, System.Int32 length) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.String get_Text() { }
        private System.Void set_Text(System.String value) { }
        private System.String get_Value() { }
        private System.String ToString() { }
        private System.ReadOnlySpan<System.Char> GetLeftSubstring() { }
        private System.ReadOnlySpan<System.Char> GetRightSubstring() { }

    }

    // TypeToken: 0x20000D5
    public class CaptureCollection, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IReadOnlyList`1, IReadOnlyCollection`1, IList, ICollection
    {
        // Fields
        private readonly System.Text.RegularExpressions.Group _group;        // 0x10
        private readonly System.Int32 _capcount;        // 0x18
        private System.Text.RegularExpressions.Capture[] _captures;        // 0x20

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.Group group) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 get_Count() { }
        private System.Text.RegularExpressions.Capture get_Item(System.Int32 i) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }
        private System.Text.RegularExpressions.Capture GetCapture(System.Int32 i) { }
        private System.Void ForceInitialized() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Void CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Void CopyTo(System.Text.RegularExpressions.Capture[] array, System.Int32 arrayIndex) { }
        private System.Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(System.Int32 index, System.Text.RegularExpressions.Capture item) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(System.Int32 index) { }
        private System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(System.Int32 index) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(System.Int32 index, System.Text.RegularExpressions.Capture value) { }
        private System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item) { }
        private System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }

    }

    // TypeToken: 0x20000D7
    public class CollectionDebuggerProxy`1
    {
    }

    // TypeToken: 0x20000D8
    public class Group : Capture
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Group s_emptyGroup;        // 0x0
        private readonly System.Int32[] _caps;        // 0x20
        private System.Int32 _capcount;        // 0x28
        private System.Text.RegularExpressions.CaptureCollection _capcoll;        // 0x30
        private readonly System.String <Name>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor(System.String text, System.Int32[] caps, System.Int32 capcount, System.String name) { }
        private System.Boolean get_Success() { }
        private System.Text.RegularExpressions.CaptureCollection get_Captures() { }
        private System.Void .cctor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class GroupCollection, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IReadOnlyList`1, IReadOnlyCollection`1, IList, ICollection
    {
        // Fields
        private readonly System.Text.RegularExpressions.Match _match;        // 0x10
        private readonly System.Collections.Hashtable _captureMap;        // 0x18
        private System.Text.RegularExpressions.Group[] _groups;        // 0x20

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 get_Count() { }
        private System.Text.RegularExpressions.Group get_Item(System.Int32 groupnum) { }
        private System.Text.RegularExpressions.Group get_Item(System.String groupname) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }
        private System.Text.RegularExpressions.Group GetGroup(System.Int32 groupnum) { }
        private System.Text.RegularExpressions.Group GetGroupImpl(System.Int32 groupnum) { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Void CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Void CopyTo(System.Text.RegularExpressions.Group[] array, System.Int32 arrayIndex) { }
        private System.Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(System.Int32 index, System.Text.RegularExpressions.Group item) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(System.Int32 index) { }
        private System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(System.Int32 index) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(System.Int32 index, System.Text.RegularExpressions.Group value) { }
        private System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item) { }
        private System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DB
    public class Match : Group
    {
        // Fields
        private System.Text.RegularExpressions.GroupCollection _groupcoll;        // 0x40
        private System.Text.RegularExpressions.Regex _regex;        // 0x48
        private System.Int32 _textbeg;        // 0x50
        private System.Int32 _textpos;        // 0x54
        private System.Int32 _textend;        // 0x58
        private System.Int32 _textstart;        // 0x5C
        private System.Int32[][] _matches;        // 0x60
        private System.Int32[] _matchcount;        // 0x68
        private System.Boolean _balancing;        // 0x70
        private static readonly System.Text.RegularExpressions.Match <Empty>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.Regex regex, System.Int32 capcount, System.String text, System.Int32 begpos, System.Int32 len, System.Int32 startpos) { }
        private System.Text.RegularExpressions.Match get_Empty() { }
        private System.Void Reset(System.Text.RegularExpressions.Regex regex, System.String text, System.Int32 textbeg, System.Int32 textend, System.Int32 textstart) { }
        private System.Text.RegularExpressions.GroupCollection get_Groups() { }
        private System.Text.RegularExpressions.Match NextMatch() { }
        private System.ReadOnlySpan<System.Char> GroupToStringImpl(System.Int32 groupnum) { }
        private System.ReadOnlySpan<System.Char> LastGroupToStringImpl() { }
        private System.Void AddMatch(System.Int32 cap, System.Int32 start, System.Int32 len) { }
        private System.Void BalanceMatch(System.Int32 cap) { }
        private System.Void RemoveMatch(System.Int32 cap) { }
        private System.Boolean IsMatched(System.Int32 cap) { }
        private System.Int32 MatchIndex(System.Int32 cap) { }
        private System.Int32 MatchLength(System.Int32 cap) { }
        private System.Void Tidy(System.Int32 textpos) { }
        private System.Void .cctor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public class MatchSparse : Match
    {
        // Fields
        private readonly System.Collections.Hashtable _caps;        // 0x78

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, System.Int32 capcount, System.String text, System.Int32 begpos, System.Int32 len, System.Int32 startpos) { }
        private System.Text.RegularExpressions.GroupCollection get_Groups() { }

    }

    // TypeToken: 0x20000DD
    public class MatchCollection, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IReadOnlyList`1, IReadOnlyCollection`1, IList, ICollection
    {
        // Fields
        private readonly System.Text.RegularExpressions.Regex _regex;        // 0x10
        private readonly System.Collections.Generic.List<System.Text.RegularExpressions.Match> _matches;        // 0x18
        private System.Boolean _done;        // 0x20
        private readonly System.String _input;        // 0x28
        private readonly System.Int32 _beginning;        // 0x30
        private readonly System.Int32 _length;        // 0x34
        private System.Int32 _startat;        // 0x38
        private System.Int32 _prevlen;        // 0x3C

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.Regex regex, System.String input, System.Int32 beginning, System.Int32 length, System.Int32 startat) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 get_Count() { }
        private System.Text.RegularExpressions.Match get_Item(System.Int32 i) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }
        private System.Text.RegularExpressions.Match GetMatch(System.Int32 i) { }
        private System.Void EnsureInitialized() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Void CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Void CopyTo(System.Text.RegularExpressions.Match[] array, System.Int32 arrayIndex) { }
        private System.Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(System.Int32 index, System.Text.RegularExpressions.Match item) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(System.Int32 index) { }
        private System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(System.Int32 index) { }
        private System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(System.Int32 index, System.Text.RegularExpressions.Match value) { }
        private System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item) { }
        private System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DF
    public class ExclusiveReference
    {
        // Fields
        private System.Text.RegularExpressions.RegexRunner _ref;        // 0x10
        private System.Text.RegularExpressions.RegexRunner _obj;        // 0x18
        private System.Int32 _locked;        // 0x20

        // Methods
        private System.Text.RegularExpressions.RegexRunner Get() { }
        private System.Void Release(System.Text.RegularExpressions.RegexRunner obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0
    public class Regex, ISerializable
    {
        // Fields
        private static System.Int32 CacheDictionarySwitchLimit;        // 0x0
        private static System.Int32 s_cacheSize;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex.CachedCodeEntryKey,System.Text.RegularExpressions.Regex.CachedCodeEntry> s_cache;        // 0x8
        private static System.Int32 s_cacheCount;        // 0x10
        private static System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheFirst;        // 0x18
        private static System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheLast;        // 0x20
        private static readonly System.TimeSpan s_maximumMatchTimeout;        // 0x28
        private static System.String DefaultMatchTimeout_ConfigKeyName;        // 0x0
        private static readonly System.TimeSpan s_defaultMatchTimeout;        // 0x30
        public static readonly System.TimeSpan InfiniteMatchTimeout;        // 0x38
        protected internal System.TimeSpan internalMatchTimeout;        // 0x10
        private static System.Int32 MaxOptionShift;        // 0x0
        protected internal System.String pattern;        // 0x18
        protected internal System.Text.RegularExpressions.RegexOptions roptions;        // 0x20
        protected internal System.Text.RegularExpressions.RegexRunnerFactory factory;        // 0x28
        protected internal System.Collections.Hashtable caps;        // 0x30
        protected internal System.Collections.Hashtable capnames;        // 0x38
        protected internal System.String[] capslist;        // 0x40
        protected internal System.Int32 capsize;        // 0x48
        private System.Text.RegularExpressions.ExclusiveReference _runnerref;        // 0x50
        private System.WeakReference<System.Text.RegularExpressions.RegexReplacement> _replref;        // 0x58
        private System.Text.RegularExpressions.RegexCode _code;        // 0x60
        private System.Boolean _refsInitialized;        // 0x68

        // Methods
        private System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Boolean isToAdd) { }
        private System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Boolean isToAdd) { }
        private System.Void FillCacheDictionary() { }
        private System.Boolean TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Text.RegularExpressions.Regex.CachedCodeEntry& entry) { }
        private System.Boolean TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Text.RegularExpressions.Regex.CachedCodeEntry& entry) { }
        private System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key) { }
        private System.Boolean IsMatch(System.String input, System.String pattern) { }
        private System.Boolean IsMatch(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options) { }
        private System.Boolean IsMatch(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { }
        private System.Boolean IsMatch(System.String input) { }
        private System.Boolean IsMatch(System.String input, System.Int32 startat) { }
        private System.Text.RegularExpressions.Match Match(System.String input, System.String pattern) { }
        private System.Text.RegularExpressions.Match Match(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options) { }
        private System.Text.RegularExpressions.Match Match(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { }
        private System.Text.RegularExpressions.Match Match(System.String input) { }
        private System.Text.RegularExpressions.Match Match(System.String input, System.Int32 startat) { }
        private System.Text.RegularExpressions.MatchCollection Matches(System.String input, System.String pattern) { }
        private System.Text.RegularExpressions.MatchCollection Matches(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { }
        private System.Text.RegularExpressions.MatchCollection Matches(System.String input) { }
        private System.Text.RegularExpressions.MatchCollection Matches(System.String input, System.Int32 startat) { }
        private System.String Replace(System.String input, System.String pattern, System.String replacement) { }
        private System.String Replace(System.String input, System.String pattern, System.String replacement, System.Text.RegularExpressions.RegexOptions options) { }
        private System.String Replace(System.String input, System.String pattern, System.String replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { }
        private System.String Replace(System.String input, System.String replacement) { }
        private System.String Replace(System.String input, System.String replacement, System.Int32 count, System.Int32 startat) { }
        private System.String Replace(System.String input, System.String pattern, System.Text.RegularExpressions.MatchEvaluator evaluator) { }
        private System.String Replace(System.String input, System.String pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { }
        private System.String Replace(System.String input, System.Text.RegularExpressions.MatchEvaluator evaluator) { }
        private System.String Replace(System.String input, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Int32 count, System.Int32 startat) { }
        private System.String Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, System.String input, System.Int32 count, System.Int32 startat) { }
        private System.Void .cctor() { }
        private System.Void ValidateMatchTimeout(System.TimeSpan matchTimeout) { }
        private System.TimeSpan InitDefaultMatchTimeout() { }
        private System.Void .ctor(System.String pattern) { }
        private System.Void .ctor(System.String pattern, System.Text.RegularExpressions.RegexOptions options) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor(System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, System.Boolean addToCache) { }
        private System.String Escape(System.String str) { }
        private System.Text.RegularExpressions.RegexOptions get_Options() { }
        private System.Boolean get_RightToLeft() { }
        private System.String ToString() { }
        private System.String GroupNameFromNumber(System.Int32 i) { }
        private System.Int32 GroupNumberFromName(System.String name) { }
        private System.Void InitializeReferences() { }
        private System.Text.RegularExpressions.Match Run(System.Boolean quick, System.Int32 prevlen, System.String input, System.Int32 beginning, System.Int32 length, System.Int32 startat) { }
        private System.Boolean UseOptionR() { }
        private System.Boolean UseOptionInvariant() { }

    }

    // TypeToken: 0x20000E3
    public class MatchEvaluator : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke(System.Text.RegularExpressions.Match match) { }

    }

    // TypeToken: 0x20000E4
    public class RegexBoyerMoore
    {
        // Fields
        public readonly System.Int32[] Positive;        // 0x10
        public readonly System.Int32[] NegativeASCII;        // 0x18
        public readonly System.Int32[][] NegativeUnicode;        // 0x20
        public readonly System.String Pattern;        // 0x28
        public readonly System.Int32 LowASCII;        // 0x30
        public readonly System.Int32 HighASCII;        // 0x34
        public readonly System.Boolean RightToLeft;        // 0x38
        public readonly System.Boolean CaseInsensitive;        // 0x39
        private readonly System.Globalization.CultureInfo _culture;        // 0x40

        // Methods
        private System.Void .ctor(System.String pattern, System.Boolean caseInsensitive, System.Boolean rightToLeft, System.Globalization.CultureInfo culture) { }
        private System.Boolean MatchPattern(System.String text, System.Int32 index) { }
        private System.Boolean IsMatch(System.String text, System.Int32 index, System.Int32 beglimit, System.Int32 endlimit) { }
        private System.Int32 Scan(System.String text, System.Int32 index, System.Int32 beglimit, System.Int32 endlimit) { }

    }

    // TypeToken: 0x20000E5
    public class RegexCharClass
    {
        // Fields
        private static readonly System.String s_internalRegexIgnoreCase;        // 0x0
        private static readonly System.String s_space;        // 0x8
        private static readonly System.String s_notSpace;        // 0x10
        private static readonly System.String s_word;        // 0x18
        private static readonly System.String s_notWord;        // 0x20
        public static readonly System.String SpaceClass;        // 0x28
        public static readonly System.String NotSpaceClass;        // 0x30
        public static readonly System.String WordClass;        // 0x38
        public static readonly System.String NotWordClass;        // 0x40
        public static readonly System.String DigitClass;        // 0x48
        public static readonly System.String NotDigitClass;        // 0x50
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_definedCategories;        // 0x58
        private static readonly System.String[][] s_propTable;        // 0x60
        private static readonly System.Text.RegularExpressions.RegexCharClass.LowerCaseMapping[] s_lcTable;        // 0x68
        private System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> _rangelist;        // 0x10
        private System.Text.StringBuilder _categories;        // 0x18
        private System.Boolean _canonical;        // 0x20
        private System.Boolean _negate;        // 0x21
        private System.Text.RegularExpressions.RegexCharClass _subtractor;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction) { }
        private System.Boolean get_CanMerge() { }
        private System.Void set_Negate(System.Boolean value) { }
        private System.Void AddChar(System.Char c) { }
        private System.Void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc) { }
        private System.Void AddSet(System.String set) { }
        private System.Void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub) { }
        private System.Void AddRange(System.Char first, System.Char last) { }
        private System.Void AddCategoryFromName(System.String categoryName, System.Boolean invert, System.Boolean caseInsensitive, System.String pattern) { }
        private System.Void AddCategory(System.String category) { }
        private System.Void AddLowercase(System.Globalization.CultureInfo culture) { }
        private System.Void AddLowercaseRange(System.Char chMin, System.Char chMax, System.Globalization.CultureInfo culture) { }
        private System.Void AddWord(System.Boolean ecma, System.Boolean negate) { }
        private System.Void AddSpace(System.Boolean ecma, System.Boolean negate) { }
        private System.Void AddDigit(System.Boolean ecma, System.Boolean negate, System.String pattern) { }
        private System.Char SingletonChar(System.String set) { }
        private System.Boolean IsMergeable(System.String charClass) { }
        private System.Boolean IsEmpty(System.String charClass) { }
        private System.Boolean IsSingleton(System.String set) { }
        private System.Boolean IsSingletonInverse(System.String set) { }
        private System.Boolean IsSubtraction(System.String charClass) { }
        private System.Boolean IsNegated(System.String set) { }
        private System.Boolean IsECMAWordChar(System.Char ch) { }
        private System.Boolean IsWordChar(System.Char ch) { }
        private System.Boolean CharInClass(System.Char ch, System.String set) { }
        private System.Boolean CharInClassRecursive(System.Char ch, System.String set, System.Int32 start) { }
        private System.Boolean CharInClassInternal(System.Char ch, System.String set, System.Int32 start, System.Int32 mySetLength, System.Int32 myCategoryLength) { }
        private System.Boolean CharInCategory(System.Char ch, System.String set, System.Int32 start, System.Int32 mySetLength, System.Int32 myCategoryLength) { }
        private System.Boolean CharInCategoryGroup(System.Char ch, System.Globalization.UnicodeCategory chcategory, System.String category, System.Int32& i) { }
        private System.String NegateCategory(System.String category) { }
        private System.Text.RegularExpressions.RegexCharClass Parse(System.String charClass) { }
        private System.Text.RegularExpressions.RegexCharClass ParseRecursive(System.String charClass, System.Int32 start) { }
        private System.Int32 RangeCount() { }
        private System.String ToStringClass() { }
        private System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(System.Int32 i) { }
        private System.Void Canonicalize() { }
        private System.String SetFromProperty(System.String capname, System.Boolean invert, System.String pattern) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E9
    public class RegexCode
    {
        // Fields
        public static System.Int32 Onerep;        // 0x0
        public static System.Int32 Notonerep;        // 0x0
        public static System.Int32 Setrep;        // 0x0
        public static System.Int32 Oneloop;        // 0x0
        public static System.Int32 Notoneloop;        // 0x0
        public static System.Int32 Setloop;        // 0x0
        public static System.Int32 Onelazy;        // 0x0
        public static System.Int32 Notonelazy;        // 0x0
        public static System.Int32 Setlazy;        // 0x0
        public static System.Int32 One;        // 0x0
        public static System.Int32 Notone;        // 0x0
        public static System.Int32 Set;        // 0x0
        public static System.Int32 Multi;        // 0x0
        public static System.Int32 Ref;        // 0x0
        public static System.Int32 Bol;        // 0x0
        public static System.Int32 Eol;        // 0x0
        public static System.Int32 Boundary;        // 0x0
        public static System.Int32 Nonboundary;        // 0x0
        public static System.Int32 Beginning;        // 0x0
        public static System.Int32 Start;        // 0x0
        public static System.Int32 EndZ;        // 0x0
        public static System.Int32 End;        // 0x0
        public static System.Int32 Nothing;        // 0x0
        public static System.Int32 Lazybranch;        // 0x0
        public static System.Int32 Branchmark;        // 0x0
        public static System.Int32 Lazybranchmark;        // 0x0
        public static System.Int32 Nullcount;        // 0x0
        public static System.Int32 Setcount;        // 0x0
        public static System.Int32 Branchcount;        // 0x0
        public static System.Int32 Lazybranchcount;        // 0x0
        public static System.Int32 Nullmark;        // 0x0
        public static System.Int32 Setmark;        // 0x0
        public static System.Int32 Capturemark;        // 0x0
        public static System.Int32 Getmark;        // 0x0
        public static System.Int32 Setjump;        // 0x0
        public static System.Int32 Backjump;        // 0x0
        public static System.Int32 Forejump;        // 0x0
        public static System.Int32 Testref;        // 0x0
        public static System.Int32 Goto;        // 0x0
        public static System.Int32 Prune;        // 0x0
        public static System.Int32 Stop;        // 0x0
        public static System.Int32 ECMABoundary;        // 0x0
        public static System.Int32 NonECMABoundary;        // 0x0
        public static System.Int32 Mask;        // 0x0
        public static System.Int32 Rtl;        // 0x0
        public static System.Int32 Back;        // 0x0
        public static System.Int32 Back2;        // 0x0
        public static System.Int32 Ci;        // 0x0
        public readonly System.Int32[] Codes;        // 0x10
        public readonly System.String[] Strings;        // 0x18
        public readonly System.Int32 TrackCount;        // 0x20
        public readonly System.Collections.Hashtable Caps;        // 0x28
        public readonly System.Int32 CapSize;        // 0x30
        public readonly System.Nullable<System.Text.RegularExpressions.RegexPrefix> FCPrefix;        // 0x38
        public readonly System.Text.RegularExpressions.RegexBoyerMoore BMPrefix;        // 0x50
        public readonly System.Int32 Anchors;        // 0x58
        public readonly System.Boolean RightToLeft;        // 0x5C

        // Methods
        private System.Void .ctor(System.Int32[] codes, System.Collections.Generic.List<System.String> stringlist, System.Int32 trackcount, System.Collections.Hashtable caps, System.Int32 capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, System.Int32 anchors, System.Boolean rightToLeft) { }
        private System.Boolean OpcodeBacktracks(System.Int32 Op) { }

    }

    // TypeToken: 0x20000EA
    public struct RegexFCD
    {
        // Fields
        private readonly System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;        // 0x10
        private System.Collections.Generic.ValueListBuilder<System.Int32> _intStack;        // 0x18
        private System.Boolean _skipAllChildren;        // 0x38
        private System.Boolean _skipchild;        // 0x39
        private System.Boolean _failed;        // 0x3A

        // Methods
        private System.Void .ctor(System.Span<System.Int32> intStack) { }
        private System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t) { }
        private System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree) { }
        private System.Int32 Anchors(System.Text.RegularExpressions.RegexTree tree) { }
        private System.Int32 AnchorFromType(System.Int32 type) { }
        private System.Void PushInt(System.Int32 i) { }
        private System.Boolean IntIsEmpty() { }
        private System.Int32 PopInt() { }
        private System.Void PushFC(System.Text.RegularExpressions.RegexFC fc) { }
        private System.Boolean FCIsEmpty() { }
        private System.Text.RegularExpressions.RegexFC PopFC() { }
        private System.Text.RegularExpressions.RegexFC TopFC() { }
        private System.Void Dispose() { }
        private System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree) { }
        private System.Void SkipChild() { }
        private System.Void CalculateFC(System.Int32 NodeType, System.Text.RegularExpressions.RegexNode node, System.Int32 CurIndex) { }

    }

    // TypeToken: 0x20000EB
    public class RegexFC
    {
        // Fields
        private System.Text.RegularExpressions.RegexCharClass _cc;        // 0x10
        public System.Boolean _nullable;        // 0x18
        private System.Boolean <CaseInsensitive>k__BackingField;        // 0x19

        // Methods
        private System.Void .ctor(System.Boolean nullable) { }
        private System.Void .ctor(System.Char ch, System.Boolean not, System.Boolean nullable, System.Boolean caseInsensitive) { }
        private System.Void .ctor(System.String charClass, System.Boolean nullable, System.Boolean caseInsensitive) { }
        private System.Boolean AddFC(System.Text.RegularExpressions.RegexFC fc, System.Boolean concatenate) { }
        private System.Boolean get_CaseInsensitive() { }
        private System.Void set_CaseInsensitive(System.Boolean value) { }
        private System.String GetFirstChars(System.Globalization.CultureInfo culture) { }

    }

    // TypeToken: 0x20000EC
    public class RegexInterpreter : RegexRunner
    {
        // Fields
        private readonly System.Text.RegularExpressions.RegexCode _code;        // 0x80
        private readonly System.Globalization.CultureInfo _culture;        // 0x88
        private System.Int32 _operator;        // 0x90
        private System.Int32 _codepos;        // 0x94
        private System.Boolean _rightToLeft;        // 0x98
        private System.Boolean _caseInsensitive;        // 0x99

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture) { }
        private System.Void InitTrackCount() { }
        private System.Void Advance(System.Int32 i) { }
        private System.Void Goto(System.Int32 newpos) { }
        private System.Void Textto(System.Int32 newpos) { }
        private System.Void Trackto(System.Int32 newpos) { }
        private System.Int32 Textstart() { }
        private System.Int32 Textpos() { }
        private System.Int32 Trackpos() { }
        private System.Void TrackPush() { }
        private System.Void TrackPush(System.Int32 I1) { }
        private System.Void TrackPush(System.Int32 I1, System.Int32 I2) { }
        private System.Void TrackPush(System.Int32 I1, System.Int32 I2, System.Int32 I3) { }
        private System.Void TrackPush2(System.Int32 I1) { }
        private System.Void TrackPush2(System.Int32 I1, System.Int32 I2) { }
        private System.Void Backtrack() { }
        private System.Void SetOperator(System.Int32 op) { }
        private System.Void TrackPop() { }
        private System.Void TrackPop(System.Int32 framesize) { }
        private System.Int32 TrackPeek() { }
        private System.Int32 TrackPeek(System.Int32 i) { }
        private System.Void StackPush(System.Int32 I1) { }
        private System.Void StackPush(System.Int32 I1, System.Int32 I2) { }
        private System.Void StackPop() { }
        private System.Void StackPop(System.Int32 framesize) { }
        private System.Int32 StackPeek() { }
        private System.Int32 StackPeek(System.Int32 i) { }
        private System.Int32 Operator() { }
        private System.Int32 Operand(System.Int32 i) { }
        private System.Int32 Leftchars() { }
        private System.Int32 Rightchars() { }
        private System.Int32 Bump() { }
        private System.Int32 Forwardchars() { }
        private System.Char Forwardcharnext() { }
        private System.Boolean Stringmatch(System.String str) { }
        private System.Boolean Refmatch(System.Int32 index, System.Int32 len) { }
        private System.Void Backwardnext() { }
        private System.Char CharAt(System.Int32 j) { }
        private System.Boolean FindFirstChar() { }
        private System.Void Go() { }

    }

    // TypeToken: 0x20000ED
    public class RegexMatchTimeoutException : TimeoutException, ISerializable
    {
        // Fields
        private readonly System.String <Input>k__BackingField;        // 0x90
        private readonly System.String <Pattern>k__BackingField;        // 0x98
        private readonly System.TimeSpan <MatchTimeout>k__BackingField;        // 0xA0

        // Methods
        private System.Void .ctor(System.String regexInput, System.String regexPattern, System.TimeSpan matchTimeout) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.String get_Input() { }
        private System.String get_Pattern() { }
        private System.TimeSpan get_MatchTimeout() { }

    }

    // TypeToken: 0x20000EE
    public class RegexNode
    {
        // Fields
        public System.Int32 NType;        // 0x10
        public System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode> Children;        // 0x18
        public System.String Str;        // 0x20
        public System.Char Ch;        // 0x28
        public System.Int32 M;        // 0x2C
        public System.Int32 N;        // 0x30
        public readonly System.Text.RegularExpressions.RegexOptions Options;        // 0x34
        public System.Text.RegularExpressions.RegexNode Next;        // 0x38

        // Methods
        private System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options) { }
        private System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.Char ch) { }
        private System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.String str) { }
        private System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.Int32 m) { }
        private System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.Int32 m, System.Int32 n) { }
        private System.Boolean UseOptionR() { }
        private System.Text.RegularExpressions.RegexNode ReverseLeft() { }
        private System.Void MakeRep(System.Int32 type, System.Int32 min, System.Int32 max) { }
        private System.Text.RegularExpressions.RegexNode Reduce() { }
        private System.Text.RegularExpressions.RegexNode StripEnation(System.Int32 emptyType) { }
        private System.Text.RegularExpressions.RegexNode ReduceGroup() { }
        private System.Text.RegularExpressions.RegexNode ReduceRep() { }
        private System.Text.RegularExpressions.RegexNode ReduceSet() { }
        private System.Text.RegularExpressions.RegexNode ReduceAlternation() { }
        private System.Text.RegularExpressions.RegexNode ReduceConcatenation() { }
        private System.Text.RegularExpressions.RegexNode MakeQuantifier(System.Boolean lazy, System.Int32 min, System.Int32 max) { }
        private System.Void AddChild(System.Text.RegularExpressions.RegexNode newChild) { }
        private System.Text.RegularExpressions.RegexNode Child(System.Int32 i) { }
        private System.Int32 ChildCount() { }
        private System.Int32 Type() { }

    }

    // TypeToken: 0x20000EF
    public struct RegexOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Text.RegularExpressions.RegexOptions None;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions IgnoreCase;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions Multiline;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions ExplicitCapture;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions Compiled;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions Singleline;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions IgnorePatternWhitespace;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions RightToLeft;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions ECMAScript;        // 0x0
        public static System.Text.RegularExpressions.RegexOptions CultureInvariant;        // 0x0

    }

    // TypeToken: 0x20000F0
    public class RegexParser
    {
        // Fields
        private System.Text.RegularExpressions.RegexNode _stack;        // 0x10
        private System.Text.RegularExpressions.RegexNode _group;        // 0x18
        private System.Text.RegularExpressions.RegexNode _alternation;        // 0x20
        private System.Text.RegularExpressions.RegexNode _concatenation;        // 0x28
        private System.Text.RegularExpressions.RegexNode _unit;        // 0x30
        private System.String _pattern;        // 0x38
        private System.Int32 _currentPos;        // 0x40
        private System.Globalization.CultureInfo _culture;        // 0x48
        private System.Int32 _autocap;        // 0x50
        private System.Int32 _capcount;        // 0x54
        private System.Int32 _captop;        // 0x58
        private System.Int32 _capsize;        // 0x5C
        private System.Collections.Hashtable _caps;        // 0x60
        private System.Collections.Hashtable _capnames;        // 0x68
        private System.Int32[] _capnumlist;        // 0x70
        private System.Collections.Generic.List<System.String> _capnamelist;        // 0x78
        private System.Text.RegularExpressions.RegexOptions _options;        // 0x80
        private System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions> _optionsStack;        // 0x88
        private System.Boolean _ignoreNextParen;        // 0x90
        private static readonly System.Byte[] s_category;        // 0x0

        // Methods
        private System.Text.RegularExpressions.RegexTree Parse(System.String re, System.Text.RegularExpressions.RegexOptions op) { }
        private System.Text.RegularExpressions.RegexReplacement ParseReplacement(System.String rep, System.Collections.Hashtable caps, System.Int32 capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op) { }
        private System.String Escape(System.String input) { }
        private System.Void .ctor(System.Globalization.CultureInfo culture) { }
        private System.Void SetPattern(System.String Re) { }
        private System.Void Reset(System.Text.RegularExpressions.RegexOptions topopts) { }
        private System.Text.RegularExpressions.RegexNode ScanRegex() { }
        private System.Text.RegularExpressions.RegexNode ScanReplacement() { }
        private System.Text.RegularExpressions.RegexCharClass ScanCharClass(System.Boolean caseInsensitive, System.Boolean scanOnly) { }
        private System.Text.RegularExpressions.RegexNode ScanGroupOpen() { }
        private System.Void ScanBlank() { }
        private System.Text.RegularExpressions.RegexNode ScanBackslash(System.Boolean scanOnly) { }
        private System.Text.RegularExpressions.RegexNode ScanBasicBackslash(System.Boolean scanOnly) { }
        private System.Text.RegularExpressions.RegexNode ScanDollar() { }
        private System.String ScanCapname() { }
        private System.Char ScanOctal() { }
        private System.Int32 ScanDecimal() { }
        private System.Char ScanHex(System.Int32 c) { }
        private System.Int32 HexDigit(System.Char ch) { }
        private System.Char ScanControl() { }
        private System.Boolean IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option) { }
        private System.Void ScanOptions() { }
        private System.Char ScanCharEscape() { }
        private System.String ParseProperty() { }
        private System.Int32 TypeFromCode(System.Char ch) { }
        private System.Text.RegularExpressions.RegexOptions OptionFromCode(System.Char ch) { }
        private System.Void CountCaptures() { }
        private System.Void NoteCaptureSlot(System.Int32 i, System.Int32 pos) { }
        private System.Void NoteCaptureName(System.String name, System.Int32 pos) { }
        private System.Void NoteCaptures(System.Collections.Hashtable caps, System.Int32 capsize, System.Collections.Hashtable capnames) { }
        private System.Void AssignNameSlots() { }
        private System.Int32 CaptureSlotFromName(System.String capname) { }
        private System.Boolean IsCaptureSlot(System.Int32 i) { }
        private System.Boolean IsCaptureName(System.String capname) { }
        private System.Boolean UseOptionN() { }
        private System.Boolean UseOptionI() { }
        private System.Boolean UseOptionM() { }
        private System.Boolean UseOptionS() { }
        private System.Boolean UseOptionX() { }
        private System.Boolean UseOptionE() { }
        private System.Boolean IsSpecial(System.Char ch) { }
        private System.Boolean IsStopperX(System.Char ch) { }
        private System.Boolean IsQuantifier(System.Char ch) { }
        private System.Boolean IsTrueQuantifier() { }
        private System.Boolean IsSpace(System.Char ch) { }
        private System.Boolean IsMetachar(System.Char ch) { }
        private System.Void AddConcatenate(System.Int32 pos, System.Int32 cch, System.Boolean isReplacement) { }
        private System.Void PushGroup() { }
        private System.Void PopGroup() { }
        private System.Boolean EmptyStack() { }
        private System.Void StartGroup(System.Text.RegularExpressions.RegexNode openGroup) { }
        private System.Void AddAlternate() { }
        private System.Void AddConcatenate() { }
        private System.Void AddConcatenate(System.Boolean lazy, System.Int32 min, System.Int32 max) { }
        private System.Text.RegularExpressions.RegexNode Unit() { }
        private System.Void AddUnitOne(System.Char ch) { }
        private System.Void AddUnitNotone(System.Char ch) { }
        private System.Void AddUnitSet(System.String cc) { }
        private System.Void AddUnitNode(System.Text.RegularExpressions.RegexNode node) { }
        private System.Void AddUnitType(System.Int32 type) { }
        private System.Void AddGroup() { }
        private System.Void PushOptions() { }
        private System.Void PopOptions() { }
        private System.Boolean EmptyOptionsStack() { }
        private System.Void PopKeepOptions() { }
        private System.ArgumentException MakeException(System.String message) { }
        private System.Int32 Textpos() { }
        private System.Void Textto(System.Int32 pos) { }
        private System.Char RightCharMoveRight() { }
        private System.Void MoveRight() { }
        private System.Void MoveRight(System.Int32 i) { }
        private System.Void MoveLeft() { }
        private System.Char CharAt(System.Int32 i) { }
        private System.Char RightChar() { }
        private System.Char RightChar(System.Int32 i) { }
        private System.Int32 CharsRight() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F1
    public struct RegexPrefix
    {
        // Fields
        private readonly System.Boolean <CaseInsensitive>k__BackingField;        // 0x10
        private static readonly System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;        // 0x0
        private readonly System.String <Prefix>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String prefix, System.Boolean ci) { }
        private System.Boolean get_CaseInsensitive() { }
        private System.Text.RegularExpressions.RegexPrefix get_Empty() { }
        private System.String get_Prefix() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F2
    public class RegexReplacement
    {
        // Fields
        private static System.Int32 Specials;        // 0x0
        public static System.Int32 LeftPortion;        // 0x0
        public static System.Int32 RightPortion;        // 0x0
        public static System.Int32 LastGroup;        // 0x0
        public static System.Int32 WholeString;        // 0x0
        private readonly System.Collections.Generic.List<System.String> _strings;        // 0x10
        private readonly System.Collections.Generic.List<System.Int32> _rules;        // 0x18
        private readonly System.String <Pattern>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.String rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps) { }
        private System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, System.String replacement, System.Collections.Hashtable caps, System.Int32 capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions) { }
        private System.String get_Pattern() { }
        private System.Void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match) { }
        private System.Void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, System.Text.RegularExpressions.Match match) { }
        private System.String Replace(System.Text.RegularExpressions.Regex regex, System.String input, System.Int32 count, System.Int32 startat) { }

    }

    // TypeToken: 0x20000F3
    public class RegexRunner
    {
        // Fields
        protected internal System.Int32 runtextbeg;        // 0x10
        protected internal System.Int32 runtextend;        // 0x14
        protected internal System.Int32 runtextstart;        // 0x18
        protected internal System.String runtext;        // 0x20
        protected internal System.Int32 runtextpos;        // 0x28
        protected internal System.Int32[] runtrack;        // 0x30
        protected internal System.Int32 runtrackpos;        // 0x38
        protected internal System.Int32[] runstack;        // 0x40
        protected internal System.Int32 runstackpos;        // 0x48
        protected internal System.Int32[] runcrawl;        // 0x50
        protected internal System.Int32 runcrawlpos;        // 0x58
        protected internal System.Int32 runtrackcount;        // 0x5C
        protected internal System.Text.RegularExpressions.Match runmatch;        // 0x60
        protected internal System.Text.RegularExpressions.Regex runregex;        // 0x68
        private System.Int32 _timeout;        // 0x70
        private System.Boolean _ignoreTimeout;        // 0x74
        private System.Int32 _timeoutOccursAt;        // 0x78
        private static System.Int32 TimeoutCheckFrequency;        // 0x0
        private System.Int32 _timeoutChecksToSkip;        // 0x7C

        // Methods
        private System.Void .ctor() { }
        private System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, System.String text, System.Int32 textbeg, System.Int32 textend, System.Int32 textstart, System.Int32 prevlen, System.Boolean quick, System.TimeSpan timeout) { }
        private System.Void StartTimeoutWatch() { }
        private System.Void CheckTimeout() { }
        private System.Void DoCheckTimeout() { }
        private System.Void Go() { }
        private System.Boolean FindFirstChar() { }
        private System.Void InitTrackCount() { }
        private System.Void InitMatch() { }
        private System.Text.RegularExpressions.Match TidyMatch(System.Boolean quick) { }
        private System.Void EnsureStorage() { }
        private System.Boolean IsBoundary(System.Int32 index, System.Int32 startpos, System.Int32 endpos) { }
        private System.Boolean IsECMABoundary(System.Int32 index, System.Int32 startpos, System.Int32 endpos) { }
        private System.Void DoubleTrack() { }
        private System.Void DoubleStack() { }
        private System.Void DoubleCrawl() { }
        private System.Void Crawl(System.Int32 i) { }
        private System.Int32 Popcrawl() { }
        private System.Int32 Crawlpos() { }
        private System.Void Capture(System.Int32 capnum, System.Int32 start, System.Int32 end) { }
        private System.Void TransferCapture(System.Int32 capnum, System.Int32 uncapnum, System.Int32 start, System.Int32 end) { }
        private System.Void Uncapture() { }
        private System.Boolean IsMatched(System.Int32 cap) { }
        private System.Int32 MatchIndex(System.Int32 cap) { }
        private System.Int32 MatchLength(System.Int32 cap) { }

    }

    // TypeToken: 0x20000F4
    public class RegexRunnerFactory
    {
        // Methods
        private System.Text.RegularExpressions.RegexRunner CreateInstance() { }

    }

    // TypeToken: 0x20000F5
    public class RegexTree
    {
        // Fields
        public readonly System.Text.RegularExpressions.RegexNode Root;        // 0x10
        public readonly System.Collections.Hashtable Caps;        // 0x18
        public readonly System.Int32[] CapNumList;        // 0x20
        public readonly System.Int32 CapTop;        // 0x28
        public readonly System.Collections.Hashtable CapNames;        // 0x30
        public readonly System.String[] CapsList;        // 0x38
        public readonly System.Text.RegularExpressions.RegexOptions Options;        // 0x40

        // Methods
        private System.Void .ctor(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, System.Int32[] capNumList, System.Int32 capTop, System.Collections.Hashtable capNames, System.String[] capsList, System.Text.RegularExpressions.RegexOptions options) { }

    }

    // TypeToken: 0x20000F6
    public struct RegexWriter
    {
        // Fields
        private System.Collections.Generic.ValueListBuilder<System.Int32> _emitted;        // 0x10
        private System.Collections.Generic.ValueListBuilder<System.Int32> _intStack;        // 0x30
        private readonly System.Collections.Generic.Dictionary<System.String,System.Int32> _stringHash;        // 0x50
        private readonly System.Collections.Generic.List<System.String> _stringTable;        // 0x58
        private System.Collections.Hashtable _caps;        // 0x60
        private System.Int32 _trackCount;        // 0x68

        // Methods
        private System.Void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan) { }
        private System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree) { }
        private System.Void Dispose() { }
        private System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree) { }
        private System.Void PatchJump(System.Int32 offset, System.Int32 jumpDest) { }
        private System.Void Emit(System.Int32 op) { }
        private System.Void Emit(System.Int32 op, System.Int32 opd1) { }
        private System.Void Emit(System.Int32 op, System.Int32 opd1, System.Int32 opd2) { }
        private System.Int32 StringCode(System.String str) { }
        private System.Int32 MapCapnum(System.Int32 capnum) { }
        private System.Void EmitFragment(System.Int32 nodetype, System.Text.RegularExpressions.RegexNode node, System.Int32 curIndex) { }

    }

}

namespace Unity
{

    // TypeToken: 0x200038D
    public class ThrowStub : ObjectDisposedException
    {
        // Methods
        private System.Void ThrowNotSupportedException() { }

    }

}

