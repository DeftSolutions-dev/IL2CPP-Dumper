// ========================================================
// Dumped by @desirepro
// Assembly: System.dll
// Classes:  909
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: unitytls_error_code
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_SUCCESS  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_INVALID_ARGUMENT  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_INVALID_FORMAT  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_INVALID_PASSWORD  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_INVALID_STATE  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_BUFFER_OVERFLOW  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_OUT_OF_MEMORY  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_INTERNAL_ERROR  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_NOT_SUPPORTED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_ENTROPY_SOURCE_FAILED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_STREAM_CLOSED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_USER_CUSTOM_ERROR_START  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_USER_WOULD_BLOCK  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_USER_READ_FAILED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_USER_WRITE_FAILED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_USER_UNKNOWN_ERROR  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_error_codeUNITYTLS_USER_CUSTOM_ERROR_END  // 0x0
METHODS:
END_CLASS

CLASS: unitytls_errorstate
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  private           System.UInt32                   magic  // 0x10
  public            Mono.Unity.UnityTls.unitytls_error_codecode  // 0x14
  private           System.UInt64                   reserved  // 0x18
METHODS:
END_CLASS

CLASS: unitytls_key
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
METHODS:
END_CLASS

CLASS: unitytls_key_ref
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.UInt64                   handle  // 0x10
METHODS:
END_CLASS

CLASS: unitytls_x509_ref
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.UInt64                   handle  // 0x10
METHODS:
END_CLASS

CLASS: unitytls_x509list
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
METHODS:
END_CLASS

CLASS: unitytls_x509list_ref
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.UInt64                   handle  // 0x10
METHODS:
END_CLASS

CLASS: unitytls_x509verify_result
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_SUCCESS  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_NOT_DONE  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FATAL_ERROR  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_EXPIRED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_REVOKED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_CN_MISMATCH  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR1  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR2  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR3  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR4  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR5  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR6  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR7  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_USER_ERROR8  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_x509verify_resultUNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR  // 0x0
METHODS:
END_CLASS

CLASS: unitytls_x509verify_callback
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
METHODS:
END_CLASS

CLASS: unitytls_x509name
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
METHODS:
END_CLASS

CLASS: unitytls_ciphersuite
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Mono.Unity.UnityTls.unitytls_ciphersuiteUNITYTLS_CIPHERSUITE_INVALID  // 0x0
METHODS:
END_CLASS

CLASS: unitytls_protocol
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Mono.Unity.UnityTls.unitytls_protocolUNITYTLS_PROTOCOL_TLS_1_0  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_protocolUNITYTLS_PROTOCOL_TLS_1_1  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_protocolUNITYTLS_PROTOCOL_TLS_1_2  // 0x0
  public    static  Mono.Unity.UnityTls.unitytls_protocolUNITYTLS_PROTOCOL_INVALID  // 0x0
METHODS:
END_CLASS

CLASS: unitytls_tlsctx_protocolrange
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            Mono.Unity.UnityTls.unitytls_protocolmin  // 0x10
  public            Mono.Unity.UnityTls.unitytls_protocolmax  // 0x14
METHODS:
END_CLASS

CLASS: unitytls_tlsctx_write_callback
TYPE:  class
TOKEN: 0x2000019
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.IntPtr Invoke(System.Void* userData, System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_read_callback
TYPE:  class
TOKEN: 0x200001A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.IntPtr Invoke(System.Void* userData, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_trace_callback
TYPE:  class
TOKEN: 0x200001B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* traceMessage, System.IntPtr traceMessageLen)
END_CLASS

CLASS: unitytls_tlsctx_certificate_callback
TYPE:  class
TOKEN: 0x200001C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, System.IntPtr caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_x509verify_callback
TYPE:  class
TOKEN: 0x200001D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_callbacks
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            Mono.Unity.UnityTls.unitytls_tlsctx_read_callbackread  // 0x10
  public            Mono.Unity.UnityTls.unitytls_tlsctx_write_callbackwrite  // 0x18
  public            System.Void*                    data  // 0x20
METHODS:
END_CLASS

CLASS: unitytls_errorstate_create_t
TYPE:  class
TOKEN: 0x2000020
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_errorstate Invoke()
END_CLASS

CLASS: unitytls_errorstate_raise_error_t
TYPE:  class
TOKEN: 0x2000021
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode)
END_CLASS

CLASS: unitytls_key_get_ref_t
TYPE:  class
TOKEN: 0x2000022
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_key_parse_der_t
TYPE:  class
TOKEN: 0x2000023
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_key* Invoke(System.Byte* buffer, System.IntPtr bufferLen, System.Byte* password, System.IntPtr passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_key_parse_pem_t
TYPE:  class
TOKEN: 0x2000024
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_key* Invoke(System.Byte* buffer, System.IntPtr bufferLen, System.Byte* password, System.IntPtr passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_key_free_t
TYPE:  class
TOKEN: 0x2000025
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_key* key)
END_CLASS

CLASS: unitytls_x509_export_der_t
TYPE:  class
TOKEN: 0x2000026
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.IntPtr Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509list_get_ref_t
TYPE:  class
TOKEN: 0x2000027
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509list_get_x509_t
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, System.IntPtr index, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509list_create_t
TYPE:  class
TOKEN: 0x2000029
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509list_append_t
TYPE:  class
TOKEN: 0x200002A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509list_append_der_t
TYPE:  class
TOKEN: 0x200002B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509list_free_t
TYPE:  class
TOKEN: 0x200002C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list)
END_CLASS

CLASS: unitytls_x509verify_default_ca_t
TYPE:  class
TOKEN: 0x200002D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_x509verify_explicit_ca_t
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_create_server_t
TYPE:  class
TOKEN: 0x200002F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, System.UInt64 certChain, System.UInt64 leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_create_client_t
TYPE:  class
TOKEN: 0x2000030
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_server_require_client_authentication_t
TYPE:  class
TOKEN: 0x2000031
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_set_certificate_callback_t
TYPE:  class
TOKEN: 0x2000032
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_set_trace_callback_t
TYPE:  class
TOKEN: 0x2000033
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_set_x509verify_callback_t
TYPE:  class
TOKEN: 0x2000034
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, System.Void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_set_supported_ciphersuites_t
TYPE:  class
TOKEN: 0x2000035
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, System.IntPtr supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_get_ciphersuite_t
TYPE:  class
TOKEN: 0x2000036
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_get_protocol_t
TYPE:  class
TOKEN: 0x2000037
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_process_handshake_t
TYPE:  class
TOKEN: 0x2000038
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_read_t
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.IntPtr Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_write_t
TYPE:  class
TOKEN: 0x200003A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.IntPtr Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_notify_close_t
TYPE:  class
TOKEN: 0x200003B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_tlsctx_free_t
TYPE:  class
TOKEN: 0x200003C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx)
END_CLASS

CLASS: unitytls_random_generate_bytes_t
TYPE:  class
TOKEN: 0x200003D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: unitytls_interface_struct
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  public    readonly System.UInt64                   UNITYTLS_INVALID_HANDLE  // 0x10
  public    readonly Mono.Unity.UnityTls.unitytls_tlsctx_protocolrangeUNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT  // 0x18
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_create_tunitytls_errorstate_create  // 0x20
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_tunitytls_errorstate_raise_error  // 0x28
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_get_ref_tunitytls_key_get_ref  // 0x30
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_der_tunitytls_key_parse_der  // 0x38
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_tunitytls_key_parse_pem  // 0x40
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_free_tunitytls_key_free  // 0x48
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509_export_der_tunitytls_x509_export_der  // 0x50
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_tunitytls_x509list_get_ref  // 0x58
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_tunitytls_x509list_get_x509  // 0x60
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_create_tunitytls_x509list_create  // 0x68
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_tunitytls_x509list_append  // 0x70
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_tunitytls_x509list_append_der  // 0x78
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_tunitytls_x509list_append_pem  // 0x80
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_free_tunitytls_x509list_free  // 0x88
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_tunitytls_x509verify_default_ca  // 0x90
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_tunitytls_x509verify_explicit_ca  // 0x98
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_tunitytls_tlsctx_create_server  // 0xA0
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_tunitytls_tlsctx_create_client  // 0xA8
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_tunitytls_tlsctx_server_require_client_authentication  // 0xB0
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_tunitytls_tlsctx_set_certificate_callback  // 0xB8
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_tunitytls_tlsctx_set_trace_callback  // 0xC0
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_tunitytls_tlsctx_set_x509verify_callback  // 0xC8
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_tunitytls_tlsctx_set_supported_ciphersuites  // 0xD0
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_tunitytls_tlsctx_get_ciphersuite  // 0xD8
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_tunitytls_tlsctx_get_protocol  // 0xE0
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_tunitytls_tlsctx_process_handshake  // 0xE8
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_tunitytls_tlsctx_read  // 0xF0
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_tunitytls_tlsctx_write  // 0xF8
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_tunitytls_tlsctx_notify_close  // 0x100
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_tunitytls_tlsctx_free  // 0x108
  public            Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_tunitytls_random_generate_bytes  // 0x110
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Operation
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationNone  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationHandshake  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationAuthenticated  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationRenegotiate  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationRead  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationWrite  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationClose  // 0x0
METHODS:
END_CLASS

CLASS: OperationType
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationTypeRead  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationTypeWrite  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationTypeRenegotiate  // 0x0
  public    static  Mono.Net.Security.MobileAuthenticatedStream.OperationTypeShutdown  // 0x0
METHODS:
END_CLASS

CLASS: BoringBioHandle
TYPE:  class
TOKEN: 0x2000069
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: ControlCommand
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsBioMono.ControlCommandFlush  // 0x0
METHODS:
END_CLASS

CLASS: BioReadFunc
TYPE:  class
TOKEN: 0x200006E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr bio, System.IntPtr data, System.Int32 dataLength, System.Int32& wantMore)
END_CLASS

CLASS: BioWriteFunc
TYPE:  class
TOKEN: 0x200006F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr bio, System.IntPtr data, System.Int32 dataLength)
END_CLASS

CLASS: BioControlFunc
TYPE:  class
TOKEN: 0x2000070
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int64 Invoke(System.IntPtr bio, Mono.Btls.MonoBtlsBioMono.ControlCommand command, System.Int64 arg)
END_CLASS

CLASS: BoringKeyHandle
TYPE:  class
TOKEN: 0x2000075
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: MonoBtlsHandle
TYPE:  class
TOKEN: 0x2000077
EXTENDS: SafeHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle, System.Boolean ownsHandle)
  System.Boolean get_IsInvalid()
END_CLASS

CLASS: BoringPkcs12Handle
TYPE:  class
TOKEN: 0x2000079
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BoringSslHandle
TYPE:  class
TOKEN: 0x200007F
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: PrintErrorsCallbackFunc
TYPE:  class
TOKEN: 0x2000080
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr str, System.IntPtr len, System.IntPtr ctx)
END_CLASS

CLASS: BoringSslCtxHandle
TYPE:  class
TOKEN: 0x2000082
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: NativeVerifyFunc
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr instance, System.Int32 preverify_ok, System.IntPtr ctx)
END_CLASS

CLASS: NativeSelectFunc
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr instance, System.Int32 count, System.IntPtr sizes, System.IntPtr data)
END_CLASS

CLASS: NativeServerNameFunc
TYPE:  class
TOKEN: 0x2000085
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr instance)
END_CLASS

CLASS: BoringX509Handle
TYPE:  class
TOKEN: 0x200008B
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
  System.IntPtr StealHandle()
END_CLASS

CLASS: BoringX509ChainHandle
TYPE:  class
TOKEN: 0x200008D
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BoringX509LookupHandle
TYPE:  class
TOKEN: 0x2000092
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BoringX509LookupMonoHandle
TYPE:  class
TOKEN: 0x2000094
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BySubjectFunc
TYPE:  class
TOKEN: 0x2000095
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr instance, System.IntPtr name, System.IntPtr& x509_ptr)
END_CLASS

CLASS: BoringX509NameHandle
TYPE:  class
TOKEN: 0x2000099
EXTENDS: MonoBtlsHandle
FIELDS:
  private           System.Boolean                  dontFree  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr handle, System.Boolean ownsHandle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BoringX509StoreHandle
TYPE:  class
TOKEN: 0x200009C
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BoringX509StoreCtxHandle
TYPE:  class
TOKEN: 0x200009E
EXTENDS: MonoBtlsHandle
FIELDS:
  private           System.Boolean                  dontFree  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr handle, System.Boolean ownsHandle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: BoringX509VerifyParamHandle
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: MonoBtlsHandle
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: AlgorithmIdentifier
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  private           System.String                   AlgorithmId  // 0x10
  private           System.Byte[]                   Parameters  // 0x18
METHODS:
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            System.UInt64                   value__  // 0x10
  public    static  System.Uri.Flags                Zero  // 0x0
  public    static  System.Uri.Flags                SchemeNotCanonical  // 0x0
  public    static  System.Uri.Flags                UserNotCanonical  // 0x0
  public    static  System.Uri.Flags                HostNotCanonical  // 0x0
  public    static  System.Uri.Flags                PortNotCanonical  // 0x0
  public    static  System.Uri.Flags                PathNotCanonical  // 0x0
  public    static  System.Uri.Flags                QueryNotCanonical  // 0x0
  public    static  System.Uri.Flags                FragmentNotCanonical  // 0x0
  public    static  System.Uri.Flags                CannotDisplayCanonical  // 0x0
  public    static  System.Uri.Flags                E_UserNotCanonical  // 0x0
  public    static  System.Uri.Flags                E_HostNotCanonical  // 0x0
  public    static  System.Uri.Flags                E_PortNotCanonical  // 0x0
  public    static  System.Uri.Flags                E_PathNotCanonical  // 0x0
  public    static  System.Uri.Flags                E_QueryNotCanonical  // 0x0
  public    static  System.Uri.Flags                E_FragmentNotCanonical  // 0x0
  public    static  System.Uri.Flags                E_CannotDisplayCanonical  // 0x0
  public    static  System.Uri.Flags                ShouldBeCompressed  // 0x0
  public    static  System.Uri.Flags                FirstSlashAbsent  // 0x0
  public    static  System.Uri.Flags                BackslashInPath  // 0x0
  public    static  System.Uri.Flags                IndexMask  // 0x0
  public    static  System.Uri.Flags                HostTypeMask  // 0x0
  public    static  System.Uri.Flags                HostNotParsed  // 0x0
  public    static  System.Uri.Flags                IPv6HostType  // 0x0
  public    static  System.Uri.Flags                IPv4HostType  // 0x0
  public    static  System.Uri.Flags                DnsHostType  // 0x0
  public    static  System.Uri.Flags                UncHostType  // 0x0
  public    static  System.Uri.Flags                BasicHostType  // 0x0
  public    static  System.Uri.Flags                UnusedHostType  // 0x0
  public    static  System.Uri.Flags                UnknownHostType  // 0x0
  public    static  System.Uri.Flags                UserEscaped  // 0x0
  public    static  System.Uri.Flags                AuthorityFound  // 0x0
  public    static  System.Uri.Flags                HasUserInfo  // 0x0
  public    static  System.Uri.Flags                LoopbackHost  // 0x0
  public    static  System.Uri.Flags                NotDefaultPort  // 0x0
  public    static  System.Uri.Flags                UserDrivenParsing  // 0x0
  public    static  System.Uri.Flags                CanonicalDnsHost  // 0x0
  public    static  System.Uri.Flags                ErrorOrParsingRecursion  // 0x0
  public    static  System.Uri.Flags                DosPath  // 0x0
  public    static  System.Uri.Flags                UncPath  // 0x0
  public    static  System.Uri.Flags                ImplicitFile  // 0x0
  public    static  System.Uri.Flags                MinimalUriInfoSet  // 0x0
  public    static  System.Uri.Flags                AllUriInfoSet  // 0x0
  public    static  System.Uri.Flags                IdnHost  // 0x0
  public    static  System.Uri.Flags                HasUnicode  // 0x0
  public    static  System.Uri.Flags                HostUnicodeNormalized  // 0x0
  public    static  System.Uri.Flags                RestUnicodeNormalized  // 0x0
  public    static  System.Uri.Flags                UnicodeHost  // 0x0
  public    static  System.Uri.Flags                IntranetUri  // 0x0
  public    static  System.Uri.Flags                UseOrigUncdStrOffset  // 0x0
  public    static  System.Uri.Flags                UserIriCanonical  // 0x0
  public    static  System.Uri.Flags                PathIriCanonical  // 0x0
  public    static  System.Uri.Flags                QueryIriCanonical  // 0x0
  public    static  System.Uri.Flags                FragmentIriCanonical  // 0x0
  public    static  System.Uri.Flags                IriCanonical  // 0x0
  public    static  System.Uri.Flags                CompressedSlashes  // 0x0
METHODS:
END_CLASS

CLASS: UriInfo
TYPE:  class
TOKEN: 0x20000BA
FIELDS:
  public            System.String                   Host  // 0x10
  public            System.String                   ScopeId  // 0x18
  public            System.String                   String  // 0x20
  public            System.Uri.Offset               Offset  // 0x28
  public            System.String                   DnsSafeHost  // 0x38
  public            System.Uri.MoreInfo             MoreInfo  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Offset
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.UInt16                   Scheme  // 0x10
  public            System.UInt16                   User  // 0x12
  public            System.UInt16                   Host  // 0x14
  public            System.UInt16                   PortValue  // 0x16
  public            System.UInt16                   Path  // 0x18
  public            System.UInt16                   Query  // 0x1A
  public            System.UInt16                   Fragment  // 0x1C
  public            System.UInt16                   End  // 0x1E
METHODS:
END_CLASS

CLASS: MoreInfo
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  public            System.String                   Path  // 0x10
  public            System.String                   Query  // 0x18
  public            System.String                   Fragment  // 0x20
  public            System.String                   AbsoluteUri  // 0x28
  public            System.Int32                    Hash  // 0x30
  public            System.String                   RemoteUrl  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Check
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Uri.Check                None  // 0x0
  public    static  System.Uri.Check                EscapedCanonical  // 0x0
  public    static  System.Uri.Check                DisplayCanonical  // 0x0
  public    static  System.Uri.Check                DotSlashAttn  // 0x0
  public    static  System.Uri.Check                DotSlashEscaped  // 0x0
  public    static  System.Uri.Check                BackslashInPath  // 0x0
  public    static  System.Uri.Check                ReservedFound  // 0x0
  public    static  System.Uri.Check                NotIriCanonical  // 0x0
  public    static  System.Uri.Check                FoundNonAscii  // 0x0
METHODS:
END_CLASS

CLASS: UriQuirksVersion
TYPE:  struct
TOKEN: 0x20000C8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriParser.UriQuirksVersionV2  // 0x0
  public    static  System.UriParser.UriQuirksVersionV3  // 0x0
METHODS:
END_CLASS

CLASS: BuiltInUriParser
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: UriParser
FIELDS:
METHODS:
  System.Void .ctor(System.String lwrCaseScheme, System.Int32 defaultPort, System.UriSyntaxFlags syntaxFlags)
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x20000D6
FIELDS:
  private   readonly System.Text.RegularExpressions.CaptureCollection_collection  // 0x10
  private           System.Int32                    _index  // 0x18
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.CaptureCollection collection)
  System.Boolean MoveNext()
  System.Text.RegularExpressions.Capture get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x20000DA
FIELDS:
  private   readonly System.Text.RegularExpressions.GroupCollection_collection  // 0x10
  private           System.Int32                    _index  // 0x18
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.GroupCollection collection)
  System.Boolean MoveNext()
  System.Text.RegularExpressions.Group get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x20000DE
FIELDS:
  private   readonly System.Text.RegularExpressions.MatchCollection_collection  // 0x10
  private           System.Int32                    _index  // 0x18
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.MatchCollection collection)
  System.Boolean MoveNext()
  System.Text.RegularExpressions.Match get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: CachedCodeEntryKey
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  private   readonly System.Text.RegularExpressions.RegexOptions_options  // 0x10
  private   readonly System.String                   _cultureKey  // 0x18
  private   readonly System.String                   _pattern  // 0x20
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.RegexOptions options, System.String cultureKey, System.String pattern)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other)
  System.Boolean op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right)
  System.Int32 GetHashCode()
END_CLASS

CLASS: CachedCodeEntry
TYPE:  class
TOKEN: 0x20000E2
FIELDS:
  public            System.Text.RegularExpressions.Regex.CachedCodeEntryNext  // 0x10
  public            System.Text.RegularExpressions.Regex.CachedCodeEntryPrevious  // 0x18
  public    readonly System.Text.RegularExpressions.Regex.CachedCodeEntryKeyKey  // 0x20
  public            System.Text.RegularExpressions.RegexCodeCode  // 0x38
  public    readonly System.Collections.Hashtable    Caps  // 0x40
  public    readonly System.Collections.Hashtable    Capnames  // 0x48
  public    readonly System.String[]                 Capslist  // 0x50
  public    readonly System.Int32                    Capsize  // 0x58
  public    readonly System.Text.RegularExpressions.ExclusiveReferenceRunnerref  // 0x60
  public    readonly System.WeakReference<System.Text.RegularExpressions.RegexReplacement>ReplRef  // 0x68
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, System.String[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, System.Int32 capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref)
END_CLASS

CLASS: LowerCaseMapping
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public    readonly System.Char                     ChMin  // 0x10
  public    readonly System.Char                     ChMax  // 0x12
  public    readonly System.Int32                    LcOp  // 0x14
  public    readonly System.Int32                    Data  // 0x18
METHODS:
  System.Void .ctor(System.Char chMin, System.Char chMax, System.Int32 lcOp, System.Int32 data)
END_CLASS

CLASS: SingleRangeComparer
TYPE:  class
TOKEN: 0x20000E7
FIELDS:
  public    static readonly System.Text.RegularExpressions.RegexCharClass.SingleRangeComparerInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y)
  System.Void .cctor()
END_CLASS

CLASS: SingleRange
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  public    readonly System.Char                     First  // 0x10
  public    readonly System.Char                     Last  // 0x12
METHODS:
  System.Void .ctor(System.Char first, System.Char last)
END_CLASS

CLASS: StreamReadMode
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Diagnostics.Process.StreamReadModeundefined  // 0x0
  public    static  System.Diagnostics.Process.StreamReadModesyncMode  // 0x0
  public    static  System.Diagnostics.Process.StreamReadModeasyncMode  // 0x0
METHODS:
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Diagnostics.Process.StateHaveId  // 0x0
  public    static  System.Diagnostics.Process.StateIsLocal  // 0x0
  public    static  System.Diagnostics.Process.StateIsNt  // 0x0
  public    static  System.Diagnostics.Process.StateHaveProcessInfo  // 0x0
  public    static  System.Diagnostics.Process.StateExited  // 0x0
  public    static  System.Diagnostics.Process.StateAssociated  // 0x0
  public    static  System.Diagnostics.Process.StateIsWin2k  // 0x0
  public    static  System.Diagnostics.Process.StateHaveNtProcessInfo  // 0x0
METHODS:
END_CLASS

CLASS: ProcInfo
TYPE:  struct
TOKEN: 0x2000101
FIELDS:
  public            System.IntPtr                   process_handle  // 0x10
  public            System.Int32                    pid  // 0x18
  public            System.String[]                 envVariables  // 0x20
  public            System.String                   UserName  // 0x28
  public            System.String                   Domain  // 0x30
  public            System.IntPtr                   Password  // 0x38
  public            System.Boolean                  LoadUserProfile  // 0x40
METHODS:
END_CLASS

CLASS: DerTag
TYPE:  struct
TOKEN: 0x200010E
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagBoolean  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagInteger  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagBitString  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagOctetString  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagNull  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagObjectIdentifier  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagUTF8String  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagSequence  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagSet  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagPrintableString  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagT61String  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagIA5String  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagUTCTime  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagGeneralizedTime  // 0x0
  public    static  System.Security.Cryptography.DerSequenceReader.DerTagBMPString  // 0x0
METHODS:
END_CLASS

CLASS: X509CertificateEnumerator
TYPE:  class
TOKEN: 0x200012C
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings)
  System.Security.Cryptography.X509Certificates.X509Certificate get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
  System.Boolean MoveNext()
END_CLASS

CLASS: StateFlags
TYPE:  struct
TOKEN: 0x200013F
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Net.ContextAwareResult.StateFlagsNone  // 0x0
  public    static  System.Net.ContextAwareResult.StateFlagsCaptureIdentity  // 0x0
  public    static  System.Net.ContextAwareResult.StateFlagsCaptureContext  // 0x0
  public    static  System.Net.ContextAwareResult.StateFlagsThreadSafeContextCopy  // 0x0
  public    static  System.Net.ContextAwareResult.StateFlagsPostBlockStarted  // 0x0
  public    static  System.Net.ContextAwareResult.StateFlagsPostBlockFinished  // 0x0
METHODS:
END_CLASS

CLASS: Keywords
TYPE:  class
TOKEN: 0x2000144
FIELDS:
  public    static  System.Diagnostics.Tracing.EventKeywordsDefault  // 0x0
  public    static  System.Diagnostics.Tracing.EventKeywordsDebug  // 0x0
  public    static  System.Diagnostics.Tracing.EventKeywordsEnterExit  // 0x0
METHODS:
END_CLASS

CLASS: ReadOnlyIPAddress
TYPE:  class
TOKEN: 0x200014A
EXTENDS: IPAddress
FIELDS:
METHODS:
  System.Void .ctor(System.Int64 newAddress)
END_CLASS

CLASS: PipelineInstruction
TYPE:  struct
TOKEN: 0x200014E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.CommandStream.PipelineInstructionAbort  // 0x0
  public    static  System.Net.CommandStream.PipelineInstructionAdvance  // 0x0
  public    static  System.Net.CommandStream.PipelineInstructionPause  // 0x0
  public    static  System.Net.CommandStream.PipelineInstructionReread  // 0x0
  public    static  System.Net.CommandStream.PipelineInstructionGiveStream  // 0x0
METHODS:
END_CLASS

CLASS: PipelineEntryFlags
TYPE:  struct
TOKEN: 0x200014F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.CommandStream.PipelineEntryFlagsUserCommand  // 0x0
  public    static  System.Net.CommandStream.PipelineEntryFlagsGiveDataStream  // 0x0
  public    static  System.Net.CommandStream.PipelineEntryFlagsCreateDataConnection  // 0x0
  public    static  System.Net.CommandStream.PipelineEntryFlagsDontLogParameter  // 0x0
METHODS:
END_CLASS

CLASS: PipelineEntry
TYPE:  class
TOKEN: 0x2000150
FIELDS:
  private           System.String                   Command  // 0x10
  private           System.Net.CommandStream.PipelineEntryFlagsFlags  // 0x18
METHODS:
  System.Void .ctor(System.String command)
  System.Void .ctor(System.String command, System.Net.CommandStream.PipelineEntryFlags flags)
  System.Boolean HasFlag(System.Net.CommandStream.PipelineEntryFlags flags)
END_CLASS

CLASS: GetPathOption
TYPE:  struct
TOKEN: 0x2000155
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.FtpControlStream.GetPathOptionNormal  // 0x0
  public    static  System.Net.FtpControlStream.GetPathOptionAssumeFilename  // 0x0
  public    static  System.Net.FtpControlStream.GetPathOptionAssumeNoFilename  // 0x0
METHODS:
END_CLASS

CLASS: RequestStage
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.FtpWebRequest.RequestStageCheckForError  // 0x0
  public    static  System.Net.FtpWebRequest.RequestStageRequestStarted  // 0x0
  public    static  System.Net.FtpWebRequest.RequestStageWriteReady  // 0x0
  public    static  System.Net.FtpWebRequest.RequestStageReadReady  // 0x0
  public    static  System.Net.FtpWebRequest.RequestStageReleaseConnection  // 0x0
METHODS:
END_CLASS

CLASS: EmptyStream
TYPE:  class
TOKEN: 0x2000161
EXTENDS: MemoryStream
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: RfcChar
TYPE:  struct
TOKEN: 0x2000181
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Net.WebHeaderCollection.RfcCharHigh  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharReg  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharCtl  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharCR  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharLF  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharWS  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharColon  // 0x0
  public    static  System.Net.WebHeaderCollection.RfcCharDelim  // 0x0
METHODS:
END_CLASS

CLASS: DesignerWebRequestCreate
TYPE:  class
TOKEN: 0x2000184
FIELDS:
METHODS:
  System.Net.WebRequest Create(System.Uri uri)
  System.Void .ctor()
END_CLASS

CLASS: ThreadContext
TYPE:  class
TOKEN: 0x200018F
FIELDS:
  private           System.Int32                    m_NestedIOCount  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Queue
TYPE:  class
TOKEN: 0x2000192
FIELDS:
  private   readonly System.Int32                    m_DurationMilliseconds  // 0x10
METHODS:
  System.Void .ctor(System.Int32 durationMilliseconds)
  System.Int32 get_Duration()
  System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, System.Object context)
END_CLASS

CLASS: Timer
TYPE:  class
TOKEN: 0x2000193
FIELDS:
  private   readonly System.Int32                    m_StartTimeMilliseconds  // 0x10
  private   readonly System.Int32                    m_DurationMilliseconds  // 0x14
METHODS:
  System.Void .ctor(System.Int32 durationMilliseconds)
  System.Int32 get_StartTime()
  System.Int32 get_Expiration()
  System.Boolean Cancel()
  System.Boolean get_HasExpired()
  System.Void Dispose()
END_CLASS

CLASS: Callback
TYPE:  class
TOKEN: 0x2000194
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Net.TimerThread.Timer timer, System.Int32 timeNoticed, System.Object context)
END_CLASS

CLASS: TimerQueue
TYPE:  class
TOKEN: 0x2000195
EXTENDS: Queue
FIELDS:
  private           System.IntPtr                   m_ThisHandle  // 0x18
  private   readonly System.Net.TimerThread.TimerNodem_Timers  // 0x20
METHODS:
  System.Void .ctor(System.Int32 durationMilliseconds)
  System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, System.Object context)
  System.Boolean Fire(System.Int32& nextExpiration)
END_CLASS

CLASS: InfiniteTimerQueue
TYPE:  class
TOKEN: 0x2000196
EXTENDS: Queue
FIELDS:
METHODS:
  System.Void .ctor()
  System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, System.Object context)
END_CLASS

CLASS: TimerState
TYPE:  struct
TOKEN: 0x2000198
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.TimerThread.TimerNode.TimerStateReady  // 0x0
  public    static  System.Net.TimerThread.TimerNode.TimerStateFired  // 0x0
  public    static  System.Net.TimerThread.TimerNode.TimerStateCancelled  // 0x0
  public    static  System.Net.TimerThread.TimerNode.TimerStateSentinel  // 0x0
METHODS:
END_CLASS

CLASS: TimerNode
TYPE:  class
TOKEN: 0x2000197
EXTENDS: Timer
FIELDS:
  private           System.Net.TimerThread.TimerNode.TimerStatem_TimerState  // 0x18
  private           System.Net.TimerThread.Callback m_Callback  // 0x20
  private           System.Object                   m_Context  // 0x28
  private           System.Object                   m_QueueLock  // 0x30
  private           System.Net.TimerThread.TimerNodenext  // 0x38
  private           System.Net.TimerThread.TimerNodeprev  // 0x40
METHODS:
  System.Void .ctor(System.Net.TimerThread.Callback callback, System.Object context, System.Int32 durationMilliseconds, System.Object queueLock)
  System.Void .ctor()
  System.Boolean get_HasExpired()
  System.Net.TimerThread.TimerNode get_Next()
  System.Void set_Next(System.Net.TimerThread.TimerNode value)
  System.Net.TimerThread.TimerNode get_Prev()
  System.Void set_Prev(System.Net.TimerThread.TimerNode value)
  System.Boolean Cancel()
  System.Boolean Fire()
END_CLASS

CLASS: InfiniteTimer
TYPE:  class
TOKEN: 0x2000199
EXTENDS: Timer
FIELDS:
  private           System.Int32                    cancelled  // 0x18
METHODS:
  System.Void .ctor()
  System.Boolean get_HasExpired()
  System.Boolean Cancel()
END_CLASS

CLASS: RecognizedAttribute
TYPE:  struct
TOKEN: 0x200019E
FIELDS:
  private           System.String                   m_name  // 0x10
  private           System.Net.CookieToken          m_token  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.Net.CookieToken token)
  System.Net.CookieToken get_Token()
  System.Boolean IsEqualTo(System.String value)
END_CLASS

CLASS: Stamp
TYPE:  struct
TOKEN: 0x20001A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.CookieCollection.StampCheck  // 0x0
  public    static  System.Net.CookieCollection.StampSet  // 0x0
  public    static  System.Net.CookieCollection.StampSetToUnused  // 0x0
  public    static  System.Net.CookieCollection.StampSetToMaxUsed  // 0x0
METHODS:
END_CLASS

CLASS: CookieCollectionEnumerator
TYPE:  class
TOKEN: 0x20001A3
FIELDS:
  private           System.Net.CookieCollection     m_cookies  // 0x10
  private           System.Int32                    m_count  // 0x18
  private           System.Int32                    m_index  // 0x1C
  private           System.Int32                    m_version  // 0x20
METHODS:
  System.Void .ctor(System.Net.CookieCollection cookies)
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: PathListComparer
TYPE:  class
TOKEN: 0x20001A7
FIELDS:
  private   static readonly System.Net.PathList.PathListComparerStaticInstance  // 0x0
METHODS:
  System.Int32 System.Collections.IComparer.Compare(System.Object ol, System.Object or)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: HTTP_REQUEST_HEADER_ID
TYPE:  class
TOKEN: 0x20001B2
FIELDS:
  private   static  System.String[]                 m_Strings  // 0x0
METHODS:
  System.String ToString(System.Int32 position)
  System.Void .cctor()
END_CLASS

CLASS: HttpApi
TYPE:  class
TOKEN: 0x20001B1
FIELDS:
  private   static  System.String[]                 m_Strings  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: SecureStringHelper
TYPE:  class
TOKEN: 0x20001B3
FIELDS:
METHODS:
  System.String CreateString(System.Security.SecureString secureString)
  System.Security.SecureString CreateSecureString(System.String plainString)
END_CLASS

CLASS: CallbackContext
TYPE:  class
TOKEN: 0x20001B6
FIELDS:
  private   readonly System.Object                   request  // 0x10
  private   readonly System.Security.Cryptography.X509Certificates.X509Certificatecertificate  // 0x18
  private   readonly System.Security.Cryptography.X509Certificates.X509Chainchain  // 0x20
  private   readonly System.Net.Security.SslPolicyErrorssslPolicyErrors  // 0x28
  private           System.Boolean                  result  // 0x2C
METHODS:
  System.Void .ctor(System.Object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x20001BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.ContentDecodeStream.ModeGZip  // 0x0
  public    static  System.Net.ContentDecodeStream.ModeDeflate  // 0x0
METHODS:
END_CLASS

CLASS: GetHostAddressesCallback
TYPE:  class
TOKEN: 0x20001C4
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Net.IPAddress[] Invoke(System.String hostName)
  System.IAsyncResult BeginInvoke(System.String hostName, System.AsyncCallback callback, System.Object object)
  System.Net.IPAddress[] EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: NtlmAuthState
TYPE:  struct
TOKEN: 0x20001C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.HttpWebRequest.NtlmAuthStateNone  // 0x0
  public    static  System.Net.HttpWebRequest.NtlmAuthStateChallenge  // 0x0
  public    static  System.Net.HttpWebRequest.NtlmAuthStateResponse  // 0x0
METHODS:
END_CLASS

CLASS: AuthorizationState
TYPE:  struct
TOKEN: 0x20001CA
FIELDS:
  private   readonly System.Net.HttpWebRequest       request  // 0x10
  private   readonly System.Boolean                  isProxy  // 0x18
  private           System.Boolean                  isCompleted  // 0x19
  private           System.Net.HttpWebRequest.NtlmAuthStatentlm_auth_state  // 0x1C
METHODS:
  System.Boolean get_IsCompleted()
  System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState()
  System.Boolean get_IsNtlmAuthenticated()
  System.Void .ctor(System.Net.HttpWebRequest request, System.Boolean isProxy)
  System.Boolean CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code)
  System.Void Reset()
  System.String ToString()
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x20001D3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.MonoChunkParser.StateNone  // 0x0
  public    static  System.Net.MonoChunkParser.StatePartialSize  // 0x0
  public    static  System.Net.MonoChunkParser.StateBody  // 0x0
  public    static  System.Net.MonoChunkParser.StateBodyFinished  // 0x0
  public    static  System.Net.MonoChunkParser.StateTrailer  // 0x0
METHODS:
END_CLASS

CLASS: Chunk
TYPE:  class
TOKEN: 0x20001D4
FIELDS:
  public            System.Byte[]                   Bytes  // 0x10
  public            System.Int32                    Offset  // 0x18
METHODS:
  System.Void .ctor(System.Byte[] chunk)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
END_CLASS

CLASS: SPKey
TYPE:  class
TOKEN: 0x20001DB
FIELDS:
  private           System.Uri                      uri  // 0x10
  private           System.Uri                      proxy  // 0x18
  private           System.Boolean                  use_connect  // 0x20
METHODS:
  System.Void .ctor(System.Uri uri, System.Uri proxy, System.Boolean use_connect)
  System.Boolean get_UsesProxy()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: ConnectionGroup
TYPE:  class
TOKEN: 0x20001DD
FIELDS:
  private   readonly System.Net.ServicePointScheduler<Scheduler>k__BackingField  // 0x10
  private   readonly System.String                   <Name>k__BackingField  // 0x18
  private   static  System.Int32                    nextId  // 0x0
  public    readonly System.Int32                    ID  // 0x20
  private           System.Collections.Generic.LinkedList<System.Net.WebConnection>connections  // 0x28
  private           System.Collections.Generic.LinkedList<System.Net.WebOperation>queue  // 0x30
METHODS:
  System.Net.ServicePointScheduler get_Scheduler()
  System.Void .ctor(System.Net.ServicePointScheduler scheduler, System.String name)
  System.Boolean IsEmpty()
  System.Void RemoveConnection(System.Net.WebConnection connection)
  System.Void Cleanup()
  System.Void Close()
  System.Void EnqueueOperation(System.Net.WebOperation operation)
  System.Net.WebOperation GetNextOperation()
  System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation)
  System.ValueTuple<System.Net.WebConnection,System.Boolean> CreateOrReuseConnection(System.Net.WebOperation operation, System.Boolean force)
END_CLASS

CLASS: AsyncManualResetEvent
TYPE:  class
TOKEN: 0x20001DE
FIELDS:
  private           System.Threading.Tasks.TaskCompletionSource<System.Boolean>m_tcs  // 0x10
METHODS:
  System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Int32 millisecondTimeout)
  System.Void Set()
  System.Void Reset()
  System.Void .ctor(System.Boolean state)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20001E3
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  System.Net.WebCompletionSource.Status<T>Running  // 0x0
  public    static  System.Net.WebCompletionSource.Status<T>Completed  // 0x0
  public    static  System.Net.WebCompletionSource.Status<T>Canceled  // 0x0
  public    static  System.Net.WebCompletionSource.Status<T>Faulted  // 0x0
METHODS:
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x20001E4
FIELDS:
  private   readonly System.Net.WebCompletionSource.Status<T><Status>k__BackingField  // 0x0
  private   readonly System.Runtime.ExceptionServices.ExceptionDispatchInfo<Error>k__BackingField  // 0x0
  private   readonly T                               <Argument>k__BackingField  // 0x0
METHODS:
  System.Net.WebCompletionSource.Status<T> get_Status()
  System.Boolean get_Success()
  System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error()
  T get_Argument()
  System.Void .ctor(T argument)
  System.Void .ctor(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error)
END_CLASS

CLASS: NtlmAuthState
TYPE:  struct
TOKEN: 0x20001EF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebConnectionTunnel.NtlmAuthStateNone  // 0x0
  public    static  System.Net.WebConnectionTunnel.NtlmAuthStateChallenge  // 0x0
  public    static  System.Net.WebConnectionTunnel.NtlmAuthStateResponse  // 0x0
METHODS:
END_CLASS

CLASS: CachedEventArgs
TYPE:  class
TOKEN: 0x2000239
FIELDS:
  public            System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket>TaskAccept  // 0x10
  public            System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgsTaskReceive  // 0x18
  public            System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgsTaskSend  // 0x20
  public            System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgsValueTaskReceive  // 0x28
  public            System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgsValueTaskSend  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TaskSocketAsyncEventArgs`1
TYPE:  class
TOKEN: 0x200023A
EXTENDS: SocketAsyncEventArgs
FIELDS:
  private           System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>_builder  // 0x0
  private           System.Boolean                  _accessed  // 0x0
METHODS:
  System.Void .ctor()
  System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(System.Boolean& responsibleForReturningToPool)
END_CLASS

CLASS: Int32TaskSocketAsyncEventArgs
TYPE:  class
TOKEN: 0x200023B
EXTENDS: TaskSocketAsyncEventArgs`1
FIELDS:
  private           System.Boolean                  _wrapExceptionsInIOExceptions  // 0xA0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AwaitableSocketAsyncEventArgs
TYPE:  class
TOKEN: 0x200023C
EXTENDS: SocketAsyncEventArgs
FIELDS:
  private   static readonly System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgsReserved  // 0x0
  private   static readonly System.Action<System.Object>    s_completedSentinel  // 0x8
  private   static readonly System.Action<System.Object>    s_availableSentinel  // 0x10
  private           System.Action<System.Object>    _continuation  // 0x80
  private           System.Threading.ExecutionContext_executionContext  // 0x88
  private           System.Object                   _scheduler  // 0x90
  private           System.Int16                    _token  // 0x98
  private           System.Boolean                  <WrapExceptionsInIOExceptions>k__BackingField  // 0x9A
METHODS:
  System.Void .ctor()
  System.Boolean get_WrapExceptionsInIOExceptions()
  System.Void set_WrapExceptionsInIOExceptions(System.Boolean value)
  System.Boolean Reserve()
  System.Void Release()
  System.Void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _)
  System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Net.Sockets.Socket socket)
  System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket)
  System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(System.Int16 token)
  System.Void OnCompleted(System.Action<System.Object> continuation, System.Object state, System.Int16 token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags)
  System.Void InvokeContinuation(System.Action<System.Object> continuation, System.Object state, System.Boolean forceAsync)
  System.Int32 GetResult(System.Int16 token)
  System.Void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(System.Int16 token)
  System.Void ThrowIncorrectTokenException()
  System.Void ThrowMultipleContinuationsException()
  System.Void ThrowException(System.Net.Sockets.SocketError error)
  System.Exception CreateException(System.Net.Sockets.SocketError error)
  System.Void .cctor()
END_CLASS

CLASS: WSABUF
TYPE:  struct
TOKEN: 0x200023E
FIELDS:
  public            System.Int32                    len  // 0x10
  public            System.IntPtr                   buf  // 0x18
METHODS:
END_CLASS

CLASS: Utf8MessageState
TYPE:  class
TOKEN: 0x200025A
FIELDS:
  private           System.Boolean                  SequenceInProgress  // 0x10
  private           System.Int32                    AdditionalBytesExpected  // 0x14
  private           System.Int32                    ExpectedValueMin  // 0x18
  private           System.Int32                    CurrentDecodeBits  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MessageOpcode
TYPE:  struct
TOKEN: 0x200025B
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Net.WebSockets.ManagedWebSocket.MessageOpcodeContinuation  // 0x0
  public    static  System.Net.WebSockets.ManagedWebSocket.MessageOpcodeText  // 0x0
  public    static  System.Net.WebSockets.ManagedWebSocket.MessageOpcodeBinary  // 0x0
  public    static  System.Net.WebSockets.ManagedWebSocket.MessageOpcodeClose  // 0x0
  public    static  System.Net.WebSockets.ManagedWebSocket.MessageOpcodePing  // 0x0
  public    static  System.Net.WebSockets.ManagedWebSocket.MessageOpcodePong  // 0x0
METHODS:
END_CLASS

CLASS: MessageHeader
TYPE:  struct
TOKEN: 0x200025C
FIELDS:
  private           System.Net.WebSockets.ManagedWebSocket.MessageOpcodeOpcode  // 0x10
  private           System.Boolean                  Fin  // 0x11
  private           System.Int64                    PayloadLength  // 0x18
  private           System.Int32                    Mask  // 0x20
METHODS:
END_CLASS

CLASS: IWebSocketReceiveResultGetter`1
TYPE:  interface
TOKEN: 0x200025D
FIELDS:
METHODS:
  TResult GetResult(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, System.String closeDescription)
END_CLASS

CLASS: WebSocketReceiveResultGetter
TYPE:  struct
TOKEN: 0x200025E
FIELDS:
METHODS:
  System.Net.WebSockets.WebSocketReceiveResult GetResult(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, System.String closeDescription)
END_CLASS

CLASS: InternalState
TYPE:  struct
TOKEN: 0x200026C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebSockets.ClientWebSocket.InternalStateCreated  // 0x0
  public    static  System.Net.WebSockets.ClientWebSocket.InternalStateConnecting  // 0x0
  public    static  System.Net.WebSockets.ClientWebSocket.InternalStateConnected  // 0x0
  public    static  System.Net.WebSockets.ClientWebSocket.InternalStateDisposed  // 0x0
METHODS:
END_CLASS

CLASS: DefaultWebProxy
TYPE:  class
TOKEN: 0x200026D
FIELDS:
  private   static readonly System.Net.WebSockets.ClientWebSocket.DefaultWebProxy<Instance>k__BackingField  // 0x0
METHODS:
  System.Net.WebSockets.ClientWebSocket.DefaultWebProxy get_Instance()
  System.Net.ICredentials get_Credentials()
  System.Uri GetProxy(System.Uri destination)
  System.Boolean IsBypassed(System.Uri host)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: ListEntry
TYPE:  class
TOKEN: 0x200029F
FIELDS:
  private           System.ComponentModel.EventHandlerList.ListEntry_next  // 0x10
  private           System.Object                   _key  // 0x18
  private           System.Delegate                 _handler  // 0x20
METHODS:
END_CLASS

CLASS: ArrayPropertyDescriptor
TYPE:  class
TOKEN: 0x20002A7
EXTENDS: SimplePropertyDescriptor
FIELDS:
  private   readonly System.Int32                    _index  // 0x98
METHODS:
  System.Void .ctor(System.Type arrayType, System.Type elementType, System.Int32 index)
  System.Object GetValue(System.Object instance)
  System.Void SetValue(System.Object instance, System.Object value)
END_CLASS

CLASS: AttributeEntry
TYPE:  struct
TOKEN: 0x20002A9
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Int32                    index  // 0x18
METHODS:
END_CLASS

CLASS: CultureComparer
TYPE:  class
TOKEN: 0x20002B3
FIELDS:
  private           System.ComponentModel.CultureInfoConverter_converter  // 0x10
METHODS:
  System.Void .ctor(System.ComponentModel.CultureInfoConverter cultureConverter)
  System.Int32 Compare(System.Object item1, System.Object item2)
END_CLASS

CLASS: CultureInfoMapper
TYPE:  class
TOKEN: 0x20002B4
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_cultureInfoNameMap  // 0x0
METHODS:
  System.Collections.Generic.Dictionary<System.String,System.String> CreateMap()
  System.String GetCultureInfoName(System.String cultureInfoDisplayName)
  System.Void .cctor()
END_CLASS

CLASS: ArraySubsetEnumerator
TYPE:  class
TOKEN: 0x20002C1
FIELDS:
  private   readonly System.Array                    _array  // 0x10
  private   readonly System.Int32                    _total  // 0x18
  private           System.Int32                    _current  // 0x1C
METHODS:
  System.Void .ctor(System.Array array, System.Int32 count)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Object get_Current()
END_CLASS

CLASS: PropertyDescriptorEnumerator
TYPE:  class
TOKEN: 0x20002D6
FIELDS:
  private           System.ComponentModel.PropertyDescriptorCollection_owner  // 0x10
  private           System.Int32                    _index  // 0x18
METHODS:
  System.Void .ctor(System.ComponentModel.PropertyDescriptorCollection owner)
  System.Object get_Current()
  System.Collections.DictionaryEntry get_Entry()
  System.Object get_Key()
  System.Object get_Value()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: ReferenceComparer
TYPE:  class
TOKEN: 0x20002D9
FIELDS:
  private           System.ComponentModel.ReferenceConverter_converter  // 0x10
METHODS:
  System.Void .ctor(System.ComponentModel.ReferenceConverter converter)
  System.Int32 Compare(System.Object item1, System.Object item2)
END_CLASS

CLASS: EmptyCustomTypeDescriptor
TYPE:  class
TOKEN: 0x20002E3
EXTENDS: CustomTypeDescriptor
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ReflectedTypeData
TYPE:  class
TOKEN: 0x20002FA
FIELDS:
  private           System.Type                     _type  // 0x10
  private           System.ComponentModel.AttributeCollection_attributes  // 0x18
  private           System.ComponentModel.EventDescriptorCollection_events  // 0x20
  private           System.ComponentModel.PropertyDescriptorCollection_properties  // 0x28
  private           System.ComponentModel.TypeConverter_converter  // 0x30
  private           System.Object[]                 _editors  // 0x38
  private           System.Type[]                   _editorTypes  // 0x40
  private           System.Int32                    _editorCount  // 0x48
METHODS:
  System.Void .ctor(System.Type type)
  System.Boolean get_IsPopulated()
  System.ComponentModel.AttributeCollection GetAttributes()
  System.ComponentModel.TypeConverter GetConverter(System.Object instance)
  System.ComponentModel.PropertyDescriptorCollection GetProperties()
  System.Type GetTypeFromName(System.String typeName)
  System.Void Refresh()
END_CLASS

CLASS: SimplePropertyDescriptor
TYPE:  class
TOKEN: 0x20002FC
EXTENDS: PropertyDescriptor
FIELDS:
  private           System.Type                     componentType  // 0x88
  private           System.Type                     propertyType  // 0x90
METHODS:
  System.Void .ctor(System.Type componentType, System.String name, System.Type propertyType)
  System.Void .ctor(System.Type componentType, System.String name, System.Type propertyType, System.Attribute[] attributes)
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Boolean CanResetValue(System.Object component)
  System.Void ResetValue(System.Object component)
  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: StandardValuesCollection
TYPE:  class
TOKEN: 0x20002FD
FIELDS:
  private           System.Collections.ICollection  values  // 0x10
  private           System.Array                    valueArray  // 0x18
METHODS:
  System.Void .ctor(System.Collections.ICollection values)
  System.Int32 get_Count()
  System.Object get_Item(System.Int32 index)
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 System.Collections.ICollection.get_Count()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: AttributeFilterCacheItem
TYPE:  class
TOKEN: 0x20002FF
FIELDS:
  private           System.Attribute[]              _filter  // 0x10
  private           System.Collections.ICollection  FilteredMembers  // 0x18
METHODS:
  System.Void .ctor(System.Attribute[] filter, System.Collections.ICollection filteredMembers)
  System.Boolean IsValid(System.Attribute[] filter)
END_CLASS

CLASS: FilterCacheItem
TYPE:  class
TOKEN: 0x2000300
FIELDS:
  private           System.ComponentModel.Design.ITypeDescriptorFilterService_filterService  // 0x10
  private           System.Collections.ICollection  FilteredMembers  // 0x18
METHODS:
  System.Void .ctor(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers)
  System.Boolean IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService)
END_CLASS

CLASS: IUnimplemented
TYPE:  interface
TOKEN: 0x2000301
FIELDS:
METHODS:
END_CLASS

CLASS: MemberDescriptorComparer
TYPE:  class
TOKEN: 0x2000302
FIELDS:
  public    static readonly System.ComponentModel.TypeDescriptor.MemberDescriptorComparerInstance  // 0x0
METHODS:
  System.Int32 Compare(System.Object left, System.Object right)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: MergedTypeDescriptor
TYPE:  class
TOKEN: 0x2000303
FIELDS:
  private           System.ComponentModel.ICustomTypeDescriptor_primary  // 0x10
  private           System.ComponentModel.ICustomTypeDescriptor_secondary  // 0x18
METHODS:
  System.Void .ctor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary)
  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
END_CLASS

CLASS: DefaultExtendedTypeDescriptor
TYPE:  struct
TOKEN: 0x2000305
FIELDS:
  private           System.ComponentModel.TypeDescriptor.TypeDescriptionNode_node  // 0x10
  private           System.Object                   _instance  // 0x18
METHODS:
  System.Void .ctor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Object instance)
  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
END_CLASS

CLASS: DefaultTypeDescriptor
TYPE:  struct
TOKEN: 0x2000306
FIELDS:
  private           System.ComponentModel.TypeDescriptor.TypeDescriptionNode_node  // 0x10
  private           System.Type                     _objectType  // 0x18
  private           System.Object                   _instance  // 0x20
METHODS:
  System.Void .ctor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, System.Object instance)
  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
END_CLASS

CLASS: TypeDescriptionNode
TYPE:  class
TOKEN: 0x2000304
EXTENDS: TypeDescriptionProvider
FIELDS:
  private           System.ComponentModel.TypeDescriptor.TypeDescriptionNodeNext  // 0x20
  private           System.ComponentModel.TypeDescriptionProviderProvider  // 0x28
METHODS:
  System.Void .ctor(System.ComponentModel.TypeDescriptionProvider provider)
  System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args)
  System.Collections.IDictionary GetCache(System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance)
  System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance)
  System.Type GetReflectionType(System.Type objectType, System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance)
END_CLASS

CLASS: TypeDescriptorComObject
TYPE:  class
TOKEN: 0x2000307
FIELDS:
METHODS:
END_CLASS

CLASS: TypeDescriptorInterface
TYPE:  class
TOKEN: 0x2000308
FIELDS:
METHODS:
END_CLASS

CLASS: WeakKeyComparer
TYPE:  class
TOKEN: 0x200030E
FIELDS:
METHODS:
  System.Boolean System.Collections.IEqualityComparer.Equals(System.Object x, System.Object y)
  System.Int32 System.Collections.IEqualityComparer.GetHashCode(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: WrappedPropertyDescriptor
TYPE:  class
TOKEN: 0x2000319
EXTENDS: PropertyDescriptor
FIELDS:
  private           System.Object                   target  // 0x88
  private           System.ComponentModel.PropertyDescriptorproperty  // 0x90
METHODS:
  System.Void .ctor(System.ComponentModel.PropertyDescriptor property, System.Object target)
  System.ComponentModel.AttributeCollection get_Attributes()
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Boolean CanResetValue(System.Object component)
  System.Object GetValue(System.Object component)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: DesignerOptionCollection
TYPE:  class
TOKEN: 0x2000318
FIELDS:
  private           System.ComponentModel.Design.DesignerOptionService_service  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Object                   _value  // 0x20
  private           System.Collections.ArrayList    _children  // 0x28
  private           System.ComponentModel.PropertyDescriptorCollection_properties  // 0x30
METHODS:
  System.Int32 get_Count()
  System.String get_Name()
  System.ComponentModel.PropertyDescriptorCollection get_Properties()
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Void EnsurePopulated()
  System.Collections.IEnumerator GetEnumerator()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
END_CLASS

CLASS: OptionPropertyDescriptor
TYPE:  class
TOKEN: 0x200031B
EXTENDS: PropertyDescriptor
FIELDS:
  private           System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection_option  // 0x88
METHODS:
  System.Void .ctor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option)
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Boolean CanResetValue(System.Object component)
  System.Object GetValue(System.Object component)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: DesignerOptionConverter
TYPE:  class
TOKEN: 0x200031A
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, System.Object value, System.Attribute[] attributes)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Void .ctor()
END_CLASS

CLASS: SimpleMonitor
TYPE:  class
TOKEN: 0x2000320
FIELDS:
  private           System.Int32                    _busyCount  // 0x0
  private           System.Collections.ObjectModel.ObservableCollection<T>_collection  // 0x0
METHODS:
  System.Void .ctor(System.Collections.ObjectModel.ObservableCollection<T> collection)
  System.Void Dispose()
END_CLASS

CLASS: NodeEnumerator
TYPE:  class
TOKEN: 0x2000325
FIELDS:
  private           System.Collections.Specialized.ListDictionary_list  // 0x10
  private           System.Collections.Specialized.ListDictionary.DictionaryNode_current  // 0x18
  private           System.Int32                    _version  // 0x20
  private           System.Boolean                  _start  // 0x24
METHODS:
  System.Void .ctor(System.Collections.Specialized.ListDictionary list)
  System.Object get_Current()
  System.Collections.DictionaryEntry get_Entry()
  System.Object get_Key()
  System.Object get_Value()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: NodeKeyValueEnumerator
TYPE:  class
TOKEN: 0x2000327
FIELDS:
  private           System.Collections.Specialized.ListDictionary_list  // 0x10
  private           System.Collections.Specialized.ListDictionary.DictionaryNode_current  // 0x18
  private           System.Int32                    _version  // 0x20
  private           System.Boolean                  _isKeys  // 0x24
  private           System.Boolean                  _start  // 0x25
METHODS:
  System.Void .ctor(System.Collections.Specialized.ListDictionary list, System.Boolean isKeys)
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: NodeKeyValueCollection
TYPE:  class
TOKEN: 0x2000326
FIELDS:
  private           System.Collections.Specialized.ListDictionary_list  // 0x10
  private           System.Boolean                  _isKeys  // 0x18
METHODS:
  System.Void .ctor(System.Collections.Specialized.ListDictionary list, System.Boolean isKeys)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Int32 System.Collections.ICollection.get_Count()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: DictionaryNode
TYPE:  class
TOKEN: 0x2000328
FIELDS:
  public            System.Object                   key  // 0x10
  public            System.Object                   value  // 0x18
  public            System.Collections.Specialized.ListDictionary.DictionaryNodenext  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: OrderedDictionaryEnumerator
TYPE:  class
TOKEN: 0x200032B
FIELDS:
  private           System.Int32                    _objectReturnType  // 0x10
  private           System.Collections.IEnumerator  _arrayEnumerator  // 0x18
METHODS:
  System.Void .ctor(System.Collections.ArrayList array, System.Int32 objectReturnType)
  System.Object get_Current()
  System.Collections.DictionaryEntry get_Entry()
  System.Object get_Key()
  System.Object get_Value()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: OrderedDictionaryKeyValueCollection
TYPE:  class
TOKEN: 0x200032C
FIELDS:
  private           System.Collections.ArrayList    _objects  // 0x10
  private           System.Boolean                  _isKeys  // 0x18
METHODS:
  System.Void .ctor(System.Collections.ArrayList array, System.Boolean isKeys)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Int32 System.Collections.ICollection.get_Count()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: NameObjectEntry
TYPE:  class
TOKEN: 0x2000336
FIELDS:
  private           System.String                   Key  // 0x10
  private           System.Object                   Value  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.Object value)
END_CLASS

CLASS: NameObjectKeysEnumerator
TYPE:  class
TOKEN: 0x2000337
FIELDS:
  private           System.Int32                    _pos  // 0x10
  private           System.Collections.Specialized.NameObjectCollectionBase_coll  // 0x18
  private           System.Int32                    _version  // 0x20
METHODS:
  System.Void .ctor(System.Collections.Specialized.NameObjectCollectionBase coll)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Object get_Current()
END_CLASS

CLASS: KeysCollection
TYPE:  class
TOKEN: 0x2000338
FIELDS:
  private           System.Collections.Specialized.NameObjectCollectionBase_coll  // 0x10
METHODS:
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 get_Count()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Void .ctor()
END_CLASS

CLASS: WorkStealingQueue
TYPE:  class
TOKEN: 0x200033D
FIELDS:
  private           System.Int32                    _headIndex  // 0x0
  private           System.Int32                    _tailIndex  // 0x0
  private           T[]                             _array  // 0x0
  private           System.Int32                    _mask  // 0x0
  private           System.Int32                    _addTakeCount  // 0x0
  private           System.Int32                    _stealCount  // 0x0
  private           System.Int32                    _currentOp  // 0x0
  private           System.Boolean                  _frozen  // 0x0
  private   readonly System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>_nextQueue  // 0x0
  private   readonly System.Int32                    _ownerThreadId  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> nextQueue)
  System.Void LocalPush(T item, System.Int64& emptyToNonEmptyListTransitionCount)
  System.Void LocalClear()
  System.Boolean TrySteal(T& result, System.Boolean take)
  System.Int32 DangerousCopyTo(T[] array, System.Int32 arrayIndex)
  System.Int32 get_DangerousCount()
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x200033E
FIELDS:
  private   readonly T[]                             _array  // 0x0
  private           T                               _current  // 0x0
  private           System.Int32                    _index  // 0x0
METHODS:
  System.Void .ctor(T[] array)
  System.Boolean MoveNext()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Reset()
  System.Void Dispose()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000345
FIELDS:
  private           System.Collections.Generic.LinkedList<T>_list  // 0x0
  private           System.Collections.Generic.LinkedListNode<T>_node  // 0x0
  private           System.Int32                    _version  // 0x0
  private           T                               _current  // 0x0
  private           System.Int32                    _index  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.LinkedList<T> list)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
  System.Void Dispose()
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000348
FIELDS:
  private           System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>_treeEnum  // 0x0
  private           System.Int32                    _getEnumeratorRetType  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, System.Int32 getEnumeratorRetType)
  System.Boolean MoveNext()
  System.Void Dispose()
  System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current()
  System.Boolean get_NotStartedOrEnded()
  System.Void Reset()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Object System.Collections.IDictionaryEnumerator.get_Key()
  System.Object System.Collections.IDictionaryEnumerator.get_Value()
  System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200034A
FIELDS:
  private           System.Collections.Generic.SortedDictionary.Enumerator<TKey,TValue>_dictEnum  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary)
  System.Void Dispose()
  System.Boolean MoveNext()
  TKey get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: KeyCollection
TYPE:  class
TOKEN: 0x2000349
FIELDS:
  private           System.Collections.Generic.SortedDictionary<TKey,TValue>_dictionary  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary)
  System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void CopyTo(TKey[] array, System.Int32 index)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Int32 get_Count()
  System.Boolean System.Collections.Generic.ICollection<TKey>.get_IsReadOnly()
  System.Void System.Collections.Generic.ICollection<TKey>.Add(TKey item)
  System.Void System.Collections.Generic.ICollection<TKey>.Clear()
  System.Boolean System.Collections.Generic.ICollection<TKey>.Contains(TKey item)
  System.Boolean System.Collections.Generic.ICollection<TKey>.Remove(TKey item)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200034E
FIELDS:
  private           System.Collections.Generic.SortedDictionary.Enumerator<TKey,TValue>_dictEnum  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary)
  System.Void Dispose()
  System.Boolean MoveNext()
  TValue get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ValueCollection
TYPE:  class
TOKEN: 0x200034D
FIELDS:
  private           System.Collections.Generic.SortedDictionary<TKey,TValue>_dictionary  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary)
  System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void CopyTo(TValue[] array, System.Int32 index)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Int32 get_Count()
  System.Boolean System.Collections.Generic.ICollection<TValue>.get_IsReadOnly()
  System.Void System.Collections.Generic.ICollection<TValue>.Add(TValue item)
  System.Void System.Collections.Generic.ICollection<TValue>.Clear()
  System.Boolean System.Collections.Generic.ICollection<TValue>.Contains(TValue item)
  System.Boolean System.Collections.Generic.ICollection<TValue>.Remove(TValue item)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
END_CLASS

CLASS: KeyValuePairComparer
TYPE:  class
TOKEN: 0x2000351
EXTENDS: Comparer`1
FIELDS:
  private           System.Collections.Generic.IComparer<TKey>keyComparer  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer)
  System.Int32 Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000356
FIELDS:
  private           System.Collections.Generic.SortedList<TKey,TValue>_sortedList  // 0x0
  private           TKey                            _key  // 0x0
  private           TValue                          _value  // 0x0
  private           System.Int32                    _index  // 0x0
  private           System.Int32                    _version  // 0x0
  private           System.Int32                    _getEnumeratorRetType  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, System.Int32 getEnumeratorRetType)
  System.Void Dispose()
  System.Object System.Collections.IDictionaryEnumerator.get_Key()
  System.Boolean MoveNext()
  System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry()
  System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Object System.Collections.IDictionaryEnumerator.get_Value()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: SortedListKeyEnumerator
TYPE:  class
TOKEN: 0x2000357
FIELDS:
  private           System.Collections.Generic.SortedList<TKey,TValue>_sortedList  // 0x0
  private           System.Int32                    _index  // 0x0
  private           System.Int32                    _version  // 0x0
  private           TKey                            _currentKey  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList)
  System.Void Dispose()
  System.Boolean MoveNext()
  TKey get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: SortedListValueEnumerator
TYPE:  class
TOKEN: 0x2000358
FIELDS:
  private           System.Collections.Generic.SortedList<TKey,TValue>_sortedList  // 0x0
  private           System.Int32                    _index  // 0x0
  private           System.Int32                    _version  // 0x0
  private           TValue                          _currentValue  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList)
  System.Void Dispose()
  System.Boolean MoveNext()
  TValue get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: KeyList
TYPE:  class
TOKEN: 0x2000359
FIELDS:
  private           System.Collections.Generic.SortedList<TKey,TValue>_dict  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void Add(TKey key)
  System.Void Clear()
  System.Boolean Contains(TKey key)
  System.Void CopyTo(TKey[] array, System.Int32 arrayIndex)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Void Insert(System.Int32 index, TKey value)
  TKey get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, TKey value)
  System.Collections.Generic.IEnumerator<TKey> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 IndexOf(TKey key)
  System.Boolean Remove(TKey key)
  System.Void RemoveAt(System.Int32 index)
END_CLASS

CLASS: ValueList
TYPE:  class
TOKEN: 0x200035A
FIELDS:
  private           System.Collections.Generic.SortedList<TKey,TValue>_dict  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void Add(TValue key)
  System.Void Clear()
  System.Boolean Contains(TValue value)
  System.Void CopyTo(TValue[] array, System.Int32 arrayIndex)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Void Insert(System.Int32 index, TValue value)
  TValue get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, TValue value)
  System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 IndexOf(TValue value)
  System.Boolean Remove(TValue value)
  System.Void RemoveAt(System.Int32 index)
END_CLASS

CLASS: Node
TYPE:  class
TOKEN: 0x200035C
FIELDS:
  private           T                               <Item>k__BackingField  // 0x0
  private           System.Collections.Generic.SortedSet.Node<T><Left>k__BackingField  // 0x0
  private           System.Collections.Generic.SortedSet.Node<T><Right>k__BackingField  // 0x0
  private           System.Collections.Generic.NodeColor<Color>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(T item, System.Collections.Generic.NodeColor color)
  System.Boolean IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node)
  System.Boolean IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node)
  T get_Item()
  System.Void set_Item(T value)
  System.Collections.Generic.SortedSet.Node<T> get_Left()
  System.Void set_Left(System.Collections.Generic.SortedSet.Node<T> value)
  System.Collections.Generic.SortedSet.Node<T> get_Right()
  System.Void set_Right(System.Collections.Generic.SortedSet.Node<T> value)
  System.Collections.Generic.NodeColor get_Color()
  System.Void set_Color(System.Collections.Generic.NodeColor value)
  System.Boolean get_IsBlack()
  System.Boolean get_IsRed()
  System.Boolean get_Is2Node()
  System.Boolean get_Is4Node()
  System.Void ColorBlack()
  System.Void ColorRed()
  System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling)
  System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node)
  System.Void Split4Node()
  System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation)
  System.Collections.Generic.SortedSet.Node<T> RotateLeft()
  System.Collections.Generic.SortedSet.Node<T> RotateLeftRight()
  System.Collections.Generic.SortedSet.Node<T> RotateRight()
  System.Collections.Generic.SortedSet.Node<T> RotateRightLeft()
  System.Void Merge2Nodes()
  System.Void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200035D
FIELDS:
  private   static readonly System.Collections.Generic.SortedSet.Node<T>s_dummyNode  // 0x0
  private           System.Collections.Generic.SortedSet<T>_tree  // 0x0
  private           System.Int32                    _version  // 0x0
  private           System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>>_stack  // 0x0
  private           System.Collections.Generic.SortedSet.Node<T>_current  // 0x0
  private           System.Boolean                  _reverse  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.SortedSet<T> set)
  System.Void .ctor(System.Collections.Generic.SortedSet<T> set, System.Boolean reverse)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender)
  System.Void Initialize()
  System.Boolean MoveNext()
  System.Void Dispose()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean get_NotStartedOrEnded()
  System.Void Reset()
  System.Void System.Collections.IEnumerator.Reset()
  System.Void .cctor()
END_CLASS

CLASS: ReadMethod
TYPE:  class
TOKEN: 0x200036A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.IAsyncResult BeginInvoke(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: WriteMethod
TYPE:  class
TOKEN: 0x200036B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.IAsyncResult BeginInvoke(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnmanagedReadOrWrite
TYPE:  class
TOKEN: 0x200036D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.IntPtr buffer, System.Int32 length, System.IntPtr data)
END_CLASS

CLASS: SafeDeflateStreamHandle
TYPE:  class
TOKEN: 0x200036E
EXTENDS: SafeHandle
FIELDS:
METHODS:
  System.Boolean get_IsInvalid()
  System.Void .ctor()
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: __StaticArrayInitTypeSize=6
TYPE:  struct
TOKEN: 0x2000370
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=9
TYPE:  struct
TOKEN: 0x2000371
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=10
TYPE:  struct
TOKEN: 0x2000372
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x2000373
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=14
TYPE:  struct
TOKEN: 0x2000374
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  struct
TOKEN: 0x2000375
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=44
TYPE:  struct
TOKEN: 0x2000376
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=128
TYPE:  struct
TOKEN: 0x2000377
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  struct
TOKEN: 0x2000378
FIELDS:
METHODS:
END_CLASS

CLASS: Internal.Cryptography.OidLookup
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String,System.String>s_lateBoundOidToFriendlyName  // 0x0
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String,System.String>s_lateBoundFriendlyNameToOid  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_friendlyNameToOid  // 0x10
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_oidToFriendlyName  // 0x18
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_compatOids  // 0x20
METHODS:
  System.String ToFriendlyName(System.String oid, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups)
  System.String ToOid(System.String friendlyName, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups)
  System.Boolean ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup)
  System.String NativeOidToFriendlyName(System.String oid, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups)
  System.String NativeFriendlyNameToOid(System.String friendlyName, System.Security.Cryptography.OidGroup oidGroup, System.Boolean fallBackToAllGroups)
  System.Void .cctor()
END_CLASS

CLASS: Internal.Cryptography.Pal.GeneralNameType
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Internal.Cryptography.Pal.GeneralNameTypeOtherName  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeRfc822Name  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeEmail  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeDnsName  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeX400Address  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeDirectoryName  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeEdiPartyName  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeUniformResourceIdentifier  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeIPAddress  // 0x0
  public    static  Internal.Cryptography.Pal.GeneralNameTypeRegisteredId  // 0x0
METHODS:
END_CLASS

CLASS: Internal.Cryptography.Pal.CertificateData
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  private           System.Byte[]                   RawData  // 0x10
  private           System.Byte[]                   SubjectPublicKeyInfo  // 0x18
  private           System.Int32                    Version  // 0x20
  private           System.Byte[]                   SerialNumber  // 0x28
  private           Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifierTbsSignature  // 0x30
  private           System.Security.Cryptography.X509Certificates.X500DistinguishedNameIssuer  // 0x40
  private           System.DateTime                 NotBefore  // 0x48
  private           System.DateTime                 NotAfter  // 0x50
  private           System.Security.Cryptography.X509Certificates.X500DistinguishedNameSubject  // 0x58
  private           Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifierPublicKeyAlgorithm  // 0x60
  private           System.Byte[]                   PublicKey  // 0x70
  private           System.Byte[]                   IssuerUniqueId  // 0x78
  private           System.Byte[]                   SubjectUniqueId  // 0x80
  private           System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Extension>Extensions  // 0x88
  private           Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifierSignatureAlgorithm  // 0x90
  private           System.Byte[]                   SignatureValue  // 0xA0
METHODS:
  System.Void .ctor(System.Byte[] rawData)
  System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer)
  System.String GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name)
  System.String FindAltNameMatch(System.Byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, System.String otherOid)
  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name)
END_CLASS

CLASS: Microsoft.Win32.NativeMethods
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
METHODS:
  System.Boolean DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.SafeHandle hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, Microsoft.Win32.SafeHandles.SafeWaitHandle& targetHandle, System.Int32 dwDesiredAccess, System.Boolean bInheritHandle, System.Int32 dwOptions)
  System.Boolean DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, Microsoft.Win32.SafeHandles.SafeProcessHandle& targetHandle, System.Int32 dwDesiredAccess, System.Boolean bInheritHandle, System.Int32 dwOptions)
  System.IntPtr GetCurrentProcess()
  System.Boolean GetExitCodeProcess(System.IntPtr processHandle, System.Int32& exitCode)
  System.Boolean GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, System.Int32& exitCode)
  System.Int32 GetCurrentProcessId()
  System.Boolean CloseProcess(System.IntPtr handle)
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeProcessHandle
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: SafeHandleZeroOrMinusOneIsInvalid
FIELDS:
  private   static  Microsoft.Win32.SafeHandles.SafeProcessHandleInvalidHandle  // 0x0
METHODS:
  System.Void .ctor(System.IntPtr handle)
  System.Void .ctor(System.IntPtr existingHandle, System.Boolean ownsHandle)
  System.Boolean ReleaseHandle()
  System.Void .cctor()
END_CLASS

CLASS: Mono.SystemCertificateProvider
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  Mono.Security.Interface.MonoTlsProviderprovider  // 0x0
  private   static  System.Int32                    initialized  // 0x8
  private   static  Mono.X509PalImpl                x509pal  // 0x10
  private   static  System.Object                   syncRoot  // 0x18
METHODS:
  Mono.X509PalImpl GetX509Pal()
  System.Void EnsureInitialized()
  Mono.X509PalImpl get_X509Pal()
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data, Mono.CertificateImportFlags importFlags)
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags)
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Mono.SystemDependencyProvider
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  Mono.SystemDependencyProvider   instance  // 0x0
  private   static  System.Object                   syncRoot  // 0x8
  private   readonly Mono.SystemCertificateProvider  <CertificateProvider>k__BackingField  // 0x10
METHODS:
  Mono.SystemDependencyProvider get_Instance()
  System.Void Initialize()
  Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider()
  Mono.SystemCertificateProvider get_CertificateProvider()
  Mono.X509PalImpl get_X509Pal()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Mono.X509Pal
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  Mono.X509PalImpl get_Instance()
END_CLASS

CLASS: Mono.X509PalImplMono
TYPE:  class
TOKEN: 0x2000005
EXTENDS: X509PalImpl
FIELDS:
METHODS:
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert)
  System.Void .ctor()
END_CLASS

CLASS: Mono.X509PalImpl
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private   static  System.Byte[]                   signedData  // 0x0
METHODS:
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert)
  System.Byte[] PEM(System.String type, System.Byte[] data)
  System.Byte[] ConvertData(System.Byte[] data)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(System.Byte[] data)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags)
  System.Boolean get_SupportsLegacyBasicConstraintsExtension()
  System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(System.Byte[] rawData)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Btls.MonoBtlsBio
TYPE:  class
TOKEN: 0x2000068
EXTENDS: MonoBtlsObject
FIELDS:
METHODS:
  System.Void .ctor(Mono.Btls.MonoBtlsBio.BoringBioHandle handle)
  Mono.Btls.MonoBtlsBio.BoringBioHandle get_Handle()
  System.Void mono_btls_bio_free(System.IntPtr handle)
END_CLASS

CLASS: Mono.Btls.MonoBtlsBioMemory
TYPE:  class
TOKEN: 0x200006A
EXTENDS: MonoBtlsBio
FIELDS:
METHODS:
  System.IntPtr mono_btls_bio_mem_new()
  System.Int32 mono_btls_bio_mem_get_data(System.IntPtr handle, System.IntPtr& data)
  System.Void .ctor()
  System.Byte[] GetData()
END_CLASS

CLASS: Mono.Btls.IMonoBtlsBioMono
TYPE:  interface
TOKEN: 0x200006B
FIELDS:
METHODS:
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean& wantMore)
  System.Boolean Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Flush()
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsBioMono
TYPE:  class
TOKEN: 0x200006C
EXTENDS: MonoBtlsBio
FIELDS:
  private           System.Runtime.InteropServices.GCHandlehandle  // 0x20
  private           System.IntPtr                   instance  // 0x28
  private           Mono.Btls.MonoBtlsBioMono.BioReadFuncreadFunc  // 0x30
  private           Mono.Btls.MonoBtlsBioMono.BioWriteFuncwriteFunc  // 0x38
  private           Mono.Btls.MonoBtlsBioMono.BioControlFunccontrolFunc  // 0x40
  private           System.IntPtr                   readFuncPtr  // 0x48
  private           System.IntPtr                   writeFuncPtr  // 0x50
  private           System.IntPtr                   controlFuncPtr  // 0x58
  private           Mono.Btls.IMonoBtlsBioMono      backend  // 0x60
METHODS:
  System.Void .ctor(Mono.Btls.IMonoBtlsBioMono backend)
  System.IntPtr mono_btls_bio_mono_new()
  System.Void mono_btls_bio_mono_initialize(System.IntPtr handle, System.IntPtr instance, System.IntPtr readFunc, System.IntPtr writeFunc, System.IntPtr controlFunc)
  System.Int64 Control(Mono.Btls.MonoBtlsBioMono.ControlCommand command, System.Int64 arg)
  System.Int32 OnRead(System.IntPtr data, System.Int32 dataLength, System.Int32& wantMore)
  System.Int32 OnRead(System.IntPtr instance, System.IntPtr data, System.Int32 dataLength, System.Int32& wantMore)
  System.Int32 OnWrite(System.IntPtr data, System.Int32 dataLength)
  System.Int32 OnWrite(System.IntPtr instance, System.IntPtr data, System.Int32 dataLength)
  System.Int64 Control(System.IntPtr instance, Mono.Btls.MonoBtlsBioMono.ControlCommand command, System.Int64 arg)
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsContext
TYPE:  class
TOKEN: 0x2000071
EXTENDS: MobileTlsContext
FIELDS:
  private           System.Security.Cryptography.X509Certificates.X509Certificate2remoteCertificate  // 0x58
  private           System.Security.Cryptography.X509Certificates.X509CertificateclientCertificate  // 0x60
  private           Mono.Btls.X509CertificateImplBtlsnativeServerCertificate  // 0x68
  private           Mono.Btls.X509CertificateImplBtlsnativeClientCertificate  // 0x70
  private           Mono.Btls.MonoBtlsSslCtx        ctx  // 0x78
  private           Mono.Btls.MonoBtlsSsl           ssl  // 0x80
  private           Mono.Btls.MonoBtlsBio           bio  // 0x88
  private           Mono.Btls.MonoBtlsBio           errbio  // 0x90
  private           Mono.Security.Interface.MonoTlsConnectionInfoconnectionInfo  // 0x98
  private           System.Boolean                  certificateValidated  // 0xA0
  private           System.Boolean                  isAuthenticated  // 0xA1
  private           System.Boolean                  connected  // 0xA2
METHODS:
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options)
  Mono.Btls.X509CertificateImplBtls GetPrivateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate)
  System.Int32 VerifyCallback(Mono.Btls.MonoBtlsX509StoreCtx storeCtx)
  System.Int32 SelectCallback(System.String[] acceptableIssuers)
  System.Int32 ServerNameCallback()
  System.Void StartHandshake()
  System.Void SetPrivateCertificate(Mono.Btls.X509CertificateImplBtls privateCert)
  System.Exception GetException(Mono.Btls.MonoBtlsSslError status)
  System.Boolean ProcessHandshake()
  Mono.Btls.MonoBtlsSslError DoProcessHandshake()
  System.Void FinishHandshake()
  System.Void InitializeConnection()
  System.Void GetPeerCertificate()
  System.Void InitializeSession()
  Mono.Security.Interface.TlsProtocols GetProtocol(Mono.Security.Interface.TlsProtocolCode protocol)
  System.Void Flush()
  System.ValueTuple<System.Int32,System.Boolean> Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.ValueTuple<System.Int32,System.Boolean> Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Renegotiate()
  System.Void Shutdown()
  System.Boolean PendingRenegotiation()
  System.Void Dispose(T& disposable)
  System.Void Dispose(System.Boolean disposing)
  System.Int32 Mono.Btls.IMonoBtlsBioMono.Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean& wantMore)
  System.Boolean Mono.Btls.IMonoBtlsBioMono.Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Mono.Btls.IMonoBtlsBioMono.Flush()
  System.Void Mono.Btls.IMonoBtlsBioMono.Close()
  System.Boolean get_IsAuthenticated()
  System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate()
  System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate()
END_CLASS

CLASS: Mono.Btls.MonoBtlsError
TYPE:  class
TOKEN: 0x2000072
FIELDS:
METHODS:
  System.Void mono_btls_error_clear_error()
  System.Int32 mono_btls_error_get_error_line(System.IntPtr& file, System.Int32& line)
  System.Void mono_btls_error_get_error_string_n(System.Int32 error, System.IntPtr buf, System.Int32 len)
  System.Int32 mono_btls_error_get_reason(System.Int32 error)
  System.Void ClearError()
  System.String GetErrorString(System.Int32 error)
  System.Int32 GetError(System.String& file, System.Int32& line)
  System.Int32 GetErrorReason(System.Int32 error)
END_CLASS

CLASS: Mono.Btls.MonoBtlsException
TYPE:  class
TOKEN: 0x2000073
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(Mono.Btls.MonoBtlsSslError error)
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String format, System.Object[] args)
END_CLASS

CLASS: Mono.Btls.MonoBtlsKey
TYPE:  class
TOKEN: 0x2000074
EXTENDS: MonoBtlsObject
FIELDS:
METHODS:
  System.IntPtr mono_btls_key_new()
  System.Void mono_btls_key_free(System.IntPtr handle)
  System.IntPtr mono_btls_key_up_ref(System.IntPtr handle)
  System.Int32 mono_btls_key_get_bytes(System.IntPtr handle, System.IntPtr& data, System.Int32& size, System.Int32 include_private_bits)
  System.Int32 mono_btls_key_assign_rsa_private_key(System.IntPtr handle, System.Byte[] der, System.Int32 der_length)
  Mono.Btls.MonoBtlsKey.BoringKeyHandle get_Handle()
  System.Void .ctor(Mono.Btls.MonoBtlsKey.BoringKeyHandle handle)
  System.Byte[] GetBytes(System.Boolean include_private_bits)
  Mono.Btls.MonoBtlsKey Copy()
  Mono.Btls.MonoBtlsKey CreateFromRSAPrivateKey(System.Security.Cryptography.RSA privateKey)
END_CLASS

CLASS: Mono.Btls.MonoBtlsObject
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  private           Mono.Btls.MonoBtlsObject.MonoBtlsHandlehandle  // 0x10
  private           System.Exception                lastError  // 0x18
METHODS:
  System.Void .ctor(Mono.Btls.MonoBtlsObject.MonoBtlsHandle handle)
  Mono.Btls.MonoBtlsObject.MonoBtlsHandle get_Handle()
  System.Boolean get_IsValid()
  System.Void CheckThrow()
  System.Exception SetException(System.Exception ex)
  System.Void CheckError(System.Boolean ok, System.String callerName)
  System.Void CheckError(System.Int32 ret, System.String callerName)
  System.Void CheckLastError(System.String callerName)
  System.Void mono_btls_free(System.IntPtr data)
  System.Void FreeDataPtr(System.IntPtr data)
  System.Void Close()
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Void Finalize()
END_CLASS

CLASS: Mono.Btls.MonoBtlsPkcs12
TYPE:  class
TOKEN: 0x2000078
EXTENDS: MonoBtlsObject
FIELDS:
  private           Mono.Btls.MonoBtlsKey           privateKey  // 0x20
METHODS:
  Mono.Btls.MonoBtlsPkcs12.BoringPkcs12Handle get_Handle()
  System.Void mono_btls_pkcs12_free(System.IntPtr handle)
  System.IntPtr mono_btls_pkcs12_new()
  System.Int32 mono_btls_pkcs12_get_count(System.IntPtr handle)
  System.IntPtr mono_btls_pkcs12_get_cert(System.IntPtr Handle, System.Int32 index)
  System.Int32 mono_btls_pkcs12_import(System.IntPtr chain, System.Void* data, System.Int32 len, Microsoft.Win32.SafeHandles.SafePasswordHandle password)
  System.Int32 mono_btls_pkcs12_has_private_key(System.IntPtr pkcs12)
  System.IntPtr mono_btls_pkcs12_get_private_key(System.IntPtr pkcs12)
  System.Void .ctor()
  System.Int32 get_Count()
  Mono.Btls.MonoBtlsX509 GetCertificate(System.Int32 index)
  System.Void Import(System.Byte[] buffer, Microsoft.Win32.SafeHandles.SafePasswordHandle password)
  System.Boolean get_HasPrivateKey()
  Mono.Btls.MonoBtlsKey GetPrivateKey()
END_CLASS

CLASS: Mono.Btls.MonoBtlsProvider
TYPE:  class
TOKEN: 0x200007A
EXTENDS: MobileTlsProvider
FIELDS:
METHODS:
  System.Guid get_ID()
  System.String get_Name()
  System.Void .ctor()
  System.Boolean get_SupportsSslStream()
  System.Boolean get_SupportsMonoExtensions()
  System.Boolean get_SupportsConnectionInfo()
  System.Boolean get_SupportsCleanShutdown()
  System.Security.Authentication.SslProtocols get_SupportedProtocols()
  Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl GetNativeCertificate(System.Byte[] data, System.String password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags flags)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl GetNativeCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl GetNativeCertificate(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags flags)
  Mono.Btls.MonoBtlsX509VerifyParam GetVerifyParam(Mono.Security.Interface.MonoTlsSettings settings, System.String targetHost, System.Boolean serverMode)
  System.Boolean ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11)
  System.Boolean ValidateCertificate(Mono.Btls.MonoBtlsX509Chain chain, Mono.Btls.MonoBtlsX509VerifyParam param)
  System.Void CheckValidationResult(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Btls.MonoBtlsX509StoreCtx storeCtx, System.Boolean success, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11)
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags MapVerifyErrorToChainStatus(Mono.Btls.MonoBtlsX509Error code)
  System.Void SetupCertificateStore(Mono.Btls.MonoBtlsX509Store store, Mono.Security.Interface.MonoTlsSettings settings, System.Boolean server)
  System.Void SetupDefaultCertificateStore(Mono.Btls.MonoBtlsX509Store store)
  System.Void AddUserStore(Mono.Btls.MonoBtlsX509Store store)
  System.Void AddMachineStore(Mono.Btls.MonoBtlsX509Store store)
  System.Void AddTrustedRoots(Mono.Btls.MonoBtlsX509Store store, Mono.Security.Interface.MonoTlsSettings settings, System.Boolean server)
  System.Security.Cryptography.X509Certificates.X509Certificate2 CreateCertificate(Mono.Btls.MonoBtlsX509 x509)
  System.Security.Cryptography.X509Certificates.X509Chain GetManagedChain(Mono.Btls.MonoBtlsX509Chain chain)
  Mono.Btls.MonoBtlsX509 GetBtlsCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate)
  Mono.Btls.MonoBtlsX509Chain GetNativeChain(System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates)
END_CLASS

CLASS: Mono.Btls.MonoBtlsVerifyCallback
TYPE:  class
TOKEN: 0x200007B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(Mono.Btls.MonoBtlsX509StoreCtx ctx)
END_CLASS

CLASS: Mono.Btls.MonoBtlsSelectCallback
TYPE:  class
TOKEN: 0x200007C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.String[] acceptableIssuers)
END_CLASS

CLASS: Mono.Btls.MonoBtlsServerNameCallback
TYPE:  class
TOKEN: 0x200007D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke()
END_CLASS

CLASS: Mono.Btls.MonoBtlsSsl
TYPE:  class
TOKEN: 0x200007E
EXTENDS: MonoBtlsObject
FIELDS:
  private           Mono.Btls.MonoBtlsBio           bio  // 0x20
  private           Mono.Btls.MonoBtlsSsl.PrintErrorsCallbackFuncprintErrorsFunc  // 0x28
  private           System.IntPtr                   printErrorsFuncPtr  // 0x30
METHODS:
  System.Void mono_btls_ssl_destroy(System.IntPtr handle)
  System.IntPtr mono_btls_ssl_new(System.IntPtr handle)
  System.Int32 mono_btls_ssl_use_certificate(System.IntPtr handle, System.IntPtr x509)
  System.Int32 mono_btls_ssl_use_private_key(System.IntPtr handle, System.IntPtr key)
  System.Int32 mono_btls_ssl_add_chain_certificate(System.IntPtr handle, System.IntPtr x509)
  System.Int32 mono_btls_ssl_accept(System.IntPtr handle)
  System.Int32 mono_btls_ssl_connect(System.IntPtr handle)
  System.Int32 mono_btls_ssl_handshake(System.IntPtr handle)
  System.Void mono_btls_ssl_close(System.IntPtr handle)
  System.Int32 mono_btls_ssl_shutdown(System.IntPtr handle)
  System.Void mono_btls_ssl_set_quiet_shutdown(System.IntPtr handle, System.Int32 mode)
  System.Void mono_btls_ssl_set_bio(System.IntPtr handle, System.IntPtr bio)
  System.Int32 mono_btls_ssl_read(System.IntPtr handle, System.IntPtr data, System.Int32 len)
  System.Int32 mono_btls_ssl_write(System.IntPtr handle, System.IntPtr data, System.Int32 len)
  System.Int32 mono_btls_ssl_get_error(System.IntPtr handle, System.Int32 ret_code)
  System.Int32 mono_btls_ssl_get_version(System.IntPtr handle)
  System.Int32 mono_btls_ssl_get_cipher(System.IntPtr handle)
  System.IntPtr mono_btls_ssl_get_peer_certificate(System.IntPtr handle)
  System.Void mono_btls_ssl_print_errors_cb(System.IntPtr func, System.IntPtr ctx)
  System.Int32 mono_btls_ssl_set_server_name(System.IntPtr handle, System.IntPtr name)
  System.IntPtr mono_btls_ssl_get_server_name(System.IntPtr handle)
  System.Void mono_btls_ssl_set_renegotiate_mode(System.IntPtr handle, System.Int32 mode)
  System.Int32 mono_btls_ssl_renegotiate_pending(System.IntPtr handle)
  Mono.Btls.MonoBtlsSsl.BoringSslHandle Create_internal(Mono.Btls.MonoBtlsSslCtx ctx)
  System.Void .ctor(Mono.Btls.MonoBtlsSslCtx ctx)
  Mono.Btls.MonoBtlsSsl.BoringSslHandle get_Handle()
  System.Void SetBio(Mono.Btls.MonoBtlsBio bio)
  System.Exception ThrowError(System.String callerName)
  Mono.Btls.MonoBtlsSslError GetError(System.Int32 ret_code)
  System.Void SetCertificate(Mono.Btls.MonoBtlsX509 x509)
  System.Void SetPrivateKey(Mono.Btls.MonoBtlsKey key)
  System.Void AddIntermediateCertificate(Mono.Btls.MonoBtlsX509 x509)
  Mono.Btls.MonoBtlsSslError Accept()
  Mono.Btls.MonoBtlsSslError Connect()
  Mono.Btls.MonoBtlsSslError Handshake()
  System.Int32 PrintErrorsCallback(System.IntPtr str, System.IntPtr len, System.IntPtr ctx)
  System.String GetErrors()
  System.Void PrintErrors()
  Mono.Btls.MonoBtlsSslError Read(System.IntPtr data, System.Int32& dataSize)
  Mono.Btls.MonoBtlsSslError Write(System.IntPtr data, System.Int32& dataSize)
  System.Int32 GetVersion()
  System.Int32 GetCipher()
  Mono.Btls.MonoBtlsX509 GetPeerCertificate()
  System.Void SetServerName(System.String name)
  System.String GetServerName()
  System.Void Shutdown()
  System.Void SetQuietShutdown()
  System.Void Close()
  System.Void SetRenegotiateMode(Mono.Btls.MonoBtlsSslRenegotiateMode mode)
  System.Boolean RenegotiatePending()
END_CLASS

CLASS: Mono.Btls.MonoBtlsSslCtx
TYPE:  class
TOKEN: 0x2000081
EXTENDS: MonoBtlsObject
FIELDS:
  private           Mono.Btls.MonoBtlsSslCtx.NativeVerifyFuncverifyFunc  // 0x20
  private           Mono.Btls.MonoBtlsSslCtx.NativeSelectFuncselectFunc  // 0x28
  private           Mono.Btls.MonoBtlsSslCtx.NativeServerNameFuncserverNameFunc  // 0x30
  private           System.IntPtr                   verifyFuncPtr  // 0x38
  private           System.IntPtr                   selectFuncPtr  // 0x40
  private           System.IntPtr                   serverNameFuncPtr  // 0x48
  private           Mono.Btls.MonoBtlsVerifyCallbackverifyCallback  // 0x50
  private           Mono.Btls.MonoBtlsSelectCallbackselectCallback  // 0x58
  private           Mono.Btls.MonoBtlsServerNameCallbackserverNameCallback  // 0x60
  private           Mono.Btls.MonoBtlsX509Store     store  // 0x68
  private           System.Runtime.InteropServices.GCHandleinstance  // 0x70
  private           System.IntPtr                   instancePtr  // 0x78
METHODS:
  Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle get_Handle()
  System.IntPtr mono_btls_ssl_ctx_new()
  System.Int32 mono_btls_ssl_ctx_free(System.IntPtr handle)
  System.Void mono_btls_ssl_ctx_initialize(System.IntPtr handle, System.IntPtr instance)
  System.Void mono_btls_ssl_ctx_set_cert_verify_callback(System.IntPtr handle, System.IntPtr func, System.Int32 cert_required)
  System.Void mono_btls_ssl_ctx_set_cert_select_callback(System.IntPtr handle, System.IntPtr func)
  System.Void mono_btls_ssl_ctx_set_min_version(System.IntPtr handle, System.Int32 version)
  System.Void mono_btls_ssl_ctx_set_max_version(System.IntPtr handle, System.Int32 version)
  System.Int32 mono_btls_ssl_ctx_set_ciphers(System.IntPtr handle, System.Int32 count, System.IntPtr data, System.Int32 allow_unsupported)
  System.Int32 mono_btls_ssl_ctx_set_verify_param(System.IntPtr handle, System.IntPtr param)
  System.Int32 mono_btls_ssl_ctx_set_client_ca_list(System.IntPtr handle, System.Int32 count, System.IntPtr sizes, System.IntPtr data)
  System.Void mono_btls_ssl_ctx_set_server_name_callback(System.IntPtr handle, System.IntPtr func)
  System.Void .ctor()
  System.Void .ctor(Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle handle)
  Mono.Btls.MonoBtlsX509Store get_CertificateStore()
  System.Int32 VerifyCallback(System.Boolean preverify_ok, Mono.Btls.MonoBtlsX509StoreCtx ctx)
  System.Int32 NativeVerifyCallback(System.IntPtr instance, System.Int32 preverify_ok, System.IntPtr store_ctx)
  System.Int32 NativeSelectCallback(System.IntPtr instance, System.Int32 count, System.IntPtr sizes, System.IntPtr data)
  System.String[] CopyIssuers(System.Int32 count, System.IntPtr sizesPtr, System.IntPtr dataPtr)
  System.Void SetVerifyCallback(Mono.Btls.MonoBtlsVerifyCallback callback, System.Boolean client_cert_required)
  System.Void SetSelectCallback(Mono.Btls.MonoBtlsSelectCallback callback)
  System.Void SetMinVersion(System.Int32 version)
  System.Void SetMaxVersion(System.Int32 version)
  System.Void SetCiphers(System.Int16[] ciphers, System.Boolean allow_unsupported)
  System.Void SetVerifyParam(Mono.Btls.MonoBtlsX509VerifyParam param)
  System.Void SetClientCertificateIssuers(System.String[] acceptableIssuers)
  System.Void SetServerNameCallback(Mono.Btls.MonoBtlsServerNameCallback callback)
  System.Int32 NativeServerNameCallback(System.IntPtr instance)
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsSslError
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsSslError      None  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      Ssl  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantRead  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantWrite  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantX509Lookup  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      Syscall  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      ZeroReturn  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantConnect  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantAccept  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantChannelIdLookup  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      PendingSession  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      PendingCertificate  // 0x0
  public    static  Mono.Btls.MonoBtlsSslError      WantPrivateKeyOperation  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsSslRenegotiateMode
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsSslRenegotiateModeNEVER  // 0x0
  public    static  Mono.Btls.MonoBtlsSslRenegotiateModeONCE  // 0x0
  public    static  Mono.Btls.MonoBtlsSslRenegotiateModeFREELY  // 0x0
  public    static  Mono.Btls.MonoBtlsSslRenegotiateModeIGNORE  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsStream
TYPE:  class
TOKEN: 0x2000088
EXTENDS: MobileAuthenticatedStream
FIELDS:
METHODS:
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider)
  Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options)
END_CLASS

CLASS: Mono.Btls.MonoBtlsUtils
TYPE:  class
TOKEN: 0x2000089
FIELDS:
  private   static  System.Byte[]                   emailOid  // 0x0
METHODS:
  System.Boolean Compare(System.Byte[] a, System.Byte[] b)
  System.Boolean AppendEntry(System.Text.StringBuilder sb, Mono.Btls.MonoBtlsX509Name name, System.Int32 index, System.String separator, System.Boolean quotes)
  System.String FormatName(Mono.Btls.MonoBtlsX509Name name, System.Boolean reversed, System.String separator, System.Boolean quotes)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509
TYPE:  class
TOKEN: 0x200008A
EXTENDS: MonoBtlsObject
FIELDS:
METHODS:
  Mono.Btls.MonoBtlsX509.BoringX509Handle get_Handle()
  System.Void .ctor(Mono.Btls.MonoBtlsX509.BoringX509Handle handle)
  System.IntPtr mono_btls_x509_up_ref(System.IntPtr handle)
  System.IntPtr mono_btls_x509_from_data(System.IntPtr data, System.Int32 len, Mono.Btls.MonoBtlsX509Format format)
  System.IntPtr mono_btls_x509_get_subject_name(System.IntPtr handle)
  System.Int32 mono_btls_x509_get_raw_data(System.IntPtr handle, System.IntPtr bio, Mono.Btls.MonoBtlsX509Format format)
  System.Int32 mono_btls_x509_cmp(System.IntPtr a, System.IntPtr b)
  System.Void mono_btls_x509_free(System.IntPtr handle)
  System.Int32 mono_btls_x509_add_explicit_trust(System.IntPtr handle, Mono.Btls.MonoBtlsX509TrustKind kind)
  Mono.Btls.MonoBtlsX509 Copy()
  Mono.Btls.MonoBtlsX509 LoadFromData(System.Byte[] buffer, Mono.Btls.MonoBtlsX509Format format)
  Mono.Btls.MonoBtlsX509Name GetSubjectName()
  System.Int64 GetSubjectNameHash()
  System.Byte[] GetRawData(Mono.Btls.MonoBtlsX509Format format)
  System.Int32 Compare(Mono.Btls.MonoBtlsX509 a, Mono.Btls.MonoBtlsX509 b)
  System.Void AddExplicitTrust(Mono.Btls.MonoBtlsX509TrustKind kind)
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509Chain
TYPE:  class
TOKEN: 0x200008C
EXTENDS: MonoBtlsObject
FIELDS:
METHODS:
  Mono.Btls.MonoBtlsX509Chain.BoringX509ChainHandle get_Handle()
  System.IntPtr mono_btls_x509_chain_new()
  System.Int32 mono_btls_x509_chain_get_count(System.IntPtr handle)
  System.IntPtr mono_btls_x509_chain_get_cert(System.IntPtr Handle, System.Int32 index)
  System.Int32 mono_btls_x509_chain_add_cert(System.IntPtr chain, System.IntPtr x509)
  System.IntPtr mono_btls_x509_chain_up_ref(System.IntPtr handle)
  System.Void mono_btls_x509_chain_free(System.IntPtr handle)
  System.Void .ctor()
  System.Void .ctor(Mono.Btls.MonoBtlsX509Chain.BoringX509ChainHandle handle)
  System.Int32 get_Count()
  Mono.Btls.MonoBtlsX509 GetCertificate(System.Int32 index)
  System.Void AddCertificate(Mono.Btls.MonoBtlsX509 x509)
  Mono.Btls.MonoBtlsX509Chain Copy()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509Error
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509Error     OK  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_GET_ISSUER_CERT  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_GET_CRL  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_DECRYPT_CERT_SIGNATURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_DECRYPT_CRL_SIGNATURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_DECODE_ISSUER_PUBLIC_KEY  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_SIGNATURE_FAILURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CRL_SIGNATURE_FAILURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_NOT_YET_VALID  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_HAS_EXPIRED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CRL_NOT_YET_VALID  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CRL_HAS_EXPIRED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     ERROR_IN_CERT_NOT_BEFORE_FIELD  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     ERROR_IN_CERT_NOT_AFTER_FIELD  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     ERROR_IN_CRL_LAST_UPDATE_FIELD  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     ERROR_IN_CRL_NEXT_UPDATE_FIELD  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     OUT_OF_MEM  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     DEPTH_ZERO_SELF_SIGNED_CERT  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SELF_SIGNED_CERT_IN_CHAIN  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_GET_ISSUER_CERT_LOCALLY  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_VERIFY_LEAF_SIGNATURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_CHAIN_TOO_LONG  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_REVOKED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     INVALID_CA  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     PATH_LENGTH_EXCEEDED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     INVALID_PURPOSE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_UNTRUSTED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CERT_REJECTED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUBJECT_ISSUER_MISMATCH  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     AKID_SKID_MISMATCH  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     AKID_ISSUER_SERIAL_MISMATCH  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     KEYUSAGE_NO_CERTSIGN  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNABLE_TO_GET_CRL_ISSUER  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNHANDLED_CRITICAL_EXTENSION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     KEYUSAGE_NO_CRL_SIGN  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNHANDLED_CRITICAL_CRL_EXTENSION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     INVALID_NON_CA  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     PROXY_PATH_LENGTH_EXCEEDED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     KEYUSAGE_NO_DIGITAL_SIGNATURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     PROXY_CERTIFICATES_NOT_ALLOWED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     INVALID_EXTENSION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     INVALID_POLICY_EXTENSION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     NO_EXPLICIT_POLICY  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     DIFFERENT_CRL_SCOPE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNSUPPORTED_EXTENSION_FEATURE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNNESTED_RESOURCE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     PERMITTED_VIOLATION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     EXCLUDED_VIOLATION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUBTREE_MINMAX  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNSUPPORTED_CONSTRAINT_TYPE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNSUPPORTED_CONSTRAINT_SYNTAX  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     UNSUPPORTED_NAME_SYNTAX  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     CRL_PATH_VALIDATION_ERROR  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUITE_B_INVALID_VERSION  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUITE_B_INVALID_ALGORITHM  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUITE_B_INVALID_CURVE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUITE_B_INVALID_SIGNATURE_ALGORITHM  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUITE_B_LOS_NOT_ALLOWED  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     SUITE_B_CANNOT_SIGN_P_384_WITH_P_256  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     HOSTNAME_MISMATCH  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     EMAIL_MISMATCH  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     IP_ADDRESS_MISMATCH  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Error     APPLICATION_VERIFICATION  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509FileType
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509FileType  PEM  // 0x0
  public    static  Mono.Btls.MonoBtlsX509FileType  ASN1  // 0x0
  public    static  Mono.Btls.MonoBtlsX509FileType  DEFAULT  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509Format
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509Format    DER  // 0x0
  public    static  Mono.Btls.MonoBtlsX509Format    PEM  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509Lookup
TYPE:  class
TOKEN: 0x2000091
EXTENDS: MonoBtlsObject
FIELDS:
  private           Mono.Btls.MonoBtlsX509Store     store  // 0x20
  private           Mono.Btls.MonoBtlsX509LookupTypetype  // 0x28
  private           System.Collections.Generic.List<Mono.Btls.MonoBtlsX509LookupMono>monoLookups  // 0x30
METHODS:
  Mono.Btls.MonoBtlsX509Lookup.BoringX509LookupHandle get_Handle()
  System.IntPtr mono_btls_x509_lookup_new(System.IntPtr store, Mono.Btls.MonoBtlsX509LookupType type)
  System.Int32 mono_btls_x509_lookup_add_dir(System.IntPtr handle, System.IntPtr dir, Mono.Btls.MonoBtlsX509FileType type)
  System.Int32 mono_btls_x509_lookup_add_mono(System.IntPtr handle, System.IntPtr monoLookup)
  System.Void mono_btls_x509_lookup_free(System.IntPtr handle)
  System.IntPtr mono_btls_x509_lookup_peek_lookup(System.IntPtr handle)
  Mono.Btls.MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(Mono.Btls.MonoBtlsX509Store store, Mono.Btls.MonoBtlsX509LookupType type)
  System.Void .ctor(Mono.Btls.MonoBtlsX509Store store, Mono.Btls.MonoBtlsX509LookupType type)
  System.IntPtr GetNativeLookup()
  System.Void AddDirectory(System.String dir, Mono.Btls.MonoBtlsX509FileType type)
  System.Void AddMono(Mono.Btls.MonoBtlsX509LookupMono monoLookup)
  System.Void AddCertificate(Mono.Btls.MonoBtlsX509 certificate)
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509LookupMono
TYPE:  class
TOKEN: 0x2000093
EXTENDS: MonoBtlsObject
FIELDS:
  private           System.Runtime.InteropServices.GCHandlegch  // 0x20
  private           System.IntPtr                   instance  // 0x28
  private           Mono.Btls.MonoBtlsX509LookupMono.BySubjectFuncbySubjectFunc  // 0x30
  private           System.IntPtr                   bySubjectFuncPtr  // 0x38
  private           Mono.Btls.MonoBtlsX509Lookup    lookup  // 0x40
METHODS:
  Mono.Btls.MonoBtlsX509LookupMono.BoringX509LookupMonoHandle get_Handle()
  System.IntPtr mono_btls_x509_lookup_mono_new()
  System.Void mono_btls_x509_lookup_mono_init(System.IntPtr handle, System.IntPtr instance, System.IntPtr by_subject_func)
  System.Int32 mono_btls_x509_lookup_mono_free(System.IntPtr handle)
  System.Void .ctor()
  System.Void Install(Mono.Btls.MonoBtlsX509Lookup lookup)
  System.Void AddCertificate(Mono.Btls.MonoBtlsX509 certificate)
  Mono.Btls.MonoBtlsX509 OnGetBySubject(Mono.Btls.MonoBtlsX509Name name)
  System.Int32 OnGetBySubject(System.IntPtr instance, System.IntPtr name_ptr, System.IntPtr& x509_ptr)
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509LookupMonoCollection
TYPE:  class
TOKEN: 0x2000096
EXTENDS: MonoBtlsX509LookupMono
FIELDS:
  private           System.Int64[]                  hashes  // 0x48
  private           Mono.Btls.MonoBtlsX509[]        certificates  // 0x50
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollectioncollection  // 0x58
  private           Mono.Btls.MonoBtlsX509TrustKind trust  // 0x60
METHODS:
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateCollection collection, Mono.Btls.MonoBtlsX509TrustKind trust)
  System.Void Initialize()
  Mono.Btls.MonoBtlsX509 OnGetBySubject(Mono.Btls.MonoBtlsX509Name name)
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509LookupType
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509LookupTypeUNKNOWN  // 0x0
  public    static  Mono.Btls.MonoBtlsX509LookupTypeFILE  // 0x0
  public    static  Mono.Btls.MonoBtlsX509LookupTypeHASH_DIR  // 0x0
  public    static  Mono.Btls.MonoBtlsX509LookupTypeMONO  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509Name
TYPE:  class
TOKEN: 0x2000098
EXTENDS: MonoBtlsObject
FIELDS:
METHODS:
  System.Int64 mono_btls_x509_name_hash(System.IntPtr handle)
  System.Int32 mono_btls_x509_name_get_entry_count(System.IntPtr handle)
  Mono.Btls.MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(System.IntPtr name, System.Int32 index)
  System.Int32 mono_btls_x509_name_get_entry_oid(System.IntPtr name, System.Int32 index, System.IntPtr buffer, System.Int32 size)
  System.Int32 mono_btls_x509_name_get_entry_oid_data(System.IntPtr name, System.Int32 index, System.IntPtr& data)
  System.Int32 mono_btls_x509_name_get_entry_value(System.IntPtr name, System.Int32 index, System.Int32& tag, System.IntPtr& str)
  System.IntPtr mono_btls_x509_name_from_data(System.Void* data, System.Int32 len, System.Int32 use_canon_enc)
  System.Void mono_btls_x509_name_free(System.IntPtr handle)
  Mono.Btls.MonoBtlsX509Name.BoringX509NameHandle get_Handle()
  System.Void .ctor(Mono.Btls.MonoBtlsX509Name.BoringX509NameHandle handle)
  System.Int64 GetHash()
  System.Int32 GetEntryCount()
  Mono.Btls.MonoBtlsX509NameEntryType GetEntryType(System.Int32 index)
  System.String GetEntryOid(System.Int32 index)
  System.Byte[] GetEntryOidData(System.Int32 index)
  System.String GetEntryValue(System.Int32 index, System.Int32& tag)
  Mono.Btls.MonoBtlsX509Name CreateFromData(System.Byte[] data, System.Boolean use_canon_enc)
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509NameEntryType
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeUnknown  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeCountryName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeOrganizationName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeOrganizationalUnitName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeCommonName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeLocalityName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeStateOrProvinceName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeStreetAddress  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeSerialNumber  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeDomainComponent  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeUserId  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeEmail  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeDnQualifier  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeTitle  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeSurname  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeGivenName  // 0x0
  public    static  Mono.Btls.MonoBtlsX509NameEntryTypeInitial  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509Store
TYPE:  class
TOKEN: 0x200009B
EXTENDS: MonoBtlsObject
FIELDS:
  private           System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup>lookupHash  // 0x20
METHODS:
  Mono.Btls.MonoBtlsX509Store.BoringX509StoreHandle get_Handle()
  System.IntPtr mono_btls_x509_store_new()
  System.IntPtr mono_btls_x509_store_from_ssl_ctx(System.IntPtr handle)
  System.Int32 mono_btls_x509_store_add_cert(System.IntPtr handle, System.IntPtr x509)
  System.Void mono_btls_x509_store_free(System.IntPtr handle)
  Mono.Btls.MonoBtlsX509Store.BoringX509StoreHandle Create_internal()
  Mono.Btls.MonoBtlsX509Store.BoringX509StoreHandle Create_internal(Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle ctx)
  System.Void .ctor()
  System.Void .ctor(Mono.Btls.MonoBtlsSslCtx.BoringSslCtxHandle ctx)
  System.Void AddCertificate(Mono.Btls.MonoBtlsX509 x509)
  Mono.Btls.MonoBtlsX509Lookup AddLookup(Mono.Btls.MonoBtlsX509LookupType type)
  System.Void AddDirectoryLookup(System.String dir, Mono.Btls.MonoBtlsX509FileType type)
  System.Void AddCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection collection, Mono.Btls.MonoBtlsX509TrustKind trust)
  System.Void Close()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509StoreCtx
TYPE:  class
TOKEN: 0x200009D
EXTENDS: MonoBtlsObject
FIELDS:
  private           System.Nullable<System.Int32>   verifyResult  // 0x20
METHODS:
  Mono.Btls.MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle get_Handle()
  System.IntPtr mono_btls_x509_store_ctx_new()
  System.IntPtr mono_btls_x509_store_ctx_from_ptr(System.IntPtr ctx)
  Mono.Btls.MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(System.IntPtr handle, System.IntPtr& error_string)
  System.IntPtr mono_btls_x509_store_ctx_get_chain(System.IntPtr handle)
  System.Int32 mono_btls_x509_store_ctx_init(System.IntPtr handle, System.IntPtr store, System.IntPtr chain)
  System.Int32 mono_btls_x509_store_ctx_set_param(System.IntPtr handle, System.IntPtr param)
  System.Int32 mono_btls_x509_store_ctx_verify_cert(System.IntPtr handle)
  System.IntPtr mono_btls_x509_store_ctx_get_untrusted(System.IntPtr handle)
  System.IntPtr mono_btls_x509_store_ctx_up_ref(System.IntPtr handle)
  System.Void mono_btls_x509_store_ctx_free(System.IntPtr handle)
  System.Void .ctor()
  Mono.Btls.MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(System.IntPtr store_ctx)
  System.Void .ctor(System.Int32 preverify_ok, System.IntPtr store_ctx)
  System.Void .ctor(Mono.Btls.MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult)
  Mono.Btls.MonoBtlsX509Error GetError()
  Mono.Btls.MonoBtlsX509Chain GetChain()
  Mono.Btls.MonoBtlsX509Chain GetUntrusted()
  System.Void Initialize(Mono.Btls.MonoBtlsX509Store store, Mono.Btls.MonoBtlsX509Chain chain)
  System.Void SetVerifyParam(Mono.Btls.MonoBtlsX509VerifyParam param)
  System.Int32 get_VerifyResult()
  System.Int32 Verify()
  Mono.Btls.MonoBtlsX509StoreCtx Copy()
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509StoreManager
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  private   static  System.Boolean                  initialized  // 0x0
  private   static  System.String                   machineTrustedRootPath  // 0x8
  private   static  System.String                   machineIntermediateCAPath  // 0x10
  private   static  System.String                   machineUntrustedPath  // 0x18
  private   static  System.String                   userTrustedRootPath  // 0x20
  private   static  System.String                   userIntermediateCAPath  // 0x28
  private   static  System.String                   userUntrustedPath  // 0x30
METHODS:
  System.Void Initialize()
  System.Void DoInitialize()
  System.String GetStorePath(Mono.Btls.MonoBtlsX509StoreType type)
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509StoreType
TYPE:  struct
TOKEN: 0x20000A0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509StoreType Custom  // 0x0
  public    static  Mono.Btls.MonoBtlsX509StoreType MachineTrustedRoots  // 0x0
  public    static  Mono.Btls.MonoBtlsX509StoreType MachineIntermediateCA  // 0x0
  public    static  Mono.Btls.MonoBtlsX509StoreType MachineUntrusted  // 0x0
  public    static  Mono.Btls.MonoBtlsX509StoreType UserTrustedRoots  // 0x0
  public    static  Mono.Btls.MonoBtlsX509StoreType UserIntermediateCA  // 0x0
  public    static  Mono.Btls.MonoBtlsX509StoreType UserUntrusted  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509TrustKind
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Btls.MonoBtlsX509TrustKind DEFAULT  // 0x0
  public    static  Mono.Btls.MonoBtlsX509TrustKind TRUST_CLIENT  // 0x0
  public    static  Mono.Btls.MonoBtlsX509TrustKind TRUST_SERVER  // 0x0
  public    static  Mono.Btls.MonoBtlsX509TrustKind TRUST_ALL  // 0x0
  public    static  Mono.Btls.MonoBtlsX509TrustKind REJECT_CLIENT  // 0x0
  public    static  Mono.Btls.MonoBtlsX509TrustKind REJECT_SERVER  // 0x0
  public    static  Mono.Btls.MonoBtlsX509TrustKind REJECT_ALL  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Btls.MonoBtlsX509VerifyParam
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: MonoBtlsObject
FIELDS:
METHODS:
  Mono.Btls.MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle get_Handle()
  System.IntPtr mono_btls_x509_verify_param_copy(System.IntPtr handle)
  System.IntPtr mono_btls_x509_verify_param_lookup(System.IntPtr name)
  System.Int32 mono_btls_x509_verify_param_can_modify(System.IntPtr param)
  System.Int32 mono_btls_x509_verify_param_set_host(System.IntPtr handle, System.IntPtr name, System.Int32 namelen)
  System.Int32 mono_btls_x509_verify_param_set_time(System.IntPtr handle, System.Int64 time)
  System.Void mono_btls_x509_verify_param_free(System.IntPtr handle)
  System.Void .ctor(Mono.Btls.MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle)
  Mono.Btls.MonoBtlsX509VerifyParam Copy()
  Mono.Btls.MonoBtlsX509VerifyParam GetSslClient()
  Mono.Btls.MonoBtlsX509VerifyParam GetSslServer()
  Mono.Btls.MonoBtlsX509VerifyParam Lookup(System.String name, System.Boolean fail)
  System.Boolean get_CanModify()
  System.Void WantToModify()
  System.Void SetHost(System.String name)
  System.Void SetTime(System.DateTime time)
END_CLASS

CLASS: Mono.Btls.X509CertificateImplBtls
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: X509Certificate2ImplUnix
FIELDS:
  private           Mono.Btls.MonoBtlsX509          x509  // 0xB0
  private           Mono.Btls.MonoBtlsKey           nativePrivateKey  // 0xB8
  private           System.Security.Cryptography.X509Certificates.X509CertificateImplCollectionintermediateCerts  // 0xC0
METHODS:
  System.Void .ctor(Mono.Btls.MonoBtlsX509 x509)
  System.Void .ctor(Mono.Btls.X509CertificateImplBtls other)
  System.Void .ctor(System.Byte[] data, Mono.Btls.MonoBtlsX509Format format)
  System.Void .ctor(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags)
  System.Boolean get_IsValid()
  Mono.Btls.MonoBtlsX509 get_X509()
  Mono.Btls.MonoBtlsKey get_NativePrivateKey()
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone()
  System.Byte[] GetRawCertData()
  System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_HasPrivateKey()
  System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey()
  System.Void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value)
  System.Security.Cryptography.RSA GetRSAPrivateKey()
  System.Security.Cryptography.DSA GetDSAPrivateKey()
  System.Void Import(System.Byte[] data)
  System.Void ImportPkcs12(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password)
  System.Void ImportAuthenticode(System.Byte[] data)
  System.Boolean Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate)
END_CLASS

CLASS: Mono.Btls.X509ChainImplBtls
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: X509ChainImpl
FIELDS:
  private           Mono.Btls.MonoBtlsX509StoreCtx  storeCtx  // 0x10
  private           Mono.Btls.MonoBtlsX509Chain     chain  // 0x18
  private           Mono.Btls.MonoBtlsX509Chain     untrustedChain  // 0x20
  private           System.Security.Cryptography.X509Certificates.X509ChainElementCollectionelements  // 0x28
  private           System.Security.Cryptography.X509Certificates.X509Certificate2Collectionuntrusted  // 0x30
  private           System.Security.Cryptography.X509Certificates.X509Certificate2[]certificates  // 0x38
  private           System.Security.Cryptography.X509Certificates.X509ChainPolicypolicy  // 0x40
  private           System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus>chainStatusList  // 0x48
METHODS:
  System.Void .ctor(Mono.Btls.MonoBtlsX509Chain chain)
  System.Void .ctor(Mono.Btls.MonoBtlsX509StoreCtx storeCtx)
  System.Boolean get_IsValid()
  Mono.Btls.MonoBtlsX509StoreCtx get_StoreCtx()
  System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements()
  System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy()
  System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode)
  System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void Reset()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: Mono.Btls.X509PalImplBtls
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: X509PalImpl
FIELDS:
  private   readonly Mono.Btls.MonoBtlsProvider      <Provider>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(Mono.Security.Interface.MonoTlsProvider provider)
  Mono.Btls.MonoBtlsProvider get_Provider()
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(System.Byte[] data)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert)
END_CLASS

CLASS: Mono.Http.NtlmSession
TYPE:  class
TOKEN: 0x2000065
FIELDS:
  private           Mono.Security.Protocol.Ntlm.MessageBasemessage  // 0x10
METHODS:
  System.Void .ctor()
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
END_CLASS

CLASS: Mono.Http.NtlmClient
TYPE:  class
TOKEN: 0x2000066
FIELDS:
  private   static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession>cache  // 0x0
METHODS:
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.String get_AuthenticationType()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Net.Security.BufferOffsetSize
TYPE:  class
TOKEN: 0x2000043
FIELDS:
  public            System.Byte[]                   Buffer  // 0x10
  public            System.Int32                    Offset  // 0x18
  public            System.Int32                    Size  // 0x1C
  public            System.Int32                    TotalBytes  // 0x20
  public            System.Boolean                  Complete  // 0x24
METHODS:
  System.Int32 get_EndOffset()
  System.Int32 get_Remaining()
  System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.String ToString()
END_CLASS

CLASS: Mono.Net.Security.BufferOffsetSize2
TYPE:  class
TOKEN: 0x2000044
EXTENDS: BufferOffsetSize
FIELDS:
  public    readonly System.Int32                    InitialSize  // 0x28
METHODS:
  System.Void .ctor(System.Int32 size)
  System.Void Reset()
  System.Void MakeRoom(System.Int32 size)
  System.Void AppendData(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
END_CLASS

CLASS: Mono.Net.Security.AsyncOperationStatus
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Net.Security.AsyncOperationStatusInitialize  // 0x0
  public    static  Mono.Net.Security.AsyncOperationStatusContinue  // 0x0
  public    static  Mono.Net.Security.AsyncOperationStatusReadDone  // 0x0
  public    static  Mono.Net.Security.AsyncOperationStatusComplete  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Net.Security.AsyncProtocolResult
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  private   readonly System.Int32                    <UserResult>k__BackingField  // 0x10
  private   readonly System.Runtime.ExceptionServices.ExceptionDispatchInfo<Error>k__BackingField  // 0x18
METHODS:
  System.Int32 get_UserResult()
  System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error()
  System.Void .ctor(System.Int32 result)
  System.Void .ctor(System.Runtime.ExceptionServices.ExceptionDispatchInfo error)
END_CLASS

CLASS: Mono.Net.Security.AsyncProtocolRequest
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private   readonly Mono.Net.Security.MobileAuthenticatedStream<Parent>k__BackingField  // 0x10
  private   readonly System.Boolean                  <RunSynchronously>k__BackingField  // 0x18
  private           System.Int32                    <UserResult>k__BackingField  // 0x1C
  private           System.Int32                    Started  // 0x20
  private           System.Int32                    RequestedSize  // 0x24
  private           System.Int32                    WriteRequested  // 0x28
  private   readonly System.Object                   locker  // 0x30
METHODS:
  Mono.Net.Security.MobileAuthenticatedStream get_Parent()
  System.Boolean get_RunSynchronously()
  System.String get_Name()
  System.Int32 get_UserResult()
  System.Void set_UserResult(System.Int32 value)
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync)
  System.Void RequestRead(System.Int32 size)
  System.Void RequestWrite()
  System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(System.Threading.CancellationToken cancellationToken)
  Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status)
  System.String ToString()
END_CLASS

CLASS: Mono.Net.Security.AsyncHandshakeRequest
TYPE:  class
TOKEN: 0x200004B
EXTENDS: AsyncProtocolRequest
FIELDS:
METHODS:
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync)
  Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status)
END_CLASS

CLASS: Mono.Net.Security.AsyncReadOrWriteRequest
TYPE:  class
TOKEN: 0x200004C
EXTENDS: AsyncProtocolRequest
FIELDS:
  private   readonly Mono.Net.Security.BufferOffsetSize<UserBuffer>k__BackingField  // 0x38
  private           System.Int32                    <CurrentSize>k__BackingField  // 0x40
METHODS:
  Mono.Net.Security.BufferOffsetSize get_UserBuffer()
  System.Int32 get_CurrentSize()
  System.Void set_CurrentSize(System.Int32 value)
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync, System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.String ToString()
END_CLASS

CLASS: Mono.Net.Security.AsyncReadRequest
TYPE:  class
TOKEN: 0x200004D
EXTENDS: AsyncReadOrWriteRequest
FIELDS:
METHODS:
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync, System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status)
END_CLASS

CLASS: Mono.Net.Security.AsyncWriteRequest
TYPE:  class
TOKEN: 0x200004E
EXTENDS: AsyncReadOrWriteRequest
FIELDS:
METHODS:
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, System.Boolean sync, System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status)
END_CLASS

CLASS: Mono.Net.Security.ChainValidationHelper
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private   readonly System.WeakReference<System.Net.Security.SslStream>owner  // 0x10
  private   readonly Mono.Security.Interface.MonoTlsSettingssettings  // 0x18
  private   readonly Mono.Net.Security.MobileTlsProviderprovider  // 0x20
  private   readonly System.Net.ServerCertValidationCallbackcertValidationCallback  // 0x28
  private   readonly System.Net.Security.LocalCertSelectionCallbackcertSelectionCallback  // 0x30
  private   readonly Mono.Net.Security.MonoTlsStream tlsStream  // 0x38
  private   readonly System.Net.HttpWebRequest       request  // 0x40
METHODS:
  Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings)
  Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings& settings, Mono.Net.Security.MonoTlsStream stream)
  System.Void .ctor(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, System.Boolean cloneSettings, Mono.Net.Security.MonoTlsStream stream)
  System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings)
  System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
  Mono.Security.Interface.MonoTlsSettings get_Settings()
  System.Boolean SelectClientCertificate(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers, System.Security.Cryptography.X509Certificates.X509Certificate& clientCertificate)
  Mono.Security.Interface.ValidationResult ValidateCertificate(System.String host, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain)
  Mono.Security.Interface.ValidationResult ValidateChain(System.String host, System.Boolean server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors)
  Mono.Security.Interface.ValidationResult ValidateChain(System.String host, System.Boolean server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors)
  System.Boolean InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors)
END_CLASS

CLASS: Mono.Net.Security.MobileAuthenticatedStream
TYPE:  class
TOKEN: 0x2000051
EXTENDS: AuthenticatedStream
FIELDS:
  private           Mono.Net.Security.MobileTlsContextxobileTlsContext  // 0x38
  private           System.Runtime.ExceptionServices.ExceptionDispatchInfolastException  // 0x40
  private           Mono.Net.Security.AsyncProtocolRequestasyncHandshakeRequest  // 0x48
  private           Mono.Net.Security.AsyncProtocolRequestasyncReadRequest  // 0x50
  private           Mono.Net.Security.AsyncProtocolRequestasyncWriteRequest  // 0x58
  private           Mono.Net.Security.BufferOffsetSize2readBuffer  // 0x60
  private           Mono.Net.Security.BufferOffsetSize2writeBuffer  // 0x68
  private           System.Object                   ioLock  // 0x70
  private           System.Int32                    closeRequested  // 0x78
  private           System.Boolean                  shutdown  // 0x7C
  private           Mono.Net.Security.MobileAuthenticatedStream.Operationoperation  // 0x80
  private   static  System.Int32                    uniqueNameInteger  // 0x0
  private   readonly System.Net.Security.SslStream   <SslStream>k__BackingField  // 0x88
  private   readonly Mono.Security.Interface.MonoTlsSettings<Settings>k__BackingField  // 0x90
  private   readonly Mono.Net.Security.MobileTlsProvider<Provider>k__BackingField  // 0x98
  private           System.String                   <TargetHost>k__BackingField  // 0xA0
  private   static  System.Int32                    nextId  // 0x4
  private   readonly System.Int32                    ID  // 0xA8
METHODS:
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider)
  System.Net.Security.SslStream get_SslStream()
  Mono.Security.Interface.MonoTlsSettings get_Settings()
  Mono.Net.Security.MobileTlsProvider get_Provider()
  System.String get_TargetHost()
  System.Void set_TargetHost(System.String value)
  System.Void CheckThrow(System.Boolean authSuccessCheck, System.Boolean shutdownCheck)
  System.Exception GetSSPIException(System.Exception e)
  System.Exception GetIOException(System.Exception e, System.String message)
  System.Exception GetInternalError()
  System.Exception GetInvalidNestedCallException()
  System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e)
  System.Void AuthenticateAsClient(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation)
  System.Threading.Tasks.Task AuthenticateAsClientAsync(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation)
  System.Threading.Tasks.Task ProcessAuthentication(System.Boolean runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken)
  Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Int32> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken)
  System.Int32 InternalRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean& outWantMore)
  System.ValueTuple<System.Int32,System.Boolean> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Boolean InternalWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Boolean InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Threading.Tasks.Task<System.Int32> InnerRead(System.Boolean sync, System.Int32 requestedSize, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task InnerWrite(System.Boolean sync, System.Threading.CancellationToken cancellationToken)
  Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, System.Boolean renegotiate)
  System.ValueTuple<System.Int32,System.Boolean> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer)
  System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer)
  System.Boolean get_IsAuthenticated()
  System.Void Dispose(System.Boolean disposing)
  System.Void Flush()
  System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate()
  System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate()
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Void SetLength(System.Int64 value)
  System.Boolean get_CanRead()
  System.Boolean get_CanTimeout()
  System.Boolean get_CanWrite()
  System.Boolean get_CanSeek()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Int32 get_ReadTimeout()
  System.Void set_ReadTimeout(System.Int32 value)
  System.Int32 get_WriteTimeout()
  System.Void set_WriteTimeout(System.Int32 value)
  System.Void .cctor()
  System.Void <InnerWrite>b__67_0()
END_CLASS

CLASS: Mono.Net.Security.MobileTlsContext
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  private           Mono.Net.Security.ChainValidationHelpercertificateValidator  // 0x10
  private   readonly Mono.Net.Security.MonoSslAuthenticationOptions<Options>k__BackingField  // 0x18
  private   readonly Mono.Net.Security.MobileAuthenticatedStream<Parent>k__BackingField  // 0x20
  private   readonly System.Boolean                  <IsServer>k__BackingField  // 0x28
  private   readonly System.String                   <TargetHost>k__BackingField  // 0x30
  private   readonly System.String                   <ServerName>k__BackingField  // 0x38
  private   readonly System.Boolean                  <AskForClientCertificate>k__BackingField  // 0x40
  private   readonly System.Security.Authentication.SslProtocols<EnabledProtocols>k__BackingField  // 0x44
  private   readonly System.Security.Cryptography.X509Certificates.X509CertificateCollection<ClientCertificates>k__BackingField  // 0x48
  private           System.Security.Cryptography.X509Certificates.X509Certificate<LocalServerCertificate>k__BackingField  // 0x50
METHODS:
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options)
  Mono.Net.Security.MonoSslAuthenticationOptions get_Options()
  Mono.Net.Security.MobileAuthenticatedStream get_Parent()
  Mono.Security.Interface.MonoTlsSettings get_Settings()
  System.Boolean get_IsAuthenticated()
  System.Boolean get_IsServer()
  System.String get_TargetHost()
  System.String get_ServerName()
  System.Boolean get_AskForClientCertificate()
  System.Security.Authentication.SslProtocols get_EnabledProtocols()
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Void GetProtocolVersions(System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max)
  System.Void StartHandshake()
  System.Boolean ProcessHandshake()
  System.Void FinishHandshake()
  System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate()
  System.Void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value)
  System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate()
  System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate()
  System.Void Flush()
  System.ValueTuple<System.Int32,System.Boolean> Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.ValueTuple<System.Int32,System.Boolean> Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Shutdown()
  System.Boolean PendingRenegotiation()
  System.Boolean ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain)
  System.Security.Cryptography.X509Certificates.X509Certificate SelectServerCertificate(System.String serverIdentity)
  System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(System.String[] acceptableIssuers)
  System.Void Renegotiate()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Finalize()
END_CLASS

CLASS: Mono.Net.Security.MobileTlsProvider
TYPE:  class
TOKEN: 0x200005A
EXTENDS: MonoTlsProvider
FIELDS:
METHODS:
  Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings)
  System.Boolean ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11)
  System.Void .ctor()
END_CLASS

CLASS: Mono.Net.Security.MonoSslAuthenticationOptions
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  private           System.Net.Security.ServerCertSelectionCallback<ServerCertSelectionDelegate>k__BackingField  // 0x10
METHODS:
  System.Boolean get_ServerMode()
  System.Boolean get_AllowRenegotiation()
  System.Security.Authentication.SslProtocols get_EnabledSslProtocols()
  System.Void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value)
  System.Void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value)
  System.Void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value)
  System.String get_TargetHost()
  System.Void set_TargetHost(System.String value)
  System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate()
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
  System.Boolean get_ClientCertificateRequired()
  System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate()
  System.Void .ctor()
END_CLASS

CLASS: Mono.Net.Security.MonoSslClientAuthenticationOptions
TYPE:  class
TOKEN: 0x200005C
EXTENDS: MonoSslAuthenticationOptions
FIELDS:
  private   readonly System.Net.Security.SslClientAuthenticationOptions<Options>k__BackingField  // 0x18
METHODS:
  System.Net.Security.SslClientAuthenticationOptions get_Options()
  System.Boolean get_ServerMode()
  System.Void .ctor()
  System.Boolean get_AllowRenegotiation()
  System.Void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value)
  System.Void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value)
  System.Security.Authentication.SslProtocols get_EnabledSslProtocols()
  System.Void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value)
  System.String get_TargetHost()
  System.Void set_TargetHost(System.String value)
  System.Boolean get_ClientCertificateRequired()
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
  System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate()
END_CLASS

CLASS: Mono.Net.Security.MonoTlsProviderFactory
TYPE:  class
TOKEN: 0x200005D
FIELDS:
  private   static  System.Object                   locker  // 0x0
  private   static  System.Boolean                  initialized  // 0x8
  private   static  Mono.Net.Security.MobileTlsProviderdefaultProvider  // 0x10
  private   static  System.Collections.Generic.Dictionary<System.String,System.Tuple<System.Guid,System.String>>providerRegistration  // 0x18
  private   static  System.Collections.Generic.Dictionary<System.Guid,Mono.Net.Security.MobileTlsProvider>providerCache  // 0x20
  private   static readonly System.Guid                     UnityTlsId  // 0x28
  private   static readonly System.Guid                     AppleTlsId  // 0x38
  private   static readonly System.Guid                     BtlsId  // 0x48
METHODS:
  Mono.Net.Security.MobileTlsProvider GetProviderInternal()
  System.Void InitializeInternal()
  Mono.Net.Security.MobileTlsProvider LookupProvider(System.String name, System.Boolean throwOnError)
  System.Void InitializeProviderRegistration()
  System.Void PopulateUnityProviders()
  System.Void PopulateProviders()
  System.Boolean IsBtlsSupported()
  Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl()
  Mono.Net.Security.MobileTlsProvider GetProvider()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Net.Security.MonoTlsStream
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private   readonly Mono.Net.Security.MobileTlsProviderprovider  // 0x10
  private   readonly System.Net.Sockets.NetworkStreamnetworkStream  // 0x18
  private   readonly System.Net.HttpWebRequest       request  // 0x20
  private   readonly Mono.Security.Interface.MonoTlsSettingssettings  // 0x28
  private           System.Net.Security.SslStream   sslStream  // 0x30
  private   readonly System.Object                   sslStreamLock  // 0x38
  private           System.Net.WebExceptionStatus   status  // 0x40
  private           System.Boolean                  <CertificateValidationFailed>k__BackingField  // 0x44
METHODS:
  System.Net.HttpWebRequest get_Request()
  System.Net.WebExceptionStatus get_ExceptionStatus()
  System.Boolean get_CertificateValidationFailed()
  System.Void set_CertificateValidationFailed(System.Boolean value)
  System.Void .ctor(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream)
  System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken)
  System.Void Dispose()
  System.Void CloseSslStream()
END_CLASS

CLASS: Mono.Net.Security.NoReflectionHelper
TYPE:  class
TOKEN: 0x2000060
FIELDS:
METHODS:
  System.Object GetProvider()
END_CLASS

CLASS: Mono.Net.Security.SystemCertificateValidator
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private   static  System.Boolean                  is_macosx  // 0x0
  private   static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagss_flags  // 0x4
METHODS:
  System.Void .cctor()
  System.Boolean NeedsChain(Mono.Security.Interface.MonoTlsSettings settings)
END_CLASS

CLASS: Mono.Net.Security.Private.CallbackHelpers
TYPE:  class
TOKEN: 0x2000062
FIELDS:
METHODS:
  Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback)
  System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback)
END_CLASS

CLASS: Mono.Unity.CertHelper
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.Void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: Mono.Unity.Debug
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, System.String context, Mono.Security.Interface.AlertDescription defaultAlert)
  System.Void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, System.String context, Mono.Security.Interface.AlertDescription defaultAlert)
END_CLASS

CLASS: Mono.Unity.UnityTls
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  Mono.Unity.UnityTls.unitytls_interface_structmarshalledInterface  // 0x0
METHODS:
  System.IntPtr GetUnityTlsInterface()
  System.Boolean get_IsSupported()
  Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface()
END_CLASS

CLASS: Mono.Unity.UnityTlsContext
TYPE:  class
TOKEN: 0x200003E
EXTENDS: MobileTlsContext
FIELDS:
  private           Mono.Unity.UnityTls.unitytls_tlsctx*tlsContext  // 0x58
  private           Mono.Unity.UnityTls.unitytls_x509list*requestedClientCertChain  // 0x60
  private           Mono.Unity.UnityTls.unitytls_key*requestedClientKey  // 0x68
  private           Mono.Unity.UnityTls.unitytls_tlsctx_read_callbackreadCallback  // 0x70
  private           Mono.Unity.UnityTls.unitytls_tlsctx_write_callbackwriteCallback  // 0x78
  private           Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callbackcertificateCallback  // 0x80
  private           Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callbackverifyCallback  // 0x88
  private           System.Security.Cryptography.X509Certificates.X509CertificatelocalClientCertificate  // 0x90
  private           System.Security.Cryptography.X509Certificates.X509Certificate2remoteCertificate  // 0x98
  private           Mono.Security.Interface.MonoTlsConnectionInfoconnectioninfo  // 0xA0
  private           System.Boolean                  isAuthenticated  // 0xA8
  private           System.Boolean                  hasContext  // 0xA9
  private           System.Boolean                  closedGraceful  // 0xAA
  private           System.Byte[]                   writeBuffer  // 0xB0
  private           System.Byte[]                   readBuffer  // 0xB8
  private           System.Runtime.InteropServices.GCHandlehandle  // 0xC0
  private           System.Exception                lastException  // 0xC8
METHODS:
  System.Void .ctor(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options)
  System.Void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_x509list*& nativeCertChain, Mono.Unity.UnityTls.unitytls_key*& nativeKey)
  System.Boolean get_IsAuthenticated()
  System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate()
  System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate()
  System.Void Flush()
  System.ValueTuple<System.Int32,System.Boolean> Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.ValueTuple<System.Int32,System.Boolean> Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Renegotiate()
  System.Boolean PendingRenegotiation()
  System.Void Shutdown()
  System.Void Dispose(System.Boolean disposing)
  System.Void StartHandshake()
  System.Boolean ProcessHandshake()
  System.Void FinishHandshake()
  System.IntPtr WriteCallback(System.Void* userData, System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.IntPtr WriteCallback(System.Byte* data, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.IntPtr ReadCallback(System.Void* userData, System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.IntPtr ReadCallback(System.Byte* buffer, System.IntPtr bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.Void CertificateCallback(System.Void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, System.IntPtr caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.Void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.Byte* cn, System.IntPtr cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, System.IntPtr caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
END_CLASS

CLASS: Mono.Unity.UnityTlsConversions
TYPE:  class
TOKEN: 0x200003F
FIELDS:
METHODS:
  Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols)
  Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols)
  Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol)
  Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert)
  System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult)
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult)
END_CLASS

CLASS: Mono.Unity.UnityTlsProvider
TYPE:  class
TOKEN: 0x2000040
EXTENDS: MobileTlsProvider
FIELDS:
METHODS:
  System.String get_Name()
  System.Guid get_ID()
  System.Boolean get_SupportsSslStream()
  System.Boolean get_SupportsMonoExtensions()
  System.Boolean get_SupportsConnectionInfo()
  System.Boolean get_SupportsCleanShutdown()
  System.Security.Authentication.SslProtocols get_SupportedProtocols()
  Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings)
  Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(System.Void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState)
  System.Boolean ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, System.String targetHost, System.Boolean serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Boolean wantsChain, System.Security.Cryptography.X509Certificates.X509Chain& chain, System.Net.Security.SslPolicyErrors& errors, System.Int32& status11)
  System.Void .ctor()
END_CLASS

CLASS: Mono.Unity.UnityTlsStream
TYPE:  class
TOKEN: 0x2000041
EXTENDS: MobileAuthenticatedStream
FIELDS:
METHODS:
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider)
  Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options)
END_CLASS

CLASS: Mono.Unity.X509ChainImplUnityTls
TYPE:  class
TOKEN: 0x2000042
EXTENDS: X509ChainImpl
FIELDS:
  private           System.Security.Cryptography.X509Certificates.X509ChainElementCollectionelements  // 0x10
  private           Mono.Unity.UnityTls.unitytls_x509list_refnativeCertificateChain  // 0x18
  private           System.Security.Cryptography.X509Certificates.X509ChainPolicypolicy  // 0x20
  private           System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus>chainStatusList  // 0x28
  private           System.Boolean                  reverseOrder  // 0x30
METHODS:
  System.Void .ctor(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, System.Boolean reverseOrder)
  System.Boolean get_IsValid()
  Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain()
  System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements()
  System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error)
  System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy()
  System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void Reset()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: Mono.Util.MonoPInvokeCallbackAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor(System.Type t)
END_CLASS

CLASS: System.IPv4AddressHelper
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
METHODS:
  System.Int32 ParseHostNumber(System.ReadOnlySpan<System.Char> str, System.Int32 start, System.Int32 end)
  System.Boolean IsValid(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean allowIPv6, System.Boolean notImplicitFile, System.Boolean unknownScheme)
  System.Boolean ParseCanonical(System.ReadOnlySpan<System.Char> name, System.Byte* numbers, System.Int32 start, System.Int32 end)
  System.Boolean IsValidCanonical(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean allowIPv6, System.Boolean notImplicitFile)
  System.Int64 ParseNonCanonical(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean notImplicitFile)
  System.String ParseCanonicalName(System.String str, System.Int32 start, System.Int32 end, System.Boolean& isLoopback)
  System.Boolean Parse(System.String name, System.Byte* numbers, System.Int32 start, System.Int32 end)
END_CLASS

CLASS: System.IPv6AddressHelper
TYPE:  class
TOKEN: 0x20000B0
FIELDS:
METHODS:
  System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers)
  System.Boolean ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers)
  System.Boolean IsValidStrict(System.Char* name, System.Int32 start, System.Int32& end)
  System.Void Parse(System.ReadOnlySpan<System.Char> address, System.UInt16* numbers, System.Int32 start, System.String& scopeId)
  System.String ParseCanonicalName(System.String str, System.Int32 start, System.Boolean& isLoopback, System.String& scopeId)
  System.Boolean IsLoopback(System.ReadOnlySpan<System.UInt16> numbers)
  System.Boolean InternalIsValid(System.Char* name, System.Int32 start, System.Int32& end, System.Boolean validateStrictAddress)
  System.Boolean IsValid(System.Char* name, System.Int32 start, System.Int32& end)
END_CLASS

CLASS: System.NotImplemented
TYPE:  class
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Exception ByDesignWithMessage(System.String message)
END_CLASS

CLASS: System.PasteArguments
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
METHODS:
  System.Void AppendArgument(System.Text.StringBuilder stringBuilder, System.String argument)
  System.Boolean ContainsNoWhitespaceOrQuotes(System.String s)
END_CLASS

CLASS: System.StringExtensions
TYPE:  class
TOKEN: 0x20000B3
FIELDS:
METHODS:
  System.String SubstringTrim(System.String value, System.Int32 startIndex)
  System.String SubstringTrim(System.String value, System.Int32 startIndex, System.Int32 length)
END_CLASS

CLASS: System.UriBuilder
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  private           System.Boolean                  _changed  // 0x10
  private           System.String                   _fragment  // 0x18
  private           System.String                   _host  // 0x20
  private           System.String                   _password  // 0x28
  private           System.String                   _path  // 0x30
  private           System.Int32                    _port  // 0x38
  private           System.String                   _query  // 0x40
  private           System.String                   _scheme  // 0x48
  private           System.String                   _schemeDelimiter  // 0x50
  private           System.Uri                      _uri  // 0x58
  private           System.String                   _username  // 0x60
METHODS:
  System.Void .ctor(System.Uri uri)
  System.Void Init(System.Uri uri)
  System.Void set_Path(System.String value)
  System.Uri get_Uri()
  System.Boolean Equals(System.Object rparam)
  System.Int32 GetHashCode()
  System.Void SetFieldsFromUri(System.Uri uri)
  System.String ToString()
END_CLASS

CLASS: System.SecurityUtils
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
METHODS:
  System.Void DemandReflectionAccess(System.Type type)
  System.Void DemandGrantSet(System.Reflection.Assembly assembly)
  System.Boolean HasReflectionPermission(System.Type type)
  System.Object SecureCreateInstance(System.Type type)
  System.Object SecureCreateInstance(System.Type type, System.Object[] args, System.Boolean allowNonPublic)
  System.Object SecureCreateInstance(System.Type type, System.Object[] args)
  System.Object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, System.Object[] args, System.Boolean allowNonPublic)
  System.Object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, System.Object[] args, System.Boolean allowNonPublic, System.Reflection.BindingFlags extraFlags)
  System.Boolean GenericArgumentsAreVisible(System.Reflection.MethodInfo method)
  System.Object MethodInfoInvoke(System.Reflection.MethodInfo method, System.Object target, System.Object[] args)
END_CLASS

CLASS: System.InvariantComparer
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  private           System.Globalization.CompareInfom_compareInfo  // 0x10
  private   static readonly System.InvariantComparer        Default  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 Compare(System.Object a, System.Object b)
  System.Void .cctor()
END_CLASS

CLASS: System.IriHelper
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
METHODS:
  System.Boolean CheckIriUnicodeRange(System.Char unicode, System.Boolean isQuery)
  System.Boolean CheckIriUnicodeRange(System.Char highSurr, System.Char lowSurr, System.Boolean& surrogatePair, System.Boolean isQuery)
  System.Boolean CheckIsReserved(System.Char ch, System.UriComponents component)
  System.String EscapeUnescapeIri(System.Char* pInput, System.Int32 start, System.Int32 end, System.UriComponents component)
END_CLASS

CLASS: System.Uri
TYPE:  class
TOKEN: 0x20000B8
FIELDS:
  public    static readonly System.String                   UriSchemeFile  // 0x0
  public    static readonly System.String                   UriSchemeFtp  // 0x8
  public    static readonly System.String                   UriSchemeGopher  // 0x10
  public    static readonly System.String                   UriSchemeHttp  // 0x18
  public    static readonly System.String                   UriSchemeHttps  // 0x20
  private   static readonly System.String                   UriSchemeWs  // 0x28
  private   static readonly System.String                   UriSchemeWss  // 0x30
  public    static readonly System.String                   UriSchemeMailto  // 0x38
  public    static readonly System.String                   UriSchemeNews  // 0x40
  public    static readonly System.String                   UriSchemeNntp  // 0x48
  public    static readonly System.String                   UriSchemeNetTcp  // 0x50
  public    static readonly System.String                   UriSchemeNetPipe  // 0x58
  public    static readonly System.String                   SchemeDelimiter  // 0x60
  private   static  System.Int32                    c_Max16BitUtf8SequenceLength  // 0x0
  private   static  System.Int32                    c_MaxUriBufferSize  // 0x0
  private   static  System.Int32                    c_MaxUriSchemeName  // 0x0
  private           System.String                   m_String  // 0x10
  private           System.String                   m_originalUnicodeString  // 0x18
  private           System.UriParser                m_Syntax  // 0x20
  private           System.String                   m_DnsSafeHost  // 0x28
  private           System.Uri.Flags                m_Flags  // 0x30
  private           System.Uri.UriInfo              m_Info  // 0x38
  private           System.Boolean                  m_iriParsing  // 0x40
  private   static  System.Boolean                  s_ConfigInitialized  // 0x68
  private   static  System.Boolean                  s_ConfigInitializing  // 0x69
  private   static  System.UriIdnScope              s_IdnScope  // 0x6C
  private   static  System.Boolean                  s_IriParsing  // 0x70
  private   static  System.Boolean                  useDotNetRelativeOrAbsolute  // 0x71
  private   static  System.UriKind                  DotNetRelativeOrAbsolute  // 0x0
  private   static readonly System.Boolean                  IsWindowsFileSystem  // 0x72
  private   static  System.Object                   s_initLock  // 0x78
  private   static  System.UriFormat                V1ToStringUnescape  // 0x0
  private   static  System.Char                     c_DummyChar  // 0x0
  private   static  System.Char                     c_EOL  // 0x0
  private   static readonly System.Char[]                   HexLowerChars  // 0x80
  private   static readonly System.Char[]                   _WSchars  // 0x88
METHODS:
  System.Boolean get_IsImplicitFile()
  System.Boolean get_IsUncOrDosPath()
  System.Boolean get_IsDosPath()
  System.Boolean get_IsUncPath()
  System.Uri.Flags get_HostType()
  System.UriParser get_Syntax()
  System.Boolean get_IsNotAbsoluteUri()
  System.Boolean IriParsingStatic(System.UriParser syntax)
  System.Boolean get_AllowIdn()
  System.Boolean AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags)
  System.Boolean IsIntranet(System.String schemeHost)
  System.Boolean get_UserDrivenParsing()
  System.Void SetUserDrivenParsing()
  System.UInt16 get_SecuredPathIndex()
  System.Boolean NotAny(System.Uri.Flags flags)
  System.Boolean InFact(System.Uri.Flags flags)
  System.Boolean StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags)
  System.Boolean StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags)
  System.Uri.UriInfo EnsureUriInfo()
  System.Void EnsureParseRemaining()
  System.Void EnsureHostString(System.Boolean allowDnsOptimization)
  System.Void .ctor(System.String uriString)
  System.Void .ctor(System.String uriString, System.UriKind uriKind)
  System.Void .ctor(System.Uri baseUri, System.String relativeUri)
  System.Void CreateUri(System.Uri baseUri, System.String relativeUri, System.Boolean dontEscape)
  System.Void .ctor(System.Uri baseUri, System.Uri relativeUri)
  System.ParsingError GetCombinedString(System.Uri baseUri, System.String relativeStr, System.Boolean dontEscape, System.String& result)
  System.UriFormatException GetException(System.ParsingError err)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.String get_AbsolutePath()
  System.String get_PrivateAbsolutePath()
  System.String get_AbsoluteUri()
  System.String get_LocalPath()
  System.String get_Authority()
  System.UriHostNameType get_HostNameType()
  System.Boolean get_IsDefaultPort()
  System.Boolean get_IsFile()
  System.Boolean get_IsLoopback()
  System.String get_PathAndQuery()
  System.String[] get_Segments()
  System.Boolean get_IsUnc()
  System.String get_Host()
  System.Boolean StaticIsFile(System.UriParser syntax)
  System.Object get_InitializeLock()
  System.Void InitializeUriConfig()
  System.String GetLocalPath()
  System.Int32 get_Port()
  System.String get_Query()
  System.String get_Fragment()
  System.String get_Scheme()
  System.Boolean get_OriginalStringSwitched()
  System.String get_OriginalString()
  System.String get_DnsSafeHost()
  System.String get_IdnHost()
  System.Boolean get_IsAbsoluteUri()
  System.Boolean get_UserEscaped()
  System.String get_UserInfo()
  System.String HexEscape(System.Char character)
  System.Boolean IsGenDelim(System.Char ch)
  System.Boolean IsHexDigit(System.Char character)
  System.Int32 FromHex(System.Char digit)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean op_Equality(System.Uri uri1, System.Uri uri2)
  System.Boolean op_Inequality(System.Uri uri1, System.Uri uri2)
  System.Boolean Equals(System.Object comparand)
  System.Uri MakeRelativeUri(System.Uri uri)
  System.Boolean CheckForColonInFirstPathSegment(System.String uriString)
  System.String InternalEscapeString(System.String rawString)
  System.ParsingError ParseScheme(System.String uriString, System.Uri.Flags& flags, System.UriParser& syntax)
  System.UriFormatException ParseMinimal()
  System.ParsingError PrivateParseMinimal()
  System.Void PrivateParseMinimalIri(System.String newHost, System.UInt16 idx)
  System.Void CreateUriInfo(System.Uri.Flags cF)
  System.Void CreateHostString()
  System.String CreateHostStringHelper(System.String str, System.UInt16 idx, System.UInt16 end, System.Uri.Flags& flags, System.String& scopeId)
  System.Void GetHostViaCustomSyntax()
  System.String GetParts(System.UriComponents uriParts, System.UriFormat formatAs)
  System.String GetEscapedParts(System.UriComponents uriParts)
  System.String GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs)
  System.String ReCreateParts(System.UriComponents parts, System.UInt16 nonCanonical, System.UriFormat formatAs)
  System.String GetUriPartsFromUserString(System.UriComponents uriParts)
  System.Void ParseRemaining()
  System.UInt16 ParseSchemeCheckImplicitFile(System.Char* uriString, System.UInt16 length, System.ParsingError& err, System.Uri.Flags& flags, System.UriParser& syntax)
  System.Boolean CheckKnownSchemes(System.Int64* lptr, System.UInt16 nChars, System.UriParser& syntax)
  System.ParsingError CheckSchemeSyntax(System.Char* ptr, System.UInt16 length, System.UriParser& syntax)
  System.UInt16 CheckAuthorityHelper(System.Char* pString, System.UInt16 idx, System.UInt16 length, System.ParsingError& err, System.Uri.Flags& flags, System.UriParser syntax, System.String& newHost)
  System.Void CheckAuthorityHelperHandleDnsIri(System.Char* pString, System.UInt16 start, System.Int32 end, System.Int32 startInput, System.Boolean iriParsing, System.Boolean hasUnicode, System.UriParser syntax, System.String userInfoString, System.Uri.Flags& flags, System.Boolean& justNormalized, System.String& newHost, System.ParsingError& err)
  System.Void CheckAuthorityHelperHandleAnyHostIri(System.Char* pString, System.Int32 startInput, System.Int32 end, System.Boolean iriParsing, System.Boolean hasUnicode, System.UriParser syntax, System.Uri.Flags& flags, System.String& newHost, System.ParsingError& err)
  System.Void FindEndOfComponent(System.String input, System.UInt16& idx, System.UInt16 end, System.Char delim)
  System.Void FindEndOfComponent(System.Char* str, System.UInt16& idx, System.UInt16 end, System.Char delim)
  System.Uri.Check CheckCanonical(System.Char* str, System.UInt16& idx, System.UInt16 end, System.Char delim)
  System.Char[] GetCanonicalPath(System.Char[] dest, System.Int32& pos, System.UriFormat formatAs)
  System.Void UnescapeOnly(System.Char* pch, System.Int32 start, System.Int32& end, System.Char ch1, System.Char ch2, System.Char ch3)
  System.Char[] Compress(System.Char[] dest, System.UInt16 start, System.Int32& destLength, System.UriParser syntax)
  System.Int32 CalculateCaseInsensitiveHashCode(System.String text)
  System.String CombineUri(System.Uri basePart, System.String relativePart, System.UriFormat uriFormat)
  System.String PathDifference(System.String path1, System.String path2, System.Boolean compareCase)
  System.Boolean get_HasAuthority()
  System.Boolean IsLWS(System.Char ch)
  System.Boolean IsAsciiLetter(System.Char character)
  System.Boolean IsAsciiLetterOrDigit(System.Char character)
  System.Boolean IsBidiControlCharacter(System.Char ch)
  System.String StripBidiControlCharacter(System.Char* strToClean, System.Int32 start, System.Int32 length)
  System.Void CreateThis(System.String uri, System.Boolean dontEscape, System.UriKind uriKind)
  System.Void InitializeUri(System.ParsingError err, System.UriKind uriKind, System.UriFormatException& e)
  System.Boolean CheckForConfigLoad(System.String data)
  System.Boolean CheckForUnicode(System.String data)
  System.Boolean CheckForEscapedUnreserved(System.String data)
  System.Boolean TryCreate(System.String uriString, System.UriKind uriKind, System.Uri& result)
  System.Boolean TryCreate(System.Uri baseUri, System.String relativeUri, System.Uri& result)
  System.Boolean TryCreate(System.Uri baseUri, System.Uri relativeUri, System.Uri& result)
  System.String GetComponents(System.UriComponents components, System.UriFormat format)
  System.String UnescapeDataString(System.String stringToUnescape)
  System.String EscapeUnescapeIri(System.String input, System.Int32 start, System.Int32 end, System.UriComponents component)
  System.Void .ctor(System.Uri.Flags flags, System.UriParser uriParser, System.String uri)
  System.Uri CreateHelper(System.String uriString, System.Boolean dontEscape, System.UriKind uriKind, System.UriFormatException& e)
  System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, System.String& newUriString, System.Boolean& userEscaped, System.UriFormatException& e)
  System.String GetRelativeSerializationString(System.UriFormat format)
  System.String GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat)
  System.Boolean IsBaseOf(System.Uri uri)
  System.Boolean IsBaseOfHelper(System.Uri uriLink)
  System.Void CreateThisFromUri(System.Uri otherUri)
  System.Void .cctor()
END_CLASS

CLASS: System.UriFormatException
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: FormatException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String textString)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
END_CLASS

CLASS: System.UriKind
TYPE:  struct
TOKEN: 0x20000BF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriKind                  RelativeOrAbsolute  // 0x0
  public    static  System.UriKind                  Absolute  // 0x0
  public    static  System.UriKind                  Relative  // 0x0
METHODS:
END_CLASS

CLASS: System.UriComponents
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriComponents            Scheme  // 0x0
  public    static  System.UriComponents            UserInfo  // 0x0
  public    static  System.UriComponents            Host  // 0x0
  public    static  System.UriComponents            Port  // 0x0
  public    static  System.UriComponents            Path  // 0x0
  public    static  System.UriComponents            Query  // 0x0
  public    static  System.UriComponents            Fragment  // 0x0
  public    static  System.UriComponents            StrongPort  // 0x0
  public    static  System.UriComponents            NormalizedHost  // 0x0
  public    static  System.UriComponents            KeepDelimiter  // 0x0
  public    static  System.UriComponents            SerializationInfoString  // 0x0
  public    static  System.UriComponents            AbsoluteUri  // 0x0
  public    static  System.UriComponents            HostAndPort  // 0x0
  public    static  System.UriComponents            StrongAuthority  // 0x0
  public    static  System.UriComponents            SchemeAndServer  // 0x0
  public    static  System.UriComponents            HttpRequestUrl  // 0x0
  public    static  System.UriComponents            PathAndQuery  // 0x0
METHODS:
END_CLASS

CLASS: System.UriFormat
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriFormat                UriEscaped  // 0x0
  public    static  System.UriFormat                Unescaped  // 0x0
  public    static  System.UriFormat                SafeUnescaped  // 0x0
METHODS:
END_CLASS

CLASS: System.UriIdnScope
TYPE:  struct
TOKEN: 0x20000C2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriIdnScope              None  // 0x0
  public    static  System.UriIdnScope              AllExceptIntranet  // 0x0
  public    static  System.UriIdnScope              All  // 0x0
METHODS:
END_CLASS

CLASS: System.ParsingError
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.ParsingError             None  // 0x0
  public    static  System.ParsingError             BadFormat  // 0x0
  public    static  System.ParsingError             BadScheme  // 0x0
  public    static  System.ParsingError             BadAuthority  // 0x0
  public    static  System.ParsingError             EmptyUriString  // 0x0
  public    static  System.ParsingError             LastRelativeUriOkErrIndex  // 0x0
  public    static  System.ParsingError             SchemeLimit  // 0x0
  public    static  System.ParsingError             SizeLimit  // 0x0
  public    static  System.ParsingError             MustRootedPath  // 0x0
  public    static  System.ParsingError             BadHostName  // 0x0
  public    static  System.ParsingError             NonEmptyHost  // 0x0
  public    static  System.ParsingError             BadPort  // 0x0
  public    static  System.ParsingError             BadAuthorityTerminator  // 0x0
  public    static  System.ParsingError             CannotCreateRelative  // 0x0
METHODS:
END_CLASS

CLASS: System.UnescapeMode
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UnescapeMode             CopyOnly  // 0x0
  public    static  System.UnescapeMode             Escape  // 0x0
  public    static  System.UnescapeMode             Unescape  // 0x0
  public    static  System.UnescapeMode             EscapeUnescape  // 0x0
  public    static  System.UnescapeMode             V1ToStringFlag  // 0x0
  public    static  System.UnescapeMode             UnescapeAll  // 0x0
  public    static  System.UnescapeMode             UnescapeAllOrThrow  // 0x0
METHODS:
END_CLASS

CLASS: System.UriHelper
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
  private   static readonly System.Char[]                   HexUpperChars  // 0x0
METHODS:
  System.Boolean TestForSubPath(System.Char* pMe, System.UInt16 meLength, System.Char* pShe, System.UInt16 sheLength, System.Boolean ignoreCase)
  System.Char[] EscapeString(System.String input, System.Int32 start, System.Int32 end, System.Char[] dest, System.Int32& destPos, System.Boolean isUriString, System.Char force1, System.Char force2, System.Char rsvd)
  System.Char[] EnsureDestinationSize(System.Char* pStr, System.Char[] dest, System.Int32 currentInputPos, System.Int16 charsToAdd, System.Int16 minReallocateChars, System.Int32& destPos, System.Int32 prevInputPos)
  System.Char[] UnescapeString(System.String input, System.Int32 start, System.Int32 end, System.Char[] dest, System.Int32& destPosition, System.Char rsvd1, System.Char rsvd2, System.Char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, System.Boolean isQuery)
  System.Char[] UnescapeString(System.Char* pStr, System.Int32 start, System.Int32 end, System.Char[] dest, System.Int32& destPosition, System.Char rsvd1, System.Char rsvd2, System.Char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, System.Boolean isQuery)
  System.Void MatchUTF8Sequence(System.Char* pDest, System.Char[] dest, System.Int32& destOffset, System.Char[] unescapedChars, System.Int32 charCount, System.Byte[] bytes, System.Int32 byteCount, System.Boolean isQuery, System.Boolean iriParsing)
  System.Void EscapeAsciiChar(System.Char ch, System.Char[] to, System.Int32& pos)
  System.Char EscapedAscii(System.Char digit, System.Char next)
  System.Boolean IsNotSafeForUnescape(System.Char ch)
  System.Boolean IsReservedUnreservedOrHash(System.Char c)
  System.Boolean IsUnreserved(System.Char c)
  System.Boolean Is3986Unreserved(System.Char c)
  System.Void .cctor()
END_CLASS

CLASS: System.UriHostNameType
TYPE:  struct
TOKEN: 0x20000C6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriHostNameType          Unknown  // 0x0
  public    static  System.UriHostNameType          Basic  // 0x0
  public    static  System.UriHostNameType          Dns  // 0x0
  public    static  System.UriHostNameType          IPv4  // 0x0
  public    static  System.UriHostNameType          IPv6  // 0x0
METHODS:
END_CLASS

CLASS: System.UriParser
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
  private   static  System.UriSyntaxFlags           SchemeOnlyFlags  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.UriParser>m_Table  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,System.UriParser>m_TempTable  // 0x8
  private           System.UriSyntaxFlags           m_Flags  // 0x10
  private           System.UriSyntaxFlags           m_UpdatableFlags  // 0x14
  private           System.Boolean                  m_UpdatableFlagsUsed  // 0x18
  private   static  System.UriSyntaxFlags           c_UpdatableFlags  // 0x0
  private           System.Int32                    m_Port  // 0x1C
  private           System.String                   m_Scheme  // 0x20
  private   static  System.Int32                    NoDefaultPort  // 0x0
  private   static  System.Int32                    c_InitialTableSize  // 0x0
  private   static  System.UriParser                HttpUri  // 0x10
  private   static  System.UriParser                HttpsUri  // 0x18
  private   static  System.UriParser                WsUri  // 0x20
  private   static  System.UriParser                WssUri  // 0x28
  private   static  System.UriParser                FtpUri  // 0x30
  private   static  System.UriParser                FileUri  // 0x38
  private   static  System.UriParser                GopherUri  // 0x40
  private   static  System.UriParser                NntpUri  // 0x48
  private   static  System.UriParser                NewsUri  // 0x50
  private   static  System.UriParser                MailToUri  // 0x58
  private   static  System.UriParser                UuidUri  // 0x60
  private   static  System.UriParser                TelnetUri  // 0x68
  private   static  System.UriParser                LdapUri  // 0x70
  private   static  System.UriParser                NetTcpUri  // 0x78
  private   static  System.UriParser                NetPipeUri  // 0x80
  private   static  System.UriParser                VsMacrosUri  // 0x88
  private   static readonly System.UriParser.UriQuirksVersions_QuirksVersion  // 0x90
  private   static  System.Int32                    c_MaxCapacity  // 0x0
  private   static  System.UriSyntaxFlags           UnknownV1SyntaxFlags  // 0x0
  private   static readonly System.UriSyntaxFlags           HttpSyntaxFlags  // 0x94
  private   static  System.UriSyntaxFlags           FtpSyntaxFlags  // 0x0
  private   static readonly System.UriSyntaxFlags           FileSyntaxFlags  // 0x98
  private   static  System.UriSyntaxFlags           VsmacrosSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           GopherSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           NewsSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           NntpSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           TelnetSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           LdapSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           MailtoSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           NetPipeSyntaxFlags  // 0x0
  private   static  System.UriSyntaxFlags           NetTcpSyntaxFlags  // 0x0
METHODS:
  System.String get_SchemeName()
  System.Int32 get_DefaultPort()
  System.UriParser OnNewUri()
  System.Void InitializeAndValidate(System.Uri uri, System.UriFormatException& parsingError)
  System.String Resolve(System.Uri baseUri, System.Uri relativeUri, System.UriFormatException& parsingError)
  System.Boolean IsBaseOf(System.Uri baseUri, System.Uri relativeUri)
  System.String GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format)
  System.Boolean get_ShouldUseLegacyV2Quirks()
  System.Void .cctor()
  System.UriSyntaxFlags get_Flags()
  System.Boolean NotAny(System.UriSyntaxFlags flags)
  System.Boolean InFact(System.UriSyntaxFlags flags)
  System.Boolean IsAllSet(System.UriSyntaxFlags flags)
  System.Boolean IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected)
  System.Void .ctor(System.UriSyntaxFlags flags)
  System.UriParser FindOrFetchAsUnknownV1Syntax(System.String lwrCaseScheme)
  System.UriParser GetSyntax(System.String lwrCaseScheme)
  System.Boolean get_IsSimple()
  System.UriParser InternalOnNewUri()
  System.Void InternalValidate(System.Uri thisUri, System.UriFormatException& parsingError)
  System.String InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, System.UriFormatException& parsingError)
  System.Boolean InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink)
  System.String InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat)
END_CLASS

CLASS: System.DomainNameHelper
TYPE:  class
TOKEN: 0x20000CA
FIELDS:
METHODS:
  System.String ParseCanonicalName(System.String str, System.Int32 start, System.Int32 end, System.Boolean& loopback)
  System.Boolean IsValid(System.Char* name, System.UInt16 pos, System.Int32& returnedEnd, System.Boolean& notCanonical, System.Boolean notImplicitFile)
  System.Boolean IsValidByIri(System.Char* name, System.UInt16 pos, System.Int32& returnedEnd, System.Boolean& notCanonical, System.Boolean notImplicitFile)
  System.String IdnEquivalent(System.String hostname)
  System.String IdnEquivalent(System.Char* hostname, System.Int32 start, System.Int32 end, System.Boolean& allAscii, System.Boolean& atLeastOneValidIdn)
  System.String IdnEquivalent(System.Char* hostname, System.Int32 start, System.Int32 end, System.Boolean& allAscii, System.String& bidiStrippedHost)
  System.Boolean IsIdnAce(System.String input, System.Int32 index)
  System.Boolean IsIdnAce(System.Char* input, System.Int32 index)
  System.String UnicodeEquivalent(System.String idnHost, System.Char* hostname, System.Int32 start, System.Int32 end)
  System.String UnicodeEquivalent(System.Char* hostname, System.Int32 start, System.Int32 end, System.Boolean& allAscii, System.Boolean& atLeastOneValidIdn)
  System.Boolean IsASCIILetterOrDigit(System.Char character, System.Boolean& notCanonical)
  System.Boolean IsValidDomainLabelCharacter(System.Char character, System.Boolean& notCanonical)
END_CLASS

CLASS: System.UncNameHelper
TYPE:  class
TOKEN: 0x20000CB
FIELDS:
METHODS:
  System.String ParseCanonicalName(System.String str, System.Int32 start, System.Int32 end, System.Boolean& loopback)
  System.Boolean IsValid(System.Char* name, System.UInt16 start, System.Int32& returnedEnd, System.Boolean notImplicitFile)
END_CLASS

CLASS: System.UriSyntaxFlags
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.UriSyntaxFlags           None  // 0x0
  public    static  System.UriSyntaxFlags           MustHaveAuthority  // 0x0
  public    static  System.UriSyntaxFlags           OptionalAuthority  // 0x0
  public    static  System.UriSyntaxFlags           MayHaveUserInfo  // 0x0
  public    static  System.UriSyntaxFlags           MayHavePort  // 0x0
  public    static  System.UriSyntaxFlags           MayHavePath  // 0x0
  public    static  System.UriSyntaxFlags           MayHaveQuery  // 0x0
  public    static  System.UriSyntaxFlags           MayHaveFragment  // 0x0
  public    static  System.UriSyntaxFlags           AllowEmptyHost  // 0x0
  public    static  System.UriSyntaxFlags           AllowUncHost  // 0x0
  public    static  System.UriSyntaxFlags           AllowDnsHost  // 0x0
  public    static  System.UriSyntaxFlags           AllowIPv4Host  // 0x0
  public    static  System.UriSyntaxFlags           AllowIPv6Host  // 0x0
  public    static  System.UriSyntaxFlags           AllowAnInternetHost  // 0x0
  public    static  System.UriSyntaxFlags           AllowAnyOtherHost  // 0x0
  public    static  System.UriSyntaxFlags           FileLikeUri  // 0x0
  public    static  System.UriSyntaxFlags           MailToLikeUri  // 0x0
  public    static  System.UriSyntaxFlags           V1_UnknownUri  // 0x0
  public    static  System.UriSyntaxFlags           SimpleUserSyntax  // 0x0
  public    static  System.UriSyntaxFlags           BuiltInSyntax  // 0x0
  public    static  System.UriSyntaxFlags           ParserSchemeOnly  // 0x0
  public    static  System.UriSyntaxFlags           AllowDOSPath  // 0x0
  public    static  System.UriSyntaxFlags           PathIsRooted  // 0x0
  public    static  System.UriSyntaxFlags           ConvertPathSlashes  // 0x0
  public    static  System.UriSyntaxFlags           CompressPath  // 0x0
  public    static  System.UriSyntaxFlags           CanonicalizeAsFilePath  // 0x0
  public    static  System.UriSyntaxFlags           UnEscapeDotsAndSlashes  // 0x0
  public    static  System.UriSyntaxFlags           AllowIdn  // 0x0
  public    static  System.UriSyntaxFlags           AllowIriParsing  // 0x0
METHODS:
END_CLASS

CLASS: System.LocalAppContextSwitches
TYPE:  class
TOKEN: 0x20000CD
FIELDS:
  public    static readonly System.Boolean                  MemberDescriptorEqualsReturnsFalseIfEquivalent  // 0x0
METHODS:
END_CLASS

CLASS: System.IOOperation
TYPE:  struct
TOKEN: 0x20000CE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IOOperation              Read  // 0x0
  public    static  System.IOOperation              Write  // 0x0
METHODS:
END_CLASS

CLASS: System.IOAsyncCallback
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IOAsyncResult ioares)
END_CLASS

CLASS: System.IOAsyncResult
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
  private           System.AsyncCallback            async_callback  // 0x10
  private           System.Object                   async_state  // 0x18
  private           System.Threading.ManualResetEventwait_handle  // 0x20
  private           System.Boolean                  completed_synchronously  // 0x28
  private           System.Boolean                  completed  // 0x29
METHODS:
  System.Void .ctor()
  System.Void Init(System.AsyncCallback async_callback, System.Object async_state)
  System.Void .ctor(System.AsyncCallback async_callback, System.Object async_state)
  System.AsyncCallback get_AsyncCallback()
  System.Object get_AsyncState()
  System.Threading.WaitHandle get_AsyncWaitHandle()
  System.Boolean get_CompletedSynchronously()
  System.Void set_CompletedSynchronously(System.Boolean value)
  System.Boolean get_IsCompleted()
  System.Void set_IsCompleted(System.Boolean value)
  System.Void CompleteDisposed()
END_CLASS

CLASS: System.IOSelectorJob
TYPE:  class
TOKEN: 0x20000D1
FIELDS:
  private           System.IOOperation              operation  // 0x10
  private           System.IOAsyncCallback          callback  // 0x18
  private           System.IOAsyncResult            state  // 0x20
METHODS:
  System.Void .ctor(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state)
  System.Void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
  System.Void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae)
  System.Void MarkDisposed()
END_CLASS

CLASS: System.IOSelector
TYPE:  class
TOKEN: 0x20000D2
FIELDS:
METHODS:
  System.Void Add(System.IntPtr handle, System.IOSelectorJob job)
END_CLASS

CLASS: System.UriTypeConverter
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean CanConvert(System.Type type)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.CodeDom.Compiler.GeneratedCodeAttribute
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   tool  // 0x10
  private   readonly System.String                   version  // 0x18
METHODS:
  System.Void .ctor(System.String tool, System.String version)
END_CLASS

CLASS: System.Collections.HashtableExtensions
TYPE:  class
TOKEN: 0x200031E
FIELDS:
METHODS:
  System.Boolean TryGetValue(System.Collections.Hashtable table, System.Object key, T& value)
END_CLASS

CLASS: System.Collections.Concurrent.BlockingCollection`1
TYPE:  class
TOKEN: 0x200033A
FIELDS:
  private           System.Collections.Concurrent.IProducerConsumerCollection<T>_collection  // 0x0
  private           System.Int32                    _boundedCapacity  // 0x0
  private           System.Threading.SemaphoreSlim  _freeNodes  // 0x0
  private           System.Threading.SemaphoreSlim  _occupiedNodes  // 0x0
  private           System.Boolean                  _isDisposed  // 0x0
  private           System.Threading.CancellationTokenSource_consumersCancellationTokenSource  // 0x0
  private           System.Threading.CancellationTokenSource_producersCancellationTokenSource  // 0x0
  private           System.Int32                    _currentAdders  // 0x0
METHODS:
  System.Boolean get_IsAddingCompleted()
  System.Int32 get_Count()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void .ctor()
  System.Void .ctor(System.Collections.Concurrent.IProducerConsumerCollection<T> collection)
  System.Void Initialize(System.Collections.Concurrent.IProducerConsumerCollection<T> collection, System.Int32 boundedCapacity, System.Int32 collectionCount)
  System.Void Add(T item)
  System.Boolean TryAddWithNoTimeValidation(T item, System.Int32 millisecondsTimeout, System.Threading.CancellationToken cancellationToken)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void CheckDisposed()
END_CLASS

CLASS: System.Collections.Concurrent.BlockingCollectionDebugView`1
TYPE:  class
TOKEN: 0x200033B
FIELDS:
METHODS:
END_CLASS

CLASS: System.Collections.Concurrent.ConcurrentBag`1
TYPE:  class
TOKEN: 0x200033C
FIELDS:
  private   readonly System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>>_locals  // 0x0
  private           System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>_workStealingQueues  // 0x0
  private           System.Int64                    _emptyToNonEmptyListTransitionCount  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Add(T item)
  System.Boolean System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item)
  System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(System.Boolean forceCreate)
  System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread()
  System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue()
  System.Void CopyTo(T[] array, System.Int32 index)
  System.Int32 CopyFromEachQueueToArray(T[] array, System.Int32 index)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  T[] ToArray()
  System.Void Clear()
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 get_Count()
  System.Int32 get_DangerousCount()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Object get_GlobalQueuesLock()
  System.Void FreezeBag(System.Boolean& lockTaken)
  System.Void UnfreezeBag(System.Boolean lockTaken)
END_CLASS

CLASS: System.Collections.Generic.ValueListBuilder`1
TYPE:  struct
TOKEN: 0x200033F
FIELDS:
  private           System.Span<T>                  _span  // 0x0
  private           T[]                             _arrayFromPool  // 0x0
  private           System.Int32                    _pos  // 0x0
METHODS:
  System.Void .ctor(System.Span<T> initialSpan)
  System.Int32 get_Length()
  T& get_Item(System.Int32 index)
  System.Void Append(T item)
  System.ReadOnlySpan<T> AsSpan()
  System.Void Dispose()
  System.Void Grow()
  T Pop()
END_CLASS

CLASS: System.Collections.Generic.ICollectionDebugView`1
TYPE:  class
TOKEN: 0x2000340
FIELDS:
METHODS:
END_CLASS

CLASS: System.Collections.Generic.IDictionaryDebugView`2
TYPE:  class
TOKEN: 0x2000341
FIELDS:
METHODS:
END_CLASS

CLASS: System.Collections.Generic.DictionaryKeyCollectionDebugView`2
TYPE:  class
TOKEN: 0x2000342
FIELDS:
METHODS:
END_CLASS

CLASS: System.Collections.Generic.DictionaryValueCollectionDebugView`2
TYPE:  class
TOKEN: 0x2000343
FIELDS:
METHODS:
END_CLASS

CLASS: System.Collections.Generic.LinkedList`1
TYPE:  class
TOKEN: 0x2000344
FIELDS:
  private           System.Collections.Generic.LinkedListNode<T>head  // 0x0
  private           System.Int32                    count  // 0x0
  private           System.Int32                    version  // 0x0
  private           System.Object                   _syncRoot  // 0x0
  private           System.Runtime.Serialization.SerializationInfo_siInfo  // 0x0
  private   static  System.String                   VersionName  // 0x0
  private   static  System.String                   CountName  // 0x0
  private   static  System.String                   ValuesName  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Int32 get_Count()
  System.Collections.Generic.LinkedListNode<T> get_First()
  System.Collections.Generic.LinkedListNode<T> get_Last()
  System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
  System.Void System.Collections.Generic.ICollection<T>.Add(T value)
  System.Void AddAfter(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode)
  System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> node, T value)
  System.Collections.Generic.LinkedListNode<T> AddFirst(T value)
  System.Void AddFirst(System.Collections.Generic.LinkedListNode<T> node)
  System.Collections.Generic.LinkedListNode<T> AddLast(T value)
  System.Void AddLast(System.Collections.Generic.LinkedListNode<T> node)
  System.Void Clear()
  System.Boolean Contains(T value)
  System.Void CopyTo(T[] array, System.Int32 index)
  System.Collections.Generic.LinkedListNode<T> Find(T value)
  System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Boolean Remove(T value)
  System.Void Remove(System.Collections.Generic.LinkedListNode<T> node)
  System.Void RemoveFirst()
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void OnDeserialization(System.Object sender)
  System.Void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode)
  System.Void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode)
  System.Void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node)
  System.Void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node)
  System.Void ValidateNode(System.Collections.Generic.LinkedListNode<T> node)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: System.Collections.Generic.LinkedListNode`1
TYPE:  class
TOKEN: 0x2000346
FIELDS:
  private           System.Collections.Generic.LinkedList<T>list  // 0x0
  private           System.Collections.Generic.LinkedListNode<T>next  // 0x0
  private           System.Collections.Generic.LinkedListNode<T>prev  // 0x0
  private           T                               item  // 0x0
METHODS:
  System.Void .ctor(T value)
  System.Void .ctor(System.Collections.Generic.LinkedList<T> list, T value)
  System.Collections.Generic.LinkedList<T> get_List()
  System.Collections.Generic.LinkedListNode<T> get_Next()
  System.Collections.Generic.LinkedListNode<T> get_Previous()
  T get_Value()
  System.Void set_Value(T value)
  System.Void Invalidate()
END_CLASS

CLASS: System.Collections.Generic.SortedDictionary`2
TYPE:  class
TOKEN: 0x2000347
FIELDS:
  private           System.Collections.Generic.SortedDictionary.KeyCollection<TKey,TValue>_keys  // 0x0
  private           System.Collections.Generic.SortedDictionary.ValueCollection<TKey,TValue>_values  // 0x0
  private           System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey,TValue>>_set  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly()
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Int32 get_Count()
  System.Collections.Generic.SortedDictionary.KeyCollection<TKey,TValue> get_Keys()
  System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys()
  System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys()
  System.Collections.Generic.SortedDictionary.ValueCollection<TKey,TValue> get_Values()
  System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values()
  System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values()
  System.Void Add(TKey key, TValue value)
  System.Void Clear()
  System.Boolean ContainsKey(TKey key)
  System.Boolean ContainsValue(TValue value)
  System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 index)
  System.Collections.Generic.SortedDictionary.Enumerator<TKey,TValue> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
  System.Boolean Remove(TKey key)
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.IDictionary.get_IsFixedSize()
  System.Boolean System.Collections.IDictionary.get_IsReadOnly()
  System.Collections.ICollection System.Collections.IDictionary.get_Keys()
  System.Collections.ICollection System.Collections.IDictionary.get_Values()
  System.Object System.Collections.IDictionary.get_Item(System.Object key)
  System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value)
  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  System.Boolean IsCompatibleKey(System.Object key)
  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  System.Void System.Collections.IDictionary.Remove(System.Object key)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: System.Collections.Generic.TreeSet`1
TYPE:  class
TOKEN: 0x2000354
EXTENDS: SortedSet`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<T> comparer)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context)
  System.Boolean AddIfNotPresent(T item)
END_CLASS

CLASS: System.Collections.Generic.SortedList`2
TYPE:  class
TOKEN: 0x2000355
FIELDS:
  private           TKey[]                          keys  // 0x0
  private           TValue[]                        values  // 0x0
  private           System.Int32                    _size  // 0x0
  private           System.Int32                    version  // 0x0
  private           System.Collections.Generic.IComparer<TKey>comparer  // 0x0
  private           System.Collections.Generic.SortedList.KeyList<TKey,TValue>keyList  // 0x0
  private           System.Collections.Generic.SortedList.ValueList<TKey,TValue>valueList  // 0x0
  private           System.Object                   _syncRoot  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<TKey> comparer)
  System.Void .ctor(System.Int32 capacity, System.Collections.Generic.IComparer<TKey> comparer)
  System.Void Add(TKey key, TValue value)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair)
  System.Void set_Capacity(System.Int32 value)
  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  System.Int32 get_Count()
  System.Collections.Generic.IList<TKey> get_Keys()
  System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys()
  System.Collections.ICollection System.Collections.IDictionary.get_Keys()
  System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys()
  System.Collections.Generic.IList<TValue> get_Values()
  System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values()
  System.Collections.ICollection System.Collections.IDictionary.get_Values()
  System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values()
  System.Collections.Generic.SortedList.KeyList<TKey,TValue> GetKeyListHelper()
  System.Collections.Generic.SortedList.ValueList<TKey,TValue> GetValueListHelper()
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly()
  System.Boolean System.Collections.IDictionary.get_IsReadOnly()
  System.Boolean System.Collections.IDictionary.get_IsFixedSize()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void Clear()
  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  System.Boolean ContainsKey(TKey key)
  System.Boolean ContainsValue(TValue value)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Void EnsureCapacity(System.Int32 min)
  TValue GetByIndex(System.Int32 index)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  TKey GetKey(System.Int32 index)
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Object System.Collections.IDictionary.get_Item(System.Object key)
  System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value)
  System.Int32 IndexOfKey(TKey key)
  System.Int32 IndexOfValue(TValue value)
  System.Void Insert(System.Int32 index, TKey key, TValue value)
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Void RemoveAt(System.Int32 index)
  System.Boolean Remove(TKey key)
  System.Void System.Collections.IDictionary.Remove(System.Object key)
  System.Boolean IsCompatibleKey(System.Object key)
END_CLASS

CLASS: System.Collections.Generic.SortedSet`1
TYPE:  class
TOKEN: 0x200035B
FIELDS:
  private           System.Collections.Generic.SortedSet.Node<T>root  // 0x0
  private           System.Collections.Generic.IComparer<T>comparer  // 0x0
  private           System.Int32                    count  // 0x0
  private           System.Int32                    version  // 0x0
  private           System.Object                   _syncRoot  // 0x0
  private           System.Runtime.Serialization.SerializationInfosiInfo  // 0x0
  private   static  System.String                   ComparerName  // 0x0
  private   static  System.String                   CountName  // 0x0
  private   static  System.String                   ItemsName  // 0x0
  private   static  System.String                   VersionName  // 0x0
  private   static  System.String                   TreeName  // 0x0
  private   static  System.String                   NodeValueName  // 0x0
  private   static  System.String                   EnumStartName  // 0x0
  private   static  System.String                   ReverseName  // 0x0
  private   static  System.String                   EnumVersionName  // 0x0
  private   static  System.String                   MinName  // 0x0
  private   static  System.String                   MaxName  // 0x0
  private   static  System.String                   LowerBoundActiveName  // 0x0
  private   static  System.String                   UpperBoundActiveName  // 0x0
  private   static  System.Int32                    StackAllocThreshold  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IComparer<T> comparer)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Boolean InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action)
  System.Int32 get_Count()
  System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void VersionCheck()
  System.Boolean IsWithinRange(T item)
  System.Boolean Add(T item)
  System.Void System.Collections.Generic.ICollection<T>.Add(T item)
  System.Boolean AddIfNotPresent(T item)
  System.Boolean Remove(T item)
  System.Boolean DoRemove(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 index)
  System.Void CopyTo(T[] array, System.Int32 index, System.Int32 count)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T>& parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent)
  System.Void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild)
  System.Void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor)
  System.Collections.Generic.SortedSet.Node<T> FindNode(T item)
  System.Void UpdateVersion()
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender)
  System.Void OnDeserialization(System.Object sender)
  System.Int32 Log2(System.Int32 value)
END_CLASS

CLASS: System.Collections.Generic.NodeColor
TYPE:  struct
TOKEN: 0x2000360
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Collections.Generic.NodeColorBlack  // 0x0
  public    static  System.Collections.Generic.NodeColorRed  // 0x0
METHODS:
END_CLASS

CLASS: System.Collections.Generic.TreeWalkPredicate`1
TYPE:  class
TOKEN: 0x2000361
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Collections.Generic.SortedSet.Node<T> node)
END_CLASS

CLASS: System.Collections.Generic.TreeRotation
TYPE:  struct
TOKEN: 0x2000362
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Collections.Generic.TreeRotationLeft  // 0x0
  public    static  System.Collections.Generic.TreeRotationLeftRight  // 0x0
  public    static  System.Collections.Generic.TreeRotationRight  // 0x0
  public    static  System.Collections.Generic.TreeRotationRightLeft  // 0x0
METHODS:
END_CLASS

CLASS: System.Collections.Generic.CollectionDebugView`1
TYPE:  class
TOKEN: 0x2000363
FIELDS:
METHODS:
END_CLASS

CLASS: System.Collections.Generic.ISet`1
TYPE:  interface
TOKEN: 0x2000364
FIELDS:
METHODS:
  System.Boolean Add(T item)
END_CLASS

CLASS: System.Collections.ObjectModel.ObservableCollection`1
TYPE:  class
TOKEN: 0x200031F
EXTENDS: Collection`1
FIELDS:
  private           System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T>_monitor  // 0x0
  private           System.Int32                    _blockReentrancyCount  // 0x0
  private           System.Collections.Specialized.NotifyCollectionChangedEventHandlerCollectionChanged  // 0x0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection)
  System.Collections.Generic.List<T> CreateCopy(System.Collections.Generic.IEnumerable<T> collection, System.String paramName)
  System.Void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void ClearItems()
  System.Void RemoveItem(System.Int32 index)
  System.Void InsertItem(System.Int32 index, T item)
  System.Void SetItem(System.Int32 index, T item)
  System.Void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
  System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  System.Void CheckReentrancy()
  System.Void OnCountPropertyChanged()
  System.Void OnIndexerPropertyChanged()
  System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object item, System.Int32 index)
  System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object oldItem, System.Object newItem, System.Int32 index)
  System.Void OnCollectionReset()
  System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> EnsureMonitorInitialized()
  System.Void OnSerializing(System.Runtime.Serialization.StreamingContext context)
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: System.Collections.ObjectModel.EventArgsCache
TYPE:  class
TOKEN: 0x2000321
FIELDS:
  private   static readonly System.ComponentModel.PropertyChangedEventArgsCountPropertyChanged  // 0x0
  private   static readonly System.ComponentModel.PropertyChangedEventArgsIndexerPropertyChanged  // 0x8
  private   static readonly System.Collections.Specialized.NotifyCollectionChangedEventArgsResetCollectionChanged  // 0x10
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Collections.ObjectModel.ReadOnlyObservableCollection`1
TYPE:  class
TOKEN: 0x2000322
EXTENDS: ReadOnlyCollection`1
FIELDS:
  private           System.Collections.Specialized.NotifyCollectionChangedEventHandlerCollectionChanged  // 0x0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x0
METHODS:
  System.Void .ctor(System.Collections.ObjectModel.ObservableCollection<T> list)
  System.Void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
  System.Void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
  System.Void HandleCollectionChanged(System.Object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  System.Void HandlePropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
END_CLASS

CLASS: System.Collections.Specialized.BitVector32
TYPE:  struct
TOKEN: 0x2000323
FIELDS:
  private           System.UInt32                   _data  // 0x10
METHODS:
  System.Boolean get_Item(System.Int32 bit)
  System.Void set_Item(System.Int32 bit, System.Boolean value)
  System.Int32 CreateMask()
  System.Int32 CreateMask(System.Int32 previous)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString(System.Collections.Specialized.BitVector32 value)
  System.String ToString()
END_CLASS

CLASS: System.Collections.Specialized.ListDictionary
TYPE:  class
TOKEN: 0x2000324
FIELDS:
  private           System.Collections.Specialized.ListDictionary.DictionaryNodehead  // 0x10
  private           System.Int32                    version  // 0x18
  private           System.Int32                    count  // 0x1C
  private   readonly System.Collections.IComparer    comparer  // 0x20
  private           System.Object                   _syncRoot  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.IComparer comparer)
  System.Object get_Item(System.Object key)
  System.Void set_Item(System.Object key, System.Object value)
  System.Int32 get_Count()
  System.Collections.ICollection get_Keys()
  System.Boolean get_IsReadOnly()
  System.Boolean get_IsFixedSize()
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Collections.ICollection get_Values()
  System.Void Add(System.Object key, System.Object value)
  System.Void Clear()
  System.Boolean Contains(System.Object key)
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Collections.IDictionaryEnumerator GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Remove(System.Object key)
END_CLASS

CLASS: System.Collections.Specialized.NameValueCollection
TYPE:  class
TOKEN: 0x2000329
EXTENDS: NameObjectCollectionBase
FIELDS:
  private           System.String[]                 _all  // 0x58
  private           System.String[]                 _allKeys  // 0x60
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity, System.Collections.IEqualityComparer equalityComparer)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void InvalidateCachedArrays()
  System.String GetAsOneString(System.Collections.ArrayList list)
  System.String[] GetAsStringArray(System.Collections.ArrayList list)
  System.Void Add(System.String name, System.String value)
  System.String Get(System.String name)
  System.String[] GetValues(System.String name)
  System.Void Set(System.String name, System.String value)
  System.Void Remove(System.String name)
  System.String get_Item(System.String name)
  System.Void set_Item(System.String name, System.String value)
  System.String Get(System.Int32 index)
  System.String[] GetValues(System.Int32 index)
  System.String GetKey(System.Int32 index)
  System.String[] get_AllKeys()
  System.Void .ctor(System.DBNull dummy)
END_CLASS

CLASS: System.Collections.Specialized.OrderedDictionary
TYPE:  class
TOKEN: 0x200032A
FIELDS:
  private           System.Collections.ArrayList    _objectsArray  // 0x10
  private           System.Collections.Hashtable    _objectsTable  // 0x18
  private           System.Int32                    _initialCapacity  // 0x20
  private           System.Collections.IEqualityComparer_comparer  // 0x28
  private           System.Boolean                  _readOnly  // 0x30
  private           System.Object                   _syncRoot  // 0x38
  private           System.Runtime.Serialization.SerializationInfo_siInfo  // 0x40
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Int32 capacity, System.Collections.IEqualityComparer comparer)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Int32 get_Count()
  System.Boolean System.Collections.IDictionary.get_IsFixedSize()
  System.Boolean get_IsReadOnly()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Collections.ICollection get_Keys()
  System.Collections.ArrayList get_objectsArray()
  System.Collections.Hashtable get_objectsTable()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Object get_Item(System.Object key)
  System.Void set_Item(System.Object key, System.Object value)
  System.Collections.ICollection get_Values()
  System.Void Add(System.Object key, System.Object value)
  System.Void Clear()
  System.Boolean Contains(System.Object key)
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Int32 IndexOfKey(System.Object key)
  System.Void Remove(System.Object key)
  System.Collections.IDictionaryEnumerator GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object sender)
  System.Void OnDeserialization(System.Object sender)
END_CLASS

CLASS: System.Collections.Specialized.StringCollection
TYPE:  class
TOKEN: 0x200032D
FIELDS:
  private   readonly System.Collections.ArrayList    data  // 0x10
METHODS:
  System.String get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.String value)
  System.Int32 get_Count()
  System.Boolean System.Collections.IList.get_IsReadOnly()
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Int32 Add(System.String value)
  System.Void Clear()
  System.Boolean Contains(System.String value)
  System.Void CopyTo(System.String[] array, System.Int32 index)
  System.Int32 IndexOf(System.String value)
  System.Void Insert(System.Int32 index, System.String value)
  System.Boolean get_IsSynchronized()
  System.Void Remove(System.String value)
  System.Void RemoveAt(System.Int32 index)
  System.Object get_SyncRoot()
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void .ctor()
END_CLASS

CLASS: System.Collections.Specialized.StringDictionary
TYPE:  class
TOKEN: 0x200032E
FIELDS:
  private           System.Collections.Hashtable    contents  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Add(System.String key, System.String value)
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: System.Collections.Specialized.INotifyCollectionChanged
TYPE:  interface
TOKEN: 0x200032F
FIELDS:
METHODS:
  System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
END_CLASS

CLASS: System.Collections.Specialized.NotifyCollectionChangedAction
TYPE:  struct
TOKEN: 0x2000330
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Collections.Specialized.NotifyCollectionChangedActionAdd  // 0x0
  public    static  System.Collections.Specialized.NotifyCollectionChangedActionRemove  // 0x0
  public    static  System.Collections.Specialized.NotifyCollectionChangedActionReplace  // 0x0
  public    static  System.Collections.Specialized.NotifyCollectionChangedActionMove  // 0x0
  public    static  System.Collections.Specialized.NotifyCollectionChangedActionReset  // 0x0
METHODS:
END_CLASS

CLASS: System.Collections.Specialized.NotifyCollectionChangedEventArgs
TYPE:  class
TOKEN: 0x2000331
EXTENDS: EventArgs
FIELDS:
  private           System.Collections.Specialized.NotifyCollectionChangedAction_action  // 0x10
  private           System.Collections.IList        _newItems  // 0x18
  private           System.Collections.IList        _oldItems  // 0x20
  private           System.Int32                    _newStartingIndex  // 0x28
  private           System.Int32                    _oldStartingIndex  // 0x2C
METHODS:
  System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action)
  System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object changedItem, System.Int32 index)
  System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Object newItem, System.Object oldItem, System.Int32 index)
  System.Void .ctor(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, System.Int32 startingIndex)
  System.Void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, System.Int32 startingIndex)
  System.Void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Int32 newStartingIndex)
  System.Void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, System.Int32 oldStartingIndex)
  System.Void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, System.Int32 startingIndex, System.Int32 oldStartingIndex)
END_CLASS

CLASS: System.Collections.Specialized.NotifyCollectionChangedEventHandler
TYPE:  class
TOKEN: 0x2000332
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
END_CLASS

CLASS: System.Collections.Specialized.ReadOnlyList
TYPE:  class
TOKEN: 0x2000333
FIELDS:
  private   readonly System.Collections.IList        _list  // 0x10
METHODS:
  System.Void .ctor(System.Collections.IList list)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean get_IsFixedSize()
  System.Boolean get_IsSynchronized()
  System.Object get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Object value)
  System.Object get_SyncRoot()
  System.Int32 Add(System.Object value)
  System.Void Clear()
  System.Boolean Contains(System.Object value)
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 IndexOf(System.Object value)
  System.Void Insert(System.Int32 index, System.Object value)
  System.Void Remove(System.Object value)
  System.Void RemoveAt(System.Int32 index)
END_CLASS

CLASS: System.Collections.Specialized.CaseSensitiveStringDictionary
TYPE:  class
TOKEN: 0x2000334
EXTENDS: StringDictionary
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Add(System.String key, System.String value)
END_CLASS

CLASS: System.Collections.Specialized.NameObjectCollectionBase
TYPE:  class
TOKEN: 0x2000335
FIELDS:
  private   static  System.String                   ReadOnlyName  // 0x0
  private   static  System.String                   CountName  // 0x0
  private   static  System.String                   ComparerName  // 0x0
  private   static  System.String                   HashCodeProviderName  // 0x0
  private   static  System.String                   KeysName  // 0x0
  private   static  System.String                   ValuesName  // 0x0
  private   static  System.String                   KeyComparerName  // 0x0
  private   static  System.String                   VersionName  // 0x0
  private           System.Boolean                  _readOnly  // 0x10
  private           System.Collections.ArrayList    _entriesArray  // 0x18
  private           System.Collections.IEqualityComparer_keyComparer  // 0x20
  private           System.Collections.Hashtable    _entriesTable  // 0x28
  private           System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry_nullKeyEntry  // 0x30
  private           System.Collections.Specialized.NameObjectCollectionBase.KeysCollection_keys  // 0x38
  private           System.Runtime.Serialization.SerializationInfo_serializationInfo  // 0x40
  private           System.Int32                    _version  // 0x48
  private           System.Object                   _syncRoot  // 0x50
  private   static  System.StringComparer           defaultComparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.IEqualityComparer equalityComparer)
  System.Void .ctor(System.Int32 capacity, System.Collections.IEqualityComparer equalityComparer)
  System.Void .ctor(System.DBNull dummy)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void OnDeserialization(System.Object sender)
  System.Void Reset()
  System.Void Reset(System.Int32 capacity)
  System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(System.String key)
  System.Boolean get_IsReadOnly()
  System.Void BaseAdd(System.String name, System.Object value)
  System.Void BaseRemove(System.String name)
  System.Object BaseGet(System.String name)
  System.Void BaseSet(System.String name, System.Object value)
  System.Object BaseGet(System.Int32 index)
  System.String BaseGetKey(System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 get_Count()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.String[] BaseGetAllKeys()
  System.Void .cctor()
END_CLASS

CLASS: System.Collections.Specialized.CompatibleComparer
TYPE:  class
TOKEN: 0x2000339
FIELDS:
  private           System.Collections.IComparer    _comparer  // 0x10
  private   static  System.Collections.IComparer    defaultComparer  // 0x0
  private           System.Collections.IHashCodeProvider_hcp  // 0x18
  private   static  System.Collections.IHashCodeProviderdefaultHashProvider  // 0x8
METHODS:
  System.Void .ctor(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider)
  System.Boolean Equals(System.Object a, System.Object b)
  System.Int32 GetHashCode(System.Object obj)
  System.Collections.IComparer get_Comparer()
  System.Collections.IHashCodeProvider get_HashCodeProvider()
  System.Collections.IComparer get_DefaultComparer()
  System.Collections.IHashCodeProvider get_DefaultHashCodeProvider()
END_CLASS

CLASS: System.ComponentModel.DefaultValueAttribute
TYPE:  class
TOKEN: 0x2000293
EXTENDS: Attribute
FIELDS:
  private           System.Object                   _value  // 0x10
METHODS:
  System.Void .ctor(System.Int32 value)
  System.Void .ctor(System.Int64 value)
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Boolean value)
  System.Void .ctor(System.String value)
  System.Void .ctor(System.Object value)
  System.Void .ctor(System.UInt32 value)
  System.Object get_Value()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.ComponentModel.EditorBrowsableAttribute
TYPE:  class
TOKEN: 0x2000294
EXTENDS: Attribute
FIELDS:
  private           System.ComponentModel.EditorBrowsableStatebrowsableState  // 0x10
METHODS:
  System.Void .ctor(System.ComponentModel.EditorBrowsableState state)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.ComponentModel.EditorBrowsableState
TYPE:  struct
TOKEN: 0x2000295
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.ComponentModel.EditorBrowsableStateAlways  // 0x0
  public    static  System.ComponentModel.EditorBrowsableStateNever  // 0x0
  public    static  System.ComponentModel.EditorBrowsableStateAdvanced  // 0x0
METHODS:
END_CLASS

CLASS: System.ComponentModel.BrowsableAttribute
TYPE:  class
TOKEN: 0x2000296
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.BrowsableAttributeYes  // 0x0
  public    static readonly System.ComponentModel.BrowsableAttributeNo  // 0x8
  public    static readonly System.ComponentModel.BrowsableAttributeDefault  // 0x10
  private   readonly System.Boolean                  <Browsable>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Boolean browsable)
  System.Boolean get_Browsable()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.ComponentCollection
TYPE:  class
TOKEN: 0x2000297
EXTENDS: ReadOnlyCollectionBase
FIELDS:
METHODS:
  System.ComponentModel.IComponent get_Item(System.String name)
END_CLASS

CLASS: System.ComponentModel.DescriptionAttribute
TYPE:  class
TOKEN: 0x2000298
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.DescriptionAttributeDefault  // 0x0
  private           System.String                   <DescriptionValue>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String description)
  System.String get_Description()
  System.String get_DescriptionValue()
  System.Void set_DescriptionValue(System.String value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DesignOnlyAttribute
TYPE:  class
TOKEN: 0x2000299
EXTENDS: Attribute
FIELDS:
  private   readonly System.Boolean                  <IsDesignOnly>k__BackingField  // 0x10
  public    static readonly System.ComponentModel.DesignOnlyAttributeYes  // 0x0
  public    static readonly System.ComponentModel.DesignOnlyAttributeNo  // 0x8
  public    static readonly System.ComponentModel.DesignOnlyAttributeDefault  // 0x10
METHODS:
  System.Void .ctor(System.Boolean isDesignOnly)
  System.Boolean get_IsDesignOnly()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DesignerCategoryAttribute
TYPE:  class
TOKEN: 0x200029A
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.DesignerCategoryAttributeComponent  // 0x0
  public    static readonly System.ComponentModel.DesignerCategoryAttributeDefault  // 0x8
  public    static readonly System.ComponentModel.DesignerCategoryAttributeForm  // 0x10
  public    static readonly System.ComponentModel.DesignerCategoryAttributeGeneric  // 0x18
  private   readonly System.String                   <Category>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String category)
  System.String get_Category()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Object get_TypeId()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DesignerSerializationVisibility
TYPE:  struct
TOKEN: 0x200029B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.ComponentModel.DesignerSerializationVisibilityHidden  // 0x0
  public    static  System.ComponentModel.DesignerSerializationVisibilityVisible  // 0x0
  public    static  System.ComponentModel.DesignerSerializationVisibilityContent  // 0x0
METHODS:
END_CLASS

CLASS: System.ComponentModel.DesignerSerializationVisibilityAttribute
TYPE:  class
TOKEN: 0x200029C
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.DesignerSerializationVisibilityAttributeContent  // 0x0
  public    static readonly System.ComponentModel.DesignerSerializationVisibilityAttributeHidden  // 0x8
  public    static readonly System.ComponentModel.DesignerSerializationVisibilityAttributeVisible  // 0x10
  public    static readonly System.ComponentModel.DesignerSerializationVisibilityAttributeDefault  // 0x18
  private   readonly System.ComponentModel.DesignerSerializationVisibility<Visibility>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.ComponentModel.DesignerSerializationVisibility visibility)
  System.ComponentModel.DesignerSerializationVisibility get_Visibility()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DisplayNameAttribute
TYPE:  class
TOKEN: 0x200029D
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.DisplayNameAttributeDefault  // 0x0
  private           System.String                   <DisplayNameValue>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String displayName)
  System.String get_DisplayName()
  System.String get_DisplayNameValue()
  System.Void set_DisplayNameValue(System.String value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.EventHandlerList
TYPE:  class
TOKEN: 0x200029E
FIELDS:
  private           System.ComponentModel.EventHandlerList.ListEntry_head  // 0x10
  private           System.ComponentModel.Component _parent  // 0x18
METHODS:
  System.Delegate get_Item(System.Object key)
  System.ComponentModel.EventHandlerList.ListEntry Find(System.Object key)
END_CLASS

CLASS: System.ComponentModel.IContainer
TYPE:  interface
TOKEN: 0x20002A0
FIELDS:
METHODS:
  System.ComponentModel.ComponentCollection get_Components()
  System.Void Remove(System.ComponentModel.IComponent component)
END_CLASS

CLASS: System.ComponentModel.ISite
TYPE:  interface
TOKEN: 0x20002A1
FIELDS:
METHODS:
  System.ComponentModel.IContainer get_Container()
  System.Boolean get_DesignMode()
  System.String get_Name()
END_CLASS

CLASS: System.ComponentModel.ISynchronizeInvoke
TYPE:  interface
TOKEN: 0x20002A2
FIELDS:
METHODS:
  System.Boolean get_InvokeRequired()
  System.IAsyncResult BeginInvoke(System.Delegate method, System.Object[] args)
END_CLASS

CLASS: System.ComponentModel.InvalidEnumArgumentException
TYPE:  class
TOKEN: 0x20002A3
EXTENDS: ArgumentException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String argumentName, System.Int32 invalidValue, System.Type enumClass)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: System.ComponentModel.ReadOnlyAttribute
TYPE:  class
TOKEN: 0x20002A4
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.ReadOnlyAttributeYes  // 0x0
  public    static readonly System.ComponentModel.ReadOnlyAttributeNo  // 0x8
  public    static readonly System.ComponentModel.ReadOnlyAttributeDefault  // 0x10
  private   readonly System.Boolean                  <IsReadOnly>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Boolean isReadOnly)
  System.Boolean get_IsReadOnly()
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.AmbientValueAttribute
TYPE:  class
TOKEN: 0x20002A5
EXTENDS: Attribute
FIELDS:
  private   readonly System.Object                   <Value>k__BackingField  // 0x10
METHODS:
  System.Object get_Value()
END_CLASS

CLASS: System.ComponentModel.ArrayConverter
TYPE:  class
TOKEN: 0x20002A6
EXTENDS: CollectionConverter
FIELDS:
METHODS:
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.AttributeCollection
TYPE:  class
TOKEN: 0x20002A8
FIELDS:
  public    static readonly System.ComponentModel.AttributeCollectionEmpty  // 0x0
  private   static  System.Collections.Hashtable    s_defaultAttributes  // 0x8
  private   readonly System.Attribute[]              _attributes  // 0x10
  private   static readonly System.Object                   s_internalSyncObject  // 0x10
  private           System.ComponentModel.AttributeCollection.AttributeEntry[]_foundAttributeTypes  // 0x18
  private           System.Int32                    _index  // 0x20
METHODS:
  System.Void .ctor(System.Attribute[] attributes)
  System.Attribute[] get_Attributes()
  System.Int32 get_Count()
  System.Attribute get_Item(System.Type attributeType)
  System.Boolean Contains(System.Attribute attribute)
  System.Attribute GetDefaultAttribute(System.Type attributeType)
  System.Collections.IEnumerator GetEnumerator()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Int32 System.Collections.ICollection.get_Count()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.AttributeProviderAttribute
TYPE:  class
TOKEN: 0x20002AA
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <TypeName>k__BackingField  // 0x10
  private   readonly System.String                   <PropertyName>k__BackingField  // 0x18
METHODS:
  System.String get_TypeName()
  System.String get_PropertyName()
END_CLASS

CLASS: System.ComponentModel.BaseNumberConverter
TYPE:  class
TOKEN: 0x20002AB
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean get_AllowHex()
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
END_CLASS

CLASS: System.ComponentModel.BooleanConverter
TYPE:  class
TOKEN: 0x20002AC
EXTENDS: TypeConverter
FIELDS:
  private   static  System.ComponentModel.TypeConverter.StandardValuesCollections_values  // 0x0
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.ByteConverter
TYPE:  class
TOKEN: 0x20002AD
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.CharConverter
TYPE:  class
TOKEN: 0x20002AE
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.CollectionChangeAction
TYPE:  struct
TOKEN: 0x20002AF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.ComponentModel.CollectionChangeActionAdd  // 0x0
  public    static  System.ComponentModel.CollectionChangeActionRemove  // 0x0
  public    static  System.ComponentModel.CollectionChangeActionRefresh  // 0x0
METHODS:
END_CLASS

CLASS: System.ComponentModel.CollectionChangeEventArgs
TYPE:  class
TOKEN: 0x20002B0
EXTENDS: EventArgs
FIELDS:
  private   readonly System.ComponentModel.CollectionChangeAction<Action>k__BackingField  // 0x10
  private   readonly System.Object                   <Element>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.ComponentModel.CollectionChangeAction action, System.Object element)
  System.ComponentModel.CollectionChangeAction get_Action()
  System.Object get_Element()
END_CLASS

CLASS: System.ComponentModel.CollectionChangeEventHandler
TYPE:  class
TOKEN: 0x20002B1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
END_CLASS

CLASS: System.ComponentModel.CultureInfoConverter
TYPE:  class
TOKEN: 0x20002B2
EXTENDS: TypeConverter
FIELDS:
  private           System.ComponentModel.TypeConverter.StandardValuesCollection_values  // 0x10
  private   static  System.String                   DefaultInvariantCultureString  // 0x0
METHODS:
  System.String get_DefaultCultureString()
  System.String GetCultureName(System.Globalization.CultureInfo culture)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.CustomTypeDescriptor
TYPE:  class
TOKEN: 0x20002B5
FIELDS:
  private   readonly System.ComponentModel.ICustomTypeDescriptor_parent  // 0x10
METHODS:
  System.Void .ctor()
  System.ComponentModel.AttributeCollection GetAttributes()
  System.ComponentModel.TypeConverter GetConverter()
  System.ComponentModel.PropertyDescriptorCollection GetProperties()
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes)
  System.Object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
END_CLASS

CLASS: System.ComponentModel.DateTimeConverter
TYPE:  class
TOKEN: 0x20002B6
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.DecimalConverter
TYPE:  class
TOKEN: 0x20002B7
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Boolean get_AllowHex()
  System.Type get_TargetType()
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.DefaultEventAttribute
TYPE:  class
TOKEN: 0x20002B8
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x10
  public    static readonly System.ComponentModel.DefaultEventAttributeDefault  // 0x0
METHODS:
  System.Void .ctor(System.String name)
  System.String get_Name()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DefaultPropertyAttribute
TYPE:  class
TOKEN: 0x20002B9
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x10
  public    static readonly System.ComponentModel.DefaultPropertyAttributeDefault  // 0x0
METHODS:
  System.Void .ctor(System.String name)
  System.String get_Name()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DelegatingTypeDescriptionProvider
TYPE:  class
TOKEN: 0x20002BA
EXTENDS: TypeDescriptionProvider
FIELDS:
  private   readonly System.Type                     _type  // 0x20
METHODS:
  System.Void .ctor(System.Type type)
  System.ComponentModel.TypeDescriptionProvider get_Provider()
  System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args)
  System.Collections.IDictionary GetCache(System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance)
  System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance)
  System.Type GetReflectionType(System.Type objectType, System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance)
END_CLASS

CLASS: System.ComponentModel.ToolboxItemAttribute
TYPE:  class
TOKEN: 0x20002BB
EXTENDS: Attribute
FIELDS:
  private           System.String                   _toolboxItemTypeName  // 0x10
  public    static readonly System.ComponentModel.ToolboxItemAttributeDefault  // 0x0
  public    static readonly System.ComponentModel.ToolboxItemAttributeNone  // 0x8
METHODS:
  System.Boolean IsDefaultAttribute()
  System.Void .ctor(System.Boolean defaultType)
  System.Void .ctor(System.String toolboxItemTypeName)
  System.String get_ToolboxItemTypeName()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DesignTimeVisibleAttribute
TYPE:  class
TOKEN: 0x20002BC
EXTENDS: Attribute
FIELDS:
  private   readonly System.Boolean                  <Visible>k__BackingField  // 0x10
  public    static readonly System.ComponentModel.DesignTimeVisibleAttributeYes  // 0x0
  public    static readonly System.ComponentModel.DesignTimeVisibleAttributeNo  // 0x8
  public    static readonly System.ComponentModel.DesignTimeVisibleAttributeDefault  // 0x10
METHODS:
  System.Void .ctor(System.Boolean visible)
  System.Boolean get_Visible()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.DoubleConverter
TYPE:  class
TOKEN: 0x20002BD
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Boolean get_AllowHex()
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.EditorAttribute
TYPE:  class
TOKEN: 0x20002BE
EXTENDS: Attribute
FIELDS:
  private           System.String                   _typeId  // 0x10
  private   readonly System.String                   <EditorBaseTypeName>k__BackingField  // 0x18
  private   readonly System.String                   <EditorTypeName>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.String typeName, System.String baseTypeName)
  System.String get_EditorBaseTypeName()
  System.String get_EditorTypeName()
  System.Object get_TypeId()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.ComponentModel.EventDescriptor
TYPE:  class
TOKEN: 0x20002BF
EXTENDS: MemberDescriptor
FIELDS:
METHODS:
END_CLASS

CLASS: System.ComponentModel.EventDescriptorCollection
TYPE:  class
TOKEN: 0x20002C0
FIELDS:
  private           System.ComponentModel.EventDescriptor[]_events  // 0x10
  private           System.String[]                 _namedSort  // 0x18
  private   readonly System.Collections.IComparer    _comparer  // 0x20
  private           System.Boolean                  _eventsOwned  // 0x28
  private           System.Boolean                  _needSort  // 0x29
  private   readonly System.Boolean                  _readOnly  // 0x2A
  public    static readonly System.ComponentModel.EventDescriptorCollectionEmpty  // 0x0
  private           System.Int32                    <Count>k__BackingField  // 0x2C
METHODS:
  System.Void .ctor(System.ComponentModel.EventDescriptor[] events)
  System.Void .ctor(System.ComponentModel.EventDescriptor[] events, System.Boolean readOnly)
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.ComponentModel.EventDescriptor get_Item(System.Int32 index)
  System.Int32 Add(System.ComponentModel.EventDescriptor value)
  System.Void Clear()
  System.Boolean Contains(System.ComponentModel.EventDescriptor value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Void EnsureEventsOwned()
  System.Void EnsureSize(System.Int32 sizeNeeded)
  System.Int32 IndexOf(System.ComponentModel.EventDescriptor value)
  System.Void Insert(System.Int32 index, System.ComponentModel.EventDescriptor value)
  System.Void Remove(System.ComponentModel.EventDescriptor value)
  System.Void RemoveAt(System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
  System.Void InternalSort(System.String[] names)
  System.Void InternalSort(System.Collections.IComparer sorter)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Int32 System.Collections.ICollection.get_Count()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Void System.Collections.IList.Clear()
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Boolean System.Collections.IList.get_IsReadOnly()
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.ExpandableObjectConverter
TYPE:  class
TOKEN: 0x20002C2
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
END_CLASS

CLASS: System.ComponentModel.ExtendedPropertyDescriptor
TYPE:  class
TOKEN: 0x20002C3
EXTENDS: PropertyDescriptor
FIELDS:
  private   readonly System.ComponentModel.ReflectPropertyDescriptor_extenderInfo  // 0x88
  private   readonly System.ComponentModel.IExtenderProvider_provider  // 0x90
METHODS:
  System.Void .ctor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes)
  System.Boolean CanResetValue(System.Object comp)
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.String get_DisplayName()
  System.Object GetValue(System.Object comp)
  System.Void ResetValue(System.Object comp)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object comp)
END_CLASS

CLASS: System.ComponentModel.ExtenderProvidedPropertyAttribute
TYPE:  class
TOKEN: 0x20002C4
EXTENDS: Attribute
FIELDS:
  private           System.ComponentModel.PropertyDescriptor<ExtenderProperty>k__BackingField  // 0x10
  private           System.ComponentModel.IExtenderProvider<Provider>k__BackingField  // 0x18
  private           System.Type                     <ReceiverType>k__BackingField  // 0x20
METHODS:
  System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider)
  System.Void .ctor()
  System.ComponentModel.PropertyDescriptor get_ExtenderProperty()
  System.Void set_ExtenderProperty(System.ComponentModel.PropertyDescriptor value)
  System.ComponentModel.IExtenderProvider get_Provider()
  System.Void set_Provider(System.ComponentModel.IExtenderProvider value)
  System.Type get_ReceiverType()
  System.Void set_ReceiverType(System.Type value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
END_CLASS

CLASS: System.ComponentModel.GuidConverter
TYPE:  class
TOKEN: 0x20002C5
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.IBindingList
TYPE:  interface
TOKEN: 0x20002C6
FIELDS:
METHODS:
END_CLASS

CLASS: System.ComponentModel.ICustomTypeDescriptor
TYPE:  interface
TOKEN: 0x20002C7
FIELDS:
METHODS:
  System.ComponentModel.AttributeCollection GetAttributes()
  System.ComponentModel.TypeConverter GetConverter()
  System.ComponentModel.PropertyDescriptorCollection GetProperties()
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes)
  System.Object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
END_CLASS

CLASS: System.ComponentModel.IExtenderProvider
TYPE:  interface
TOKEN: 0x20002C8
FIELDS:
METHODS:
  System.Boolean CanExtend(System.Object extendee)
END_CLASS

CLASS: System.ComponentModel.ITypeDescriptorContext
TYPE:  interface
TOKEN: 0x20002C9
FIELDS:
METHODS:
  System.ComponentModel.IContainer get_Container()
END_CLASS

CLASS: System.ComponentModel.Int16Converter
TYPE:  class
TOKEN: 0x20002CA
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.Int32Converter
TYPE:  class
TOKEN: 0x20002CB
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.Int64Converter
TYPE:  class
TOKEN: 0x20002CC
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.ListBindableAttribute
TYPE:  class
TOKEN: 0x20002CD
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.ListBindableAttributeYes  // 0x0
  public    static readonly System.ComponentModel.ListBindableAttributeNo  // 0x8
  public    static readonly System.ComponentModel.ListBindableAttributeDefault  // 0x10
  private           System.Boolean                  _isDefault  // 0x10
  private   readonly System.Boolean                  <ListBindable>k__BackingField  // 0x11
METHODS:
  System.Void .ctor(System.Boolean listBindable)
  System.Boolean get_ListBindable()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.ListChangedEventArgs
TYPE:  class
TOKEN: 0x20002CE
EXTENDS: EventArgs
FIELDS:
  private   readonly System.ComponentModel.ListChangedType<ListChangedType>k__BackingField  // 0x10
  private   readonly System.Int32                    <NewIndex>k__BackingField  // 0x14
  private   readonly System.Int32                    <OldIndex>k__BackingField  // 0x18
  private   readonly System.ComponentModel.PropertyDescriptor<PropertyDescriptor>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.Int32 newIndex)
  System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.Int32 newIndex, System.ComponentModel.PropertyDescriptor propDesc)
  System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc)
  System.Void .ctor(System.ComponentModel.ListChangedType listChangedType, System.Int32 newIndex, System.Int32 oldIndex)
  System.ComponentModel.ListChangedType get_ListChangedType()
  System.Int32 get_NewIndex()
  System.Int32 get_OldIndex()
END_CLASS

CLASS: System.ComponentModel.ListChangedEventHandler
TYPE:  class
TOKEN: 0x20002CF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.ComponentModel.ListChangedEventArgs e)
END_CLASS

CLASS: System.ComponentModel.ListChangedType
TYPE:  struct
TOKEN: 0x20002D0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.ComponentModel.ListChangedTypeReset  // 0x0
  public    static  System.ComponentModel.ListChangedTypeItemAdded  // 0x0
  public    static  System.ComponentModel.ListChangedTypeItemDeleted  // 0x0
  public    static  System.ComponentModel.ListChangedTypeItemMoved  // 0x0
  public    static  System.ComponentModel.ListChangedTypeItemChanged  // 0x0
  public    static  System.ComponentModel.ListChangedTypePropertyDescriptorAdded  // 0x0
  public    static  System.ComponentModel.ListChangedTypePropertyDescriptorDeleted  // 0x0
  public    static  System.ComponentModel.ListChangedTypePropertyDescriptorChanged  // 0x0
METHODS:
END_CLASS

CLASS: System.ComponentModel.MarshalByValueComponent
TYPE:  class
TOKEN: 0x20002D1
FIELDS:
  private   static readonly System.Object                   s_eventDisposed  // 0x0
  private           System.ComponentModel.ISite     _site  // 0x10
  private           System.ComponentModel.EventHandlerList_events  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Finalize()
  System.ComponentModel.ISite get_Site()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Object GetService(System.Type service)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.MultilineStringConverter
TYPE:  class
TOKEN: 0x20002D2
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.NullableConverter
TYPE:  class
TOKEN: 0x20002D3
EXTENDS: TypeConverter
FIELDS:
  private   readonly System.Type                     <NullableType>k__BackingField  // 0x10
  private   readonly System.Type                     <UnderlyingType>k__BackingField  // 0x18
  private   readonly System.ComponentModel.TypeConverter<UnderlyingTypeConverter>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Type type)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues)
  System.Boolean GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean IsValid(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
  System.Type get_NullableType()
  System.Type get_UnderlyingType()
  System.ComponentModel.TypeConverter get_UnderlyingTypeConverter()
END_CLASS

CLASS: System.ComponentModel.PropertyDescriptor
TYPE:  class
TOKEN: 0x20002D4
EXTENDS: MemberDescriptor
FIELDS:
  private           System.ComponentModel.TypeConverter_converter  // 0x60
  private           System.Collections.Hashtable    _valueChangedHandlers  // 0x68
  private           System.Object[]                 _editors  // 0x70
  private           System.Type[]                   _editorTypes  // 0x78
  private           System.Int32                    _editorCount  // 0x80
METHODS:
  System.Void .ctor(System.String name, System.Attribute[] attrs)
  System.Void .ctor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs)
  System.Type get_ComponentType()
  System.ComponentModel.TypeConverter get_Converter()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Boolean CanResetValue(System.Object component)
  System.Boolean Equals(System.Object obj)
  System.Object CreateInstance(System.Type type)
  System.Void FillAttributes(System.Collections.IList attributeList)
  System.Int32 GetHashCode()
  System.Object GetInvocationTarget(System.Type type, System.Object instance)
  System.Type GetTypeFromName(System.String typeName)
  System.Object GetValue(System.Object component)
  System.Void OnValueChanged(System.Object component, System.EventArgs e)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: System.ComponentModel.PropertyDescriptorCollection
TYPE:  class
TOKEN: 0x20002D5
FIELDS:
  public    static readonly System.ComponentModel.PropertyDescriptorCollectionEmpty  // 0x0
  private           System.Collections.IDictionary  _cachedFoundProperties  // 0x10
  private           System.Boolean                  _cachedIgnoreCase  // 0x18
  private           System.ComponentModel.PropertyDescriptor[]_properties  // 0x20
  private   readonly System.String[]                 _namedSort  // 0x28
  private   readonly System.Collections.IComparer    _comparer  // 0x30
  private           System.Boolean                  _propsOwned  // 0x38
  private           System.Boolean                  _needSort  // 0x39
  private           System.Boolean                  _readOnly  // 0x3A
  private   readonly System.Object                   _internalSyncObject  // 0x40
  private           System.Int32                    <Count>k__BackingField  // 0x48
METHODS:
  System.Void .ctor(System.ComponentModel.PropertyDescriptor[] properties)
  System.Void .ctor(System.ComponentModel.PropertyDescriptor[] properties, System.Boolean readOnly)
  System.Void .ctor(System.ComponentModel.PropertyDescriptor[] properties, System.Int32 propCount, System.String[] namedSort, System.Collections.IComparer comparer)
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.ComponentModel.PropertyDescriptor get_Item(System.Int32 index)
  System.ComponentModel.PropertyDescriptor get_Item(System.String name)
  System.Int32 Add(System.ComponentModel.PropertyDescriptor value)
  System.Void Clear()
  System.Boolean Contains(System.ComponentModel.PropertyDescriptor value)
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Void EnsurePropsOwned()
  System.Void EnsureSize(System.Int32 sizeNeeded)
  System.ComponentModel.PropertyDescriptor Find(System.String name, System.Boolean ignoreCase)
  System.Int32 IndexOf(System.ComponentModel.PropertyDescriptor value)
  System.Void Insert(System.Int32 index, System.ComponentModel.PropertyDescriptor value)
  System.Void Remove(System.ComponentModel.PropertyDescriptor value)
  System.Void RemoveAt(System.Int32 index)
  System.ComponentModel.PropertyDescriptorCollection Sort(System.String[] names)
  System.Void InternalSort(System.String[] names)
  System.Void InternalSort(System.Collections.IComparer sorter)
  System.Collections.IEnumerator GetEnumerator()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Int32 System.Collections.ICollection.get_Count()
  System.Void System.Collections.IList.Clear()
  System.Void System.Collections.IDictionary.Clear()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  System.Boolean System.Collections.IDictionary.get_IsFixedSize()
  System.Boolean System.Collections.IDictionary.get_IsReadOnly()
  System.Object System.Collections.IDictionary.get_Item(System.Object key)
  System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value)
  System.Collections.ICollection System.Collections.IDictionary.get_Keys()
  System.Collections.ICollection System.Collections.IDictionary.get_Values()
  System.Void System.Collections.IDictionary.Remove(System.Object key)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsReadOnly()
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.ProvidePropertyAttribute
TYPE:  class
TOKEN: 0x20002D7
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <PropertyName>k__BackingField  // 0x10
  private   readonly System.String                   <ReceiverTypeName>k__BackingField  // 0x18
METHODS:
  System.String get_PropertyName()
  System.String get_ReceiverTypeName()
END_CLASS

CLASS: System.ComponentModel.ReferenceConverter
TYPE:  class
TOKEN: 0x20002D8
EXTENDS: TypeConverter
FIELDS:
  private   static readonly System.String                   s_none  // 0x0
  private           System.Type                     _type  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.RefreshEventArgs
TYPE:  class
TOKEN: 0x20002DA
EXTENDS: EventArgs
FIELDS:
  private   readonly System.Type                     <TypeChanged>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Type typeChanged)
END_CLASS

CLASS: System.ComponentModel.RefreshEventHandler
TYPE:  class
TOKEN: 0x20002DB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.ComponentModel.RefreshEventArgs e)
END_CLASS

CLASS: System.ComponentModel.SByteConverter
TYPE:  class
TOKEN: 0x20002DC
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.SettingsBindableAttribute
TYPE:  class
TOKEN: 0x20002DD
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.SettingsBindableAttributeYes  // 0x0
  public    static readonly System.ComponentModel.SettingsBindableAttributeNo  // 0x8
  private   readonly System.Boolean                  <Bindable>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Boolean bindable)
  System.Boolean get_Bindable()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.SingleConverter
TYPE:  class
TOKEN: 0x20002DE
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Boolean get_AllowHex()
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.StringConverter
TYPE:  class
TOKEN: 0x20002DF
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.TimeSpanConverter
TYPE:  class
TOKEN: 0x20002E0
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.TypeConverterAttribute
TYPE:  class
TOKEN: 0x20002E1
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.TypeConverterAttributeDefault  // 0x0
  private   readonly System.String                   <ConverterTypeName>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Type type)
  System.Void .ctor(System.String typeName)
  System.String get_ConverterTypeName()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.TypeDescriptionProvider
TYPE:  class
TOKEN: 0x20002E2
FIELDS:
  private   readonly System.ComponentModel.TypeDescriptionProvider_parent  // 0x10
  private           System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor_emptyDescriptor  // 0x18
METHODS:
  System.Void .ctor()
  System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args)
  System.Collections.IDictionary GetCache(System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance)
  System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance)
  System.Type GetReflectionType(System.Type objectType)
  System.Type GetReflectionType(System.Type objectType, System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType)
  System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Object instance)
  System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance)
END_CLASS

CLASS: System.ComponentModel.TypeDescriptionProviderAttribute
TYPE:  class
TOKEN: 0x20002E4
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <TypeName>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.String typeName)
  System.String get_TypeName()
END_CLASS

CLASS: System.ComponentModel.TypeListConverter
TYPE:  class
TOKEN: 0x20002E5
EXTENDS: TypeConverter
FIELDS:
  private   readonly System.Type[]                   _types  // 0x10
  private           System.ComponentModel.TypeConverter.StandardValuesCollection_values  // 0x18
METHODS:
  System.Void .ctor(System.Type[] types)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
END_CLASS

CLASS: System.ComponentModel.UInt16Converter
TYPE:  class
TOKEN: 0x20002E6
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.UInt32Converter
TYPE:  class
TOKEN: 0x20002E7
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.UInt64Converter
TYPE:  class
TOKEN: 0x20002E8
EXTENDS: BaseNumberConverter
FIELDS:
METHODS:
  System.Type get_TargetType()
  System.Object FromString(System.String value, System.Int32 radix)
  System.Object FromString(System.String value, System.Globalization.NumberFormatInfo formatInfo)
  System.String ToString(System.Object value, System.Globalization.NumberFormatInfo formatInfo)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.IChangeTracking
TYPE:  interface
TOKEN: 0x20002E9
FIELDS:
METHODS:
  System.Boolean get_IsChanged()
  System.Void AcceptChanges()
END_CLASS

CLASS: System.ComponentModel.IRevertibleChangeTracking
TYPE:  interface
TOKEN: 0x20002EA
FIELDS:
METHODS:
  System.Void RejectChanges()
END_CLASS

CLASS: System.ComponentModel.INotifyPropertyChanged
TYPE:  interface
TOKEN: 0x20002EB
FIELDS:
METHODS:
  System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
END_CLASS

CLASS: System.ComponentModel.PropertyChangedEventArgs
TYPE:  class
TOKEN: 0x20002EC
EXTENDS: EventArgs
FIELDS:
  private   readonly System.String                   _propertyName  // 0x10
METHODS:
  System.Void .ctor(System.String propertyName)
END_CLASS

CLASS: System.ComponentModel.PropertyChangedEventHandler
TYPE:  class
TOKEN: 0x20002ED
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
END_CLASS

CLASS: System.ComponentModel.PropertyChangingEventArgs
TYPE:  class
TOKEN: 0x20002EE
EXTENDS: EventArgs
FIELDS:
  private   readonly System.String                   _propertyName  // 0x10
METHODS:
  System.Void .ctor(System.String propertyName)
END_CLASS

CLASS: System.ComponentModel.PropertyChangingEventHandler
TYPE:  class
TOKEN: 0x20002EF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.ComponentModel.PropertyChangingEventArgs e)
END_CLASS

CLASS: System.ComponentModel.CategoryAttribute
TYPE:  class
TOKEN: 0x20002F0
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  localized  // 0x10
  private           System.String                   categoryValue  // 0x18
METHODS:
  System.String get_Category()
  System.String GetLocalizedString(System.String value)
END_CLASS

CLASS: System.ComponentModel.CollectionConverter
TYPE:  class
TOKEN: 0x20002F1
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.Component
TYPE:  class
TOKEN: 0x20002F2
EXTENDS: MarshalByRefObject
FIELDS:
  private   static readonly System.Object                   EventDisposed  // 0x0
  private           System.ComponentModel.ISite     site  // 0x18
  private           System.ComponentModel.EventHandlerListevents  // 0x20
METHODS:
  System.Void Finalize()
  System.Boolean get_CanRaiseEvents()
  System.Boolean get_CanRaiseEventsInternal()
  System.ComponentModel.ISite get_Site()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Object GetService(System.Type service)
  System.Boolean get_DesignMode()
  System.String ToString()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.ComponentConverter
TYPE:  class
TOKEN: 0x20002F3
EXTENDS: ReferenceConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Type type)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
END_CLASS

CLASS: System.ComponentModel.DateTimeOffsetConverter
TYPE:  class
TOKEN: 0x20002F4
EXTENDS: TypeConverter
FIELDS:
METHODS:
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.EnumConverter
TYPE:  class
TOKEN: 0x20002F5
EXTENDS: TypeConverter
FIELDS:
  private           System.ComponentModel.TypeConverter.StandardValuesCollectionvalues  // 0x10
  private           System.Type                     type  // 0x18
METHODS:
  System.Void .ctor(System.Type type)
  System.Type get_EnumType()
  System.ComponentModel.TypeConverter.StandardValuesCollection get_Values()
  System.Void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Collections.IComparer get_Comparer()
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean IsValid(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
END_CLASS

CLASS: System.ComponentModel.IComponent
TYPE:  interface
TOKEN: 0x20002F6
FIELDS:
METHODS:
  System.ComponentModel.ISite get_Site()
END_CLASS

CLASS: System.ComponentModel.MemberDescriptor
TYPE:  class
TOKEN: 0x20002F7
FIELDS:
  private           System.String                   name  // 0x10
  private           System.String                   displayName  // 0x18
  private           System.Int32                    nameHash  // 0x20
  private           System.ComponentModel.AttributeCollectionattributeCollection  // 0x28
  private           System.Attribute[]              attributes  // 0x30
  private           System.Attribute[]              originalAttributes  // 0x38
  private           System.Boolean                  attributesFiltered  // 0x40
  private           System.Boolean                  attributesFilled  // 0x41
  private           System.Int32                    metadataVersion  // 0x44
  private           System.String                   category  // 0x48
  private           System.String                   description  // 0x50
  private           System.Object                   lockCookie  // 0x58
METHODS:
  System.Void .ctor(System.String name, System.Attribute[] attributes)
  System.Void .ctor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes)
  System.Attribute[] get_AttributeArray()
  System.Void set_AttributeArray(System.Attribute[] value)
  System.ComponentModel.AttributeCollection get_Attributes()
  System.String get_Name()
  System.Int32 get_NameHashCode()
  System.String get_DisplayName()
  System.Void CheckAttributesValid()
  System.ComponentModel.AttributeCollection CreateAttributeCollection()
  System.Boolean Equals(System.Object obj)
  System.Void FillAttributes(System.Collections.IList attributeList)
  System.Void FilterAttributesIfNeeded()
  System.Reflection.MethodInfo FindMethod(System.Type componentClass, System.String name, System.Type[] args, System.Type returnType)
  System.Reflection.MethodInfo FindMethod(System.Type componentClass, System.String name, System.Type[] args, System.Type returnType, System.Boolean publicOnly)
  System.Int32 GetHashCode()
  System.Object GetInvocationTarget(System.Type type, System.Object instance)
  System.ComponentModel.ISite GetSite(System.Object component)
END_CLASS

CLASS: System.ComponentModel.ReflectPropertyDescriptor
TYPE:  class
TOKEN: 0x20002F8
EXTENDS: PropertyDescriptor
FIELDS:
  private   static readonly System.Type[]                   argsNone  // 0x0
  private   static readonly System.Object                   noValue  // 0x8
  private   static  System.Diagnostics.TraceSwitch  PropDescCreateSwitch  // 0x10
  private   static  System.Diagnostics.TraceSwitch  PropDescUsageSwitch  // 0x18
  private   static readonly System.Int32                    BitDefaultValueQueried  // 0x20
  private   static readonly System.Int32                    BitGetQueried  // 0x24
  private   static readonly System.Int32                    BitSetQueried  // 0x28
  private   static readonly System.Int32                    BitShouldSerializeQueried  // 0x2C
  private   static readonly System.Int32                    BitResetQueried  // 0x30
  private   static readonly System.Int32                    BitChangedQueried  // 0x34
  private   static readonly System.Int32                    BitIPropChangedQueried  // 0x38
  private   static readonly System.Int32                    BitReadOnlyChecked  // 0x3C
  private   static readonly System.Int32                    BitAmbientValueQueried  // 0x40
  private   static readonly System.Int32                    BitSetOnDemand  // 0x44
  private           System.Collections.Specialized.BitVector32state  // 0x88
  private           System.Type                     componentClass  // 0x90
  private           System.Type                     type  // 0x98
  private           System.Object                   defaultValue  // 0xA0
  private           System.Object                   ambientValue  // 0xA8
  private           System.Reflection.PropertyInfo  propInfo  // 0xB0
  private           System.Reflection.MethodInfo    getMethod  // 0xB8
  private           System.Reflection.MethodInfo    setMethod  // 0xC0
  private           System.Reflection.MethodInfo    shouldSerializeMethod  // 0xC8
  private           System.Reflection.MethodInfo    resetMethod  // 0xD0
  private           System.ComponentModel.EventDescriptorrealChangedEvent  // 0xD8
  private           System.Type                     receiverType  // 0xE0
METHODS:
  System.Void .ctor(System.Type componentClass, System.String name, System.Type type, System.Attribute[] attributes)
  System.Void .ctor(System.Type componentClass, System.String name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs)
  System.Void .ctor(System.Type componentClass, System.String name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs)
  System.Object get_AmbientValue()
  System.Type get_ComponentType()
  System.Object get_DefaultValue()
  System.Reflection.MethodInfo get_GetMethodValue()
  System.Boolean get_IsExtender()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Reflection.MethodInfo get_ResetMethodValue()
  System.Reflection.MethodInfo get_SetMethodValue()
  System.Reflection.MethodInfo get_ShouldSerializeMethodValue()
  System.Boolean ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, System.Object component)
  System.Type ExtenderGetReceiverType()
  System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider)
  System.Object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, System.Object component)
  System.Void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, System.Object component, System.ComponentModel.PropertyDescriptor notifyDesc)
  System.Void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, System.Object component, System.Object value, System.ComponentModel.PropertyDescriptor notifyDesc)
  System.Boolean ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, System.Object component)
  System.Boolean CanResetValue(System.Object component)
  System.Void FillAttributes(System.Collections.IList attributes)
  System.Object GetValue(System.Object component)
  System.Void OnValueChanged(System.Object component, System.EventArgs e)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.ReflectTypeDescriptionProvider
TYPE:  class
TOKEN: 0x20002F9
EXTENDS: TypeDescriptionProvider
FIELDS:
  private           System.Collections.Hashtable    _typeData  // 0x20
  private   static  System.Type[]                   _typeConstructor  // 0x0
  private   static  System.Collections.Hashtable    _intrinsicTypeConverters  // 0x8
  private   static  System.Object                   _intrinsicReferenceKey  // 0x10
  private   static  System.Object                   _intrinsicNullableKey  // 0x18
  private   static  System.Object                   _dictionaryKey  // 0x20
  private   static  System.Collections.Hashtable    _propertyCache  // 0x28
  private   static  System.Collections.Hashtable    _attributeCache  // 0x30
  private   static  System.Collections.Hashtable    _extendedPropertyCache  // 0x38
  private   static readonly System.Guid                     _extenderProviderKey  // 0x40
  private   static readonly System.Guid                     _extenderPropertiesKey  // 0x50
  private   static readonly System.Guid                     _extenderProviderPropertiesKey  // 0x60
  private   static readonly System.Type[]                   _skipInterfaceAttributeList  // 0x70
  private   static  System.Object                   _internalSyncObject  // 0x78
METHODS:
  System.Void .ctor()
  System.Collections.Hashtable get_IntrinsicTypeConverters()
  System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args)
  System.Object CreateInstance(System.Type objectType, System.Type callingType)
  System.ComponentModel.AttributeCollection GetAttributes(System.Type type)
  System.Collections.IDictionary GetCache(System.Object instance)
  System.ComponentModel.TypeConverter GetConverter(System.Type type, System.Object instance)
  System.ComponentModel.AttributeCollection GetExtendedAttributes(System.Object instance)
  System.ComponentModel.TypeConverter GetExtendedConverter(System.Object instance)
  System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(System.Object instance)
  System.ComponentModel.IExtenderProvider[] GetExtenderProviders(System.Object instance)
  System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, System.Object instance, System.Collections.IDictionary cache)
  System.Object GetExtendedPropertyOwner(System.Object instance, System.ComponentModel.PropertyDescriptor pd)
  System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(System.Object instance)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type)
  System.Object GetPropertyOwner(System.Type type, System.Object instance, System.ComponentModel.PropertyDescriptor pd)
  System.Type GetReflectionType(System.Type objectType, System.Object instance)
  System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, System.Boolean createIfNeeded)
  System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, System.Object instance)
  System.Type GetTypeFromName(System.String typeName)
  System.Boolean IsPopulated(System.Type type)
  System.Attribute[] ReflectGetAttributes(System.Type type)
  System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member)
  System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider)
  System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type)
  System.Void Refresh(System.Type type)
  System.Object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.TypeConverter
TYPE:  class
TOKEN: 0x20002FB
FIELDS:
  private   static  System.String                   s_UseCompatibleTypeConverterBehavior  // 0x0
  private   static  System.Boolean                  useCompatibleTypeConversion  // 0x0
METHODS:
  System.Boolean get_UseCompatibleTypeConversion()
  System.Boolean CanConvertFrom(System.Type sourceType)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Boolean CanConvertTo(System.Type destinationType)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertFrom(System.Object value)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object ConvertFromInvariantString(System.String text)
  System.Object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, System.String text)
  System.Object ConvertFromString(System.String text)
  System.Object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.String text)
  System.Object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.String text)
  System.Object ConvertTo(System.Object value, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.String ConvertToInvariantString(System.Object value)
  System.String ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
  System.String ConvertToString(System.Object value)
  System.String ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
  System.String ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.Object CreateInstance(System.Collections.IDictionary propertyValues)
  System.Object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues)
  System.Exception GetConvertFromException(System.Object value)
  System.Exception GetConvertToException(System.Object value, System.Type destinationType)
  System.Boolean GetCreateInstanceSupported()
  System.Boolean GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object value)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, System.Object value, System.Attribute[] attributes)
  System.Boolean GetPropertiesSupported()
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Collections.ICollection GetStandardValues()
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive()
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported()
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean IsValid(System.Object value)
  System.Boolean IsValid(System.ComponentModel.ITypeDescriptorContext context, System.Object value)
  System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, System.String[] names)
  System.Void .ctor()
END_CLASS

CLASS: System.ComponentModel.TypeDescriptor
TYPE:  class
TOKEN: 0x20002FE
FIELDS:
  private   static  System.ComponentModel.WeakHashtable_providerTable  // 0x0
  private   static  System.Collections.Hashtable    _providerTypeTable  // 0x8
  private   static  System.Collections.Hashtable    _defaultProviders  // 0x10
  private   static  System.ComponentModel.WeakHashtable_associationTable  // 0x18
  private   static  System.Int32                    _metadataVersion  // 0x20
  private   static  System.Int32                    _collisionIndex  // 0x24
  private   static  System.Diagnostics.BooleanSwitchTraceDescriptor  // 0x28
  private   static readonly System.Guid[]                   _pipelineInitializeKeys  // 0x30
  private   static readonly System.Guid[]                   _pipelineMergeKeys  // 0x38
  private   static readonly System.Guid[]                   _pipelineFilterKeys  // 0x40
  private   static readonly System.Guid[]                   _pipelineAttributeFilterKeys  // 0x48
  private   static  System.Object                   _internalSyncObject  // 0x50
  private   static  System.ComponentModel.RefreshEventHandlerRefreshed  // 0x58
METHODS:
  System.Type get_ComObjectType()
  System.Type get_InterfaceType()
  System.Int32 get_MetadataVersion()
  System.Void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type)
  System.Void CheckDefaultProvider(System.Type type)
  System.Object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args)
  System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes)
  System.Object GetAssociation(System.Type type, System.Object primary)
  System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType)
  System.ComponentModel.AttributeCollection GetAttributes(System.Object component)
  System.ComponentModel.AttributeCollection GetAttributes(System.Object component, System.Boolean noCustomTypeDesc)
  System.Collections.IDictionary GetCache(System.Object instance)
  System.ComponentModel.TypeConverter GetConverter(System.Type type)
  System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, System.String typeName)
  System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Object component, System.Boolean noCustomTypeDesc)
  System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(System.Object component)
  System.String GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member)
  System.Type GetNodeForBaseType(System.Type searchType)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component, System.Boolean noCustomTypeDesc)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component, System.Attribute[] attributes)
  System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Object component, System.Attribute[] attributes, System.Boolean noCustomTypeDesc)
  System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(System.Object component, System.Attribute[] attributes, System.Boolean noCustomTypeDesc, System.Boolean noAttributes)
  System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type)
  System.Type GetReflectionType(System.Type type)
  System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type)
  System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, System.Boolean createDelegator)
  System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Object instance)
  System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Object instance, System.Boolean createDelegator)
  System.Collections.ICollection PipelineAttributeFilter(System.Int32 pipelineType, System.Collections.ICollection members, System.Attribute[] filter, System.Object instance, System.Collections.IDictionary cache)
  System.Collections.ICollection PipelineFilter(System.Int32 pipelineType, System.Collections.ICollection members, System.Object instance, System.Collections.IDictionary cache)
  System.Collections.ICollection PipelineInitialize(System.Int32 pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache)
  System.Collections.ICollection PipelineMerge(System.Int32 pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, System.Object instance, System.Collections.IDictionary cache)
  System.Void RaiseRefresh(System.Type type)
  System.Void Refresh(System.Type type)
  System.Boolean ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute)
  System.Void SortDescriptorArray(System.Collections.IList infos)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.Win32Exception
TYPE:  class
TOKEN: 0x2000309
EXTENDS: ExternalException
FIELDS:
  private   readonly System.Int32                    nativeErrorCode  // 0x90
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 error)
  System.Void .ctor(System.Int32 error, System.String message)
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Int32 get_NativeErrorCode()
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.String GetErrorMessage(System.Int32 error)
END_CLASS

CLASS: System.ComponentModel.NotifyParentPropertyAttribute
TYPE:  class
TOKEN: 0x200030A
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.NotifyParentPropertyAttributeYes  // 0x0
  public    static readonly System.ComponentModel.NotifyParentPropertyAttributeNo  // 0x8
  public    static readonly System.ComponentModel.NotifyParentPropertyAttributeDefault  // 0x10
  private           System.Boolean                  notifyParent  // 0x10
METHODS:
  System.Void .ctor(System.Boolean notifyParent)
  System.Boolean get_NotifyParent()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.RefreshProperties
TYPE:  struct
TOKEN: 0x200030B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.ComponentModel.RefreshPropertiesNone  // 0x0
  public    static  System.ComponentModel.RefreshPropertiesAll  // 0x0
  public    static  System.ComponentModel.RefreshPropertiesRepaint  // 0x0
METHODS:
END_CLASS

CLASS: System.ComponentModel.RefreshPropertiesAttribute
TYPE:  class
TOKEN: 0x200030C
EXTENDS: Attribute
FIELDS:
  public    static readonly System.ComponentModel.RefreshPropertiesAttributeAll  // 0x0
  public    static readonly System.ComponentModel.RefreshPropertiesAttributeRepaint  // 0x8
  public    static readonly System.ComponentModel.RefreshPropertiesAttributeDefault  // 0x10
  private           System.ComponentModel.RefreshPropertiesrefresh  // 0x10
METHODS:
  System.Void .ctor(System.ComponentModel.RefreshProperties refresh)
  System.ComponentModel.RefreshProperties get_RefreshProperties()
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Boolean IsDefaultAttribute()
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.WeakHashtable
TYPE:  class
TOKEN: 0x200030D
EXTENDS: Hashtable
FIELDS:
  private   static  System.Collections.IEqualityComparer_comparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Clear()
  System.Void Remove(System.Object key)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.Design.CheckoutException
TYPE:  class
TOKEN: 0x200030F
EXTENDS: ExternalException
FIELDS:
  public    static readonly System.ComponentModel.Design.CheckoutExceptionCanceled  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message, System.Int32 errorCode)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .cctor()
END_CLASS

CLASS: System.ComponentModel.Design.IComponentChangeService
TYPE:  interface
TOKEN: 0x2000310
FIELDS:
METHODS:
  System.Void OnComponentChanged(System.Object component, System.ComponentModel.MemberDescriptor member, System.Object oldValue, System.Object newValue)
  System.Void OnComponentChanging(System.Object component, System.ComponentModel.MemberDescriptor member)
END_CLASS

CLASS: System.ComponentModel.Design.IDesigner
TYPE:  interface
TOKEN: 0x2000311
FIELDS:
METHODS:
END_CLASS

CLASS: System.ComponentModel.Design.IDesignerHost
TYPE:  interface
TOKEN: 0x2000312
FIELDS:
METHODS:
  System.ComponentModel.IComponent get_RootComponent()
  System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component)
END_CLASS

CLASS: System.ComponentModel.Design.IDictionaryService
TYPE:  interface
TOKEN: 0x2000313
FIELDS:
METHODS:
  System.Object GetValue(System.Object key)
  System.Void SetValue(System.Object key, System.Object value)
END_CLASS

CLASS: System.ComponentModel.Design.IExtenderListService
TYPE:  interface
TOKEN: 0x2000314
FIELDS:
METHODS:
  System.ComponentModel.IExtenderProvider[] GetExtenderProviders()
END_CLASS

CLASS: System.ComponentModel.Design.IReferenceService
TYPE:  interface
TOKEN: 0x2000315
FIELDS:
METHODS:
  System.Object GetReference(System.String name)
  System.String GetName(System.Object reference)
  System.Object[] GetReferences(System.Type baseType)
END_CLASS

CLASS: System.ComponentModel.Design.ITypeDescriptorFilterService
TYPE:  interface
TOKEN: 0x2000316
FIELDS:
METHODS:
  System.Boolean FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes)
  System.Boolean FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events)
  System.Boolean FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties)
END_CLASS

CLASS: System.ComponentModel.Design.DesignerOptionService
TYPE:  class
TOKEN: 0x2000317
FIELDS:
METHODS:
  System.Void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options)
END_CLASS

CLASS: System.ComponentModel.Design.Serialization.InstanceDescriptor
TYPE:  class
TOKEN: 0x200031C
FIELDS:
  private   readonly System.Collections.ICollection  <Arguments>k__BackingField  // 0x10
  private   readonly System.Boolean                  <IsComplete>k__BackingField  // 0x18
  private   readonly System.Reflection.MemberInfo    <MemberInfo>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments)
  System.Void .ctor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, System.Boolean isComplete)
  System.Collections.ICollection get_Arguments()
  System.Reflection.MemberInfo get_MemberInfo()
  System.Object Invoke()
END_CLASS

CLASS: System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute
TYPE:  class
TOKEN: 0x200031D
EXTENDS: Attribute
FIELDS:
  private           System.String                   _typeId  // 0x10
  private   readonly System.Boolean                  <Reloadable>k__BackingField  // 0x18
  private   readonly System.String                   <SerializerTypeName>k__BackingField  // 0x20
  private   readonly System.String                   <SerializerBaseTypeName>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.String serializerTypeName, System.String baseSerializerTypeName, System.Boolean reloadable)
  System.String get_SerializerBaseTypeName()
  System.Object get_TypeId()
END_CLASS

CLASS: System.Configuration.IConfigurationSectionHandler
TYPE:  interface
TOKEN: 0x2000379
FIELDS:
METHODS:
END_CLASS

CLASS: System.Diagnostics.BooleanSwitch
TYPE:  class
TOKEN: 0x20000F8
EXTENDS: Switch
FIELDS:
METHODS:
  System.Void .ctor(System.String displayName, System.String description)
END_CLASS

CLASS: System.Diagnostics.Switch
TYPE:  class
TOKEN: 0x20000F9
FIELDS:
  private   readonly System.String                   description  // 0x10
  private   readonly System.String                   displayName  // 0x18
  private           System.String                   switchValueString  // 0x20
  private           System.String                   defaultValue  // 0x28
  private   static  System.Collections.Generic.List<System.WeakReference>switches  // 0x0
  private   static  System.Int32                    s_LastCollectionCount  // 0x8
METHODS:
  System.Void .ctor(System.String displayName, System.String description)
  System.Void .ctor(System.String displayName, System.String description, System.String defaultSwitchValue)
  System.Void _pruneCachedSwitches()
  System.Void .cctor()
END_CLASS

CLASS: System.Diagnostics.SwitchLevelAttribute
TYPE:  class
TOKEN: 0x20000FA
EXTENDS: Attribute
FIELDS:
  private           System.Type                     type  // 0x10
METHODS:
  System.Void .ctor(System.Type switchLevelType)
  System.Void set_SwitchLevelType(System.Type value)
END_CLASS

CLASS: System.Diagnostics.TraceLevel
TYPE:  struct
TOKEN: 0x20000FB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Diagnostics.TraceLevel   Off  // 0x0
  public    static  System.Diagnostics.TraceLevel   Error  // 0x0
  public    static  System.Diagnostics.TraceLevel   Warning  // 0x0
  public    static  System.Diagnostics.TraceLevel   Info  // 0x0
  public    static  System.Diagnostics.TraceLevel   Verbose  // 0x0
METHODS:
END_CLASS

CLASS: System.Diagnostics.TraceSwitch
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: Switch
FIELDS:
METHODS:
  System.Void .ctor(System.String displayName, System.String description)
END_CLASS

CLASS: System.Diagnostics.AsyncStreamReader
TYPE:  class
TOKEN: 0x20000FD
FIELDS:
  private           System.IO.Stream                stream  // 0x10
  private           System.Text.Encoding            encoding  // 0x18
  private           System.Text.Decoder             decoder  // 0x20
  private           System.Byte[]                   byteBuffer  // 0x28
  private           System.Char[]                   charBuffer  // 0x30
  private           System.Boolean                  cancelOperation  // 0x38
  private           System.Threading.ManualResetEventeofEvent  // 0x40
  private           System.Object                   syncObject  // 0x48
  private           System.IAsyncResult             asyncReadResult  // 0x50
METHODS:
  System.Void Close()
  System.Void Dispose(System.Boolean disposing)
  System.Void CancelOperation()
  System.Void WaitUtilEOF()
END_CLASS

CLASS: System.Diagnostics.Process
TYPE:  class
TOKEN: 0x20000FE
EXTENDS: Component
FIELDS:
  private           System.Boolean                  haveProcessId  // 0x28
  private           System.Int32                    processId  // 0x2C
  private           System.Boolean                  haveProcessHandle  // 0x30
  private           Microsoft.Win32.SafeHandles.SafeProcessHandlem_processHandle  // 0x38
  private           System.Boolean                  isRemoteMachine  // 0x40
  private           System.String                   machineName  // 0x48
  private           System.Int32                    m_processAccess  // 0x50
  private           System.Diagnostics.ProcessThreadCollectionthreads  // 0x58
  private           System.Diagnostics.ProcessModuleCollectionmodules  // 0x60
  private           System.Boolean                  haveWorkingSetLimits  // 0x68
  private           System.Boolean                  havePriorityClass  // 0x69
  private           System.Diagnostics.ProcessStartInfostartInfo  // 0x70
  private           System.Boolean                  watchForExit  // 0x78
  private           System.Boolean                  watchingForExit  // 0x79
  private           System.EventHandler             onExited  // 0x80
  private           System.Boolean                  exited  // 0x88
  private           System.Int32                    exitCode  // 0x8C
  private           System.Boolean                  signaled  // 0x90
  private           System.Boolean                  haveExitTime  // 0x91
  private           System.Boolean                  raisedOnExited  // 0x92
  private           System.Threading.RegisteredWaitHandleregisteredWaitHandle  // 0x98
  private           System.Threading.WaitHandle     waitHandle  // 0xA0
  private           System.ComponentModel.ISynchronizeInvokesynchronizingObject  // 0xA8
  private           System.IO.StreamReader          standardOutput  // 0xB0
  private           System.IO.StreamWriter          standardInput  // 0xB8
  private           System.IO.StreamReader          standardError  // 0xC0
  private           System.Boolean                  disposed  // 0xC8
  private           System.Diagnostics.Process.StreamReadModeoutputStreamReadMode  // 0xCC
  private           System.Diagnostics.Process.StreamReadModeerrorStreamReadMode  // 0xD0
  private           System.Diagnostics.Process.StreamReadModeinputStreamReadMode  // 0xD4
  private           System.Diagnostics.AsyncStreamReaderoutput  // 0xD8
  private           System.Diagnostics.AsyncStreamReadererror  // 0xE0
  private           System.String                   process_name  // 0xE8
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String machineName, System.Boolean isRemoteMachine, System.Int32 processId, System.Diagnostics.ProcessInfo processInfo)
  System.Boolean get_Associated()
  System.Int32 get_ExitCode()
  System.Boolean get_HasExited()
  System.IntPtr get_Handle()
  System.Int32 get_Id()
  System.Diagnostics.ProcessStartInfo get_StartInfo()
  System.Void set_StartInfo(System.Diagnostics.ProcessStartInfo value)
  System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject()
  System.IO.StreamReader get_StandardOutput()
  System.Void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle)
  System.Void CompletionCallback(System.Object context, System.Boolean wasSignaled)
  System.Void Dispose(System.Boolean disposing)
  System.Void Close()
  System.Void EnsureState(System.Diagnostics.Process.State state)
  System.Void EnsureWatchingForExit()
  System.Diagnostics.Process GetProcessById(System.Int32 processId)
  System.Diagnostics.Process GetCurrentProcess()
  System.Void OnExited()
  Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(System.Int32 access, System.Boolean throwIfExited)
  Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(System.Int32 access)
  Microsoft.Win32.SafeHandles.SafeProcessHandle OpenProcessHandle(System.Int32 access)
  System.Void Refresh()
  System.Void SetProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle)
  System.Void SetProcessId(System.Int32 processId)
  System.Boolean Start()
  System.Diagnostics.Process Start(System.String fileName)
  System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo)
  System.Void StopWatchingForExit()
  System.String ToString()
  System.Boolean WaitForExit(System.Int32 milliseconds)
  System.Void WaitForExit()
  System.Void .ctor(Microsoft.Win32.SafeHandles.SafeProcessHandle handle, System.Int32 id)
  System.String ProcessName_icall(System.IntPtr handle)
  System.String ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle)
  System.String get_ProcessName()
  System.IntPtr GetProcess_internal(System.Int32 pid)
  System.Diagnostics.Process GetProcessById(System.Int32 processId, System.String machineName)
  System.Boolean IsLocalMachine(System.String machineName)
  System.Boolean ShellExecuteEx_internal(System.Diagnostics.ProcessStartInfo startInfo, System.Diagnostics.Process.ProcInfo& procInfo)
  System.Boolean CreateProcess_internal(System.Diagnostics.ProcessStartInfo startInfo, System.IntPtr stdin, System.IntPtr stdout, System.IntPtr stderr, System.Diagnostics.Process.ProcInfo& procInfo)
  System.Boolean StartWithShellExecuteEx(System.Diagnostics.ProcessStartInfo startInfo)
  System.Void CreatePipe(System.IntPtr& read, System.IntPtr& write, System.Boolean writeDirection)
  System.Boolean get_IsWindows()
  System.Boolean StartWithCreateProcess(System.Diagnostics.ProcessStartInfo startInfo)
  System.Void FillUserInfo(System.Diagnostics.ProcessStartInfo startInfo, System.Diagnostics.Process.ProcInfo& procInfo)
  System.Void RaiseOnExited()
END_CLASS

CLASS: System.Diagnostics.ProcessInfo
TYPE:  class
TOKEN: 0x2000102
FIELDS:
METHODS:
END_CLASS

CLASS: System.Diagnostics.ProcessModuleCollection
TYPE:  class
TOKEN: 0x2000103
EXTENDS: ReadOnlyCollectionBase
FIELDS:
METHODS:
END_CLASS

CLASS: System.Diagnostics.ProcessStartInfo
TYPE:  class
TOKEN: 0x2000104
FIELDS:
  private           System.String                   fileName  // 0x10
  private           System.String                   arguments  // 0x18
  private           System.String                   directory  // 0x20
  private           System.String                   verb  // 0x28
  private           System.Diagnostics.ProcessWindowStylewindowStyle  // 0x30
  private           System.Boolean                  errorDialog  // 0x34
  private           System.IntPtr                   errorDialogParentHandle  // 0x38
  private           System.Boolean                  useShellExecute  // 0x40
  private           System.String                   userName  // 0x48
  private           System.String                   domain  // 0x50
  private           System.Security.SecureString    password  // 0x58
  private           System.String                   passwordInClearText  // 0x60
  private           System.Boolean                  loadUserProfile  // 0x68
  private           System.Boolean                  redirectStandardInput  // 0x69
  private           System.Boolean                  redirectStandardOutput  // 0x6A
  private           System.Boolean                  redirectStandardError  // 0x6B
  private           System.Text.Encoding            standardOutputEncoding  // 0x70
  private           System.Text.Encoding            standardErrorEncoding  // 0x78
  private           System.Boolean                  createNoWindow  // 0x80
  private           System.WeakReference            weakParentProcess  // 0x88
  private           System.Collections.Specialized.StringDictionaryenvironmentVariables  // 0x90
  private   static readonly System.String[]                 empty  // 0x0
  private           System.Collections.ObjectModel.Collection<System.String>_argumentList  // 0x98
  private           System.Collections.Generic.IDictionary<System.String,System.String>environment  // 0xA0
  private           System.Text.Encoding            <StandardInputEncoding>k__BackingField  // 0xA8
METHODS:
  System.Void .ctor(System.Diagnostics.Process parent)
  System.Void .ctor(System.String fileName)
  System.Collections.ObjectModel.Collection<System.String> get_ArgumentList()
  System.String get_Arguments()
  System.Void set_Arguments(System.String value)
  System.Void set_CreateNoWindow(System.Boolean value)
  System.Collections.Specialized.StringDictionary get_EnvironmentVariables()
  System.Boolean get_RedirectStandardInput()
  System.Boolean get_RedirectStandardOutput()
  System.Void set_RedirectStandardOutput(System.Boolean value)
  System.Boolean get_RedirectStandardError()
  System.Text.Encoding get_StandardErrorEncoding()
  System.Text.Encoding get_StandardOutputEncoding()
  System.Boolean get_UseShellExecute()
  System.Void set_UseShellExecute(System.Boolean value)
  System.String get_UserName()
  System.Security.SecureString get_Password()
  System.String get_Domain()
  System.Boolean get_LoadUserProfile()
  System.String get_FileName()
  System.Void set_FileName(System.String value)
  System.String get_WorkingDirectory()
  System.Boolean get_HaveEnvVars()
  System.Text.Encoding get_StandardInputEncoding()
  System.Void .cctor()
END_CLASS

CLASS: System.Diagnostics.ProcessThreadCollection
TYPE:  class
TOKEN: 0x2000105
EXTENDS: ReadOnlyCollectionBase
FIELDS:
METHODS:
END_CLASS

CLASS: System.Diagnostics.ProcessWaitHandle
TYPE:  class
TOKEN: 0x2000106
EXTENDS: WaitHandle
FIELDS:
METHODS:
  System.Void .ctor(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle)
END_CLASS

CLASS: System.Diagnostics.MonitoringDescriptionAttribute
TYPE:  class
TOKEN: 0x2000107
EXTENDS: DescriptionAttribute
FIELDS:
METHODS:
  System.Void .ctor(System.String description)
  System.String get_Description()
END_CLASS

CLASS: System.Diagnostics.ProcessWindowStyle
TYPE:  struct
TOKEN: 0x2000108
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Diagnostics.ProcessWindowStyleHidden  // 0x0
  public    static  System.Diagnostics.ProcessWindowStyleMaximized  // 0x0
  public    static  System.Diagnostics.ProcessWindowStyleMinimized  // 0x0
  public    static  System.Diagnostics.ProcessWindowStyleNormal  // 0x0
METHODS:
END_CLASS

CLASS: System.Diagnostics.Stopwatch
TYPE:  class
TOKEN: 0x2000109
FIELDS:
  public    static readonly System.Int64                    Frequency  // 0x0
  public    static readonly System.Boolean                  IsHighResolution  // 0x8
  private           System.Int64                    elapsed  // 0x10
  private           System.Int64                    started  // 0x18
  private           System.Boolean                  is_running  // 0x20
METHODS:
  System.Int64 GetTimestamp()
  System.Diagnostics.Stopwatch StartNew()
  System.Void .ctor()
  System.TimeSpan get_Elapsed()
  System.Int64 get_ElapsedMilliseconds()
  System.Int64 get_ElapsedTicks()
  System.Boolean get_IsRunning()
  System.Void Reset()
  System.Void Start()
  System.Void Stop()
  System.Void Restart()
  System.Void .cctor()
END_CLASS

CLASS: System.Diagnostics.DiagnosticsConfigurationHandler
TYPE:  class
TOKEN: 0x200038C
FIELDS:
METHODS:
  System.Void .ctor()
  System.Object Create(System.Object parent, System.Object configContext, System.Xml.XmlNode section)
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute
TYPE:  class
TOKEN: 0x200010A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.IO.InvalidDataException
TYPE:  class
TOKEN: 0x2000365
EXTENDS: SystemException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: System.IO.Compression.CompressionLevel
TYPE:  struct
TOKEN: 0x2000366
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.Compression.CompressionLevelOptimal  // 0x0
  public    static  System.IO.Compression.CompressionLevelFastest  // 0x0
  public    static  System.IO.Compression.CompressionLevelNoCompression  // 0x0
METHODS:
END_CLASS

CLASS: System.IO.Compression.CompressionMode
TYPE:  struct
TOKEN: 0x2000367
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.Compression.CompressionModeDecompress  // 0x0
  public    static  System.IO.Compression.CompressionModeCompress  // 0x0
METHODS:
END_CLASS

CLASS: System.IO.Compression.GZipStream
TYPE:  class
TOKEN: 0x2000368
EXTENDS: Stream
FIELDS:
  private           System.IO.Compression.DeflateStream_deflateStream  // 0x28
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode)
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen)
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Boolean get_CanSeek()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Void Flush()
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Void SetLength(System.Int64 value)
  System.Int32 ReadByte()
  System.IAsyncResult BeginRead(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.Int32 Read(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Int32 Read(System.Span<System.Byte> buffer)
  System.IAsyncResult BeginWrite(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Void Write(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Void Write(System.ReadOnlySpan<System.Byte> buffer)
  System.Void CopyTo(System.IO.Stream destination, System.Int32 bufferSize)
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] array, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] array, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, System.Int32 bufferSize, System.Threading.CancellationToken cancellationToken)
  System.Void CheckDeflateStream()
  System.Void ThrowStreamClosedException()
END_CLASS

CLASS: System.IO.Compression.DeflateStream
TYPE:  class
TOKEN: 0x2000369
EXTENDS: Stream
FIELDS:
  private           System.IO.Stream                base_stream  // 0x28
  private           System.IO.Compression.CompressionModemode  // 0x30
  private           System.Boolean                  leaveOpen  // 0x34
  private           System.Boolean                  disposed  // 0x35
  private           System.IO.Compression.DeflateStreamNativenative  // 0x38
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode)
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen, System.Int32 windowsBits)
  System.Void .ctor(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen, System.Boolean gzip)
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  System.Int32 ReadInternal(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, System.Threading.CancellationToken cancellationToken)
  System.Int32 ReadCore(System.Span<System.Byte> destination)
  System.Int32 Read(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Void WriteInternal(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, System.Threading.CancellationToken cancellationToken)
  System.Void WriteCore(System.ReadOnlySpan<System.Byte> source)
  System.Void Write(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Void Flush()
  System.IAsyncResult BeginRead(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.IAsyncResult BeginWrite(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Void SetLength(System.Int64 value)
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
END_CLASS

CLASS: System.IO.Compression.DeflateStreamNative
TYPE:  class
TOKEN: 0x200036C
FIELDS:
  private           System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWritefeeder  // 0x10
  private           System.IO.Stream                base_stream  // 0x18
  private           System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandlez_stream  // 0x20
  private           System.Runtime.InteropServices.GCHandledata  // 0x28
  private           System.Boolean                  disposed  // 0x30
  private           System.Byte[]                   io_buffer  // 0x38
  private           System.Exception                last_error  // 0x40
METHODS:
  System.Void .ctor()
  System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, System.Boolean gzip)
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  System.Void Flush()
  System.Int32 ReadZStream(System.IntPtr buffer, System.Int32 length)
  System.Void WriteZStream(System.IntPtr buffer, System.Int32 length)
  System.Int32 UnmanagedRead(System.IntPtr buffer, System.Int32 length, System.IntPtr data)
  System.Int32 UnmanagedRead(System.IntPtr buffer, System.Int32 length)
  System.Int32 UnmanagedWrite(System.IntPtr buffer, System.Int32 length, System.IntPtr data)
  System.Int32 UnmanagedWrite(System.IntPtr buffer, System.Int32 length)
  System.Void CheckResult(System.Int32 result, System.String where)
  System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, System.Boolean gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, System.IntPtr data)
  System.Int32 CloseZStream(System.IntPtr stream)
  System.Int32 Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream)
  System.Int32 ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, System.IntPtr buffer, System.Int32 length)
  System.Int32 WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, System.IntPtr buffer, System.Int32 length)
END_CLASS

CLASS: System.Net.ContextAwareResult
TYPE:  class
TOKEN: 0x200013E
EXTENDS: LazyAsyncResult
FIELDS:
  private           System.Threading.ExecutionContext_context  // 0x40
  private           System.Object                   _lock  // 0x48
  private           System.Net.ContextAwareResult.StateFlags_flags  // 0x50
METHODS:
  System.Void SafeCaptureIdentity()
  System.Void CleanupInternal()
  System.Void .ctor(System.Object myObject, System.Object myState, System.AsyncCallback myCallBack)
  System.Void .ctor(System.Boolean captureIdentity, System.Boolean forceCaptureContext, System.Object myObject, System.Object myState, System.AsyncCallback myCallBack)
  System.Void .ctor(System.Boolean captureIdentity, System.Boolean forceCaptureContext, System.Boolean threadSafeContextCopy, System.Object myObject, System.Object myState, System.AsyncCallback myCallBack)
  System.Object StartPostingAsyncOp()
  System.Object StartPostingAsyncOp(System.Boolean lockCapture)
  System.Boolean FinishPostingAsyncOp()
  System.Void Cleanup()
  System.Boolean CaptureOrComplete(System.Threading.ExecutionContext& cachedContext, System.Boolean returnContext)
  System.Void Complete(System.IntPtr userToken)
  System.Void CompleteCallback()
END_CLASS

CLASS: System.Net.HttpStatusDescription
TYPE:  class
TOKEN: 0x2000141
FIELDS:
METHODS:
  System.String Get(System.Net.HttpStatusCode code)
  System.String Get(System.Int32 code)
END_CLASS

CLASS: System.Net.HttpValidationHelpers
TYPE:  class
TOKEN: 0x2000142
FIELDS:
  private   static readonly System.Char[]                   s_httpTrimCharacters  // 0x0
METHODS:
  System.Boolean IsInvalidMethodOrHeaderString(System.String stringValue)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.NetEventSource
TYPE:  class
TOKEN: 0x2000143
EXTENDS: EventSource
FIELDS:
  public    static readonly System.Net.NetEventSource       Log  // 0x0
METHODS:
  System.Void Enter(System.Object thisOrContextObject, System.FormattableString formattableString, System.String memberName)
  System.Void Enter(System.Object thisOrContextObject, System.Object arg0, System.String memberName)
  System.Void Enter(System.Object thisOrContextObject, System.Object arg0, System.Object arg1, System.Object arg2, System.String memberName)
  System.Void Enter(System.String thisOrContextObject, System.String memberName, System.String parameters)
  System.Void Exit(System.Object thisOrContextObject, System.FormattableString formattableString, System.String memberName)
  System.Void Exit(System.Object thisOrContextObject, System.Object arg0, System.String memberName)
  System.Void Exit(System.String thisOrContextObject, System.String memberName, System.String result)
  System.Void Info(System.Object thisOrContextObject, System.FormattableString formattableString, System.String memberName)
  System.Void Info(System.Object thisOrContextObject, System.Object message, System.String memberName)
  System.Void Info(System.String thisOrContextObject, System.String memberName, System.String message)
  System.Void Error(System.Object thisOrContextObject, System.Object message, System.String memberName)
  System.Void ErrorMessage(System.String thisOrContextObject, System.String memberName, System.String message)
  System.Void Fail(System.Object thisOrContextObject, System.Object message, System.String memberName)
  System.Void CriticalFailure(System.String thisOrContextObject, System.String memberName, System.String message)
  System.Void Associate(System.Object first, System.Object second, System.String memberName)
  System.Void Associate(System.String thisOrContextObject, System.String memberName, System.String first, System.String second)
  System.Boolean get_IsEnabled()
  System.String IdOf(System.Object value)
  System.Int32 GetHashCode(System.Object value)
  System.Object Format(System.Object value)
  System.String Format(System.FormattableString s)
  System.Void WriteEvent(System.Int32 eventId, System.String arg1, System.String arg2, System.String arg3, System.String arg4)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.TcpValidationHelpers
TYPE:  class
TOKEN: 0x2000145
FIELDS:
METHODS:
  System.Boolean ValidatePortNumber(System.Int32 port)
END_CLASS

CLASS: System.Net.TlsStream
TYPE:  class
TOKEN: 0x2000146
EXTENDS: NetworkStream
FIELDS:
  private           System.Net.Security.SslStream   _sslStream  // 0x48
  private           System.String                   _host  // 0x50
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollection_clientCertificates  // 0x58
METHODS:
  System.Void .ctor(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, System.String host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates)
  System.Void AuthenticateAsClient()
  System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, System.Object state)
  System.Void EndAuthenticateAsClient(System.IAsyncResult asyncResult)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Void EndWrite(System.IAsyncResult result)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.Void Close()
END_CLASS

CLASS: System.Net.HttpStatusCode
TYPE:  struct
TOKEN: 0x2000147
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.HttpStatusCode       Continue  // 0x0
  public    static  System.Net.HttpStatusCode       SwitchingProtocols  // 0x0
  public    static  System.Net.HttpStatusCode       Processing  // 0x0
  public    static  System.Net.HttpStatusCode       EarlyHints  // 0x0
  public    static  System.Net.HttpStatusCode       OK  // 0x0
  public    static  System.Net.HttpStatusCode       Created  // 0x0
  public    static  System.Net.HttpStatusCode       Accepted  // 0x0
  public    static  System.Net.HttpStatusCode       NonAuthoritativeInformation  // 0x0
  public    static  System.Net.HttpStatusCode       NoContent  // 0x0
  public    static  System.Net.HttpStatusCode       ResetContent  // 0x0
  public    static  System.Net.HttpStatusCode       PartialContent  // 0x0
  public    static  System.Net.HttpStatusCode       MultiStatus  // 0x0
  public    static  System.Net.HttpStatusCode       AlreadyReported  // 0x0
  public    static  System.Net.HttpStatusCode       IMUsed  // 0x0
  public    static  System.Net.HttpStatusCode       MultipleChoices  // 0x0
  public    static  System.Net.HttpStatusCode       Ambiguous  // 0x0
  public    static  System.Net.HttpStatusCode       MovedPermanently  // 0x0
  public    static  System.Net.HttpStatusCode       Moved  // 0x0
  public    static  System.Net.HttpStatusCode       Found  // 0x0
  public    static  System.Net.HttpStatusCode       Redirect  // 0x0
  public    static  System.Net.HttpStatusCode       SeeOther  // 0x0
  public    static  System.Net.HttpStatusCode       RedirectMethod  // 0x0
  public    static  System.Net.HttpStatusCode       NotModified  // 0x0
  public    static  System.Net.HttpStatusCode       UseProxy  // 0x0
  public    static  System.Net.HttpStatusCode       Unused  // 0x0
  public    static  System.Net.HttpStatusCode       TemporaryRedirect  // 0x0
  public    static  System.Net.HttpStatusCode       RedirectKeepVerb  // 0x0
  public    static  System.Net.HttpStatusCode       PermanentRedirect  // 0x0
  public    static  System.Net.HttpStatusCode       BadRequest  // 0x0
  public    static  System.Net.HttpStatusCode       Unauthorized  // 0x0
  public    static  System.Net.HttpStatusCode       PaymentRequired  // 0x0
  public    static  System.Net.HttpStatusCode       Forbidden  // 0x0
  public    static  System.Net.HttpStatusCode       NotFound  // 0x0
  public    static  System.Net.HttpStatusCode       MethodNotAllowed  // 0x0
  public    static  System.Net.HttpStatusCode       NotAcceptable  // 0x0
  public    static  System.Net.HttpStatusCode       ProxyAuthenticationRequired  // 0x0
  public    static  System.Net.HttpStatusCode       RequestTimeout  // 0x0
  public    static  System.Net.HttpStatusCode       Conflict  // 0x0
  public    static  System.Net.HttpStatusCode       Gone  // 0x0
  public    static  System.Net.HttpStatusCode       LengthRequired  // 0x0
  public    static  System.Net.HttpStatusCode       PreconditionFailed  // 0x0
  public    static  System.Net.HttpStatusCode       RequestEntityTooLarge  // 0x0
  public    static  System.Net.HttpStatusCode       RequestUriTooLong  // 0x0
  public    static  System.Net.HttpStatusCode       UnsupportedMediaType  // 0x0
  public    static  System.Net.HttpStatusCode       RequestedRangeNotSatisfiable  // 0x0
  public    static  System.Net.HttpStatusCode       ExpectationFailed  // 0x0
  public    static  System.Net.HttpStatusCode       MisdirectedRequest  // 0x0
  public    static  System.Net.HttpStatusCode       UnprocessableEntity  // 0x0
  public    static  System.Net.HttpStatusCode       Locked  // 0x0
  public    static  System.Net.HttpStatusCode       FailedDependency  // 0x0
  public    static  System.Net.HttpStatusCode       UpgradeRequired  // 0x0
  public    static  System.Net.HttpStatusCode       PreconditionRequired  // 0x0
  public    static  System.Net.HttpStatusCode       TooManyRequests  // 0x0
  public    static  System.Net.HttpStatusCode       RequestHeaderFieldsTooLarge  // 0x0
  public    static  System.Net.HttpStatusCode       UnavailableForLegalReasons  // 0x0
  public    static  System.Net.HttpStatusCode       InternalServerError  // 0x0
  public    static  System.Net.HttpStatusCode       NotImplemented  // 0x0
  public    static  System.Net.HttpStatusCode       BadGateway  // 0x0
  public    static  System.Net.HttpStatusCode       ServiceUnavailable  // 0x0
  public    static  System.Net.HttpStatusCode       GatewayTimeout  // 0x0
  public    static  System.Net.HttpStatusCode       HttpVersionNotSupported  // 0x0
  public    static  System.Net.HttpStatusCode       VariantAlsoNegotiates  // 0x0
  public    static  System.Net.HttpStatusCode       InsufficientStorage  // 0x0
  public    static  System.Net.HttpStatusCode       LoopDetected  // 0x0
  public    static  System.Net.HttpStatusCode       NotExtended  // 0x0
  public    static  System.Net.HttpStatusCode       NetworkAuthenticationRequired  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.HttpVersion
TYPE:  class
TOKEN: 0x2000148
FIELDS:
  public    static readonly System.Version                  Unknown  // 0x0
  public    static readonly System.Version                  Version10  // 0x8
  public    static readonly System.Version                  Version11  // 0x10
  public    static readonly System.Version                  Version20  // 0x18
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Net.IPAddress
TYPE:  class
TOKEN: 0x2000149
FIELDS:
  public    static readonly System.Net.IPAddress            Any  // 0x0
  public    static readonly System.Net.IPAddress            Loopback  // 0x8
  public    static readonly System.Net.IPAddress            Broadcast  // 0x10
  public    static readonly System.Net.IPAddress            None  // 0x18
  private   static  System.Int64                    LoopbackMask  // 0x0
  public    static readonly System.Net.IPAddress            IPv6Any  // 0x20
  public    static readonly System.Net.IPAddress            IPv6Loopback  // 0x28
  public    static readonly System.Net.IPAddress            IPv6None  // 0x30
  private           System.UInt32                   _addressOrScopeId  // 0x10
  private   readonly System.UInt16[]                 _numbers  // 0x18
  private           System.String                   _toString  // 0x20
  private           System.Int32                    _hashCode  // 0x28
  private   static  System.Int32                    NumberOfLabels  // 0x0
METHODS:
  System.Boolean get_IsIPv4()
  System.Boolean get_IsIPv6()
  System.UInt32 get_PrivateAddress()
  System.Void set_PrivateAddress(System.UInt32 value)
  System.UInt32 get_PrivateScopeId()
  System.Void set_PrivateScopeId(System.UInt32 value)
  System.Void .ctor(System.Int64 newAddress)
  System.Void .ctor(System.Byte[] address, System.Int64 scopeid)
  System.Void .ctor(System.ReadOnlySpan<System.Byte> address, System.Int64 scopeid)
  System.Void .ctor(System.UInt16* numbers, System.Int32 numbersLength, System.UInt32 scopeid)
  System.Void .ctor(System.UInt16[] numbers, System.UInt32 scopeid)
  System.Void .ctor(System.Byte[] address)
  System.Void .ctor(System.ReadOnlySpan<System.Byte> address)
  System.Boolean TryParse(System.String ipString, System.Net.IPAddress& address)
  System.Net.IPAddress Parse(System.String ipString)
  System.Boolean TryWriteBytes(System.Span<System.Byte> destination, System.Int32& bytesWritten)
  System.Void WriteIPv6Bytes(System.Span<System.Byte> destination)
  System.Void WriteIPv4Bytes(System.Span<System.Byte> destination)
  System.Byte[] GetAddressBytes()
  System.Net.Sockets.AddressFamily get_AddressFamily()
  System.Int64 get_ScopeId()
  System.String ToString()
  System.Boolean IsLoopback(System.Net.IPAddress address)
  System.Boolean Equals(System.Object comparandObj, System.Boolean compareScopeId)
  System.Boolean Equals(System.Object comparand)
  System.Int32 GetHashCode()
  System.Net.IPAddress MapToIPv6()
  System.Byte[] ThrowAddressNullException()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.IPAddressParser
TYPE:  class
TOKEN: 0x200014B
FIELDS:
METHODS:
  System.Net.IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, System.Boolean tryParse)
  System.String IPv4AddressToString(System.UInt32 address)
  System.Void IPv4AddressToString(System.UInt32 address, System.Text.StringBuilder destination)
  System.Int32 IPv4AddressToStringHelper(System.UInt32 address, System.Char* addressString)
  System.String IPv6AddressToString(System.UInt16[] address, System.UInt32 scopeId)
  System.Text.StringBuilder IPv6AddressToStringHelper(System.UInt16[] address, System.UInt32 scopeId)
  System.Void FormatIPv4AddressNumber(System.Int32 number, System.Char* addressString, System.Int32& offset)
  System.Boolean Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, System.Int64& address)
  System.Boolean Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, System.UInt16* numbers, System.Int32 numbersLength, System.UInt32& scope)
  System.Void AppendSections(System.UInt16[] address, System.Int32 fromInclusive, System.Int32 toExclusive, System.Text.StringBuilder buffer)
  System.Void AppendHex(System.UInt16 value, System.Text.StringBuilder buffer)
  System.UInt32 ExtractIPv4Address(System.UInt16[] address)
  System.UInt16 Reverse(System.UInt16 number)
END_CLASS

CLASS: System.Net.IPEndPoint
TYPE:  class
TOKEN: 0x200014C
EXTENDS: EndPoint
FIELDS:
  private           System.Net.IPAddress            _address  // 0x10
  private           System.Int32                    _port  // 0x18
  private   static  System.Net.IPEndPoint           Any  // 0x0
  private   static  System.Net.IPEndPoint           IPv6Any  // 0x8
METHODS:
  System.Net.Sockets.AddressFamily get_AddressFamily()
  System.Void .ctor(System.Net.IPAddress address, System.Int32 port)
  System.Net.IPAddress get_Address()
  System.Int32 get_Port()
  System.String ToString()
  System.Net.SocketAddress Serialize()
  System.Net.EndPoint Create(System.Net.SocketAddress socketAddress)
  System.Boolean Equals(System.Object comparand)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.CommandStream
TYPE:  class
TOKEN: 0x200014D
EXTENDS: NetworkStreamWrapper
FIELDS:
  private   static readonly System.AsyncCallback            s_writeCallbackDelegate  // 0x0
  private   static readonly System.AsyncCallback            s_readCallbackDelegate  // 0x8
  private           System.Boolean                  _recoverableFailure  // 0x38
  protected         System.Net.WebRequest           _request  // 0x40
  protected         System.Boolean                  _isAsync  // 0x48
  private           System.Boolean                  _aborted  // 0x49
  protected         System.Net.CommandStream.PipelineEntry[]_commands  // 0x50
  protected         System.Int32                    _index  // 0x58
  private           System.Boolean                  _doRead  // 0x5C
  private           System.Boolean                  _doSend  // 0x5D
  private           System.Net.ResponseDescription  _currentResponseDescription  // 0x60
  protected         System.String                   _abortReason  // 0x68
  private           System.String                   _buffer  // 0x70
  private           System.Text.Encoding            _encoding  // 0x78
  private           System.Text.Decoder             _decoder  // 0x80
METHODS:
  System.Void .ctor(System.Net.Sockets.TcpClient client)
  System.Void Abort(System.Exception e)
  System.Void Dispose(System.Boolean disposing)
  System.Void InvokeRequestCallback(System.Object obj)
  System.Boolean get_RecoverableFailure()
  System.Void MarkAsRecoverableFailure()
  System.IO.Stream SubmitRequest(System.Net.WebRequest request, System.Boolean isAsync, System.Boolean readInitalResponseOnConnect)
  System.Void ClearState()
  System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request)
  System.Exception GenerateException(System.String message, System.Net.WebExceptionStatus status, System.Exception innerException)
  System.Exception GenerateException(System.Net.FtpStatusCode code, System.String statusDescription, System.Exception innerException)
  System.Void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, System.Boolean isAsync)
  System.Void CheckContinuePipeline()
  System.IO.Stream ContinueCommandPipeline()
  System.Boolean PostSendCommandProcessing(System.IO.Stream& stream)
  System.Boolean PostReadCommandProcessing(System.IO.Stream& stream)
  System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, System.Boolean timeout, System.IO.Stream& stream)
  System.Void ReadCallback(System.IAsyncResult asyncResult)
  System.Void WriteCallback(System.IAsyncResult asyncResult)
  System.Text.Encoding get_Encoding()
  System.Void set_Encoding(System.Text.Encoding value)
  System.Boolean CheckValid(System.Net.ResponseDescription response, System.Int32& validThrough, System.Int32& completeLength)
  System.Net.ResponseDescription ReceiveCommandResponse()
  System.Void ReceiveCommandResponseCallback(System.Net.ReceiveState state, System.Int32 bytesRead)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.ResponseDescription
TYPE:  class
TOKEN: 0x2000151
FIELDS:
  private           System.Boolean                  Multiline  // 0x10
  private           System.Int32                    Status  // 0x14
  private           System.String                   StatusDescription  // 0x18
  private           System.Text.StringBuilder       StatusBuffer  // 0x20
  private           System.String                   StatusCodeString  // 0x28
METHODS:
  System.Boolean get_PositiveIntermediate()
  System.Boolean get_PositiveCompletion()
  System.Boolean get_TransientFailure()
  System.Boolean get_PermanentFailure()
  System.Boolean get_InvalidStatusCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.ReceiveState
TYPE:  class
TOKEN: 0x2000152
FIELDS:
  private           System.Net.ResponseDescription  Resp  // 0x10
  private           System.Int32                    ValidThrough  // 0x18
  private           System.Byte[]                   Buffer  // 0x20
  private           System.Net.CommandStream        Connection  // 0x28
METHODS:
  System.Void .ctor(System.Net.CommandStream connection)
END_CLASS

CLASS: System.Net.FtpLoginState
TYPE:  struct
TOKEN: 0x2000153
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  System.Net.FtpLoginState        NotLoggedIn  // 0x0
  public    static  System.Net.FtpLoginState        LoggedIn  // 0x0
  public    static  System.Net.FtpLoginState        LoggedInButNeedsRelogin  // 0x0
  public    static  System.Net.FtpLoginState        ReloginFailed  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.FtpControlStream
TYPE:  class
TOKEN: 0x2000154
EXTENDS: CommandStream
FIELDS:
  private           System.Net.Sockets.Socket       _dataSocket  // 0x88
  private           System.Net.IPEndPoint           _passiveEndPoint  // 0x90
  private           System.Net.TlsStream            _tlsStream  // 0x98
  private           System.Text.StringBuilder       _bannerMessage  // 0xA0
  private           System.Text.StringBuilder       _welcomeMessage  // 0xA8
  private           System.Text.StringBuilder       _exitMessage  // 0xB0
  private           System.WeakReference            _credentials  // 0xB8
  private           System.String                   _currentTypeSetting  // 0xC0
  private           System.Int64                    _contentLength  // 0xC8
  private           System.DateTime                 _lastModified  // 0xD0
  private           System.Boolean                  _dataHandshakeStarted  // 0xD8
  private           System.String                   _loginDirectory  // 0xE0
  private           System.String                   _establishedServerDirectory  // 0xE8
  private           System.String                   _requestedServerDirectory  // 0xF0
  private           System.Uri                      _responseUri  // 0xF8
  private           System.Net.FtpLoginState        _loginState  // 0x100
  private           System.Net.FtpStatusCode        StatusCode  // 0x104
  private           System.String                   StatusLine  // 0x108
  private   static readonly System.AsyncCallback            s_acceptCallbackDelegate  // 0x0
  private   static readonly System.AsyncCallback            s_connectCallbackDelegate  // 0x8
  private   static readonly System.AsyncCallback            s_SSLHandshakeCallback  // 0x10
METHODS:
  System.Net.NetworkCredential get_Credentials()
  System.Void set_Credentials(System.Net.NetworkCredential value)
  System.Void .ctor(System.Net.Sockets.TcpClient client)
  System.Void AbortConnect()
  System.Void AcceptCallback(System.IAsyncResult asyncResult)
  System.Void ConnectCallback(System.IAsyncResult asyncResult)
  System.Void SSLHandshakeCallback(System.IAsyncResult asyncResult)
  System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(System.IO.Stream& stream)
  System.Void ClearState()
  System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, System.Boolean timeout, System.IO.Stream& stream)
  System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req)
  System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, System.Boolean timeout, System.IO.Stream& stream, System.Boolean& isSocketReady)
  System.Void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, System.String& path, System.String& directory, System.String& filename)
  System.String FormatAddress(System.Net.IPAddress address, System.Int32 Port)
  System.String FormatAddressV6(System.Net.IPAddress address, System.Int32 port)
  System.Int64 get_ContentLength()
  System.DateTime get_LastModified()
  System.Uri get_ResponseUri()
  System.String get_BannerMessage()
  System.String get_WelcomeMessage()
  System.String get_ExitMessage()
  System.Int64 GetContentLengthFrom213Response(System.String responseString)
  System.DateTime GetLastModifiedFrom213Response(System.String str)
  System.Void TryUpdateResponseUri(System.String str, System.Net.FtpWebRequest request)
  System.Void TryUpdateContentLength(System.String str)
  System.String GetLoginDirectory(System.String str)
  System.Int32 GetPortV4(System.String responseString)
  System.Int32 GetPortV6(System.String responseString)
  System.Void CreateFtpListenerSocket(System.Net.FtpWebRequest request)
  System.String GetPortCommandLine(System.Net.FtpWebRequest request)
  System.String FormatFtpCommand(System.String command, System.String parameter)
  System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket)
  System.Boolean CheckValid(System.Net.ResponseDescription response, System.Int32& validThrough, System.Int32& completeLength)
  System.Net.TriState IsFtpDataStreamWriteable()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.FtpDataStream
TYPE:  class
TOKEN: 0x2000157
EXTENDS: Stream
FIELDS:
  private           System.Net.FtpWebRequest        _request  // 0x28
  private           System.Net.Sockets.NetworkStream_networkStream  // 0x30
  private           System.Boolean                  _writeable  // 0x38
  private           System.Boolean                  _readable  // 0x39
  private           System.Boolean                  _isFullyRead  // 0x3A
  private           System.Boolean                  _closing  // 0x3B
METHODS:
  System.Void .ctor(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly)
  System.Void Dispose(System.Boolean disposing)
  System.Void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState)
  System.Void CheckError()
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void AsyncReadCallback(System.IAsyncResult ar)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult ar)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Void Flush()
  System.Void SetLength(System.Int64 value)
  System.Boolean get_CanTimeout()
  System.Int32 get_ReadTimeout()
  System.Void set_ReadTimeout(System.Int32 value)
  System.Int32 get_WriteTimeout()
  System.Void set_WriteTimeout(System.Int32 value)
  System.Void SetSocketTimeoutOption(System.Int32 timeout)
END_CLASS

CLASS: System.Net.FtpOperation
TYPE:  struct
TOKEN: 0x2000158
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.FtpOperation         DownloadFile  // 0x0
  public    static  System.Net.FtpOperation         ListDirectory  // 0x0
  public    static  System.Net.FtpOperation         ListDirectoryDetails  // 0x0
  public    static  System.Net.FtpOperation         UploadFile  // 0x0
  public    static  System.Net.FtpOperation         UploadFileUnique  // 0x0
  public    static  System.Net.FtpOperation         AppendFile  // 0x0
  public    static  System.Net.FtpOperation         DeleteFile  // 0x0
  public    static  System.Net.FtpOperation         GetDateTimestamp  // 0x0
  public    static  System.Net.FtpOperation         GetFileSize  // 0x0
  public    static  System.Net.FtpOperation         Rename  // 0x0
  public    static  System.Net.FtpOperation         MakeDirectory  // 0x0
  public    static  System.Net.FtpOperation         RemoveDirectory  // 0x0
  public    static  System.Net.FtpOperation         PrintWorkingDirectory  // 0x0
  public    static  System.Net.FtpOperation         Other  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.FtpMethodFlags
TYPE:  struct
TOKEN: 0x2000159
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.FtpMethodFlags       None  // 0x0
  public    static  System.Net.FtpMethodFlags       IsDownload  // 0x0
  public    static  System.Net.FtpMethodFlags       IsUpload  // 0x0
  public    static  System.Net.FtpMethodFlags       TakesParameter  // 0x0
  public    static  System.Net.FtpMethodFlags       MayTakeParameter  // 0x0
  public    static  System.Net.FtpMethodFlags       DoesNotTakeParameter  // 0x0
  public    static  System.Net.FtpMethodFlags       ParameterIsDirectory  // 0x0
  public    static  System.Net.FtpMethodFlags       ShouldParseForResponseUri  // 0x0
  public    static  System.Net.FtpMethodFlags       HasHttpCommand  // 0x0
  public    static  System.Net.FtpMethodFlags       MustChangeWorkingDirectoryToPath  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.FtpMethodInfo
TYPE:  class
TOKEN: 0x200015A
FIELDS:
  private           System.String                   Method  // 0x10
  private           System.Net.FtpOperation         Operation  // 0x18
  private           System.Net.FtpMethodFlags       Flags  // 0x1C
  private           System.String                   HttpCommand  // 0x20
  private   static readonly System.Net.FtpMethodInfo[]      s_knownMethodInfo  // 0x0
METHODS:
  System.Void .ctor(System.String method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, System.String httpCommand)
  System.Boolean HasFlag(System.Net.FtpMethodFlags flags)
  System.Boolean get_IsCommandOnly()
  System.Boolean get_IsUpload()
  System.Boolean get_IsDownload()
  System.Boolean get_ShouldParseForResponseUri()
  System.Net.FtpMethodInfo GetMethodInfo(System.String method)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.FtpWebRequest
TYPE:  class
TOKEN: 0x200015B
EXTENDS: WebRequest
FIELDS:
  private           System.Object                   _syncObject  // 0x38
  private           System.Net.ICredentials         _authInfo  // 0x40
  private   readonly System.Uri                      _uri  // 0x48
  private           System.Net.FtpMethodInfo        _methodInfo  // 0x50
  private           System.String                   _renameTo  // 0x58
  private           System.Boolean                  _getRequestStreamStarted  // 0x60
  private           System.Boolean                  _getResponseStarted  // 0x61
  private           System.DateTime                 _startTime  // 0x68
  private           System.Int32                    _timeout  // 0x70
  private           System.Int32                    _remainingTimeout  // 0x74
  private           System.Int64                    _contentLength  // 0x78
  private           System.Int64                    _contentOffset  // 0x80
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollection_clientCertificates  // 0x88
  private           System.Boolean                  _passive  // 0x90
  private           System.Boolean                  _binary  // 0x91
  private           System.String                   _connectionGroupName  // 0x98
  private           System.Boolean                  _async  // 0xA0
  private           System.Boolean                  _aborted  // 0xA1
  private           System.Boolean                  _timedOut  // 0xA2
  private           System.Exception                _exception  // 0xA8
  private           System.Net.TimerThread.Queue    _timerQueue  // 0xB0
  private           System.Net.TimerThread.Callback _timerCallback  // 0xB8
  private           System.Boolean                  _enableSsl  // 0xC0
  private           System.Net.FtpControlStream     _connection  // 0xC8
  private           System.IO.Stream                _stream  // 0xD0
  private           System.Net.FtpWebRequest.RequestStage_requestStage  // 0xD8
  private           System.Boolean                  _onceFailed  // 0xDC
  private           System.Net.WebHeaderCollection  _ftpRequestHeaders  // 0xE0
  private           System.Net.FtpWebResponse       _ftpWebResponse  // 0xE8
  private           System.Int32                    _readWriteTimeout  // 0xF0
  private           System.Net.ContextAwareResult   _writeAsyncResult  // 0xF8
  private           System.Net.LazyAsyncResult      _readAsyncResult  // 0x100
  private           System.Net.LazyAsyncResult      _requestCompleteAsyncResult  // 0x108
  private   static readonly System.Net.NetworkCredential    s_defaultFtpNetworkCredential  // 0x0
  private   static readonly System.Net.TimerThread.Queue    s_DefaultTimerQueue  // 0x8
METHODS:
  System.Net.FtpMethodInfo get_MethodInfo()
  System.String get_Method()
  System.Void set_Method(System.String value)
  System.String get_RenameTo()
  System.Net.ICredentials get_Credentials()
  System.Void set_Credentials(System.Net.ICredentials value)
  System.Uri get_RequestUri()
  System.Int32 get_Timeout()
  System.Void set_Timeout(System.Int32 value)
  System.Int32 get_RemainingTimeout()
  System.Int32 get_ReadWriteTimeout()
  System.Int64 get_ContentOffset()
  System.Int64 get_ContentLength()
  System.Void set_ContentLength(System.Int64 value)
  System.Net.IWebProxy get_Proxy()
  System.Void set_Proxy(System.Net.IWebProxy value)
  System.Void set_ConnectionGroupName(System.String value)
  System.Boolean get_Aborted()
  System.Void .ctor(System.Uri uri)
  System.Net.WebResponse GetResponse()
  System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state)
  System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult)
  System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state)
  System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult)
  System.Void SubmitRequest(System.Boolean isAsync)
  System.Exception TranslateConnectException(System.Exception e)
  System.Void CreateConnectionAsync()
  System.Net.FtpControlStream CreateConnection()
  System.IO.Stream TimedSubmitRequestHelper(System.Boolean isAsync)
  System.Void TimerCallback(System.Net.TimerThread.Timer timer, System.Int32 timeNoticed, System.Object context)
  System.Net.TimerThread.Queue get_TimerQueue()
  System.Boolean AttemptedRecovery(System.Exception e)
  System.Void SetException(System.Exception exception)
  System.Void CheckError()
  System.Void RequestCallback(System.Object obj)
  System.Void SyncRequestCallback(System.Object obj)
  System.Void AsyncRequestCallback(System.Object obj)
  System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage)
  System.Void Abort()
  System.Void set_CachePolicy(System.Net.Cache.RequestCachePolicy value)
  System.Boolean get_UseBinary()
  System.Boolean get_UsePassive()
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Boolean get_EnableSsl()
  System.Net.WebHeaderCollection get_Headers()
  System.Boolean get_UseDefaultCredentials()
  System.Void set_PreAuthenticate(System.Boolean value)
  System.Boolean get_InUse()
  System.Void EnsureFtpWebResponse(System.Exception exception)
  System.Void DataStreamClosed(System.Net.CloseExState closeState)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.FtpWebRequestCreator
TYPE:  class
TOKEN: 0x200015F
FIELDS:
METHODS:
  System.Void .ctor()
  System.Net.WebRequest Create(System.Uri uri)
END_CLASS

CLASS: System.Net.FtpWebResponse
TYPE:  class
TOKEN: 0x2000160
EXTENDS: WebResponse
FIELDS:
  private           System.IO.Stream                _responseStream  // 0x20
  private           System.Int64                    _contentLength  // 0x28
  private           System.Uri                      _responseUri  // 0x30
  private           System.Net.FtpStatusCode        _statusCode  // 0x38
  private           System.String                   _statusLine  // 0x40
  private           System.Net.WebHeaderCollection  _ftpRequestHeaders  // 0x48
  private           System.DateTime                 _lastModified  // 0x50
  private           System.String                   _bannerMessage  // 0x58
  private           System.String                   _welcomeMessage  // 0x60
  private           System.String                   _exitMessage  // 0x68
METHODS:
  System.Void .ctor(System.IO.Stream responseStream, System.Int64 contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, System.String statusLine, System.DateTime lastModified, System.String bannerMessage, System.String welcomeMessage, System.String exitMessage)
  System.Void UpdateStatus(System.Net.FtpStatusCode statusCode, System.String statusLine, System.String exitMessage)
  System.IO.Stream GetResponseStream()
  System.Void SetResponseStream(System.IO.Stream stream)
  System.Void Close()
  System.Net.WebHeaderCollection get_Headers()
  System.Uri get_ResponseUri()
  System.Net.FtpStatusCode get_StatusCode()
END_CLASS

CLASS: System.Net.NetworkStreamWrapper
TYPE:  class
TOKEN: 0x2000162
EXTENDS: Stream
FIELDS:
  private           System.Net.Sockets.TcpClient    _client  // 0x28
  private           System.Net.Sockets.NetworkStream_networkStream  // 0x30
METHODS:
  System.Void .ctor(System.Net.Sockets.TcpClient client)
  System.Boolean get_UsingSecureStream()
  System.Net.IPAddress get_ServerAddress()
  System.Net.Sockets.Socket get_Socket()
  System.Net.Sockets.NetworkStream get_NetworkStream()
  System.Void set_NetworkStream(System.Net.Sockets.NetworkStream value)
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Boolean get_CanTimeout()
  System.Int32 get_ReadTimeout()
  System.Void set_ReadTimeout(System.Int32 value)
  System.Int32 get_WriteTimeout()
  System.Void set_WriteTimeout(System.Int32 value)
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Dispose(System.Boolean disposing)
  System.Void CloseSocket()
  System.Void Close(System.Int32 timeout)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Void Flush()
  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  System.Void SetLength(System.Int64 value)
  System.Void SetSocketTimeoutOption(System.Int32 timeout)
END_CLASS

CLASS: System.Net.SecurityProtocolType
TYPE:  struct
TOKEN: 0x2000163
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.SecurityProtocolType SystemDefault  // 0x0
  public    static  System.Net.SecurityProtocolType Ssl3  // 0x0
  public    static  System.Net.SecurityProtocolType Tls  // 0x0
  public    static  System.Net.SecurityProtocolType Tls11  // 0x0
  public    static  System.Net.SecurityProtocolType Tls12  // 0x0
  public    static  System.Net.SecurityProtocolType Tls13  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Authorization
TYPE:  class
TOKEN: 0x2000164
FIELDS:
  private           System.String                   m_Message  // 0x10
  private           System.Boolean                  m_Complete  // 0x18
  private           System.String                   ModuleAuthenticationType  // 0x20
METHODS:
  System.Void .ctor(System.String token)
  System.Void .ctor(System.String token, System.Boolean finished)
  System.String get_Message()
  System.Boolean get_Complete()
END_CLASS

CLASS: System.Net.CredentialCache
TYPE:  class
TOKEN: 0x2000165
FIELDS:
METHODS:
  System.Net.ICredentials get_DefaultCredentials()
  System.Net.NetworkCredential get_DefaultNetworkCredentials()
END_CLASS

CLASS: System.Net.SystemNetworkCredential
TYPE:  class
TOKEN: 0x2000166
EXTENDS: NetworkCredential
FIELDS:
  private   static readonly System.Net.SystemNetworkCredentialdefaultCredential  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.EndPoint
TYPE:  class
TOKEN: 0x2000167
FIELDS:
METHODS:
  System.Net.Sockets.AddressFamily get_AddressFamily()
  System.Net.SocketAddress Serialize()
  System.Net.EndPoint Create(System.Net.SocketAddress socketAddress)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.FtpStatusCode
TYPE:  struct
TOKEN: 0x2000168
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.FtpStatusCode        Undefined  // 0x0
  public    static  System.Net.FtpStatusCode        RestartMarker  // 0x0
  public    static  System.Net.FtpStatusCode        ServiceTemporarilyNotAvailable  // 0x0
  public    static  System.Net.FtpStatusCode        DataAlreadyOpen  // 0x0
  public    static  System.Net.FtpStatusCode        OpeningData  // 0x0
  public    static  System.Net.FtpStatusCode        CommandOK  // 0x0
  public    static  System.Net.FtpStatusCode        CommandExtraneous  // 0x0
  public    static  System.Net.FtpStatusCode        DirectoryStatus  // 0x0
  public    static  System.Net.FtpStatusCode        FileStatus  // 0x0
  public    static  System.Net.FtpStatusCode        SystemType  // 0x0
  public    static  System.Net.FtpStatusCode        SendUserCommand  // 0x0
  public    static  System.Net.FtpStatusCode        ClosingControl  // 0x0
  public    static  System.Net.FtpStatusCode        ClosingData  // 0x0
  public    static  System.Net.FtpStatusCode        EnteringPassive  // 0x0
  public    static  System.Net.FtpStatusCode        LoggedInProceed  // 0x0
  public    static  System.Net.FtpStatusCode        ServerWantsSecureSession  // 0x0
  public    static  System.Net.FtpStatusCode        FileActionOK  // 0x0
  public    static  System.Net.FtpStatusCode        PathnameCreated  // 0x0
  public    static  System.Net.FtpStatusCode        SendPasswordCommand  // 0x0
  public    static  System.Net.FtpStatusCode        NeedLoginAccount  // 0x0
  public    static  System.Net.FtpStatusCode        FileCommandPending  // 0x0
  public    static  System.Net.FtpStatusCode        ServiceNotAvailable  // 0x0
  public    static  System.Net.FtpStatusCode        CantOpenData  // 0x0
  public    static  System.Net.FtpStatusCode        ConnectionClosed  // 0x0
  public    static  System.Net.FtpStatusCode        ActionNotTakenFileUnavailableOrBusy  // 0x0
  public    static  System.Net.FtpStatusCode        ActionAbortedLocalProcessingError  // 0x0
  public    static  System.Net.FtpStatusCode        ActionNotTakenInsufficientSpace  // 0x0
  public    static  System.Net.FtpStatusCode        CommandSyntaxError  // 0x0
  public    static  System.Net.FtpStatusCode        ArgumentSyntaxError  // 0x0
  public    static  System.Net.FtpStatusCode        CommandNotImplemented  // 0x0
  public    static  System.Net.FtpStatusCode        BadCommandSequence  // 0x0
  public    static  System.Net.FtpStatusCode        NotLoggedIn  // 0x0
  public    static  System.Net.FtpStatusCode        AccountNeeded  // 0x0
  public    static  System.Net.FtpStatusCode        ActionNotTakenFileUnavailable  // 0x0
  public    static  System.Net.FtpStatusCode        ActionAbortedUnknownPageType  // 0x0
  public    static  System.Net.FtpStatusCode        FileActionAborted  // 0x0
  public    static  System.Net.FtpStatusCode        ActionNotTakenFilenameNotAllowed  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.HttpRequestHeader
TYPE:  struct
TOKEN: 0x2000169
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.HttpRequestHeader    CacheControl  // 0x0
  public    static  System.Net.HttpRequestHeader    Connection  // 0x0
  public    static  System.Net.HttpRequestHeader    Date  // 0x0
  public    static  System.Net.HttpRequestHeader    KeepAlive  // 0x0
  public    static  System.Net.HttpRequestHeader    Pragma  // 0x0
  public    static  System.Net.HttpRequestHeader    Trailer  // 0x0
  public    static  System.Net.HttpRequestHeader    TransferEncoding  // 0x0
  public    static  System.Net.HttpRequestHeader    Upgrade  // 0x0
  public    static  System.Net.HttpRequestHeader    Via  // 0x0
  public    static  System.Net.HttpRequestHeader    Warning  // 0x0
  public    static  System.Net.HttpRequestHeader    Allow  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentLength  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentType  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentEncoding  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentLanguage  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentLocation  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentMd5  // 0x0
  public    static  System.Net.HttpRequestHeader    ContentRange  // 0x0
  public    static  System.Net.HttpRequestHeader    Expires  // 0x0
  public    static  System.Net.HttpRequestHeader    LastModified  // 0x0
  public    static  System.Net.HttpRequestHeader    Accept  // 0x0
  public    static  System.Net.HttpRequestHeader    AcceptCharset  // 0x0
  public    static  System.Net.HttpRequestHeader    AcceptEncoding  // 0x0
  public    static  System.Net.HttpRequestHeader    AcceptLanguage  // 0x0
  public    static  System.Net.HttpRequestHeader    Authorization  // 0x0
  public    static  System.Net.HttpRequestHeader    Cookie  // 0x0
  public    static  System.Net.HttpRequestHeader    Expect  // 0x0
  public    static  System.Net.HttpRequestHeader    From  // 0x0
  public    static  System.Net.HttpRequestHeader    Host  // 0x0
  public    static  System.Net.HttpRequestHeader    IfMatch  // 0x0
  public    static  System.Net.HttpRequestHeader    IfModifiedSince  // 0x0
  public    static  System.Net.HttpRequestHeader    IfNoneMatch  // 0x0
  public    static  System.Net.HttpRequestHeader    IfRange  // 0x0
  public    static  System.Net.HttpRequestHeader    IfUnmodifiedSince  // 0x0
  public    static  System.Net.HttpRequestHeader    MaxForwards  // 0x0
  public    static  System.Net.HttpRequestHeader    ProxyAuthorization  // 0x0
  public    static  System.Net.HttpRequestHeader    Referer  // 0x0
  public    static  System.Net.HttpRequestHeader    Range  // 0x0
  public    static  System.Net.HttpRequestHeader    Te  // 0x0
  public    static  System.Net.HttpRequestHeader    Translate  // 0x0
  public    static  System.Net.HttpRequestHeader    UserAgent  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.IAuthenticationModule
TYPE:  interface
TOKEN: 0x200016A
FIELDS:
METHODS:
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest request, System.Net.ICredentials credentials)
  System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials)
  System.String get_AuthenticationType()
END_CLASS

CLASS: System.Net.ICertificatePolicy
TYPE:  interface
TOKEN: 0x200016B
FIELDS:
METHODS:
  System.Boolean CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, System.Int32 certificateProblem)
END_CLASS

CLASS: System.Net.ICredentials
TYPE:  interface
TOKEN: 0x200016C
FIELDS:
METHODS:
  System.Net.NetworkCredential GetCredential(System.Uri uri, System.String authType)
END_CLASS

CLASS: System.Net.IPHostEntry
TYPE:  class
TOKEN: 0x200016D
FIELDS:
  private           System.String                   hostName  // 0x10
  private           System.String[]                 aliases  // 0x18
  private           System.Net.IPAddress[]          addressList  // 0x20
  private           System.Boolean                  isTrustedHost  // 0x28
METHODS:
  System.String get_HostName()
  System.Void set_HostName(System.String value)
  System.Void set_Aliases(System.String[] value)
  System.Net.IPAddress[] get_AddressList()
  System.Void set_AddressList(System.Net.IPAddress[] value)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.IWebRequestCreate
TYPE:  interface
TOKEN: 0x200016E
FIELDS:
METHODS:
  System.Net.WebRequest Create(System.Uri uri)
END_CLASS

CLASS: System.Net.InternalException
TYPE:  class
TOKEN: 0x200016F
EXTENDS: SystemException
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NclUtilities
TYPE:  class
TOKEN: 0x2000170
FIELDS:
  private   static  System.Net.IPAddress[]          _LocalAddresses  // 0x0
  private   static  System.Object                   _LocalAddressesLock  // 0x8
  private   static  System.String                   _LocalDomainName  // 0x10
METHODS:
  System.Boolean IsFatal(System.Exception exception)
  System.Boolean IsAddressLocal(System.Net.IPAddress ipAddress)
  System.Net.IPHostEntry GetLocalHost()
  System.Net.IPAddress[] get_LocalAddresses()
  System.Object get_LocalAddressesLock()
END_CLASS

CLASS: System.Net.ValidationHelper
TYPE:  class
TOKEN: 0x2000171
FIELDS:
  public    static  System.String[]                 EmptyArray  // 0x0
  private   static readonly System.Char[]                   InvalidMethodChars  // 0x8
  private   static readonly System.Char[]                   InvalidParamChars  // 0x10
METHODS:
  System.String MakeStringNull(System.String stringValue)
  System.Boolean IsBlankString(System.String stringValue)
  System.Boolean ValidateTcpPort(System.Int32 port)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.ExceptionHelper
TYPE:  class
TOKEN: 0x2000172
FIELDS:
METHODS:
  System.NotImplementedException get_MethodNotImplementedException()
  System.NotImplementedException get_PropertyNotImplementedException()
  System.Net.WebException get_TimeoutException()
  System.NotSupportedException get_PropertyNotSupportedException()
  System.Net.WebException get_RequestAbortedException()
END_CLASS

CLASS: System.Net.WebRequestPrefixElement
TYPE:  class
TOKEN: 0x2000173
FIELDS:
  public            System.String                   Prefix  // 0x10
  private           System.Net.IWebRequestCreate    creator  // 0x18
  private           System.Type                     creatorType  // 0x20
METHODS:
  System.Net.IWebRequestCreate get_Creator()
  System.Void set_Creator(System.Net.IWebRequestCreate value)
  System.Void .ctor(System.String P, System.Net.IWebRequestCreate C)
END_CLASS

CLASS: System.Net.HttpContinueDelegate
TYPE:  class
TOKEN: 0x2000174
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Int32 StatusCode, System.Net.WebHeaderCollection httpHeaders)
END_CLASS

CLASS: System.Net.KnownHttpVerb
TYPE:  class
TOKEN: 0x2000175
FIELDS:
  private           System.String                   Name  // 0x10
  private           System.Boolean                  RequireContentBody  // 0x18
  private           System.Boolean                  ContentBodyNotAllowed  // 0x19
  private           System.Boolean                  ConnectRequest  // 0x1A
  private           System.Boolean                  ExpectNoContentResponse  // 0x1B
  private   static  System.Collections.Specialized.ListDictionaryNamedHeaders  // 0x0
  private   static  System.Net.KnownHttpVerb        Get  // 0x8
  private   static  System.Net.KnownHttpVerb        Connect  // 0x10
  private   static  System.Net.KnownHttpVerb        Head  // 0x18
  private   static  System.Net.KnownHttpVerb        Put  // 0x20
  private   static  System.Net.KnownHttpVerb        Post  // 0x28
  private   static  System.Net.KnownHttpVerb        MkCol  // 0x30
METHODS:
  System.Void .ctor(System.String name, System.Boolean requireContentBody, System.Boolean contentBodyNotAllowed, System.Boolean connectRequest, System.Boolean expectNoContentResponse)
  System.Void .cctor()
  System.Net.KnownHttpVerb Parse(System.String name)
END_CLASS

CLASS: System.Net.TriState
TYPE:  struct
TOKEN: 0x2000176
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.TriState             Unspecified  // 0x0
  public    static  System.Net.TriState             False  // 0x0
  public    static  System.Net.TriState             True  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkCredential
TYPE:  class
TOKEN: 0x2000177
FIELDS:
  private           System.String                   m_domain  // 0x10
  private           System.String                   m_userName  // 0x18
  private           System.Security.SecureString    m_password  // 0x20
METHODS:
  System.Void .ctor(System.String userName, System.String password)
  System.Void .ctor(System.String userName, System.String password, System.String domain)
  System.String get_UserName()
  System.Void set_UserName(System.String value)
  System.String get_Password()
  System.Void set_Password(System.String value)
  System.String get_Domain()
  System.Void set_Domain(System.String value)
  System.String InternalGetUserName()
  System.String InternalGetPassword()
  System.String InternalGetDomain()
  System.Net.NetworkCredential GetCredential(System.Uri uri, System.String authType)
END_CLASS

CLASS: System.Net.ProtocolViolationException
TYPE:  class
TOKEN: 0x2000178
EXTENDS: InvalidOperationException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
END_CLASS

CLASS: System.Net.SocketAddress
TYPE:  class
TOKEN: 0x2000179
FIELDS:
  private           System.Int32                    m_Size  // 0x10
  private           System.Byte[]                   m_Buffer  // 0x18
  private           System.Boolean                  m_changed  // 0x20
  private           System.Int32                    m_hash  // 0x24
METHODS:
  System.Net.Sockets.AddressFamily get_Family()
  System.Int32 get_Size()
  System.Byte get_Item(System.Int32 offset)
  System.Void .ctor(System.Net.Sockets.AddressFamily family, System.Int32 size)
  System.Void .ctor(System.Net.IPAddress ipAddress)
  System.Void .ctor(System.Net.IPAddress ipaddress, System.Int32 port)
  System.Net.IPAddress GetIPAddress()
  System.Net.IPEndPoint GetIPEndPoint()
  System.Boolean Equals(System.Object comparand)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: System.Net.TransportContext
TYPE:  class
TOKEN: 0x200017A
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.WebException
TYPE:  class
TOKEN: 0x200017B
EXTENDS: InvalidOperationException
FIELDS:
  private           System.Net.WebExceptionStatus   m_Status  // 0x90
  private           System.Net.WebResponse          m_Response  // 0x98
  private           System.Net.WebExceptionInternalStatusm_InternalStatus  // 0xA0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.String message, System.Net.WebExceptionStatus status)
  System.Void .ctor(System.String message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException)
  System.Void .ctor(System.String message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response)
  System.Void .ctor(System.String message, System.String data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response)
  System.Void .ctor(System.String message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus)
  System.Void .ctor(System.String message, System.String data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Net.WebExceptionStatus get_Status()
  System.Net.WebResponse get_Response()
END_CLASS

CLASS: System.Net.WebExceptionInternalStatus
TYPE:  struct
TOKEN: 0x200017C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebExceptionInternalStatusRequestFatal  // 0x0
  public    static  System.Net.WebExceptionInternalStatusServicePointFatal  // 0x0
  public    static  System.Net.WebExceptionInternalStatusRecoverable  // 0x0
  public    static  System.Net.WebExceptionInternalStatusIsolated  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebExceptionStatus
TYPE:  struct
TOKEN: 0x200017D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebExceptionStatus   Success  // 0x0
  public    static  System.Net.WebExceptionStatus   NameResolutionFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   ConnectFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   ReceiveFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   SendFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   PipelineFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   RequestCanceled  // 0x0
  public    static  System.Net.WebExceptionStatus   ProtocolError  // 0x0
  public    static  System.Net.WebExceptionStatus   ConnectionClosed  // 0x0
  public    static  System.Net.WebExceptionStatus   TrustFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   SecureChannelFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   ServerProtocolViolation  // 0x0
  public    static  System.Net.WebExceptionStatus   KeepAliveFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   Pending  // 0x0
  public    static  System.Net.WebExceptionStatus   Timeout  // 0x0
  public    static  System.Net.WebExceptionStatus   ProxyNameResolutionFailure  // 0x0
  public    static  System.Net.WebExceptionStatus   UnknownError  // 0x0
  public    static  System.Net.WebExceptionStatus   MessageLengthLimitExceeded  // 0x0
  public    static  System.Net.WebExceptionStatus   CacheEntryNotFound  // 0x0
  public    static  System.Net.WebExceptionStatus   RequestProhibitedByCachePolicy  // 0x0
  public    static  System.Net.WebExceptionStatus   RequestProhibitedByProxy  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebExceptionMapping
TYPE:  class
TOKEN: 0x200017E
FIELDS:
  private   static readonly System.String[]                 s_Mapping  // 0x0
METHODS:
  System.String GetWebStatusString(System.Net.WebExceptionStatus status)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.WebHeaderCollectionType
TYPE:  struct
TOKEN: 0x200017F
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  System.Net.WebHeaderCollectionTypeUnknown  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeWebRequest  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeWebResponse  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeHttpWebRequest  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeHttpWebResponse  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeHttpListenerRequest  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeHttpListenerResponse  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeFtpWebRequest  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeFtpWebResponse  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeFileWebRequest  // 0x0
  public    static  System.Net.WebHeaderCollectionTypeFileWebResponse  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebHeaderCollection
TYPE:  class
TOKEN: 0x2000180
EXTENDS: NameValueCollection
FIELDS:
  private   static  System.Int32                    ApproxAveHeaderLineSize  // 0x0
  private   static  System.Int32                    ApproxHighAvgNumHeaders  // 0x0
  private   static readonly System.Net.HeaderInfoTable      HInfo  // 0x0
  private           System.String[]                 m_CommonHeaders  // 0x68
  private           System.Int32                    m_NumCommonHeaders  // 0x70
  private   static readonly System.String[]                 s_CommonHeaderNames  // 0x8
  private   static readonly System.SByte[]                  s_CommonHeaderHints  // 0x10
  private   static  System.Int32                    c_AcceptRanges  // 0x0
  private   static  System.Int32                    c_ContentLength  // 0x0
  private   static  System.Int32                    c_CacheControl  // 0x0
  private   static  System.Int32                    c_ContentType  // 0x0
  private   static  System.Int32                    c_Date  // 0x0
  private   static  System.Int32                    c_Expires  // 0x0
  private   static  System.Int32                    c_ETag  // 0x0
  private   static  System.Int32                    c_LastModified  // 0x0
  private   static  System.Int32                    c_Location  // 0x0
  private   static  System.Int32                    c_ProxyAuthenticate  // 0x0
  private   static  System.Int32                    c_P3P  // 0x0
  private   static  System.Int32                    c_SetCookie2  // 0x0
  private   static  System.Int32                    c_SetCookie  // 0x0
  private   static  System.Int32                    c_Server  // 0x0
  private   static  System.Int32                    c_Via  // 0x0
  private   static  System.Int32                    c_WwwAuthenticate  // 0x0
  private   static  System.Int32                    c_XAspNetVersion  // 0x0
  private   static  System.Int32                    c_XPoweredBy  // 0x0
  private           System.Collections.Specialized.NameValueCollectionm_InnerCollection  // 0x78
  private           System.Net.WebHeaderCollectionTypem_Type  // 0x80
  private   static readonly System.Char[]                   HttpTrimCharacters  // 0x18
  private   static  System.Net.WebHeaderCollection.RfcChar[]RfcCharMap  // 0x20
METHODS:
  System.Void NormalizeCommonHeaders()
  System.Collections.Specialized.NameValueCollection get_InnerCollection()
  System.Boolean AllowMultiValues(System.String name)
  System.Boolean get_AllowHttpRequestHeader()
  System.Void Remove(System.Net.HttpRequestHeader header)
  System.Void AddInternal(System.String name, System.String value)
  System.Void ChangeInternal(System.String name, System.String value)
  System.Void RemoveInternal(System.String name)
  System.String CheckBadChars(System.String name, System.Boolean isHeaderValue)
  System.Boolean ContainsNonAsciiChars(System.String token)
  System.Void ThrowOnRestrictedHeader(System.String headerName)
  System.Void Add(System.String name, System.String value)
  System.Void Add(System.String header)
  System.Void Set(System.String name, System.String value)
  System.Void SetInternal(System.String name, System.String value)
  System.Void Remove(System.String name)
  System.String[] GetValues(System.String header)
  System.String ToString()
  System.String GetAsString(System.Collections.Specialized.NameValueCollection cc, System.Boolean winInetCompat, System.Boolean forTrace)
  System.Void .ctor()
  System.Void .ctor(System.Net.WebHeaderCollectionType type)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void OnDeserialization(System.Object sender)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.String Get(System.String name)
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 get_Count()
  System.String Get(System.Int32 index)
  System.String[] GetValues(System.Int32 index)
  System.String GetKey(System.Int32 index)
  System.String[] get_AllKeys()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.CaseInsensitiveAscii
TYPE:  class
TOKEN: 0x2000182
FIELDS:
  private   static readonly System.Net.CaseInsensitiveAscii StaticInstance  // 0x0
  private   static readonly System.Byte[]                   AsciiToLower  // 0x8
METHODS:
  System.Int32 GetHashCode(System.Object myObject)
  System.Int32 Compare(System.Object firstObject, System.Object secondObject)
  System.Int32 FastGetHashCode(System.String myString)
  System.Boolean Equals(System.Object firstObject, System.Object secondObject)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.WebRequest
TYPE:  class
TOKEN: 0x2000183
EXTENDS: MarshalByRefObject
FIELDS:
  private   static  System.Collections.ArrayList    s_PrefixList  // 0x0
  private   static  System.Object                   s_InternalSyncObject  // 0x8
  private   static  System.Net.TimerThread.Queue    s_DefaultTimerQueue  // 0x10
  private           System.Net.Security.AuthenticationLevelm_AuthenticationLevel  // 0x18
  private           System.Security.Principal.TokenImpersonationLevelm_ImpersonationLevel  // 0x1C
  private           System.Net.Cache.RequestCachePolicym_CachePolicy  // 0x20
  private           System.Net.Cache.RequestCacheProtocolm_CacheProtocol  // 0x28
  private           System.Net.Cache.RequestCacheBindingm_CacheBinding  // 0x30
  private   static  System.Net.WebRequest.DesignerWebRequestCreatewebRequestCreate  // 0x18
  private   static  System.Net.IWebProxy            s_DefaultWebProxy  // 0x20
  private   static  System.Boolean                  s_DefaultWebProxyInitialized  // 0x28
METHODS:
  System.Object get_InternalSyncObject()
  System.Net.WebRequest Create(System.Uri requestUri, System.Boolean useUriBase)
  System.Net.WebRequest Create(System.String requestUriString)
  System.Net.WebRequest Create(System.Uri requestUri)
  System.Collections.ArrayList get_PrefixList()
  System.Collections.ArrayList PopulatePrefixList()
  System.Void .ctor()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Net.Cache.RequestCachePolicy get_DefaultCachePolicy()
  System.Void set_CachePolicy(System.Net.Cache.RequestCachePolicy value)
  System.Void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy)
  System.String get_Method()
  System.Void set_Method(System.String value)
  System.Uri get_RequestUri()
  System.Void set_ConnectionGroupName(System.String value)
  System.Net.WebHeaderCollection get_Headers()
  System.Int64 get_ContentLength()
  System.Void set_ContentLength(System.Int64 value)
  System.Net.ICredentials get_Credentials()
  System.Void set_Credentials(System.Net.ICredentials value)
  System.Boolean get_UseDefaultCredentials()
  System.Net.IWebProxy get_Proxy()
  System.Void set_Proxy(System.Net.IWebProxy value)
  System.Void set_PreAuthenticate(System.Boolean value)
  System.Int32 get_Timeout()
  System.Void set_Timeout(System.Int32 value)
  System.Net.WebResponse GetResponse()
  System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state)
  System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult)
  System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state)
  System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync()
  System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync()
  System.Security.Principal.WindowsIdentity SafeCaptureIdenity()
  System.Void Abort()
  System.Net.Cache.RequestCacheProtocol get_CacheProtocol()
  System.Void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value)
  System.Net.IWebProxy get_InternalDefaultWebProxy()
  System.Void .cctor()
  System.Threading.Tasks.Task<System.IO.Stream> <GetRequestStreamAsync>b__78_0()
  System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0()
END_CLASS

CLASS: System.Net.WebResponse
TYPE:  class
TOKEN: 0x2000187
EXTENDS: MarshalByRefObject
FIELDS:
  private           System.Boolean                  m_IsFromCache  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void Close()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_IsFromCache()
  System.IO.Stream GetResponseStream()
  System.Uri get_ResponseUri()
  System.Net.WebHeaderCollection get_Headers()
END_CLASS

CLASS: System.Net.BufferOffsetSize
TYPE:  class
TOKEN: 0x2000188
FIELDS:
  private           System.Byte[]                   Buffer  // 0x10
  private           System.Int32                    Offset  // 0x18
  private           System.Int32                    Size  // 0x1C
METHODS:
  System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Boolean copyBuffer)
  System.Void .ctor(System.Byte[] buffer, System.Boolean copyBuffer)
END_CLASS

CLASS: System.Net.HeaderParser
TYPE:  class
TOKEN: 0x2000189
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String[] Invoke(System.String value)
END_CLASS

CLASS: System.Net.HeaderInfo
TYPE:  class
TOKEN: 0x200018A
FIELDS:
  private   readonly System.Boolean                  IsRequestRestricted  // 0x10
  private   readonly System.Boolean                  IsResponseRestricted  // 0x11
  private   readonly System.Net.HeaderParser         Parser  // 0x18
  private   readonly System.String                   HeaderName  // 0x20
  private   readonly System.Boolean                  AllowMultiValues  // 0x28
METHODS:
  System.Void .ctor(System.String name, System.Boolean requestRestricted, System.Boolean responseRestricted, System.Boolean multi, System.Net.HeaderParser p)
END_CLASS

CLASS: System.Net.HeaderInfoTable
TYPE:  class
TOKEN: 0x200018B
FIELDS:
  private   static  System.Collections.Hashtable    HeaderHashTable  // 0x0
  private   static  System.Net.HeaderInfo           UnknownHeaderInfo  // 0x8
  private   static  System.Net.HeaderParser         SingleParser  // 0x10
  private   static  System.Net.HeaderParser         MultiParser  // 0x18
METHODS:
  System.String[] ParseSingleValue(System.String value)
  System.String[] ParseMultiValue(System.String value)
  System.Void .cctor()
  System.Net.HeaderInfo get_Item(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.CloseExState
TYPE:  struct
TOKEN: 0x200018C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.CloseExState         Normal  // 0x0
  public    static  System.Net.CloseExState         Abort  // 0x0
  public    static  System.Net.CloseExState         Silent  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.ICloseEx
TYPE:  interface
TOKEN: 0x200018D
FIELDS:
METHODS:
  System.Void CloseEx(System.Net.CloseExState closeState)
END_CLASS

CLASS: System.Net.LazyAsyncResult
TYPE:  class
TOKEN: 0x200018E
FIELDS:
  private   static  System.Net.LazyAsyncResult.ThreadContextt_ThreadContext  // 0xFFFFFFFF
  private           System.Object                   m_AsyncObject  // 0x10
  private           System.Object                   m_AsyncState  // 0x18
  private           System.AsyncCallback            m_AsyncCallback  // 0x20
  private           System.Object                   m_Result  // 0x28
  private           System.Int32                    m_IntCompleted  // 0x30
  private           System.Boolean                  m_EndCalled  // 0x34
  private           System.Boolean                  m_UserEvent  // 0x35
  private           System.Object                   m_Event  // 0x38
METHODS:
  System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext()
  System.Void .ctor(System.Object myObject, System.Object myState, System.AsyncCallback myCallBack)
  System.Object get_AsyncObject()
  System.Object get_AsyncState()
  System.AsyncCallback get_AsyncCallback()
  System.Threading.WaitHandle get_AsyncWaitHandle()
  System.Boolean LazilyCreateEvent(System.Threading.ManualResetEvent& waitHandle)
  System.Boolean get_CompletedSynchronously()
  System.Boolean get_IsCompleted()
  System.Boolean get_InternalPeekCompleted()
  System.Boolean get_EndCalled()
  System.Void set_EndCalled(System.Boolean value)
  System.Void ProtectedInvokeCallback(System.Object result, System.IntPtr userToken)
  System.Void InvokeCallback(System.Object result)
  System.Void InvokeCallback()
  System.Void Complete(System.IntPtr userToken)
  System.Void WorkerThreadComplete(System.Object state)
  System.Void Cleanup()
  System.Object InternalWaitForCompletion()
  System.Object WaitForCompletion(System.Boolean snap)
END_CLASS

CLASS: System.Net.NetRes
TYPE:  class
TOKEN: 0x2000190
FIELDS:
METHODS:
  System.String GetWebStatusString(System.String Res, System.Net.WebExceptionStatus Status)
  System.String GetWebStatusString(System.Net.WebExceptionStatus Status)
  System.String GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, System.String statusDescription)
END_CLASS

CLASS: System.Net.TimerThread
TYPE:  class
TOKEN: 0x2000191
FIELDS:
  private   static  System.Collections.Generic.LinkedList<System.WeakReference>s_Queues  // 0x0
  private   static  System.Collections.Generic.LinkedList<System.WeakReference>s_NewQueues  // 0x8
  private   static  System.Int32                    s_ThreadState  // 0x10
  private   static  System.Threading.AutoResetEvent s_ThreadReadyEvent  // 0x18
  private   static  System.Threading.ManualResetEvents_ThreadShutdownEvent  // 0x20
  private   static  System.Threading.WaitHandle[]   s_ThreadEvents  // 0x28
  private   static  System.Int32                    s_CacheScanIteration  // 0x30
  private   static  System.Collections.Hashtable    s_QueuesCache  // 0x38
METHODS:
  System.Void .cctor()
  System.Net.TimerThread.Queue CreateQueue(System.Int32 durationMilliseconds)
  System.Net.TimerThread.Queue GetOrCreateQueue(System.Int32 durationMilliseconds)
  System.Void Prod()
  System.Void ThreadProc()
  System.Void StopTimerThread()
  System.Boolean IsTickBetween(System.Int32 start, System.Int32 end, System.Int32 comparand)
  System.Void OnDomainUnload(System.Object sender, System.EventArgs e)
END_CLASS

CLASS: System.Net.CookieVariant
TYPE:  struct
TOKEN: 0x200019A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.CookieVariant        Unknown  // 0x0
  public    static  System.Net.CookieVariant        Plain  // 0x0
  public    static  System.Net.CookieVariant        Rfc2109  // 0x0
  public    static  System.Net.CookieVariant        Rfc2965  // 0x0
  public    static  System.Net.CookieVariant        Default  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Cookie
TYPE:  class
TOKEN: 0x200019B
FIELDS:
  private   static readonly System.Char[]                   PortSplitDelimiters  // 0x0
  private   static readonly System.Char[]                   Reserved2Name  // 0x8
  private   static readonly System.Char[]                   Reserved2Value  // 0x10
  private   static  System.Net.Comparer             staticComparer  // 0x18
  private           System.String                   m_comment  // 0x10
  private           System.Uri                      m_commentUri  // 0x18
  private           System.Net.CookieVariant        m_cookieVariant  // 0x20
  private           System.Boolean                  m_discard  // 0x24
  private           System.String                   m_domain  // 0x28
  private           System.Boolean                  m_domain_implicit  // 0x30
  private           System.DateTime                 m_expires  // 0x38
  private           System.String                   m_name  // 0x40
  private           System.String                   m_path  // 0x48
  private           System.Boolean                  m_path_implicit  // 0x50
  private           System.String                   m_port  // 0x58
  private           System.Boolean                  m_port_implicit  // 0x60
  private           System.Int32[]                  m_port_list  // 0x68
  private           System.Boolean                  m_secure  // 0x70
  private           System.Boolean                  m_httpOnly  // 0x71
  private           System.DateTime                 m_timeStamp  // 0x78
  private           System.String                   m_value  // 0x80
  private           System.Int32                    m_version  // 0x88
  private           System.String                   m_domainKey  // 0x90
  private           System.Boolean                  IsQuotedVersion  // 0x98
  private           System.Boolean                  IsQuotedDomain  // 0x99
METHODS:
  System.Void .ctor()
  System.String get_Comment()
  System.Void set_Comment(System.String value)
  System.Void set_CommentUri(System.Uri value)
  System.Void set_HttpOnly(System.Boolean value)
  System.Void set_Discard(System.Boolean value)
  System.String get_Domain()
  System.Void set_Domain(System.String value)
  System.String get__Domain()
  System.Boolean get_Expired()
  System.Void set_Expires(System.DateTime value)
  System.String get_Name()
  System.Boolean InternalSetName(System.String value)
  System.String get_Path()
  System.Void set_Path(System.String value)
  System.String get__Path()
  System.Boolean get_Plain()
  System.Boolean IsDomainEqualToHost(System.String domain, System.String host)
  System.Boolean VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, System.Boolean isLocalDomain, System.String localDomain, System.Boolean set_default, System.Boolean isThrow)
  System.Boolean DomainCharsTest(System.String name)
  System.Void set_Port(System.String value)
  System.Int32[] get_PortList()
  System.String get__Port()
  System.Boolean get_Secure()
  System.Void set_Secure(System.Boolean value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Net.CookieVariant get_Variant()
  System.String get_DomainKey()
  System.Int32 get_Version()
  System.Void set_Version(System.Int32 value)
  System.String get__Version()
  System.Collections.IComparer GetComparer()
  System.Boolean Equals(System.Object comparand)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.CookieToken
TYPE:  struct
TOKEN: 0x200019C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.CookieToken          Nothing  // 0x0
  public    static  System.Net.CookieToken          NameValuePair  // 0x0
  public    static  System.Net.CookieToken          Attribute  // 0x0
  public    static  System.Net.CookieToken          EndToken  // 0x0
  public    static  System.Net.CookieToken          EndCookie  // 0x0
  public    static  System.Net.CookieToken          End  // 0x0
  public    static  System.Net.CookieToken          Equals  // 0x0
  public    static  System.Net.CookieToken          Comment  // 0x0
  public    static  System.Net.CookieToken          CommentUrl  // 0x0
  public    static  System.Net.CookieToken          CookieName  // 0x0
  public    static  System.Net.CookieToken          Discard  // 0x0
  public    static  System.Net.CookieToken          Domain  // 0x0
  public    static  System.Net.CookieToken          Expires  // 0x0
  public    static  System.Net.CookieToken          MaxAge  // 0x0
  public    static  System.Net.CookieToken          Path  // 0x0
  public    static  System.Net.CookieToken          Port  // 0x0
  public    static  System.Net.CookieToken          Secure  // 0x0
  public    static  System.Net.CookieToken          HttpOnly  // 0x0
  public    static  System.Net.CookieToken          Unknown  // 0x0
  public    static  System.Net.CookieToken          Version  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.CookieTokenizer
TYPE:  class
TOKEN: 0x200019D
FIELDS:
  private           System.Boolean                  m_eofCookie  // 0x10
  private           System.Int32                    m_index  // 0x14
  private           System.Int32                    m_length  // 0x18
  private           System.String                   m_name  // 0x20
  private           System.Boolean                  m_quoted  // 0x28
  private           System.Int32                    m_start  // 0x2C
  private           System.Net.CookieToken          m_token  // 0x30
  private           System.Int32                    m_tokenLength  // 0x34
  private           System.String                   m_tokenStream  // 0x38
  private           System.String                   m_value  // 0x40
  private   static  System.Net.CookieTokenizer.RecognizedAttribute[]RecognizedAttributes  // 0x0
  private   static  System.Net.CookieTokenizer.RecognizedAttribute[]RecognizedServerAttributes  // 0x8
METHODS:
  System.Void .ctor(System.String tokenStream)
  System.Boolean get_EndOfCookie()
  System.Void set_EndOfCookie(System.Boolean value)
  System.Boolean get_Eof()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_Quoted()
  System.Void set_Quoted(System.Boolean value)
  System.Net.CookieToken get_Token()
  System.Void set_Token(System.Net.CookieToken value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.String Extract()
  System.Net.CookieToken FindNext(System.Boolean ignoreComma, System.Boolean ignoreEquals)
  System.Net.CookieToken Next(System.Boolean first, System.Boolean parseResponseCookies)
  System.Void Reset()
  System.Net.CookieToken TokenFromName(System.Boolean parseResponseCookies)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.CookieParser
TYPE:  class
TOKEN: 0x200019F
FIELDS:
  private           System.Net.CookieTokenizer      m_tokenizer  // 0x10
METHODS:
  System.Void .ctor(System.String cookieString)
  System.Net.Cookie Get()
  System.String CheckQuoted(System.String value)
END_CLASS

CLASS: System.Net.Comparer
TYPE:  class
TOKEN: 0x20001A0
FIELDS:
METHODS:
  System.Int32 System.Collections.IComparer.Compare(System.Object ol, System.Object or)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.CookieCollection
TYPE:  class
TOKEN: 0x20001A1
FIELDS:
  private           System.Int32                    m_version  // 0x10
  private           System.Collections.ArrayList    m_list  // 0x18
  private           System.DateTime                 m_TimeStamp  // 0x20
  private           System.Boolean                  m_has_other_versions  // 0x28
  private           System.Boolean                  m_IsReadOnly  // 0x29
METHODS:
  System.Void .ctor()
  System.Net.Cookie get_Item(System.Int32 index)
  System.Void Add(System.Net.Cookie cookie)
  System.Void Add(System.Net.CookieCollection cookies)
  System.Int32 get_Count()
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how)
  System.Boolean get_IsOtherVersionSeen()
  System.Int32 InternalAdd(System.Net.Cookie cookie, System.Boolean isStrict)
  System.Int32 IndexOf(System.Net.Cookie cookie)
  System.Void RemoveAt(System.Int32 idx)
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: System.Net.HeaderVariantInfo
TYPE:  struct
TOKEN: 0x20001A4
FIELDS:
  private           System.String                   m_name  // 0x10
  private           System.Net.CookieVariant        m_variant  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.Net.CookieVariant variant)
  System.String get_Name()
  System.Net.CookieVariant get_Variant()
END_CLASS

CLASS: System.Net.CookieContainer
TYPE:  class
TOKEN: 0x20001A5
FIELDS:
  public    static  System.Int32                    DefaultCookieLimit  // 0x0
  public    static  System.Int32                    DefaultPerDomainCookieLimit  // 0x0
  public    static  System.Int32                    DefaultCookieLengthLimit  // 0x0
  private   static readonly System.Net.HeaderVariantInfo[]  HeaderInfo  // 0x0
  private           System.Collections.Hashtable    m_domainTable  // 0x10
  private           System.Int32                    m_maxCookieSize  // 0x18
  private           System.Int32                    m_maxCookies  // 0x1C
  private           System.Int32                    m_maxCookiesPerDomain  // 0x20
  private           System.Int32                    m_count  // 0x24
  private           System.String                   m_fqdnMyDomain  // 0x28
METHODS:
  System.Void .ctor()
  System.Void AddRemoveDomain(System.String key, System.Net.PathList value)
  System.Void Add(System.Net.Cookie cookie, System.Boolean throwOnError)
  System.Boolean AgeCookies(System.String domain)
  System.Int32 ExpireCollection(System.Net.CookieCollection cc)
  System.Boolean IsLocalDomain(System.String host)
  System.Net.CookieCollection CookieCutter(System.Uri uri, System.String headerName, System.String setCookieHeader, System.Boolean isThrow)
  System.Net.CookieCollection InternalGetCookies(System.Uri uri)
  System.Void BuildCookieCollectionFromDomainMatches(System.Uri uri, System.Boolean isSecure, System.Int32 port, System.Net.CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, System.Boolean matchOnlyPlainCookie)
  System.Void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, System.Int32 port, System.Boolean isSecure, System.Boolean isPlainOnly)
  System.String GetCookieHeader(System.Uri uri)
  System.String GetCookieHeader(System.Uri uri, System.String& optCookie2)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.PathList
TYPE:  class
TOKEN: 0x20001A6
FIELDS:
  private           System.Collections.SortedList   m_list  // 0x10
METHODS:
  System.Void .ctor()
  System.Int32 get_Count()
  System.Int32 GetCookiesCount()
  System.Collections.ICollection get_Values()
  System.Object get_Item(System.String s)
  System.Void set_Item(System.String s, System.Object value)
  System.Collections.IEnumerator GetEnumerator()
  System.Object get_SyncRoot()
END_CLASS

CLASS: System.Net.CookieException
TYPE:  class
TOKEN: 0x20001A8
EXTENDS: FormatException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception inner)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
END_CLASS

CLASS: System.Net.FileWebRequest
TYPE:  class
TOKEN: 0x20001A9
EXTENDS: WebRequest
FIELDS:
  private   static  System.Threading.WaitCallback   s_GetRequestStreamCallback  // 0x0
  private   static  System.Threading.WaitCallback   s_GetResponseCallback  // 0x8
  private           System.String                   m_connectionGroupName  // 0x38
  private           System.Int64                    m_contentLength  // 0x40
  private           System.Net.ICredentials         m_credentials  // 0x48
  private           System.IO.FileAccess            m_fileAccess  // 0x50
  private           System.Net.WebHeaderCollection  m_headers  // 0x58
  private           System.String                   m_method  // 0x60
  private           System.Boolean                  m_preauthenticate  // 0x68
  private           System.Net.IWebProxy            m_proxy  // 0x70
  private           System.Threading.ManualResetEventm_readerEvent  // 0x78
  private           System.Boolean                  m_readPending  // 0x80
  private           System.Net.WebResponse          m_response  // 0x88
  private           System.IO.Stream                m_stream  // 0x90
  private           System.Boolean                  m_syncHint  // 0x98
  private           System.Int32                    m_timeout  // 0x9C
  private           System.Uri                      m_uri  // 0xA0
  private           System.Boolean                  m_writePending  // 0xA8
  private           System.Boolean                  m_writing  // 0xA9
  private           System.Net.LazyAsyncResult      m_WriteAResult  // 0xB0
  private           System.Net.LazyAsyncResult      m_ReadAResult  // 0xB8
  private           System.Int32                    m_Aborted  // 0xC0
METHODS:
  System.Void .ctor(System.Uri uri)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Boolean get_Aborted()
  System.Void set_ConnectionGroupName(System.String value)
  System.Int64 get_ContentLength()
  System.Void set_ContentLength(System.Int64 value)
  System.Net.ICredentials get_Credentials()
  System.Void set_Credentials(System.Net.ICredentials value)
  System.Net.WebHeaderCollection get_Headers()
  System.String get_Method()
  System.Void set_Method(System.String value)
  System.Void set_PreAuthenticate(System.Boolean value)
  System.Net.IWebProxy get_Proxy()
  System.Void set_Proxy(System.Net.IWebProxy value)
  System.Int32 get_Timeout()
  System.Void set_Timeout(System.Int32 value)
  System.Uri get_RequestUri()
  System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state)
  System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state)
  System.Boolean CanGetRequestStream()
  System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult)
  System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult)
  System.Net.WebResponse GetResponse()
  System.Void GetRequestStreamCallback(System.Object state)
  System.Void GetResponseCallback(System.Object state)
  System.Void UnblockReader()
  System.Boolean get_UseDefaultCredentials()
  System.Void Abort()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.FileWebRequestCreator
TYPE:  class
TOKEN: 0x20001AA
FIELDS:
METHODS:
  System.Void .ctor()
  System.Net.WebRequest Create(System.Uri uri)
END_CLASS

CLASS: System.Net.FileWebStream
TYPE:  class
TOKEN: 0x20001AB
EXTENDS: FileStream
FIELDS:
  private           System.Net.FileWebRequest       m_request  // 0x70
METHODS:
  System.Void .ctor(System.Net.FileWebRequest request, System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing)
  System.Void .ctor(System.Net.FileWebRequest request, System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, System.Int32 length, System.Boolean async)
  System.Void Dispose(System.Boolean disposing)
  System.Void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult ar)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Void EndWrite(System.IAsyncResult ar)
  System.Void CheckError()
END_CLASS

CLASS: System.Net.FileWebResponse
TYPE:  class
TOKEN: 0x20001AC
EXTENDS: WebResponse
FIELDS:
  private           System.Boolean                  m_closed  // 0x20
  private           System.Int64                    m_contentLength  // 0x28
  private           System.IO.FileAccess            m_fileAccess  // 0x30
  private           System.Net.WebHeaderCollection  m_headers  // 0x38
  private           System.IO.Stream                m_stream  // 0x40
  private           System.Uri                      m_uri  // 0x48
METHODS:
  System.Void .ctor(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, System.Boolean asyncHint)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Net.WebHeaderCollection get_Headers()
  System.Uri get_ResponseUri()
  System.Void CheckDisposed()
  System.Void Close()
  System.Void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState)
  System.IO.Stream GetResponseStream()
END_CLASS

CLASS: System.Net.IWebProxy
TYPE:  interface
TOKEN: 0x20001AD
FIELDS:
METHODS:
  System.Uri GetProxy(System.Uri destination)
  System.Boolean IsBypassed(System.Uri host)
  System.Net.ICredentials get_Credentials()
END_CLASS

CLASS: System.Net.WebProxy
TYPE:  class
TOKEN: 0x20001AE
FIELDS:
  private           System.Boolean                  _UseRegistry  // 0x10
  private           System.Boolean                  _BypassOnLocal  // 0x11
  private           System.Boolean                  m_EnableAutoproxy  // 0x12
  private           System.Uri                      _ProxyAddress  // 0x18
  private           System.Collections.ArrayList    _BypassList  // 0x20
  private           System.Net.ICredentials         _Credentials  // 0x28
  private           System.Text.RegularExpressions.Regex[]_RegExBypassList  // 0x30
  private           System.Collections.Hashtable    _ProxyHostAddresses  // 0x38
  private           System.Net.AutoWebProxyScriptEnginem_ScriptEngine  // 0x40
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Uri Address, System.Boolean BypassOnLocal, System.String[] BypassList, System.Net.ICredentials Credentials)
  System.Net.ICredentials get_Credentials()
  System.Boolean get_UseDefaultCredentials()
  System.Void set_UseDefaultCredentials(System.Boolean value)
  System.Uri GetProxy(System.Uri destination)
  System.Void UpdateRegExList(System.Boolean canThrow)
  System.Boolean IsMatchInBypassList(System.Uri input)
  System.Boolean IsLocal(System.Uri host)
  System.Boolean IsLocalInProxyHash(System.Uri host)
  System.Boolean IsBypassed(System.Uri host)
  System.Boolean IsBypassedManual(System.Uri host)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Net.AutoWebProxyScriptEngine get_ScriptEngine()
  System.Net.IWebProxy CreateDefaultProxy()
  System.Void .ctor(System.Boolean enableAutoproxy)
  System.Void UnsafeUpdateFromRegistry()
  System.Boolean GetProxyAuto(System.Uri destination, System.Uri& proxyUri)
  System.Boolean IsBypassedAuto(System.Uri destination, System.Boolean& isBypassed)
  System.Boolean AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, System.Boolean checkFirstOnly)
  System.Uri ProxyUri(System.String proxyName)
END_CLASS

CLASS: System.Net.AutoWebProxyScriptEngine
TYPE:  class
TOKEN: 0x20001AF
FIELDS:
METHODS:
  System.Boolean GetProxies(System.Uri destination, System.Collections.Generic.IList<System.String>& proxyList)
  System.Boolean GetProxies(System.Uri destination, System.Collections.Generic.IList<System.String>& proxyList, System.Int32& syncStatus)
END_CLASS

CLASS: System.Net.UnsafeNclNativeMethods
TYPE:  class
TOKEN: 0x20001B0
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Logging
TYPE:  class
TOKEN: 0x20001B4
FIELDS:
METHODS:
  System.Boolean get_On()
END_CLASS

CLASS: System.Net.ServerCertValidationCallback
TYPE:  class
TOKEN: 0x20001B5
FIELDS:
  private   readonly System.Net.Security.RemoteCertificateValidationCallbackm_ValidationCallback  // 0x10
  private   readonly System.Threading.ExecutionContextm_Context  // 0x18
METHODS:
  System.Void .ctor(System.Net.Security.RemoteCertificateValidationCallback validationCallback)
  System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback()
  System.Void Callback(System.Object state)
  System.Boolean Invoke(System.Object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
END_CLASS

CLASS: System.Net.AuthenticationManager
TYPE:  class
TOKEN: 0x20001B7
FIELDS:
  private   static  System.Collections.ArrayList    modules  // 0x0
  private   static  System.Object                   locker  // 0x8
  private   static  System.Net.ICredentialPolicy    credential_policy  // 0x10
METHODS:
  System.Void EnsureModules()
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest request, System.Net.ICredentials credentials)
  System.Net.Authorization DoAuthenticate(System.String challenge, System.Net.WebRequest request, System.Net.ICredentials credentials)
  System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.BasicClient
TYPE:  class
TOKEN: 0x20001B8
FIELDS:
METHODS:
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.Byte[] GetBytes(System.String str)
  System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.String get_AuthenticationType()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.BindIPEndPoint
TYPE:  class
TOKEN: 0x20001B9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, System.Int32 retryCount)
END_CLASS

CLASS: System.Net.BufferedReadStream
TYPE:  class
TOKEN: 0x20001BA
EXTENDS: WebReadStream
FIELDS:
  private   readonly System.Net.BufferOffsetSize     readBuffer  // 0x40
METHODS:
  System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer)
  System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Boolean TryReadFromBuffer(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Int32& result)
END_CLASS

CLASS: System.Net.ContentDecodeStream
TYPE:  class
TOKEN: 0x20001BC
EXTENDS: WebReadStream
FIELDS:
  private   readonly System.IO.Stream                <OriginalInnerStream>k__BackingField  // 0x40
METHODS:
  System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode)
  System.IO.Stream get_OriginalInnerStream()
  System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream)
  System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.DecompressionMethods
TYPE:  struct
TOKEN: 0x20001BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.DecompressionMethods None  // 0x0
  public    static  System.Net.DecompressionMethods GZip  // 0x0
  public    static  System.Net.DecompressionMethods Deflate  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.DefaultCertificatePolicy
TYPE:  class
TOKEN: 0x20001BF
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.DigestHeaderParser
TYPE:  class
TOKEN: 0x20001C0
FIELDS:
  private           System.String                   header  // 0x10
  private           System.Int32                    length  // 0x18
  private           System.Int32                    pos  // 0x1C
  private   static  System.String[]                 keywords  // 0x0
  private           System.String[]                 values  // 0x20
METHODS:
  System.Void .ctor(System.String header)
  System.String get_Realm()
  System.String get_Opaque()
  System.String get_Nonce()
  System.String get_Algorithm()
  System.String get_QOP()
  System.Boolean Parse()
  System.Void SkipWhitespace()
  System.String GetKey()
  System.Boolean GetKeywordAndValue(System.String& key, System.String& value)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.DigestSession
TYPE:  class
TOKEN: 0x20001C1
FIELDS:
  private   static  System.Security.Cryptography.RandomNumberGeneratorrng  // 0x0
  private           System.DateTime                 lastUse  // 0x10
  private           System.Int32                    _nc  // 0x18
  private           System.Security.Cryptography.HashAlgorithmhash  // 0x20
  private           System.Net.DigestHeaderParser   parser  // 0x28
  private           System.String                   _cnonce  // 0x30
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.String get_Algorithm()
  System.String get_Realm()
  System.String get_Nonce()
  System.String get_Opaque()
  System.String get_QOP()
  System.String get_CNonce()
  System.Boolean Parse(System.String challenge)
  System.String HashToHexString(System.String toBeHashed)
  System.String HA1(System.String username, System.String password)
  System.String HA2(System.Net.HttpWebRequest webRequest)
  System.String Response(System.String username, System.String password, System.Net.HttpWebRequest webRequest)
  System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.DateTime get_LastUse()
END_CLASS

CLASS: System.Net.DigestClient
TYPE:  class
TOKEN: 0x20001C2
FIELDS:
  private   static readonly System.Collections.Hashtable    cache  // 0x0
METHODS:
  System.Collections.Hashtable get_Cache()
  System.Void CheckExpired(System.Int32 count)
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.String get_AuthenticationType()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Dns
TYPE:  class
TOKEN: 0x20001C3
FIELDS:
METHODS:
  System.IAsyncResult BeginGetHostAddresses(System.String hostNameOrAddress, System.AsyncCallback requestCallback, System.Object state)
  System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult)
  System.Boolean GetHostByName_icall(System.String host, System.String& h_name, System.String[]& h_aliases, System.String[]& h_addr_list, System.Int32 hint)
  System.Boolean GetHostByAddr_icall(System.String addr, System.String& h_name, System.String[]& h_aliases, System.String[]& h_addr_list, System.Int32 hint)
  System.Boolean GetHostName_icall(System.String& h_name)
  System.Void Error_11001(System.String hostName)
  System.Net.IPHostEntry hostent_to_IPHostEntry(System.String originalHostName, System.String h_name, System.String[] h_aliases, System.String[] h_addrlist)
  System.Net.IPHostEntry GetHostByAddressFromString(System.String address, System.Boolean parse)
  System.Net.IPHostEntry GetHostEntry(System.String hostNameOrAddress)
  System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address)
  System.Net.IPAddress[] GetHostAddresses(System.String hostNameOrAddress)
  System.Net.IPHostEntry GetHostByName(System.String hostName)
  System.String GetHostName()
  System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(System.String hostNameOrAddress)
END_CLASS

CLASS: System.Net.FixedSizeReadStream
TYPE:  class
TOKEN: 0x20001C5
EXTENDS: WebReadStream
FIELDS:
  private   readonly System.Int64                    <ContentLength>k__BackingField  // 0x40
  private           System.Int64                    position  // 0x48
METHODS:
  System.Int64 get_ContentLength()
  System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Int64 contentLength)
  System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.HttpRequestCreator
TYPE:  class
TOKEN: 0x20001C7
FIELDS:
METHODS:
  System.Void .ctor()
  System.Net.WebRequest Create(System.Uri uri)
END_CLASS

CLASS: System.Net.HttpWebRequest
TYPE:  class
TOKEN: 0x20001C8
EXTENDS: WebRequest
FIELDS:
  private           System.Uri                      requestUri  // 0x38
  private           System.Uri                      actualUri  // 0x40
  private           System.Boolean                  hostChanged  // 0x48
  private           System.Boolean                  allowAutoRedirect  // 0x49
  private           System.Boolean                  allowBuffering  // 0x4A
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollectioncertificates  // 0x50
  private           System.String                   connectionGroup  // 0x58
  private           System.Boolean                  haveContentLength  // 0x60
  private           System.Int64                    contentLength  // 0x68
  private           System.Net.HttpContinueDelegate continueDelegate  // 0x70
  private           System.Net.CookieContainer      cookieContainer  // 0x78
  private           System.Net.ICredentials         credentials  // 0x80
  private           System.Boolean                  haveResponse  // 0x88
  private           System.Boolean                  requestSent  // 0x89
  private           System.Net.WebHeaderCollection  webHeaders  // 0x90
  private           System.Boolean                  keepAlive  // 0x98
  private           System.Int32                    maxAutoRedirect  // 0x9C
  private           System.String                   mediaType  // 0xA0
  private           System.String                   method  // 0xA8
  private           System.String                   initialMethod  // 0xB0
  private           System.Boolean                  pipelined  // 0xB8
  private           System.Boolean                  preAuthenticate  // 0xB9
  private           System.Boolean                  usedPreAuth  // 0xBA
  private           System.Version                  version  // 0xC0
  private           System.Boolean                  force_version  // 0xC8
  private           System.Version                  actualVersion  // 0xD0
  private           System.Net.IWebProxy            proxy  // 0xD8
  private           System.Boolean                  sendChunked  // 0xE0
  private           System.Net.ServicePoint         servicePoint  // 0xE8
  private           System.Int32                    timeout  // 0xF0
  private           System.Int32                    continueTimeout  // 0xF4
  private           System.Net.WebRequestStream     writeStream  // 0xF8
  private           System.Net.HttpWebResponse      webResponse  // 0x100
  private           System.Net.WebCompletionSource  responseTask  // 0x108
  private           System.Net.WebOperation         currentOperation  // 0x110
  private           System.Int32                    aborted  // 0x118
  private           System.Boolean                  gotRequestStream  // 0x11C
  private           System.Int32                    redirects  // 0x120
  private           System.Boolean                  expectContinue  // 0x124
  private           System.Boolean                  getResponseCalled  // 0x125
  private           System.Object                   locker  // 0x128
  private           System.Boolean                  finished_reading  // 0x130
  private           System.Net.DecompressionMethods auto_decomp  // 0x134
  private   static  System.Int32                    defaultMaxResponseHeadersLength  // 0x0
  private   static  System.Int32                    defaultMaximumErrorResponseLength  // 0x4
  private   static  System.Net.Cache.RequestCachePolicydefaultCachePolicy  // 0x8
  private           System.Int32                    readWriteTimeout  // 0x138
  private           Mono.Net.Security.MobileTlsProvidertlsProvider  // 0x140
  private           Mono.Security.Interface.MonoTlsSettingstlsSettings  // 0x148
  private           System.Net.ServerCertValidationCallbackcertValidationCallback  // 0x150
  private           System.Boolean                  hostHasPort  // 0x158
  private           System.Uri                      hostUri  // 0x160
  private           System.Net.HttpWebRequest.AuthorizationStateauth_state  // 0x168
  private           System.Net.HttpWebRequest.AuthorizationStateproxy_auth_state  // 0x178
  private           System.Func<System.IO.Stream,System.Threading.Tasks.Task>ResendContentFactory  // 0x188
  private           System.Boolean                  <ThrowOnError>k__BackingField  // 0x190
  private           System.Boolean                  unsafe_auth_blah  // 0x191
METHODS:
  System.Void .cctor()
  System.Void .ctor(System.Uri uri)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void ResetAuthorization()
  System.Uri get_Address()
  System.Void set_AllowAutoRedirect(System.Boolean value)
  System.Boolean get_AllowWriteStreamBuffering()
  System.Void set_AllowWriteStreamBuffering(System.Boolean value)
  System.Net.DecompressionMethods get_AutomaticDecompression()
  System.Void set_AutomaticDecompression(System.Net.DecompressionMethods value)
  System.Boolean get_InternalAllowBuffering()
  System.Boolean get_MethodWithBuffer()
  Mono.Net.Security.MobileTlsProvider get_TlsProvider()
  Mono.Security.Interface.MonoTlsSettings get_TlsSettings()
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Void set_ConnectionGroupName(System.String value)
  System.Int64 get_ContentLength()
  System.Void set_ContentLength(System.Int64 value)
  System.Void set_InternalContentLength(System.Int64 value)
  System.Boolean get_ThrowOnError()
  System.Void set_ThrowOnError(System.Boolean value)
  System.Void set_CookieContainer(System.Net.CookieContainer value)
  System.Net.ICredentials get_Credentials()
  System.Void set_Credentials(System.Net.ICredentials value)
  System.Int32 get_DefaultMaximumErrorResponseLength()
  System.Net.WebHeaderCollection get_Headers()
  System.String get_Host()
  System.Void set_Host(System.String value)
  System.Boolean TryGetHostUri(System.String hostName, System.Uri& hostUri)
  System.Boolean get_KeepAlive()
  System.Void set_KeepAlive(System.Boolean value)
  System.Void set_MaximumAutomaticRedirections(System.Int32 value)
  System.Int32 get_DefaultMaximumResponseHeadersLength()
  System.Int32 get_ReadWriteTimeout()
  System.String get_Method()
  System.Void set_Method(System.String value)
  System.Void set_PreAuthenticate(System.Boolean value)
  System.Version get_ProtocolVersion()
  System.Void set_ProtocolVersion(System.Version value)
  System.Net.IWebProxy get_Proxy()
  System.Void set_Proxy(System.Net.IWebProxy value)
  System.Uri get_RequestUri()
  System.Boolean get_SendChunked()
  System.Void set_SendChunked(System.Boolean value)
  System.Net.ServicePoint get_ServicePoint()
  System.Net.ServicePoint get_ServicePointNoLock()
  System.Int32 get_Timeout()
  System.Void set_Timeout(System.Int32 value)
  System.String get_TransferEncoding()
  System.Boolean get_UseDefaultCredentials()
  System.Boolean get_UnsafeAuthenticatedConnectionSharing()
  System.Boolean get_ExpectContinue()
  System.Void set_ExpectContinue(System.Boolean value)
  System.Uri get_AuthUri()
  System.Boolean get_ProxyQuery()
  System.Net.ServerCertValidationCallback get_ServerCertValidationCallback()
  System.Net.ServicePoint GetServicePoint()
  System.Net.WebOperation SendRequest(System.Boolean redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.IO.Stream> MyGetRequestStreamAsync(System.Threading.CancellationToken cancellationToken)
  System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, System.Object state)
  System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync()
  System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, System.Int32 timeout, System.Action abort, System.Func<System.Boolean> aborted, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, System.Int32 timeout, System.Action abort, System.Func<System.Boolean> aborted, System.Threading.CancellationTokenSource cts)
  System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func)
  System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken)
  System.Exception FlattenException(System.Exception e)
  System.Net.WebException GetWebException(System.Exception e)
  System.Net.WebException GetWebException(System.Exception e, System.Boolean aborted)
  System.Net.WebException CreateRequestAbortedException()
  System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, System.Object state)
  System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult)
  System.Net.WebResponse GetResponse()
  System.Void set_FinishedReading(System.Boolean value)
  System.Boolean get_Aborted()
  System.Void Abort()
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void CheckRequestStarted()
  System.Void DoContinueDelegate(System.Int32 statusCode, System.Net.WebHeaderCollection headers)
  System.Void RewriteRedirectToGet()
  System.Boolean Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response)
  System.String GetHeaders()
  System.Void DoPreAuthenticate()
  System.Byte[] GetRequestHeaders()
  System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken)
  System.Boolean CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code)
  System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, System.Boolean redirect)
  System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response)
  System.Boolean <RunWithTimeout>b__242_0()
  System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.HttpWebResponse
TYPE:  class
TOKEN: 0x20001D0
EXTENDS: WebResponse
FIELDS:
  private           System.Uri                      uri  // 0x20
  private           System.Net.WebHeaderCollection  webHeaders  // 0x28
  private           System.Net.CookieCollection     cookieCollection  // 0x30
  private           System.String                   method  // 0x38
  private           System.Version                  version  // 0x40
  private           System.Net.HttpStatusCode       statusCode  // 0x48
  private           System.String                   statusDescription  // 0x50
  private           System.Int64                    contentLength  // 0x58
  private           System.String                   contentType  // 0x60
  private           System.Net.CookieContainer      cookie_container  // 0x68
  private           System.Boolean                  disposed  // 0x70
  private           System.IO.Stream                stream  // 0x78
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Uri uri, System.String method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers)
  System.Void .ctor(System.Uri uri, System.String method, System.Net.WebResponseStream stream, System.Net.CookieContainer container)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Net.WebHeaderCollection get_Headers()
  System.Uri get_ResponseUri()
  System.Net.HttpStatusCode get_StatusCode()
  System.String get_StatusDescription()
  System.IO.Stream GetResponseStream()
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void Close()
  System.Void System.IDisposable.Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void CheckDisposed()
  System.Void FillCookies()
END_CLASS

CLASS: System.Net.ICredentialPolicy
TYPE:  interface
TOKEN: 0x20001D1
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.MonoChunkParser
TYPE:  class
TOKEN: 0x20001D2
FIELDS:
  private           System.Net.WebHeaderCollection  headers  // 0x10
  private           System.Int32                    chunkSize  // 0x18
  private           System.Int32                    chunkRead  // 0x1C
  private           System.Int32                    totalWritten  // 0x20
  private           System.Net.MonoChunkParser.Statestate  // 0x24
  private           System.Text.StringBuilder       saved  // 0x28
  private           System.Boolean                  sawCR  // 0x30
  private           System.Boolean                  gotit  // 0x31
  private           System.Int32                    trailerState  // 0x34
  private           System.Collections.ArrayList    chunks  // 0x38
METHODS:
  System.Void .ctor(System.Net.WebHeaderCollection headers)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Int32 ReadFromChunks(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void InternalWrite(System.Byte[] buffer, System.Int32& offset, System.Int32 size)
  System.Boolean get_WantMore()
  System.Boolean get_DataAvailable()
  System.Int32 get_ChunkLeft()
  System.Net.MonoChunkParser.State ReadBody(System.Byte[] buffer, System.Int32& offset, System.Int32 size)
  System.Net.MonoChunkParser.State GetChunkSize(System.Byte[] buffer, System.Int32& offset, System.Int32 size)
  System.String RemoveChunkExtension(System.String input)
  System.Net.MonoChunkParser.State ReadCRLF(System.Byte[] buffer, System.Int32& offset, System.Int32 size)
  System.Net.MonoChunkParser.State ReadTrailer(System.Byte[] buffer, System.Int32& offset, System.Int32 size)
  System.Void ThrowProtocolViolation(System.String message)
END_CLASS

CLASS: System.Net.MonoChunkStream
TYPE:  class
TOKEN: 0x20001D5
EXTENDS: WebReadStream
FIELDS:
  private   readonly System.Net.WebHeaderCollection  <Headers>k__BackingField  // 0x40
  private   readonly System.Net.MonoChunkParser      <Decoder>k__BackingField  // 0x48
METHODS:
  System.Net.MonoChunkParser get_Decoder()
  System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers)
  System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken)
  System.Void ThrowExpectingChunkTrailer()
  System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.NtlmClient
TYPE:  class
TOKEN: 0x20001D8
FIELDS:
  private           System.Net.IAuthenticationModuleauthObject  // 0x10
METHODS:
  System.Void .ctor()
  System.Net.Authorization Authenticate(System.String challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials)
  System.String get_AuthenticationType()
END_CLASS

CLASS: System.Net.ServicePoint
TYPE:  class
TOKEN: 0x20001D9
FIELDS:
  private   readonly System.Uri                      uri  // 0x10
  private           System.DateTime                 lastDnsResolve  // 0x18
  private           System.Version                  protocolVersion  // 0x20
  private           System.Net.IPHostEntry          host  // 0x28
  private           System.Boolean                  usesProxy  // 0x30
  private           System.Boolean                  sendContinue  // 0x31
  private           System.Boolean                  useConnect  // 0x32
  private           System.Object                   hostE  // 0x38
  private           System.Boolean                  useNagle  // 0x40
  private           System.Net.BindIPEndPoint       endPointCallback  // 0x48
  private           System.Boolean                  tcp_keepalive  // 0x50
  private           System.Int32                    tcp_keepalive_time  // 0x54
  private           System.Int32                    tcp_keepalive_interval  // 0x58
  private           System.Boolean                  disposed  // 0x5C
  private           System.Int32                    connectionLeaseTimeout  // 0x60
  private           System.Int32                    receiveBufferSize  // 0x64
  private   readonly System.Net.ServicePointManager.SPKey<Key>k__BackingField  // 0x68
  private           System.Net.ServicePointScheduler<Scheduler>k__BackingField  // 0x70
  private           System.Int32                    connectionLimit  // 0x78
  private           System.Int32                    maxIdleTime  // 0x7C
  private           System.Object                   m_ServerCertificateOrBytes  // 0x80
  private           System.Object                   m_ClientCertificateOrBytes  // 0x88
METHODS:
  System.Void .ctor(System.Net.ServicePointManager.SPKey key, System.Uri uri, System.Int32 connectionLimit, System.Int32 maxIdleTime)
  System.Net.ServicePointManager.SPKey get_Key()
  System.Net.ServicePointScheduler get_Scheduler()
  System.Void set_Scheduler(System.Net.ServicePointScheduler value)
  System.Uri get_Address()
  System.Int32 get_ConnectionLimit()
  System.Version get_ProtocolVersion()
  System.Void set_Expect100Continue(System.Boolean value)
  System.Boolean get_UseNagleAlgorithm()
  System.Void set_UseNagleAlgorithm(System.Boolean value)
  System.Boolean get_SendContinue()
  System.Void set_SendContinue(System.Boolean value)
  System.Void SetTcpKeepAlive(System.Boolean enabled, System.Int32 keepAliveTime, System.Int32 keepAliveInterval)
  System.Void KeepAliveSetup(System.Net.Sockets.Socket socket)
  System.Void PutBytes(System.Byte[] bytes, System.UInt32 v, System.Int32 offset)
  System.Boolean get_UsesProxy()
  System.Void set_UsesProxy(System.Boolean value)
  System.Boolean get_UseConnect()
  System.Void set_UseConnect(System.Boolean value)
  System.Boolean get_HasTimedOut()
  System.Net.IPHostEntry get_HostEntry()
  System.Void SetVersion(System.Version version)
  System.Void SendRequest(System.Net.WebOperation operation, System.String groupName)
  System.Boolean CloseConnectionGroup(System.String connectionGroupName)
  System.Void FreeServicePoint()
  System.Void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate)
  System.Void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate)
  System.Boolean CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote)
END_CLASS

CLASS: System.Net.ServicePointManager
TYPE:  class
TOKEN: 0x20001DA
FIELDS:
  private   static  System.Collections.Concurrent.ConcurrentDictionary<System.Net.ServicePointManager.SPKey,System.Net.ServicePoint>servicePoints  // 0x0
  private   static  System.Net.ICertificatePolicy   policy  // 0x8
  private   static  System.Int32                    defaultConnectionLimit  // 0x10
  private   static  System.Int32                    maxServicePointIdleTime  // 0x14
  private   static  System.Int32                    maxServicePoints  // 0x18
  private   static  System.Int32                    dnsRefreshTimeout  // 0x1C
  private   static  System.Boolean                  _checkCRL  // 0x20
  private   static  System.Net.SecurityProtocolType _securityProtocol  // 0x24
  private   static  System.Boolean                  expectContinue  // 0x28
  private   static  System.Boolean                  useNagle  // 0x29
  private   static  System.Net.ServerCertValidationCallbackserver_cert_cb  // 0x30
  private   static  System.Boolean                  tcp_keepalive  // 0x38
  private   static  System.Int32                    tcp_keepalive_time  // 0x3C
  private   static  System.Int32                    tcp_keepalive_interval  // 0x40
METHODS:
  System.Void .cctor()
  System.Net.ICertificatePolicy GetLegacyCertificatePolicy()
  System.Boolean get_CheckCertificateRevocationList()
  System.Int32 get_DnsRefreshTimeout()
  System.Net.SecurityProtocolType get_SecurityProtocol()
  System.Net.ServerCertValidationCallback get_ServerCertValidationCallback()
  System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback()
  System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy)
  System.Void CloseConnectionGroup(System.String connectionGroupName)
  System.Void RemoveServicePoint(System.Net.ServicePoint sp)
END_CLASS

CLASS: System.Net.ServicePointScheduler
TYPE:  class
TOKEN: 0x20001DC
FIELDS:
  private           System.Net.ServicePoint         <ServicePoint>k__BackingField  // 0x10
  private           System.Int32                    running  // 0x18
  private           System.Int32                    maxIdleTime  // 0x1C
  private           System.Net.ServicePointScheduler.AsyncManualResetEventschedulerEvent  // 0x20
  private           System.Net.ServicePointScheduler.ConnectionGroupdefaultGroup  // 0x28
  private           System.Collections.Generic.Dictionary<System.String,System.Net.ServicePointScheduler.ConnectionGroup>groups  // 0x30
  private           System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebOperation>>operations  // 0x38
  private           System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebConnection,System.Threading.Tasks.Task>>idleConnections  // 0x40
  private           System.Int32                    currentConnections  // 0x48
  private           System.Int32                    connectionLimit  // 0x4C
  private           System.DateTime                 idleSince  // 0x50
  private   static  System.Int32                    nextId  // 0x0
  public    readonly System.Int32                    ID  // 0x58
METHODS:
  System.Net.ServicePoint get_ServicePoint()
  System.Void set_ServicePoint(System.Net.ServicePoint value)
  System.Int32 get_MaxIdleTime()
  System.Void .ctor(System.Net.ServicePoint servicePoint, System.Int32 connectionLimit, System.Int32 maxIdleTime)
  System.Void Run()
  System.Threading.Tasks.Task RunScheduler()
  System.Void Cleanup()
  System.Void RunSchedulerIteration()
  System.Boolean OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation)
  System.Void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection)
  System.Boolean SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group)
  System.Void RemoveOperation(System.Net.WebOperation operation)
  System.Void RemoveIdleConnection(System.Net.WebConnection connection)
  System.Void FinalCleanup()
  System.Void SendRequest(System.Net.WebOperation operation, System.String groupName)
  System.Boolean CloseConnectionGroup(System.String groupName)
  System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(System.String name)
  System.Void OnConnectionCreated(System.Net.WebConnection connection)
  System.Void OnConnectionClosed(System.Net.WebConnection connection)
  System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Threading.Tasks.Task workerTask, System.Int32 millisecondTimeout)
  System.Threading.Tasks.Task <Run>b__31_0()
END_CLASS

CLASS: System.Net.WebCompletionSource`1
TYPE:  class
TOKEN: 0x20001E2
FIELDS:
  private           System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>>completion  // 0x0
  private           System.Net.WebCompletionSource.Result<T>currentResult  // 0x0
METHODS:
  System.Void .ctor(System.Boolean runAsync)
  System.Net.WebCompletionSource.Result<T> get_CurrentResult()
  System.Threading.Tasks.Task get_Task()
  System.Boolean TrySetCompleted(T argument)
  System.Boolean TrySetCompleted()
  System.Boolean TrySetCanceled()
  System.Boolean TrySetCanceled(System.OperationCanceledException error)
  System.Boolean TrySetException(System.Exception error)
  System.Void ThrowOnError()
  System.Threading.Tasks.Task<T> WaitForCompletion()
END_CLASS

CLASS: System.Net.WebCompletionSource
TYPE:  class
TOKEN: 0x20001E6
EXTENDS: WebCompletionSource`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.ReadState
TYPE:  struct
TOKEN: 0x20001E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.ReadState            None  // 0x0
  public    static  System.Net.ReadState            Status  // 0x0
  public    static  System.Net.ReadState            Headers  // 0x0
  public    static  System.Net.ReadState            Content  // 0x0
  public    static  System.Net.ReadState            Aborted  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebConnection
TYPE:  class
TOKEN: 0x20001E8
FIELDS:
  private           System.Net.NetworkCredential    ntlm_credentials  // 0x10
  private           System.Boolean                  ntlm_authenticated  // 0x18
  private           System.Boolean                  unsafe_sharing  // 0x19
  private           System.IO.Stream                networkStream  // 0x20
  private           System.Net.Sockets.Socket       socket  // 0x28
  private           Mono.Net.Security.MonoTlsStream monoTlsStream  // 0x30
  private           System.Net.WebConnectionTunnel  tunnel  // 0x38
  private           System.Int32                    disposed  // 0x40
  private   readonly System.Net.ServicePoint         <ServicePoint>k__BackingField  // 0x48
  private           System.DateTime                 idleSince  // 0x50
  private           System.Net.WebOperation         currentOperation  // 0x58
METHODS:
  System.Net.ServicePoint get_ServicePoint()
  System.Void .ctor(System.Net.ServicePoint sPoint)
  System.Boolean CanReuse()
  System.Boolean CheckReusable()
  System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Boolean> CreateStream(System.Net.WebOperation operation, System.Boolean reused, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken)
  System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error)
  System.Boolean ReadLine(System.Byte[] buffer, System.Int32& start, System.Int32 max, System.String& output)
  System.Boolean CanReuseConnection(System.Net.WebOperation operation)
  System.Boolean PrepareSharingNtlm(System.Net.WebOperation operation)
  System.Void Reset()
  System.Void Close(System.Boolean reset)
  System.Void CloseSocket()
  System.Boolean get_Closed()
  System.DateTime get_IdleSince()
  System.Boolean StartOperation(System.Net.WebOperation operation, System.Boolean reused)
  System.Boolean Continue(System.Net.WebOperation next)
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Void ResetNtlm()
  System.Boolean get_NtlmAuthenticated()
  System.Void set_NtlmAuthenticated(System.Boolean value)
  System.Net.NetworkCredential get_NtlmCredential()
  System.Void set_NtlmCredential(System.Net.NetworkCredential value)
  System.Boolean get_UnsafeAuthenticatedConnectionSharing()
  System.Void set_UnsafeAuthenticatedConnectionSharing(System.Boolean value)
END_CLASS

CLASS: System.Net.WebConnectionStream
TYPE:  class
TOKEN: 0x20001ED
EXTENDS: Stream
FIELDS:
  protected         System.Boolean                  closed  // 0x28
  private           System.Boolean                  disposed  // 0x29
  private           System.Object                   locker  // 0x30
  private           System.Int32                    read_timeout  // 0x38
  private           System.Int32                    write_timeout  // 0x3C
  private   readonly System.Net.HttpWebRequest       <Request>k__BackingField  // 0x40
  private   readonly System.Net.WebConnection        <Connection>k__BackingField  // 0x48
  private   readonly System.Net.WebOperation         <Operation>k__BackingField  // 0x50
METHODS:
  System.Void .ctor(System.Net.WebConnection cnc, System.Net.WebOperation operation)
  System.Net.HttpWebRequest get_Request()
  System.Net.WebConnection get_Connection()
  System.Net.WebOperation get_Operation()
  System.Net.ServicePoint get_ServicePoint()
  System.Boolean get_CanTimeout()
  System.Int32 get_ReadTimeout()
  System.Void set_ReadTimeout(System.Int32 value)
  System.Int32 get_WriteTimeout()
  System.Void set_WriteTimeout(System.Int32 value)
  System.Exception GetException(System.Exception e)
  System.Boolean TryReadFromBufferedContent(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Int32& result)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback cb, System.Object state)
  System.Int32 EndRead(System.IAsyncResult r)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback cb, System.Object state)
  System.Void EndWrite(System.IAsyncResult r)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Flush()
  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  System.Void InternalClose()
  System.Void Close_internal(System.Boolean& disposed)
  System.Void Close()
  System.Int64 Seek(System.Int64 a, System.IO.SeekOrigin b)
  System.Void SetLength(System.Int64 a)
  System.Boolean get_CanSeek()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
END_CLASS

CLASS: System.Net.WebConnectionTunnel
TYPE:  class
TOKEN: 0x20001EE
FIELDS:
  private   readonly System.Net.HttpWebRequest       <Request>k__BackingField  // 0x10
  private   readonly System.Uri                      <ConnectUri>k__BackingField  // 0x18
  private           System.Net.HttpWebRequest       connectRequest  // 0x20
  private           System.Net.WebConnectionTunnel.NtlmAuthStatentlmAuthState  // 0x28
  private           System.Boolean                  <Success>k__BackingField  // 0x2C
  private           System.Boolean                  <CloseConnection>k__BackingField  // 0x2D
  private           System.Int32                    <StatusCode>k__BackingField  // 0x30
  private           System.String                   <StatusDescription>k__BackingField  // 0x38
  private           System.String[]                 <Challenge>k__BackingField  // 0x40
  private           System.Net.WebHeaderCollection  <Headers>k__BackingField  // 0x48
  private           System.Version                  <ProxyVersion>k__BackingField  // 0x50
  private           System.Byte[]                   <Data>k__BackingField  // 0x58
METHODS:
  System.Net.HttpWebRequest get_Request()
  System.Uri get_ConnectUri()
  System.Void .ctor(System.Net.HttpWebRequest request, System.Uri connectUri)
  System.Boolean get_Success()
  System.Void set_Success(System.Boolean value)
  System.Boolean get_CloseConnection()
  System.Void set_CloseConnection(System.Boolean value)
  System.Int32 get_StatusCode()
  System.Void set_StatusCode(System.Int32 value)
  System.Void set_StatusDescription(System.String value)
  System.String[] get_Challenge()
  System.Void set_Challenge(System.String[] value)
  System.Net.WebHeaderCollection get_Headers()
  System.Void set_Headers(System.Net.WebHeaderCollection value)
  System.Version get_ProxyVersion()
  System.Void set_ProxyVersion(System.Version value)
  System.Byte[] get_Data()
  System.Void set_Data(System.Byte[] value)
  System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
  System.Void FlushContents(System.IO.Stream stream, System.Int32 contentLength)
END_CLASS

CLASS: System.Net.WebOperation
TYPE:  class
TOKEN: 0x20001F2
FIELDS:
  private   readonly System.Net.HttpWebRequest       <Request>k__BackingField  // 0x10
  private           System.Net.WebConnection        <Connection>k__BackingField  // 0x18
  private           System.Net.ServicePoint         <ServicePoint>k__BackingField  // 0x20
  private   readonly System.Net.BufferOffsetSize     <WriteBuffer>k__BackingField  // 0x28
  private   readonly System.Boolean                  <IsNtlmChallenge>k__BackingField  // 0x30
  private           System.Threading.CancellationTokenSourcects  // 0x38
  private           System.Net.WebCompletionSource<System.Net.WebRequestStream>requestTask  // 0x40
  private           System.Net.WebCompletionSource<System.Net.WebRequestStream>requestWrittenTask  // 0x48
  private           System.Net.WebCompletionSource<System.Net.WebResponseStream>responseTask  // 0x50
  private           System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>>finishedTask  // 0x58
  private           System.Net.WebRequestStream     writeStream  // 0x60
  private           System.Net.WebResponseStream    responseStream  // 0x68
  private           System.Runtime.ExceptionServices.ExceptionDispatchInfodisposedInfo  // 0x70
  private           System.Runtime.ExceptionServices.ExceptionDispatchInfoclosedInfo  // 0x78
  private           System.Net.WebOperation         priorityRequest  // 0x80
  private           System.Int32                    requestSent  // 0x88
  private           System.Int32                    finished  // 0x8C
METHODS:
  System.Net.HttpWebRequest get_Request()
  System.Net.WebConnection get_Connection()
  System.Void set_Connection(System.Net.WebConnection value)
  System.Net.ServicePoint get_ServicePoint()
  System.Void set_ServicePoint(System.Net.ServicePoint value)
  System.Net.BufferOffsetSize get_WriteBuffer()
  System.Boolean get_IsNtlmChallenge()
  System.Void .ctor(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, System.Boolean isNtlmChallenge, System.Threading.CancellationToken cancellationToken)
  System.Boolean get_Aborted()
  System.Boolean get_Closed()
  System.Void Abort()
  System.Void Close()
  System.Void SetCanceled()
  System.Void SetError(System.Exception error)
  System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(System.Runtime.ExceptionServices.ExceptionDispatchInfo& field)
  System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken)
  System.Void ThrowIfDisposed()
  System.Void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken)
  System.Void ThrowIfClosedOrDisposed()
  System.Void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken)
  System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(System.Boolean throwIt, System.Runtime.ExceptionServices.ExceptionDispatchInfo& field)
  System.Void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection)
  System.Void SetPriorityRequest(System.Net.WebOperation operation)
  System.Threading.Tasks.Task<System.IO.Stream> GetRequestStream()
  System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal()
  System.Net.WebRequestStream get_WriteStream()
  System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream()
  System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished()
  System.Void Run()
  System.Void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error)
  System.Void Finish(System.Boolean ok, System.Exception error)
  System.Void <RegisterRequest>b__48_0()
END_CLASS

CLASS: System.Net.WebReadStream
TYPE:  class
TOKEN: 0x20001F5
EXTENDS: Stream
FIELDS:
  private   readonly System.Net.WebOperation         <Operation>k__BackingField  // 0x28
  private   readonly System.IO.Stream                <InnerStream>k__BackingField  // 0x30
  private           System.Boolean                  disposed  // 0x38
METHODS:
  System.Net.WebOperation get_Operation()
  System.IO.Stream get_InnerStream()
  System.Void .ctor(System.Net.WebOperation operation, System.IO.Stream innerStream)
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Boolean get_CanSeek()
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Void SetLength(System.Int64 value)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Flush()
  System.Exception GetException(System.Exception e)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback cb, System.Object state)
  System.Int32 EndRead(System.IAsyncResult r)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken)
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: System.Net.WebRequestStream
TYPE:  class
TOKEN: 0x20001F7
EXTENDS: WebConnectionStream
FIELDS:
  private   static  System.Byte[]                   crlf  // 0x0
  private           System.IO.MemoryStream          writeBuffer  // 0x58
  private           System.Boolean                  requestWritten  // 0x60
  private           System.Boolean                  allowBuffering  // 0x61
  private           System.Boolean                  sendChunked  // 0x62
  private           System.Net.WebCompletionSource  pendingWrite  // 0x68
  private           System.Int64                    totalWritten  // 0x70
  private           System.Byte[]                   headers  // 0x78
  private           System.Boolean                  headersSent  // 0x80
  private           System.Int32                    completeRequestWritten  // 0x84
  private           System.Int32                    chunkTrailerWritten  // 0x88
  private   readonly System.IO.Stream                <InnerStream>k__BackingField  // 0x90
  private   readonly System.Boolean                  <KeepAlive>k__BackingField  // 0x98
METHODS:
  System.Void .ctor(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel)
  System.IO.Stream get_InnerStream()
  System.Boolean get_KeepAlive()
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Boolean get_HasWriteBuffer()
  System.Int32 get_WriteBufferLength()
  System.Net.BufferOffsetSize GetWriteBuffer()
  System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsyncInner(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task ProcessWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Void CheckWriteOverflow(System.Int64 contentLength, System.Int64 totalWritten, System.Int64 size)
  System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task SetHeadersAsync(System.Boolean setInternalLength, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteChunkTrailer()
  System.Void KillBuffer()
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Boolean TryReadFromBufferedContent(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Int32& result)
  System.Void Close_internal(System.Boolean& disposed)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.WebResponseStream
TYPE:  class
TOKEN: 0x2000200
EXTENDS: WebConnectionStream
FIELDS:
  private           System.Net.WebReadStream        innerStream  // 0x58
  private           System.Boolean                  nextReadCalled  // 0x60
  private           System.Boolean                  bufferedEntireContent  // 0x61
  private           System.Net.WebCompletionSource  pendingRead  // 0x68
  private           System.Object                   locker  // 0x70
  private           System.Int32                    nestedRead  // 0x78
  private           System.Boolean                  read_eof  // 0x7C
  private   readonly System.Net.WebRequestStream     <RequestStream>k__BackingField  // 0x80
  private           System.Net.WebHeaderCollection  <Headers>k__BackingField  // 0x88
  private           System.Net.HttpStatusCode       <StatusCode>k__BackingField  // 0x90
  private           System.String                   <StatusDescription>k__BackingField  // 0x98
  private           System.Version                  <Version>k__BackingField  // 0xA0
  private           System.Boolean                  <KeepAlive>k__BackingField  // 0xA8
  private           System.Boolean                  <ChunkedRead>k__BackingField  // 0xA9
METHODS:
  System.Net.WebRequestStream get_RequestStream()
  System.Net.WebHeaderCollection get_Headers()
  System.Void set_Headers(System.Net.WebHeaderCollection value)
  System.Net.HttpStatusCode get_StatusCode()
  System.Void set_StatusCode(System.Net.HttpStatusCode value)
  System.String get_StatusDescription()
  System.Void set_StatusDescription(System.String value)
  System.Version get_Version()
  System.Void set_Version(System.Version value)
  System.Boolean get_KeepAlive()
  System.Void set_KeepAlive(System.Boolean value)
  System.Void .ctor(System.Net.WebRequestStream request)
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Boolean get_ChunkedRead()
  System.Void set_ChunkedRead(System.Boolean value)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Int32> ProcessRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Boolean TryReadFromBufferedContent(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Int32& result)
  System.Boolean get_ExpectContent()
  System.Void Initialize(System.Net.BufferOffsetSize buffer)
  System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task ReadAllAsync(System.Boolean resending, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Void Close_internal(System.Boolean& disposed)
  System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, System.String where)
  System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken)
  System.Boolean GetResponse(System.Net.BufferOffsetSize buffer, System.Int32& pos, System.Net.ReadState& state)
END_CLASS

CLASS: System.Net.Cache.RequestCache
TYPE:  class
TOKEN: 0x200022F
FIELDS:
  private   static readonly System.Char[]                   LineSplits  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Cache.RequestCacheManager
TYPE:  class
TOKEN: 0x2000230
FIELDS:
  private   static  System.Net.Cache.RequestCachingSectionInternals_CacheConfigSettings  // 0x0
  private   static readonly System.Net.Cache.RequestCacheBindings_BypassCacheBinding  // 0x8
  private   static  System.Net.Cache.RequestCacheBindings_DefaultGlobalBinding  // 0x10
  private   static  System.Net.Cache.RequestCacheBindings_DefaultHttpBinding  // 0x18
  private   static  System.Net.Cache.RequestCacheBindings_DefaultFtpBinding  // 0x20
METHODS:
  System.Net.Cache.RequestCacheBinding GetBinding(System.String internedScheme)
  System.Void LoadConfigSettings()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Cache.RequestCacheValidator
TYPE:  class
TOKEN: 0x2000231
FIELDS:
METHODS:
  System.Object CreateValidator()
END_CLASS

CLASS: System.Net.Cache.RequestCachingSectionInternal
TYPE:  class
TOKEN: 0x2000232
FIELDS:
  public    readonly System.Boolean                  DisableAllCaching  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Cache.RequestCacheBinding
TYPE:  class
TOKEN: 0x2000233
FIELDS:
  private           System.Net.Cache.RequestCache   m_RequestCache  // 0x10
  private           System.Net.Cache.RequestCacheValidatorm_CacheValidator  // 0x18
  private           System.Net.Cache.RequestCachePolicym_Policy  // 0x20
METHODS:
  System.Void .ctor(System.Net.Cache.RequestCache requestCache, System.Net.Cache.RequestCacheValidator cacheValidator, System.Net.Cache.RequestCachePolicy policy)
  System.Net.Cache.RequestCache get_Cache()
  System.Net.Cache.RequestCacheValidator get_Validator()
  System.Net.Cache.RequestCachePolicy get_Policy()
END_CLASS

CLASS: System.Net.Cache.RequestCacheLevel
TYPE:  struct
TOKEN: 0x2000234
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Cache.RequestCacheLevelDefault  // 0x0
  public    static  System.Net.Cache.RequestCacheLevelBypassCache  // 0x0
  public    static  System.Net.Cache.RequestCacheLevelCacheOnly  // 0x0
  public    static  System.Net.Cache.RequestCacheLevelCacheIfAvailable  // 0x0
  public    static  System.Net.Cache.RequestCacheLevelRevalidate  // 0x0
  public    static  System.Net.Cache.RequestCacheLevelReload  // 0x0
  public    static  System.Net.Cache.RequestCacheLevelNoCacheNoStore  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Cache.RequestCachePolicy
TYPE:  class
TOKEN: 0x2000235
FIELDS:
  private           System.Net.Cache.RequestCacheLevelm_Level  // 0x10
METHODS:
  System.Void .ctor(System.Net.Cache.RequestCacheLevel level)
  System.Net.Cache.RequestCacheLevel get_Level()
  System.String ToString()
END_CLASS

CLASS: System.Net.Cache.RequestCacheProtocol
TYPE:  class
TOKEN: 0x2000236
FIELDS:
METHODS:
  System.Void .ctor(System.Object arg1, System.Object arg2)
END_CLASS

CLASS: System.Net.Configuration.DefaultProxySectionInternal
TYPE:  class
TOKEN: 0x200022D
FIELDS:
  private           System.Net.IWebProxy            webProxy  // 0x10
  private   static  System.Object                   classSyncObject  // 0x0
METHODS:
  System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode()
  System.Net.IWebProxy GetSystemWebProxy()
  System.Object get_ClassSyncObject()
  System.Net.Configuration.DefaultProxySectionInternal GetSection()
  System.Net.IWebProxy get_WebProxy()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Configuration.SettingsSectionInternal
TYPE:  class
TOKEN: 0x200022E
FIELDS:
  private   static readonly System.Net.Configuration.SettingsSectionInternalinstance  // 0x0
  private   readonly System.Boolean                  HttpListenerUnescapeRequestUrl  // 0x10
  private   readonly System.Net.Sockets.IPProtectionLevelIPProtectionLevel  // 0x14
METHODS:
  System.Net.Configuration.SettingsSectionInternal get_Section()
  System.Boolean get_Ipv6Enabled()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Configuration.BypassElement
TYPE:  class
TOKEN: 0x200037A
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Configuration.BypassElementCollection
TYPE:  class
TOKEN: 0x200037B
EXTENDS: ConfigurationElementCollection
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Configuration.ConnectionManagementElement
TYPE:  class
TOKEN: 0x200037C
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Configuration.ConnectionManagementElementCollection
TYPE:  class
TOKEN: 0x200037D
EXTENDS: ConfigurationElementCollection
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Configuration.ConnectionManagementSection
TYPE:  class
TOKEN: 0x200037E
EXTENDS: ConfigurationSection
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.DefaultProxySection
TYPE:  class
TOKEN: 0x200037F
EXTENDS: ConfigurationSection
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
  System.Void Reset(System.Configuration.ConfigurationElement parentElement)
END_CLASS

CLASS: System.Net.Configuration.ProxyElement
TYPE:  class
TOKEN: 0x2000380
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.HttpWebRequestElement
TYPE:  class
TOKEN: 0x2000381
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.Ipv6Element
TYPE:  class
TOKEN: 0x2000382
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.NetSectionGroup
TYPE:  class
TOKEN: 0x2000383
EXTENDS: ConfigurationSectionGroup
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Configuration.SettingsSection
TYPE:  class
TOKEN: 0x2000384
EXTENDS: ConfigurationSection
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.PerformanceCountersElement
TYPE:  class
TOKEN: 0x2000385
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.ServicePointManagerElement
TYPE:  class
TOKEN: 0x2000386
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.SocketElement
TYPE:  class
TOKEN: 0x2000387
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.WebProxyScriptElement
TYPE:  class
TOKEN: 0x2000388
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.WebRequestModulesSection
TYPE:  class
TOKEN: 0x2000389
EXTENDS: ConfigurationSection
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
END_CLASS

CLASS: System.Net.Configuration.WebRequestModuleElementCollection
TYPE:  class
TOKEN: 0x200038A
EXTENDS: ConfigurationElementCollection
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Configuration.WebRequestModuleElement
TYPE:  class
TOKEN: 0x200038B
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Mail.DomainLiteralReader
TYPE:  class
TOKEN: 0x2000280
FIELDS:
METHODS:
  System.Int32 ReadReverse(System.String data, System.Int32 index)
END_CLASS

CLASS: System.Net.Mail.DotAtomReader
TYPE:  class
TOKEN: 0x2000281
FIELDS:
METHODS:
  System.Int32 ReadReverse(System.String data, System.Int32 index)
END_CLASS

CLASS: System.Net.Mail.MailAddressParser
TYPE:  class
TOKEN: 0x2000282
FIELDS:
METHODS:
  System.Net.Mail.MailAddress ParseAddress(System.String data)
  System.Net.Mail.MailAddress ParseAddress(System.String data, System.Boolean expectMultipleAddresses, System.Int32& index)
  System.Int32 ReadCfwsAndThrowIfIncomplete(System.String data, System.Int32 index)
  System.String ParseDomain(System.String data, System.Int32& index)
  System.String ParseLocalPart(System.String data, System.Int32& index, System.Boolean expectAngleBracket, System.Boolean expectMultipleAddresses)
  System.String ParseDisplayName(System.String data, System.Int32& index, System.Boolean expectMultipleAddresses)
  System.String NormalizeOrThrow(System.String input)
END_CLASS

CLASS: System.Net.Mail.QuotedPairReader
TYPE:  class
TOKEN: 0x2000283
FIELDS:
METHODS:
  System.Int32 CountQuotedChars(System.String data, System.Int32 index, System.Boolean permitUnicodeEscaping)
  System.Int32 CountBackslashes(System.String data, System.Int32 index)
END_CLASS

CLASS: System.Net.Mail.QuotedStringFormatReader
TYPE:  class
TOKEN: 0x2000284
FIELDS:
METHODS:
  System.Int32 ReadReverseQuoted(System.String data, System.Int32 index, System.Boolean permitUnicode)
  System.Int32 ReadReverseUnQuoted(System.String data, System.Int32 index, System.Boolean permitUnicode, System.Boolean expectCommaDelimiter)
  System.Boolean IsValidQtext(System.Boolean allowUnicode, System.Char ch)
END_CLASS

CLASS: System.Net.Mail.WhitespaceReader
TYPE:  class
TOKEN: 0x2000285
FIELDS:
METHODS:
  System.Int32 ReadFwsReverse(System.String data, System.Int32 index)
  System.Int32 ReadCfwsReverse(System.String data, System.Int32 index)
END_CLASS

CLASS: System.Net.Mail.MailAddress
TYPE:  class
TOKEN: 0x2000286
FIELDS:
  private   readonly System.Text.Encoding            _displayNameEncoding  // 0x10
  private   readonly System.String                   _displayName  // 0x18
  private   readonly System.String                   _userName  // 0x20
  private   readonly System.String                   _host  // 0x28
  private   static readonly System.Net.Mime.EncodedStreamFactorys_encoderFactory  // 0x0
METHODS:
  System.Void .ctor(System.String displayName, System.String userName, System.String domain)
  System.Void .ctor(System.String address)
  System.Void .ctor(System.String address, System.String displayName, System.Text.Encoding displayNameEncoding)
  System.String get_DisplayName()
  System.String get_Address()
  System.String get_SmtpAddress()
  System.String ToString()
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Mime.MailBnfHelper
TYPE:  class
TOKEN: 0x200027E
FIELDS:
  private   static readonly System.Boolean[]                Atext  // 0x0
  private   static readonly System.Boolean[]                Qtext  // 0x8
  private   static readonly System.Boolean[]                Dtext  // 0x10
  private   static readonly System.Boolean[]                Ftext  // 0x18
  private   static readonly System.Boolean[]                Ttext  // 0x20
  private   static readonly System.Boolean[]                Ctext  // 0x28
  private   static readonly System.Int32                    Ascii7bitMaxValue  // 0x30
  private   static readonly System.Char                     Quote  // 0x34
  private   static readonly System.Char                     Space  // 0x36
  private   static readonly System.Char                     Tab  // 0x38
  private   static readonly System.Char                     CR  // 0x3A
  private   static readonly System.Char                     LF  // 0x3C
  private   static readonly System.Char                     StartComment  // 0x3E
  private   static readonly System.Char                     EndComment  // 0x40
  private   static readonly System.Char                     Backslash  // 0x42
  private   static readonly System.Char                     At  // 0x44
  private   static readonly System.Char                     EndAngleBracket  // 0x46
  private   static readonly System.Char                     StartAngleBracket  // 0x48
  private   static readonly System.Char                     StartSquareBracket  // 0x4A
  private   static readonly System.Char                     EndSquareBracket  // 0x4C
  private   static readonly System.Char                     Comma  // 0x4E
  private   static readonly System.Char                     Dot  // 0x50
  private   static readonly System.Char[]                   s_colonSeparator  // 0x58
  private   static  System.String[]                 s_months  // 0x60
METHODS:
  System.Boolean[] CreateCharactersAllowedInAtoms()
  System.Boolean[] CreateCharactersAllowedInQuotedStrings()
  System.Boolean[] CreateCharactersAllowedInDomainLiterals()
  System.Boolean[] CreateCharactersAllowedInHeaderNames()
  System.Boolean[] CreateCharactersAllowedInTokens()
  System.Boolean[] CreateCharactersAllowedInComments()
  System.Boolean IsAllowedWhiteSpace(System.Char c)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Mime.EncodedStreamFactory
TYPE:  class
TOKEN: 0x200027F
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.DuplicateAddressDetectionState
TYPE:  struct
TOKEN: 0x2000206
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.DuplicateAddressDetectionStateInvalid  // 0x0
  public    static  System.Net.NetworkInformation.DuplicateAddressDetectionStateTentative  // 0x0
  public    static  System.Net.NetworkInformation.DuplicateAddressDetectionStateDuplicate  // 0x0
  public    static  System.Net.NetworkInformation.DuplicateAddressDetectionStateDeprecated  // 0x0
  public    static  System.Net.NetworkInformation.DuplicateAddressDetectionStatePreferred  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.IPAddressInformation
TYPE:  class
TOKEN: 0x2000207
FIELDS:
METHODS:
  System.Net.IPAddress get_Address()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.IPGlobalProperties
TYPE:  class
TOKEN: 0x2000208
FIELDS:
METHODS:
  System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties()
  System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties()
  System.String get_DomainName()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.IPInterfaceProperties
TYPE:  class
TOKEN: 0x2000209
FIELDS:
METHODS:
  System.Net.NetworkInformation.UnicastIPAddressInformationCollection get_UnicastAddresses()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.IPv4InterfaceStatistics
TYPE:  class
TOKEN: 0x200020A
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.NetworkInformationException
TYPE:  class
TOKEN: 0x200020B
EXTENDS: Win32Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 errorCode)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
END_CLASS

CLASS: System.Net.NetworkInformation.NetworkInterface
TYPE:  class
TOKEN: 0x200020C
FIELDS:
METHODS:
  System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces()
  System.Net.NetworkInformation.IPInterfaceProperties GetIPProperties()
  System.Net.NetworkInformation.OperationalStatus get_OperationalStatus()
  System.Net.NetworkInformation.NetworkInterfaceType get_NetworkInterfaceType()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.NetworkInterfaceComponent
TYPE:  struct
TOKEN: 0x200020D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.NetworkInterfaceComponentIPv4  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceComponentIPv6  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.OperationalStatus
TYPE:  struct
TOKEN: 0x200020E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.OperationalStatusUp  // 0x0
  public    static  System.Net.NetworkInformation.OperationalStatusDown  // 0x0
  public    static  System.Net.NetworkInformation.OperationalStatusTesting  // 0x0
  public    static  System.Net.NetworkInformation.OperationalStatusUnknown  // 0x0
  public    static  System.Net.NetworkInformation.OperationalStatusDormant  // 0x0
  public    static  System.Net.NetworkInformation.OperationalStatusNotPresent  // 0x0
  public    static  System.Net.NetworkInformation.OperationalStatusLowerLayerDown  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.PrefixOrigin
TYPE:  struct
TOKEN: 0x200020F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.PrefixOriginOther  // 0x0
  public    static  System.Net.NetworkInformation.PrefixOriginManual  // 0x0
  public    static  System.Net.NetworkInformation.PrefixOriginWellKnown  // 0x0
  public    static  System.Net.NetworkInformation.PrefixOriginDhcp  // 0x0
  public    static  System.Net.NetworkInformation.PrefixOriginRouterAdvertisement  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.SuffixOrigin
TYPE:  struct
TOKEN: 0x2000210
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.SuffixOriginOther  // 0x0
  public    static  System.Net.NetworkInformation.SuffixOriginManual  // 0x0
  public    static  System.Net.NetworkInformation.SuffixOriginWellKnown  // 0x0
  public    static  System.Net.NetworkInformation.SuffixOriginOriginDhcp  // 0x0
  public    static  System.Net.NetworkInformation.SuffixOriginLinkLayerAddress  // 0x0
  public    static  System.Net.NetworkInformation.SuffixOriginRandom  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.UnicastIPAddressInformation
TYPE:  class
TOKEN: 0x2000211
EXTENDS: IPAddressInformation
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.UnicastIPAddressInformationCollection
TYPE:  class
TOKEN: 0x2000212
FIELDS:
  private           System.Collections.ObjectModel.Collection<System.Net.NetworkInformation.UnicastIPAddressInformation>addresses  // 0x10
METHODS:
  System.Void .ctor()
  System.Void CopyTo(System.Net.NetworkInformation.UnicastIPAddressInformation[] array, System.Int32 offset)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Void Add(System.Net.NetworkInformation.UnicastIPAddressInformation address)
  System.Void InternalAdd(System.Net.NetworkInformation.UnicastIPAddressInformation address)
  System.Boolean Contains(System.Net.NetworkInformation.UnicastIPAddressInformation address)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.UnicastIPAddressInformation> GetEnumerator()
  System.Boolean Remove(System.Net.NetworkInformation.UnicastIPAddressInformation address)
  System.Void Clear()
END_CLASS

CLASS: System.Net.NetworkInformation.NetworkInterfaceType
TYPE:  struct
TOKEN: 0x2000213
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeUnknown  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeEthernet  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeTokenRing  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeFddi  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeBasicIsdn  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypePrimaryIsdn  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypePpp  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeLoopback  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeEthernet3Megabit  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeSlip  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeAtm  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeGenericModem  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeFastEthernetT  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeIsdn  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeFastEthernetFx  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeWireless80211  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeAsymmetricDsl  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeRateAdaptDsl  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeSymmetricDsl  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeVeryHighSpeedDsl  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeIPOverAtm  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeGigabitEthernet  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeTunnel  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeMultiRateSymmetricDsl  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeHighPerformanceSerialBus  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeWman  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeWwanpp  // 0x0
  public    static  System.Net.NetworkInformation.NetworkInterfaceTypeWwanpp2  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.NetBiosNodeType
TYPE:  struct
TOKEN: 0x2000214
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.NetworkInformation.NetBiosNodeTypeUnknown  // 0x0
  public    static  System.Net.NetworkInformation.NetBiosNodeTypeBroadcast  // 0x0
  public    static  System.Net.NetworkInformation.NetBiosNodeTypePeer2Peer  // 0x0
  public    static  System.Net.NetworkInformation.NetBiosNodeTypeMixed  // 0x0
  public    static  System.Net.NetworkInformation.NetBiosNodeTypeHybrid  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.IPGlobalPropertiesFactoryPal
TYPE:  class
TOKEN: 0x2000215
FIELDS:
METHODS:
  System.Net.NetworkInformation.IPGlobalProperties Create()
END_CLASS

CLASS: System.Net.NetworkInformation.SystemNetworkInterface
TYPE:  class
TOKEN: 0x2000216
FIELDS:
  private   static readonly System.Net.NetworkInformation.NetworkInterfaceFactorynif  // 0x0
METHODS:
  System.Net.NetworkInformation.NetworkInterface[] GetNetworkInterfaces()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.NetworkInformation.NetworkInterfaceFactory
TYPE:  class
TOKEN: 0x2000217
FIELDS:
METHODS:
  System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces()
  System.Net.NetworkInformation.NetworkInterfaceFactory Create()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.NetworkInterfaceFactoryPal
TYPE:  class
TOKEN: 0x2000218
FIELDS:
METHODS:
  System.Net.NetworkInformation.NetworkInterfaceFactory Create()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32IPGlobalProperties
TYPE:  class
TOKEN: 0x2000219
EXTENDS: IPGlobalProperties
FIELDS:
METHODS:
  System.String get_DomainName()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32IPGlobalPropertiesFactoryPal
TYPE:  class
TOKEN: 0x200021A
FIELDS:
METHODS:
  System.Net.NetworkInformation.IPGlobalProperties Create()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32IPInterfaceProperties2
TYPE:  class
TOKEN: 0x200021B
EXTENDS: IPInterfaceProperties
FIELDS:
  private   readonly System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSESaddr  // 0x10
  private   readonly System.Net.NetworkInformation.Win32_MIB_IFROWmib4  // 0x118
  private   readonly System.Net.NetworkInformation.Win32_MIB_IFROWmib6  // 0x188
METHODS:
  System.Void .ctor(System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr, System.Net.NetworkInformation.Win32_MIB_IFROW mib4, System.Net.NetworkInformation.Win32_MIB_IFROW mib6)
  System.Net.NetworkInformation.UnicastIPAddressInformationCollection get_UnicastAddresses()
  System.Net.NetworkInformation.UnicastIPAddressInformationCollection Win32FromUnicast(System.IntPtr ptr)
END_CLASS

CLASS: System.Net.NetworkInformation.Win32IPv4InterfaceStatistics
TYPE:  class
TOKEN: 0x200021C
EXTENDS: IPv4InterfaceStatistics
FIELDS:
  private           System.Net.NetworkInformation.Win32_MIB_IFROWinfo  // 0x10
METHODS:
  System.Void .ctor(System.Net.NetworkInformation.Win32_MIB_IFROW info)
END_CLASS

CLASS: System.Net.NetworkInformation.Win32NetworkInterfaceAPI
TYPE:  class
TOKEN: 0x200021D
EXTENDS: NetworkInterfaceFactory
FIELDS:
METHODS:
  System.Int32 GetAdaptersAddresses(System.UInt32 family, System.UInt32 flags, System.IntPtr reserved, System.IntPtr info, System.Int32& size)
  System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses()
  System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32NetworkInterface2
TYPE:  class
TOKEN: 0x200021E
EXTENDS: NetworkInterface
FIELDS:
  private           System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSESaddr  // 0x10
  private           System.Net.NetworkInformation.Win32_MIB_IFROWmib4  // 0x118
  private           System.Net.NetworkInformation.Win32_MIB_IFROWmib6  // 0x188
  private           System.Net.NetworkInformation.Win32IPv4InterfaceStatisticsip4stats  // 0x1F8
  private           System.Net.NetworkInformation.IPInterfacePropertiesip_if_props  // 0x200
METHODS:
  System.Int32 GetIfEntry(System.Net.NetworkInformation.Win32_MIB_IFROW& row)
  System.Void .ctor(System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr)
  System.Net.NetworkInformation.IPInterfaceProperties GetIPProperties()
  System.Net.NetworkInformation.NetworkInterfaceType get_NetworkInterfaceType()
  System.Net.NetworkInformation.OperationalStatus get_OperationalStatus()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32NetworkInterfaceFactoryPal
TYPE:  class
TOKEN: 0x200021F
FIELDS:
METHODS:
  System.Net.NetworkInformation.NetworkInterfaceFactory Create()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32NetworkInterface
TYPE:  class
TOKEN: 0x2000220
FIELDS:
  private   static  System.Net.NetworkInformation.Win32_FIXED_INFOfixedInfo  // 0x0
  private   static  System.Boolean                  initialized  // 0x58
METHODS:
  System.Int32 GetNetworkParams(System.IntPtr ptr, System.Int32& size)
  System.Net.NetworkInformation.Win32_FIXED_INFO get_FixedInfo()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_FIXED_INFO
TYPE:  struct
TOKEN: 0x2000221
FIELDS:
  public            System.String                   HostName  // 0x10
  public            System.String                   DomainName  // 0x18
  public            System.IntPtr                   CurrentDnsServer  // 0x20
  public            System.Net.NetworkInformation.Win32_IP_ADDR_STRINGDnsServerList  // 0x28
  public            System.Net.NetworkInformation.NetBiosNodeTypeNodeType  // 0x48
  public            System.String                   ScopeId  // 0x50
  public            System.UInt32                   EnableRouting  // 0x58
  public            System.UInt32                   EnableProxy  // 0x5C
  public            System.UInt32                   EnableDns  // 0x60
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.AlignmentUnion
TYPE:  struct
TOKEN: 0x2000222
FIELDS:
  public            System.UInt64                   Alignment  // 0x10
  public            System.Int32                    Length  // 0x10
  public            System.Int32                    IfIndex  // 0x14
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES
TYPE:  struct
TOKEN: 0x2000223
FIELDS:
  public            System.Net.NetworkInformation.AlignmentUnionAlignment  // 0x10
  public            System.IntPtr                   Next  // 0x18
  public            System.String                   AdapterName  // 0x20
  public            System.IntPtr                   FirstUnicastAddress  // 0x28
  public            System.IntPtr                   FirstAnycastAddress  // 0x30
  public            System.IntPtr                   FirstMulticastAddress  // 0x38
  public            System.IntPtr                   FirstDnsServerAddress  // 0x40
  public            System.String                   DnsSuffix  // 0x48
  public            System.String                   Description  // 0x50
  public            System.String                   FriendlyName  // 0x58
  public            System.Byte[]                   PhysicalAddress  // 0x60
  public            System.UInt32                   PhysicalAddressLength  // 0x68
  public            System.UInt32                   Flags  // 0x6C
  public            System.UInt32                   Mtu  // 0x70
  public            System.Net.NetworkInformation.NetworkInterfaceTypeIfType  // 0x74
  public            System.Net.NetworkInformation.OperationalStatusOperStatus  // 0x78
  public            System.Int32                    Ipv6IfIndex  // 0x7C
  public            System.UInt32[]                 ZoneIndices  // 0x80
  public            System.IntPtr                   FirstPrefix  // 0x88
  public            System.UInt64                   TransmitLinkSpeed  // 0x90
  public            System.UInt64                   ReceiveLinkSpeed  // 0x98
  public            System.IntPtr                   FirstWinsServerAddress  // 0xA0
  public            System.IntPtr                   FirstGatewayAddress  // 0xA8
  public            System.UInt32                   Ipv4Metric  // 0xB0
  public            System.UInt32                   Ipv6Metric  // 0xB4
  public            System.UInt64                   Luid  // 0xB8
  public            System.Net.NetworkInformation.Win32_SOCKET_ADDRESSDhcpv4Server  // 0xC0
  public            System.UInt32                   CompartmentId  // 0xD0
  public            System.UInt64                   NetworkGuid  // 0xD8
  public            System.Int32                    ConnectionType  // 0xE0
  public            System.Int32                    TunnelType  // 0xE4
  public            System.Net.NetworkInformation.Win32_SOCKET_ADDRESSDhcpv6Server  // 0xE8
  public            System.Byte[]                   Dhcpv6ClientDuid  // 0xF8
  public            System.UInt64                   Dhcpv6ClientDuidLength  // 0x100
  public            System.UInt64                   Dhcpv6Iaid  // 0x108
  public            System.IntPtr                   FirstDnsSuffix  // 0x110
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_MIB_IFROW
TYPE:  struct
TOKEN: 0x2000224
FIELDS:
  public            System.Char[]                   Name  // 0x10
  public            System.Int32                    Index  // 0x18
  public            System.Net.NetworkInformation.NetworkInterfaceTypeType  // 0x1C
  public            System.Int32                    Mtu  // 0x20
  public            System.UInt32                   Speed  // 0x24
  public            System.Int32                    PhysAddrLen  // 0x28
  public            System.Byte[]                   PhysAddr  // 0x30
  public            System.UInt32                   AdminStatus  // 0x38
  public            System.UInt32                   OperStatus  // 0x3C
  public            System.UInt32                   LastChange  // 0x40
  public            System.Int32                    InOctets  // 0x44
  public            System.Int32                    InUcastPkts  // 0x48
  public            System.Int32                    InNUcastPkts  // 0x4C
  public            System.Int32                    InDiscards  // 0x50
  public            System.Int32                    InErrors  // 0x54
  public            System.Int32                    InUnknownProtos  // 0x58
  public            System.Int32                    OutOctets  // 0x5C
  public            System.Int32                    OutUcastPkts  // 0x60
  public            System.Int32                    OutNUcastPkts  // 0x64
  public            System.Int32                    OutDiscards  // 0x68
  public            System.Int32                    OutErrors  // 0x6C
  public            System.Int32                    OutQLen  // 0x70
  public            System.Int32                    DescrLen  // 0x74
  public            System.Byte[]                   Descr  // 0x78
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_IP_ADDR_STRING
TYPE:  struct
TOKEN: 0x2000225
FIELDS:
  public            System.IntPtr                   Next  // 0x10
  public            System.String                   IpAddress  // 0x18
  public            System.String                   IpMask  // 0x20
  public            System.UInt32                   Context  // 0x28
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32LengthFlagsUnion
TYPE:  struct
TOKEN: 0x2000226
FIELDS:
  public            System.UInt32                   Length  // 0x10
  public            System.UInt32                   Flags  // 0x14
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS
TYPE:  struct
TOKEN: 0x2000227
FIELDS:
  public            System.Net.NetworkInformation.Win32LengthFlagsUnionLengthFlags  // 0x10
  public            System.IntPtr                   Next  // 0x18
  public            System.Net.NetworkInformation.Win32_SOCKET_ADDRESSAddress  // 0x20
  public            System.Net.NetworkInformation.PrefixOriginPrefixOrigin  // 0x30
  public            System.Net.NetworkInformation.SuffixOriginSuffixOrigin  // 0x34
  public            System.Net.NetworkInformation.DuplicateAddressDetectionStateDadState  // 0x38
  public            System.UInt32                   ValidLifetime  // 0x3C
  public            System.UInt32                   PreferredLifetime  // 0x40
  public            System.UInt32                   LeaseLifetime  // 0x44
  public            System.Byte                     OnLinkPrefixLength  // 0x48
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_SOCKADDR
TYPE:  struct
TOKEN: 0x2000228
FIELDS:
  public            System.UInt16                   AddressFamily  // 0x10
  public            System.Byte[]                   AddressData  // 0x18
METHODS:
END_CLASS

CLASS: System.Net.NetworkInformation.Win32_SOCKET_ADDRESS
TYPE:  struct
TOKEN: 0x2000229
FIELDS:
  public            System.IntPtr                   Sockaddr  // 0x10
  public            System.Int32                    SockaddrLength  // 0x18
METHODS:
  System.Net.IPAddress GetIPAddress()
END_CLASS

CLASS: System.Net.NetworkInformation.Win32UnicastIPAddressInformation
TYPE:  class
TOKEN: 0x200022A
EXTENDS: UnicastIPAddressInformation
FIELDS:
  private           System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESSinfo  // 0x10
  private           System.Net.IPAddress            ipv4Mask  // 0x50
METHODS:
  System.Void .ctor(System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS info)
  System.Net.IPAddress get_Address()
  System.Net.IPAddress PrefixLengthToSubnetMask(System.Byte prefixLength, System.Net.Sockets.AddressFamily family)
END_CLASS

CLASS: System.Net.NetworkInformation.UnixNetworkInterfaceFactoryPal
TYPE:  class
TOKEN: 0x200022B
FIELDS:
METHODS:
  System.Net.NetworkInformation.NetworkInterfaceFactory Create()
END_CLASS

CLASS: System.Net.NetworkInformation.UnixIPGlobalPropertiesFactoryPal
TYPE:  class
TOKEN: 0x200022C
FIELDS:
METHODS:
  System.Net.NetworkInformation.IPGlobalProperties Create()
END_CLASS

CLASS: System.Net.Security.CertificateHelper
TYPE:  class
TOKEN: 0x2000287
FIELDS:
METHODS:
  System.Security.Cryptography.X509Certificates.X509Certificate2 GetEligibleClientCertificate()
  System.Security.Cryptography.X509Certificates.X509Certificate2 GetEligibleClientCertificate(System.Security.Cryptography.X509Certificates.X509CertificateCollection candidateCerts)
  System.Security.Cryptography.X509Certificates.X509Certificate2 GetEligibleClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2Collection candidateCerts)
END_CLASS

CLASS: System.Net.Security.SslClientAuthenticationOptions
TYPE:  class
TOKEN: 0x2000288
FIELDS:
  private           System.Net.Security.EncryptionPolicy_encryptionPolicy  // 0x10
  private           System.Security.Cryptography.X509Certificates.X509RevocationMode_checkCertificateRevocation  // 0x14
  private           System.Security.Authentication.SslProtocols_enabledSslProtocols  // 0x18
  private           System.Boolean                  _allowRenegotiation  // 0x1C
  private           System.Net.Security.LocalCertificateSelectionCallback<LocalCertificateSelectionCallback>k__BackingField  // 0x20
  private           System.String                   <TargetHost>k__BackingField  // 0x28
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollection<ClientCertificates>k__BackingField  // 0x30
METHODS:
  System.Boolean get_AllowRenegotiation()
  System.Void set_LocalCertificateSelectionCallback(System.Net.Security.LocalCertificateSelectionCallback value)
  System.String get_TargetHost()
  System.Void set_TargetHost(System.String value)
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
  System.Void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value)
  System.Void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value)
  System.Security.Authentication.SslProtocols get_EnabledSslProtocols()
  System.Void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Security.AuthenticatedStream
TYPE:  class
TOKEN: 0x2000289
EXTENDS: Stream
FIELDS:
  private           System.IO.Stream                _InnerStream  // 0x28
  private           System.Boolean                  _LeaveStreamOpen  // 0x30
METHODS:
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen)
  System.IO.Stream get_InnerStream()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_IsAuthenticated()
END_CLASS

CLASS: System.Net.Security.AuthenticationLevel
TYPE:  struct
TOKEN: 0x200028A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Security.AuthenticationLevelNone  // 0x0
  public    static  System.Net.Security.AuthenticationLevelMutualAuthRequested  // 0x0
  public    static  System.Net.Security.AuthenticationLevelMutualAuthRequired  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Security.EncryptionPolicy
TYPE:  struct
TOKEN: 0x200028B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Security.EncryptionPolicyRequireEncryption  // 0x0
  public    static  System.Net.Security.EncryptionPolicyAllowNoEncryption  // 0x0
  public    static  System.Net.Security.EncryptionPolicyNoEncryption  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Security.LocalCertificateSelectionCallback
TYPE:  class
TOKEN: 0x200028C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: System.Net.Security.RemoteCertificateValidationCallback
TYPE:  class
TOKEN: 0x200028D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
END_CLASS

CLASS: System.Net.Security.SslPolicyErrors
TYPE:  struct
TOKEN: 0x200028E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Security.SslPolicyErrorsNone  // 0x0
  public    static  System.Net.Security.SslPolicyErrorsRemoteCertificateNotAvailable  // 0x0
  public    static  System.Net.Security.SslPolicyErrorsRemoteCertificateNameMismatch  // 0x0
  public    static  System.Net.Security.SslPolicyErrorsRemoteCertificateChainErrors  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Security.LocalCertSelectionCallback
TYPE:  class
TOKEN: 0x200028F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: System.Net.Security.ServerCertSelectionCallback
TYPE:  class
TOKEN: 0x2000290
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String hostName)
END_CLASS

CLASS: System.Net.Security.SslStream
TYPE:  class
TOKEN: 0x2000291
EXTENDS: AuthenticatedStream
FIELDS:
  private           Mono.Net.Security.MobileTlsProviderprovider  // 0x38
  private           Mono.Security.Interface.MonoTlsSettingssettings  // 0x40
  private           System.Net.Security.RemoteCertificateValidationCallbackvalidationCallback  // 0x48
  private           System.Net.Security.LocalCertificateSelectionCallbackselectionCallback  // 0x50
  private           Mono.Net.Security.MobileAuthenticatedStreamimpl  // 0x58
  private           System.Boolean                  explicitSettings  // 0x60
METHODS:
  Mono.Net.Security.MobileAuthenticatedStream get_Impl()
  System.String get_InternalTargetHost()
  Mono.Net.Security.MobileTlsProvider GetProvider()
  System.Void .ctor(System.IO.Stream innerStream)
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen)
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback)
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback)
  System.Void .ctor(System.IO.Stream innerStream, System.Boolean leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings)
  System.Void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback)
  System.Void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback)
  System.Void AuthenticateAsClient(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation)
  System.IAsyncResult BeginAuthenticateAsClient(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.Void EndAuthenticateAsClient(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task AuthenticateAsClientAsync(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, System.Boolean checkCertificateRevocation)
  System.Boolean get_IsAuthenticated()
  System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate()
  System.Boolean get_CanSeek()
  System.Boolean get_CanRead()
  System.Boolean get_CanTimeout()
  System.Boolean get_CanWrite()
  System.Int32 get_ReadTimeout()
  System.Void set_ReadTimeout(System.Int32 value)
  System.Int32 get_WriteTimeout()
  System.Void set_WriteTimeout(System.Int32 value)
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Void SetLength(System.Int64 value)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  System.Void Flush()
  System.Void CheckDisposed()
  System.Void Dispose(System.Boolean disposing)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state)
  System.Void EndWrite(System.IAsyncResult asyncResult)
END_CLASS

CLASS: System.Net.Sockets.NetworkStream
TYPE:  class
TOKEN: 0x2000237
EXTENDS: Stream
FIELDS:
  private   readonly System.Net.Sockets.Socket       _streamSocket  // 0x28
  private   readonly System.Boolean                  _ownsSocket  // 0x30
  private           System.Boolean                  _readable  // 0x31
  private           System.Boolean                  _writeable  // 0x32
  private           System.Int32                    _closeTimeout  // 0x34
  private           System.Boolean                  _cleanedUp  // 0x38
  private           System.Int32                    _currentReadTimeout  // 0x3C
  private           System.Int32                    _currentWriteTimeout  // 0x40
METHODS:
  System.Void .ctor(System.Net.Sockets.Socket socket)
  System.Void .ctor(System.Net.Sockets.Socket socket, System.Boolean ownsSocket)
  System.Void .ctor(System.Net.Sockets.Socket socket, System.IO.FileAccess access, System.Boolean ownsSocket)
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Boolean get_CanTimeout()
  System.Int32 get_ReadTimeout()
  System.Void set_ReadTimeout(System.Int32 value)
  System.Int32 get_WriteTimeout()
  System.Void set_WriteTimeout(System.Int32 value)
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Int32 Read(System.Span<System.Byte> destination)
  System.Int32 ReadByte()
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void Write(System.ReadOnlySpan<System.Byte> source)
  System.Void WriteByte(System.Byte value)
  System.Void Close(System.Int32 timeout)
  System.Void Dispose(System.Boolean disposing)
  System.Void Finalize()
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.AsyncCallback callback, System.Object state)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Void Flush()
  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  System.Void SetLength(System.Int64 value)
  System.Void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, System.Int32 timeout, System.Boolean silent)
  System.Net.Sockets.Socket get_InternalSocket()
END_CLASS

CLASS: System.Net.Sockets.Socket
TYPE:  class
TOKEN: 0x2000238
FIELDS:
  private   static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>AcceptCompletedHandler  // 0x0
  private   static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>ReceiveCompletedHandler  // 0x8
  private   static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>SendCompletedHandler  // 0x10
  private   static readonly System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket>s_rentedSocketSentinel  // 0x18
  private   static readonly System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgss_rentedInt32Sentinel  // 0x20
  private   static readonly System.Threading.Tasks.Task<System.Int32>s_zeroTask  // 0x28
  private           System.Net.Sockets.Socket.CachedEventArgs_cachedTaskEventArgs  // 0x10
  private   static  System.Object                   s_InternalSyncObject  // 0x30
  private   static  System.Boolean                  s_SupportsIPv4  // 0x38
  private   static  System.Boolean                  s_SupportsIPv6  // 0x39
  private   static  System.Boolean                  s_OSSupportsIPv6  // 0x3A
  private   static  System.Boolean                  s_Initialized  // 0x3B
  private   static  System.Boolean                  s_LoggingEnabled  // 0x3C
  private           System.Boolean                  is_closed  // 0x18
  private           System.Boolean                  is_listening  // 0x19
  private           System.Int32                    linger_timeout  // 0x1C
  private           System.Net.Sockets.AddressFamilyaddressFamily  // 0x20
  private           System.Net.Sockets.SocketType   socketType  // 0x24
  private           System.Net.Sockets.ProtocolType protocolType  // 0x28
  private           System.Net.Sockets.SafeSocketHandlem_Handle  // 0x30
  private           System.Net.EndPoint             seed_endpoint  // 0x38
  private           System.Threading.SemaphoreSlim  ReadSem  // 0x40
  private           System.Threading.SemaphoreSlim  WriteSem  // 0x48
  private           System.Boolean                  is_blocking  // 0x50
  private           System.Boolean                  is_bound  // 0x51
  private           System.Boolean                  is_connected  // 0x52
  private           System.Int32                    m_IntCleanedUp  // 0x54
  private           System.Boolean                  connect_in_progress  // 0x58
  private   static  System.AsyncCallback            AcceptAsyncCallback  // 0x40
  private   static  System.IOAsyncCallback          BeginAcceptCallback  // 0x48
  private   static  System.IOAsyncCallback          BeginAcceptReceiveCallback  // 0x50
  private   static  System.AsyncCallback            ConnectAsyncCallback  // 0x58
  private   static  System.IOAsyncCallback          BeginConnectCallback  // 0x60
  private   static  System.AsyncCallback            DisconnectAsyncCallback  // 0x68
  private   static  System.IOAsyncCallback          BeginDisconnectCallback  // 0x70
  private   static  System.AsyncCallback            ReceiveAsyncCallback  // 0x78
  private   static  System.IOAsyncCallback          BeginReceiveCallback  // 0x80
  private   static  System.IOAsyncCallback          BeginReceiveGenericCallback  // 0x88
  private   static  System.AsyncCallback            ReceiveFromAsyncCallback  // 0x90
  private   static  System.IOAsyncCallback          BeginReceiveFromCallback  // 0x98
  private   static  System.AsyncCallback            SendAsyncCallback  // 0xA0
  private   static  System.IOAsyncCallback          BeginSendGenericCallback  // 0xA8
  private   static  System.AsyncCallback            SendToAsyncCallback  // 0xB0
METHODS:
  System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, System.Int32 port)
  System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Boolean fromNetworkStream, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags)
  System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags)
  System.Void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea)
  System.Void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, System.Boolean isReceive)
  System.Exception GetException(System.Net.Sockets.SocketError error, System.Boolean wrapExceptionsInIOExceptions)
  System.Void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, System.Boolean isReceive)
  System.Void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea)
  System.Void .ctor(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType)
  System.Boolean get_OSSupportsIPv4()
  System.Boolean get_OSSupportsIPv6()
  System.IntPtr get_Handle()
  System.Net.Sockets.AddressFamily get_AddressFamily()
  System.Net.Sockets.SocketType get_SocketType()
  System.Net.Sockets.ProtocolType get_ProtocolType()
  System.Boolean get_ExclusiveAddressUse()
  System.Void set_ExclusiveAddressUse(System.Boolean value)
  System.Void set_DontFragment(System.Boolean value)
  System.Boolean get_DualMode()
  System.Void set_DualMode(System.Boolean value)
  System.Boolean get_IsDualMode()
  System.Boolean CanTryAddressFamily(System.Net.Sockets.AddressFamily family)
  System.Void Connect(System.Net.IPAddress[] addresses, System.Int32 port)
  System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags)
  System.Int32 Send(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags)
  System.Int32 Receive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags)
  System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags)
  System.Int32 IOControl(System.Net.Sockets.IOControlCode ioControlCode, System.Byte[] optionInValue, System.Byte[] optionOutValue)
  System.Void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level)
  System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.IAsyncResult BeginSend(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, System.Object state)
  System.Int32 EndSend(System.IAsyncResult asyncResult)
  System.IAsyncResult BeginReceive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, System.Object state)
  System.Int32 EndReceive(System.IAsyncResult asyncResult)
  System.Object get_InternalSyncObject()
  System.Boolean get_CleanedUp()
  System.Void InitializeSockets()
  System.Void Dispose()
  System.Void Finalize()
  System.Void InternalShutdown(System.Net.Sockets.SocketShutdown how)
  System.Void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Int32 optionValue, System.Boolean silent)
  System.Void .ctor(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle)
  System.Void SocketDefaults()
  System.IntPtr Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Int32& error)
  System.Int32 get_Available()
  System.Int32 Available_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32& error)
  System.Int32 Available_icall(System.IntPtr socket, System.Int32& error)
  System.Boolean get_IsBound()
  System.Net.EndPoint get_LocalEndPoint()
  System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 family, System.Int32& error)
  System.Net.SocketAddress LocalEndPoint_icall(System.IntPtr socket, System.Int32 family, System.Int32& error)
  System.Boolean get_Blocking()
  System.Void set_Blocking(System.Boolean value)
  System.Void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Boolean block, System.Int32& error)
  System.Void Blocking_icall(System.IntPtr socket, System.Boolean block, System.Int32& error)
  System.Boolean get_Connected()
  System.Void set_NoDelay(System.Boolean value)
  System.Net.EndPoint get_RemoteEndPoint()
  System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 family, System.Int32& error)
  System.Net.SocketAddress RemoteEndPoint_icall(System.IntPtr socket, System.Int32 family, System.Int32& error)
  System.Boolean Poll(System.Int32 microSeconds, System.Net.Sockets.SelectMode mode)
  System.Boolean Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, System.Int32 timeout, System.Int32& error)
  System.Boolean Poll_icall(System.IntPtr socket, System.Net.Sockets.SelectMode mode, System.Int32 timeout, System.Int32& error)
  System.Net.Sockets.Socket Accept()
  System.Void Accept(System.Net.Sockets.Socket acceptSocket)
  System.IAsyncResult BeginAccept(System.AsyncCallback callback, System.Object state)
  System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult)
  System.Net.Sockets.Socket EndAccept(System.Byte[]& buffer, System.Int32& bytesTransferred, System.IAsyncResult asyncResult)
  System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32& error, System.Boolean blocking)
  System.IntPtr Accept_icall(System.IntPtr sock, System.Int32& error, System.Boolean blocking)
  System.Void Bind(System.Net.EndPoint localEP)
  System.Void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, System.Int32& error)
  System.Void Bind_icall(System.IntPtr sock, System.Net.SocketAddress sa, System.Int32& error)
  System.Void Listen(System.Int32 backlog)
  System.Void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 backlog, System.Int32& error)
  System.Void Listen_icall(System.IntPtr sock, System.Int32 backlog, System.Int32& error)
  System.Void Connect(System.Net.IPAddress address, System.Int32 port)
  System.Void Connect(System.Net.EndPoint remoteEP)
  System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback callback, System.Object state)
  System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, System.Object state)
  System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.Boolean BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares)
  System.Boolean BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares)
  System.Void EndConnect(System.IAsyncResult asyncResult)
  System.Void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, System.Int32& error, System.Boolean blocking)
  System.Void Connect_icall(System.IntPtr sock, System.Net.SocketAddress sa, System.Int32& error, System.Boolean blocking)
  System.Void Disconnect(System.Boolean reuseSocket)
  System.Void EndDisconnect(System.IAsyncResult asyncResult)
  System.Void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Boolean reuse, System.Int32& error)
  System.Void Disconnect_icall(System.IntPtr sock, System.Boolean reuse, System.Int32& error)
  System.Int32 Receive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Receive(System.Memory<System.Byte> buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Receive(System.Span<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Send(System.ReadOnlySpan<System.Byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Boolean ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e)
  System.IAsyncResult BeginReceive(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode, System.AsyncCallback callback, System.Object state)
  System.Int32 EndReceive(System.IAsyncResult asyncResult, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 Receive_array_icall(System.IntPtr sock, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 Receive_icall(System.IntPtr sock, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 ReceiveFrom(System.Memory<System.Byte> buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint& remoteEP, System.Net.Sockets.SocketError& errorCode)
  System.Int32 EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares)
  System.Int32 ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Net.SocketAddress& sockaddr, System.Int32& error, System.Boolean blocking)
  System.Int32 ReceiveFrom_icall(System.IntPtr sock, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Net.SocketAddress& sockaddr, System.Int32& error, System.Boolean blocking)
  System.Int32 Send(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode)
  System.Boolean SendAsync(System.Net.Sockets.SocketAsyncEventArgs e)
  System.IAsyncResult BeginSend(System.Byte[] buffer, System.Int32 offset, System.Int32 size, System.Net.Sockets.SocketFlags socketFlags, System.Net.Sockets.SocketError& errorCode, System.AsyncCallback callback, System.Object state)
  System.Void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, System.Int32 sent_so_far)
  System.Int32 EndSend(System.IAsyncResult asyncResult, System.Net.Sockets.SocketError& errorCode)
  System.Int32 Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 Send_array_icall(System.IntPtr sock, System.Net.Sockets.Socket.WSABUF* bufarray, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 Send_icall(System.IntPtr sock, System.Byte* buffer, System.Int32 count, System.Net.Sockets.SocketFlags flags, System.Int32& error, System.Boolean blocking)
  System.Int32 EndSendTo(System.IAsyncResult asyncResult)
  System.Object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName)
  System.Void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object& obj_val, System.Int32& error)
  System.Void GetSocketOption_obj_icall(System.IntPtr socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object& obj_val, System.Int32& error)
  System.Void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Object optionValue)
  System.Void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Int32 optionValue)
  System.Void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object obj_val, System.Byte[] byte_val, System.Int32 int_val, System.Int32& error)
  System.Void SetSocketOption_icall(System.IntPtr socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, System.Object obj_val, System.Byte[] byte_val, System.Int32 int_val, System.Int32& error)
  System.Int32 IOControl(System.Int32 ioControlCode, System.Byte[] optionInValue, System.Byte[] optionOutValue)
  System.Int32 IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Int32 ioctl_code, System.Byte[] input, System.Byte[] output, System.Int32& error)
  System.Int32 IOControl_icall(System.IntPtr sock, System.Int32 ioctl_code, System.Byte[] input, System.Byte[] output, System.Int32& error)
  System.Void Close()
  System.Void Close(System.Int32 timeout)
  System.Void Close_icall(System.IntPtr socket, System.Int32& error)
  System.Void Shutdown(System.Net.Sockets.SocketShutdown how)
  System.Void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, System.Int32& error)
  System.Void Shutdown_icall(System.IntPtr socket, System.Net.Sockets.SocketShutdown how, System.Int32& error)
  System.Void Dispose(System.Boolean disposing)
  System.Void Linger(System.IntPtr handle)
  System.Void ThrowIfDisposedAndClosed()
  System.Void ThrowIfBufferNull(System.Byte[] buffer)
  System.Void ThrowIfBufferOutOfRange(System.Byte[] buffer, System.Int32 offset, System.Int32 size)
  System.Void ThrowIfUdp()
  System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, System.String methodName, System.String argName)
  System.Void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, System.IntPtr handle, System.IOSelectorJob job)
  System.Void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, System.Object state, System.Net.Sockets.SocketOperation operation)
  System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op)
  System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input)
  System.Void cancel_blocking_socket_operation(System.Threading.Thread thread)
  System.Int32 get_FamilyHint()
  System.Boolean IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface)
  System.Boolean IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Sockets.SocketException
TYPE:  class
TOKEN: 0x2000243
EXTENDS: Win32Exception
FIELDS:
  private           System.Net.EndPoint             m_EndPoint  // 0x98
METHODS:
  System.Int32 WSAGetLastError_icall()
  System.Void .ctor()
  System.Void .ctor(System.Int32 error, System.String message)
  System.Void .ctor(System.Int32 errorCode)
  System.Void .ctor(System.Net.Sockets.SocketError socketError)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.String get_Message()
  System.Net.Sockets.SocketError get_SocketErrorCode()
END_CLASS

CLASS: System.Net.Sockets.AddressFamily
TYPE:  struct
TOKEN: 0x2000244
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.AddressFamilyUnknown  // 0x0
  public    static  System.Net.Sockets.AddressFamilyUnspecified  // 0x0
  public    static  System.Net.Sockets.AddressFamilyUnix  // 0x0
  public    static  System.Net.Sockets.AddressFamilyInterNetwork  // 0x0
  public    static  System.Net.Sockets.AddressFamilyImpLink  // 0x0
  public    static  System.Net.Sockets.AddressFamilyPup  // 0x0
  public    static  System.Net.Sockets.AddressFamilyChaos  // 0x0
  public    static  System.Net.Sockets.AddressFamilyNS  // 0x0
  public    static  System.Net.Sockets.AddressFamilyIpx  // 0x0
  public    static  System.Net.Sockets.AddressFamilyIso  // 0x0
  public    static  System.Net.Sockets.AddressFamilyOsi  // 0x0
  public    static  System.Net.Sockets.AddressFamilyEcma  // 0x0
  public    static  System.Net.Sockets.AddressFamilyDataKit  // 0x0
  public    static  System.Net.Sockets.AddressFamilyCcitt  // 0x0
  public    static  System.Net.Sockets.AddressFamilySna  // 0x0
  public    static  System.Net.Sockets.AddressFamilyDecNet  // 0x0
  public    static  System.Net.Sockets.AddressFamilyDataLink  // 0x0
  public    static  System.Net.Sockets.AddressFamilyLat  // 0x0
  public    static  System.Net.Sockets.AddressFamilyHyperChannel  // 0x0
  public    static  System.Net.Sockets.AddressFamilyAppleTalk  // 0x0
  public    static  System.Net.Sockets.AddressFamilyNetBios  // 0x0
  public    static  System.Net.Sockets.AddressFamilyVoiceView  // 0x0
  public    static  System.Net.Sockets.AddressFamilyFireFox  // 0x0
  public    static  System.Net.Sockets.AddressFamilyBanyan  // 0x0
  public    static  System.Net.Sockets.AddressFamilyAtm  // 0x0
  public    static  System.Net.Sockets.AddressFamilyInterNetworkV6  // 0x0
  public    static  System.Net.Sockets.AddressFamilyCluster  // 0x0
  public    static  System.Net.Sockets.AddressFamilyIeee12844  // 0x0
  public    static  System.Net.Sockets.AddressFamilyIrda  // 0x0
  public    static  System.Net.Sockets.AddressFamilyNetworkDesigners  // 0x0
  public    static  System.Net.Sockets.AddressFamilyMax  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.IOControlCode
TYPE:  struct
TOKEN: 0x2000245
FIELDS:
  public            System.Int64                    value__  // 0x10
  public    static  System.Net.Sockets.IOControlCodeAsyncIO  // 0x0
  public    static  System.Net.Sockets.IOControlCodeNonBlockingIO  // 0x0
  public    static  System.Net.Sockets.IOControlCodeDataToRead  // 0x0
  public    static  System.Net.Sockets.IOControlCodeOobDataRead  // 0x0
  public    static  System.Net.Sockets.IOControlCodeAssociateHandle  // 0x0
  public    static  System.Net.Sockets.IOControlCodeEnableCircularQueuing  // 0x0
  public    static  System.Net.Sockets.IOControlCodeFlush  // 0x0
  public    static  System.Net.Sockets.IOControlCodeGetBroadcastAddress  // 0x0
  public    static  System.Net.Sockets.IOControlCodeGetExtensionFunctionPointer  // 0x0
  public    static  System.Net.Sockets.IOControlCodeGetQos  // 0x0
  public    static  System.Net.Sockets.IOControlCodeGetGroupQos  // 0x0
  public    static  System.Net.Sockets.IOControlCodeMultipointLoopback  // 0x0
  public    static  System.Net.Sockets.IOControlCodeMulticastScope  // 0x0
  public    static  System.Net.Sockets.IOControlCodeSetQos  // 0x0
  public    static  System.Net.Sockets.IOControlCodeSetGroupQos  // 0x0
  public    static  System.Net.Sockets.IOControlCodeTranslateHandle  // 0x0
  public    static  System.Net.Sockets.IOControlCodeRoutingInterfaceQuery  // 0x0
  public    static  System.Net.Sockets.IOControlCodeRoutingInterfaceChange  // 0x0
  public    static  System.Net.Sockets.IOControlCodeAddressListQuery  // 0x0
  public    static  System.Net.Sockets.IOControlCodeAddressListChange  // 0x0
  public    static  System.Net.Sockets.IOControlCodeQueryTargetPnpHandle  // 0x0
  public    static  System.Net.Sockets.IOControlCodeNamespaceChange  // 0x0
  public    static  System.Net.Sockets.IOControlCodeAddressListSort  // 0x0
  public    static  System.Net.Sockets.IOControlCodeReceiveAll  // 0x0
  public    static  System.Net.Sockets.IOControlCodeReceiveAllMulticast  // 0x0
  public    static  System.Net.Sockets.IOControlCodeReceiveAllIgmpMulticast  // 0x0
  public    static  System.Net.Sockets.IOControlCodeKeepAliveValues  // 0x0
  public    static  System.Net.Sockets.IOControlCodeAbsorbRouterAlert  // 0x0
  public    static  System.Net.Sockets.IOControlCodeUnicastInterface  // 0x0
  public    static  System.Net.Sockets.IOControlCodeLimitBroadcasts  // 0x0
  public    static  System.Net.Sockets.IOControlCodeBindToInterface  // 0x0
  public    static  System.Net.Sockets.IOControlCodeMulticastInterface  // 0x0
  public    static  System.Net.Sockets.IOControlCodeAddMulticastGroupOnInterface  // 0x0
  public    static  System.Net.Sockets.IOControlCodeDeleteMulticastGroupFromInterface  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.IPProtectionLevel
TYPE:  struct
TOKEN: 0x2000246
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.IPProtectionLevelUnspecified  // 0x0
  public    static  System.Net.Sockets.IPProtectionLevelUnrestricted  // 0x0
  public    static  System.Net.Sockets.IPProtectionLevelEdgeRestricted  // 0x0
  public    static  System.Net.Sockets.IPProtectionLevelRestricted  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.LingerOption
TYPE:  class
TOKEN: 0x2000247
FIELDS:
  private           System.Boolean                  enabled  // 0x10
  private           System.Int32                    lingerTime  // 0x14
METHODS:
  System.Void .ctor(System.Boolean enable, System.Int32 seconds)
  System.Void set_Enabled(System.Boolean value)
  System.Void set_LingerTime(System.Int32 value)
END_CLASS

CLASS: System.Net.Sockets.MulticastOption
TYPE:  class
TOKEN: 0x2000248
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Sockets.IPv6MulticastOption
TYPE:  class
TOKEN: 0x2000249
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Sockets.ProtocolType
TYPE:  struct
TOKEN: 0x200024A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.ProtocolType IP  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv6HopByHopOptions  // 0x0
  public    static  System.Net.Sockets.ProtocolType Icmp  // 0x0
  public    static  System.Net.Sockets.ProtocolType Igmp  // 0x0
  public    static  System.Net.Sockets.ProtocolType Ggp  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv4  // 0x0
  public    static  System.Net.Sockets.ProtocolType Tcp  // 0x0
  public    static  System.Net.Sockets.ProtocolType Pup  // 0x0
  public    static  System.Net.Sockets.ProtocolType Udp  // 0x0
  public    static  System.Net.Sockets.ProtocolType Idp  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv6  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv6RoutingHeader  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv6FragmentHeader  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPSecEncapsulatingSecurityPayload  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPSecAuthenticationHeader  // 0x0
  public    static  System.Net.Sockets.ProtocolType IcmpV6  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv6NoNextHeader  // 0x0
  public    static  System.Net.Sockets.ProtocolType IPv6DestinationOptions  // 0x0
  public    static  System.Net.Sockets.ProtocolType ND  // 0x0
  public    static  System.Net.Sockets.ProtocolType Raw  // 0x0
  public    static  System.Net.Sockets.ProtocolType Unspecified  // 0x0
  public    static  System.Net.Sockets.ProtocolType Ipx  // 0x0
  public    static  System.Net.Sockets.ProtocolType Spx  // 0x0
  public    static  System.Net.Sockets.ProtocolType SpxII  // 0x0
  public    static  System.Net.Sockets.ProtocolType Unknown  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SelectMode
TYPE:  struct
TOKEN: 0x200024B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SelectMode   SelectRead  // 0x0
  public    static  System.Net.Sockets.SelectMode   SelectWrite  // 0x0
  public    static  System.Net.Sockets.SelectMode   SelectError  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketAsyncOperation
TYPE:  struct
TOKEN: 0x200024C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketAsyncOperationNone  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationAccept  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationConnect  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationDisconnect  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationReceive  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationReceiveFrom  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationReceiveMessageFrom  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationSend  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationSendPackets  // 0x0
  public    static  System.Net.Sockets.SocketAsyncOperationSendTo  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketError
TYPE:  struct
TOKEN: 0x200024D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketError  Success  // 0x0
  public    static  System.Net.Sockets.SocketError  SocketError  // 0x0
  public    static  System.Net.Sockets.SocketError  Interrupted  // 0x0
  public    static  System.Net.Sockets.SocketError  AccessDenied  // 0x0
  public    static  System.Net.Sockets.SocketError  Fault  // 0x0
  public    static  System.Net.Sockets.SocketError  InvalidArgument  // 0x0
  public    static  System.Net.Sockets.SocketError  TooManyOpenSockets  // 0x0
  public    static  System.Net.Sockets.SocketError  WouldBlock  // 0x0
  public    static  System.Net.Sockets.SocketError  InProgress  // 0x0
  public    static  System.Net.Sockets.SocketError  AlreadyInProgress  // 0x0
  public    static  System.Net.Sockets.SocketError  NotSocket  // 0x0
  public    static  System.Net.Sockets.SocketError  DestinationAddressRequired  // 0x0
  public    static  System.Net.Sockets.SocketError  MessageSize  // 0x0
  public    static  System.Net.Sockets.SocketError  ProtocolType  // 0x0
  public    static  System.Net.Sockets.SocketError  ProtocolOption  // 0x0
  public    static  System.Net.Sockets.SocketError  ProtocolNotSupported  // 0x0
  public    static  System.Net.Sockets.SocketError  SocketNotSupported  // 0x0
  public    static  System.Net.Sockets.SocketError  OperationNotSupported  // 0x0
  public    static  System.Net.Sockets.SocketError  ProtocolFamilyNotSupported  // 0x0
  public    static  System.Net.Sockets.SocketError  AddressFamilyNotSupported  // 0x0
  public    static  System.Net.Sockets.SocketError  AddressAlreadyInUse  // 0x0
  public    static  System.Net.Sockets.SocketError  AddressNotAvailable  // 0x0
  public    static  System.Net.Sockets.SocketError  NetworkDown  // 0x0
  public    static  System.Net.Sockets.SocketError  NetworkUnreachable  // 0x0
  public    static  System.Net.Sockets.SocketError  NetworkReset  // 0x0
  public    static  System.Net.Sockets.SocketError  ConnectionAborted  // 0x0
  public    static  System.Net.Sockets.SocketError  ConnectionReset  // 0x0
  public    static  System.Net.Sockets.SocketError  NoBufferSpaceAvailable  // 0x0
  public    static  System.Net.Sockets.SocketError  IsConnected  // 0x0
  public    static  System.Net.Sockets.SocketError  NotConnected  // 0x0
  public    static  System.Net.Sockets.SocketError  Shutdown  // 0x0
  public    static  System.Net.Sockets.SocketError  TimedOut  // 0x0
  public    static  System.Net.Sockets.SocketError  ConnectionRefused  // 0x0
  public    static  System.Net.Sockets.SocketError  HostDown  // 0x0
  public    static  System.Net.Sockets.SocketError  HostUnreachable  // 0x0
  public    static  System.Net.Sockets.SocketError  ProcessLimit  // 0x0
  public    static  System.Net.Sockets.SocketError  SystemNotReady  // 0x0
  public    static  System.Net.Sockets.SocketError  VersionNotSupported  // 0x0
  public    static  System.Net.Sockets.SocketError  NotInitialized  // 0x0
  public    static  System.Net.Sockets.SocketError  Disconnecting  // 0x0
  public    static  System.Net.Sockets.SocketError  TypeNotFound  // 0x0
  public    static  System.Net.Sockets.SocketError  HostNotFound  // 0x0
  public    static  System.Net.Sockets.SocketError  TryAgain  // 0x0
  public    static  System.Net.Sockets.SocketError  NoRecovery  // 0x0
  public    static  System.Net.Sockets.SocketError  NoData  // 0x0
  public    static  System.Net.Sockets.SocketError  IOPending  // 0x0
  public    static  System.Net.Sockets.SocketError  OperationAborted  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketFlags
TYPE:  struct
TOKEN: 0x200024E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketFlags  None  // 0x0
  public    static  System.Net.Sockets.SocketFlags  OutOfBand  // 0x0
  public    static  System.Net.Sockets.SocketFlags  Peek  // 0x0
  public    static  System.Net.Sockets.SocketFlags  DontRoute  // 0x0
  public    static  System.Net.Sockets.SocketFlags  MaxIOVectorLength  // 0x0
  public    static  System.Net.Sockets.SocketFlags  Truncated  // 0x0
  public    static  System.Net.Sockets.SocketFlags  ControlDataTruncated  // 0x0
  public    static  System.Net.Sockets.SocketFlags  Broadcast  // 0x0
  public    static  System.Net.Sockets.SocketFlags  Multicast  // 0x0
  public    static  System.Net.Sockets.SocketFlags  Partial  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketOptionLevel
TYPE:  struct
TOKEN: 0x200024F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketOptionLevelSocket  // 0x0
  public    static  System.Net.Sockets.SocketOptionLevelIP  // 0x0
  public    static  System.Net.Sockets.SocketOptionLevelIPv6  // 0x0
  public    static  System.Net.Sockets.SocketOptionLevelTcp  // 0x0
  public    static  System.Net.Sockets.SocketOptionLevelUdp  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketOptionName
TYPE:  struct
TOKEN: 0x2000250
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketOptionNameDebug  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameAcceptConnection  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameReuseAddress  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameKeepAlive  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameDontRoute  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameBroadcast  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameUseLoopback  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameLinger  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameOutOfBandInline  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameDontLinger  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameExclusiveAddressUse  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameSendBuffer  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameReceiveBuffer  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameSendLowWater  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameReceiveLowWater  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameSendTimeout  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameReceiveTimeout  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameError  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameType  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameReuseUnicastPort  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameMaxConnections  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameIPOptions  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameHeaderIncluded  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameTypeOfService  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameIpTimeToLive  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameMulticastInterface  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameMulticastTimeToLive  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameMulticastLoopback  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameAddMembership  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameDropMembership  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameDontFragment  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameAddSourceMembership  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameDropSourceMembership  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameBlockSource  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameUnblockSource  // 0x0
  public    static  System.Net.Sockets.SocketOptionNamePacketInformation  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameHopLimit  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameIPProtectionLevel  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameIPv6Only  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameNoDelay  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameBsdUrgent  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameExpedited  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameNoChecksum  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameChecksumCoverage  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameUpdateAcceptContext  // 0x0
  public    static  System.Net.Sockets.SocketOptionNameUpdateConnectContext  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketShutdown
TYPE:  struct
TOKEN: 0x2000251
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketShutdownReceive  // 0x0
  public    static  System.Net.Sockets.SocketShutdownSend  // 0x0
  public    static  System.Net.Sockets.SocketShutdownBoth  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.SocketType
TYPE:  struct
TOKEN: 0x2000252
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketType   Stream  // 0x0
  public    static  System.Net.Sockets.SocketType   Dgram  // 0x0
  public    static  System.Net.Sockets.SocketType   Raw  // 0x0
  public    static  System.Net.Sockets.SocketType   Rdm  // 0x0
  public    static  System.Net.Sockets.SocketType   Seqpacket  // 0x0
  public    static  System.Net.Sockets.SocketType   Unknown  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Sockets.TcpClient
TYPE:  class
TOKEN: 0x2000253
FIELDS:
  private           System.Net.Sockets.Socket       m_ClientSocket  // 0x10
  private           System.Boolean                  m_Active  // 0x18
  private           System.Net.Sockets.NetworkStreamm_DataStream  // 0x20
  private           System.Net.Sockets.AddressFamilym_Family  // 0x28
  private           System.Boolean                  m_CleanedUp  // 0x2C
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Net.Sockets.AddressFamily family)
  System.Net.Sockets.Socket get_Client()
  System.Void set_Client(System.Net.Sockets.Socket value)
  System.Boolean get_Connected()
  System.Void Connect(System.String hostname, System.Int32 port)
  System.Void Connect(System.Net.IPEndPoint remoteEP)
  System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.Void EndConnect(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task ConnectAsync(System.String host, System.Int32 port)
  System.Net.Sockets.NetworkStream GetStream()
  System.Void Close()
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Void Finalize()
  System.Void set_ReceiveTimeout(System.Int32 value)
  System.Void set_SendTimeout(System.Int32 value)
  System.Void set_NoDelay(System.Boolean value)
  System.Void initialize()
END_CLASS

CLASS: System.Net.Sockets.SafeSocketHandle
TYPE:  class
TOKEN: 0x2000254
EXTENDS: SafeHandleMinusOneIsInvalid
FIELDS:
  private           System.Collections.Generic.List<System.Threading.Thread>blocking_threads  // 0x20
  private           System.Collections.Generic.Dictionary<System.Threading.Thread,System.Diagnostics.StackTrace>threads_stacktraces  // 0x28
  private           System.Boolean                  in_cleanup  // 0x30
  private   static  System.Boolean                  THROW_ON_ABORT_RETRIES  // 0x0
METHODS:
  System.Void .ctor(System.IntPtr preexistingHandle, System.Boolean ownsHandle)
  System.Boolean ReleaseHandle()
  System.Void RegisterForBlockingSyscall()
  System.Void UnRegisterForBlockingSyscall()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Sockets.SocketAsyncEventArgs
TYPE:  class
TOKEN: 0x2000255
EXTENDS: EventArgs
FIELDS:
  private           System.Boolean                  disposed  // 0x10
  private           System.Int32                    in_progress  // 0x14
  private           System.Net.EndPoint             remote_ep  // 0x18
  private           System.Net.Sockets.Socket       current_socket  // 0x20
  private           System.Net.Sockets.SocketAsyncResultsocket_async_result  // 0x28
  private           System.Net.Sockets.Socket       <AcceptSocket>k__BackingField  // 0x30
  private           System.Int32                    <BytesTransferred>k__BackingField  // 0x38
  private           System.Net.Sockets.SocketAsyncOperation<LastOperation>k__BackingField  // 0x3C
  private           System.Net.Sockets.SocketError  <SocketError>k__BackingField  // 0x40
  private           System.Net.Sockets.SocketFlags  <SocketFlags>k__BackingField  // 0x44
  private           System.Object                   <UserToken>k__BackingField  // 0x48
  private           System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>Completed  // 0x50
  private           System.Memory<System.Byte>      _buffer  // 0x58
  private           System.Int32                    _offset  // 0x68
  private           System.Int32                    _count  // 0x6C
  private           System.Boolean                  _bufferIsExplicitArray  // 0x70
  private           System.Collections.Generic.IList<System.ArraySegment<System.Byte>>_bufferList  // 0x78
METHODS:
  System.Net.Sockets.Socket get_AcceptSocket()
  System.Void set_AcceptSocket(System.Net.Sockets.Socket value)
  System.Int32 get_BytesTransferred()
  System.Void set_BytesTransferred(System.Int32 value)
  System.Void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value)
  System.Void set_RemoteEndPoint(System.Net.EndPoint value)
  System.Net.Sockets.SocketError get_SocketError()
  System.Void set_SocketError(System.Net.Sockets.SocketError value)
  System.Void set_SocketFlags(System.Net.Sockets.SocketFlags value)
  System.Object get_UserToken()
  System.Void set_UserToken(System.Object value)
  System.Void .ctor(System.Boolean flowExecutionContext)
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Void SetBytesTransferred(System.Int32 value)
  System.Net.Sockets.Socket get_CurrentSocket()
  System.Void SetCurrentSocket(System.Net.Sockets.Socket socket)
  System.Void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op)
  System.Void Complete_internal()
  System.Void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e)
  System.Memory<System.Byte> get_MemoryBuffer()
  System.Int32 get_Offset()
  System.Int32 get_Count()
  System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList()
  System.Void SetBuffer(System.Memory<System.Byte> buffer)
END_CLASS

CLASS: System.Net.Sockets.SocketAsyncResult
TYPE:  class
TOKEN: 0x2000256
EXTENDS: IOAsyncResult
FIELDS:
  public            System.Net.Sockets.Socket       socket  // 0x30
  public            System.Net.Sockets.SocketOperationoperation  // 0x38
  private           System.Exception                DelayedException  // 0x40
  public            System.Net.EndPoint             EndPoint  // 0x48
  public            System.Memory<System.Byte>      Buffer  // 0x50
  public            System.Int32                    Offset  // 0x60
  public            System.Int32                    Size  // 0x64
  public            System.Net.Sockets.SocketFlags  SockFlags  // 0x68
  public            System.Net.Sockets.Socket       AcceptSocket  // 0x70
  public            System.Net.IPAddress[]          Addresses  // 0x78
  public            System.Int32                    Port  // 0x80
  public            System.Collections.Generic.IList<System.ArraySegment<System.Byte>>Buffers  // 0x88
  public            System.Boolean                  ReuseSocket  // 0x90
  public            System.Int32                    CurrentAddress  // 0x94
  public            System.Net.Sockets.Socket       AcceptedSocket  // 0x98
  public            System.Int32                    Total  // 0xA0
  private           System.Int32                    error  // 0xA4
  public            System.Int32                    EndCalled  // 0xA8
METHODS:
  System.IntPtr get_Handle()
  System.Void .ctor()
  System.Void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, System.Object state, System.Net.Sockets.SocketOperation operation)
  System.Void .ctor(System.Net.Sockets.Socket socket, System.AsyncCallback callback, System.Object state, System.Net.Sockets.SocketOperation operation)
  System.Net.Sockets.SocketError get_ErrorCode()
  System.Void CheckIfThrowDelayedException()
  System.Void CompleteDisposed()
  System.Void Complete()
  System.Void Complete(System.Boolean synch)
  System.Void Complete(System.Int32 total)
  System.Void Complete(System.Exception e, System.Boolean synch)
  System.Void Complete(System.Exception e)
  System.Void Complete(System.Net.Sockets.Socket s)
  System.Void Complete(System.Net.Sockets.Socket s, System.Int32 total)
END_CLASS

CLASS: System.Net.Sockets.SocketOperation
TYPE:  struct
TOKEN: 0x2000258
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Sockets.SocketOperationAccept  // 0x0
  public    static  System.Net.Sockets.SocketOperationConnect  // 0x0
  public    static  System.Net.Sockets.SocketOperationReceive  // 0x0
  public    static  System.Net.Sockets.SocketOperationReceiveFrom  // 0x0
  public    static  System.Net.Sockets.SocketOperationSend  // 0x0
  public    static  System.Net.Sockets.SocketOperationSendTo  // 0x0
  public    static  System.Net.Sockets.SocketOperationRecvJustCallback  // 0x0
  public    static  System.Net.Sockets.SocketOperationSendJustCallback  // 0x0
  public    static  System.Net.Sockets.SocketOperationDisconnect  // 0x0
  public    static  System.Net.Sockets.SocketOperationAcceptReceive  // 0x0
  public    static  System.Net.Sockets.SocketOperationReceiveGeneric  // 0x0
  public    static  System.Net.Sockets.SocketOperationSendGeneric  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebSockets.ManagedWebSocket
TYPE:  class
TOKEN: 0x2000259
EXTENDS: WebSocket
FIELDS:
  private   static readonly System.Security.Cryptography.RandomNumberGenerators_random  // 0x0
  private   static readonly System.Text.UTF8Encoding        s_textEncoding  // 0x8
  private   static readonly System.Net.WebSockets.WebSocketState[]s_validSendStates  // 0x10
  private   static readonly System.Net.WebSockets.WebSocketState[]s_validReceiveStates  // 0x18
  private   static readonly System.Net.WebSockets.WebSocketState[]s_validCloseOutputStates  // 0x20
  private   static readonly System.Net.WebSockets.WebSocketState[]s_validCloseStates  // 0x28
  private   static readonly System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult>s_cachedCloseTask  // 0x30
  private   readonly System.IO.Stream                _stream  // 0x10
  private   readonly System.Boolean                  _isServer  // 0x18
  private   readonly System.String                   _subprotocol  // 0x20
  private   readonly System.Threading.Timer          _keepAliveTimer  // 0x28
  private   readonly System.Threading.CancellationTokenSource_abortSource  // 0x30
  private           System.Memory<System.Byte>      _receiveBuffer  // 0x38
  private   readonly System.Net.WebSockets.ManagedWebSocket.Utf8MessageState_utf8TextState  // 0x48
  private   readonly System.Threading.SemaphoreSlim  _sendFrameAsyncLock  // 0x50
  private           System.Net.WebSockets.WebSocketState_state  // 0x58
  private           System.Boolean                  _disposed  // 0x5C
  private           System.Boolean                  _sentCloseFrame  // 0x5D
  private           System.Boolean                  _receivedCloseFrame  // 0x5E
  private           System.Nullable<System.Net.WebSockets.WebSocketCloseStatus>_closeStatus  // 0x60
  private           System.String                   _closeStatusDescription  // 0x68
  private           System.Net.WebSockets.ManagedWebSocket.MessageHeader_lastReceiveHeader  // 0x70
  private           System.Int32                    _receiveBufferOffset  // 0x88
  private           System.Int32                    _receiveBufferCount  // 0x8C
  private           System.Int32                    _receivedMaskOffsetOffset  // 0x90
  private           System.Byte[]                   _sendBuffer  // 0x98
  private           System.Boolean                  _lastSendWasFragment  // 0xA0
  private           System.Threading.Tasks.Task     _lastReceiveAsync  // 0xA8
METHODS:
  System.Net.WebSockets.ManagedWebSocket CreateFromConnectedStream(System.IO.Stream stream, System.Boolean isServer, System.String subprotocol, System.TimeSpan keepAliveInterval)
  System.Object get_StateUpdateLock()
  System.Object get_ReceiveAsyncLock()
  System.Void .ctor(System.IO.Stream stream, System.Boolean isServer, System.String subprotocol, System.TimeSpan keepAliveInterval)
  System.Void Dispose()
  System.Void DisposeCore()
  System.Net.WebSockets.WebSocketState get_State()
  System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask SendPrivateAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken)
  System.Void Abort()
  System.Threading.Tasks.ValueTask SendFrameAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlyMemory<System.Byte> payloadBuffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask SendFrameLockAcquiredNonCancelableAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlyMemory<System.Byte> payloadBuffer)
  System.Threading.Tasks.Task WaitForWriteTaskAsync(System.Threading.Tasks.ValueTask writeTask)
  System.Threading.Tasks.Task SendFrameFallbackAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlyMemory<System.Byte> payloadBuffer, System.Threading.CancellationToken cancellationToken)
  System.Int32 WriteFrameToSendBuffer(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Boolean endOfMessage, System.ReadOnlySpan<System.Byte> payloadBuffer)
  System.Void SendKeepAliveFrameAsync()
  System.Int32 WriteHeader(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, System.Byte[] sendBuffer, System.ReadOnlySpan<System.Byte> payload, System.Boolean endOfMessage, System.Boolean useMask)
  System.Void WriteRandomMask(System.Byte[] buffer, System.Int32 offset)
  System.Threading.Tasks.ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate(System.Memory<System.Byte> payloadBuffer, System.Threading.CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter)
  System.Threading.Tasks.Task HandleReceivedCloseAsync(System.Net.WebSockets.ManagedWebSocket.MessageHeader header, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WaitForServerToCloseConnectionAsync(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task HandleReceivedPingPongAsync(System.Net.WebSockets.ManagedWebSocket.MessageHeader header, System.Threading.CancellationToken cancellationToken)
  System.Boolean IsValidCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus)
  System.Threading.Tasks.Task CloseWithReceiveErrorAndThrowAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.Net.WebSockets.WebSocketError error, System.Exception innerException)
  System.Boolean TryParseMessageHeaderFromReceiveBuffer(System.Net.WebSockets.ManagedWebSocket.MessageHeader& resultHeader)
  System.Threading.Tasks.Task SendCloseFrameAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String closeStatusDescription, System.Threading.CancellationToken cancellationToken)
  System.Void ConsumeFromBuffer(System.Int32 count)
  System.Threading.Tasks.Task EnsureBufferContainsAsync(System.Int32 minimumRequiredBytes, System.Threading.CancellationToken cancellationToken, System.Boolean throwOnPrematureClosure)
  System.Void ThrowIfEOFUnexpected(System.Boolean throwOnPrematureClosure)
  System.Void AllocateSendBuffer(System.Int32 minLength)
  System.Void ReleaseSendBuffer()
  System.Int32 CombineMaskBytes(System.Span<System.Byte> buffer, System.Int32 maskOffset)
  System.Int32 ApplyMask(System.Span<System.Byte> toMask, System.Byte[] mask, System.Int32 maskOffset, System.Int32 maskOffsetIndex)
  System.Int32 ApplyMask(System.Span<System.Byte> toMask, System.Int32 mask, System.Int32 maskIndex)
  System.Void ThrowIfOperationInProgress(System.Boolean operationCompleted, System.String methodName)
  System.Void ThrowOperationInProgress(System.String methodName)
  System.Exception CreateOperationCanceledException(System.Exception innerException, System.Threading.CancellationToken cancellationToken)
  System.Boolean TryValidateUtf8(System.Span<System.Byte> span, System.Boolean endOfMessage, System.Net.WebSockets.ManagedWebSocket.Utf8MessageState state)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.WebSockets.WebSocketValidate
TYPE:  class
TOKEN: 0x200026A
FIELDS:
METHODS:
  System.Void ThrowIfInvalidState(System.Net.WebSockets.WebSocketState currentState, System.Boolean isDisposed, System.Net.WebSockets.WebSocketState[] validStates)
  System.Void ValidateSubprotocol(System.String subProtocol)
  System.Void ValidateCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription)
  System.Void ValidateArraySegment(System.ArraySegment<System.Byte> arraySegment, System.String parameterName)
END_CLASS

CLASS: System.Net.WebSockets.ClientWebSocket
TYPE:  class
TOKEN: 0x200026B
EXTENDS: WebSocket
FIELDS:
  private   readonly System.Net.WebSockets.ClientWebSocketOptions_options  // 0x10
  private           System.Net.WebSockets.WebSocketHandle_innerWebSocket  // 0x18
  private           System.Int32                    _state  // 0x20
METHODS:
  System.Void .ctor()
  System.Net.WebSockets.ClientWebSocketOptions get_Options()
  System.Net.WebSockets.WebSocketState get_State()
  System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken)
  System.Void Abort()
  System.Void Dispose()
  System.Void ThrowIfNotConnected()
END_CLASS

CLASS: System.Net.WebSockets.ClientWebSocketOptions
TYPE:  class
TOKEN: 0x200026F
FIELDS:
  private           System.Boolean                  _isReadOnly  // 0x10
  private   readonly System.Collections.Generic.List<System.String>_requestedSubProtocols  // 0x18
  private   readonly System.Net.WebHeaderCollection  _requestHeaders  // 0x20
  private           System.TimeSpan                 _keepAliveInterval  // 0x28
  private           System.Boolean                  _useDefaultCredentials  // 0x30
  private           System.Net.ICredentials         _credentials  // 0x38
  private           System.Net.IWebProxy            _proxy  // 0x40
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollection_clientCertificates  // 0x48
  private           System.Net.CookieContainer      _cookies  // 0x50
  private           System.Int32                    _receiveBufferSize  // 0x58
  private           System.Int32                    _sendBufferSize  // 0x5C
  private           System.Nullable<System.ArraySegment<System.Byte>>_buffer  // 0x60
  private           System.Net.Security.RemoteCertificateValidationCallback_remoteCertificateValidationCallback  // 0x78
METHODS:
  System.Void .ctor()
  System.Net.WebHeaderCollection get_RequestHeaders()
  System.Collections.Generic.List<System.String> get_RequestedSubProtocols()
  System.Void set_Proxy(System.Net.IWebProxy value)
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Net.CookieContainer get_Cookies()
  System.Void AddSubProtocol(System.String subProtocol)
  System.TimeSpan get_KeepAliveInterval()
  System.Int32 get_ReceiveBufferSize()
  System.Int32 get_SendBufferSize()
  System.Nullable<System.ArraySegment<System.Byte>> get_Buffer()
  System.Void SetToReadOnly()
  System.Void ThrowIfReadOnly()
END_CLASS

CLASS: System.Net.WebSockets.WebSocketHandle
TYPE:  class
TOKEN: 0x2000270
FIELDS:
  private   static  System.Text.StringBuilder       t_cachedStringBuilder  // 0xFFFFFFFF
  private   static readonly System.Text.Encoding            s_defaultHttpEncoding  // 0x0
  private   static  System.Int32                    DefaultReceiveBufferSize  // 0x0
  private   static  System.String                   WSServerGuid  // 0x0
  private   readonly System.Threading.CancellationTokenSource_abortSource  // 0x10
  private           System.Net.WebSockets.WebSocketState_state  // 0x18
  private           System.Net.WebSockets.WebSocket _webSocket  // 0x20
METHODS:
  System.Net.WebSockets.WebSocketHandle Create()
  System.Boolean IsValid(System.Net.WebSockets.WebSocketHandle handle)
  System.Net.WebSockets.WebSocketState get_State()
  System.Void CheckPlatformSupport()
  System.Void Dispose()
  System.Void Abort()
  System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, System.Threading.CancellationToken cancellationToken, System.Net.WebSockets.ClientWebSocketOptions options)
  System.Threading.Tasks.Task<System.Net.Sockets.Socket> ConnectSocketAsync(System.String host, System.Int32 port, System.Threading.CancellationToken cancellationToken)
  System.Byte[] BuildRequestHeader(System.Uri uri, System.Net.WebSockets.ClientWebSocketOptions options, System.String secKey)
  System.Collections.Generic.KeyValuePair<System.String,System.String> CreateSecKeyAndSecWebSocketAccept()
  System.Threading.Tasks.Task<System.String> ParseAndValidateConnectResponseAsync(System.IO.Stream stream, System.Net.WebSockets.ClientWebSocketOptions options, System.String expectedSecWebSocketAccept, System.Threading.CancellationToken cancellationToken)
  System.Void ValidateAndTrackHeader(System.String targetHeaderName, System.String targetHeaderValue, System.String foundHeaderName, System.String foundHeaderValue, System.Boolean& foundHeader)
  System.Threading.Tasks.Task<System.String> ReadResponseHeaderLineAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.WebSockets.WebSocket
TYPE:  class
TOKEN: 0x2000277
FIELDS:
METHODS:
  System.Net.WebSockets.WebSocketState get_State()
  System.Void Abort()
  System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.String statusDescription, System.Threading.CancellationToken cancellationToken)
  System.Void Dispose()
  System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task SendAsync(System.ArraySegment<System.Byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Threading.CancellationToken cancellationToken)
  System.TimeSpan get_DefaultKeepAliveInterval()
  System.Net.WebSockets.WebSocket CreateClientWebSocket(System.IO.Stream innerStream, System.String subProtocol, System.Int32 receiveBufferSize, System.Int32 sendBufferSize, System.TimeSpan keepAliveInterval, System.Boolean useZeroMaskingKey, System.ArraySegment<System.Byte> internalBuffer)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.WebSockets.WebSocketCloseStatus
TYPE:  struct
TOKEN: 0x2000278
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebSockets.WebSocketCloseStatusNormalClosure  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusEndpointUnavailable  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusProtocolError  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusInvalidMessageType  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusEmpty  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusInvalidPayloadData  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusPolicyViolation  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusMessageTooBig  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusMandatoryExtension  // 0x0
  public    static  System.Net.WebSockets.WebSocketCloseStatusInternalServerError  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebSockets.WebSocketError
TYPE:  struct
TOKEN: 0x2000279
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebSockets.WebSocketErrorSuccess  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorInvalidMessageType  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorFaulted  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorNativeError  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorNotAWebSocket  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorUnsupportedVersion  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorUnsupportedProtocol  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorHeaderError  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorConnectionClosedPrematurely  // 0x0
  public    static  System.Net.WebSockets.WebSocketErrorInvalidState  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebSockets.WebSocketException
TYPE:  class
TOKEN: 0x200027A
EXTENDS: Win32Exception
FIELDS:
  private   readonly System.Net.WebSockets.WebSocketError_webSocketErrorCode  // 0x98
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Net.WebSockets.WebSocketError error)
  System.Void .ctor(System.Net.WebSockets.WebSocketError error, System.String message)
  System.Void .ctor(System.Net.WebSockets.WebSocketError error, System.Exception innerException)
  System.Void .ctor(System.Net.WebSockets.WebSocketError error, System.String message, System.Exception innerException)
  System.Void .ctor(System.Int32 nativeError)
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.String GetErrorMessage(System.Net.WebSockets.WebSocketError error)
  System.Void SetErrorCodeOnError(System.Int32 nativeError)
  System.Boolean Succeeded(System.Int32 hr)
END_CLASS

CLASS: System.Net.WebSockets.WebSocketMessageType
TYPE:  struct
TOKEN: 0x200027B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebSockets.WebSocketMessageTypeText  // 0x0
  public    static  System.Net.WebSockets.WebSocketMessageTypeBinary  // 0x0
  public    static  System.Net.WebSockets.WebSocketMessageTypeClose  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.WebSockets.WebSocketReceiveResult
TYPE:  class
TOKEN: 0x200027C
FIELDS:
  private   readonly System.Int32                    <Count>k__BackingField  // 0x10
  private   readonly System.Boolean                  <EndOfMessage>k__BackingField  // 0x14
  private   readonly System.Net.WebSockets.WebSocketMessageType<MessageType>k__BackingField  // 0x18
  private   readonly System.Nullable<System.Net.WebSockets.WebSocketCloseStatus><CloseStatus>k__BackingField  // 0x1C
  private   readonly System.String                   <CloseStatusDescription>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage)
  System.Void .ctor(System.Int32 count, System.Net.WebSockets.WebSocketMessageType messageType, System.Boolean endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, System.String closeStatusDescription)
  System.Int32 get_Count()
  System.Boolean get_EndOfMessage()
  System.Net.WebSockets.WebSocketMessageType get_MessageType()
  System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> get_CloseStatus()
  System.String get_CloseStatusDescription()
END_CLASS

CLASS: System.Net.WebSockets.WebSocketState
TYPE:  struct
TOKEN: 0x200027D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.WebSockets.WebSocketStateNone  // 0x0
  public    static  System.Net.WebSockets.WebSocketStateConnecting  // 0x0
  public    static  System.Net.WebSockets.WebSocketStateOpen  // 0x0
  public    static  System.Net.WebSockets.WebSocketStateCloseSent  // 0x0
  public    static  System.Net.WebSockets.WebSocketStateCloseReceived  // 0x0
  public    static  System.Net.WebSockets.WebSocketStateClosed  // 0x0
  public    static  System.Net.WebSockets.WebSocketStateAborted  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Authentication.AuthenticationException
TYPE:  class
TOKEN: 0x200010B
EXTENDS: SystemException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
END_CLASS

CLASS: System.Security.Authentication.SslProtocols
TYPE:  struct
TOKEN: 0x200010C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Authentication.SslProtocolsNone  // 0x0
  public    static  System.Security.Authentication.SslProtocolsSsl2  // 0x0
  public    static  System.Security.Authentication.SslProtocolsSsl3  // 0x0
  public    static  System.Security.Authentication.SslProtocolsTls  // 0x0
  public    static  System.Security.Authentication.SslProtocolsTls11  // 0x0
  public    static  System.Security.Authentication.SslProtocolsTls12  // 0x0
  public    static  System.Security.Authentication.SslProtocolsTls13  // 0x0
  public    static  System.Security.Authentication.SslProtocolsDefault  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.DerSequenceReader
TYPE:  class
TOKEN: 0x200010D
FIELDS:
  private   static  System.Globalization.DateTimeFormatInfos_validityDateTimeFormatInfo  // 0x0
  private   static  System.Text.Encoding            s_utf8EncodingWithExceptionFallback  // 0x8
  private   static  System.Text.Encoding            s_latin1Encoding  // 0x10
  private   readonly System.Byte[]                   _data  // 0x10
  private   readonly System.Int32                    _end  // 0x18
  private           System.Int32                    _position  // 0x1C
  private           System.Int32                    <ContentLength>k__BackingField  // 0x20
METHODS:
  System.Void set_ContentLength(System.Int32 value)
  System.Void .ctor(System.Byte[] data)
  System.Void .ctor(System.Byte[] data, System.Int32 offset, System.Int32 length)
  System.Void .ctor(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, System.Byte[] data, System.Int32 offset, System.Int32 length)
  System.Boolean get_HasData()
  System.Byte PeekTag()
  System.Void SkipValue()
  System.Byte[] ReadNextEncodedValue()
  System.Boolean ReadBoolean()
  System.Int32 ReadInteger()
  System.Byte[] ReadIntegerBytes()
  System.Byte[] ReadBitString()
  System.Byte[] ReadOctetString()
  System.String ReadOidAsString()
  System.String ReadUtf8String()
  System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected)
  System.Security.Cryptography.DerSequenceReader ReadSequence()
  System.Security.Cryptography.DerSequenceReader ReadSet()
  System.String ReadPrintableString()
  System.String ReadIA5String()
  System.String ReadT61String()
  System.DateTime ReadX509Date()
  System.DateTime ReadUtcTime()
  System.DateTime ReadGeneralizedTime()
  System.String ReadBMPString()
  System.String TrimTrailingNulls(System.String value)
  System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, System.String formatString)
  System.Byte[] ReadContentAsBytes()
  System.Void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected)
  System.Void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, System.Byte[] data, System.Int32 position)
  System.Int32 EatLength()
  System.Int32 ScanContentLength(System.Byte[] data, System.Int32 offset, System.Int32 end, System.Int32& bytesConsumed)
END_CLASS

CLASS: System.Security.Cryptography.Oid
TYPE:  class
TOKEN: 0x2000110
FIELDS:
  private           System.String                   _value  // 0x10
  private           System.String                   _friendlyName  // 0x18
  private           System.Security.Cryptography.OidGroup_group  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String oid)
  System.Void .ctor(System.String value, System.String friendlyName)
  System.Void .ctor(System.Security.Cryptography.Oid oid)
  System.Security.Cryptography.Oid FromOidValue(System.String oidValue, System.Security.Cryptography.OidGroup group)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.String get_FriendlyName()
  System.Void .ctor(System.String value, System.String friendlyName, System.Security.Cryptography.OidGroup group)
END_CLASS

CLASS: System.Security.Cryptography.OidCollection
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private   readonly System.Collections.Generic.List<System.Security.Cryptography.Oid>_list  // 0x10
METHODS:
  System.Void .ctor()
  System.Int32 Add(System.Security.Cryptography.Oid oid)
  System.Security.Cryptography.Oid get_Item(System.Int32 index)
  System.Int32 get_Count()
  System.Security.Cryptography.OidEnumerator GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
END_CLASS

CLASS: System.Security.Cryptography.OidEnumerator
TYPE:  class
TOKEN: 0x2000112
FIELDS:
  private   readonly System.Security.Cryptography.OidCollection_oids  // 0x10
  private           System.Int32                    _current  // 0x18
METHODS:
  System.Void .ctor(System.Security.Cryptography.OidCollection oids)
  System.Security.Cryptography.Oid get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: System.Security.Cryptography.OidGroup
TYPE:  struct
TOKEN: 0x2000113
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.OidGroupAll  // 0x0
  public    static  System.Security.Cryptography.OidGroupHashAlgorithm  // 0x0
  public    static  System.Security.Cryptography.OidGroupEncryptionAlgorithm  // 0x0
  public    static  System.Security.Cryptography.OidGroupPublicKeyAlgorithm  // 0x0
  public    static  System.Security.Cryptography.OidGroupSignatureAlgorithm  // 0x0
  public    static  System.Security.Cryptography.OidGroupAttribute  // 0x0
  public    static  System.Security.Cryptography.OidGroupExtensionOrAttribute  // 0x0
  public    static  System.Security.Cryptography.OidGroupEnhancedKeyUsage  // 0x0
  public    static  System.Security.Cryptography.OidGroupPolicy  // 0x0
  public    static  System.Security.Cryptography.OidGroupTemplate  // 0x0
  public    static  System.Security.Cryptography.OidGroupKeyDerivationFunction  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.AsnDecodeStatus
TYPE:  struct
TOKEN: 0x2000114
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.AsnDecodeStatusNotDecoded  // 0x0
  public    static  System.Security.Cryptography.AsnDecodeStatusOk  // 0x0
  public    static  System.Security.Cryptography.AsnDecodeStatusBadAsn  // 0x0
  public    static  System.Security.Cryptography.AsnDecodeStatusBadTag  // 0x0
  public    static  System.Security.Cryptography.AsnDecodeStatusBadLength  // 0x0
  public    static  System.Security.Cryptography.AsnDecodeStatusInformationNotAvailable  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.AsnEncodedData
TYPE:  class
TOKEN: 0x2000115
FIELDS:
  private           System.Security.Cryptography.Oid_oid  // 0x10
  private           System.Byte[]                   _raw  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String oid, System.Byte[] rawData)
  System.Void .ctor(System.Security.Cryptography.Oid oid, System.Byte[] rawData)
  System.Void .ctor(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.Security.Cryptography.Oid get_Oid()
  System.Void set_Oid(System.Security.Cryptography.Oid value)
  System.Byte[] get_RawData()
  System.Void set_RawData(System.Byte[] value)
  System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.String Format(System.Boolean multiLine)
  System.String ToString(System.Boolean multiLine)
  System.String Default(System.Boolean multiLine)
  System.String BasicConstraintsExtension(System.Boolean multiLine)
  System.String EnhancedKeyUsageExtension(System.Boolean multiLine)
  System.String KeyUsageExtension(System.Boolean multiLine)
  System.String SubjectKeyIdentifierExtension(System.Boolean multiLine)
  System.String SubjectAltName(System.Boolean multiLine)
  System.String NetscapeCertType(System.Boolean multiLine)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.OpenFlags
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.OpenFlagsReadOnly  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.OpenFlagsReadWrite  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.OpenFlagsMaxAllowed  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.OpenFlagsOpenExistingOnly  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.OpenFlagsIncludeArchived  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.StoreLocation
TYPE:  struct
TOKEN: 0x2000117
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.StoreLocationCurrentUser  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreLocationLocalMachine  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.StoreName
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.StoreNameAddressBook  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameAuthRoot  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameCertificateAuthority  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameDisallowed  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameMy  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameRoot  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameTrustedPeople  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.StoreNameTrustedPublisher  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags
TYPE:  struct
TOKEN: 0x2000119
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsNone  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsReversed  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsUseSemicolons  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsDoNotUsePlusSign  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsDoNotUseQuotes  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsUseCommas  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsUseNewLines  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsUseUTF8Encoding  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsUseT61Encoding  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlagsForceUTF8Encoding  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainStatusFlags
TYPE:  struct
TOKEN: 0x200011A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsNoError  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsNotTimeValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsNotTimeNested  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsRevoked  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsNotSignatureValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsNotValidForUsage  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsUntrustedRoot  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsRevocationStatusUnknown  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsCyclic  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsInvalidExtension  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsInvalidPolicyConstraints  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsInvalidBasicConstraints  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsInvalidNameConstraints  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsHasNotSupportedNameConstraint  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsHasNotDefinedNameConstraint  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsHasNotPermittedNameConstraint  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsHasExcludedNameConstraint  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsPartialChain  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsCtlNotTimeValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsCtlNotSignatureValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsCtlNotValidForUsage  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsOfflineRevocation  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsNoIssuanceChainPolicy  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsExplicitDistrust  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsHasNotSupportedCriticalExtension  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsHasWeakSignature  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509FindType
TYPE:  struct
TOKEN: 0x200011B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByThumbprint  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindBySubjectName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindBySubjectDistinguishedName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByIssuerName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByIssuerDistinguishedName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindBySerialNumber  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByTimeValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByTimeNotYetValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByTimeExpired  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByTemplateName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByApplicationPolicy  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByCertificatePolicy  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByExtension  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindByKeyUsage  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509FindTypeFindBySubjectKeyIdentifier  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509KeyUsageFlags
TYPE:  struct
TOKEN: 0x200011C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsNone  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsEncipherOnly  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsCrlSign  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsKeyCertSign  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsKeyAgreement  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsDataEncipherment  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsKeyEncipherment  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsNonRepudiation  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsDigitalSignature  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsDecipherOnly  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509NameType
TYPE:  struct
TOKEN: 0x200011D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509NameTypeSimpleName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509NameTypeEmailName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509NameTypeUpnName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509NameTypeDnsName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509NameTypeDnsFromAlternativeName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509NameTypeUrlName  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509RevocationFlag
TYPE:  struct
TOKEN: 0x200011E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509RevocationFlagEndCertificateOnly  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509RevocationFlagEntireChain  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509RevocationFlagExcludeRoot  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509RevocationMode
TYPE:  struct
TOKEN: 0x200011F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509RevocationModeNoCheck  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509RevocationModeOnline  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509RevocationModeOffline  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm
TYPE:  struct
TOKEN: 0x2000120
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithmSha1  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithmShortSha1  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithmCapiSha1  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509VerificationFlags
TYPE:  struct
TOKEN: 0x2000121
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsNoFlag  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreNotTimeValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreCtlNotTimeValid  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreNotTimeNested  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreInvalidBasicConstraints  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsAllowUnknownCertificateAuthority  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreWrongUsage  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreInvalidName  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreInvalidPolicy  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreEndRevocationUnknown  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreCtlSignerRevocationUnknown  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreCertificateAuthorityRevocationUnknown  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsIgnoreRootRevocationUnknown  // 0x0
  public    static  System.Security.Cryptography.X509Certificates.X509VerificationFlagsAllFlags  // 0x0
METHODS:
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.PublicKey
TYPE:  class
TOKEN: 0x2000122
FIELDS:
  private           System.Security.Cryptography.AsnEncodedData_keyValue  // 0x10
  private           System.Security.Cryptography.AsnEncodedData_params  // 0x18
  private           System.Security.Cryptography.Oid_oid  // 0x20
  private   static  System.Byte[]                   Empty  // 0x0
METHODS:
  System.Void .ctor(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue)
  System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue()
  System.Security.Cryptography.AsnEncodedData get_EncodedParameters()
  System.Security.Cryptography.AsymmetricAlgorithm get_Key()
  System.Security.Cryptography.Oid get_Oid()
  System.Byte[] GetUnsignedBigInteger(System.Byte[] integer)
  System.Security.Cryptography.DSA DecodeDSA(System.Byte[] rawPublicKey, System.Byte[] rawParameters)
  System.Security.Cryptography.RSA DecodeRSA(System.Byte[] rawPublicKey)
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X500DistinguishedName
TYPE:  class
TOKEN: 0x2000123
EXTENDS: AsnEncodedData
FIELDS:
  private           System.String                   name  // 0x20
  private           System.Byte[]                   canonEncoding  // 0x28
METHODS:
  System.Void .ctor(System.Byte[] encodedDistinguishedName)
  System.Void .ctor(System.String distinguishedName)
  System.Void .ctor(System.String distinguishedName, System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag)
  System.String get_Name()
  System.String Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag)
  System.String Format(System.Boolean multiLine)
  System.String GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag)
  System.Void DecodeRawData()
  System.String Canonize(System.String s)
  System.Boolean AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension
TYPE:  class
TOKEN: 0x2000124
EXTENDS: X509Extension
FIELDS:
  private   static  System.String                   oid  // 0x0
  private   static  System.String                   friendlyName  // 0x0
  private           System.Boolean                  _certificateAuthority  // 0x28
  private           System.Boolean                  _hasPathLengthConstraint  // 0x29
  private           System.Int32                    _pathLengthConstraint  // 0x2C
  private           System.Security.Cryptography.AsnDecodeStatus_status  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, System.Boolean critical)
  System.Void .ctor(System.Boolean certificateAuthority, System.Boolean hasPathLengthConstraint, System.Int32 pathLengthConstraint, System.Boolean critical)
  System.Boolean get_CertificateAuthority()
  System.Boolean get_HasPathLengthConstraint()
  System.Int32 get_PathLengthConstraint()
  System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension)
  System.Byte[] Encode()
  System.String ToString(System.Boolean multiLine)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Certificate2
TYPE:  class
TOKEN: 0x2000125
EXTENDS: X509Certificate
FIELDS:
  private           System.Byte[]                   lazyRawData  // 0x60
  private           System.Security.Cryptography.OidlazySignatureAlgorithm  // 0x68
  private           System.Int32                    lazyVersion  // 0x70
  private           System.Security.Cryptography.X509Certificates.X500DistinguishedNamelazySubjectName  // 0x78
  private           System.Security.Cryptography.X509Certificates.X500DistinguishedNamelazyIssuerName  // 0x80
  private           System.Security.Cryptography.X509Certificates.PublicKeylazyPublicKey  // 0x88
  private           System.Security.Cryptography.AsymmetricAlgorithmlazyPrivateKey  // 0x90
  private           System.Security.Cryptography.X509Certificates.X509ExtensionCollectionlazyExtensions  // 0x98
METHODS:
  System.Void Reset()
  System.Void .ctor()
  System.Void .ctor(System.Byte[] rawData)
  System.Void .ctor(System.Byte[] rawData, System.String password)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2Impl impl)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate certificate)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions()
  System.Boolean get_HasPrivateKey()
  System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey()
  System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName()
  System.DateTime get_NotAfter()
  System.DateTime get_NotBefore()
  System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey()
  System.Byte[] get_RawData()
  System.String get_SerialNumber()
  System.Security.Cryptography.Oid get_SignatureAlgorithm()
  System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName()
  System.String get_Thumbprint()
  System.Int32 get_Version()
  System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(System.Byte[] rawData)
  System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer)
  System.String ToString()
  System.String ToString(System.Boolean verbose)
  System.Boolean Verify()
  System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid)
  System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Certificate2Collection
TYPE:  class
TOKEN: 0x2000126
EXTENDS: X509CertificateCollection
FIELDS:
  private   static  System.String[]                 newline_split  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates)
  System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(System.Int32 index)
  System.Int32 Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates)
  System.Boolean Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.String GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x)
  System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, System.Object findValue, System.Boolean validOnly)
  System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator()
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator
TYPE:  class
TOKEN: 0x2000127
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection)
  System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current()
  System.Boolean MoveNext()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Certificate2Impl
TYPE:  class
TOKEN: 0x2000128
EXTENDS: X509CertificateImpl
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions()
  System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName()
  System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey()
  System.Void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value)
  System.String get_SignatureAlgorithm()
  System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName()
  System.Int32 get_Version()
  System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates()
  System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer)
  System.Boolean Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate)
  System.Void AppendPrivateKeyInfo(System.Text.StringBuilder sb)
  System.Void .ctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono
TYPE:  class
TOKEN: 0x2000129
EXTENDS: X509Certificate2ImplUnix
FIELDS:
  private           System.Security.Cryptography.X509Certificates.X509CertificateImplCollectionintermediateCerts  // 0xB0
  private           Mono.Security.X509.X509Certificate_cert  // 0xB8
  private   static  System.String                   empty_error  // 0x0
  private   static  System.Byte[]                   signedData  // 0x8
METHODS:
  System.Boolean get_IsValid()
  System.Void .ctor(Mono.Security.X509.X509Certificate cert)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other)
  System.Void .ctor(System.Byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags)
  System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone()
  Mono.Security.X509.X509Certificate get_Cert()
  System.Byte[] GetRawCertData()
  System.Boolean get_HasPrivateKey()
  System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey()
  System.Void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value)
  System.Security.Cryptography.RSA GetRSAPrivateKey()
  System.Security.Cryptography.DSA GetDSAPrivateKey()
  Mono.Security.X509.X509Certificate ImportPkcs12(System.Byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password)
  Mono.Security.X509.X509Certificate ImportPkcs12(System.Byte[] rawData, System.String password)
  System.Boolean Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate)
  System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates()
  Mono.Security.X509.X509Certificate get_MonoCertificate()
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix
TYPE:  class
TOKEN: 0x200012A
EXTENDS: X509Certificate2Impl
FIELDS:
  private           System.Boolean                  readCertData  // 0x10
  private           Internal.Cryptography.Pal.CertificateDatacertData  // 0x18
METHODS:
  System.Void EnsureCertData()
  System.Byte[] GetRawCertData()
  System.String get_KeyAlgorithm()
  System.Byte[] get_KeyAlgorithmParameters()
  System.Byte[] get_PublicKeyValue()
  System.Byte[] get_SerialNumber()
  System.String get_SignatureAlgorithm()
  System.Int32 get_Version()
  System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName()
  System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName()
  System.String get_Subject()
  System.String get_Issuer()
  System.Byte[] get_RawData()
  System.Byte[] get_Thumbprint()
  System.String GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, System.Boolean forIssuer)
  System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions()
  System.DateTime get_NotAfter()
  System.DateTime get_NotBefore()
  System.Void AppendPrivateKeyInfo(System.Text.StringBuilder sb)
  System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, Microsoft.Win32.SafeHandles.SafePasswordHandle password)
  System.Byte[] ExportPkcs12(Microsoft.Win32.SafeHandles.SafePasswordHandle password)
  System.Byte[] ExportPkcs12(System.String password)
  System.Void .ctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509CertificateCollection
TYPE:  class
TOKEN: 0x200012B
EXTENDS: CollectionBase
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
  System.Security.Cryptography.X509Certificates.X509Certificate get_Item(System.Int32 index)
  System.Int32 Add(System.Security.Cryptography.X509Certificates.X509Certificate value)
  System.Void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
  System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509CertificateImplCollection
TYPE:  class
TOKEN: 0x200012D
FIELDS:
  private           System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl>list  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other)
  System.Int32 get_Count()
  System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(System.Int32 index)
  System.Void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, System.Boolean takeOwnership)
  System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Finalize()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Chain
TYPE:  class
TOKEN: 0x200012E
FIELDS:
  private           System.Security.Cryptography.X509Certificates.X509ChainImplimpl  // 0x10
METHODS:
  System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl()
  System.Void .ctor()
  System.Void .ctor(System.Boolean useMachineContext)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509ChainImpl impl)
  System.Void .ctor(System.IntPtr chainContext)
  System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements()
  System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy()
  System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void Reset()
  System.Security.Cryptography.X509Certificates.X509Chain Create()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Finalize()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainElement
TYPE:  class
TOKEN: 0x200012F
FIELDS:
  private           System.Security.Cryptography.X509Certificates.X509Certificate2certificate  // 0x10
  private           System.Security.Cryptography.X509Certificates.X509ChainStatus[]status  // 0x18
  private           System.String                   info  // 0x20
  private           System.Security.Cryptography.X509Certificates.X509ChainStatusFlagscompressed_status_flags  // 0x28
METHODS:
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate()
  System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus()
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags()
  System.Void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value)
  System.Int32 Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags)
  System.Void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, System.Int32& position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask)
  System.Void UncompressFlags()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainElementCollection
TYPE:  class
TOKEN: 0x2000130
FIELDS:
  private           System.Collections.ArrayList    _list  // 0x10
METHODS:
  System.Void .ctor()
  System.Int32 get_Count()
  System.Boolean get_IsSynchronized()
  System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(System.Int32 index)
  System.Object get_SyncRoot()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void Clear()
  System.Boolean Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator
TYPE:  class
TOKEN: 0x2000131
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.IEnumerable enumerable)
  System.Security.Cryptography.X509Certificates.X509ChainElement get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainImpl
TYPE:  class
TOKEN: 0x2000132
FIELDS:
METHODS:
  System.Boolean get_IsValid()
  System.Void ThrowIfContextInvalid()
  System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements()
  System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy()
  System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode)
  System.Void Reset()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Finalize()
  System.Void .ctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainImplMono
TYPE:  class
TOKEN: 0x2000133
EXTENDS: X509ChainImpl
FIELDS:
  private           System.Security.Cryptography.X509Certificates.StoreLocationlocation  // 0x10
  private           System.Security.Cryptography.X509Certificates.X509ChainElementCollectionelements  // 0x18
  private           System.Security.Cryptography.X509Certificates.X509ChainPolicypolicy  // 0x20
  private           System.Security.Cryptography.X509Certificates.X509ChainStatus[]status  // 0x28
  private   static  System.Security.Cryptography.X509Certificates.X509ChainStatus[]Empty  // 0x0
  private           System.Int32                    max_path_length  // 0x30
  private           System.Security.Cryptography.X509Certificates.X500DistinguishedNameworking_issuer_name  // 0x38
  private           System.Security.Cryptography.AsymmetricAlgorithmworking_public_key  // 0x40
  private           System.Security.Cryptography.X509Certificates.X509ChainElementbce_restriction  // 0x48
  private           System.Security.Cryptography.X509Certificates.X509Certificate2Collectionroots  // 0x50
  private           System.Security.Cryptography.X509Certificates.X509Certificate2Collectioncas  // 0x58
  private           System.Security.Cryptography.X509Certificates.X509Storeroot_store  // 0x60
  private           System.Security.Cryptography.X509Certificates.X509Storeca_store  // 0x68
  private           System.Security.Cryptography.X509Certificates.X509Storeuser_root_store  // 0x70
  private           System.Security.Cryptography.X509Certificates.X509Storeuser_ca_store  // 0x78
  private           System.Security.Cryptography.X509Certificates.X509Certificate2Collectioncollection  // 0x80
METHODS:
  System.Void .ctor(System.Boolean useMachineContext)
  System.Boolean get_IsValid()
  System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements()
  System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy()
  System.Void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error)
  System.Boolean Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void Reset()
  System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots()
  System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities()
  System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore()
  System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore()
  System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore()
  System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore()
  System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection()
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c)
  System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Boolean IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Boolean IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag)
  System.Void Process(System.Int32 n)
  System.Void PrepareForNextCertificate(System.Int32 n)
  System.Void WrapUp()
  System.Void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element)
  System.Boolean IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey)
  System.String GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.String GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.String GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl)
  System.String GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext)
  System.Void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag)
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Int32 ca, System.Boolean online)
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, System.Boolean online)
  Mono.Security.X509.X509Crl CheckCrls(System.String subject, System.String ski, Mono.Security.X509.X509Store store)
  Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate)
  System.Boolean ProcessCrlExtensions(Mono.Security.X509.X509Crl crl)
  System.Boolean ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry)
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainPolicy
TYPE:  class
TOKEN: 0x2000134
FIELDS:
  private           System.Security.Cryptography.OidCollectionapps  // 0x10
  private           System.Security.Cryptography.OidCollectioncert  // 0x18
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollectionstore  // 0x20
  private           System.Security.Cryptography.X509Certificates.X509Certificate2Collectionstore2  // 0x28
  private           System.Security.Cryptography.X509Certificates.X509RevocationFlagrflag  // 0x30
  private           System.Security.Cryptography.X509Certificates.X509RevocationModemode  // 0x34
  private           System.TimeSpan                 timeout  // 0x38
  private           System.Security.Cryptography.X509Certificates.X509VerificationFlagsvflags  // 0x40
  private           System.DateTime                 vtime  // 0x48
METHODS:
  System.Void .ctor()
  System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore()
  System.Void set_ExtraStore(System.Security.Cryptography.X509Certificates.X509Certificate2Collection value)
  System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag()
  System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode()
  System.Void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value)
  System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags()
  System.Void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value)
  System.DateTime get_VerificationTime()
  System.Void Reset()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ChainStatus
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
  private           System.Security.Cryptography.X509Certificates.X509ChainStatusFlagsstatus  // 0x10
  private           System.String                   info  // 0x18
METHODS:
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag)
  System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status()
  System.Void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value)
  System.Void set_StatusInformation(System.String value)
  System.String GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension
TYPE:  class
TOKEN: 0x2000136
EXTENDS: X509Extension
FIELDS:
  private           System.Security.Cryptography.OidCollection_enhKeyUsage  // 0x28
  private           System.Security.Cryptography.AsnDecodeStatus_status  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, System.Boolean critical)
  System.Void .ctor(System.Security.Cryptography.OidCollection enhancedKeyUsages, System.Boolean critical)
  System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension)
  System.Byte[] Encode()
  System.String ToString(System.Boolean multiLine)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Extension
TYPE:  class
TOKEN: 0x2000137
EXTENDS: AsnEncodedData
FIELDS:
  private           System.Boolean                  _critical  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String oid, System.Byte[] rawData, System.Boolean critical)
  System.Boolean get_Critical()
  System.Void set_Critical(System.Boolean value)
  System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.String FormatUnkownData(System.Byte[] data)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ExtensionCollection
TYPE:  class
TOKEN: 0x2000138
FIELDS:
  private   static  System.Byte[]                   Empty  // 0x0
  private           System.Collections.ArrayList    _list  // 0x10
METHODS:
  System.Void .ctor()
  System.Int32 get_Count()
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Security.Cryptography.X509Certificates.X509Extension get_Item(System.String oid)
  System.Int32 Add(System.Security.Cryptography.X509Certificates.X509Extension extension)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator
TYPE:  class
TOKEN: 0x2000139
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.ArrayList list)
  System.Security.Cryptography.X509Certificates.X509Extension get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Helper2
TYPE:  class
TOKEN: 0x200013A
FIELDS:
METHODS:
  Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
  System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(System.Boolean useMachineContext)
  System.Boolean IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl)
  System.Void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl)
  System.Exception GetInvalidChainContextException()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509KeyUsageExtension
TYPE:  class
TOKEN: 0x200013B
EXTENDS: X509Extension
FIELDS:
  private   static  System.String                   oid  // 0x0
  private   static  System.String                   friendlyName  // 0x0
  private   static  System.Security.Cryptography.X509Certificates.X509KeyUsageFlagsall  // 0x0
  private           System.Security.Cryptography.X509Certificates.X509KeyUsageFlags_keyUsages  // 0x28
  private           System.Security.Cryptography.AsnDecodeStatus_status  // 0x2C
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, System.Boolean critical)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, System.Boolean critical)
  System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages()
  System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags)
  System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension)
  System.Byte[] Encode()
  System.String ToString(System.Boolean multiLine)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509Store
TYPE:  class
TOKEN: 0x200013C
FIELDS:
  private           System.String                   _name  // 0x10
  private           System.Security.Cryptography.X509Certificates.StoreLocation_location  // 0x18
  private           System.Security.Cryptography.X509Certificates.X509Certificate2Collectionlist  // 0x20
  private           System.Security.Cryptography.X509Certificates.OpenFlags_flags  // 0x28
  private           Mono.Security.X509.X509Store    store  // 0x30
METHODS:
  System.Void .ctor(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation)
  System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates()
  Mono.Security.X509.X509Stores get_Factory()
  Mono.Security.X509.X509Store get_Store()
  System.Void Close()
  System.Void Dispose()
  System.Void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags)
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension
TYPE:  class
TOKEN: 0x200013D
EXTENDS: X509Extension
FIELDS:
  private   static  System.String                   oid  // 0x0
  private   static  System.String                   friendlyName  // 0x0
  private           System.Byte[]                   _subjectKeyIdentifier  // 0x28
  private           System.String                   _ski  // 0x30
  private           System.Security.Cryptography.AsnDecodeStatus_status  // 0x38
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, System.Boolean critical)
  System.Void .ctor(System.Byte[] subjectKeyIdentifier, System.Boolean critical)
  System.Void .ctor(System.String subjectKeyIdentifier, System.Boolean critical)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.PublicKey key, System.Boolean critical)
  System.Void .ctor(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, System.Boolean critical)
  System.String get_SubjectKeyIdentifier()
  System.Void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData)
  System.Byte FromHexChar(System.Char c)
  System.Byte FromHexChars(System.Char c1, System.Char c2)
  System.Byte[] FromHex(System.String hex)
  System.Security.Cryptography.AsnDecodeStatus Decode(System.Byte[] extension)
  System.Byte[] Encode()
  System.String ToString(System.Boolean multiLine)
END_CLASS

CLASS: System.Text.RegularExpressions.Capture
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  private           System.Int32                    <Index>k__BackingField  // 0x10
  private           System.Int32                    <Length>k__BackingField  // 0x14
  private           System.String                   <Text>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String text, System.Int32 index, System.Int32 length)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.String get_Text()
  System.Void set_Text(System.String value)
  System.String get_Value()
  System.String ToString()
  System.ReadOnlySpan<System.Char> GetLeftSubstring()
  System.ReadOnlySpan<System.Char> GetRightSubstring()
END_CLASS

CLASS: System.Text.RegularExpressions.CaptureCollection
TYPE:  class
TOKEN: 0x20000D5
FIELDS:
  private   readonly System.Text.RegularExpressions.Group_group  // 0x10
  private   readonly System.Int32                    _capcount  // 0x18
  private           System.Text.RegularExpressions.Capture[]_captures  // 0x20
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.Group group)
  System.Boolean get_IsReadOnly()
  System.Int32 get_Count()
  System.Text.RegularExpressions.Capture get_Item(System.Int32 i)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator()
  System.Text.RegularExpressions.Capture GetCapture(System.Int32 i)
  System.Void ForceInitialized()
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Void CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Void CopyTo(System.Text.RegularExpressions.Capture[] array, System.Int32 arrayIndex)
  System.Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(System.Int32 index, System.Text.RegularExpressions.Capture item)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(System.Int32 index)
  System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(System.Int32 index)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(System.Int32 index, System.Text.RegularExpressions.Capture value)
  System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item)
  System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear()
  System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item)
  System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Void System.Collections.IList.Clear()
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
END_CLASS

CLASS: System.Text.RegularExpressions.CollectionDebuggerProxy`1
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
METHODS:
END_CLASS

CLASS: System.Text.RegularExpressions.Group
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: Capture
FIELDS:
  private   static readonly System.Text.RegularExpressions.Groups_emptyGroup  // 0x0
  private   readonly System.Int32[]                  _caps  // 0x20
  private           System.Int32                    _capcount  // 0x28
  private           System.Text.RegularExpressions.CaptureCollection_capcoll  // 0x30
  private   readonly System.String                   <Name>k__BackingField  // 0x38
METHODS:
  System.Void .ctor(System.String text, System.Int32[] caps, System.Int32 capcount, System.String name)
  System.Boolean get_Success()
  System.Text.RegularExpressions.CaptureCollection get_Captures()
  System.Void .cctor()
  System.Void .ctor()
END_CLASS

CLASS: System.Text.RegularExpressions.GroupCollection
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private   readonly System.Text.RegularExpressions.Match_match  // 0x10
  private   readonly System.Collections.Hashtable    _captureMap  // 0x18
  private           System.Text.RegularExpressions.Group[]_groups  // 0x20
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps)
  System.Boolean get_IsReadOnly()
  System.Int32 get_Count()
  System.Text.RegularExpressions.Group get_Item(System.Int32 groupnum)
  System.Text.RegularExpressions.Group get_Item(System.String groupname)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator()
  System.Text.RegularExpressions.Group GetGroup(System.Int32 groupnum)
  System.Text.RegularExpressions.Group GetGroupImpl(System.Int32 groupnum)
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Void CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Void CopyTo(System.Text.RegularExpressions.Group[] array, System.Int32 arrayIndex)
  System.Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(System.Int32 index, System.Text.RegularExpressions.Group item)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(System.Int32 index)
  System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(System.Int32 index)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(System.Int32 index, System.Text.RegularExpressions.Group value)
  System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item)
  System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear()
  System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item)
  System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Void System.Collections.IList.Clear()
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: System.Text.RegularExpressions.Match
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: Group
FIELDS:
  private           System.Text.RegularExpressions.GroupCollection_groupcoll  // 0x40
  private           System.Text.RegularExpressions.Regex_regex  // 0x48
  private           System.Int32                    _textbeg  // 0x50
  private           System.Int32                    _textpos  // 0x54
  private           System.Int32                    _textend  // 0x58
  private           System.Int32                    _textstart  // 0x5C
  private           System.Int32[][]                _matches  // 0x60
  private           System.Int32[]                  _matchcount  // 0x68
  private           System.Boolean                  _balancing  // 0x70
  private   static readonly System.Text.RegularExpressions.Match<Empty>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.Regex regex, System.Int32 capcount, System.String text, System.Int32 begpos, System.Int32 len, System.Int32 startpos)
  System.Text.RegularExpressions.Match get_Empty()
  System.Void Reset(System.Text.RegularExpressions.Regex regex, System.String text, System.Int32 textbeg, System.Int32 textend, System.Int32 textstart)
  System.Text.RegularExpressions.GroupCollection get_Groups()
  System.Text.RegularExpressions.Match NextMatch()
  System.ReadOnlySpan<System.Char> GroupToStringImpl(System.Int32 groupnum)
  System.ReadOnlySpan<System.Char> LastGroupToStringImpl()
  System.Void AddMatch(System.Int32 cap, System.Int32 start, System.Int32 len)
  System.Void BalanceMatch(System.Int32 cap)
  System.Void RemoveMatch(System.Int32 cap)
  System.Boolean IsMatched(System.Int32 cap)
  System.Int32 MatchIndex(System.Int32 cap)
  System.Int32 MatchLength(System.Int32 cap)
  System.Void Tidy(System.Int32 textpos)
  System.Void .cctor()
  System.Void .ctor()
END_CLASS

CLASS: System.Text.RegularExpressions.MatchSparse
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: Match
FIELDS:
  private   readonly System.Collections.Hashtable    _caps  // 0x78
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, System.Int32 capcount, System.String text, System.Int32 begpos, System.Int32 len, System.Int32 startpos)
  System.Text.RegularExpressions.GroupCollection get_Groups()
END_CLASS

CLASS: System.Text.RegularExpressions.MatchCollection
TYPE:  class
TOKEN: 0x20000DD
FIELDS:
  private   readonly System.Text.RegularExpressions.Regex_regex  // 0x10
  private   readonly System.Collections.Generic.List<System.Text.RegularExpressions.Match>_matches  // 0x18
  private           System.Boolean                  _done  // 0x20
  private   readonly System.String                   _input  // 0x28
  private   readonly System.Int32                    _beginning  // 0x30
  private   readonly System.Int32                    _length  // 0x34
  private           System.Int32                    _startat  // 0x38
  private           System.Int32                    _prevlen  // 0x3C
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.Regex regex, System.String input, System.Int32 beginning, System.Int32 length, System.Int32 startat)
  System.Boolean get_IsReadOnly()
  System.Int32 get_Count()
  System.Text.RegularExpressions.Match get_Item(System.Int32 i)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator()
  System.Text.RegularExpressions.Match GetMatch(System.Int32 i)
  System.Void EnsureInitialized()
  System.Boolean get_IsSynchronized()
  System.Object get_SyncRoot()
  System.Void CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Void CopyTo(System.Text.RegularExpressions.Match[] array, System.Int32 arrayIndex)
  System.Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(System.Int32 index, System.Text.RegularExpressions.Match item)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(System.Int32 index)
  System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(System.Int32 index)
  System.Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(System.Int32 index, System.Text.RegularExpressions.Match value)
  System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item)
  System.Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear()
  System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item)
  System.Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Void System.Collections.IList.Clear()
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: System.Text.RegularExpressions.ExclusiveReference
TYPE:  class
TOKEN: 0x20000DF
FIELDS:
  private           System.Text.RegularExpressions.RegexRunner_ref  // 0x10
  private           System.Text.RegularExpressions.RegexRunner_obj  // 0x18
  private           System.Int32                    _locked  // 0x20
METHODS:
  System.Text.RegularExpressions.RegexRunner Get()
  System.Void Release(System.Text.RegularExpressions.RegexRunner obj)
  System.Void .ctor()
END_CLASS

CLASS: System.Text.RegularExpressions.Regex
TYPE:  class
TOKEN: 0x20000E0
FIELDS:
  private   static  System.Int32                    CacheDictionarySwitchLimit  // 0x0
  private   static  System.Int32                    s_cacheSize  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex.CachedCodeEntryKey,System.Text.RegularExpressions.Regex.CachedCodeEntry>s_cache  // 0x8
  private   static  System.Int32                    s_cacheCount  // 0x10
  private   static  System.Text.RegularExpressions.Regex.CachedCodeEntrys_cacheFirst  // 0x18
  private   static  System.Text.RegularExpressions.Regex.CachedCodeEntrys_cacheLast  // 0x20
  private   static readonly System.TimeSpan                 s_maximumMatchTimeout  // 0x28
  private   static  System.String                   DefaultMatchTimeout_ConfigKeyName  // 0x0
  private   static readonly System.TimeSpan                 s_defaultMatchTimeout  // 0x30
  public    static readonly System.TimeSpan                 InfiniteMatchTimeout  // 0x38
  protected internal        System.TimeSpan                 internalMatchTimeout  // 0x10
  private   static  System.Int32                    MaxOptionShift  // 0x0
  protected internal        System.String                   pattern  // 0x18
  protected internal        System.Text.RegularExpressions.RegexOptionsroptions  // 0x20
  protected internal        System.Text.RegularExpressions.RegexRunnerFactoryfactory  // 0x28
  protected internal        System.Collections.Hashtable    caps  // 0x30
  protected internal        System.Collections.Hashtable    capnames  // 0x38
  protected internal        System.String[]                 capslist  // 0x40
  protected internal        System.Int32                    capsize  // 0x48
  private           System.Text.RegularExpressions.ExclusiveReference_runnerref  // 0x50
  private           System.WeakReference<System.Text.RegularExpressions.RegexReplacement>_replref  // 0x58
  private           System.Text.RegularExpressions.RegexCode_code  // 0x60
  private           System.Boolean                  _refsInitialized  // 0x68
METHODS:
  System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Boolean isToAdd)
  System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Boolean isToAdd)
  System.Void FillCacheDictionary()
  System.Boolean TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Text.RegularExpressions.Regex.CachedCodeEntry& entry)
  System.Boolean TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Text.RegularExpressions.Regex.CachedCodeEntry& entry)
  System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key)
  System.Boolean IsMatch(System.String input, System.String pattern)
  System.Boolean IsMatch(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options)
  System.Boolean IsMatch(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout)
  System.Boolean IsMatch(System.String input)
  System.Boolean IsMatch(System.String input, System.Int32 startat)
  System.Text.RegularExpressions.Match Match(System.String input, System.String pattern)
  System.Text.RegularExpressions.Match Match(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options)
  System.Text.RegularExpressions.Match Match(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout)
  System.Text.RegularExpressions.Match Match(System.String input)
  System.Text.RegularExpressions.Match Match(System.String input, System.Int32 startat)
  System.Text.RegularExpressions.MatchCollection Matches(System.String input, System.String pattern)
  System.Text.RegularExpressions.MatchCollection Matches(System.String input, System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout)
  System.Text.RegularExpressions.MatchCollection Matches(System.String input)
  System.Text.RegularExpressions.MatchCollection Matches(System.String input, System.Int32 startat)
  System.String Replace(System.String input, System.String pattern, System.String replacement)
  System.String Replace(System.String input, System.String pattern, System.String replacement, System.Text.RegularExpressions.RegexOptions options)
  System.String Replace(System.String input, System.String pattern, System.String replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout)
  System.String Replace(System.String input, System.String replacement)
  System.String Replace(System.String input, System.String replacement, System.Int32 count, System.Int32 startat)
  System.String Replace(System.String input, System.String pattern, System.Text.RegularExpressions.MatchEvaluator evaluator)
  System.String Replace(System.String input, System.String pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout)
  System.String Replace(System.String input, System.Text.RegularExpressions.MatchEvaluator evaluator)
  System.String Replace(System.String input, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Int32 count, System.Int32 startat)
  System.String Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, System.String input, System.Int32 count, System.Int32 startat)
  System.Void .cctor()
  System.Void ValidateMatchTimeout(System.TimeSpan matchTimeout)
  System.TimeSpan InitDefaultMatchTimeout()
  System.Void .ctor(System.String pattern)
  System.Void .ctor(System.String pattern, System.Text.RegularExpressions.RegexOptions options)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor(System.String pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, System.Boolean addToCache)
  System.String Escape(System.String str)
  System.Text.RegularExpressions.RegexOptions get_Options()
  System.Boolean get_RightToLeft()
  System.String ToString()
  System.String GroupNameFromNumber(System.Int32 i)
  System.Int32 GroupNumberFromName(System.String name)
  System.Void InitializeReferences()
  System.Text.RegularExpressions.Match Run(System.Boolean quick, System.Int32 prevlen, System.String input, System.Int32 beginning, System.Int32 length, System.Int32 startat)
  System.Boolean UseOptionR()
  System.Boolean UseOptionInvariant()
END_CLASS

CLASS: System.Text.RegularExpressions.MatchEvaluator
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke(System.Text.RegularExpressions.Match match)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexBoyerMoore
TYPE:  class
TOKEN: 0x20000E4
FIELDS:
  public    readonly System.Int32[]                  Positive  // 0x10
  public    readonly System.Int32[]                  NegativeASCII  // 0x18
  public    readonly System.Int32[][]                NegativeUnicode  // 0x20
  public    readonly System.String                   Pattern  // 0x28
  public    readonly System.Int32                    LowASCII  // 0x30
  public    readonly System.Int32                    HighASCII  // 0x34
  public    readonly System.Boolean                  RightToLeft  // 0x38
  public    readonly System.Boolean                  CaseInsensitive  // 0x39
  private   readonly System.Globalization.CultureInfo_culture  // 0x40
METHODS:
  System.Void .ctor(System.String pattern, System.Boolean caseInsensitive, System.Boolean rightToLeft, System.Globalization.CultureInfo culture)
  System.Boolean MatchPattern(System.String text, System.Int32 index)
  System.Boolean IsMatch(System.String text, System.Int32 index, System.Int32 beglimit, System.Int32 endlimit)
  System.Int32 Scan(System.String text, System.Int32 index, System.Int32 beglimit, System.Int32 endlimit)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexCharClass
TYPE:  class
TOKEN: 0x20000E5
FIELDS:
  private   static readonly System.String                   s_internalRegexIgnoreCase  // 0x0
  private   static readonly System.String                   s_space  // 0x8
  private   static readonly System.String                   s_notSpace  // 0x10
  private   static readonly System.String                   s_word  // 0x18
  private   static readonly System.String                   s_notWord  // 0x20
  public    static readonly System.String                   SpaceClass  // 0x28
  public    static readonly System.String                   NotSpaceClass  // 0x30
  public    static readonly System.String                   WordClass  // 0x38
  public    static readonly System.String                   NotWordClass  // 0x40
  public    static readonly System.String                   DigitClass  // 0x48
  public    static readonly System.String                   NotDigitClass  // 0x50
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_definedCategories  // 0x58
  private   static readonly System.String[][]               s_propTable  // 0x60
  private   static readonly System.Text.RegularExpressions.RegexCharClass.LowerCaseMapping[]s_lcTable  // 0x68
  private           System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange>_rangelist  // 0x10
  private           System.Text.StringBuilder       _categories  // 0x18
  private           System.Boolean                  _canonical  // 0x20
  private           System.Boolean                  _negate  // 0x21
  private           System.Text.RegularExpressions.RegexCharClass_subtractor  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Boolean negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction)
  System.Boolean get_CanMerge()
  System.Void set_Negate(System.Boolean value)
  System.Void AddChar(System.Char c)
  System.Void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc)
  System.Void AddSet(System.String set)
  System.Void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub)
  System.Void AddRange(System.Char first, System.Char last)
  System.Void AddCategoryFromName(System.String categoryName, System.Boolean invert, System.Boolean caseInsensitive, System.String pattern)
  System.Void AddCategory(System.String category)
  System.Void AddLowercase(System.Globalization.CultureInfo culture)
  System.Void AddLowercaseRange(System.Char chMin, System.Char chMax, System.Globalization.CultureInfo culture)
  System.Void AddWord(System.Boolean ecma, System.Boolean negate)
  System.Void AddSpace(System.Boolean ecma, System.Boolean negate)
  System.Void AddDigit(System.Boolean ecma, System.Boolean negate, System.String pattern)
  System.Char SingletonChar(System.String set)
  System.Boolean IsMergeable(System.String charClass)
  System.Boolean IsEmpty(System.String charClass)
  System.Boolean IsSingleton(System.String set)
  System.Boolean IsSingletonInverse(System.String set)
  System.Boolean IsSubtraction(System.String charClass)
  System.Boolean IsNegated(System.String set)
  System.Boolean IsECMAWordChar(System.Char ch)
  System.Boolean IsWordChar(System.Char ch)
  System.Boolean CharInClass(System.Char ch, System.String set)
  System.Boolean CharInClassRecursive(System.Char ch, System.String set, System.Int32 start)
  System.Boolean CharInClassInternal(System.Char ch, System.String set, System.Int32 start, System.Int32 mySetLength, System.Int32 myCategoryLength)
  System.Boolean CharInCategory(System.Char ch, System.String set, System.Int32 start, System.Int32 mySetLength, System.Int32 myCategoryLength)
  System.Boolean CharInCategoryGroup(System.Char ch, System.Globalization.UnicodeCategory chcategory, System.String category, System.Int32& i)
  System.String NegateCategory(System.String category)
  System.Text.RegularExpressions.RegexCharClass Parse(System.String charClass)
  System.Text.RegularExpressions.RegexCharClass ParseRecursive(System.String charClass, System.Int32 start)
  System.Int32 RangeCount()
  System.String ToStringClass()
  System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(System.Int32 i)
  System.Void Canonicalize()
  System.String SetFromProperty(System.String capname, System.Boolean invert, System.String pattern)
  System.Void .cctor()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexCode
TYPE:  class
TOKEN: 0x20000E9
FIELDS:
  public    static  System.Int32                    Onerep  // 0x0
  public    static  System.Int32                    Notonerep  // 0x0
  public    static  System.Int32                    Setrep  // 0x0
  public    static  System.Int32                    Oneloop  // 0x0
  public    static  System.Int32                    Notoneloop  // 0x0
  public    static  System.Int32                    Setloop  // 0x0
  public    static  System.Int32                    Onelazy  // 0x0
  public    static  System.Int32                    Notonelazy  // 0x0
  public    static  System.Int32                    Setlazy  // 0x0
  public    static  System.Int32                    One  // 0x0
  public    static  System.Int32                    Notone  // 0x0
  public    static  System.Int32                    Set  // 0x0
  public    static  System.Int32                    Multi  // 0x0
  public    static  System.Int32                    Ref  // 0x0
  public    static  System.Int32                    Bol  // 0x0
  public    static  System.Int32                    Eol  // 0x0
  public    static  System.Int32                    Boundary  // 0x0
  public    static  System.Int32                    Nonboundary  // 0x0
  public    static  System.Int32                    Beginning  // 0x0
  public    static  System.Int32                    Start  // 0x0
  public    static  System.Int32                    EndZ  // 0x0
  public    static  System.Int32                    End  // 0x0
  public    static  System.Int32                    Nothing  // 0x0
  public    static  System.Int32                    Lazybranch  // 0x0
  public    static  System.Int32                    Branchmark  // 0x0
  public    static  System.Int32                    Lazybranchmark  // 0x0
  public    static  System.Int32                    Nullcount  // 0x0
  public    static  System.Int32                    Setcount  // 0x0
  public    static  System.Int32                    Branchcount  // 0x0
  public    static  System.Int32                    Lazybranchcount  // 0x0
  public    static  System.Int32                    Nullmark  // 0x0
  public    static  System.Int32                    Setmark  // 0x0
  public    static  System.Int32                    Capturemark  // 0x0
  public    static  System.Int32                    Getmark  // 0x0
  public    static  System.Int32                    Setjump  // 0x0
  public    static  System.Int32                    Backjump  // 0x0
  public    static  System.Int32                    Forejump  // 0x0
  public    static  System.Int32                    Testref  // 0x0
  public    static  System.Int32                    Goto  // 0x0
  public    static  System.Int32                    Prune  // 0x0
  public    static  System.Int32                    Stop  // 0x0
  public    static  System.Int32                    ECMABoundary  // 0x0
  public    static  System.Int32                    NonECMABoundary  // 0x0
  public    static  System.Int32                    Mask  // 0x0
  public    static  System.Int32                    Rtl  // 0x0
  public    static  System.Int32                    Back  // 0x0
  public    static  System.Int32                    Back2  // 0x0
  public    static  System.Int32                    Ci  // 0x0
  public    readonly System.Int32[]                  Codes  // 0x10
  public    readonly System.String[]                 Strings  // 0x18
  public    readonly System.Int32                    TrackCount  // 0x20
  public    readonly System.Collections.Hashtable    Caps  // 0x28
  public    readonly System.Int32                    CapSize  // 0x30
  public    readonly System.Nullable<System.Text.RegularExpressions.RegexPrefix>FCPrefix  // 0x38
  public    readonly System.Text.RegularExpressions.RegexBoyerMooreBMPrefix  // 0x50
  public    readonly System.Int32                    Anchors  // 0x58
  public    readonly System.Boolean                  RightToLeft  // 0x5C
METHODS:
  System.Void .ctor(System.Int32[] codes, System.Collections.Generic.List<System.String> stringlist, System.Int32 trackcount, System.Collections.Hashtable caps, System.Int32 capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, System.Int32 anchors, System.Boolean rightToLeft)
  System.Boolean OpcodeBacktracks(System.Int32 Op)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexFCD
TYPE:  struct
TOKEN: 0x20000EA
FIELDS:
  private   readonly System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC>_fcStack  // 0x10
  private           System.Collections.Generic.ValueListBuilder<System.Int32>_intStack  // 0x18
  private           System.Boolean                  _skipAllChildren  // 0x38
  private           System.Boolean                  _skipchild  // 0x39
  private           System.Boolean                  _failed  // 0x3A
METHODS:
  System.Void .ctor(System.Span<System.Int32> intStack)
  System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t)
  System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree)
  System.Int32 Anchors(System.Text.RegularExpressions.RegexTree tree)
  System.Int32 AnchorFromType(System.Int32 type)
  System.Void PushInt(System.Int32 i)
  System.Boolean IntIsEmpty()
  System.Int32 PopInt()
  System.Void PushFC(System.Text.RegularExpressions.RegexFC fc)
  System.Boolean FCIsEmpty()
  System.Text.RegularExpressions.RegexFC PopFC()
  System.Text.RegularExpressions.RegexFC TopFC()
  System.Void Dispose()
  System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree)
  System.Void SkipChild()
  System.Void CalculateFC(System.Int32 NodeType, System.Text.RegularExpressions.RegexNode node, System.Int32 CurIndex)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexFC
TYPE:  class
TOKEN: 0x20000EB
FIELDS:
  private           System.Text.RegularExpressions.RegexCharClass_cc  // 0x10
  public            System.Boolean                  _nullable  // 0x18
  private           System.Boolean                  <CaseInsensitive>k__BackingField  // 0x19
METHODS:
  System.Void .ctor(System.Boolean nullable)
  System.Void .ctor(System.Char ch, System.Boolean not, System.Boolean nullable, System.Boolean caseInsensitive)
  System.Void .ctor(System.String charClass, System.Boolean nullable, System.Boolean caseInsensitive)
  System.Boolean AddFC(System.Text.RegularExpressions.RegexFC fc, System.Boolean concatenate)
  System.Boolean get_CaseInsensitive()
  System.Void set_CaseInsensitive(System.Boolean value)
  System.String GetFirstChars(System.Globalization.CultureInfo culture)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexInterpreter
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: RegexRunner
FIELDS:
  private   readonly System.Text.RegularExpressions.RegexCode_code  // 0x80
  private   readonly System.Globalization.CultureInfo_culture  // 0x88
  private           System.Int32                    _operator  // 0x90
  private           System.Int32                    _codepos  // 0x94
  private           System.Boolean                  _rightToLeft  // 0x98
  private           System.Boolean                  _caseInsensitive  // 0x99
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture)
  System.Void InitTrackCount()
  System.Void Advance(System.Int32 i)
  System.Void Goto(System.Int32 newpos)
  System.Void Textto(System.Int32 newpos)
  System.Void Trackto(System.Int32 newpos)
  System.Int32 Textstart()
  System.Int32 Textpos()
  System.Int32 Trackpos()
  System.Void TrackPush()
  System.Void TrackPush(System.Int32 I1)
  System.Void TrackPush(System.Int32 I1, System.Int32 I2)
  System.Void TrackPush(System.Int32 I1, System.Int32 I2, System.Int32 I3)
  System.Void TrackPush2(System.Int32 I1)
  System.Void TrackPush2(System.Int32 I1, System.Int32 I2)
  System.Void Backtrack()
  System.Void SetOperator(System.Int32 op)
  System.Void TrackPop()
  System.Void TrackPop(System.Int32 framesize)
  System.Int32 TrackPeek()
  System.Int32 TrackPeek(System.Int32 i)
  System.Void StackPush(System.Int32 I1)
  System.Void StackPush(System.Int32 I1, System.Int32 I2)
  System.Void StackPop()
  System.Void StackPop(System.Int32 framesize)
  System.Int32 StackPeek()
  System.Int32 StackPeek(System.Int32 i)
  System.Int32 Operator()
  System.Int32 Operand(System.Int32 i)
  System.Int32 Leftchars()
  System.Int32 Rightchars()
  System.Int32 Bump()
  System.Int32 Forwardchars()
  System.Char Forwardcharnext()
  System.Boolean Stringmatch(System.String str)
  System.Boolean Refmatch(System.Int32 index, System.Int32 len)
  System.Void Backwardnext()
  System.Char CharAt(System.Int32 j)
  System.Boolean FindFirstChar()
  System.Void Go()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexMatchTimeoutException
TYPE:  class
TOKEN: 0x20000ED
EXTENDS: TimeoutException
FIELDS:
  private   readonly System.String                   <Input>k__BackingField  // 0x90
  private   readonly System.String                   <Pattern>k__BackingField  // 0x98
  private   readonly System.TimeSpan                 <MatchTimeout>k__BackingField  // 0xA0
METHODS:
  System.Void .ctor(System.String regexInput, System.String regexPattern, System.TimeSpan matchTimeout)
  System.Void .ctor()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.String get_Input()
  System.String get_Pattern()
  System.TimeSpan get_MatchTimeout()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexNode
TYPE:  class
TOKEN: 0x20000EE
FIELDS:
  public            System.Int32                    NType  // 0x10
  public            System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>Children  // 0x18
  public            System.String                   Str  // 0x20
  public            System.Char                     Ch  // 0x28
  public            System.Int32                    M  // 0x2C
  public            System.Int32                    N  // 0x30
  public    readonly System.Text.RegularExpressions.RegexOptionsOptions  // 0x34
  public            System.Text.RegularExpressions.RegexNodeNext  // 0x38
METHODS:
  System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options)
  System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.Char ch)
  System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.String str)
  System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.Int32 m)
  System.Void .ctor(System.Int32 type, System.Text.RegularExpressions.RegexOptions options, System.Int32 m, System.Int32 n)
  System.Boolean UseOptionR()
  System.Text.RegularExpressions.RegexNode ReverseLeft()
  System.Void MakeRep(System.Int32 type, System.Int32 min, System.Int32 max)
  System.Text.RegularExpressions.RegexNode Reduce()
  System.Text.RegularExpressions.RegexNode StripEnation(System.Int32 emptyType)
  System.Text.RegularExpressions.RegexNode ReduceGroup()
  System.Text.RegularExpressions.RegexNode ReduceRep()
  System.Text.RegularExpressions.RegexNode ReduceSet()
  System.Text.RegularExpressions.RegexNode ReduceAlternation()
  System.Text.RegularExpressions.RegexNode ReduceConcatenation()
  System.Text.RegularExpressions.RegexNode MakeQuantifier(System.Boolean lazy, System.Int32 min, System.Int32 max)
  System.Void AddChild(System.Text.RegularExpressions.RegexNode newChild)
  System.Text.RegularExpressions.RegexNode Child(System.Int32 i)
  System.Int32 ChildCount()
  System.Int32 Type()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexOptions
TYPE:  struct
TOKEN: 0x20000EF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Text.RegularExpressions.RegexOptionsNone  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsIgnoreCase  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsMultiline  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsExplicitCapture  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsCompiled  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsSingleline  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsIgnorePatternWhitespace  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsRightToLeft  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsECMAScript  // 0x0
  public    static  System.Text.RegularExpressions.RegexOptionsCultureInvariant  // 0x0
METHODS:
END_CLASS

CLASS: System.Text.RegularExpressions.RegexParser
TYPE:  class
TOKEN: 0x20000F0
FIELDS:
  private           System.Text.RegularExpressions.RegexNode_stack  // 0x10
  private           System.Text.RegularExpressions.RegexNode_group  // 0x18
  private           System.Text.RegularExpressions.RegexNode_alternation  // 0x20
  private           System.Text.RegularExpressions.RegexNode_concatenation  // 0x28
  private           System.Text.RegularExpressions.RegexNode_unit  // 0x30
  private           System.String                   _pattern  // 0x38
  private           System.Int32                    _currentPos  // 0x40
  private           System.Globalization.CultureInfo_culture  // 0x48
  private           System.Int32                    _autocap  // 0x50
  private           System.Int32                    _capcount  // 0x54
  private           System.Int32                    _captop  // 0x58
  private           System.Int32                    _capsize  // 0x5C
  private           System.Collections.Hashtable    _caps  // 0x60
  private           System.Collections.Hashtable    _capnames  // 0x68
  private           System.Int32[]                  _capnumlist  // 0x70
  private           System.Collections.Generic.List<System.String>_capnamelist  // 0x78
  private           System.Text.RegularExpressions.RegexOptions_options  // 0x80
  private           System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions>_optionsStack  // 0x88
  private           System.Boolean                  _ignoreNextParen  // 0x90
  private   static readonly System.Byte[]                   s_category  // 0x0
METHODS:
  System.Text.RegularExpressions.RegexTree Parse(System.String re, System.Text.RegularExpressions.RegexOptions op)
  System.Text.RegularExpressions.RegexReplacement ParseReplacement(System.String rep, System.Collections.Hashtable caps, System.Int32 capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op)
  System.String Escape(System.String input)
  System.Void .ctor(System.Globalization.CultureInfo culture)
  System.Void SetPattern(System.String Re)
  System.Void Reset(System.Text.RegularExpressions.RegexOptions topopts)
  System.Text.RegularExpressions.RegexNode ScanRegex()
  System.Text.RegularExpressions.RegexNode ScanReplacement()
  System.Text.RegularExpressions.RegexCharClass ScanCharClass(System.Boolean caseInsensitive, System.Boolean scanOnly)
  System.Text.RegularExpressions.RegexNode ScanGroupOpen()
  System.Void ScanBlank()
  System.Text.RegularExpressions.RegexNode ScanBackslash(System.Boolean scanOnly)
  System.Text.RegularExpressions.RegexNode ScanBasicBackslash(System.Boolean scanOnly)
  System.Text.RegularExpressions.RegexNode ScanDollar()
  System.String ScanCapname()
  System.Char ScanOctal()
  System.Int32 ScanDecimal()
  System.Char ScanHex(System.Int32 c)
  System.Int32 HexDigit(System.Char ch)
  System.Char ScanControl()
  System.Boolean IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option)
  System.Void ScanOptions()
  System.Char ScanCharEscape()
  System.String ParseProperty()
  System.Int32 TypeFromCode(System.Char ch)
  System.Text.RegularExpressions.RegexOptions OptionFromCode(System.Char ch)
  System.Void CountCaptures()
  System.Void NoteCaptureSlot(System.Int32 i, System.Int32 pos)
  System.Void NoteCaptureName(System.String name, System.Int32 pos)
  System.Void NoteCaptures(System.Collections.Hashtable caps, System.Int32 capsize, System.Collections.Hashtable capnames)
  System.Void AssignNameSlots()
  System.Int32 CaptureSlotFromName(System.String capname)
  System.Boolean IsCaptureSlot(System.Int32 i)
  System.Boolean IsCaptureName(System.String capname)
  System.Boolean UseOptionN()
  System.Boolean UseOptionI()
  System.Boolean UseOptionM()
  System.Boolean UseOptionS()
  System.Boolean UseOptionX()
  System.Boolean UseOptionE()
  System.Boolean IsSpecial(System.Char ch)
  System.Boolean IsStopperX(System.Char ch)
  System.Boolean IsQuantifier(System.Char ch)
  System.Boolean IsTrueQuantifier()
  System.Boolean IsSpace(System.Char ch)
  System.Boolean IsMetachar(System.Char ch)
  System.Void AddConcatenate(System.Int32 pos, System.Int32 cch, System.Boolean isReplacement)
  System.Void PushGroup()
  System.Void PopGroup()
  System.Boolean EmptyStack()
  System.Void StartGroup(System.Text.RegularExpressions.RegexNode openGroup)
  System.Void AddAlternate()
  System.Void AddConcatenate()
  System.Void AddConcatenate(System.Boolean lazy, System.Int32 min, System.Int32 max)
  System.Text.RegularExpressions.RegexNode Unit()
  System.Void AddUnitOne(System.Char ch)
  System.Void AddUnitNotone(System.Char ch)
  System.Void AddUnitSet(System.String cc)
  System.Void AddUnitNode(System.Text.RegularExpressions.RegexNode node)
  System.Void AddUnitType(System.Int32 type)
  System.Void AddGroup()
  System.Void PushOptions()
  System.Void PopOptions()
  System.Boolean EmptyOptionsStack()
  System.Void PopKeepOptions()
  System.ArgumentException MakeException(System.String message)
  System.Int32 Textpos()
  System.Void Textto(System.Int32 pos)
  System.Char RightCharMoveRight()
  System.Void MoveRight()
  System.Void MoveRight(System.Int32 i)
  System.Void MoveLeft()
  System.Char CharAt(System.Int32 i)
  System.Char RightChar()
  System.Char RightChar(System.Int32 i)
  System.Int32 CharsRight()
  System.Void .cctor()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexPrefix
TYPE:  struct
TOKEN: 0x20000F1
FIELDS:
  private   readonly System.Boolean                  <CaseInsensitive>k__BackingField  // 0x10
  private   static readonly System.Text.RegularExpressions.RegexPrefix<Empty>k__BackingField  // 0x0
  private   readonly System.String                   <Prefix>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String prefix, System.Boolean ci)
  System.Boolean get_CaseInsensitive()
  System.Text.RegularExpressions.RegexPrefix get_Empty()
  System.String get_Prefix()
  System.Void .cctor()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexReplacement
TYPE:  class
TOKEN: 0x20000F2
FIELDS:
  private   static  System.Int32                    Specials  // 0x0
  public    static  System.Int32                    LeftPortion  // 0x0
  public    static  System.Int32                    RightPortion  // 0x0
  public    static  System.Int32                    LastGroup  // 0x0
  public    static  System.Int32                    WholeString  // 0x0
  private   readonly System.Collections.Generic.List<System.String>_strings  // 0x10
  private   readonly System.Collections.Generic.List<System.Int32>_rules  // 0x18
  private   readonly System.String                   <Pattern>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.String rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps)
  System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, System.String replacement, System.Collections.Hashtable caps, System.Int32 capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions)
  System.String get_Pattern()
  System.Void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match)
  System.Void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, System.Text.RegularExpressions.Match match)
  System.String Replace(System.Text.RegularExpressions.Regex regex, System.String input, System.Int32 count, System.Int32 startat)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexRunner
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
  protected internal        System.Int32                    runtextbeg  // 0x10
  protected internal        System.Int32                    runtextend  // 0x14
  protected internal        System.Int32                    runtextstart  // 0x18
  protected internal        System.String                   runtext  // 0x20
  protected internal        System.Int32                    runtextpos  // 0x28
  protected internal        System.Int32[]                  runtrack  // 0x30
  protected internal        System.Int32                    runtrackpos  // 0x38
  protected internal        System.Int32[]                  runstack  // 0x40
  protected internal        System.Int32                    runstackpos  // 0x48
  protected internal        System.Int32[]                  runcrawl  // 0x50
  protected internal        System.Int32                    runcrawlpos  // 0x58
  protected internal        System.Int32                    runtrackcount  // 0x5C
  protected internal        System.Text.RegularExpressions.Matchrunmatch  // 0x60
  protected internal        System.Text.RegularExpressions.Regexrunregex  // 0x68
  private           System.Int32                    _timeout  // 0x70
  private           System.Boolean                  _ignoreTimeout  // 0x74
  private           System.Int32                    _timeoutOccursAt  // 0x78
  private   static  System.Int32                    TimeoutCheckFrequency  // 0x0
  private           System.Int32                    _timeoutChecksToSkip  // 0x7C
METHODS:
  System.Void .ctor()
  System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, System.String text, System.Int32 textbeg, System.Int32 textend, System.Int32 textstart, System.Int32 prevlen, System.Boolean quick, System.TimeSpan timeout)
  System.Void StartTimeoutWatch()
  System.Void CheckTimeout()
  System.Void DoCheckTimeout()
  System.Void Go()
  System.Boolean FindFirstChar()
  System.Void InitTrackCount()
  System.Void InitMatch()
  System.Text.RegularExpressions.Match TidyMatch(System.Boolean quick)
  System.Void EnsureStorage()
  System.Boolean IsBoundary(System.Int32 index, System.Int32 startpos, System.Int32 endpos)
  System.Boolean IsECMABoundary(System.Int32 index, System.Int32 startpos, System.Int32 endpos)
  System.Void DoubleTrack()
  System.Void DoubleStack()
  System.Void DoubleCrawl()
  System.Void Crawl(System.Int32 i)
  System.Int32 Popcrawl()
  System.Int32 Crawlpos()
  System.Void Capture(System.Int32 capnum, System.Int32 start, System.Int32 end)
  System.Void TransferCapture(System.Int32 capnum, System.Int32 uncapnum, System.Int32 start, System.Int32 end)
  System.Void Uncapture()
  System.Boolean IsMatched(System.Int32 cap)
  System.Int32 MatchIndex(System.Int32 cap)
  System.Int32 MatchLength(System.Int32 cap)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexRunnerFactory
TYPE:  class
TOKEN: 0x20000F4
FIELDS:
METHODS:
  System.Text.RegularExpressions.RegexRunner CreateInstance()
END_CLASS

CLASS: System.Text.RegularExpressions.RegexTree
TYPE:  class
TOKEN: 0x20000F5
FIELDS:
  public    readonly System.Text.RegularExpressions.RegexNodeRoot  // 0x10
  public    readonly System.Collections.Hashtable    Caps  // 0x18
  public    readonly System.Int32[]                  CapNumList  // 0x20
  public    readonly System.Int32                    CapTop  // 0x28
  public    readonly System.Collections.Hashtable    CapNames  // 0x30
  public    readonly System.String[]                 CapsList  // 0x38
  public    readonly System.Text.RegularExpressions.RegexOptionsOptions  // 0x40
METHODS:
  System.Void .ctor(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, System.Int32[] capNumList, System.Int32 capTop, System.Collections.Hashtable capNames, System.String[] capsList, System.Text.RegularExpressions.RegexOptions options)
END_CLASS

CLASS: System.Text.RegularExpressions.RegexWriter
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  private           System.Collections.Generic.ValueListBuilder<System.Int32>_emitted  // 0x10
  private           System.Collections.Generic.ValueListBuilder<System.Int32>_intStack  // 0x30
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Int32>_stringHash  // 0x50
  private   readonly System.Collections.Generic.List<System.String>_stringTable  // 0x58
  private           System.Collections.Hashtable    _caps  // 0x60
  private           System.Int32                    _trackCount  // 0x68
METHODS:
  System.Void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan)
  System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree)
  System.Void Dispose()
  System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree)
  System.Void PatchJump(System.Int32 offset, System.Int32 jumpDest)
  System.Void Emit(System.Int32 op)
  System.Void Emit(System.Int32 op, System.Int32 opd1)
  System.Void Emit(System.Int32 op, System.Int32 opd1, System.Int32 opd2)
  System.Int32 StringCode(System.String str)
  System.Int32 MapCapnum(System.Int32 capnum)
  System.Void EmitFragment(System.Int32 nodetype, System.Text.RegularExpressions.RegexNode node, System.Int32 curIndex)
END_CLASS

CLASS: Unity.ThrowStub
TYPE:  class
TOKEN: 0x200038D
EXTENDS: ObjectDisposedException
FIELDS:
METHODS:
  System.Void ThrowNotSupportedException()
END_CLASS

