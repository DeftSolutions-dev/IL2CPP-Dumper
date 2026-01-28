// ========================================================
// Dumped by @desirepro
// Assembly: System.IO.Compression.dll
// Classes:  18
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Brotli
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque)
  System.Int32 BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut)
  System.Void BrotliDecoderDestroyInstance(System.IntPtr state)
  System.Boolean BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state)
  Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque)
  System.Boolean BrotliEncoderSetParameter(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderParameter parameter, System.UInt32 value)
  System.Boolean BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut)
  System.Boolean BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state)
  System.Void BrotliEncoderDestroyInstance(System.IntPtr state)
END_CLASS

CLASS: Interop
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
END_CLASS

CLASS: SR
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.String Format(System.String resourceFormat, System.Object p1)
  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3)
END_CLASS

CLASS: TaskWrapperAsyncResult
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private   readonly System.Threading.Tasks.Task     Task  // 0x10
  private   readonly System.Object                   _state  // 0x18
  private   readonly System.Boolean                  _completedSynchronously  // 0x20
METHODS:
  System.Void .ctor(System.Threading.Tasks.Task task, System.Object state, System.Boolean completedSynchronously)
  System.Object System.IAsyncResult.get_AsyncState()
  System.Boolean System.IAsyncResult.get_CompletedSynchronously()
  System.Boolean System.IAsyncResult.get_IsCompleted()
  System.Threading.WaitHandle System.IAsyncResult.get_AsyncWaitHandle()
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle
TYPE:  class
TOKEN: 0x2000011
EXTENDS: SafeHandle
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean ReleaseHandle()
  System.Boolean get_IsInvalid()
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle
TYPE:  class
TOKEN: 0x2000012
EXTENDS: SafeHandle
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean ReleaseHandle()
  System.Boolean get_IsInvalid()
END_CLASS

CLASS: System.IO.Compression.BrotliStream
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Stream
FIELDS:
  private           System.IO.Stream                _stream  // 0x28
  private   readonly System.Byte[]                   _buffer  // 0x30
  private   readonly System.Boolean                  _leaveOpen  // 0x38
  private   readonly System.IO.Compression.CompressionMode_mode  // 0x3C
  private           System.Int32                    _activeAsyncOperation  // 0x40
  private           System.IO.Compression.BrotliDecoder_decoder  // 0x48
  private           System.Int32                    _bufferOffset  // 0x58
  private           System.Int32                    _bufferCount  // 0x5C
  private           System.IO.Compression.BrotliEncoder_encoder  // 0x60
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen)
  System.Void EnsureNotDisposed()
  System.Void Dispose(System.Boolean disposing)
  System.Void ValidateParameters(System.Byte[] array, System.Int32 offset, System.Int32 count)
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Boolean get_CanSeek()
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Void SetLength(System.Int64 value)
  System.Boolean get_AsyncOperationIsActive()
  System.Void EnsureNoActiveAsyncOperation()
  System.Void AsyncOperationStarting()
  System.Void AsyncOperationCompleting()
  System.Void ThrowInvalidBeginCall()
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Int32 Read(System.Span<System.Byte> buffer)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask<System.Int32> FinishReadAsyncMemory(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel)
  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, System.Boolean leaveOpen)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Write(System.ReadOnlySpan<System.Byte> buffer)
  System.Void WriteCore(System.ReadOnlySpan<System.Byte> buffer, System.Boolean isFinalBlock)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  System.Void Flush()
  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.IO.Compression.BrotliUtils
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Int32 GetQualityFromCompressionLevel(System.IO.Compression.CompressionLevel level)
END_CLASS

CLASS: System.IO.Compression.BrotliDecoder
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private           Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle_state  // 0x10
  private           System.Boolean                  _disposed  // 0x18
METHODS:
  System.Void InitializeDecoder()
  System.Void EnsureInitialized()
  System.Void Dispose()
  System.Void EnsureNotDisposed()
  System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten)
END_CLASS

CLASS: System.IO.Compression.BrotliEncoder
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private           Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle_state  // 0x10
  private           System.Boolean                  _disposed  // 0x18
METHODS:
  System.Void .ctor(System.Int32 quality, System.Int32 window)
  System.Void InitializeEncoder()
  System.Void EnsureInitialized()
  System.Void Dispose()
  System.Void EnsureNotDisposed()
  System.Void SetQuality(System.Int32 quality)
  System.Void SetWindow(System.Int32 window)
  System.Buffers.OperationStatus Flush(System.Memory<System.Byte> destination, System.Int32& bytesWritten)
  System.Buffers.OperationStatus Flush(System.Span<System.Byte> destination, System.Int32& bytesWritten)
  System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<System.Byte> source, System.Memory<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock)
  System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock)
  System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.IO.Compression.BrotliEncoderOperation operation)
END_CLASS

CLASS: System.IO.Compression.BrotliEncoderOperation
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.Compression.BrotliEncoderOperationProcess  // 0x0
  public    static  System.IO.Compression.BrotliEncoderOperationFlush  // 0x0
  public    static  System.IO.Compression.BrotliEncoderOperationFinish  // 0x0
  public    static  System.IO.Compression.BrotliEncoderOperationEmitMetadata  // 0x0
METHODS:
END_CLASS

CLASS: System.IO.Compression.BrotliEncoderParameter
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.Compression.BrotliEncoderParameterMode  // 0x0
  public    static  System.IO.Compression.BrotliEncoderParameterQuality  // 0x0
  public    static  System.IO.Compression.BrotliEncoderParameterLGWin  // 0x0
  public    static  System.IO.Compression.BrotliEncoderParameterLGBlock  // 0x0
  public    static  System.IO.Compression.BrotliEncoderParameterLCModeling  // 0x0
  public    static  System.IO.Compression.BrotliEncoderParameterSizeHint  // 0x0
METHODS:
END_CLASS

CLASS: System.Threading.Tasks.TaskToApm
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, System.Object state)
  System.Void End(System.IAsyncResult asyncResult)
  TResult End(System.IAsyncResult asyncResult)
  System.Void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult)
END_CLASS

