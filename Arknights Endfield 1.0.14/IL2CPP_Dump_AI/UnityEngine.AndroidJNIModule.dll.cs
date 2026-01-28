// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AndroidJNIModule.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.AndroidJavaRunnable
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.AndroidJavaException
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Exception
FIELDS:
  private           System.String                   mJavaStackTrace  // 0x90
METHODS:
  System.Void .ctor(System.String message, System.String javaStackTrace)
  System.String get_StackTrace()
END_CLASS

CLASS: UnityEngine.GlobalJavaObjectRef
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.Boolean                  m_disposed  // 0x10
  protected         System.IntPtr                   m_jobject  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr jobject)
  System.Void Finalize()
  System.IntPtr op_Implicit(UnityEngine.GlobalJavaObjectRef obj)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.AndroidJavaRunnableProxy
TYPE:  class
TOKEN: 0x2000005
EXTENDS: AndroidJavaProxy
FIELDS:
  private           UnityEngine.AndroidJavaRunnable mRunnable  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.AndroidJavaRunnable runnable)
END_CLASS

CLASS: UnityEngine.AndroidJavaProxy
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  public    readonly UnityEngine.AndroidJavaClass    javaInterface  // 0x10
  private           System.IntPtr                   proxyObject  // 0x18
  private   static readonly UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass  // 0x0
  private   static readonly System.IntPtr                   s_HashCodeMethodID  // 0x8
METHODS:
  System.Void .ctor(System.String javaInterface)
  System.Void .ctor(UnityEngine.AndroidJavaClass javaInterface)
  System.Void Finalize()
  UnityEngine.AndroidJavaObject Invoke(System.String methodName, System.Object[] args)
  UnityEngine.AndroidJavaObject Invoke(System.String methodName, UnityEngine.AndroidJavaObject[] javaArgs)
  System.Boolean equals(UnityEngine.AndroidJavaObject obj)
  System.Int32 hashCode()
  System.String toString()
  UnityEngine.AndroidJavaObject GetProxyObject()
  System.IntPtr GetRawProxy()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AndroidJavaObject
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static  System.Boolean                  enableDebugPrints  // 0x0
  private           UnityEngine.GlobalJavaObjectRef m_jobject  // 0x10
  private           UnityEngine.GlobalJavaObjectRef m_jclass  // 0x18
METHODS:
  System.Void .ctor(System.String className, System.Object[] args)
  System.Void Dispose()
  FieldType Get(System.String fieldName)
  FieldType GetStatic(System.String fieldName)
  System.IntPtr GetRawObject()
  System.IntPtr GetRawClass()
  ReturnType Call(System.String methodName, System.Object[] args)
  ReturnType CallStatic(System.String methodName, System.Object[] args)
  System.Void DebugPrint(System.String msg)
  System.Void _AndroidJavaObject(System.String className, System.Object[] args)
  System.Void .ctor(System.IntPtr jobject)
  System.Void .ctor()
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  ReturnType _Call(System.String methodName, System.Object[] args)
  FieldType _Get(System.String fieldName)
  ReturnType _CallStatic(System.String methodName, System.Object[] args)
  FieldType _GetStatic(System.String fieldName)
  UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(System.IntPtr jobject)
  UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(System.IntPtr jclass)
  ReturnType FromJavaArrayDeleteLocalRef(System.IntPtr jobject)
  System.IntPtr _GetRawObject()
  System.IntPtr _GetRawClass()
END_CLASS

CLASS: UnityEngine.AndroidJavaClass
TYPE:  class
TOKEN: 0x2000008
EXTENDS: AndroidJavaObject
FIELDS:
METHODS:
  System.Void .ctor(System.String className)
  System.Void _AndroidJavaClass(System.String className)
  System.Void .ctor(System.IntPtr jclass)
END_CLASS

CLASS: UnityEngine.AndroidReflection
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   static readonly UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass  // 0x0
  private   static readonly System.IntPtr                   s_ReflectionHelperGetConstructorID  // 0x8
  private   static readonly System.IntPtr                   s_ReflectionHelperGetMethodID  // 0x10
  private   static readonly System.IntPtr                   s_ReflectionHelperGetFieldID  // 0x18
  private   static readonly System.IntPtr                   s_ReflectionHelperGetFieldSignature  // 0x20
  private   static readonly System.IntPtr                   s_ReflectionHelperNewProxyInstance  // 0x28
  private   static readonly System.IntPtr                   s_ReflectionHelperSetNativeExceptionOnProxy  // 0x30
  private   static readonly System.IntPtr                   s_FieldGetDeclaringClass  // 0x38
METHODS:
  System.Boolean IsPrimitive(System.Type t)
  System.Boolean IsAssignableFrom(System.Type t, System.Type from)
  System.IntPtr GetStaticMethodID(System.String clazz, System.String methodName, System.String signature)
  System.IntPtr GetMethodID(System.String clazz, System.String methodName, System.String signature)
  System.IntPtr GetConstructorMember(System.IntPtr jclass, System.String signature)
  System.IntPtr GetMethodMember(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic)
  System.IntPtr GetFieldMember(System.IntPtr jclass, System.String fieldName, System.String signature, System.Boolean isStatic)
  System.IntPtr GetFieldClass(System.IntPtr field)
  System.String GetFieldSignature(System.IntPtr field)
  System.IntPtr NewProxyInstance(System.IntPtr player, System.IntPtr delegateHandle, System.IntPtr interfaze)
  System.Void SetNativeExceptionOnProxy(System.IntPtr proxy, System.Exception e, System.Boolean methodNotFound)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine._AndroidJNIHelper
TYPE:  class
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.IntPtr CreateJavaProxy(System.IntPtr player, System.IntPtr delegateHandle, UnityEngine.AndroidJavaProxy proxy)
  System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable)
  System.IntPtr InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, System.IntPtr jmethodName, System.IntPtr jargs)
  UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args)
  System.Object UnboxArray(UnityEngine.AndroidJavaObject obj)
  System.Object Unbox(UnityEngine.AndroidJavaObject obj)
  UnityEngine.AndroidJavaObject Box(System.Object obj)
  System.Void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs)
  System.IntPtr ConvertToJNIArray(System.Array array)
  ArrayType ConvertFromJNIArray(System.IntPtr array)
  System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args)
  System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.Object[] args, System.Boolean isStatic)
  System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.Boolean isStatic)
  System.IntPtr GetConstructorID(System.IntPtr jclass, System.String signature)
  System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic)
  System.IntPtr GetMethodIDFallback(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic)
  System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.String signature, System.Boolean isStatic)
  System.String GetSignature(System.Object obj)
  System.String GetSignature(System.Object[] args)
  System.String GetSignature(System.Object[] args)
END_CLASS

CLASS: UnityEngine.jvalue
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Boolean                  z  // 0x10
  public            System.SByte                    b  // 0x10
  public            System.Char                     c  // 0x10
  public            System.Int16                    s  // 0x10
  public            System.Int32                    i  // 0x10
  public            System.Int64                    j  // 0x10
  public            System.Single                   f  // 0x10
  public            System.Double                   d  // 0x10
  public            System.IntPtr                   l  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.AndroidJNIHelper
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
  System.IntPtr GetConstructorID(System.IntPtr javaClass, System.String signature)
  System.IntPtr GetMethodID(System.IntPtr javaClass, System.String methodName, System.String signature, System.Boolean isStatic)
  System.IntPtr GetFieldID(System.IntPtr javaClass, System.String fieldName, System.String signature, System.Boolean isStatic)
  System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable)
  System.IntPtr CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy)
  UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args)
  System.Void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs)
  System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args)
  ArrayType ConvertFromJNIArray(System.IntPtr array)
  System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.Object[] args, System.Boolean isStatic)
  System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.Boolean isStatic)
END_CLASS

CLASS: UnityEngine.AndroidJNI
TYPE:  class
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.IntPtr FindClass(System.String name)
  System.IntPtr FromReflectedMethod(System.IntPtr refMethod)
  System.IntPtr ExceptionOccurred()
  System.Void ExceptionClear()
  System.Int32 PushLocalFrame(System.Int32 capacity)
  System.IntPtr PopLocalFrame(System.IntPtr ptr)
  System.IntPtr NewGlobalRef(System.IntPtr obj)
  System.Void DeleteGlobalRef(System.IntPtr obj)
  System.IntPtr NewWeakGlobalRef(System.IntPtr obj)
  System.Void DeleteWeakGlobalRef(System.IntPtr obj)
  System.IntPtr NewLocalRef(System.IntPtr obj)
  System.Void DeleteLocalRef(System.IntPtr obj)
  System.Boolean IsSameObject(System.IntPtr obj1, System.IntPtr obj2)
  System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.IntPtr GetObjectClass(System.IntPtr obj)
  System.IntPtr GetMethodID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr GetFieldID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr GetStaticMethodID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr GetStaticFieldID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr NewString(System.String chars)
  System.IntPtr NewStringFromStr(System.String chars)
  System.String GetStringChars(System.IntPtr str)
  System.String CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int32 CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Boolean CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int16 CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.SByte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Single CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int64 CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.String GetStringField(System.IntPtr obj, System.IntPtr fieldID)
  System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID)
  System.Boolean GetBooleanField(System.IntPtr obj, System.IntPtr fieldID)
  System.SByte GetSByteField(System.IntPtr obj, System.IntPtr fieldID)
  System.Char GetCharField(System.IntPtr obj, System.IntPtr fieldID)
  System.Int16 GetShortField(System.IntPtr obj, System.IntPtr fieldID)
  System.Int32 GetIntField(System.IntPtr obj, System.IntPtr fieldID)
  System.Int64 GetLongField(System.IntPtr obj, System.IntPtr fieldID)
  System.Single GetFloatField(System.IntPtr obj, System.IntPtr fieldID)
  System.Double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID)
  System.String CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int32 CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Boolean CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int16 CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.SByte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Single CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int64 CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.String GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID)
  System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Boolean GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID)
  System.SByte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Int16 GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Int32 GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Int64 GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Single GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID)
  System.IntPtr ToBooleanArray(System.Boolean[] array)
  System.IntPtr ToByteArray(System.Byte[] array)
  System.IntPtr ToSByteArray(System.SByte[] array)
  System.IntPtr ToCharArray(System.Char[] array)
  System.IntPtr ToShortArray(System.Int16[] array)
  System.IntPtr ToIntArray(System.Int32[] array)
  System.IntPtr ToLongArray(System.Int64[] array)
  System.IntPtr ToFloatArray(System.Single[] array)
  System.IntPtr ToDoubleArray(System.Double[] array)
  System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr arrayClass)
  System.Boolean[] FromBooleanArray(System.IntPtr array)
  System.Byte[] FromByteArray(System.IntPtr array)
  System.SByte[] FromSByteArray(System.IntPtr array)
  System.Char[] FromCharArray(System.IntPtr array)
  System.Int16[] FromShortArray(System.IntPtr array)
  System.Int32[] FromIntArray(System.IntPtr array)
  System.Int64[] FromLongArray(System.IntPtr array)
  System.Single[] FromFloatArray(System.IntPtr array)
  System.Double[] FromDoubleArray(System.IntPtr array)
  System.Int32 GetArrayLength(System.IntPtr array)
  System.IntPtr NewObjectArray(System.Int32 size, System.IntPtr clazz, System.IntPtr obj)
  System.IntPtr GetObjectArrayElement(System.IntPtr array, System.Int32 index)
  System.Void SetObjectArrayElement(System.IntPtr array, System.Int32 index, System.IntPtr obj)
END_CLASS

CLASS: UnityEngine.AndroidJNISafe
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Void CheckException()
  System.Void DeleteGlobalRef(System.IntPtr globalref)
  System.Void DeleteWeakGlobalRef(System.IntPtr globalref)
  System.Void DeleteLocalRef(System.IntPtr localref)
  System.IntPtr NewString(System.String chars)
  System.String GetStringChars(System.IntPtr str)
  System.IntPtr GetObjectClass(System.IntPtr ptr)
  System.IntPtr GetStaticMethodID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr GetMethodID(System.IntPtr obj, System.String name, System.String sig)
  System.IntPtr GetFieldID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr GetStaticFieldID(System.IntPtr clazz, System.String name, System.String sig)
  System.IntPtr FromReflectedMethod(System.IntPtr refMethod)
  System.IntPtr FindClass(System.String name)
  System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID)
  System.String GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Single GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Int64 GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Int16 GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID)
  System.SByte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Boolean GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Int32 GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID)
  System.Void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.String CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Single CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int64 CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int16 CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.SByte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Boolean CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int32 CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID)
  System.String GetStringField(System.IntPtr obj, System.IntPtr fieldID)
  System.Char GetCharField(System.IntPtr obj, System.IntPtr fieldID)
  System.Double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID)
  System.Single GetFloatField(System.IntPtr obj, System.IntPtr fieldID)
  System.Int64 GetLongField(System.IntPtr obj, System.IntPtr fieldID)
  System.Int16 GetShortField(System.IntPtr obj, System.IntPtr fieldID)
  System.SByte GetSByteField(System.IntPtr obj, System.IntPtr fieldID)
  System.Boolean GetBooleanField(System.IntPtr obj, System.IntPtr fieldID)
  System.Int32 GetIntField(System.IntPtr obj, System.IntPtr fieldID)
  System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.String CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Single CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int64 CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int16 CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.SByte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Boolean CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Int32 CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
  System.Char[] FromCharArray(System.IntPtr array)
  System.Double[] FromDoubleArray(System.IntPtr array)
  System.Single[] FromFloatArray(System.IntPtr array)
  System.Int64[] FromLongArray(System.IntPtr array)
  System.Int16[] FromShortArray(System.IntPtr array)
  System.Byte[] FromByteArray(System.IntPtr array)
  System.SByte[] FromSByteArray(System.IntPtr array)
  System.Boolean[] FromBooleanArray(System.IntPtr array)
  System.Int32[] FromIntArray(System.IntPtr array)
  System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr type)
  System.IntPtr ToCharArray(System.Char[] array)
  System.IntPtr ToDoubleArray(System.Double[] array)
  System.IntPtr ToFloatArray(System.Single[] array)
  System.IntPtr ToLongArray(System.Int64[] array)
  System.IntPtr ToShortArray(System.Int16[] array)
  System.IntPtr ToByteArray(System.Byte[] array)
  System.IntPtr ToSByteArray(System.SByte[] array)
  System.IntPtr ToBooleanArray(System.Boolean[] array)
  System.IntPtr ToIntArray(System.Int32[] array)
  System.IntPtr GetObjectArrayElement(System.IntPtr array, System.Int32 index)
  System.Int32 GetArrayLength(System.IntPtr array)
END_CLASS

CLASS: UnityEngine.Android.Common
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private   static  UnityEngine.AndroidJavaObject   m_Activity  // 0x0
METHODS:
  UnityEngine.AndroidJavaObject GetActivity()
END_CLASS

