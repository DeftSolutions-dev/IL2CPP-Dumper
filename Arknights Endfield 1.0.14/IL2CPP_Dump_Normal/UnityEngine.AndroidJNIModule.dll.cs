// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AndroidJNIModule.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class AndroidJavaRunnable : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000003
    public class AndroidJavaException : Exception
    {
        // Fields
        private System.String mJavaStackTrace;        // 0x90

        // Methods
        private System.Void .ctor(System.String message, System.String javaStackTrace) { }
        private System.String get_StackTrace() { }

    }

    // TypeToken: 0x2000004
    public class GlobalJavaObjectRef
    {
        // Fields
        private System.Boolean m_disposed;        // 0x10
        protected System.IntPtr m_jobject;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr jobject) { }
        private System.Void Finalize() { }
        private System.IntPtr op_Implicit(UnityEngine.GlobalJavaObjectRef obj) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000005
    public class AndroidJavaRunnableProxy : AndroidJavaProxy
    {
        // Fields
        private UnityEngine.AndroidJavaRunnable mRunnable;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.AndroidJavaRunnable runnable) { }

    }

    // TypeToken: 0x2000006
    public class AndroidJavaProxy
    {
        // Fields
        public readonly UnityEngine.AndroidJavaClass javaInterface;        // 0x10
        private System.IntPtr proxyObject;        // 0x18
        private static readonly UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;        // 0x0
        private static readonly System.IntPtr s_HashCodeMethodID;        // 0x8

        // Methods
        private System.Void .ctor(System.String javaInterface) { }
        private System.Void .ctor(UnityEngine.AndroidJavaClass javaInterface) { }
        private System.Void Finalize() { }
        private UnityEngine.AndroidJavaObject Invoke(System.String methodName, System.Object[] args) { }
        private UnityEngine.AndroidJavaObject Invoke(System.String methodName, UnityEngine.AndroidJavaObject[] javaArgs) { }
        private System.Boolean equals(UnityEngine.AndroidJavaObject obj) { }
        private System.Int32 hashCode() { }
        private System.String toString() { }
        private UnityEngine.AndroidJavaObject GetProxyObject() { }
        private System.IntPtr GetRawProxy() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000007
    public class AndroidJavaObject, IDisposable
    {
        // Fields
        private static System.Boolean enableDebugPrints;        // 0x0
        private UnityEngine.GlobalJavaObjectRef m_jobject;        // 0x10
        private UnityEngine.GlobalJavaObjectRef m_jclass;        // 0x18

        // Methods
        private System.Void .ctor(System.String className, System.Object[] args) { }
        private System.Void Dispose() { }
        private FieldType Get(System.String fieldName) { }
        private FieldType GetStatic(System.String fieldName) { }
        private System.IntPtr GetRawObject() { }
        private System.IntPtr GetRawClass() { }
        private ReturnType Call(System.String methodName, System.Object[] args) { }
        private ReturnType CallStatic(System.String methodName, System.Object[] args) { }
        private System.Void DebugPrint(System.String msg) { }
        private System.Void _AndroidJavaObject(System.String className, System.Object[] args) { }
        private System.Void .ctor(System.IntPtr jobject) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private ReturnType _Call(System.String methodName, System.Object[] args) { }
        private FieldType _Get(System.String fieldName) { }
        private ReturnType _CallStatic(System.String methodName, System.Object[] args) { }
        private FieldType _GetStatic(System.String fieldName) { }
        private UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(System.IntPtr jobject) { }
        private UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(System.IntPtr jclass) { }
        private ReturnType FromJavaArrayDeleteLocalRef(System.IntPtr jobject) { }
        private System.IntPtr _GetRawObject() { }
        private System.IntPtr _GetRawClass() { }

    }

    // TypeToken: 0x2000008
    public class AndroidJavaClass : AndroidJavaObject
    {
        // Methods
        private System.Void .ctor(System.String className) { }
        private System.Void _AndroidJavaClass(System.String className) { }
        private System.Void .ctor(System.IntPtr jclass) { }

    }

    // TypeToken: 0x2000009
    public class AndroidReflection
    {
        // Fields
        private static readonly UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass;        // 0x0
        private static readonly System.IntPtr s_ReflectionHelperGetConstructorID;        // 0x8
        private static readonly System.IntPtr s_ReflectionHelperGetMethodID;        // 0x10
        private static readonly System.IntPtr s_ReflectionHelperGetFieldID;        // 0x18
        private static readonly System.IntPtr s_ReflectionHelperGetFieldSignature;        // 0x20
        private static readonly System.IntPtr s_ReflectionHelperNewProxyInstance;        // 0x28
        private static readonly System.IntPtr s_ReflectionHelperSetNativeExceptionOnProxy;        // 0x30
        private static readonly System.IntPtr s_FieldGetDeclaringClass;        // 0x38

        // Methods
        private System.Boolean IsPrimitive(System.Type t) { }
        private System.Boolean IsAssignableFrom(System.Type t, System.Type from) { }
        private System.IntPtr GetStaticMethodID(System.String clazz, System.String methodName, System.String signature) { }
        private System.IntPtr GetMethodID(System.String clazz, System.String methodName, System.String signature) { }
        private System.IntPtr GetConstructorMember(System.IntPtr jclass, System.String signature) { }
        private System.IntPtr GetMethodMember(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        private System.IntPtr GetFieldMember(System.IntPtr jclass, System.String fieldName, System.String signature, System.Boolean isStatic) { }
        private System.IntPtr GetFieldClass(System.IntPtr field) { }
        private System.String GetFieldSignature(System.IntPtr field) { }
        private System.IntPtr NewProxyInstance(System.IntPtr player, System.IntPtr delegateHandle, System.IntPtr interfaze) { }
        private System.Void SetNativeExceptionOnProxy(System.IntPtr proxy, System.Exception e, System.Boolean methodNotFound) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class _AndroidJNIHelper
    {
        // Methods
        private System.IntPtr CreateJavaProxy(System.IntPtr player, System.IntPtr delegateHandle, UnityEngine.AndroidJavaProxy proxy) { }
        private System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable) { }
        private System.IntPtr InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, System.IntPtr jmethodName, System.IntPtr jargs) { }
        private UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args) { }
        private System.Object UnboxArray(UnityEngine.AndroidJavaObject obj) { }
        private System.Object Unbox(UnityEngine.AndroidJavaObject obj) { }
        private UnityEngine.AndroidJavaObject Box(System.Object obj) { }
        private System.Void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs) { }
        private System.IntPtr ConvertToJNIArray(System.Array array) { }
        private ArrayType ConvertFromJNIArray(System.IntPtr array) { }
        private System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args) { }
        private System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.Object[] args, System.Boolean isStatic) { }
        private System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.Boolean isStatic) { }
        private System.IntPtr GetConstructorID(System.IntPtr jclass, System.String signature) { }
        private System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        private System.IntPtr GetMethodIDFallback(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        private System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.String signature, System.Boolean isStatic) { }
        private System.String GetSignature(System.Object obj) { }
        private System.String GetSignature(System.Object[] args) { }
        private System.String GetSignature(System.Object[] args) { }

    }

    // TypeToken: 0x200000B
    public struct jvalue
    {
        // Fields
        public System.Boolean z;        // 0x10
        public System.SByte b;        // 0x10
        public System.Char c;        // 0x10
        public System.Int16 s;        // 0x10
        public System.Int32 i;        // 0x10
        public System.Int64 j;        // 0x10
        public System.Single f;        // 0x10
        public System.Double d;        // 0x10
        public System.IntPtr l;        // 0x10

    }

    // TypeToken: 0x200000C
    public class AndroidJNIHelper
    {
        // Methods
        private System.IntPtr GetConstructorID(System.IntPtr javaClass, System.String signature) { }
        private System.IntPtr GetMethodID(System.IntPtr javaClass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        private System.IntPtr GetFieldID(System.IntPtr javaClass, System.String fieldName, System.String signature, System.Boolean isStatic) { }
        private System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable) { }
        private System.IntPtr CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy) { }
        private UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args) { }
        private System.Void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs) { }
        private System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args) { }
        private ArrayType ConvertFromJNIArray(System.IntPtr array) { }
        private System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.Object[] args, System.Boolean isStatic) { }
        private System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.Boolean isStatic) { }

    }

    // TypeToken: 0x200000D
    public class AndroidJNI
    {
        // Methods
        private System.IntPtr FindClass(System.String name) { }
        private System.IntPtr FromReflectedMethod(System.IntPtr refMethod) { }
        private System.IntPtr ExceptionOccurred() { }
        private System.Void ExceptionClear() { }
        private System.Int32 PushLocalFrame(System.Int32 capacity) { }
        private System.IntPtr PopLocalFrame(System.IntPtr ptr) { }
        private System.IntPtr NewGlobalRef(System.IntPtr obj) { }
        private System.Void DeleteGlobalRef(System.IntPtr obj) { }
        private System.IntPtr NewWeakGlobalRef(System.IntPtr obj) { }
        private System.Void DeleteWeakGlobalRef(System.IntPtr obj) { }
        private System.IntPtr NewLocalRef(System.IntPtr obj) { }
        private System.Void DeleteLocalRef(System.IntPtr obj) { }
        private System.Boolean IsSameObject(System.IntPtr obj1, System.IntPtr obj2) { }
        private System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.IntPtr GetObjectClass(System.IntPtr obj) { }
        private System.IntPtr GetMethodID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr GetFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr GetStaticMethodID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr GetStaticFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr NewString(System.String chars) { }
        private System.IntPtr NewStringFromStr(System.String chars) { }
        private System.String GetStringChars(System.IntPtr str) { }
        private System.String CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int32 CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Boolean CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int16 CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.SByte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Single CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int64 CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.String GetStringField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Boolean GetBooleanField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.SByte GetSByteField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Char GetCharField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Int16 GetShortField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Int32 GetIntField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Int64 GetLongField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Single GetFloatField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.String CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int32 CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Boolean CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int16 CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.SByte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Single CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int64 CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.String GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Boolean GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.SByte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Int16 GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Int32 GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Int64 GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Single GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.IntPtr ToBooleanArray(System.Boolean[] array) { }
        private System.IntPtr ToByteArray(System.Byte[] array) { }
        private System.IntPtr ToSByteArray(System.SByte[] array) { }
        private System.IntPtr ToCharArray(System.Char[] array) { }
        private System.IntPtr ToShortArray(System.Int16[] array) { }
        private System.IntPtr ToIntArray(System.Int32[] array) { }
        private System.IntPtr ToLongArray(System.Int64[] array) { }
        private System.IntPtr ToFloatArray(System.Single[] array) { }
        private System.IntPtr ToDoubleArray(System.Double[] array) { }
        private System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr arrayClass) { }
        private System.Boolean[] FromBooleanArray(System.IntPtr array) { }
        private System.Byte[] FromByteArray(System.IntPtr array) { }
        private System.SByte[] FromSByteArray(System.IntPtr array) { }
        private System.Char[] FromCharArray(System.IntPtr array) { }
        private System.Int16[] FromShortArray(System.IntPtr array) { }
        private System.Int32[] FromIntArray(System.IntPtr array) { }
        private System.Int64[] FromLongArray(System.IntPtr array) { }
        private System.Single[] FromFloatArray(System.IntPtr array) { }
        private System.Double[] FromDoubleArray(System.IntPtr array) { }
        private System.Int32 GetArrayLength(System.IntPtr array) { }
        private System.IntPtr NewObjectArray(System.Int32 size, System.IntPtr clazz, System.IntPtr obj) { }
        private System.IntPtr GetObjectArrayElement(System.IntPtr array, System.Int32 index) { }
        private System.Void SetObjectArrayElement(System.IntPtr array, System.Int32 index, System.IntPtr obj) { }

    }

    // TypeToken: 0x200000E
    public class AndroidJNISafe
    {
        // Methods
        private System.Void CheckException() { }
        private System.Void DeleteGlobalRef(System.IntPtr globalref) { }
        private System.Void DeleteWeakGlobalRef(System.IntPtr globalref) { }
        private System.Void DeleteLocalRef(System.IntPtr localref) { }
        private System.IntPtr NewString(System.String chars) { }
        private System.String GetStringChars(System.IntPtr str) { }
        private System.IntPtr GetObjectClass(System.IntPtr ptr) { }
        private System.IntPtr GetStaticMethodID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr GetMethodID(System.IntPtr obj, System.String name, System.String sig) { }
        private System.IntPtr GetFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr GetStaticFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        private System.IntPtr FromReflectedMethod(System.IntPtr refMethod) { }
        private System.IntPtr FindClass(System.String name) { }
        private System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.String GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Single GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Int64 GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Int16 GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.SByte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Boolean GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Int32 GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID) { }
        private System.Void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.String CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Single CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int64 CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int16 CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.SByte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Boolean CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int32 CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.String GetStringField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Char GetCharField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Single GetFloatField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Int64 GetLongField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Int16 GetShortField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.SByte GetSByteField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Boolean GetBooleanField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.Int32 GetIntField(System.IntPtr obj, System.IntPtr fieldID) { }
        private System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.String CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Single CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int64 CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int16 CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.SByte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Boolean CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Int32 CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        private System.Char[] FromCharArray(System.IntPtr array) { }
        private System.Double[] FromDoubleArray(System.IntPtr array) { }
        private System.Single[] FromFloatArray(System.IntPtr array) { }
        private System.Int64[] FromLongArray(System.IntPtr array) { }
        private System.Int16[] FromShortArray(System.IntPtr array) { }
        private System.Byte[] FromByteArray(System.IntPtr array) { }
        private System.SByte[] FromSByteArray(System.IntPtr array) { }
        private System.Boolean[] FromBooleanArray(System.IntPtr array) { }
        private System.Int32[] FromIntArray(System.IntPtr array) { }
        private System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr type) { }
        private System.IntPtr ToCharArray(System.Char[] array) { }
        private System.IntPtr ToDoubleArray(System.Double[] array) { }
        private System.IntPtr ToFloatArray(System.Single[] array) { }
        private System.IntPtr ToLongArray(System.Int64[] array) { }
        private System.IntPtr ToShortArray(System.Int16[] array) { }
        private System.IntPtr ToByteArray(System.Byte[] array) { }
        private System.IntPtr ToSByteArray(System.SByte[] array) { }
        private System.IntPtr ToBooleanArray(System.Boolean[] array) { }
        private System.IntPtr ToIntArray(System.Int32[] array) { }
        private System.IntPtr GetObjectArrayElement(System.IntPtr array, System.Int32 index) { }
        private System.Int32 GetArrayLength(System.IntPtr array) { }

    }

}

namespace UnityEngine.Android
{

    // TypeToken: 0x200000F
    public class Common
    {
        // Fields
        private static UnityEngine.AndroidJavaObject m_Activity;        // 0x0

        // Methods
        private UnityEngine.AndroidJavaObject GetActivity() { }

    }

}

