// ========================================================
// Dumped by @desirepro
// Assembly: System.IO.Compression.dll
// Classes:  18
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public class Brotli
    {
        // Methods
        private Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque) { }
        private System.Int32 BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut) { }
        private System.Void BrotliDecoderDestroyInstance(System.IntPtr state) { }
        private System.Boolean BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state) { }
        private Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque) { }
        private System.Boolean BrotliEncoderSetParameter(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderParameter parameter, System.UInt32 value) { }
        private System.Boolean BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut) { }
        private System.Boolean BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state) { }
        private System.Void BrotliEncoderDestroyInstance(System.IntPtr state) { }

    }

    // TypeToken: 0x2000002
    public class Interop
    {
    }

    // TypeToken: 0x2000004
    public class SR
    {
        // Methods
        private System.String Format(System.String resourceFormat, System.Object p1) { }
        private System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3) { }

    }

    // TypeToken: 0x200000F
    public class TaskWrapperAsyncResult, IAsyncResult
    {
        // Fields
        private readonly System.Threading.Tasks.Task Task;        // 0x10
        private readonly System.Object _state;        // 0x18
        private readonly System.Boolean _completedSynchronously;        // 0x20

        // Methods
        private System.Void .ctor(System.Threading.Tasks.Task task, System.Object state, System.Boolean completedSynchronously) { }
        private System.Object System.IAsyncResult.get_AsyncState() { }
        private System.Boolean System.IAsyncResult.get_CompletedSynchronously() { }
        private System.Boolean System.IAsyncResult.get_IsCompleted() { }
        private System.Threading.WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

    }

namespace Microsoft.Win32.SafeHandles
{

    // TypeToken: 0x2000011
    public class SafeBrotliEncoderHandle : SafeHandle
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean ReleaseHandle() { }
        private System.Boolean get_IsInvalid() { }

    }

    // TypeToken: 0x2000012
    public class SafeBrotliDecoderHandle : SafeHandle
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean ReleaseHandle() { }
        private System.Boolean get_IsInvalid() { }

    }

}

namespace System.IO.Compression
{

    // TypeToken: 0x2000005
    public class BrotliStream : Stream
    {
        // Fields
        private System.IO.Stream _stream;        // 0x28
        private readonly System.Byte[] _buffer;        // 0x30
        private readonly System.Boolean _leaveOpen;        // 0x38
        private readonly System.IO.Compression.CompressionMode _mode;        // 0x3C
        private System.Int32 _activeAsyncOperation;        // 0x40
        private System.IO.Compression.BrotliDecoder _decoder;        // 0x48
        private System.Int32 _bufferOffset;        // 0x58
        private System.Int32 _bufferCount;        // 0x5C
        private System.IO.Compression.BrotliEncoder _encoder;        // 0x60

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen) { }
        private System.Void EnsureNotDisposed() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void ValidateParameters(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Boolean get_CanSeek() { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Boolean get_AsyncOperationIsActive() { }
        private System.Void EnsureNoActiveAsyncOperation() { }
        private System.Void AsyncOperationStarting() { }
        private System.Void AsyncOperationCompleting() { }
        private System.Void ThrowInvalidBeginCall() { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Int32 Read(System.Span<System.Byte> buffer) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask<System.Int32> FinishReadAsyncMemory(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        private System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, System.Boolean leaveOpen) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Write(System.ReadOnlySpan<System.Byte> buffer) { }
        private System.Void WriteCore(System.ReadOnlySpan<System.Byte> buffer, System.Boolean isFinalBlock) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Flush() { }
        private System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x2000009
    public class BrotliUtils
    {
        // Methods
        private System.Int32 GetQualityFromCompressionLevel(System.IO.Compression.CompressionLevel level) { }

    }

    // TypeToken: 0x200000A
    public struct BrotliDecoder, IDisposable
    {
        // Fields
        private Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle _state;        // 0x10
        private System.Boolean _disposed;        // 0x18

        // Methods
        private System.Void InitializeDecoder() { }
        private System.Void EnsureInitialized() { }
        private System.Void Dispose() { }
        private System.Void EnsureNotDisposed() { }
        private System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten) { }

    }

    // TypeToken: 0x200000B
    public struct BrotliEncoder, IDisposable
    {
        // Fields
        private Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle _state;        // 0x10
        private System.Boolean _disposed;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 quality, System.Int32 window) { }
        private System.Void InitializeEncoder() { }
        private System.Void EnsureInitialized() { }
        private System.Void Dispose() { }
        private System.Void EnsureNotDisposed() { }
        private System.Void SetQuality(System.Int32 quality) { }
        private System.Void SetWindow(System.Int32 window) { }
        private System.Buffers.OperationStatus Flush(System.Memory<System.Byte> destination, System.Int32& bytesWritten) { }
        private System.Buffers.OperationStatus Flush(System.Span<System.Byte> destination, System.Int32& bytesWritten) { }
        private System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<System.Byte> source, System.Memory<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock) { }
        private System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock) { }
        private System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.IO.Compression.BrotliEncoderOperation operation) { }

    }

    // TypeToken: 0x200000C
    public struct BrotliEncoderOperation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.Compression.BrotliEncoderOperation Process;        // 0x0
        public static System.IO.Compression.BrotliEncoderOperation Flush;        // 0x0
        public static System.IO.Compression.BrotliEncoderOperation Finish;        // 0x0
        public static System.IO.Compression.BrotliEncoderOperation EmitMetadata;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct BrotliEncoderParameter
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.Compression.BrotliEncoderParameter Mode;        // 0x0
        public static System.IO.Compression.BrotliEncoderParameter Quality;        // 0x0
        public static System.IO.Compression.BrotliEncoderParameter LGWin;        // 0x0
        public static System.IO.Compression.BrotliEncoderParameter LGBlock;        // 0x0
        public static System.IO.Compression.BrotliEncoderParameter LCModeling;        // 0x0
        public static System.IO.Compression.BrotliEncoderParameter SizeHint;        // 0x0

    }

}

namespace System.Threading.Tasks
{

    // TypeToken: 0x200000E
    public class TaskToApm
    {
        // Methods
        private System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, System.Object state) { }
        private System.Void End(System.IAsyncResult asyncResult) { }
        private TResult End(System.IAsyncResult asyncResult) { }
        private System.Void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult) { }

    }

}

