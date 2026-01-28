// ========================================================
// Dumped by @desirepro
// Assembly: Mono.Security.dll
// Classes:  104
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class Locale
    {
        // Methods
        private System.String GetText(System.String msg) { }
        private System.String GetText(System.String fmt, System.Object[] args) { }

    }

    // TypeToken: 0x2000007
    public class ContentInfo
    {
        // Fields
        private System.String contentType;        // 0x10
        private Mono.Security.ASN1 content;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String oid) { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.Void .ctor(Mono.Security.ASN1 asn1) { }
        private Mono.Security.ASN1 get_ASN1() { }
        private Mono.Security.ASN1 get_Content() { }
        private System.Void set_Content(Mono.Security.ASN1 value) { }
        private System.String get_ContentType() { }
        private System.Void set_ContentType(System.String value) { }
        private Mono.Security.ASN1 GetASN1() { }

    }

    // TypeToken: 0x2000008
    public class EncryptedData
    {
        // Fields
        private System.Byte _version;        // 0x10
        private Mono.Security.PKCS7.ContentInfo _content;        // 0x18
        private Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm;        // 0x20
        private System.Byte[] _encrypted;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Security.ASN1 asn1) { }
        private Mono.Security.PKCS7.ContentInfo get_EncryptionAlgorithm() { }
        private System.Byte[] get_EncryptedContent() { }

    }

    // TypeToken: 0x2000009
    public class SignedData
    {
        // Fields
        private System.Byte version;        // 0x10
        private System.String hashAlgorithm;        // 0x18
        private Mono.Security.PKCS7.ContentInfo contentInfo;        // 0x20
        private Mono.Security.X509.X509CertificateCollection certs;        // 0x28
        private System.Collections.ArrayList crls;        // 0x30
        private Mono.Security.PKCS7.SignerInfo signerInfo;        // 0x38
        private System.Boolean mda;        // 0x40

        // Methods
        private System.Void .ctor(Mono.Security.ASN1 asn1) { }
        private Mono.Security.X509.X509CertificateCollection get_Certificates() { }
        private Mono.Security.PKCS7.ContentInfo get_ContentInfo() { }
        private System.Void set_HashName(System.String value) { }
        private Mono.Security.PKCS7.SignerInfo get_SignerInfo() { }
        private System.String OidToName(System.String oid) { }

    }

    // TypeToken: 0x200000A
    public class SignerInfo
    {
        // Fields
        private System.Byte version;        // 0x10
        private System.String hashAlgorithm;        // 0x18
        private System.Collections.ArrayList authenticatedAttributes;        // 0x20
        private System.Collections.ArrayList unauthenticatedAttributes;        // 0x28
        private System.Byte[] signature;        // 0x30
        private System.String issuer;        // 0x38
        private System.Byte[] serial;        // 0x40
        private System.Byte[] ski;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Security.ASN1 asn1) { }
        private System.String get_IssuerName() { }
        private System.Byte[] get_SerialNumber() { }
        private System.Collections.ArrayList get_AuthenticatedAttributes() { }
        private System.String get_HashName() { }
        private System.Void set_HashName(System.String value) { }
        private System.Byte[] get_Signature() { }
        private System.Collections.ArrayList get_UnauthenticatedAttributes() { }
        private System.Byte get_Version() { }

    }

    // TypeToken: 0x200000D
    public class DeriveBytes
    {
        // Fields
        private static System.Byte[] keyDiversifier;        // 0x0
        private static System.Byte[] ivDiversifier;        // 0x8
        private static System.Byte[] macDiversifier;        // 0x10
        private System.String _hashName;        // 0x10
        private System.Int32 _iterations;        // 0x18
        private System.Byte[] _password;        // 0x20
        private System.Byte[] _salt;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void set_HashName(System.String value) { }
        private System.Void set_IterationCount(System.Int32 value) { }
        private System.Void set_Password(System.Byte[] value) { }
        private System.Void set_Salt(System.Byte[] value) { }
        private System.Void Adjust(System.Byte[] a, System.Int32 aOff, System.Byte[] b) { }
        private System.Byte[] Derive(System.Byte[] diversifier, System.Int32 n) { }
        private System.Byte[] DeriveKey(System.Int32 size) { }
        private System.Byte[] DeriveIV(System.Int32 size) { }
        private System.Byte[] DeriveMAC(System.Int32 size) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class X509CrlEntry
    {
        // Fields
        private System.Byte[] sn;        // 0x10
        private System.DateTime revocationDate;        // 0x18
        private Mono.Security.X509.X509ExtensionCollection extensions;        // 0x20

        // Methods
        private System.Void .ctor(Mono.Security.ASN1 entry) { }
        private System.Byte[] get_SerialNumber() { }
        private System.DateTime get_RevocationDate() { }
        private Mono.Security.X509.X509ExtensionCollection get_Extensions() { }

    }

    // TypeToken: 0x2000013
    public class X509CertificateEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.IEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(Mono.Security.X509.X509CertificateCollection mappings) { }
        private Mono.Security.X509.X509Certificate get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x200001C
    public class AttributeTypeAndValue
    {
        // Fields
        private System.String oid;        // 0x10
        private System.String attrValue;        // 0x18
        private System.Int32 upperBound;        // 0x20
        private System.Byte encoding;        // 0x24

        // Methods
        private System.Void .ctor(System.String oid, System.Int32 upperBound) { }
        private System.Void .ctor(System.String oid, System.Int32 upperBound, System.Byte encoding) { }
        private System.Void set_Value(System.String value) { }
        private Mono.Security.ASN1 GetASN1(System.Byte encoding) { }
        private Mono.Security.ASN1 GetASN1() { }
        private System.Byte SelectBestEncoding() { }

    }

    // TypeToken: 0x200001D
    public class CommonName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class SerialNumber : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class LocalityName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class StateOrProvinceName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class OrganizationName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class OrganizationalUnitName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class EmailAddress : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class DomainComponent : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class UserId : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class Oid : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor(System.String oid) { }

    }

    // TypeToken: 0x2000027
    public class Title : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class CountryName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class DnQualifier : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public class Surname : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class GivenName : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class Initial : AttributeTypeAndValue
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class PrivateKeyInfo
    {
        // Fields
        private System.Int32 _version;        // 0x10
        private System.String _algorithm;        // 0x18
        private System.Byte[] _key;        // 0x20
        private System.Collections.ArrayList _list;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.String get_Algorithm() { }
        private System.Void set_Algorithm(System.String value) { }
        private System.Byte[] get_PrivateKey() { }
        private System.Void set_PrivateKey(System.Byte[] value) { }
        private System.Void Decode(System.Byte[] data) { }
        private System.Byte[] GetBytes() { }
        private System.Byte[] RemoveLeadingZero(System.Byte[] bigInt) { }
        private System.Byte[] Normalize(System.Byte[] bigInt, System.Int32 length) { }
        private System.Security.Cryptography.RSA DecodeRSA(System.Byte[] keypair) { }
        private System.Byte[] Encode(System.Security.Cryptography.RSA rsa) { }
        private System.Security.Cryptography.DSA DecodeDSA(System.Byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters) { }
        private System.Byte[] Encode(System.Security.Cryptography.DSA dsa) { }
        private System.Byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa) { }

    }

    // TypeToken: 0x2000050
    public class EncryptedPrivateKeyInfo
    {
        // Fields
        private System.String _algorithm;        // 0x10
        private System.Byte[] _salt;        // 0x18
        private System.Int32 _iterations;        // 0x20
        private System.Byte[] _data;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.String get_Algorithm() { }
        private System.Void set_Algorithm(System.String value) { }
        private System.Byte[] get_EncryptedData() { }
        private System.Void set_EncryptedData(System.Byte[] value) { }
        private System.Byte[] get_Salt() { }
        private System.Int32 get_IterationCount() { }
        private System.Void set_IterationCount(System.Int32 value) { }
        private System.Void Decode(System.Byte[] data) { }
        private System.Byte[] GetBytes() { }

    }

    // TypeToken: 0x2000052
    public class KeyGeneratedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.EventArgs e) { }

    }

    // TypeToken: 0x2000056
    public struct Sign
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Math.BigInteger.Sign Negative;        // 0x0
        public static Mono.Math.BigInteger.Sign Zero;        // 0x0
        public static Mono.Math.BigInteger.Sign Positive;        // 0x0

    }

    // TypeToken: 0x2000057
    public class ModulusRing
    {
        // Fields
        private Mono.Math.BigInteger mod;        // 0x10
        private Mono.Math.BigInteger constant;        // 0x18

        // Methods
        private System.Void .ctor(Mono.Math.BigInteger modulus) { }
        private System.Void BarrettReduction(Mono.Math.BigInteger x) { }
        private Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b) { }
        private Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b) { }
        private Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k) { }
        private Mono.Math.BigInteger Pow(System.UInt32 b, Mono.Math.BigInteger exp) { }

    }

    // TypeToken: 0x2000058
    public class Kernel
    {
        // Methods
        private Mono.Math.BigInteger AddSameSign(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small) { }
        private System.Void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small) { }
        private System.Void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.UInt32 SingleByteDivideInPlace(Mono.Math.BigInteger n, System.UInt32 d) { }
        private System.UInt32 DwordMod(Mono.Math.BigInteger n, System.UInt32 d) { }
        private Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, System.UInt32 d) { }
        private Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, System.Int32 n) { }
        private Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, System.Int32 n) { }
        private System.Void Multiply(System.UInt32[] x, System.UInt32 xOffset, System.UInt32 xLen, System.UInt32[] y, System.UInt32 yOffset, System.UInt32 yLen, System.UInt32[] d, System.UInt32 dOffset) { }
        private System.Void MultiplyMod2p32pmod(System.UInt32[] x, System.Int32 xOffset, System.Int32 xLen, System.UInt32[] y, System.Int32 yOffest, System.Int32 yLen, System.UInt32[] d, System.Int32 dOffset, System.Int32 mod) { }
        private System.UInt32 modInverse(Mono.Math.BigInteger bi, System.UInt32 modulus) { }
        private Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus) { }

    }

    // TypeToken: 0x200005F
    public struct __StaticArrayInitTypeSize=3
    {
    }

    // TypeToken: 0x2000060
    public struct __StaticArrayInitTypeSize=9
    {
    }

    // TypeToken: 0x2000061
    public struct __StaticArrayInitTypeSize=10
    {
    }

    // TypeToken: 0x2000062
    public struct __StaticArrayInitTypeSize=18
    {
    }

    // TypeToken: 0x2000063
    public struct __StaticArrayInitTypeSize=20
    {
    }

    // TypeToken: 0x2000064
    public struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x2000065
    public struct __StaticArrayInitTypeSize=48
    {
    }

    // TypeToken: 0x2000066
    public struct __StaticArrayInitTypeSize=64
    {
    }

    // TypeToken: 0x2000067
    public struct __StaticArrayInitTypeSize=256
    {
    }

    // TypeToken: 0x2000068
    public struct __StaticArrayInitTypeSize=3132
    {
    }

namespace Mono.Math
{

    // TypeToken: 0x2000055
    public class BigInteger
    {
        // Fields
        private System.UInt32 length;        // 0x10
        private System.UInt32[] data;        // 0x18
        private static readonly System.UInt32[] smallPrimes;        // 0x0
        private static System.Security.Cryptography.RandomNumberGenerator rng;        // 0x8

        // Methods
        private System.Void .ctor(Mono.Math.BigInteger.Sign sign, System.UInt32 len) { }
        private System.Void .ctor(Mono.Math.BigInteger bi) { }
        private System.Void .ctor(Mono.Math.BigInteger bi, System.UInt32 len) { }
        private System.Void .ctor(System.Byte[] inData) { }
        private System.Void .ctor(System.UInt32 ui) { }
        private Mono.Math.BigInteger op_Implicit(System.UInt32 value) { }
        private Mono.Math.BigInteger op_Implicit(System.Int32 value) { }
        private Mono.Math.BigInteger op_Addition(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.UInt32 op_Modulus(Mono.Math.BigInteger bi, System.UInt32 ui) { }
        private Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, System.Int32 shiftVal) { }
        private Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, System.Int32 shiftVal) { }
        private System.Security.Cryptography.RandomNumberGenerator get_Rng() { }
        private Mono.Math.BigInteger GenerateRandom(System.Int32 bits, System.Security.Cryptography.RandomNumberGenerator rng) { }
        private Mono.Math.BigInteger GenerateRandom(System.Int32 bits) { }
        private System.Int32 BitCount() { }
        private System.Boolean TestBit(System.Int32 bitNum) { }
        private System.Void SetBit(System.UInt32 bitNum) { }
        private System.Void SetBit(System.UInt32 bitNum, System.Boolean value) { }
        private System.Int32 LowestSetBit() { }
        private System.Byte[] GetBytes() { }
        private System.Boolean op_Equality(Mono.Math.BigInteger bi1, System.UInt32 ui) { }
        private System.Boolean op_Inequality(Mono.Math.BigInteger bi1, System.UInt32 ui) { }
        private System.Boolean op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.Boolean op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.Boolean op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.Boolean op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.Boolean op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.Boolean op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { }
        private System.String ToString(System.UInt32 radix) { }
        private System.String ToString(System.UInt32 radix, System.String characterSet) { }
        private System.Void Normalize() { }
        private System.Void Clear() { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object o) { }
        private Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus) { }
        private Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n) { }
        private Mono.Math.BigInteger GeneratePseudoPrime(System.Int32 bits) { }
        private System.Void Incr2() { }
        private System.Void .cctor() { }

    }

}

namespace Mono.Math.Prime
{

    // TypeToken: 0x2000059
    public struct ConfidenceFactor
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Math.Prime.ConfidenceFactor ExtraLow;        // 0x0
        public static Mono.Math.Prime.ConfidenceFactor Low;        // 0x0
        public static Mono.Math.Prime.ConfidenceFactor Medium;        // 0x0
        public static Mono.Math.Prime.ConfidenceFactor High;        // 0x0
        public static Mono.Math.Prime.ConfidenceFactor ExtraHigh;        // 0x0
        public static Mono.Math.Prime.ConfidenceFactor Provable;        // 0x0

    }

    // TypeToken: 0x200005A
    public class PrimalityTest : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence) { }

    }

    // TypeToken: 0x200005B
    public class PrimalityTests
    {
        // Methods
        private System.Int32 GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence) { }
        private System.Boolean RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence) { }

    }

}

namespace Mono.Math.Prime.Generator
{

    // TypeToken: 0x200005C
    public class PrimeGeneratorBase
    {
        // Methods
        private Mono.Math.Prime.ConfidenceFactor get_Confidence() { }
        private Mono.Math.Prime.PrimalityTest get_PrimalityTest() { }
        private System.Int32 get_TrialDivisionBounds() { }
        private Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
    {
        // Methods
        private Mono.Math.BigInteger GenerateSearchBase(System.Int32 bits, System.Object context) { }
        private Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits) { }
        private Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits, System.Object context) { }
        private System.Boolean IsPrimeAcceptable(Mono.Math.BigInteger bi, System.Object context) { }
        private System.Void .ctor() { }

    }

}

namespace Mono.Security
{

    // TypeToken: 0x2000003
    public class ASN1
    {
        // Fields
        private System.Byte m_nTag;        // 0x10
        private System.Byte[] m_aValue;        // 0x18
        private System.Collections.ArrayList elist;        // 0x20

        // Methods
        private System.Void .ctor(System.Byte tag) { }
        private System.Void .ctor(System.Byte tag, System.Byte[] data) { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.Int32 get_Count() { }
        private System.Byte get_Tag() { }
        private System.Int32 get_Length() { }
        private System.Byte[] get_Value() { }
        private System.Void set_Value(System.Byte[] value) { }
        private System.Boolean CompareArray(System.Byte[] array1, System.Byte[] array2) { }
        private System.Boolean CompareValue(System.Byte[] value) { }
        private Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1) { }
        private System.Byte[] GetBytes() { }
        private System.Void Decode(System.Byte[] asn1, System.Int32& anPos, System.Int32 anLength) { }
        private System.Void DecodeTLV(System.Byte[] asn1, System.Int32& pos, System.Byte& tag, System.Int32& length, System.Byte[]& content) { }
        private Mono.Security.ASN1 get_Item(System.Int32 index) { }
        private Mono.Security.ASN1 Element(System.Int32 index, System.Byte anTag) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000004
    public class ASN1Convert
    {
        // Methods
        private Mono.Security.ASN1 FromInt32(System.Int32 value) { }
        private Mono.Security.ASN1 FromOid(System.String oid) { }
        private Mono.Security.ASN1 FromUnsignedBigInteger(System.Byte[] big) { }
        private System.Int32 ToInt32(Mono.Security.ASN1 asn1) { }
        private System.String ToOid(Mono.Security.ASN1 asn1) { }
        private System.DateTime ToDateTime(Mono.Security.ASN1 time) { }

    }

    // TypeToken: 0x2000005
    public class BitConverterLE
    {
        // Methods
        private System.Byte[] GetUIntBytes(System.Byte* bytes) { }
        private System.Byte[] GetULongBytes(System.Byte* bytes) { }
        private System.Byte[] GetBytes(System.Int32 value) { }
        private System.Byte[] GetBytes(System.Int64 value) { }
        private System.Void UShortFromBytes(System.Byte* dst, System.Byte[] src, System.Int32 startIndex) { }
        private System.Void UIntFromBytes(System.Byte* dst, System.Byte[] src, System.Int32 startIndex) { }
        private System.Int32 ToInt32(System.Byte[] value, System.Int32 startIndex) { }
        private System.UInt16 ToUInt16(System.Byte[] value, System.Int32 startIndex) { }
        private System.UInt32 ToUInt32(System.Byte[] value, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000006
    public class PKCS7
    {
    }

}

namespace Mono.Security.Authenticode
{

    // TypeToken: 0x2000053
    public class AuthenticodeBase
    {
        // Fields
        private System.Byte[] fileblock;        // 0x10
        private System.IO.Stream fs;        // 0x18
        private System.Int32 blockNo;        // 0x20
        private System.Int32 blockLength;        // 0x24
        private System.Int32 peOffset;        // 0x28
        private System.Int32 dirSecurityOffset;        // 0x2C
        private System.Int32 dirSecuritySize;        // 0x30
        private System.Int32 coffSymbolTableOffset;        // 0x34
        private System.Boolean pe64;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_PEOffset() { }
        private System.Void Open(System.String filename) { }
        private System.Void Open(System.Byte[] rawdata) { }
        private System.Void Close() { }
        private System.Void ReadFirstBlock() { }
        private System.Int32 ProcessFirstBlock() { }
        private System.Byte[] GetSecurityEntry() { }
        private System.Byte[] GetHash(System.Security.Cryptography.HashAlgorithm hash) { }

    }

    // TypeToken: 0x2000054
    public class AuthenticodeDeformatter : AuthenticodeBase
    {
        // Fields
        private System.String filename;        // 0x40
        private System.Byte[] rawdata;        // 0x48
        private System.Byte[] hash;        // 0x50
        private Mono.Security.X509.X509CertificateCollection coll;        // 0x58
        private Mono.Security.ASN1 signedHash;        // 0x60
        private System.DateTime timestamp;        // 0x68
        private Mono.Security.X509.X509Certificate signingCertificate;        // 0x70
        private System.Int32 reason;        // 0x78
        private System.Boolean trustedRoot;        // 0x7C
        private System.Boolean trustedTimestampRoot;        // 0x7D
        private System.Byte[] entry;        // 0x80
        private Mono.Security.X509.X509Chain signerChain;        // 0x88
        private Mono.Security.X509.X509Chain timestampChain;        // 0x90

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Byte[] rawData) { }
        private System.Void set_RawData(System.Byte[] value) { }
        private Mono.Security.X509.X509Certificate get_SigningCertificate() { }
        private System.Boolean CheckSignature() { }
        private System.Boolean CompareIssuerSerial(System.String issuer, System.Byte[] serial, Mono.Security.X509.X509Certificate x509) { }
        private System.Boolean VerifySignature(Mono.Security.PKCS7.SignedData sd, System.Byte[] calculatedMessageDigest, System.Security.Cryptography.HashAlgorithm ha) { }
        private System.Boolean VerifyCounterSignature(Mono.Security.PKCS7.SignerInfo cs, System.Byte[] signature) { }
        private System.Void Reset() { }

    }

}

namespace Mono.Security.Cryptography
{

    // TypeToken: 0x2000048
    public class CryptoConvert
    {
        // Methods
        private System.String ToHex(System.Byte[] input) { }
        private System.Byte FromHexChar(System.Char c) { }
        private System.Byte[] FromHex(System.String hex) { }

    }

    // TypeToken: 0x2000049
    public class MD2 : HashAlgorithm
    {
        // Methods
        private System.Void .ctor() { }
        private Mono.Security.Cryptography.MD2 Create() { }

    }

    // TypeToken: 0x200004A
    public class MD2Managed : MD2
    {
        // Fields
        private System.Byte[] state;        // 0x28
        private System.Byte[] checksum;        // 0x30
        private System.Byte[] buffer;        // 0x38
        private System.Int32 count;        // 0x40
        private System.Byte[] x;        // 0x48
        private static readonly System.Byte[] PI_SUBST;        // 0x0

        // Methods
        private System.Byte[] Padding(System.Int32 nLength) { }
        private System.Void .ctor() { }
        private System.Void Initialize() { }
        private System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize) { }
        private System.Byte[] HashFinal() { }
        private System.Void MD2Transform(System.Byte[] state, System.Byte[] checksum, System.Byte[] block, System.Int32 index) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004B
    public class MD4 : HashAlgorithm
    {
        // Methods
        private System.Void .ctor() { }
        private Mono.Security.Cryptography.MD4 Create() { }

    }

    // TypeToken: 0x200004C
    public class MD4Managed : MD4
    {
        // Fields
        private System.UInt32[] state;        // 0x28
        private System.Byte[] buffer;        // 0x30
        private System.UInt32[] count;        // 0x38
        private System.UInt32[] x;        // 0x40
        private System.Byte[] digest;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Void Initialize() { }
        private System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize) { }
        private System.Byte[] HashFinal() { }
        private System.Byte[] Padding(System.Int32 nLength) { }
        private System.UInt32 F(System.UInt32 x, System.UInt32 y, System.UInt32 z) { }
        private System.UInt32 G(System.UInt32 x, System.UInt32 y, System.UInt32 z) { }
        private System.UInt32 H(System.UInt32 x, System.UInt32 y, System.UInt32 z) { }
        private System.UInt32 ROL(System.UInt32 x, System.Byte n) { }
        private System.Void FF(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s) { }
        private System.Void GG(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s) { }
        private System.Void HH(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s) { }
        private System.Void Encode(System.Byte[] output, System.UInt32[] input) { }
        private System.Void Decode(System.UInt32[] output, System.Byte[] input, System.Int32 index) { }
        private System.Void MD4Transform(System.UInt32[] state, System.Byte[] block, System.Int32 index) { }

    }

    // TypeToken: 0x200004D
    public class PKCS1
    {
        // Fields
        private static System.Byte[] emptySHA1;        // 0x0
        private static System.Byte[] emptySHA256;        // 0x8
        private static System.Byte[] emptySHA384;        // 0x10
        private static System.Byte[] emptySHA512;        // 0x18

        // Methods
        private System.Boolean Compare(System.Byte[] array1, System.Byte[] array2) { }
        private System.Byte[] I2OSP(System.Byte[] x, System.Int32 size) { }
        private System.Byte[] OS2IP(System.Byte[] x) { }
        private System.Byte[] RSAVP1(System.Security.Cryptography.RSA rsa, System.Byte[] s) { }
        private System.Boolean Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Byte[] signature, System.Boolean tryNonStandardEncoding) { }
        private System.Byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Int32 emLength) { }
        private System.String HashNameFromOid(System.String oid, System.Boolean throwOnError) { }
        private System.Security.Cryptography.HashAlgorithm CreateFromOid(System.String oid) { }
        private System.Security.Cryptography.HashAlgorithm CreateFromName(System.String name) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004E
    public class PKCS8
    {
    }

    // TypeToken: 0x2000051
    public class RSAManaged : RSA
    {
        // Fields
        private System.Boolean isCRTpossible;        // 0x20
        private System.Boolean keyBlinding;        // 0x21
        private System.Boolean keypairGenerated;        // 0x22
        private System.Boolean m_disposed;        // 0x23
        private Mono.Math.BigInteger d;        // 0x28
        private Mono.Math.BigInteger p;        // 0x30
        private Mono.Math.BigInteger q;        // 0x38
        private Mono.Math.BigInteger dp;        // 0x40
        private Mono.Math.BigInteger dq;        // 0x48
        private Mono.Math.BigInteger qInv;        // 0x50
        private Mono.Math.BigInteger n;        // 0x58
        private Mono.Math.BigInteger e;        // 0x60
        private Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler KeyGenerated;        // 0x68

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 keySize) { }
        private System.Void Finalize() { }
        private System.Void GenerateKeyPair() { }
        private System.Int32 get_KeySize() { }
        private System.Boolean get_PublicOnly() { }
        private System.Byte[] DecryptValue(System.Byte[] rgb) { }
        private System.Byte[] EncryptValue(System.Byte[] rgb) { }
        private System.Security.Cryptography.RSAParameters ExportParameters(System.Boolean includePrivateParameters) { }
        private System.Void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.String ToXmlString(System.Boolean includePrivateParameters) { }
        private System.Byte[] GetPaddedValue(Mono.Math.BigInteger value, System.Int32 length) { }

    }

}

namespace Mono.Security.Interface
{

    // TypeToken: 0x2000038
    public struct AlertLevel
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Mono.Security.Interface.AlertLevel Warning;        // 0x0
        public static Mono.Security.Interface.AlertLevel Fatal;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct AlertDescription
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Mono.Security.Interface.AlertDescription CloseNotify;        // 0x0
        public static Mono.Security.Interface.AlertDescription UnexpectedMessage;        // 0x0
        public static Mono.Security.Interface.AlertDescription BadRecordMAC;        // 0x0
        public static Mono.Security.Interface.AlertDescription DecryptionFailed_RESERVED;        // 0x0
        public static Mono.Security.Interface.AlertDescription RecordOverflow;        // 0x0
        public static Mono.Security.Interface.AlertDescription DecompressionFailure;        // 0x0
        public static Mono.Security.Interface.AlertDescription HandshakeFailure;        // 0x0
        public static Mono.Security.Interface.AlertDescription NoCertificate_RESERVED;        // 0x0
        public static Mono.Security.Interface.AlertDescription BadCertificate;        // 0x0
        public static Mono.Security.Interface.AlertDescription UnsupportedCertificate;        // 0x0
        public static Mono.Security.Interface.AlertDescription CertificateRevoked;        // 0x0
        public static Mono.Security.Interface.AlertDescription CertificateExpired;        // 0x0
        public static Mono.Security.Interface.AlertDescription CertificateUnknown;        // 0x0
        public static Mono.Security.Interface.AlertDescription IlegalParameter;        // 0x0
        public static Mono.Security.Interface.AlertDescription UnknownCA;        // 0x0
        public static Mono.Security.Interface.AlertDescription AccessDenied;        // 0x0
        public static Mono.Security.Interface.AlertDescription DecodeError;        // 0x0
        public static Mono.Security.Interface.AlertDescription DecryptError;        // 0x0
        public static Mono.Security.Interface.AlertDescription ExportRestriction;        // 0x0
        public static Mono.Security.Interface.AlertDescription ProtocolVersion;        // 0x0
        public static Mono.Security.Interface.AlertDescription InsuficientSecurity;        // 0x0
        public static Mono.Security.Interface.AlertDescription InternalError;        // 0x0
        public static Mono.Security.Interface.AlertDescription UserCancelled;        // 0x0
        public static Mono.Security.Interface.AlertDescription NoRenegotiation;        // 0x0
        public static Mono.Security.Interface.AlertDescription UnsupportedExtension;        // 0x0

    }

    // TypeToken: 0x200003A
    public class Alert
    {
        // Fields
        private Mono.Security.Interface.AlertLevel level;        // 0x10
        private Mono.Security.Interface.AlertDescription description;        // 0x11

        // Methods
        private Mono.Security.Interface.AlertLevel get_Level() { }
        private Mono.Security.Interface.AlertDescription get_Description() { }
        private System.Void .ctor(Mono.Security.Interface.AlertDescription description) { }
        private System.Void inferAlertLevel() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200003B
    public class ValidationResult
    {
        // Fields
        private System.Boolean trusted;        // 0x10
        private System.Boolean user_denied;        // 0x11
        private System.Int32 error_code;        // 0x14
        private System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors;        // 0x18

        // Methods
        private System.Void .ctor(System.Boolean trusted, System.Boolean user_denied, System.Int32 error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors) { }
        private System.Boolean get_Trusted() { }
        private System.Boolean get_UserDenied() { }

    }

    // TypeToken: 0x200003C
    public interface ICertificateValidator
    {
    }

    // TypeToken: 0x200003D
    public struct CipherSuiteCode
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static Mono.Security.Interface.CipherSuiteCode TLS_NULL_WITH_NULL_NULL;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_NULL_MD5;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_EXPORT_WITH_RC4_40_MD5;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_RC4_128_MD5;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_IDEA_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_EXPORT_WITH_DES40_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_DES_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_DES_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_DES_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_DES_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_DES_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_EXPORT_WITH_RC4_40_MD5;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_RC4_128_MD5;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_DES_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_SEED_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_SEED_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_SEED_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_SEED_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_SEED_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_SEED_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_anon_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_anon_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_anon_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_anon_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_NULL_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_NULL_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_NULL_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_RC4_128_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_EMPTY_RENEGOTIATION_INFO_SCSV;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_128_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_256_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_128_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_AES_256_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_128_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_256_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CCM;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_128_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_AES_256_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_DHE_WITH_AES_128_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_DHE_WITH_AES_256_CCM_8;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_RSA_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_PSK_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_ECDHE_PSK_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_RSA_PSK_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_PSK_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_DHE_RSA_WITH_SALSA20_SHA1;        // 0x0
        public static Mono.Security.Interface.CipherSuiteCode TLS_FALLBACK_SCSV;        // 0x0

    }

    // TypeToken: 0x200003E
    public class MonoTlsConnectionInfo
    {
        // Fields
        private Mono.Security.Interface.CipherSuiteCode <CipherSuiteCode>k__BackingField;        // 0x10
        private Mono.Security.Interface.TlsProtocols <ProtocolVersion>k__BackingField;        // 0x14
        private System.String <PeerDomainName>k__BackingField;        // 0x18

        // Methods
        private Mono.Security.Interface.CipherSuiteCode get_CipherSuiteCode() { }
        private System.Void set_CipherSuiteCode(Mono.Security.Interface.CipherSuiteCode value) { }
        private Mono.Security.Interface.TlsProtocols get_ProtocolVersion() { }
        private System.Void set_ProtocolVersion(Mono.Security.Interface.TlsProtocols value) { }
        private System.Void set_PeerDomainName(System.String value) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public struct MonoSslPolicyErrors
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Security.Interface.MonoSslPolicyErrors None;        // 0x0
        public static Mono.Security.Interface.MonoSslPolicyErrors RemoteCertificateNotAvailable;        // 0x0
        public static Mono.Security.Interface.MonoSslPolicyErrors RemoteCertificateNameMismatch;        // 0x0
        public static Mono.Security.Interface.MonoSslPolicyErrors RemoteCertificateChainErrors;        // 0x0

    }

    // TypeToken: 0x2000040
    public class MonoRemoteCertificateValidationCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors) { }

    }

    // TypeToken: 0x2000041
    public class MonoLocalCertificateSelectionCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x2000042
    public class MonoTlsProvider
    {
        // Methods
        private System.Void .ctor() { }
        private System.Guid get_ID() { }
        private System.String get_Name() { }
        private System.Boolean get_SupportsSslStream() { }
        private System.Boolean get_SupportsConnectionInfo() { }
        private System.Boolean get_SupportsMonoExtensions() { }
        private System.Security.Authentication.SslProtocols get_SupportedProtocols() { }
        private System.Boolean get_SupportsCleanShutdown() { }

    }

    // TypeToken: 0x2000043
    public class MonoTlsProviderFactory
    {
        // Methods
        private Mono.Security.Interface.MonoTlsProvider GetProvider() { }

    }

    // TypeToken: 0x2000044
    public class MonoTlsSettings
    {
        // Fields
        private Mono.Security.Interface.MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField;        // 0x10
        private Mono.Security.Interface.MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField;        // 0x18
        private System.Nullable<System.DateTime> <CertificateValidationTime>k__BackingField;        // 0x20
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection <TrustAnchors>k__BackingField;        // 0x30
        private System.Object <UserSettings>k__BackingField;        // 0x38
        private System.String[] <CertificateSearchPaths>k__BackingField;        // 0x40
        private System.Boolean <SendCloseNotify>k__BackingField;        // 0x48
        private System.String[] <ClientCertificateIssuers>k__BackingField;        // 0x50
        private System.Boolean <DisallowUnauthenticatedCertificateRequest>k__BackingField;        // 0x58
        private System.Nullable<Mono.Security.Interface.TlsProtocols> <EnabledProtocols>k__BackingField;        // 0x5C
        private Mono.Security.Interface.CipherSuiteCode[] <EnabledCiphers>k__BackingField;        // 0x68
        private System.Boolean cloned;        // 0x70
        private System.Boolean checkCertName;        // 0x71
        private System.Boolean checkCertRevocationStatus;        // 0x72
        private System.Nullable<System.Boolean> useServicePointManagerCallback;        // 0x73
        private System.Boolean skipSystemValidators;        // 0x75
        private System.Boolean callbackNeedsChain;        // 0x76
        private Mono.Security.Interface.ICertificateValidator certificateValidator;        // 0x78
        private static Mono.Security.Interface.MonoTlsSettings defaultSettings;        // 0x0

        // Methods
        private Mono.Security.Interface.MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }
        private System.Void set_RemoteCertificateValidationCallback(Mono.Security.Interface.MonoRemoteCertificateValidationCallback value) { }
        private Mono.Security.Interface.MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }
        private System.Void set_ClientCertificateSelectionCallback(Mono.Security.Interface.MonoLocalCertificateSelectionCallback value) { }
        private System.Nullable<System.Boolean> get_UseServicePointManagerCallback() { }
        private System.Void set_UseServicePointManagerCallback(System.Nullable<System.Boolean> value) { }
        private System.Boolean get_CallbackNeedsCertificateChain() { }
        private System.Nullable<System.DateTime> get_CertificateValidationTime() { }
        private System.Void set_CertificateValidationTime(System.Nullable<System.DateTime> value) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_TrustAnchors() { }
        private System.Void set_TrustAnchors(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        private System.Object get_UserSettings() { }
        private System.Void set_UserSettings(System.Object value) { }
        private System.String[] get_CertificateSearchPaths() { }
        private System.Void set_CertificateSearchPaths(System.String[] value) { }
        private System.Boolean get_SendCloseNotify() { }
        private System.Void set_SendCloseNotify(System.Boolean value) { }
        private System.String[] get_ClientCertificateIssuers() { }
        private System.Void set_ClientCertificateIssuers(System.String[] value) { }
        private System.Boolean get_DisallowUnauthenticatedCertificateRequest() { }
        private System.Void set_DisallowUnauthenticatedCertificateRequest(System.Boolean value) { }
        private System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols() { }
        private System.Void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value) { }
        private Mono.Security.Interface.CipherSuiteCode[] get_EnabledCiphers() { }
        private System.Void set_EnabledCiphers(Mono.Security.Interface.CipherSuiteCode[] value) { }
        private System.Void .ctor() { }
        private Mono.Security.Interface.MonoTlsSettings get_DefaultSettings() { }
        private Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings() { }
        private Mono.Security.Interface.ICertificateValidator get_CertificateValidator() { }
        private Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator) { }
        private Mono.Security.Interface.MonoTlsSettings Clone() { }
        private System.Void .ctor(Mono.Security.Interface.MonoTlsSettings other) { }

    }

    // TypeToken: 0x2000045
    public class TlsException : Exception
    {
        // Fields
        private Mono.Security.Interface.Alert alert;        // 0x90

        // Methods
        private System.Void .ctor(Mono.Security.Interface.Alert alert) { }
        private System.Void .ctor(Mono.Security.Interface.Alert alert, System.String message) { }
        private System.Void .ctor(Mono.Security.Interface.AlertDescription description) { }
        private System.Void .ctor(Mono.Security.Interface.AlertDescription description, System.String message) { }

    }

    // TypeToken: 0x2000046
    public struct TlsProtocolCode
    {
        // Fields
        public System.Int16 value__;        // 0x10
        public static Mono.Security.Interface.TlsProtocolCode Tls10;        // 0x0
        public static Mono.Security.Interface.TlsProtocolCode Tls11;        // 0x0
        public static Mono.Security.Interface.TlsProtocolCode Tls12;        // 0x0

    }

    // TypeToken: 0x2000047
    public struct TlsProtocols
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Security.Interface.TlsProtocols Zero;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls10Client;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls10Server;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls10;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls11Client;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls11Server;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls11;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls12Client;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls12Server;        // 0x0
        public static Mono.Security.Interface.TlsProtocols Tls12;        // 0x0
        public static Mono.Security.Interface.TlsProtocols ClientMask;        // 0x0
        public static Mono.Security.Interface.TlsProtocols ServerMask;        // 0x0

    }

}

namespace Mono.Security.Protocol.Ntlm
{

    // TypeToken: 0x200002F
    public class ChallengeResponse, IDisposable
    {
        // Fields
        private static System.Byte[] magic;        // 0x0
        private static System.Byte[] nullEncMagic;        // 0x8
        private System.Boolean _disposed;        // 0x10
        private System.Byte[] _challenge;        // 0x18
        private System.Byte[] _lmpwd;        // 0x20
        private System.Byte[] _ntpwd;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String password, System.Byte[] challenge) { }
        private System.Void Finalize() { }
        private System.Void set_Password(System.String value) { }
        private System.Void set_Challenge(System.Byte[] value) { }
        private System.Byte[] get_LM() { }
        private System.Byte[] get_NT() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Byte[] GetResponse(System.Byte[] pwd) { }
        private System.Byte[] PrepareDESKey(System.Byte[] key56bits, System.Int32 position) { }
        private System.Byte[] PasswordToKey(System.String password, System.Int32 position) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000030
    public class ChallengeResponse2
    {
        // Fields
        private static System.Byte[] magic;        // 0x0
        private static System.Byte[] nullEncMagic;        // 0x8

        // Methods
        private System.Byte[] Compute_LM(System.String password, System.Byte[] challenge) { }
        private System.Byte[] Compute_NTLM_Password(System.String password) { }
        private System.Byte[] Compute_NTLM(System.String password, System.Byte[] challenge) { }
        private System.Void Compute_NTLMv2_Session(System.String password, System.Byte[] challenge, System.Byte[]& lm, System.Byte[]& ntlm) { }
        private System.Byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, System.String username, System.String password, System.String domain) { }
        private System.Void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, System.String username, System.String password, System.String domain, System.Byte[]& lm, System.Byte[]& ntlm) { }
        private System.Byte[] GetResponse(System.Byte[] challenge, System.Byte[] pwd) { }
        private System.Byte[] PrepareDESKey(System.Byte[] key56bits, System.Int32 position) { }
        private System.Byte[] PasswordToKey(System.String password, System.Int32 position) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public class MessageBase
    {
        // Fields
        private static System.Byte[] header;        // 0x0
        private System.Int32 _type;        // 0x10
        private Mono.Security.Protocol.Ntlm.NtlmFlags _flags;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 messageType) { }
        private Mono.Security.Protocol.Ntlm.NtlmFlags get_Flags() { }
        private System.Void set_Flags(Mono.Security.Protocol.Ntlm.NtlmFlags value) { }
        private System.Int32 get_Type() { }
        private System.Byte[] PrepareMessage(System.Int32 messageSize) { }
        private System.Void Decode(System.Byte[] message) { }
        private System.Boolean CheckHeader(System.Byte[] message) { }
        private System.Byte[] GetBytes() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000032
    public struct NtlmAuthLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel LM_and_NTLM;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel NTLM_only;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel NTLMv2_only;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct NtlmFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateUnicode;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateOem;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags RequestTarget;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateNtlm;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateDomainSupplied;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateWorkstationSupplied;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateAlwaysSign;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags NegotiateNtlm2Key;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags Negotiate128;        // 0x0
        public static Mono.Security.Protocol.Ntlm.NtlmFlags Negotiate56;        // 0x0

    }

    // TypeToken: 0x2000034
    public class NtlmSettings
    {
        // Fields
        private static Mono.Security.Protocol.Ntlm.NtlmAuthLevel defaultAuthLevel;        // 0x0

        // Methods
        private Mono.Security.Protocol.Ntlm.NtlmAuthLevel get_DefaultAuthLevel() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000035
    public class Type1Message : MessageBase
    {
        // Fields
        private System.String _host;        // 0x18
        private System.String _domain;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void set_Domain(System.String value) { }
        private System.Void set_Host(System.String value) { }
        private System.Void Decode(System.Byte[] message) { }
        private System.Byte[] GetBytes() { }

    }

    // TypeToken: 0x2000036
    public class Type2Message : MessageBase
    {
        // Fields
        private System.Byte[] _nonce;        // 0x18
        private System.String _targetName;        // 0x20
        private System.Byte[] _targetInfo;        // 0x28

        // Methods
        private System.Void .ctor(System.Byte[] message) { }
        private System.Void Finalize() { }
        private System.Byte[] get_Nonce() { }
        private System.String get_TargetName() { }
        private System.Byte[] get_TargetInfo() { }
        private System.Void Decode(System.Byte[] message) { }
        private System.Byte[] GetBytes() { }

    }

    // TypeToken: 0x2000037
    public class Type3Message : MessageBase
    {
        // Fields
        private Mono.Security.Protocol.Ntlm.NtlmAuthLevel _level;        // 0x18
        private System.Byte[] _challenge;        // 0x20
        private System.String _host;        // 0x28
        private System.String _domain;        // 0x30
        private System.String _username;        // 0x38
        private System.String _password;        // 0x40
        private Mono.Security.Protocol.Ntlm.Type2Message _type2;        // 0x48
        private System.Byte[] _lm;        // 0x50
        private System.Byte[] _nt;        // 0x58

        // Methods
        private System.Void .ctor(Mono.Security.Protocol.Ntlm.Type2Message type2) { }
        private System.Void Finalize() { }
        private System.Void set_Domain(System.String value) { }
        private System.Void set_Password(System.String value) { }
        private System.Void set_Username(System.String value) { }
        private System.Void Decode(System.Byte[] message) { }
        private System.String DecodeString(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        private System.Byte[] EncodeString(System.String text) { }
        private System.Byte[] GetBytes() { }

    }

}

namespace Mono.Security.X509
{

    // TypeToken: 0x200000B
    public class SafeBag
    {
        // Fields
        private System.String _bagOID;        // 0x10
        private Mono.Security.ASN1 _asn1;        // 0x18

        // Methods
        private System.Void .ctor(System.String bagOID, Mono.Security.ASN1 asn1) { }
        private System.String get_BagOID() { }
        private Mono.Security.ASN1 get_ASN1() { }

    }

    // TypeToken: 0x200000C
    public class PKCS12, ICloneable
    {
        // Fields
        private System.Byte[] _password;        // 0x10
        private System.Collections.ArrayList _keyBags;        // 0x18
        private System.Collections.ArrayList _secretBags;        // 0x20
        private Mono.Security.X509.X509CertificateCollection _certs;        // 0x28
        private System.Boolean _keyBagsChanged;        // 0x30
        private System.Boolean _secretBagsChanged;        // 0x31
        private System.Boolean _certsChanged;        // 0x32
        private System.Int32 _iterations;        // 0x34
        private System.Collections.ArrayList _safeBags;        // 0x38
        private System.Security.Cryptography.RandomNumberGenerator _rng;        // 0x40
        private static System.Int32 password_max_length;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.Void .ctor(System.Byte[] data, System.String password) { }
        private System.Void Decode(System.Byte[] data) { }
        private System.Void Finalize() { }
        private System.Void set_Password(System.String value) { }
        private System.Int32 get_IterationCount() { }
        private System.Void set_IterationCount(System.Int32 value) { }
        private System.Collections.ArrayList get_Keys() { }
        private Mono.Security.X509.X509CertificateCollection get_Certificates() { }
        private System.Security.Cryptography.RandomNumberGenerator get_RNG() { }
        private System.Boolean Compare(System.Byte[] expected, System.Byte[] actual) { }
        private System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount) { }
        private System.Byte[] Decrypt(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount, System.Byte[] encryptedData) { }
        private System.Byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed) { }
        private System.Byte[] Encrypt(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount, System.Byte[] data) { }
        private System.Security.Cryptography.DSAParameters GetExistingParameters(System.Boolean& found) { }
        private System.Void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki) { }
        private System.Void ReadSafeBag(Mono.Security.ASN1 safeBag) { }
        private Mono.Security.ASN1 Pkcs8ShroudedKeyBagSafeBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) { }
        private Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes) { }
        private System.Byte[] MAC(System.Byte[] password, System.Byte[] salt, System.Int32 iterations, System.Byte[] data) { }
        private System.Byte[] GetBytes() { }
        private Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, System.String algorithmOid) { }
        private System.Void AddCertificate(Mono.Security.X509.X509Certificate cert) { }
        private System.Void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes) { }
        private System.Void RemoveCertificate(Mono.Security.X509.X509Certificate cert) { }
        private System.Void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs) { }
        private System.Boolean CompareAsymmetricAlgorithm(System.Security.Cryptography.AsymmetricAlgorithm a1, System.Security.Cryptography.AsymmetricAlgorithm a2) { }
        private System.Void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) { }
        private System.Object Clone() { }
        private System.Int32 get_MaximumPasswordLength() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class X501
    {
        // Fields
        private static System.Byte[] countryName;        // 0x0
        private static System.Byte[] organizationName;        // 0x8
        private static System.Byte[] organizationalUnitName;        // 0x10
        private static System.Byte[] commonName;        // 0x18
        private static System.Byte[] localityName;        // 0x20
        private static System.Byte[] stateOrProvinceName;        // 0x28
        private static System.Byte[] streetAddress;        // 0x30
        private static System.Byte[] serialNumber;        // 0x38
        private static System.Byte[] domainComponent;        // 0x40
        private static System.Byte[] userid;        // 0x48
        private static System.Byte[] email;        // 0x50
        private static System.Byte[] dnQualifier;        // 0x58
        private static System.Byte[] title;        // 0x60
        private static System.Byte[] surname;        // 0x68
        private static System.Byte[] givenName;        // 0x70
        private static System.Byte[] initial;        // 0x78

        // Methods
        private System.String ToString(Mono.Security.ASN1 seq) { }
        private System.String ToString(Mono.Security.ASN1 seq, System.Boolean reversed, System.String separator, System.Boolean quotes) { }
        private System.Void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, System.Boolean quotes) { }
        private Mono.Security.X509.X520.AttributeTypeAndValue GetAttributeFromOid(System.String attributeType) { }
        private System.Boolean IsOid(System.String oid) { }
        private Mono.Security.X509.X520.AttributeTypeAndValue ReadAttribute(System.String value, System.Int32& pos) { }
        private System.Boolean IsHex(System.Char c) { }
        private System.String ReadHex(System.String value, System.Int32& pos) { }
        private System.Int32 ReadEscaped(System.Text.StringBuilder sb, System.String value, System.Int32 pos) { }
        private System.Int32 ReadQuoted(System.Text.StringBuilder sb, System.String value, System.Int32 pos) { }
        private System.String ReadValue(System.String value, System.Int32& pos) { }
        private Mono.Security.ASN1 FromString(System.String rdn) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000F
    public class X509Crl
    {
        // Fields
        private System.String issuer;        // 0x10
        private System.Byte version;        // 0x18
        private System.DateTime thisUpdate;        // 0x20
        private System.DateTime nextUpdate;        // 0x28
        private System.Collections.ArrayList entries;        // 0x30
        private System.String signatureOID;        // 0x38
        private System.Byte[] signature;        // 0x40
        private Mono.Security.X509.X509ExtensionCollection extensions;        // 0x48
        private System.Byte[] encoded;        // 0x50
        private System.Byte[] hash_value;        // 0x58

        // Methods
        private System.Void .ctor(System.Byte[] crl) { }
        private System.Void Parse(System.Byte[] crl) { }
        private Mono.Security.X509.X509ExtensionCollection get_Extensions() { }
        private System.Byte[] get_Hash() { }
        private System.String get_IssuerName() { }
        private System.DateTime get_NextUpdate() { }
        private System.Boolean Compare(System.Byte[] array1, System.Byte[] array2) { }
        private Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509) { }
        private Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(System.Byte[] serialNumber) { }
        private System.Boolean VerifySignature(System.Security.Cryptography.DSA dsa) { }
        private System.Boolean VerifySignature(System.Security.Cryptography.RSA rsa) { }
        private System.Boolean VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { }

    }

    // TypeToken: 0x2000011
    public class X509Certificate, ISerializable
    {
        // Fields
        private Mono.Security.ASN1 decoder;        // 0x10
        private System.Byte[] m_encodedcert;        // 0x18
        private System.DateTime m_from;        // 0x20
        private System.DateTime m_until;        // 0x28
        private Mono.Security.ASN1 issuer;        // 0x30
        private System.String m_issuername;        // 0x38
        private System.String m_keyalgo;        // 0x40
        private System.Byte[] m_keyalgoparams;        // 0x48
        private Mono.Security.ASN1 subject;        // 0x50
        private System.String m_subject;        // 0x58
        private System.Byte[] m_publickey;        // 0x60
        private System.Byte[] signature;        // 0x68
        private System.String m_signaturealgo;        // 0x70
        private System.Byte[] m_signaturealgoparams;        // 0x78
        private System.Byte[] certhash;        // 0x80
        private System.Security.Cryptography.RSA _rsa;        // 0x88
        private System.Security.Cryptography.DSA _dsa;        // 0x90
        private System.Int32 version;        // 0x98
        private System.Byte[] serialnumber;        // 0xA0
        private System.Byte[] issuerUniqueID;        // 0xA8
        private System.Byte[] subjectUniqueID;        // 0xB0
        private Mono.Security.X509.X509ExtensionCollection extensions;        // 0xB8
        private static System.String encoding_error;        // 0x0

        // Methods
        private System.Void Parse(System.Byte[] data) { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.Byte[] GetUnsignedBigInteger(System.Byte[] integer) { }
        private System.Security.Cryptography.DSA get_DSA() { }
        private System.Void set_DSA(System.Security.Cryptography.DSA value) { }
        private Mono.Security.X509.X509ExtensionCollection get_Extensions() { }
        private System.Byte[] get_Hash() { }
        private System.String get_IssuerName() { }
        private System.String get_KeyAlgorithm() { }
        private System.Byte[] get_KeyAlgorithmParameters() { }
        private System.Void set_KeyAlgorithmParameters(System.Byte[] value) { }
        private System.Byte[] get_PublicKey() { }
        private System.Security.Cryptography.RSA get_RSA() { }
        private System.Void set_RSA(System.Security.Cryptography.RSA value) { }
        private System.Byte[] get_RawData() { }
        private System.Byte[] get_SerialNumber() { }
        private System.Byte[] get_Signature() { }
        private System.String get_SubjectName() { }
        private System.DateTime get_ValidFrom() { }
        private System.DateTime get_ValidUntil() { }
        private System.Int32 get_Version() { }
        private System.Boolean get_IsCurrent() { }
        private System.Boolean WasCurrent(System.DateTime instant) { }
        private System.Boolean VerifySignature(System.Security.Cryptography.DSA dsa) { }
        private System.Boolean VerifySignature(System.Security.Cryptography.RSA rsa) { }
        private System.Boolean VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
        private System.Boolean get_IsSelfSigned() { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Byte[] PEM(System.String type, System.Byte[] data) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public class X509CertificateCollection : CollectionBase, IEnumerable
    {
        // Methods
        private System.Void .ctor() { }
        private Mono.Security.X509.X509Certificate get_Item(System.Int32 index) { }
        private System.Int32 Add(Mono.Security.X509.X509Certificate value) { }
        private System.Void AddRange(Mono.Security.X509.X509CertificateCollection value) { }
        private System.Boolean Contains(Mono.Security.X509.X509Certificate value) { }
        private Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 GetHashCode() { }
        private System.Int32 IndexOf(Mono.Security.X509.X509Certificate value) { }
        private System.Boolean Compare(System.Byte[] array1, System.Byte[] array2) { }

    }

    // TypeToken: 0x2000014
    public class X509Chain
    {
        // Fields
        private Mono.Security.X509.X509CertificateCollection roots;        // 0x10
        private Mono.Security.X509.X509CertificateCollection certs;        // 0x18
        private Mono.Security.X509.X509Certificate _root;        // 0x20
        private Mono.Security.X509.X509CertificateCollection _chain;        // 0x28
        private Mono.Security.X509.X509ChainStatusFlags _status;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private Mono.Security.X509.X509CertificateCollection get_TrustAnchors() { }
        private System.Void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection) { }
        private System.Boolean Build(Mono.Security.X509.X509Certificate leaf) { }
        private System.Void Reset() { }
        private System.Boolean IsValid(Mono.Security.X509.X509Certificate cert) { }
        private Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child) { }
        private Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot) { }
        private System.Boolean IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted) { }
        private System.Boolean IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent) { }

    }

    // TypeToken: 0x2000015
    public struct X509ChainStatusFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Mono.Security.X509.X509ChainStatusFlags InvalidBasicConstraints;        // 0x0
        public static Mono.Security.X509.X509ChainStatusFlags NoError;        // 0x0
        public static Mono.Security.X509.X509ChainStatusFlags NotSignatureValid;        // 0x0
        public static Mono.Security.X509.X509ChainStatusFlags NotTimeNested;        // 0x0
        public static Mono.Security.X509.X509ChainStatusFlags NotTimeValid;        // 0x0
        public static Mono.Security.X509.X509ChainStatusFlags PartialChain;        // 0x0
        public static Mono.Security.X509.X509ChainStatusFlags UntrustedRoot;        // 0x0

    }

    // TypeToken: 0x2000016
    public class X509Extension
    {
        // Fields
        protected System.String extnOid;        // 0x10
        protected System.Boolean extnCritical;        // 0x18
        protected Mono.Security.ASN1 extnValue;        // 0x20

        // Methods
        private System.Void .ctor(Mono.Security.ASN1 asn1) { }
        private System.Void .ctor(Mono.Security.X509.X509Extension extension) { }
        private System.Void Decode() { }
        private System.Void Encode() { }
        private System.String get_Oid() { }
        private System.Boolean get_Critical() { }
        private Mono.Security.ASN1 get_Value() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void WriteLine(System.Text.StringBuilder sb, System.Int32 n, System.Int32 pos) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000017
    public class X509ExtensionCollection : CollectionBase, IEnumerable
    {
        // Fields
        private System.Boolean readOnly;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Mono.Security.ASN1 asn1) { }
        private System.Int32 IndexOf(System.String oid) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private Mono.Security.X509.X509Extension get_Item(System.String oid) { }

    }

    // TypeToken: 0x2000018
    public class X509Store
    {
        // Fields
        private System.String _storePath;        // 0x10
        private Mono.Security.X509.X509CertificateCollection _certificates;        // 0x18
        private System.Collections.ArrayList _crls;        // 0x20
        private System.Boolean _crl;        // 0x28
        private System.Boolean _newFormat;        // 0x29

        // Methods
        private System.Void .ctor(System.String path, System.Boolean crl, System.Boolean newFormat) { }
        private Mono.Security.X509.X509CertificateCollection get_Certificates() { }
        private System.Collections.ArrayList get_Crls() { }
        private System.Byte[] Load(System.String filename) { }
        private Mono.Security.X509.X509Certificate LoadCertificate(System.String filename) { }
        private Mono.Security.X509.X509Crl LoadCrl(System.String filename) { }
        private System.Boolean CheckStore(System.String path, System.Boolean throwException) { }
        private Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(System.String storeName) { }
        private System.Collections.ArrayList BuildCrlsCollection(System.String storeName) { }

    }

    // TypeToken: 0x2000019
    public class X509StoreManager
    {
        // Fields
        private static System.String _userPath;        // 0x0
        private static System.String _localMachinePath;        // 0x8
        private static System.String _newUserPath;        // 0x10
        private static System.String _newLocalMachinePath;        // 0x18
        private static Mono.Security.X509.X509Stores _userStore;        // 0x20
        private static Mono.Security.X509.X509Stores _machineStore;        // 0x28

        // Methods
        private System.String get_CurrentUserPath() { }
        private System.String get_LocalMachinePath() { }
        private System.String get_NewCurrentUserPath() { }
        private System.String get_NewLocalMachinePath() { }
        private Mono.Security.X509.X509Stores get_CurrentUser() { }
        private Mono.Security.X509.X509Stores get_LocalMachine() { }
        private Mono.Security.X509.X509CertificateCollection get_TrustedRootCertificates() { }

    }

    // TypeToken: 0x200001A
    public class X509Stores
    {
        // Fields
        private System.String _storePath;        // 0x10
        private System.Boolean _newFormat;        // 0x18
        private Mono.Security.X509.X509Store _trusted;        // 0x20

        // Methods
        private System.Void .ctor(System.String path, System.Boolean newFormat) { }
        private Mono.Security.X509.X509Store get_TrustedRoot() { }
        private Mono.Security.X509.X509Store Open(System.String storeName, System.Boolean create) { }

    }

    // TypeToken: 0x200001B
    public class X520
    {
    }

}

namespace Mono.Security.X509.Extensions
{

    // TypeToken: 0x200002D
    public class AuthorityKeyIdentifierExtension : X509Extension
    {
        // Fields
        private System.Byte[] aki;        // 0x28

        // Methods
        private System.Void .ctor(Mono.Security.X509.X509Extension extension) { }
        private System.Void Decode() { }
        private System.Void Encode() { }
        private System.Byte[] get_Identifier() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200002E
    public class BasicConstraintsExtension : X509Extension
    {
        // Fields
        private System.Boolean cA;        // 0x28
        private System.Int32 pathLenConstraint;        // 0x2C

        // Methods
        private System.Void .ctor(Mono.Security.X509.X509Extension extension) { }
        private System.Void Decode() { }
        private System.Void Encode() { }
        private System.Boolean get_CertificateAuthority() { }
        private System.String ToString() { }

    }

}

