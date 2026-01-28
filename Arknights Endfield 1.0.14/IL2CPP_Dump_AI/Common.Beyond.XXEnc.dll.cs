// ========================================================
// Dumped by @desirepro
// Assembly: Common.Beyond.XXEnc.dll
// Classes:  6
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.XXEnc.XXE1
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  public    static  System.Int32                    allowedKeyLength  // 0x0
  public    static  System.Int32                    allowedNonceLength  // 0x0
  public    static  System.Int32                    processBytesAtTime  // 0x0
  private   static  System.Int32                    stateLength  // 0x0
  private   readonly System.UInt32[]                 state  // 0x10
  private           System.Boolean                  isDisposed  // 0x18
  private           System.UInt32[]                 x  // 0x20
  private           System.Byte[]                   tmp  // 0x28
  private           System.Byte                     processedIdx  // 0x30
  private   static readonly System.Byte[]                   sigma  // 0x0
  private   static readonly System.Byte[]                   tau  // 0x8
METHODS:
  System.Void .ctor(System.ReadOnlySpan<System.Byte> key, System.ReadOnlySpan<System.Byte> nonce, System.UInt32 counter)
  System.UInt32[] get_State()
  System.Void KeySetup(System.ReadOnlySpan<System.Byte> key)
  System.Void IvSetup(System.ReadOnlySpan<System.Byte> nonce, System.UInt32 counter)
  System.Void EncryptBytes(System.Byte[] output, System.Byte[] input, System.Int32 numBytes)
  System.Void EncryptStream(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime)
  System.Threading.Tasks.Task EncryptStreamAsync(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime)
  System.Void EncryptBytes(System.Byte[] output, System.Byte[] input)
  System.Void TransformBytes(System.Byte[] inoutput)
  System.Void TransformBytes(System.Byte[] inoutput, System.Int32 inoffset, System.Int32 len)
  System.Void TransformBytes(System.Span<System.Byte> inoutput)
  System.Void CreateWorkSpace()
  System.Byte[] EncryptBytes(System.Byte[] input, System.Int32 numBytes)
  System.Byte[] EncryptBytes(System.Byte[] input)
  System.Byte[] EncryptString(System.String input)
  System.Void DecryptBytes(System.Byte[] output, System.Byte[] input, System.Int32 numBytes)
  System.Void DecryptStream(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime)
  System.Threading.Tasks.Task DecryptStreamAsync(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime)
  System.Void DecryptBytes(System.Byte[] output, System.Byte[] input)
  System.Byte[] DecryptBytes(System.Byte[] input, System.Int32 numBytes)
  System.Byte[] DecryptBytes(System.Byte[] input)
  System.String DecryptUTF8ByteArray(System.Byte[] input)
  System.Void WorkStreams(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime)
  System.Threading.Tasks.Task WorkStreamsAsync(System.IO.Stream output, System.IO.Stream input, System.Int32 howManyBytesToProcessAtTime)
  System.Void WorkBytes(System.Byte[] inoutput)
  System.Void WorkBytes(System.Byte[] output, System.Byte[] input, System.Int32 numBytes)
  System.Void WorkBytes(System.Byte[] output, System.Int32 outoffset, System.Byte[] input, System.Int32 inoffset, System.Int32 numBytes)
  System.Void WorkBytes(System.Span<System.Byte> output, System.Span<System.Byte> input)
  System.Void RecalXORStream()
  System.Void QuarterRound(System.UInt32[] x, System.UInt32 a, System.UInt32 b, System.UInt32 c, System.UInt32 d)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.XXEnc.Util
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.UInt32 Rotate(System.UInt32 v, System.Int32 c)
  System.UInt32 XOr(System.UInt32 v, System.UInt32 w)
  System.UInt32 Add(System.UInt32 v, System.UInt32 w)
  System.UInt32 AddOne(System.UInt32 v)
  System.UInt32 U8To32Little(System.ReadOnlySpan<System.Byte> p, System.Int32 inputOffset)
  System.Void ToBytes(System.Byte[] output, System.UInt32 input, System.Int32 outputOffset)
END_CLASS

