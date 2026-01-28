// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRF.dll
// Classes:  90
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SRDebugUtil
    {
        // Fields
        public static System.Int32 LineBufferCount;        // 0x0
        private static System.Boolean <IsFixedUpdate>k__BackingField;        // 0x0

        // Methods
        private System.Boolean get_IsFixedUpdate() { }
        private System.Void set_IsFixedUpdate(System.Boolean value) { }
        private System.Void AssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance) { }
        private System.Void Assert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance) { }
        private System.Void EditorAssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance) { }
        private System.Void EditorAssert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance) { }

    }

    // TypeToken: 0x2000003
    public class SRFileUtil
    {
        // Methods
        private System.Void DeleteDirectory(System.String path) { }
        private System.String GetBytesReadable(System.Int64 i) { }

    }

    // TypeToken: 0x2000004
    public class SRInstantiate
    {
        // Methods
        private T Instantiate(T prefab) { }
        private UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab) { }
        private T Instantiate(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x2000006
    public struct EaseType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRMath.EaseType Linear;        // 0x0
        public static SRMath.EaseType QuadEaseOut;        // 0x0
        public static SRMath.EaseType QuadEaseIn;        // 0x0
        public static SRMath.EaseType QuadEaseInOut;        // 0x0
        public static SRMath.EaseType QuadEaseOutIn;        // 0x0
        public static SRMath.EaseType ExpoEaseOut;        // 0x0
        public static SRMath.EaseType ExpoEaseIn;        // 0x0
        public static SRMath.EaseType ExpoEaseInOut;        // 0x0
        public static SRMath.EaseType ExpoEaseOutIn;        // 0x0
        public static SRMath.EaseType CubicEaseOut;        // 0x0
        public static SRMath.EaseType CubicEaseIn;        // 0x0
        public static SRMath.EaseType CubicEaseInOut;        // 0x0
        public static SRMath.EaseType CubicEaseOutIn;        // 0x0
        public static SRMath.EaseType QuartEaseOut;        // 0x0
        public static SRMath.EaseType QuartEaseIn;        // 0x0
        public static SRMath.EaseType QuartEaseInOut;        // 0x0
        public static SRMath.EaseType QuartEaseOutIn;        // 0x0
        public static SRMath.EaseType QuintEaseOut;        // 0x0
        public static SRMath.EaseType QuintEaseIn;        // 0x0
        public static SRMath.EaseType QuintEaseInOut;        // 0x0
        public static SRMath.EaseType QuintEaseOutIn;        // 0x0
        public static SRMath.EaseType CircEaseOut;        // 0x0
        public static SRMath.EaseType CircEaseIn;        // 0x0
        public static SRMath.EaseType CircEaseInOut;        // 0x0
        public static SRMath.EaseType CircEaseOutIn;        // 0x0
        public static SRMath.EaseType SineEaseOut;        // 0x0
        public static SRMath.EaseType SineEaseIn;        // 0x0
        public static SRMath.EaseType SineEaseInOut;        // 0x0
        public static SRMath.EaseType SineEaseOutIn;        // 0x0
        public static SRMath.EaseType ElasticEaseOut;        // 0x0
        public static SRMath.EaseType ElasticEaseIn;        // 0x0
        public static SRMath.EaseType ElasticEaseInOut;        // 0x0
        public static SRMath.EaseType ElasticEaseOutIn;        // 0x0
        public static SRMath.EaseType BounceEaseOut;        // 0x0
        public static SRMath.EaseType BounceEaseIn;        // 0x0
        public static SRMath.EaseType BounceEaseInOut;        // 0x0
        public static SRMath.EaseType BounceEaseOutIn;        // 0x0
        public static SRMath.EaseType BackEaseOut;        // 0x0
        public static SRMath.EaseType BackEaseIn;        // 0x0
        public static SRMath.EaseType BackEaseInOut;        // 0x0
        public static SRMath.EaseType BackEaseOutIn;        // 0x0

    }

    // TypeToken: 0x2000007
    public class TweenFunctions
    {
        // Methods
        private System.Single Linear(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ExpoEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ExpoEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ExpoEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ExpoEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CircEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CircEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CircEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CircEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuadEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuadEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuadEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuadEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single SineEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single SineEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single SineEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single SineEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CubicEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CubicEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CubicEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single CubicEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuartEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuartEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuartEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuartEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuintEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuintEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuintEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single QuintEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ElasticEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ElasticEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ElasticEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single ElasticEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BounceEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BounceEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BounceEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BounceEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BackEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BackEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BackEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        private System.Single BackEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }

    }

    // TypeToken: 0x2000005
    public class SRMath
    {
        // Methods
        private System.Single LerpUnclamped(System.Single from, System.Single to, System.Single t) { }
        private UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t) { }
        private System.Single FacingNormalized(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2) { }
        private System.Single WrapAngle(System.Single angle) { }
        private System.Single NearestAngle(System.Single to, System.Single angle1, System.Single angle2) { }
        private System.Int32 Wrap(System.Int32 max, System.Int32 value) { }
        private System.Single Wrap(System.Single max, System.Single value) { }
        private System.Single Average(System.Single v1, System.Single v2) { }
        private System.Single Angle(UnityEngine.Vector2 direction) { }
        private System.Single Ease(System.Single from, System.Single to, System.Single t, SRMath.EaseType type) { }
        private System.Single SpringLerp(System.Single strength, System.Single deltaTime) { }
        private System.Single SpringLerp(System.Single from, System.Single to, System.Single strength, System.Single deltaTime) { }
        private UnityEngine.Vector3 SpringLerp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single strength, System.Single deltaTime) { }
        private UnityEngine.Quaternion SpringLerp(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single strength, System.Single deltaTime) { }
        private System.Single SmoothClamp(System.Single value, System.Single min, System.Single max, System.Single scrollMax, SRMath.EaseType easeType) { }

    }

    // TypeToken: 0x200000A
    public struct TOKEN
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRF.Json.Parser.TOKEN NONE;        // 0x0
        public static SRF.Json.Parser.TOKEN CURLY_OPEN;        // 0x0
        public static SRF.Json.Parser.TOKEN CURLY_CLOSE;        // 0x0
        public static SRF.Json.Parser.TOKEN SQUARED_OPEN;        // 0x0
        public static SRF.Json.Parser.TOKEN SQUARED_CLOSE;        // 0x0
        public static SRF.Json.Parser.TOKEN COLON;        // 0x0
        public static SRF.Json.Parser.TOKEN COMMA;        // 0x0
        public static SRF.Json.Parser.TOKEN STRING;        // 0x0
        public static SRF.Json.Parser.TOKEN NUMBER;        // 0x0
        public static SRF.Json.Parser.TOKEN TRUE;        // 0x0
        public static SRF.Json.Parser.TOKEN FALSE;        // 0x0
        public static SRF.Json.Parser.TOKEN NULL;        // 0x0

    }

    // TypeToken: 0x2000009
    public class Parser, IDisposable
    {
        // Fields
        private static System.String WORD_BREAK;        // 0x0
        private System.IO.StringReader json;        // 0x10

        // Methods
        private System.Void .ctor(System.String jsonString) { }
        private System.Char get_PeekChar() { }
        private System.Char get_NextChar() { }
        private System.String get_NextWord() { }
        private SRF.Json.Parser.TOKEN get_NextToken() { }
        private System.Void Dispose() { }
        private System.Boolean IsWordBreak(System.Char c) { }
        private System.Object Parse(System.String jsonString) { }
        private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }
        private System.Collections.Generic.List<System.Object> ParseArray() { }
        private System.Object ParseValue() { }
        private System.Object ParseByToken(SRF.Json.Parser.TOKEN token) { }
        private System.String ParseString() { }
        private System.Object ParseNumber() { }
        private System.Void EatWhitespace() { }

    }

    // TypeToken: 0x200000B
    public class Serializer
    {
        // Fields
        private System.Text.StringBuilder builder;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.String Serialize(System.Object obj) { }
        private System.Void SerializeValue(System.Object value) { }
        private System.Void SerializeObject(System.Collections.IDictionary obj) { }
        private System.Void SerializeArray(System.Collections.IList anArray) { }
        private System.Void SerializeString(System.String str) { }
        private System.Void SerializeOther(System.Object value) { }

    }

    // TypeToken: 0x2000012
    public struct FieldInfo
    {
        // Fields
        public System.Boolean AutoCreate;        // 0x10
        public System.Boolean AutoSet;        // 0x11
        public System.Reflection.FieldInfo Field;        // 0x18
        public System.Boolean Import;        // 0x20
        public System.Type ImportType;        // 0x28

    }

    // TypeToken: 0x2000020
    public struct Operations
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRF.UI.CopyPreferredSizes.Operations Max;        // 0x0
        public static SRF.UI.CopyPreferredSizes.Operations Min;        // 0x0

    }

    // TypeToken: 0x2000021
    public class CopySource
    {
        // Fields
        public UnityEngine.RectTransform Rect;        // 0x10
        public System.Single PaddingHeight;        // 0x18
        public System.Single PaddingWidth;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public struct Modes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRF.UI.ResponsiveEnable.Modes EnableAbove;        // 0x0
        public static SRF.UI.ResponsiveEnable.Modes EnableBelow;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct Entry
    {
        // Fields
        public UnityEngine.Behaviour[] Components;        // 0x10
        public UnityEngine.GameObject[] GameObjects;        // 0x18
        public SRF.UI.ResponsiveEnable.Modes Mode;        // 0x20
        public System.Single ThresholdHeight;        // 0x24
        public System.Single ThresholdWidth;        // 0x28

    }

    // TypeToken: 0x200002D
    public struct SizeDefinition
    {
        // Fields
        public System.Single ElementWidth;        // 0x10
        public System.Single ThresholdWidth;        // 0x14

    }

    // TypeToken: 0x200002C
    public struct Element
    {
        // Fields
        public SRF.UI.ResponsiveResize.Element.SizeDefinition[] SizeDefinitions;        // 0x10
        public UnityEngine.RectTransform Target;        // 0x18

    }

    // TypeToken: 0x2000033
    public class SpinEvent : UnityEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class SelectedItemChangedEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class Row
    {
        // Fields
        public System.Object Data;        // 0x10
        public System.Int32 Index;        // 0x18
        public UnityEngine.RectTransform Rect;        // 0x20
        public SRF.UI.StyleRoot Root;        // 0x28
        public SRF.UI.Layout.IVirtualView View;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class Service
    {
        // Fields
        public System.Object Object;        // 0x10
        public System.Type Type;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public class ServiceStub
    {
        // Fields
        public System.Func<System.Object> Constructor;        // 0x10
        public System.Type InterfaceType;        // 0x18
        public System.Func<System.Type> Selector;        // 0x20
        public System.Type Type;        // 0x28

        // Methods
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

namespace SRF
{

    // TypeToken: 0x2000008
    public class Json
    {
        // Methods
        private System.Object Deserialize(System.String json) { }
        private System.String Serialize(System.Object obj) { }

    }

    // TypeToken: 0x200000C
    public class SRList`1, IList`1, ICollection`1, IEnumerable`1, IEnumerable, ISerializationCallbackReceiver
    {
        // Fields
        private T[] _buffer;        // 0x0
        private System.Int32 _count;        // 0x0
        private System.Collections.Generic.EqualityComparer<T> _equalityComparer;        // 0x0
        private System.Collections.ObjectModel.ReadOnlyCollection<T> _readOnlyWrapper;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> source) { }
        private T[] get_Buffer() { }
        private System.Void set_Buffer(T[] value) { }
        private System.Collections.Generic.EqualityComparer<T> get_EqualityComparer() { }
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Add(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(T item) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 IndexOf(T item) { }
        private System.Void Insert(System.Int32 index, T item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void AddRange(System.Collections.Generic.IEnumerable<T> range) { }
        private System.Void Clear(System.Boolean clean) { }
        private System.Void Clean() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly() { }
        private System.Void Expand() { }
        private System.Void Trim() { }
        private System.Void Sort(System.Comparison<T> comparer) { }

    }

    // TypeToken: 0x200000E
    public class SRMonoBehaviour : MonoBehaviour
    {
        // Fields
        private UnityEngine.Collider _collider;        // 0x18
        private UnityEngine.Transform _transform;        // 0x20
        private UnityEngine.Rigidbody _rigidBody;        // 0x28
        private UnityEngine.GameObject _gameObject;        // 0x30
        private UnityEngine.Rigidbody2D _rigidbody2D;        // 0x38
        private UnityEngine.Collider2D _collider2D;        // 0x40

        // Methods
        private UnityEngine.Transform get_CachedTransform() { }
        private UnityEngine.Collider get_CachedCollider() { }
        private UnityEngine.Collider2D get_CachedCollider2D() { }
        private UnityEngine.Rigidbody get_CachedRigidBody() { }
        private UnityEngine.Rigidbody2D get_CachedRigidBody2D() { }
        private UnityEngine.GameObject get_CachedGameObject() { }
        private UnityEngine.Transform get_transform() { }
        private System.Void AssertNotNull(System.Object value, System.String fieldName) { }
        private System.Void Assert(System.Boolean condition, System.String message) { }
        private System.Void EditorAssertNotNull(System.Object value, System.String fieldName) { }
        private System.Void EditorAssert(System.Boolean condition, System.String message) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class RequiredFieldAttribute : Attribute
    {
        // Fields
        private System.Boolean _autoCreate;        // 0x10
        private System.Boolean _autoSearch;        // 0x11
        private System.Boolean _editorOnly;        // 0x12

        // Methods
        private System.Void .ctor(System.Boolean autoSearch) { }
        private System.Void .ctor() { }
        private System.Boolean get_AutoSearch() { }
        private System.Void set_AutoSearch(System.Boolean value) { }
        private System.Boolean get_AutoCreate() { }
        private System.Void set_AutoCreate(System.Boolean value) { }
        private System.Boolean get_EditorOnly() { }
        private System.Void set_EditorOnly(System.Boolean value) { }

    }

    // TypeToken: 0x2000010
    public class ImportAttribute : Attribute
    {
        // Fields
        public readonly System.Type Service;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type serviceType) { }

    }

    // TypeToken: 0x2000011
    public class SRMonoBehaviourEx : SRMonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo>> _checkedFields;        // 0x0

        // Methods
        private System.Void CheckFields(SRF.SRMonoBehaviourEx instance, System.Boolean justSet) { }
        private System.Void PopulateObject(System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo> cache, SRF.SRMonoBehaviourEx instance, System.Boolean justSet) { }
        private System.Collections.Generic.List<SRF.SRMonoBehaviourEx.FieldInfo> ScanType(System.Type t) { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void FixedUpdate() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class Coroutines
    {
        // Methods
        private System.Collections.IEnumerator WaitForSecondsRealTime(System.Single time) { }

    }

    // TypeToken: 0x2000015
    public class SRFFloatExtensions
    {
        // Methods
        private System.Single Sqr(System.Single f) { }
        private System.Single SqrRt(System.Single f) { }
        private System.Boolean ApproxZero(System.Single f) { }
        private System.Boolean Approx(System.Single f, System.Single f2) { }

    }

    // TypeToken: 0x2000016
    public class SRFGameObjectExtensions
    {
        // Methods
        private T GetIComponent(UnityEngine.GameObject t) { }
        private T GetComponentOrAdd(UnityEngine.GameObject obj) { }
        private System.Void RemoveComponentIfExists(UnityEngine.GameObject obj) { }
        private System.Void RemoveComponentsIfExists(UnityEngine.GameObject obj) { }
        private System.Boolean EnableComponentIfExists(UnityEngine.GameObject obj, System.Boolean enable) { }
        private System.Void SetLayerRecursive(UnityEngine.GameObject o, System.Int32 layer) { }
        private System.Void SetLayerInternal(UnityEngine.Transform t, System.Int32 layer) { }

    }

    // TypeToken: 0x2000017
    public class SRFIListExtensions
    {
        // Methods
        private T Random(System.Collections.Generic.IList<T> list) { }
        private T RandomOrDefault(System.Collections.Generic.IList<T> list) { }
        private T PopLast(System.Collections.Generic.IList<T> list) { }

    }

    // TypeToken: 0x2000018
    public class SRFStringExtensions
    {
        // Methods
        private System.String Fmt(System.String formatString, System.Object[] args) { }

    }

    // TypeToken: 0x2000019
    public class SRFTransformExtensions
    {
        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.Transform> GetChildren(UnityEngine.Transform t) { }
        private System.Void ResetLocal(UnityEngine.Transform t) { }
        private UnityEngine.GameObject CreateChild(UnityEngine.Transform t, System.String name) { }
        private System.Void SetParentMaintainLocals(UnityEngine.Transform t, UnityEngine.Transform parent) { }
        private System.Void SetLocals(UnityEngine.Transform t, UnityEngine.Transform from) { }
        private System.Void Match(UnityEngine.Transform t, UnityEngine.Transform from) { }
        private System.Void DestroyChildren(UnityEngine.Transform t) { }

    }

    // TypeToken: 0x200001B
    public class Hierarchy
    {
        // Fields
        private static readonly System.Char[] Seperator;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> Cache;        // 0x8

        // Methods
        private UnityEngine.Transform get_Item(System.String key) { }
        private UnityEngine.Transform Get(System.String key) { }
        private System.Void RuntimeInitialize() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace SRF.Components
{

    // TypeToken: 0x2000058
    public class SRAutoSingleton`1 : SRMonoBehaviour
    {
        // Fields
        private static T _instance;        // 0x0

        // Methods
        private T get_Instance() { }
        private System.Boolean get_HasInstance() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnApplicationQuit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public class SRSingleton`1 : SRMonoBehaviour
    {
        // Fields
        private static T _instance;        // 0x0

        // Methods
        private T get_Instance() { }
        private System.Boolean get_HasInstance() { }
        private System.Void Register() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnApplicationQuit() { }
        private System.Void .ctor() { }

    }

}

namespace SRF.Helpers
{

    // TypeToken: 0x200004E
    public class AssetUtil
    {
    }

    // TypeToken: 0x200004F
    public class MethodReference
    {
        // Fields
        private readonly System.Func<System.Object[],System.Object> _method;        // 0x10

        // Methods
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo method) { }
        private System.Void .ctor(System.Func<System.Object[],System.Object> method) { }
        private System.Object Invoke(System.Object[] parameters) { }
        private SRF.Helpers.MethodReference op_Implicit(System.Action action) { }

    }

    // TypeToken: 0x2000052
    public class PropertyValueChangedHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(SRF.Helpers.PropertyReference property) { }
        private System.IAsyncResult BeginInvoke(SRF.Helpers.PropertyReference property, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000053
    public class PropertyReference
    {
        // Fields
        private readonly System.Reflection.PropertyInfo _property;        // 0x10
        private readonly System.Object _target;        // 0x18
        private readonly System.Attribute[] _attributes;        // 0x20
        private readonly System.Func<System.Object> _getter;        // 0x28
        private readonly System.Action<System.Object> _setter;        // 0x30
        private System.Collections.Generic.List<SRF.Helpers.PropertyValueChangedHandler> _valueChangedListeners;        // 0x38
        private System.Type <PropertyType>k__BackingField;        // 0x40

        // Methods
        private System.Void add_ValueChanged(SRF.Helpers.PropertyValueChangedHandler value) { }
        private System.Void remove_ValueChanged(SRF.Helpers.PropertyValueChangedHandler value) { }
        private SRF.Helpers.PropertyReference FromLambda(System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes) { }
        private System.Void .ctor(System.Object target, System.Reflection.PropertyInfo property) { }
        private System.Void .ctor(System.Type type, System.Func<System.Object> getter, System.Action<System.Object> setter, System.Attribute[] attributes) { }
        private System.Type get_PropertyType() { }
        private System.Void set_PropertyType(System.Type value) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Void NotifyValueChanged() { }
        private System.Object GetValue() { }
        private System.Void SetValue(System.Object value) { }
        private T GetAttribute() { }
        private System.Void OnTargetPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000057
    public class SRReflection
    {
        // Methods
        private System.Void SetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p, System.Object value) { }
        private System.Object GetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p) { }
        private T GetAttribute(System.Reflection.MemberInfo t) { }

    }

}

namespace SRF.Internal
{

    // TypeToken: 0x200005A
    public class ComponentMenuPaths
    {
        // Fields
        public static System.String PathRoot;        // 0x0
        public static System.String SRServiceManager;        // 0x0
        public static System.String BehavioursRoot;        // 0x0
        public static System.String DestroyOnDisable;        // 0x0
        public static System.String DontDestroyOnLoad;        // 0x0
        public static System.String MatchTransform;        // 0x0
        public static System.String LookAt;        // 0x0
        public static System.String MatchForwardDirection;        // 0x0
        public static System.String MatchMainCameraForwardDirection;        // 0x0
        public static System.String RuntimePosition;        // 0x0
        public static System.String ScrollTexture;        // 0x0
        public static System.String SmoothFloatBehaviour;        // 0x0
        public static System.String SmoothFollow2D;        // 0x0
        public static System.String SpringFollow;        // 0x0
        public static System.String SmoothMatchTransform;        // 0x0
        public static System.String SpawnPrefab;        // 0x0
        public static System.String Velocity;        // 0x0
        public static System.String SmoothOscillate;        // 0x0
        public static System.String SRDebugCamera;        // 0x0
        public static System.String ComponentsRoot;        // 0x0
        public static System.String SRLineRenderer;        // 0x0
        public static System.String SelectionRoot;        // 0x0
        public static System.String SRSpriteFadeRenderer;        // 0x0
        public static System.String SRMaterialFadeRenderer;        // 0x0
        public static System.String SRCompositeFadeRenderer;        // 0x0
        public static System.String UIRoot;        // 0x0
        public static System.String TiltOnTouch;        // 0x0
        public static System.String ScaleOnTouch;        // 0x0
        public static System.String InheritColour;        // 0x0
        public static System.String FlashGraphic;        // 0x0
        public static System.String CopyPreferredSize;        // 0x0
        public static System.String CopyPreferredSizes;        // 0x0
        public static System.String CopyLayoutElement;        // 0x0
        public static System.String CopySizeIntoLayoutElement;        // 0x0
        public static System.String SRText;        // 0x0
        public static System.String Unselectable;        // 0x0
        public static System.String LongPressButton;        // 0x0
        public static System.String ScrollToBottom;        // 0x0
        public static System.String FlowLayoutGroup;        // 0x0
        public static System.String VirtualVerticalLayoutGroup;        // 0x0
        public static System.String StyleRoot;        // 0x0
        public static System.String StyleComponent;        // 0x0
        public static System.String ResponsiveEnable;        // 0x0
        public static System.String ResponsiveResize;        // 0x0
        public static System.String RetinaScaler;        // 0x0
        public static System.String NumberButton;        // 0x0
        public static System.String NumberSpinner;        // 0x0
        public static System.String SRSpinner;        // 0x0
        public static System.String ContentFitText;        // 0x0

    }

}

namespace SRF.Service
{

    // TypeToken: 0x200003F
    public class ServiceAttribute : PreserveAttribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Type serviceType) { }
        private System.Type get_ServiceType() { }
        private System.Void set_ServiceType(System.Type value) { }

    }

    // TypeToken: 0x2000040
    public class ServiceSelectorAttribute : PreserveAttribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Type serviceType) { }
        private System.Type get_ServiceType() { }
        private System.Void set_ServiceType(System.Type value) { }

    }

    // TypeToken: 0x2000041
    public class ServiceConstructorAttribute : PreserveAttribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Type serviceType) { }
        private System.Type get_ServiceType() { }
        private System.Void set_ServiceType(System.Type value) { }

    }

    // TypeToken: 0x2000042
    public interface IAsyncService
    {
        // Methods
        private System.Boolean get_IsLoaded() { }

    }

    // TypeToken: 0x2000043
    public class SRDependencyServiceBase`1 : SRServiceBase`1, IAsyncService
    {
        // Fields
        private System.Boolean _isLoaded;        // 0x0

        // Methods
        private System.Type[] get_Dependencies() { }
        private System.Boolean get_IsLoaded() { }
        private System.Void Log(System.String msg, UnityEngine.Object target) { }
        private System.Void Start() { }
        private System.Void OnLoaded() { }
        private System.Collections.IEnumerator LoadDependencies() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class SRSceneServiceBase`2 : SRServiceBase`1, IAsyncService
    {
        // Fields
        private TImpl _rootObject;        // 0x0

        // Methods
        private System.String get_SceneName() { }
        private TImpl get_RootObject() { }
        private System.Boolean get_IsLoaded() { }
        private System.Void Log(System.String msg, UnityEngine.Object target) { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void OnLoaded() { }
        private System.Collections.IEnumerator LoadCoroutine() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class SRServiceBase`1 : SRMonoBehaviourEx
    {
        // Methods
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000048
    public class SRServiceManager : SRAutoSingleton`1
    {
        // Fields
        public static System.Boolean EnableLogging;        // 0x0
        public static System.Int32 LoadingCount;        // 0x0
        private static readonly System.Collections.Generic.List<System.Reflection.Assembly> _assemblies;        // 0x8
        private readonly SRF.SRList<SRF.Service.SRServiceManager.Service> _services;        // 0x48
        private System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> _serviceStubs;        // 0x50
        private static System.Boolean _hasQuit;        // 0x10

        // Methods
        private System.Void RegisterAssembly() { }
        private System.Boolean get_IsLoading() { }
        private T GetService() { }
        private System.Object GetService(System.Type t) { }
        private System.Object GetServiceInternal(System.Type t) { }
        private System.Boolean HasService() { }
        private System.Boolean HasService(System.Type t) { }
        private System.Void RegisterService(System.Object service) { }
        private System.Void RegisterService(System.Type t, System.Object service) { }
        private System.Void UnRegisterService() { }
        private System.Void UnRegisterService(System.Type t) { }
        private System.Void Awake() { }
        private System.Void UpdateStubs() { }
        private System.Object AutoCreateService(System.Type t) { }
        private System.Void OnApplicationQuit() { }
        private System.Object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType) { }
        private System.Void ScanType(System.Type type) { }
        private System.Void ScanTypeForSelectors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs) { }
        private System.Void ScanTypeForConstructors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs) { }
        private System.Reflection.MethodInfo[] GetStaticMethods(System.Type t) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace SRF.UI
{

    // TypeToken: 0x200001C
    public class ContentFitText : UIBehaviour, ILayoutElement
    {
        // Fields
        public SRF.UI.SRText CopySource;        // 0x18
        public UnityEngine.Vector2 Padding;        // 0x20

        // Methods
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void OnEnable() { }
        private System.Void CopySourceOnLayoutDirty(SRF.UI.SRText srText) { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnDisable() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void OnBeforeTransformParentChanged() { }
        private System.Void SetDirty() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class CopyLayoutElement : UIBehaviour, ILayoutElement
    {
        // Fields
        public System.Boolean CopyMinHeight;        // 0x18
        public System.Boolean CopyMinWidth;        // 0x19
        public System.Boolean CopyPreferredHeight;        // 0x1A
        public System.Boolean CopyPreferredWidth;        // 0x1B
        public UnityEngine.RectTransform CopySource;        // 0x20
        public System.Single PaddingMinHeight;        // 0x28
        public System.Single PaddingMinWidth;        // 0x2C
        public System.Single PaddingPreferredHeight;        // 0x30
        public System.Single PaddingPreferredWidth;        // 0x34

        // Methods
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_minWidth() { }
        private System.Single get_minHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Single get_flexibleHeight() { }
        private System.Single get_flexibleWidth() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class CopyPreferredSize : LayoutElement
    {
        // Fields
        public UnityEngine.RectTransform CopySource;        // 0x38
        public System.Single PaddingHeight;        // 0x40
        public System.Single PaddingWidth;        // 0x44

        // Methods
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class CopyPreferredSizes : LayoutElement
    {
        // Fields
        public SRF.UI.CopyPreferredSizes.CopySource[] CopySources;        // 0x38
        public SRF.UI.CopyPreferredSizes.Operations Operation;        // 0x40

        // Methods
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class CopySizeIntoLayoutElement : LayoutElement
    {
        // Fields
        public UnityEngine.RectTransform CopySource;        // 0x38
        public System.Single PaddingHeight;        // 0x40
        public System.Single PaddingWidth;        // 0x44
        public System.Boolean SetPreferredSize;        // 0x48
        public System.Boolean SetMinimumSize;        // 0x49

        // Methods
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_minWidth() { }
        private System.Single get_minHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private UnityEngine.UI.CanvasScaler _canvasScaler;        // 0x18
        private System.Single _delta;        // 0x20
        private System.Single _startValue;        // 0x24
        public UnityEngine.RectTransform.Axis Axis;        // 0x28
        public System.Boolean Invert;        // 0x2C
        public System.Single MaxSize;        // 0x30
        public UnityEngine.UI.LayoutElement TargetLayoutElement;        // 0x38
        public UnityEngine.RectTransform TargetRectTransform;        // 0x40

        // Methods
        private System.Single get_Mult() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Start() { }
        private System.Boolean Verify() { }
        private System.Single GetCurrentValue() { }
        private System.Void SetCurrentValue(System.Single value) { }
        private System.Void CommitCurrentValue() { }
        private System.Single GetMinSize() { }
        private System.Single GetMaxSize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        public System.Single DecayTime;        // 0x18
        public UnityEngine.Color DefaultColor;        // 0x1C
        public UnityEngine.Color FlashColor;        // 0x2C
        public UnityEngine.UI.Graphic Target;        // 0x40
        private System.Boolean _isHoldingUntilNextPress;        // 0x48

        // Methods
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEnable() { }
        private System.Void Flash() { }
        private System.Void FlashAndHoldUntilNextPress() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class InheritColour : SRMonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Graphic _graphic;        // 0x48
        public UnityEngine.UI.Graphic From;        // 0x50

        // Methods
        private UnityEngine.UI.Graphic get_Graphic() { }
        private System.Void Refresh() { }
        private System.Void Update() { }
        private System.Void Start() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class LongPressButton : Button
    {
        // Fields
        private System.Boolean _handled;        // 0x188
        private UnityEngine.UI.Button.ButtonClickedEvent _onLongPress;        // 0x190
        private System.Boolean _pressed;        // 0x198
        private System.Single _pressedTime;        // 0x19C
        public System.Single LongPressDuration;        // 0x1A0

        // Methods
        private UnityEngine.UI.Button.ButtonClickedEvent get_onLongPress() { }
        private System.Void set_onLongPress(UnityEngine.UI.Button.ButtonClickedEvent value) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public class ResponsiveBase : SRMonoBehaviour
    {
        // Fields
        private System.Boolean _queueRefresh;        // 0x48

        // Methods
        private UnityEngine.RectTransform get_RectTransform() { }
        private System.Void OnEnable() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void Update() { }
        private System.Void Refresh() { }
        private System.Void DoRefresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class ResponsiveEnable : ResponsiveBase
    {
        // Fields
        public SRF.UI.ResponsiveEnable.Entry[] Entries;        // 0x50

        // Methods
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class ResponsiveResize : ResponsiveBase
    {
        // Fields
        public SRF.UI.ResponsiveResize.Element[] Elements;        // 0x50

        // Methods
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class ScrollToBottomBehaviour : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.ScrollRect _scrollRect;        // 0x18
        private UnityEngine.CanvasGroup _canvasGroup;        // 0x20
        private System.Boolean _scrollToTop;        // 0x28

        // Methods
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void Trigger() { }
        private System.Void OnScrollRectValueChanged(UnityEngine.Vector2 position) { }
        private System.Void Refresh() { }
        private System.Void SetVisible(System.Boolean truth) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002F
    public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
    {
        // Fields
        private static System.Single ExtraThreshold;        // 0x0
        public static System.Single Delay;        // 0x0
        private System.Single _delayTime;        // 0x188
        private System.Single _downTime;        // 0x18C
        private System.Boolean _isDown;        // 0x190
        public System.Double Amount;        // 0x198
        public SRF.UI.SRNumberSpinner TargetField;        // 0x1A0

        // Methods
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Update() { }
        private System.Void Apply() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class SRNumberSpinner : InputField
    {
        // Fields
        private System.Double _currentValue;        // 0x2A0
        private System.Double _dragStartAmount;        // 0x2A8
        private System.Double _dragStep;        // 0x2B0
        public System.Single DragSensitivity;        // 0x2B8
        public System.Double MaxValue;        // 0x2C0
        public System.Double MinValue;        // 0x2C8

        // Methods
        private System.Void Awake() { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class SRRetinaScaler : SRMonoBehaviour
    {
        // Fields
        private System.Boolean _disablePixelPerfect;        // 0x48
        private System.Int32 _designDpi;        // 0x4C
        private System.Single _lastDpi;        // 0x50

        // Methods
        private System.Void Start() { }
        private System.Void ApplyScaling() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
    {
        // Fields
        private System.Single _dragDelta;        // 0x180
        private SRF.UI.SRSpinner.SpinEvent _onSpinDecrement;        // 0x188
        private SRF.UI.SRSpinner.SpinEvent _onSpinIncrement;        // 0x190
        public System.Single DragThreshold;        // 0x198

        // Methods
        private SRF.UI.SRSpinner.SpinEvent get_OnSpinIncrement() { }
        private System.Void set_OnSpinIncrement(SRF.UI.SRSpinner.SpinEvent value) { }
        private SRF.UI.SRSpinner.SpinEvent get_OnSpinDecrement() { }
        private System.Void set_OnSpinDecrement(SRF.UI.SRSpinner.SpinEvent value) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnIncrement(System.Int32 amount) { }
        private System.Void OnDecrement(System.Int32 amount) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class SRText : Text
    {
        // Fields
        private System.Action<SRF.UI.SRText> LayoutDirty;        // 0x118

        // Methods
        private System.Void add_LayoutDirty(System.Action<SRF.UI.SRText> value) { }
        private System.Void remove_LayoutDirty(System.Action<SRF.UI.SRText> value) { }
        private System.Void SetLayoutDirty() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000035
    public class StyleComponent : SRMonoBehaviour
    {
        // Fields
        private SRF.UI.Style _activeStyle;        // 0x48
        private SRF.UI.StyleRoot _cachedRoot;        // 0x50
        private UnityEngine.UI.Graphic _graphic;        // 0x58
        private System.Boolean _hasStarted;        // 0x60
        private UnityEngine.UI.Image _image;        // 0x68
        private UnityEngine.UI.Selectable _selectable;        // 0x70
        private System.String _styleKey;        // 0x78
        public System.Boolean IgnoreImage;        // 0x80

        // Methods
        private System.String get_StyleKey() { }
        private System.Void set_StyleKey(System.String value) { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void Refresh(System.Boolean invalidateCache) { }
        private SRF.UI.StyleRoot GetStyleRoot() { }
        private System.Void ApplyStyle() { }
        private System.Void SRStyleDirty() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000036
    public class StyleRoot : SRMonoBehaviour
    {
        // Fields
        private SRF.UI.StyleSheet _activeStyleSheet;        // 0x48
        public SRF.UI.StyleSheet StyleSheet;        // 0x50

        // Methods
        private SRF.UI.Style GetStyle(System.String key) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void OnStyleSheetChanged() { }
        private System.Void SetDirty() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public class Style
    {
        // Fields
        public UnityEngine.Color ActiveColor;        // 0x10
        public UnityEngine.Color DisabledColor;        // 0x20
        public UnityEngine.Color HoverColor;        // 0x30
        public UnityEngine.Sprite Image;        // 0x40
        public UnityEngine.Color NormalColor;        // 0x48

        // Methods
        private SRF.UI.Style Copy() { }
        private System.Void CopyFrom(SRF.UI.Style style) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public class StyleSheet : ScriptableObject
    {
        // Fields
        private System.Collections.Generic.List<System.String> _keys;        // 0x18
        private System.Collections.Generic.List<SRF.UI.Style> _styles;        // 0x20
        public SRF.UI.StyleSheet Parent;        // 0x28

        // Methods
        private SRF.UI.Style GetStyle(System.String key, System.Boolean searchParent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
    {
        // Fields
        private System.Boolean _suspectedSelected;        // 0x48

        // Methods
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

}

namespace SRF.UI.Layout
{

    // TypeToken: 0x200003A
    public class FlowLayoutGroup : LayoutGroup
    {
        // Fields
        private readonly System.Collections.Generic.IList<UnityEngine.RectTransform> _rowList;        // 0x58
        private System.Single _layoutHeight;        // 0x60
        public System.Boolean ChildForceExpandHeight;        // 0x64
        public System.Boolean ChildForceExpandWidth;        // 0x65
        public System.Single Spacing;        // 0x68

        // Methods
        private System.Boolean get_IsCenterAlign() { }
        private System.Boolean get_IsRightAlign() { }
        private System.Boolean get_IsMiddleAlign() { }
        private System.Boolean get_IsLowerAlign() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single SetLayout(System.Single width, System.Int32 axis, System.Boolean layoutInput) { }
        private System.Single CalculateRowVerticalOffset(System.Single groupHeight, System.Single yOffset, System.Single currentRowHeight) { }
        private System.Void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, System.Single rowWidth, System.Single rowHeight, System.Single maxWidth, System.Single xOffset, System.Single yOffset, System.Int32 axis) { }
        private System.Single GetGreatestMinimumChildWidth() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public interface IVirtualView
    {
        // Methods
        private System.Void SetDataContext(System.Object data) { }

    }

    // TypeToken: 0x200003C
    public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        private readonly SRF.SRList<System.Object> _itemList;        // 0x58
        private readonly SRF.SRList<System.Int32> _visibleItemList;        // 0x60
        private System.Boolean _isDirty;        // 0x68
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _rowCache;        // 0x70
        private UnityEngine.UI.ScrollRect _scrollRect;        // 0x78
        private System.Int32 _selectedIndex;        // 0x80
        private System.Object _selectedItem;        // 0x88
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent _selectedItemChanged;        // 0x90
        private System.Int32 _visibleItemCount;        // 0x98
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _visibleRows;        // 0xA0
        public SRF.UI.StyleSheet AltRowStyleSheet;        // 0xA8
        public System.Boolean EnableSelection;        // 0xB0
        public UnityEngine.RectTransform ItemPrefab;        // 0xB8
        public System.Int32 RowPadding;        // 0xC0
        public SRF.UI.StyleSheet RowStyleSheet;        // 0xC8
        public SRF.UI.StyleSheet SelectedRowStyleSheet;        // 0xD0
        public System.Single Spacing;        // 0xD8
        public System.Boolean StickToBottom;        // 0xDC
        private System.Single _itemHeight;        // 0xE0

        // Methods
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent get_SelectedItemChanged() { }
        private System.Void set_SelectedItemChanged(SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent value) { }
        private System.Object get_SelectedItem() { }
        private System.Void set_SelectedItem(System.Object value) { }
        private System.Single get_minHeight() { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Awake() { }
        private System.Void OnScrollRectValueChanged(UnityEngine.Vector2 d) { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void InvalidateItem(System.Int32 itemIndex) { }
        private System.Void RefreshIndexCache() { }
        private System.Void ScrollUpdate() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void SetDirty() { }
        private System.Void AddItem(System.Object item) { }
        private System.Void RemoveItem(System.Object item) { }
        private System.Void ClearItems() { }
        private UnityEngine.UI.ScrollRect get_ScrollRect() { }
        private System.Boolean get_AlignBottom() { }
        private System.Boolean get_AlignTop() { }
        private System.Single get_ItemHeight() { }
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row GetRow(System.Int32 forIndex) { }
        private System.Void RecycleRow(SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row) { }
        private System.Void PopulateRow(System.Int32 index, SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row) { }
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row CreateRow() { }
        private System.Void .ctor() { }

    }

}

