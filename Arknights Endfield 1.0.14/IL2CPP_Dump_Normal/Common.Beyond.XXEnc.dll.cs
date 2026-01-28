// ========================================================
// Dumped by @desirepro
// Assembly: Common.Beyond.XXEnc.dll
// Classes:  6
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.XXEnc
{

    // TypeToken: 0x2000002
    public class XXE1, IDisposable
    {
        // Fields
        public static System.Int32 allowedKeyLength;        // 0x0
        public static System.Int32 allowedNonceLength;        // 0x0
        public static System.Int32 processBytesAtTime;        // 0x0
        private static System.Int32 stateLength;        // 0x0
        private readonly System.UInt32[] state;        // 0x10
        private System.Boolean isDisposed;        // 0x18
        private System.UInt32[] x;        // 0x20
        private System.Byte[] tmp;        // 0x28
        private System.Byte processedIdx;        // 0x30
        private static readonly System.Byte[] sigma;        // 0x0
        private static readonly System.Byte[] tau;        // 0x8

        // Methods
        private System.Void .ctor(System.ReadOnlySpan<System.Byte> key, System.ReadOnlySpan<System.Byte> nonce, System.UInt32 counter) { }
        private System.UInt32[] get_State() { }
        private System.Void KeySetup(System.ReadOnlySpan<System.Byte> key) { }
        private System.Void IvSetup(System.ReadOnlySpan<System.Byte> nonce, System.UInt32 counter) { }
        private System.Void EncryptBytes(System.Byte[] output, System.Byte[] input, System.Int32 numBytes) { }
        private System.Void EncryptStream(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime) { }
        private System.Threading.Tasks.Task EncryptStreamAsync(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime) { }
        private System.Void EncryptBytes(System.Byte[] output, System.Byte[] input) { }
        private System.Void TransformBytes(System.Byte[] inoutput) { }
        private System.Void TransformBytes(System.Byte[] inoutput, System.Int32 inoffset, System.Int32 len) { }
        private System.Void TransformBytes(System.Span<System.Byte> inoutput) { }
        private System.Void CreateWorkSpace() { }
        private System.Byte[] EncryptBytes(System.Byte[] input, System.Int32 numBytes) { }
        private System.Byte[] EncryptBytes(System.Byte[] input) { }
        private System.Byte[] EncryptString(System.String input) { }
        private System.Void DecryptBytes(System.Byte[] output, System.Byte[] input, System.Int32 numBytes) { }
        private System.Void DecryptStream(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime) { }
        private System.Threading.Tasks.Task DecryptStreamAsync(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime) { }
        private System.Void DecryptBytes(System.Byte[] output, System.Byte[] input) { }
        private System.Byte[] DecryptBytes(System.Byte[] input, System.Int32 numBytes) { }
        private System.Byte[] DecryptBytes(System.Byte[] input) { }
        private System.String DecryptUTF8ByteArray(System.Byte[] input) { }
        private System.Void WorkStreams(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime) { }
        private System.Threading.Tasks.Task WorkStreamsAsync(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime) { }
        private System.Void WorkBytes(System.Byte[] inoutput) { }
        private System.Void WorkBytes(System.Byte[] output, System.Byte[] input, System.Int32 numBytes) { }
        private System.Void WorkBytes(System.Byte[] output, System.Int32 outoffset, System.Byte[] input, System.Int32 inoffset, System.Int32 numBytes) { }
        private System.Void WorkBytes(System.Span<System.Byte> output, System.Span<System.Byte> input) { }
        private System.Void RecalXORStream() { }
        private System.Void QuarterRound(System.UInt32[] x, System.UInt32 a, System.UInt32 b, System.UInt32 c, System.UInt32 d) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public class Util
    {
        // Methods
        private System.UInt32 Rotate(System.UInt32 v, System.Int32 c) { }
        private System.UInt32 XOr(System.UInt32 v, System.UInt32 w) { }
        private System.UInt32 Add(System.UInt32 v, System.UInt32 w) { }
        private System.UInt32 AddOne(System.UInt32 v) { }
        private System.UInt32 U8To32Little(System.ReadOnlySpan<System.Byte> p, System.Int32 inputOffset) { }
        private System.Void ToBytes(System.Byte[] output, System.UInt32 input, System.Int32 outputOffset) { }

    }

}

