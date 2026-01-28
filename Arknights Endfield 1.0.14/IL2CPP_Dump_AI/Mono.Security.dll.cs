// ========================================================
// Dumped by @desirepro
// Assembly: Mono.Security.dll
// Classes:  104
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Locale
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.String GetText(System.String msg)
  System.String GetText(System.String fmt, System.Object[] args)
END_CLASS

CLASS: ContentInfo
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           System.String                   contentType  // 0x10
  private           Mono.Security.ASN1              content  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String oid)
  System.Void .ctor(System.Byte[] data)
  System.Void .ctor(Mono.Security.ASN1 asn1)
  Mono.Security.ASN1 get_ASN1()
  Mono.Security.ASN1 get_Content()
  System.Void set_Content(Mono.Security.ASN1 value)
  System.String get_ContentType()
  System.Void set_ContentType(System.String value)
  Mono.Security.ASN1 GetASN1()
END_CLASS

CLASS: EncryptedData
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Byte                     _version  // 0x10
  private           Mono.Security.PKCS7.ContentInfo _content  // 0x18
  private           Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm  // 0x20
  private           System.Byte[]                   _encrypted  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(Mono.Security.ASN1 asn1)
  Mono.Security.PKCS7.ContentInfo get_EncryptionAlgorithm()
  System.Byte[] get_EncryptedContent()
END_CLASS

CLASS: SignedData
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private           System.Byte                     version  // 0x10
  private           System.String                   hashAlgorithm  // 0x18
  private           Mono.Security.PKCS7.ContentInfo contentInfo  // 0x20
  private           Mono.Security.X509.X509CertificateCollectioncerts  // 0x28
  private           System.Collections.ArrayList    crls  // 0x30
  private           Mono.Security.PKCS7.SignerInfo  signerInfo  // 0x38
  private           System.Boolean                  mda  // 0x40
METHODS:
  System.Void .ctor(Mono.Security.ASN1 asn1)
  Mono.Security.X509.X509CertificateCollection get_Certificates()
  Mono.Security.PKCS7.ContentInfo get_ContentInfo()
  System.Void set_HashName(System.String value)
  Mono.Security.PKCS7.SignerInfo get_SignerInfo()
  System.String OidToName(System.String oid)
END_CLASS

CLASS: SignerInfo
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private           System.Byte                     version  // 0x10
  private           System.String                   hashAlgorithm  // 0x18
  private           System.Collections.ArrayList    authenticatedAttributes  // 0x20
  private           System.Collections.ArrayList    unauthenticatedAttributes  // 0x28
  private           System.Byte[]                   signature  // 0x30
  private           System.String                   issuer  // 0x38
  private           System.Byte[]                   serial  // 0x40
  private           System.Byte[]                   ski  // 0x48
METHODS:
  System.Void .ctor()
  System.Void .ctor(Mono.Security.ASN1 asn1)
  System.String get_IssuerName()
  System.Byte[] get_SerialNumber()
  System.Collections.ArrayList get_AuthenticatedAttributes()
  System.String get_HashName()
  System.Void set_HashName(System.String value)
  System.Byte[] get_Signature()
  System.Collections.ArrayList get_UnauthenticatedAttributes()
  System.Byte get_Version()
END_CLASS

CLASS: DeriveBytes
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static  System.Byte[]                   keyDiversifier  // 0x0
  private   static  System.Byte[]                   ivDiversifier  // 0x8
  private   static  System.Byte[]                   macDiversifier  // 0x10
  private           System.String                   _hashName  // 0x10
  private           System.Int32                    _iterations  // 0x18
  private           System.Byte[]                   _password  // 0x20
  private           System.Byte[]                   _salt  // 0x28
METHODS:
  System.Void .ctor()
  System.Void set_HashName(System.String value)
  System.Void set_IterationCount(System.Int32 value)
  System.Void set_Password(System.Byte[] value)
  System.Void set_Salt(System.Byte[] value)
  System.Void Adjust(System.Byte[] a, System.Int32 aOff, System.Byte[] b)
  System.Byte[] Derive(System.Byte[] diversifier, System.Int32 n)
  System.Byte[] DeriveKey(System.Int32 size)
  System.Byte[] DeriveIV(System.Int32 size)
  System.Byte[] DeriveMAC(System.Int32 size)
  System.Void .cctor()
END_CLASS

CLASS: X509CrlEntry
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           System.Byte[]                   sn  // 0x10
  private           System.DateTime                 revocationDate  // 0x18
  private           Mono.Security.X509.X509ExtensionCollectionextensions  // 0x20
METHODS:
  System.Void .ctor(Mono.Security.ASN1 entry)
  System.Byte[] get_SerialNumber()
  System.DateTime get_RevocationDate()
  Mono.Security.X509.X509ExtensionCollection get_Extensions()
END_CLASS

CLASS: X509CertificateEnumerator
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
METHODS:
  System.Void .ctor(Mono.Security.X509.X509CertificateCollection mappings)
  Mono.Security.X509.X509Certificate get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
  System.Boolean MoveNext()
END_CLASS

CLASS: AttributeTypeAndValue
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  private           System.String                   oid  // 0x10
  private           System.String                   attrValue  // 0x18
  private           System.Int32                    upperBound  // 0x20
  private           System.Byte                     encoding  // 0x24
METHODS:
  System.Void .ctor(System.String oid, System.Int32 upperBound)
  System.Void .ctor(System.String oid, System.Int32 upperBound, System.Byte encoding)
  System.Void set_Value(System.String value)
  Mono.Security.ASN1 GetASN1(System.Byte encoding)
  Mono.Security.ASN1 GetASN1()
  System.Byte SelectBestEncoding()
END_CLASS

CLASS: CommonName
TYPE:  class
TOKEN: 0x200001D
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SerialNumber
TYPE:  class
TOKEN: 0x200001E
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: LocalityName
TYPE:  class
TOKEN: 0x200001F
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: StateOrProvinceName
TYPE:  class
TOKEN: 0x2000020
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: OrganizationName
TYPE:  class
TOKEN: 0x2000021
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: OrganizationalUnitName
TYPE:  class
TOKEN: 0x2000022
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EmailAddress
TYPE:  class
TOKEN: 0x2000023
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DomainComponent
TYPE:  class
TOKEN: 0x2000024
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UserId
TYPE:  class
TOKEN: 0x2000025
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Oid
TYPE:  class
TOKEN: 0x2000026
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor(System.String oid)
END_CLASS

CLASS: Title
TYPE:  class
TOKEN: 0x2000027
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CountryName
TYPE:  class
TOKEN: 0x2000028
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DnQualifier
TYPE:  class
TOKEN: 0x2000029
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Surname
TYPE:  class
TOKEN: 0x200002A
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: GivenName
TYPE:  class
TOKEN: 0x200002B
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Initial
TYPE:  class
TOKEN: 0x200002C
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PrivateKeyInfo
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private           System.Int32                    _version  // 0x10
  private           System.String                   _algorithm  // 0x18
  private           System.Byte[]                   _key  // 0x20
  private           System.Collections.ArrayList    _list  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Byte[] data)
  System.String get_Algorithm()
  System.Void set_Algorithm(System.String value)
  System.Byte[] get_PrivateKey()
  System.Void set_PrivateKey(System.Byte[] value)
  System.Void Decode(System.Byte[] data)
  System.Byte[] GetBytes()
  System.Byte[] RemoveLeadingZero(System.Byte[] bigInt)
  System.Byte[] Normalize(System.Byte[] bigInt, System.Int32 length)
  System.Security.Cryptography.RSA DecodeRSA(System.Byte[] keypair)
  System.Byte[] Encode(System.Security.Cryptography.RSA rsa)
  System.Security.Cryptography.DSA DecodeDSA(System.Byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters)
  System.Byte[] Encode(System.Security.Cryptography.DSA dsa)
  System.Byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa)
END_CLASS

CLASS: EncryptedPrivateKeyInfo
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  private           System.String                   _algorithm  // 0x10
  private           System.Byte[]                   _salt  // 0x18
  private           System.Int32                    _iterations  // 0x20
  private           System.Byte[]                   _data  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Byte[] data)
  System.String get_Algorithm()
  System.Void set_Algorithm(System.String value)
  System.Byte[] get_EncryptedData()
  System.Void set_EncryptedData(System.Byte[] value)
  System.Byte[] get_Salt()
  System.Int32 get_IterationCount()
  System.Void set_IterationCount(System.Int32 value)
  System.Void Decode(System.Byte[] data)
  System.Byte[] GetBytes()
END_CLASS

CLASS: KeyGeneratedEventHandler
TYPE:  class
TOKEN: 0x2000052
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.EventArgs e)
END_CLASS

CLASS: Sign
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Math.BigInteger.Sign       Negative  // 0x0
  public    static  Mono.Math.BigInteger.Sign       Zero  // 0x0
  public    static  Mono.Math.BigInteger.Sign       Positive  // 0x0
METHODS:
END_CLASS

CLASS: ModulusRing
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private           Mono.Math.BigInteger            mod  // 0x10
  private           Mono.Math.BigInteger            constant  // 0x18
METHODS:
  System.Void .ctor(Mono.Math.BigInteger modulus)
  System.Void BarrettReduction(Mono.Math.BigInteger x)
  Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b)
  Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b)
  Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k)
  Mono.Math.BigInteger Pow(System.UInt32 b, Mono.Math.BigInteger exp)
END_CLASS

CLASS: Kernel
TYPE:  class
TOKEN: 0x2000058
FIELDS:
METHODS:
  Mono.Math.BigInteger AddSameSign(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small)
  System.Void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small)
  System.Void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.UInt32 SingleByteDivideInPlace(Mono.Math.BigInteger n, System.UInt32 d)
  System.UInt32 DwordMod(Mono.Math.BigInteger n, System.UInt32 d)
  Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, System.UInt32 d)
  Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, System.Int32 n)
  Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, System.Int32 n)
  System.Void Multiply(System.UInt32[] x, System.UInt32 xOffset, System.UInt32 xLen, System.UInt32[] y, System.UInt32 yOffset, System.UInt32 yLen, System.UInt32[] d, System.UInt32 dOffset)
  System.Void MultiplyMod2p32pmod(System.UInt32[] x, System.Int32 xOffset, System.Int32 xLen, System.UInt32[] y, System.Int32 yOffest, System.Int32 yLen, System.UInt32[] d, System.Int32 dOffset, System.Int32 mod)
  System.UInt32 modInverse(Mono.Math.BigInteger bi, System.UInt32 modulus)
  Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus)
END_CLASS

CLASS: __StaticArrayInitTypeSize=3
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=9
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=10
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=18
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=48
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=64
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=3132
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Math.BigInteger
TYPE:  class
TOKEN: 0x2000055
FIELDS:
  private           System.UInt32                   length  // 0x10
  private           System.UInt32[]                 data  // 0x18
  private   static readonly System.UInt32[]                 smallPrimes  // 0x0
  private   static  System.Security.Cryptography.RandomNumberGeneratorrng  // 0x8
METHODS:
  System.Void .ctor(Mono.Math.BigInteger.Sign sign, System.UInt32 len)
  System.Void .ctor(Mono.Math.BigInteger bi)
  System.Void .ctor(Mono.Math.BigInteger bi, System.UInt32 len)
  System.Void .ctor(System.Byte[] inData)
  System.Void .ctor(System.UInt32 ui)
  Mono.Math.BigInteger op_Implicit(System.UInt32 value)
  Mono.Math.BigInteger op_Implicit(System.Int32 value)
  Mono.Math.BigInteger op_Addition(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.UInt32 op_Modulus(Mono.Math.BigInteger bi, System.UInt32 ui)
  Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, System.Int32 shiftVal)
  Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, System.Int32 shiftVal)
  System.Security.Cryptography.RandomNumberGenerator get_Rng()
  Mono.Math.BigInteger GenerateRandom(System.Int32 bits, System.Security.Cryptography.RandomNumberGenerator rng)
  Mono.Math.BigInteger GenerateRandom(System.Int32 bits)
  System.Int32 BitCount()
  System.Boolean TestBit(System.Int32 bitNum)
  System.Void SetBit(System.UInt32 bitNum)
  System.Void SetBit(System.UInt32 bitNum, System.Boolean value)
  System.Int32 LowestSetBit()
  System.Byte[] GetBytes()
  System.Boolean op_Equality(Mono.Math.BigInteger bi1, System.UInt32 ui)
  System.Boolean op_Inequality(Mono.Math.BigInteger bi1, System.UInt32 ui)
  System.Boolean op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.Boolean op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.Boolean op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.Boolean op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.Boolean op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.Boolean op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  System.String ToString(System.UInt32 radix)
  System.String ToString(System.UInt32 radix, System.String characterSet)
  System.Void Normalize()
  System.Void Clear()
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean Equals(System.Object o)
  Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus)
  Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n)
  Mono.Math.BigInteger GeneratePseudoPrime(System.Int32 bits)
  System.Void Incr2()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Math.Prime.ConfidenceFactor
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Math.Prime.ConfidenceFactorExtraLow  // 0x0
  public    static  Mono.Math.Prime.ConfidenceFactorLow  // 0x0
  public    static  Mono.Math.Prime.ConfidenceFactorMedium  // 0x0
  public    static  Mono.Math.Prime.ConfidenceFactorHigh  // 0x0
  public    static  Mono.Math.Prime.ConfidenceFactorExtraHigh  // 0x0
  public    static  Mono.Math.Prime.ConfidenceFactorProvable  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Math.Prime.PrimalityTest
TYPE:  class
TOKEN: 0x200005A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence)
END_CLASS

CLASS: Mono.Math.Prime.PrimalityTests
TYPE:  class
TOKEN: 0x200005B
FIELDS:
METHODS:
  System.Int32 GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence)
  System.Boolean RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence)
END_CLASS

CLASS: Mono.Math.Prime.Generator.PrimeGeneratorBase
TYPE:  class
TOKEN: 0x200005C
FIELDS:
METHODS:
  Mono.Math.Prime.ConfidenceFactor get_Confidence()
  Mono.Math.Prime.PrimalityTest get_PrimalityTest()
  System.Int32 get_TrialDivisionBounds()
  Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits)
  System.Void .ctor()
END_CLASS

CLASS: Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase
TYPE:  class
TOKEN: 0x200005D
EXTENDS: PrimeGeneratorBase
FIELDS:
METHODS:
  Mono.Math.BigInteger GenerateSearchBase(System.Int32 bits, System.Object context)
  Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits)
  Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits, System.Object context)
  System.Boolean IsPrimeAcceptable(Mono.Math.BigInteger bi, System.Object context)
  System.Void .ctor()
END_CLASS

CLASS: Mono.Security.ASN1
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.Byte                     m_nTag  // 0x10
  private           System.Byte[]                   m_aValue  // 0x18
  private           System.Collections.ArrayList    elist  // 0x20
METHODS:
  System.Void .ctor(System.Byte tag)
  System.Void .ctor(System.Byte tag, System.Byte[] data)
  System.Void .ctor(System.Byte[] data)
  System.Int32 get_Count()
  System.Byte get_Tag()
  System.Int32 get_Length()
  System.Byte[] get_Value()
  System.Void set_Value(System.Byte[] value)
  System.Boolean CompareArray(System.Byte[] array1, System.Byte[] array2)
  System.Boolean CompareValue(System.Byte[] value)
  Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1)
  System.Byte[] GetBytes()
  System.Void Decode(System.Byte[] asn1, System.Int32& anPos, System.Int32 anLength)
  System.Void DecodeTLV(System.Byte[] asn1, System.Int32& pos, System.Byte& tag, System.Int32& length, System.Byte[]& content)
  Mono.Security.ASN1 get_Item(System.Int32 index)
  Mono.Security.ASN1 Element(System.Int32 index, System.Byte anTag)
  System.String ToString()
END_CLASS

CLASS: Mono.Security.ASN1Convert
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  Mono.Security.ASN1 FromInt32(System.Int32 value)
  Mono.Security.ASN1 FromOid(System.String oid)
  Mono.Security.ASN1 FromUnsignedBigInteger(System.Byte[] big)
  System.Int32 ToInt32(Mono.Security.ASN1 asn1)
  System.String ToOid(Mono.Security.ASN1 asn1)
  System.DateTime ToDateTime(Mono.Security.ASN1 time)
END_CLASS

CLASS: Mono.Security.BitConverterLE
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Byte[] GetUIntBytes(System.Byte* bytes)
  System.Byte[] GetULongBytes(System.Byte* bytes)
  System.Byte[] GetBytes(System.Int32 value)
  System.Byte[] GetBytes(System.Int64 value)
  System.Void UShortFromBytes(System.Byte* dst, System.Byte[] src, System.Int32 startIndex)
  System.Void UIntFromBytes(System.Byte* dst, System.Byte[] src, System.Int32 startIndex)
  System.Int32 ToInt32(System.Byte[] value, System.Int32 startIndex)
  System.UInt16 ToUInt16(System.Byte[] value, System.Int32 startIndex)
  System.UInt32 ToUInt32(System.Byte[] value, System.Int32 startIndex)
END_CLASS

CLASS: Mono.Security.PKCS7
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.Authenticode.AuthenticodeBase
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  private           System.Byte[]                   fileblock  // 0x10
  private           System.IO.Stream                fs  // 0x18
  private           System.Int32                    blockNo  // 0x20
  private           System.Int32                    blockLength  // 0x24
  private           System.Int32                    peOffset  // 0x28
  private           System.Int32                    dirSecurityOffset  // 0x2C
  private           System.Int32                    dirSecuritySize  // 0x30
  private           System.Int32                    coffSymbolTableOffset  // 0x34
  private           System.Boolean                  pe64  // 0x38
METHODS:
  System.Void .ctor()
  System.Int32 get_PEOffset()
  System.Void Open(System.String filename)
  System.Void Open(System.Byte[] rawdata)
  System.Void Close()
  System.Void ReadFirstBlock()
  System.Int32 ProcessFirstBlock()
  System.Byte[] GetSecurityEntry()
  System.Byte[] GetHash(System.Security.Cryptography.HashAlgorithm hash)
END_CLASS

CLASS: Mono.Security.Authenticode.AuthenticodeDeformatter
TYPE:  class
TOKEN: 0x2000054
EXTENDS: AuthenticodeBase
FIELDS:
  private           System.String                   filename  // 0x40
  private           System.Byte[]                   rawdata  // 0x48
  private           System.Byte[]                   hash  // 0x50
  private           Mono.Security.X509.X509CertificateCollectioncoll  // 0x58
  private           Mono.Security.ASN1              signedHash  // 0x60
  private           System.DateTime                 timestamp  // 0x68
  private           Mono.Security.X509.X509CertificatesigningCertificate  // 0x70
  private           System.Int32                    reason  // 0x78
  private           System.Boolean                  trustedRoot  // 0x7C
  private           System.Boolean                  trustedTimestampRoot  // 0x7D
  private           System.Byte[]                   entry  // 0x80
  private           Mono.Security.X509.X509Chain    signerChain  // 0x88
  private           Mono.Security.X509.X509Chain    timestampChain  // 0x90
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Byte[] rawData)
  System.Void set_RawData(System.Byte[] value)
  Mono.Security.X509.X509Certificate get_SigningCertificate()
  System.Boolean CheckSignature()
  System.Boolean CompareIssuerSerial(System.String issuer, System.Byte[] serial, Mono.Security.X509.X509Certificate x509)
  System.Boolean VerifySignature(Mono.Security.PKCS7.SignedData sd, System.Byte[] calculatedMessageDigest, System.Security.Cryptography.HashAlgorithm ha)
  System.Boolean VerifyCounterSignature(Mono.Security.PKCS7.SignerInfo cs, System.Byte[] signature)
  System.Void Reset()
END_CLASS

CLASS: Mono.Security.Cryptography.CryptoConvert
TYPE:  class
TOKEN: 0x2000048
FIELDS:
METHODS:
  System.String ToHex(System.Byte[] input)
  System.Byte FromHexChar(System.Char c)
  System.Byte[] FromHex(System.String hex)
END_CLASS

CLASS: Mono.Security.Cryptography.MD2
TYPE:  class
TOKEN: 0x2000049
EXTENDS: HashAlgorithm
FIELDS:
METHODS:
  System.Void .ctor()
  Mono.Security.Cryptography.MD2 Create()
END_CLASS

CLASS: Mono.Security.Cryptography.MD2Managed
TYPE:  class
TOKEN: 0x200004A
EXTENDS: MD2
FIELDS:
  private           System.Byte[]                   state  // 0x28
  private           System.Byte[]                   checksum  // 0x30
  private           System.Byte[]                   buffer  // 0x38
  private           System.Int32                    count  // 0x40
  private           System.Byte[]                   x  // 0x48
  private   static readonly System.Byte[]                   PI_SUBST  // 0x0
METHODS:
  System.Byte[] Padding(System.Int32 nLength)
  System.Void .ctor()
  System.Void Initialize()
  System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize)
  System.Byte[] HashFinal()
  System.Void MD2Transform(System.Byte[] state, System.Byte[] checksum, System.Byte[] block, System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Cryptography.MD4
TYPE:  class
TOKEN: 0x200004B
EXTENDS: HashAlgorithm
FIELDS:
METHODS:
  System.Void .ctor()
  Mono.Security.Cryptography.MD4 Create()
END_CLASS

CLASS: Mono.Security.Cryptography.MD4Managed
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MD4
FIELDS:
  private           System.UInt32[]                 state  // 0x28
  private           System.Byte[]                   buffer  // 0x30
  private           System.UInt32[]                 count  // 0x38
  private           System.UInt32[]                 x  // 0x40
  private           System.Byte[]                   digest  // 0x48
METHODS:
  System.Void .ctor()
  System.Void Initialize()
  System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize)
  System.Byte[] HashFinal()
  System.Byte[] Padding(System.Int32 nLength)
  System.UInt32 F(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  System.UInt32 G(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  System.UInt32 H(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  System.UInt32 ROL(System.UInt32 x, System.Byte n)
  System.Void FF(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s)
  System.Void GG(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s)
  System.Void HH(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s)
  System.Void Encode(System.Byte[] output, System.UInt32[] input)
  System.Void Decode(System.UInt32[] output, System.Byte[] input, System.Int32 index)
  System.Void MD4Transform(System.UInt32[] state, System.Byte[] block, System.Int32 index)
END_CLASS

CLASS: Mono.Security.Cryptography.PKCS1
TYPE:  class
TOKEN: 0x200004D
FIELDS:
  private   static  System.Byte[]                   emptySHA1  // 0x0
  private   static  System.Byte[]                   emptySHA256  // 0x8
  private   static  System.Byte[]                   emptySHA384  // 0x10
  private   static  System.Byte[]                   emptySHA512  // 0x18
METHODS:
  System.Boolean Compare(System.Byte[] array1, System.Byte[] array2)
  System.Byte[] I2OSP(System.Byte[] x, System.Int32 size)
  System.Byte[] OS2IP(System.Byte[] x)
  System.Byte[] RSAVP1(System.Security.Cryptography.RSA rsa, System.Byte[] s)
  System.Boolean Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Byte[] signature, System.Boolean tryNonStandardEncoding)
  System.Byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Int32 emLength)
  System.String HashNameFromOid(System.String oid, System.Boolean throwOnError)
  System.Security.Cryptography.HashAlgorithm CreateFromOid(System.String oid)
  System.Security.Cryptography.HashAlgorithm CreateFromName(System.String name)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Cryptography.PKCS8
TYPE:  class
TOKEN: 0x200004E
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.Cryptography.RSAManaged
TYPE:  class
TOKEN: 0x2000051
EXTENDS: RSA
FIELDS:
  private           System.Boolean                  isCRTpossible  // 0x20
  private           System.Boolean                  keyBlinding  // 0x21
  private           System.Boolean                  keypairGenerated  // 0x22
  private           System.Boolean                  m_disposed  // 0x23
  private           Mono.Math.BigInteger            d  // 0x28
  private           Mono.Math.BigInteger            p  // 0x30
  private           Mono.Math.BigInteger            q  // 0x38
  private           Mono.Math.BigInteger            dp  // 0x40
  private           Mono.Math.BigInteger            dq  // 0x48
  private           Mono.Math.BigInteger            qInv  // 0x50
  private           Mono.Math.BigInteger            n  // 0x58
  private           Mono.Math.BigInteger            e  // 0x60
  private           Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandlerKeyGenerated  // 0x68
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 keySize)
  System.Void Finalize()
  System.Void GenerateKeyPair()
  System.Int32 get_KeySize()
  System.Boolean get_PublicOnly()
  System.Byte[] DecryptValue(System.Byte[] rgb)
  System.Byte[] EncryptValue(System.Byte[] rgb)
  System.Security.Cryptography.RSAParameters ExportParameters(System.Boolean includePrivateParameters)
  System.Void ImportParameters(System.Security.Cryptography.RSAParameters parameters)
  System.Void Dispose(System.Boolean disposing)
  System.String ToXmlString(System.Boolean includePrivateParameters)
  System.Byte[] GetPaddedValue(Mono.Math.BigInteger value, System.Int32 length)
END_CLASS

CLASS: Mono.Security.Interface.AlertLevel
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Mono.Security.Interface.AlertLevelWarning  // 0x0
  public    static  Mono.Security.Interface.AlertLevelFatal  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.AlertDescription
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Mono.Security.Interface.AlertDescriptionCloseNotify  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionUnexpectedMessage  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionBadRecordMAC  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionDecryptionFailed_RESERVED  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionRecordOverflow  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionDecompressionFailure  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionHandshakeFailure  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionNoCertificate_RESERVED  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionBadCertificate  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionUnsupportedCertificate  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionCertificateRevoked  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionCertificateExpired  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionCertificateUnknown  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionIlegalParameter  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionUnknownCA  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionAccessDenied  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionDecodeError  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionDecryptError  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionExportRestriction  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionProtocolVersion  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionInsuficientSecurity  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionInternalError  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionUserCancelled  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionNoRenegotiation  // 0x0
  public    static  Mono.Security.Interface.AlertDescriptionUnsupportedExtension  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.Alert
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private           Mono.Security.Interface.AlertLevellevel  // 0x10
  private           Mono.Security.Interface.AlertDescriptiondescription  // 0x11
METHODS:
  Mono.Security.Interface.AlertLevel get_Level()
  Mono.Security.Interface.AlertDescription get_Description()
  System.Void .ctor(Mono.Security.Interface.AlertDescription description)
  System.Void inferAlertLevel()
  System.String ToString()
END_CLASS

CLASS: Mono.Security.Interface.ValidationResult
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private           System.Boolean                  trusted  // 0x10
  private           System.Boolean                  user_denied  // 0x11
  private           System.Int32                    error_code  // 0x14
  private           System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors>policy_errors  // 0x18
METHODS:
  System.Void .ctor(System.Boolean trusted, System.Boolean user_denied, System.Int32 error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors)
  System.Boolean get_Trusted()
  System.Boolean get_UserDenied()
END_CLASS

CLASS: Mono.Security.Interface.ICertificateValidator
TYPE:  interface
TOKEN: 0x200003C
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.CipherSuiteCode
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_NULL_WITH_NULL_NULL  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_NULL_MD5  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_EXPORT_WITH_RC4_40_MD5  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_RC4_128_MD5  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_IDEA_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_EXPORT_WITH_DES40_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_DES_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_DES_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_DES_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_DES_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_DES_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_EXPORT_WITH_RC4_40_MD5  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_RC4_128_MD5  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_DES_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_SEED_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_SEED_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_SEED_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_SEED_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_SEED_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_SEED_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_NULL_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_256_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_NULL_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_NULL_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_NULL_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_NULL_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_NULL_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_NULL_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_RC4_128_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_128_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_256_CBC_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_NULL_SHA  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_NULL_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_NULL_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_EMPTY_RENEGOTIATION_INFO_SCSV  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_CCM  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_DHE_WITH_AES_128_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_DHE_WITH_AES_256_CCM_8  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_SALSA20_SHA1  // 0x0
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_FALLBACK_SCSV  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsConnectionInfo
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  private           Mono.Security.Interface.CipherSuiteCode<CipherSuiteCode>k__BackingField  // 0x10
  private           Mono.Security.Interface.TlsProtocols<ProtocolVersion>k__BackingField  // 0x14
  private           System.String                   <PeerDomainName>k__BackingField  // 0x18
METHODS:
  Mono.Security.Interface.CipherSuiteCode get_CipherSuiteCode()
  System.Void set_CipherSuiteCode(Mono.Security.Interface.CipherSuiteCode value)
  Mono.Security.Interface.TlsProtocols get_ProtocolVersion()
  System.Void set_ProtocolVersion(Mono.Security.Interface.TlsProtocols value)
  System.Void set_PeerDomainName(System.String value)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: Mono.Security.Interface.MonoSslPolicyErrors
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsNone  // 0x0
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsRemoteCertificateNotAvailable  // 0x0
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsRemoteCertificateNameMismatch  // 0x0
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsRemoteCertificateChainErrors  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.MonoRemoteCertificateValidationCallback
TYPE:  class
TOKEN: 0x2000040
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors)
END_CLASS

CLASS: Mono.Security.Interface.MonoLocalCertificateSelectionCallback
TYPE:  class
TOKEN: 0x2000041
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsProvider
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Void .ctor()
  System.Guid get_ID()
  System.String get_Name()
  System.Boolean get_SupportsSslStream()
  System.Boolean get_SupportsConnectionInfo()
  System.Boolean get_SupportsMonoExtensions()
  System.Security.Authentication.SslProtocols get_SupportedProtocols()
  System.Boolean get_SupportsCleanShutdown()
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsProviderFactory
TYPE:  class
TOKEN: 0x2000043
FIELDS:
METHODS:
  Mono.Security.Interface.MonoTlsProvider GetProvider()
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsSettings
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private           Mono.Security.Interface.MonoRemoteCertificateValidationCallback<RemoteCertificateValidationCallback>k__BackingField  // 0x10
  private           Mono.Security.Interface.MonoLocalCertificateSelectionCallback<ClientCertificateSelectionCallback>k__BackingField  // 0x18
  private           System.Nullable<System.DateTime><CertificateValidationTime>k__BackingField  // 0x20
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollection<TrustAnchors>k__BackingField  // 0x30
  private           System.Object                   <UserSettings>k__BackingField  // 0x38
  private           System.String[]                 <CertificateSearchPaths>k__BackingField  // 0x40
  private           System.Boolean                  <SendCloseNotify>k__BackingField  // 0x48
  private           System.String[]                 <ClientCertificateIssuers>k__BackingField  // 0x50
  private           System.Boolean                  <DisallowUnauthenticatedCertificateRequest>k__BackingField  // 0x58
  private           System.Nullable<Mono.Security.Interface.TlsProtocols><EnabledProtocols>k__BackingField  // 0x5C
  private           Mono.Security.Interface.CipherSuiteCode[]<EnabledCiphers>k__BackingField  // 0x68
  private           System.Boolean                  cloned  // 0x70
  private           System.Boolean                  checkCertName  // 0x71
  private           System.Boolean                  checkCertRevocationStatus  // 0x72
  private           System.Nullable<System.Boolean> useServicePointManagerCallback  // 0x73
  private           System.Boolean                  skipSystemValidators  // 0x75
  private           System.Boolean                  callbackNeedsChain  // 0x76
  private           Mono.Security.Interface.ICertificateValidatorcertificateValidator  // 0x78
  private   static  Mono.Security.Interface.MonoTlsSettingsdefaultSettings  // 0x0
METHODS:
  Mono.Security.Interface.MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback()
  System.Void set_RemoteCertificateValidationCallback(Mono.Security.Interface.MonoRemoteCertificateValidationCallback value)
  Mono.Security.Interface.MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback()
  System.Void set_ClientCertificateSelectionCallback(Mono.Security.Interface.MonoLocalCertificateSelectionCallback value)
  System.Nullable<System.Boolean> get_UseServicePointManagerCallback()
  System.Void set_UseServicePointManagerCallback(System.Nullable<System.Boolean> value)
  System.Boolean get_CallbackNeedsCertificateChain()
  System.Nullable<System.DateTime> get_CertificateValidationTime()
  System.Void set_CertificateValidationTime(System.Nullable<System.DateTime> value)
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_TrustAnchors()
  System.Void set_TrustAnchors(System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
  System.Object get_UserSettings()
  System.Void set_UserSettings(System.Object value)
  System.String[] get_CertificateSearchPaths()
  System.Void set_CertificateSearchPaths(System.String[] value)
  System.Boolean get_SendCloseNotify()
  System.Void set_SendCloseNotify(System.Boolean value)
  System.String[] get_ClientCertificateIssuers()
  System.Void set_ClientCertificateIssuers(System.String[] value)
  System.Boolean get_DisallowUnauthenticatedCertificateRequest()
  System.Void set_DisallowUnauthenticatedCertificateRequest(System.Boolean value)
  System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols()
  System.Void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value)
  Mono.Security.Interface.CipherSuiteCode[] get_EnabledCiphers()
  System.Void set_EnabledCiphers(Mono.Security.Interface.CipherSuiteCode[] value)
  System.Void .ctor()
  Mono.Security.Interface.MonoTlsSettings get_DefaultSettings()
  Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings()
  Mono.Security.Interface.ICertificateValidator get_CertificateValidator()
  Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator)
  Mono.Security.Interface.MonoTlsSettings Clone()
  System.Void .ctor(Mono.Security.Interface.MonoTlsSettings other)
END_CLASS

CLASS: Mono.Security.Interface.TlsException
TYPE:  class
TOKEN: 0x2000045
EXTENDS: Exception
FIELDS:
  private           Mono.Security.Interface.Alert   alert  // 0x90
METHODS:
  System.Void .ctor(Mono.Security.Interface.Alert alert)
  System.Void .ctor(Mono.Security.Interface.Alert alert, System.String message)
  System.Void .ctor(Mono.Security.Interface.AlertDescription description)
  System.Void .ctor(Mono.Security.Interface.AlertDescription description, System.String message)
END_CLASS

CLASS: Mono.Security.Interface.TlsProtocolCode
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int16                    value__  // 0x10
  public    static  Mono.Security.Interface.TlsProtocolCodeTls10  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolCodeTls11  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolCodeTls12  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.TlsProtocols
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Interface.TlsProtocolsZero  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls10Client  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls10Server  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls10  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls11Client  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls11Server  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls11  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls12Client  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls12Server  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsTls12  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsClientMask  // 0x0
  public    static  Mono.Security.Interface.TlsProtocolsServerMask  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.ChallengeResponse
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private   static  System.Byte[]                   magic  // 0x0
  private   static  System.Byte[]                   nullEncMagic  // 0x8
  private           System.Boolean                  _disposed  // 0x10
  private           System.Byte[]                   _challenge  // 0x18
  private           System.Byte[]                   _lmpwd  // 0x20
  private           System.Byte[]                   _ntpwd  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String password, System.Byte[] challenge)
  System.Void Finalize()
  System.Void set_Password(System.String value)
  System.Void set_Challenge(System.Byte[] value)
  System.Byte[] get_LM()
  System.Byte[] get_NT()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Byte[] GetResponse(System.Byte[] pwd)
  System.Byte[] PrepareDESKey(System.Byte[] key56bits, System.Int32 position)
  System.Byte[] PasswordToKey(System.String password, System.Int32 position)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.ChallengeResponse2
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static  System.Byte[]                   magic  // 0x0
  private   static  System.Byte[]                   nullEncMagic  // 0x8
METHODS:
  System.Byte[] Compute_LM(System.String password, System.Byte[] challenge)
  System.Byte[] Compute_NTLM_Password(System.String password)
  System.Byte[] Compute_NTLM(System.String password, System.Byte[] challenge)
  System.Void Compute_NTLMv2_Session(System.String password, System.Byte[] challenge, System.Byte[]& lm, System.Byte[]& ntlm)
  System.Byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, System.String username, System.String password, System.String domain)
  System.Void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, System.String username, System.String password, System.String domain, System.Byte[]& lm, System.Byte[]& ntlm)
  System.Byte[] GetResponse(System.Byte[] challenge, System.Byte[] pwd)
  System.Byte[] PrepareDESKey(System.Byte[] key56bits, System.Int32 position)
  System.Byte[] PasswordToKey(System.String password, System.Int32 position)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.MessageBase
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  private   static  System.Byte[]                   header  // 0x0
  private           System.Int32                    _type  // 0x10
  private           Mono.Security.Protocol.Ntlm.NtlmFlags_flags  // 0x14
METHODS:
  System.Void .ctor(System.Int32 messageType)
  Mono.Security.Protocol.Ntlm.NtlmFlags get_Flags()
  System.Void set_Flags(Mono.Security.Protocol.Ntlm.NtlmFlags value)
  System.Int32 get_Type()
  System.Byte[] PrepareMessage(System.Int32 messageSize)
  System.Void Decode(System.Byte[] message)
  System.Boolean CheckHeader(System.Byte[] message)
  System.Byte[] GetBytes()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.NtlmAuthLevel
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelLM_and_NTLM  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelLM_and_NTLM_and_try_NTLMv2_Session  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelNTLM_only  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelNTLMv2_only  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.NtlmFlags
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateUnicode  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateOem  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsRequestTarget  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateNtlm  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateDomainSupplied  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateWorkstationSupplied  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateAlwaysSign  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateNtlm2Key  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiate128  // 0x0
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiate56  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.NtlmSettings
TYPE:  class
TOKEN: 0x2000034
FIELDS:
  private   static  Mono.Security.Protocol.Ntlm.NtlmAuthLeveldefaultAuthLevel  // 0x0
METHODS:
  Mono.Security.Protocol.Ntlm.NtlmAuthLevel get_DefaultAuthLevel()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.Type1Message
TYPE:  class
TOKEN: 0x2000035
EXTENDS: MessageBase
FIELDS:
  private           System.String                   _host  // 0x18
  private           System.String                   _domain  // 0x20
METHODS:
  System.Void .ctor()
  System.Void set_Domain(System.String value)
  System.Void set_Host(System.String value)
  System.Void Decode(System.Byte[] message)
  System.Byte[] GetBytes()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.Type2Message
TYPE:  class
TOKEN: 0x2000036
EXTENDS: MessageBase
FIELDS:
  private           System.Byte[]                   _nonce  // 0x18
  private           System.String                   _targetName  // 0x20
  private           System.Byte[]                   _targetInfo  // 0x28
METHODS:
  System.Void .ctor(System.Byte[] message)
  System.Void Finalize()
  System.Byte[] get_Nonce()
  System.String get_TargetName()
  System.Byte[] get_TargetInfo()
  System.Void Decode(System.Byte[] message)
  System.Byte[] GetBytes()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.Type3Message
TYPE:  class
TOKEN: 0x2000037
EXTENDS: MessageBase
FIELDS:
  private           Mono.Security.Protocol.Ntlm.NtlmAuthLevel_level  // 0x18
  private           System.Byte[]                   _challenge  // 0x20
  private           System.String                   _host  // 0x28
  private           System.String                   _domain  // 0x30
  private           System.String                   _username  // 0x38
  private           System.String                   _password  // 0x40
  private           Mono.Security.Protocol.Ntlm.Type2Message_type2  // 0x48
  private           System.Byte[]                   _lm  // 0x50
  private           System.Byte[]                   _nt  // 0x58
METHODS:
  System.Void .ctor(Mono.Security.Protocol.Ntlm.Type2Message type2)
  System.Void Finalize()
  System.Void set_Domain(System.String value)
  System.Void set_Password(System.String value)
  System.Void set_Username(System.String value)
  System.Void Decode(System.Byte[] message)
  System.String DecodeString(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  System.Byte[] EncodeString(System.String text)
  System.Byte[] GetBytes()
END_CLASS

CLASS: Mono.Security.X509.SafeBag
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.String                   _bagOID  // 0x10
  private           Mono.Security.ASN1              _asn1  // 0x18
METHODS:
  System.Void .ctor(System.String bagOID, Mono.Security.ASN1 asn1)
  System.String get_BagOID()
  Mono.Security.ASN1 get_ASN1()
END_CLASS

CLASS: Mono.Security.X509.PKCS12
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private           System.Byte[]                   _password  // 0x10
  private           System.Collections.ArrayList    _keyBags  // 0x18
  private           System.Collections.ArrayList    _secretBags  // 0x20
  private           Mono.Security.X509.X509CertificateCollection_certs  // 0x28
  private           System.Boolean                  _keyBagsChanged  // 0x30
  private           System.Boolean                  _secretBagsChanged  // 0x31
  private           System.Boolean                  _certsChanged  // 0x32
  private           System.Int32                    _iterations  // 0x34
  private           System.Collections.ArrayList    _safeBags  // 0x38
  private           System.Security.Cryptography.RandomNumberGenerator_rng  // 0x40
  private   static  System.Int32                    password_max_length  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Byte[] data)
  System.Void .ctor(System.Byte[] data, System.String password)
  System.Void Decode(System.Byte[] data)
  System.Void Finalize()
  System.Void set_Password(System.String value)
  System.Int32 get_IterationCount()
  System.Void set_IterationCount(System.Int32 value)
  System.Collections.ArrayList get_Keys()
  Mono.Security.X509.X509CertificateCollection get_Certificates()
  System.Security.Cryptography.RandomNumberGenerator get_RNG()
  System.Boolean Compare(System.Byte[] expected, System.Byte[] actual)
  System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount)
  System.Byte[] Decrypt(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount, System.Byte[] encryptedData)
  System.Byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed)
  System.Byte[] Encrypt(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount, System.Byte[] data)
  System.Security.Cryptography.DSAParameters GetExistingParameters(System.Boolean& found)
  System.Void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki)
  System.Void ReadSafeBag(Mono.Security.ASN1 safeBag)
  Mono.Security.ASN1 Pkcs8ShroudedKeyBagSafeBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes)
  Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes)
  System.Byte[] MAC(System.Byte[] password, System.Byte[] salt, System.Int32 iterations, System.Byte[] data)
  System.Byte[] GetBytes()
  Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, System.String algorithmOid)
  System.Void AddCertificate(Mono.Security.X509.X509Certificate cert)
  System.Void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes)
  System.Void RemoveCertificate(Mono.Security.X509.X509Certificate cert)
  System.Void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs)
  System.Boolean CompareAsymmetricAlgorithm(System.Security.Cryptography.AsymmetricAlgorithm a1, System.Security.Cryptography.AsymmetricAlgorithm a2)
  System.Void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes)
  System.Object Clone()
  System.Int32 get_MaximumPasswordLength()
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.X509.X501
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private   static  System.Byte[]                   countryName  // 0x0
  private   static  System.Byte[]                   organizationName  // 0x8
  private   static  System.Byte[]                   organizationalUnitName  // 0x10
  private   static  System.Byte[]                   commonName  // 0x18
  private   static  System.Byte[]                   localityName  // 0x20
  private   static  System.Byte[]                   stateOrProvinceName  // 0x28
  private   static  System.Byte[]                   streetAddress  // 0x30
  private   static  System.Byte[]                   serialNumber  // 0x38
  private   static  System.Byte[]                   domainComponent  // 0x40
  private   static  System.Byte[]                   userid  // 0x48
  private   static  System.Byte[]                   email  // 0x50
  private   static  System.Byte[]                   dnQualifier  // 0x58
  private   static  System.Byte[]                   title  // 0x60
  private   static  System.Byte[]                   surname  // 0x68
  private   static  System.Byte[]                   givenName  // 0x70
  private   static  System.Byte[]                   initial  // 0x78
METHODS:
  System.String ToString(Mono.Security.ASN1 seq)
  System.String ToString(Mono.Security.ASN1 seq, System.Boolean reversed, System.String separator, System.Boolean quotes)
  System.Void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, System.Boolean quotes)
  Mono.Security.X509.X520.AttributeTypeAndValue GetAttributeFromOid(System.String attributeType)
  System.Boolean IsOid(System.String oid)
  Mono.Security.X509.X520.AttributeTypeAndValue ReadAttribute(System.String value, System.Int32& pos)
  System.Boolean IsHex(System.Char c)
  System.String ReadHex(System.String value, System.Int32& pos)
  System.Int32 ReadEscaped(System.Text.StringBuilder sb, System.String value, System.Int32 pos)
  System.Int32 ReadQuoted(System.Text.StringBuilder sb, System.String value, System.Int32 pos)
  System.String ReadValue(System.String value, System.Int32& pos)
  Mono.Security.ASN1 FromString(System.String rdn)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.X509.X509Crl
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private           System.String                   issuer  // 0x10
  private           System.Byte                     version  // 0x18
  private           System.DateTime                 thisUpdate  // 0x20
  private           System.DateTime                 nextUpdate  // 0x28
  private           System.Collections.ArrayList    entries  // 0x30
  private           System.String                   signatureOID  // 0x38
  private           System.Byte[]                   signature  // 0x40
  private           Mono.Security.X509.X509ExtensionCollectionextensions  // 0x48
  private           System.Byte[]                   encoded  // 0x50
  private           System.Byte[]                   hash_value  // 0x58
METHODS:
  System.Void .ctor(System.Byte[] crl)
  System.Void Parse(System.Byte[] crl)
  Mono.Security.X509.X509ExtensionCollection get_Extensions()
  System.Byte[] get_Hash()
  System.String get_IssuerName()
  System.DateTime get_NextUpdate()
  System.Boolean Compare(System.Byte[] array1, System.Byte[] array2)
  Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509)
  Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(System.Byte[] serialNumber)
  System.Boolean VerifySignature(System.Security.Cryptography.DSA dsa)
  System.Boolean VerifySignature(System.Security.Cryptography.RSA rsa)
  System.Boolean VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa)
END_CLASS

CLASS: Mono.Security.X509.X509Certificate
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           Mono.Security.ASN1              decoder  // 0x10
  private           System.Byte[]                   m_encodedcert  // 0x18
  private           System.DateTime                 m_from  // 0x20
  private           System.DateTime                 m_until  // 0x28
  private           Mono.Security.ASN1              issuer  // 0x30
  private           System.String                   m_issuername  // 0x38
  private           System.String                   m_keyalgo  // 0x40
  private           System.Byte[]                   m_keyalgoparams  // 0x48
  private           Mono.Security.ASN1              subject  // 0x50
  private           System.String                   m_subject  // 0x58
  private           System.Byte[]                   m_publickey  // 0x60
  private           System.Byte[]                   signature  // 0x68
  private           System.String                   m_signaturealgo  // 0x70
  private           System.Byte[]                   m_signaturealgoparams  // 0x78
  private           System.Byte[]                   certhash  // 0x80
  private           System.Security.Cryptography.RSA_rsa  // 0x88
  private           System.Security.Cryptography.DSA_dsa  // 0x90
  private           System.Int32                    version  // 0x98
  private           System.Byte[]                   serialnumber  // 0xA0
  private           System.Byte[]                   issuerUniqueID  // 0xA8
  private           System.Byte[]                   subjectUniqueID  // 0xB0
  private           Mono.Security.X509.X509ExtensionCollectionextensions  // 0xB8
  private   static  System.String                   encoding_error  // 0x0
METHODS:
  System.Void Parse(System.Byte[] data)
  System.Void .ctor(System.Byte[] data)
  System.Byte[] GetUnsignedBigInteger(System.Byte[] integer)
  System.Security.Cryptography.DSA get_DSA()
  System.Void set_DSA(System.Security.Cryptography.DSA value)
  Mono.Security.X509.X509ExtensionCollection get_Extensions()
  System.Byte[] get_Hash()
  System.String get_IssuerName()
  System.String get_KeyAlgorithm()
  System.Byte[] get_KeyAlgorithmParameters()
  System.Void set_KeyAlgorithmParameters(System.Byte[] value)
  System.Byte[] get_PublicKey()
  System.Security.Cryptography.RSA get_RSA()
  System.Void set_RSA(System.Security.Cryptography.RSA value)
  System.Byte[] get_RawData()
  System.Byte[] get_SerialNumber()
  System.Byte[] get_Signature()
  System.String get_SubjectName()
  System.DateTime get_ValidFrom()
  System.DateTime get_ValidUntil()
  System.Int32 get_Version()
  System.Boolean get_IsCurrent()
  System.Boolean WasCurrent(System.DateTime instant)
  System.Boolean VerifySignature(System.Security.Cryptography.DSA dsa)
  System.Boolean VerifySignature(System.Security.Cryptography.RSA rsa)
  System.Boolean VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa)
  System.Boolean get_IsSelfSigned()
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Byte[] PEM(System.String type, System.Byte[] data)
  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.X509.X509CertificateCollection
TYPE:  class
TOKEN: 0x2000012
EXTENDS: CollectionBase
FIELDS:
METHODS:
  System.Void .ctor()
  Mono.Security.X509.X509Certificate get_Item(System.Int32 index)
  System.Int32 Add(Mono.Security.X509.X509Certificate value)
  System.Void AddRange(Mono.Security.X509.X509CertificateCollection value)
  System.Boolean Contains(Mono.Security.X509.X509Certificate value)
  Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 GetHashCode()
  System.Int32 IndexOf(Mono.Security.X509.X509Certificate value)
  System.Boolean Compare(System.Byte[] array1, System.Byte[] array2)
END_CLASS

CLASS: Mono.Security.X509.X509Chain
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private           Mono.Security.X509.X509CertificateCollectionroots  // 0x10
  private           Mono.Security.X509.X509CertificateCollectioncerts  // 0x18
  private           Mono.Security.X509.X509Certificate_root  // 0x20
  private           Mono.Security.X509.X509CertificateCollection_chain  // 0x28
  private           Mono.Security.X509.X509ChainStatusFlags_status  // 0x30
METHODS:
  System.Void .ctor()
  Mono.Security.X509.X509CertificateCollection get_TrustAnchors()
  System.Void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection)
  System.Boolean Build(Mono.Security.X509.X509Certificate leaf)
  System.Void Reset()
  System.Boolean IsValid(Mono.Security.X509.X509Certificate cert)
  Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child)
  Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot)
  System.Boolean IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted)
  System.Boolean IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent)
END_CLASS

CLASS: Mono.Security.X509.X509ChainStatusFlags
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.X509.X509ChainStatusFlagsInvalidBasicConstraints  // 0x0
  public    static  Mono.Security.X509.X509ChainStatusFlagsNoError  // 0x0
  public    static  Mono.Security.X509.X509ChainStatusFlagsNotSignatureValid  // 0x0
  public    static  Mono.Security.X509.X509ChainStatusFlagsNotTimeNested  // 0x0
  public    static  Mono.Security.X509.X509ChainStatusFlagsNotTimeValid  // 0x0
  public    static  Mono.Security.X509.X509ChainStatusFlagsPartialChain  // 0x0
  public    static  Mono.Security.X509.X509ChainStatusFlagsUntrustedRoot  // 0x0
METHODS:
END_CLASS

CLASS: Mono.Security.X509.X509Extension
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  protected         System.String                   extnOid  // 0x10
  protected         System.Boolean                  extnCritical  // 0x18
  protected         Mono.Security.ASN1              extnValue  // 0x20
METHODS:
  System.Void .ctor(Mono.Security.ASN1 asn1)
  System.Void .ctor(Mono.Security.X509.X509Extension extension)
  System.Void Decode()
  System.Void Encode()
  System.String get_Oid()
  System.Boolean get_Critical()
  Mono.Security.ASN1 get_Value()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void WriteLine(System.Text.StringBuilder sb, System.Int32 n, System.Int32 pos)
  System.String ToString()
END_CLASS

CLASS: Mono.Security.X509.X509ExtensionCollection
TYPE:  class
TOKEN: 0x2000017
EXTENDS: CollectionBase
FIELDS:
  private           System.Boolean                  readOnly  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(Mono.Security.ASN1 asn1)
  System.Int32 IndexOf(System.String oid)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  Mono.Security.X509.X509Extension get_Item(System.String oid)
END_CLASS

CLASS: Mono.Security.X509.X509Store
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private           System.String                   _storePath  // 0x10
  private           Mono.Security.X509.X509CertificateCollection_certificates  // 0x18
  private           System.Collections.ArrayList    _crls  // 0x20
  private           System.Boolean                  _crl  // 0x28
  private           System.Boolean                  _newFormat  // 0x29
METHODS:
  System.Void .ctor(System.String path, System.Boolean crl, System.Boolean newFormat)
  Mono.Security.X509.X509CertificateCollection get_Certificates()
  System.Collections.ArrayList get_Crls()
  System.Byte[] Load(System.String filename)
  Mono.Security.X509.X509Certificate LoadCertificate(System.String filename)
  Mono.Security.X509.X509Crl LoadCrl(System.String filename)
  System.Boolean CheckStore(System.String path, System.Boolean throwException)
  Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(System.String storeName)
  System.Collections.ArrayList BuildCrlsCollection(System.String storeName)
END_CLASS

CLASS: Mono.Security.X509.X509StoreManager
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private   static  System.String                   _userPath  // 0x0
  private   static  System.String                   _localMachinePath  // 0x8
  private   static  System.String                   _newUserPath  // 0x10
  private   static  System.String                   _newLocalMachinePath  // 0x18
  private   static  Mono.Security.X509.X509Stores   _userStore  // 0x20
  private   static  Mono.Security.X509.X509Stores   _machineStore  // 0x28
METHODS:
  System.String get_CurrentUserPath()
  System.String get_LocalMachinePath()
  System.String get_NewCurrentUserPath()
  System.String get_NewLocalMachinePath()
  Mono.Security.X509.X509Stores get_CurrentUser()
  Mono.Security.X509.X509Stores get_LocalMachine()
  Mono.Security.X509.X509CertificateCollection get_TrustedRootCertificates()
END_CLASS

CLASS: Mono.Security.X509.X509Stores
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private           System.String                   _storePath  // 0x10
  private           System.Boolean                  _newFormat  // 0x18
  private           Mono.Security.X509.X509Store    _trusted  // 0x20
METHODS:
  System.Void .ctor(System.String path, System.Boolean newFormat)
  Mono.Security.X509.X509Store get_TrustedRoot()
  Mono.Security.X509.X509Store Open(System.String storeName, System.Boolean create)
END_CLASS

CLASS: Mono.Security.X509.X520
TYPE:  class
TOKEN: 0x200001B
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.X509.Extensions.AuthorityKeyIdentifierExtension
TYPE:  class
TOKEN: 0x200002D
EXTENDS: X509Extension
FIELDS:
  private           System.Byte[]                   aki  // 0x28
METHODS:
  System.Void .ctor(Mono.Security.X509.X509Extension extension)
  System.Void Decode()
  System.Void Encode()
  System.Byte[] get_Identifier()
  System.String ToString()
END_CLASS

CLASS: Mono.Security.X509.Extensions.BasicConstraintsExtension
TYPE:  class
TOKEN: 0x200002E
EXTENDS: X509Extension
FIELDS:
  private           System.Boolean                  cA  // 0x28
  private           System.Int32                    pathLenConstraint  // 0x2C
METHODS:
  System.Void .ctor(Mono.Security.X509.X509Extension extension)
  System.Void Decode()
  System.Void Encode()
  System.Boolean get_CertificateAuthority()
  System.String ToString()
END_CLASS

