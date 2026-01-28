// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRF.dll
// Classes:  90
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SRDebugUtil
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  public    static  System.Int32                    LineBufferCount  // 0x0
  private   static  System.Boolean                  <IsFixedUpdate>k__BackingField  // 0x0
METHODS:
  System.Boolean get_IsFixedUpdate()
  System.Void set_IsFixedUpdate(System.Boolean value)
  System.Void AssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance)
  System.Void Assert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance)
  System.Void EditorAssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance)
  System.Void EditorAssert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance)
END_CLASS

CLASS: SRFileUtil
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  System.Void DeleteDirectory(System.String path)
  System.String GetBytesReadable(System.Int64 i)
END_CLASS

CLASS: SRInstantiate
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  T Instantiate(T prefab)
  UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab)
  T Instantiate(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
END_CLASS

CLASS: EaseType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRMath.EaseType                 Linear  // 0x0
  public    static  SRMath.EaseType                 QuadEaseOut  // 0x0
  public    static  SRMath.EaseType                 QuadEaseIn  // 0x0
  public    static  SRMath.EaseType                 QuadEaseInOut  // 0x0
  public    static  SRMath.EaseType                 QuadEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 ExpoEaseOut  // 0x0
  public    static  SRMath.EaseType                 ExpoEaseIn  // 0x0
  public    static  SRMath.EaseType                 ExpoEaseInOut  // 0x0
  public    static  SRMath.EaseType                 ExpoEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 CubicEaseOut  // 0x0
  public    static  SRMath.EaseType                 CubicEaseIn  // 0x0
  public    static  SRMath.EaseType                 CubicEaseInOut  // 0x0
  public    static  SRMath.EaseType                 CubicEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 QuartEaseOut  // 0x0
  public    static  SRMath.EaseType                 QuartEaseIn  // 0x0
  public    static  SRMath.EaseType                 QuartEaseInOut  // 0x0
  public    static  SRMath.EaseType                 QuartEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 QuintEaseOut  // 0x0
  public    static  SRMath.EaseType                 QuintEaseIn  // 0x0
  public    static  SRMath.EaseType                 QuintEaseInOut  // 0x0
  public    static  SRMath.EaseType                 QuintEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 CircEaseOut  // 0x0
  public    static  SRMath.EaseType                 CircEaseIn  // 0x0
  public    static  SRMath.EaseType                 CircEaseInOut  // 0x0
  public    static  SRMath.EaseType                 CircEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 SineEaseOut  // 0x0
  public    static  SRMath.EaseType                 SineEaseIn  // 0x0
  public    static  SRMath.EaseType                 SineEaseInOut  // 0x0
  public    static  SRMath.EaseType                 SineEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 ElasticEaseOut  // 0x0
  public    static  SRMath.EaseType                 ElasticEaseIn  // 0x0
  public    static  SRMath.EaseType                 ElasticEaseInOut  // 0x0
  public    static  SRMath.EaseType                 ElasticEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 BounceEaseOut  // 0x0
  public    static  SRMath.EaseType                 BounceEaseIn  // 0x0
  public    static  SRMath.EaseType                 BounceEaseInOut  // 0x0
  public    static  SRMath.EaseType                 BounceEaseOutIn  // 0x0
  public    static  SRMath.EaseType                 BackEaseOut  // 0x0
  public    static  SRMath.EaseType                 BackEaseIn  // 0x0
  public    static  SRMath.EaseType                 BackEaseInOut  // 0x0
  public    static  SRMath.EaseType                 BackEaseOutIn  // 0x0
METHODS:
END_CLASS

CLASS: TweenFunctions
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Single Linear(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ExpoEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ExpoEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ExpoEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ExpoEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CircEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CircEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CircEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CircEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuadEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuadEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuadEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuadEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single SineEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single SineEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single SineEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single SineEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CubicEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CubicEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CubicEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single CubicEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuartEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuartEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuartEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuartEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuintEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuintEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuintEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single QuintEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ElasticEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ElasticEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ElasticEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single ElasticEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BounceEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BounceEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BounceEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BounceEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BackEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BackEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BackEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  System.Single BackEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
END_CLASS

CLASS: SRMath
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Single LerpUnclamped(System.Single from, System.Single to, System.Single t)
  UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t)
  System.Single FacingNormalized(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2)
  System.Single WrapAngle(System.Single angle)
  System.Single NearestAngle(System.Single to, System.Single angle1, System.Single angle2)
  System.Int32 Wrap(System.Int32 max, System.Int32 value)
  System.Single Wrap(System.Single max, System.Single value)
  System.Single Average(System.Single v1, System.Single v2)
  System.Single Angle(UnityEngine.Vector2 direction)
  System.Single Ease(System.Single from, System.Single to, System.Single t, SRMath.EaseType type)
  System.Single SpringLerp(System.Single strength, System.Single deltaTime)
  System.Single SpringLerp(System.Single from, System.Single to, System.Single strength, System.Single deltaTime)
  UnityEngine.Vector3 SpringLerp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single strength, System.Single deltaTime)
  UnityEngine.Quaternion SpringLerp(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single strength, System.Single deltaTime)
  System.Single SmoothClamp(System.Single value, System.Single min, System.Single max, System.Single scrollMax, SRMath.EaseType easeType)
END_CLASS

CLASS: TOKEN
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRF.Json.Parser.TOKEN           NONE  // 0x0
  public    static  SRF.Json.Parser.TOKEN           CURLY_OPEN  // 0x0
  public    static  SRF.Json.Parser.TOKEN           CURLY_CLOSE  // 0x0
  public    static  SRF.Json.Parser.TOKEN           SQUARED_OPEN  // 0x0
  public    static  SRF.Json.Parser.TOKEN           SQUARED_CLOSE  // 0x0
  public    static  SRF.Json.Parser.TOKEN           COLON  // 0x0
  public    static  SRF.Json.Parser.TOKEN           COMMA  // 0x0
  public    static  SRF.Json.Parser.TOKEN           STRING  // 0x0
  public    static  SRF.Json.Parser.TOKEN           NUMBER  // 0x0
  public    static  SRF.Json.Parser.TOKEN           TRUE  // 0x0
  public    static  SRF.Json.Parser.TOKEN           FALSE  // 0x0
  public    static  SRF.Json.Parser.TOKEN           NULL  // 0x0
METHODS:
END_CLASS

CLASS: Parser
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   static  System.String                   WORD_BREAK  // 0x0
  private           System.IO.StringReader          json  // 0x10
METHODS:
  System.Void .ctor(System.String jsonString)
  System.Char get_PeekChar()
  System.Char get_NextChar()
  System.String get_NextWord()
  SRF.Json.Parser.TOKEN get_NextToken()
  System.Void Dispose()
  System.Boolean IsWordBreak(System.Char c)
  System.Object Parse(System.String jsonString)
  System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject()
  System.Collections.Generic.List<System.Object> ParseArray()
  System.Object ParseValue()
  System.Object ParseByToken(SRF.Json.Parser.TOKEN token)
  System.String ParseString()
  System.Object ParseNumber()
  System.Void EatWhitespace()
END_CLASS

CLASS: Serializer
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.Text.StringBuilder       builder  // 0x10
METHODS:
  System.Void .ctor()
  System.String Serialize(System.Object obj)
  System.Void SerializeValue(System.Object value)
  System.Void SerializeObject(System.Collections.IDictionary obj)
  System.Void SerializeArray(System.Collections.IList anArray)
  System.Void SerializeString(System.String str)
  System.Void SerializeOther(System.Object value)
END_CLASS

CLASS: FieldInfo
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Boolean                  AutoCreate  // 0x10
  public            System.Boolean                  AutoSet  // 0x11
  public            System.Reflection.FieldInfo     Field  // 0x18
  public            System.Boolean                  Import  // 0x20
  public            System.Type                     ImportType  // 0x28
METHODS:
END_CLASS

CLASS: Operations
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRF.UI.CopyPreferredSizes.OperationsMax  // 0x0
  public    static  SRF.UI.CopyPreferredSizes.OperationsMin  // 0x0
METHODS:
END_CLASS

CLASS: CopySource
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public            UnityEngine.RectTransform       Rect  // 0x10
  public            System.Single                   PaddingHeight  // 0x18
  public            System.Single                   PaddingWidth  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Modes
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRF.UI.ResponsiveEnable.Modes   EnableAbove  // 0x0
  public    static  SRF.UI.ResponsiveEnable.Modes   EnableBelow  // 0x0
METHODS:
END_CLASS

CLASS: Entry
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            UnityEngine.Behaviour[]         Components  // 0x10
  public            UnityEngine.GameObject[]        GameObjects  // 0x18
  public            SRF.UI.ResponsiveEnable.Modes   Mode  // 0x20
  public            System.Single                   ThresholdHeight  // 0x24
  public            System.Single                   ThresholdWidth  // 0x28
METHODS:
END_CLASS

CLASS: SizeDefinition
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Single                   ElementWidth  // 0x10
  public            System.Single                   ThresholdWidth  // 0x14
METHODS:
END_CLASS

CLASS: Element
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            SRF.UI.ResponsiveResize.Element.SizeDefinition[]SizeDefinitions  // 0x10
  public            UnityEngine.RectTransform       Target  // 0x18
METHODS:
END_CLASS

CLASS: SpinEvent
TYPE:  class
TOKEN: 0x2000033
EXTENDS: UnityEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SelectedItemChangedEvent
TYPE:  class
TOKEN: 0x200003D
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  public            System.Object                   Data  // 0x10
  public            System.Int32                    Index  // 0x18
  public            UnityEngine.RectTransform       Rect  // 0x20
  public            SRF.UI.StyleRoot                Root  // 0x28
  public            SRF.UI.Layout.IVirtualView      View  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Service
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  public            System.Object                   Object  // 0x10
  public            System.Type                     Type  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ServiceStub
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            System.Func<System.Object>      Constructor  // 0x10
  public            System.Type                     InterfaceType  // 0x18
  public            System.Func<System.Type>        Selector  // 0x20
  public            System.Type                     Type  // 0x28
METHODS:
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Json
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Object Deserialize(System.String json)
  System.String Serialize(System.Object obj)
END_CLASS

CLASS: SRF.SRList`1
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private           T[]                             _buffer  // 0x0
  private           System.Int32                    _count  // 0x0
  private           System.Collections.Generic.EqualityComparer<T>_equalityComparer  // 0x0
  private           System.Collections.ObjectModel.ReadOnlyCollection<T>_readOnlyWrapper  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> source)
  T[] get_Buffer()
  System.Void set_Buffer(T[] value)
  System.Collections.Generic.EqualityComparer<T> get_EqualityComparer()
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Add(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Boolean Remove(T item)
  System.Boolean get_IsReadOnly()
  System.Int32 IndexOf(T item)
  System.Void Insert(System.Int32 index, T item)
  System.Void RemoveAt(System.Int32 index)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void AddRange(System.Collections.Generic.IEnumerable<T> range)
  System.Void Clear(System.Boolean clean)
  System.Void Clean()
  System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
  System.Void Expand()
  System.Void Trim()
  System.Void Sort(System.Comparison<T> comparer)
END_CLASS

CLASS: SRF.SRMonoBehaviour
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Collider            _collider  // 0x18
  private           UnityEngine.Transform           _transform  // 0x20
  private           UnityEngine.Rigidbody           _rigidBody  // 0x28
  private           UnityEngine.GameObject          _gameObject  // 0x30
  private           UnityEngine.Rigidbody2D         _rigidbody2D  // 0x38
  private           UnityEngine.Collider2D          _collider2D  // 0x40
METHODS:
  UnityEngine.Transform get_CachedTransform()
  UnityEngine.Collider get_CachedCollider()
  UnityEngine.Collider2D get_CachedCollider2D()
  UnityEngine.Rigidbody get_CachedRigidBody()
  UnityEngine.Rigidbody2D get_CachedRigidBody2D()
  UnityEngine.GameObject get_CachedGameObject()
  UnityEngine.Transform get_transform()
  System.Void AssertNotNull(System.Object value, System.String fieldName)
  System.Void Assert(System.Boolean condition, System.String message)
  System.Void EditorAssertNotNull(System.Object value, System.String fieldName)
  System.Void EditorAssert(System.Boolean condition, System.String message)
  System.Void .ctor()
END_CLASS

CLASS: SRF.RequiredFieldAttribute
TYPE:  class
TOKEN: 0x200000F
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  _autoCreate  // 0x10
  private           System.Boolean                  _autoSearch  // 0x11
  private           System.Boolean                  _editorOnly  // 0x12
METHODS:
  System.Void .ctor(System.Boolean autoSearch)
  System.Void .ctor()
  System.Boolean get_AutoSearch()
  System.Void set_AutoSearch(System.Boolean value)
  System.Boolean get_AutoCreate()
  System.Void set_AutoCreate(System.Boolean value)
  System.Boolean get_EditorOnly()
  System.Void set_EditorOnly(System.Boolean value)
END_CLASS

CLASS: SRF.ImportAttribute
TYPE:  class
TOKEN: 0x2000010
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     Service  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Type serviceType)
END_CLASS

CLASS: SRF.SRMonoBehaviourEx
TYPE:  class
TOKEN: 0x2000011
EXTENDS: SRMonoBehaviour
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo>>_checkedFields  // 0x0
METHODS:
  System.Void CheckFields(SRF.SRMonoBehaviourEx instance, System.Boolean justSet)
  System.Void PopulateObject(System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo> cache, SRF.SRMonoBehaviourEx instance, System.Boolean justSet)
  System.Collections.Generic.List<SRF.SRMonoBehaviourEx.FieldInfo> ScanType(System.Type t)
  System.Void Awake()
  System.Void Start()
  System.Void Update()
  System.Void FixedUpdate()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Coroutines
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Collections.IEnumerator WaitForSecondsRealTime(System.Single time)
END_CLASS

CLASS: SRF.SRFFloatExtensions
TYPE:  class
TOKEN: 0x2000015
FIELDS:
METHODS:
  System.Single Sqr(System.Single f)
  System.Single SqrRt(System.Single f)
  System.Boolean ApproxZero(System.Single f)
  System.Boolean Approx(System.Single f, System.Single f2)
END_CLASS

CLASS: SRF.SRFGameObjectExtensions
TYPE:  class
TOKEN: 0x2000016
FIELDS:
METHODS:
  T GetIComponent(UnityEngine.GameObject t)
  T GetComponentOrAdd(UnityEngine.GameObject obj)
  System.Void RemoveComponentIfExists(UnityEngine.GameObject obj)
  System.Void RemoveComponentsIfExists(UnityEngine.GameObject obj)
  System.Boolean EnableComponentIfExists(UnityEngine.GameObject obj, System.Boolean enable)
  System.Void SetLayerRecursive(UnityEngine.GameObject o, System.Int32 layer)
  System.Void SetLayerInternal(UnityEngine.Transform t, System.Int32 layer)
END_CLASS

CLASS: SRF.SRFIListExtensions
TYPE:  class
TOKEN: 0x2000017
FIELDS:
METHODS:
  T Random(System.Collections.Generic.IList<T> list)
  T RandomOrDefault(System.Collections.Generic.IList<T> list)
  T PopLast(System.Collections.Generic.IList<T> list)
END_CLASS

CLASS: SRF.SRFStringExtensions
TYPE:  class
TOKEN: 0x2000018
FIELDS:
METHODS:
  System.String Fmt(System.String formatString, System.Object[] args)
END_CLASS

CLASS: SRF.SRFTransformExtensions
TYPE:  class
TOKEN: 0x2000019
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.Transform> GetChildren(UnityEngine.Transform t)
  System.Void ResetLocal(UnityEngine.Transform t)
  UnityEngine.GameObject CreateChild(UnityEngine.Transform t, System.String name)
  System.Void SetParentMaintainLocals(UnityEngine.Transform t, UnityEngine.Transform parent)
  System.Void SetLocals(UnityEngine.Transform t, UnityEngine.Transform from)
  System.Void Match(UnityEngine.Transform t, UnityEngine.Transform from)
  System.Void DestroyChildren(UnityEngine.Transform t)
END_CLASS

CLASS: SRF.Hierarchy
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  private   static readonly System.Char[]                   Seperator  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>Cache  // 0x8
METHODS:
  UnityEngine.Transform get_Item(System.String key)
  UnityEngine.Transform Get(System.String key)
  System.Void RuntimeInitialize()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SRF.Components.SRAutoSingleton`1
TYPE:  class
TOKEN: 0x2000058
EXTENDS: SRMonoBehaviour
FIELDS:
  private   static  T                               _instance  // 0x0
METHODS:
  T get_Instance()
  System.Boolean get_HasInstance()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnApplicationQuit()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Components.SRSingleton`1
TYPE:  class
TOKEN: 0x2000059
EXTENDS: SRMonoBehaviour
FIELDS:
  private   static  T                               _instance  // 0x0
METHODS:
  T get_Instance()
  System.Boolean get_HasInstance()
  System.Void Register()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnApplicationQuit()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Helpers.AssetUtil
TYPE:  class
TOKEN: 0x200004E
FIELDS:
METHODS:
END_CLASS

CLASS: SRF.Helpers.MethodReference
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private   readonly System.Func<System.Object[],System.Object>_method  // 0x10
METHODS:
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo method)
  System.Void .ctor(System.Func<System.Object[],System.Object> method)
  System.Object Invoke(System.Object[] parameters)
  SRF.Helpers.MethodReference op_Implicit(System.Action action)
END_CLASS

CLASS: SRF.Helpers.PropertyValueChangedHandler
TYPE:  class
TOKEN: 0x2000052
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(SRF.Helpers.PropertyReference property)
  System.IAsyncResult BeginInvoke(SRF.Helpers.PropertyReference property, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRF.Helpers.PropertyReference
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  private   readonly System.Reflection.PropertyInfo  _property  // 0x10
  private   readonly System.Object                   _target  // 0x18
  private   readonly System.Attribute[]              _attributes  // 0x20
  private   readonly System.Func<System.Object>      _getter  // 0x28
  private   readonly System.Action<System.Object>    _setter  // 0x30
  private           System.Collections.Generic.List<SRF.Helpers.PropertyValueChangedHandler>_valueChangedListeners  // 0x38
  private           System.Type                     <PropertyType>k__BackingField  // 0x40
METHODS:
  System.Void add_ValueChanged(SRF.Helpers.PropertyValueChangedHandler value)
  System.Void remove_ValueChanged(SRF.Helpers.PropertyValueChangedHandler value)
  SRF.Helpers.PropertyReference FromLambda(System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes)
  System.Void .ctor(System.Object target, System.Reflection.PropertyInfo property)
  System.Void .ctor(System.Type type, System.Func<System.Object> getter, System.Action<System.Object> setter, System.Attribute[] attributes)
  System.Type get_PropertyType()
  System.Void set_PropertyType(System.Type value)
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Void NotifyValueChanged()
  System.Object GetValue()
  System.Void SetValue(System.Object value)
  T GetAttribute()
  System.Void OnTargetPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
  System.String ToString()
END_CLASS

CLASS: SRF.Helpers.SRReflection
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Void SetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p, System.Object value)
  System.Object GetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p)
  T GetAttribute(System.Reflection.MemberInfo t)
END_CLASS

CLASS: SRF.Internal.ComponentMenuPaths
TYPE:  class
TOKEN: 0x200005A
FIELDS:
  public    static  System.String                   PathRoot  // 0x0
  public    static  System.String                   SRServiceManager  // 0x0
  public    static  System.String                   BehavioursRoot  // 0x0
  public    static  System.String                   DestroyOnDisable  // 0x0
  public    static  System.String                   DontDestroyOnLoad  // 0x0
  public    static  System.String                   MatchTransform  // 0x0
  public    static  System.String                   LookAt  // 0x0
  public    static  System.String                   MatchForwardDirection  // 0x0
  public    static  System.String                   MatchMainCameraForwardDirection  // 0x0
  public    static  System.String                   RuntimePosition  // 0x0
  public    static  System.String                   ScrollTexture  // 0x0
  public    static  System.String                   SmoothFloatBehaviour  // 0x0
  public    static  System.String                   SmoothFollow2D  // 0x0
  public    static  System.String                   SpringFollow  // 0x0
  public    static  System.String                   SmoothMatchTransform  // 0x0
  public    static  System.String                   SpawnPrefab  // 0x0
  public    static  System.String                   Velocity  // 0x0
  public    static  System.String                   SmoothOscillate  // 0x0
  public    static  System.String                   SRDebugCamera  // 0x0
  public    static  System.String                   ComponentsRoot  // 0x0
  public    static  System.String                   SRLineRenderer  // 0x0
  public    static  System.String                   SelectionRoot  // 0x0
  public    static  System.String                   SRSpriteFadeRenderer  // 0x0
  public    static  System.String                   SRMaterialFadeRenderer  // 0x0
  public    static  System.String                   SRCompositeFadeRenderer  // 0x0
  public    static  System.String                   UIRoot  // 0x0
  public    static  System.String                   TiltOnTouch  // 0x0
  public    static  System.String                   ScaleOnTouch  // 0x0
  public    static  System.String                   InheritColour  // 0x0
  public    static  System.String                   FlashGraphic  // 0x0
  public    static  System.String                   CopyPreferredSize  // 0x0
  public    static  System.String                   CopyPreferredSizes  // 0x0
  public    static  System.String                   CopyLayoutElement  // 0x0
  public    static  System.String                   CopySizeIntoLayoutElement  // 0x0
  public    static  System.String                   SRText  // 0x0
  public    static  System.String                   Unselectable  // 0x0
  public    static  System.String                   LongPressButton  // 0x0
  public    static  System.String                   ScrollToBottom  // 0x0
  public    static  System.String                   FlowLayoutGroup  // 0x0
  public    static  System.String                   VirtualVerticalLayoutGroup  // 0x0
  public    static  System.String                   StyleRoot  // 0x0
  public    static  System.String                   StyleComponent  // 0x0
  public    static  System.String                   ResponsiveEnable  // 0x0
  public    static  System.String                   ResponsiveResize  // 0x0
  public    static  System.String                   RetinaScaler  // 0x0
  public    static  System.String                   NumberButton  // 0x0
  public    static  System.String                   NumberSpinner  // 0x0
  public    static  System.String                   SRSpinner  // 0x0
  public    static  System.String                   ContentFitText  // 0x0
METHODS:
END_CLASS

CLASS: SRF.Service.ServiceAttribute
TYPE:  class
TOKEN: 0x200003F
EXTENDS: PreserveAttribute
FIELDS:
  private           System.Type                     <ServiceType>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Type serviceType)
  System.Type get_ServiceType()
  System.Void set_ServiceType(System.Type value)
END_CLASS

CLASS: SRF.Service.ServiceSelectorAttribute
TYPE:  class
TOKEN: 0x2000040
EXTENDS: PreserveAttribute
FIELDS:
  private           System.Type                     <ServiceType>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Type serviceType)
  System.Type get_ServiceType()
  System.Void set_ServiceType(System.Type value)
END_CLASS

CLASS: SRF.Service.ServiceConstructorAttribute
TYPE:  class
TOKEN: 0x2000041
EXTENDS: PreserveAttribute
FIELDS:
  private           System.Type                     <ServiceType>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Type serviceType)
  System.Type get_ServiceType()
  System.Void set_ServiceType(System.Type value)
END_CLASS

CLASS: SRF.Service.IAsyncService
TYPE:  interface
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Boolean get_IsLoaded()
END_CLASS

CLASS: SRF.Service.SRDependencyServiceBase`1
TYPE:  class
TOKEN: 0x2000043
EXTENDS: SRServiceBase`1
FIELDS:
  private           System.Boolean                  _isLoaded  // 0x0
METHODS:
  System.Type[] get_Dependencies()
  System.Boolean get_IsLoaded()
  System.Void Log(System.String msg, UnityEngine.Object target)
  System.Void Start()
  System.Void OnLoaded()
  System.Collections.IEnumerator LoadDependencies()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Service.SRSceneServiceBase`2
TYPE:  class
TOKEN: 0x2000045
EXTENDS: SRServiceBase`1
FIELDS:
  private           TImpl                           _rootObject  // 0x0
METHODS:
  System.String get_SceneName()
  TImpl get_RootObject()
  System.Boolean get_IsLoaded()
  System.Void Log(System.String msg, UnityEngine.Object target)
  System.Void Start()
  System.Void OnDestroy()
  System.Void OnLoaded()
  System.Collections.IEnumerator LoadCoroutine()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Service.SRServiceBase`1
TYPE:  class
TOKEN: 0x2000047
EXTENDS: SRMonoBehaviourEx
FIELDS:
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: SRF.Service.SRServiceManager
TYPE:  class
TOKEN: 0x2000048
EXTENDS: SRAutoSingleton`1
FIELDS:
  public    static  System.Boolean                  EnableLogging  // 0x0
  public    static  System.Int32                    LoadingCount  // 0x0
  private   static readonly System.Collections.Generic.List<System.Reflection.Assembly>_assemblies  // 0x8
  private   readonly SRF.SRList<SRF.Service.SRServiceManager.Service>_services  // 0x48
  private           System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub>_serviceStubs  // 0x50
  private   static  System.Boolean                  _hasQuit  // 0x10
METHODS:
  System.Void RegisterAssembly()
  System.Boolean get_IsLoading()
  T GetService()
  System.Object GetService(System.Type t)
  System.Object GetServiceInternal(System.Type t)
  System.Boolean HasService()
  System.Boolean HasService(System.Type t)
  System.Void RegisterService(System.Object service)
  System.Void RegisterService(System.Type t, System.Object service)
  System.Void UnRegisterService()
  System.Void UnRegisterService(System.Type t)
  System.Void Awake()
  System.Void UpdateStubs()
  System.Object AutoCreateService(System.Type t)
  System.Void OnApplicationQuit()
  System.Object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType)
  System.Void ScanType(System.Type type)
  System.Void ScanTypeForSelectors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
  System.Void ScanTypeForConstructors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
  System.Reflection.MethodInfo[] GetStaticMethods(System.Type t)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SRF.UI.ContentFitText
TYPE:  class
TOKEN: 0x200001C
EXTENDS: UIBehaviour
FIELDS:
  public            SRF.UI.SRText                   CopySource  // 0x18
  public            UnityEngine.Vector2             Padding  // 0x20
METHODS:
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void OnEnable()
  System.Void CopySourceOnLayoutDirty(SRF.UI.SRText srText)
  System.Void OnTransformParentChanged()
  System.Void OnDisable()
  System.Void OnDidApplyAnimationProperties()
  System.Void OnBeforeTransformParentChanged()
  System.Void SetDirty()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopyLayoutElement
TYPE:  class
TOKEN: 0x200001D
EXTENDS: UIBehaviour
FIELDS:
  public            System.Boolean                  CopyMinHeight  // 0x18
  public            System.Boolean                  CopyMinWidth  // 0x19
  public            System.Boolean                  CopyPreferredHeight  // 0x1A
  public            System.Boolean                  CopyPreferredWidth  // 0x1B
  public            UnityEngine.RectTransform       CopySource  // 0x20
  public            System.Single                   PaddingMinHeight  // 0x28
  public            System.Single                   PaddingMinWidth  // 0x2C
  public            System.Single                   PaddingPreferredHeight  // 0x30
  public            System.Single                   PaddingPreferredWidth  // 0x34
METHODS:
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Single get_minWidth()
  System.Single get_minHeight()
  System.Int32 get_layoutPriority()
  System.Single get_flexibleHeight()
  System.Single get_flexibleWidth()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopyPreferredSize
TYPE:  class
TOKEN: 0x200001E
EXTENDS: LayoutElement
FIELDS:
  public            UnityEngine.RectTransform       CopySource  // 0x38
  public            System.Single                   PaddingHeight  // 0x40
  public            System.Single                   PaddingWidth  // 0x44
METHODS:
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Int32 get_layoutPriority()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopyPreferredSizes
TYPE:  class
TOKEN: 0x200001F
EXTENDS: LayoutElement
FIELDS:
  public            SRF.UI.CopyPreferredSizes.CopySource[]CopySources  // 0x38
  public            SRF.UI.CopyPreferredSizes.OperationsOperation  // 0x40
METHODS:
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Int32 get_layoutPriority()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopySizeIntoLayoutElement
TYPE:  class
TOKEN: 0x2000022
EXTENDS: LayoutElement
FIELDS:
  public            UnityEngine.RectTransform       CopySource  // 0x38
  public            System.Single                   PaddingHeight  // 0x40
  public            System.Single                   PaddingWidth  // 0x44
  public            System.Boolean                  SetPreferredSize  // 0x48
  public            System.Boolean                  SetMinimumSize  // 0x49
METHODS:
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Single get_minWidth()
  System.Single get_minHeight()
  System.Int32 get_layoutPriority()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.DragHandle
TYPE:  class
TOKEN: 0x2000023
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.UI.CanvasScaler     _canvasScaler  // 0x18
  private           System.Single                   _delta  // 0x20
  private           System.Single                   _startValue  // 0x24
  public            UnityEngine.RectTransform.Axis  Axis  // 0x28
  public            System.Boolean                  Invert  // 0x2C
  public            System.Single                   MaxSize  // 0x30
  public            UnityEngine.UI.LayoutElement    TargetLayoutElement  // 0x38
  public            UnityEngine.RectTransform       TargetRectTransform  // 0x40
METHODS:
  System.Single get_Mult()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Start()
  System.Boolean Verify()
  System.Single GetCurrentValue()
  System.Void SetCurrentValue(System.Single value)
  System.Void CommitCurrentValue()
  System.Single GetMinSize()
  System.Single GetMaxSize()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.FlashGraphic
TYPE:  class
TOKEN: 0x2000024
EXTENDS: UIBehaviour
FIELDS:
  public            System.Single                   DecayTime  // 0x18
  public            UnityEngine.Color               DefaultColor  // 0x1C
  public            UnityEngine.Color               FlashColor  // 0x2C
  public            UnityEngine.UI.Graphic          Target  // 0x40
  private           System.Boolean                  _isHoldingUntilNextPress  // 0x48
METHODS:
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEnable()
  System.Void Flash()
  System.Void FlashAndHoldUntilNextPress()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.InheritColour
TYPE:  class
TOKEN: 0x2000025
EXTENDS: SRMonoBehaviour
FIELDS:
  private           UnityEngine.UI.Graphic          _graphic  // 0x48
  public            UnityEngine.UI.Graphic          From  // 0x50
METHODS:
  UnityEngine.UI.Graphic get_Graphic()
  System.Void Refresh()
  System.Void Update()
  System.Void Start()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.LongPressButton
TYPE:  class
TOKEN: 0x2000026
EXTENDS: Button
FIELDS:
  private           System.Boolean                  _handled  // 0x188
  private           UnityEngine.UI.Button.ButtonClickedEvent_onLongPress  // 0x190
  private           System.Boolean                  _pressed  // 0x198
  private           System.Single                   _pressedTime  // 0x19C
  public            System.Single                   LongPressDuration  // 0x1A0
METHODS:
  UnityEngine.UI.Button.ButtonClickedEvent get_onLongPress()
  System.Void set_onLongPress(UnityEngine.UI.Button.ButtonClickedEvent value)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ResponsiveBase
TYPE:  class
TOKEN: 0x2000027
EXTENDS: SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _queueRefresh  // 0x48
METHODS:
  UnityEngine.RectTransform get_RectTransform()
  System.Void OnEnable()
  System.Void OnRectTransformDimensionsChange()
  System.Void Update()
  System.Void Refresh()
  System.Void DoRefresh()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ResponsiveEnable
TYPE:  class
TOKEN: 0x2000028
EXTENDS: ResponsiveBase
FIELDS:
  public            SRF.UI.ResponsiveEnable.Entry[] Entries  // 0x50
METHODS:
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ResponsiveResize
TYPE:  class
TOKEN: 0x200002B
EXTENDS: ResponsiveBase
FIELDS:
  public            SRF.UI.ResponsiveResize.Element[]Elements  // 0x50
METHODS:
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ScrollToBottomBehaviour
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.UI.ScrollRect       _scrollRect  // 0x18
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x20
  private           System.Boolean                  _scrollToTop  // 0x28
METHODS:
  System.Void Start()
  System.Void OnEnable()
  System.Void Trigger()
  System.Void OnScrollRectValueChanged(UnityEngine.Vector2 position)
  System.Void Refresh()
  System.Void SetVisible(System.Boolean truth)
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRNumberButton
TYPE:  class
TOKEN: 0x200002F
EXTENDS: Button
FIELDS:
  private   static  System.Single                   ExtraThreshold  // 0x0
  public    static  System.Single                   Delay  // 0x0
  private           System.Single                   _delayTime  // 0x188
  private           System.Single                   _downTime  // 0x18C
  private           System.Boolean                  _isDown  // 0x190
  public            System.Double                   Amount  // 0x198
  public            SRF.UI.SRNumberSpinner          TargetField  // 0x1A0
METHODS:
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Update()
  System.Void Apply()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRNumberSpinner
TYPE:  class
TOKEN: 0x2000030
EXTENDS: InputField
FIELDS:
  private           System.Double                   _currentValue  // 0x2A0
  private           System.Double                   _dragStartAmount  // 0x2A8
  private           System.Double                   _dragStep  // 0x2B0
  public            System.Single                   DragSensitivity  // 0x2B8
  public            System.Double                   MaxValue  // 0x2C0
  public            System.Double                   MinValue  // 0x2C8
METHODS:
  System.Void Awake()
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRRetinaScaler
TYPE:  class
TOKEN: 0x2000031
EXTENDS: SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _disablePixelPerfect  // 0x48
  private           System.Int32                    _designDpi  // 0x4C
  private           System.Single                   _lastDpi  // 0x50
METHODS:
  System.Void Start()
  System.Void ApplyScaling()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRSpinner
TYPE:  class
TOKEN: 0x2000032
EXTENDS: Selectable
FIELDS:
  private           System.Single                   _dragDelta  // 0x180
  private           SRF.UI.SRSpinner.SpinEvent      _onSpinDecrement  // 0x188
  private           SRF.UI.SRSpinner.SpinEvent      _onSpinIncrement  // 0x190
  public            System.Single                   DragThreshold  // 0x198
METHODS:
  SRF.UI.SRSpinner.SpinEvent get_OnSpinIncrement()
  System.Void set_OnSpinIncrement(SRF.UI.SRSpinner.SpinEvent value)
  SRF.UI.SRSpinner.SpinEvent get_OnSpinDecrement()
  System.Void set_OnSpinDecrement(SRF.UI.SRSpinner.SpinEvent value)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnIncrement(System.Int32 amount)
  System.Void OnDecrement(System.Int32 amount)
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRText
TYPE:  class
TOKEN: 0x2000034
EXTENDS: Text
FIELDS:
  private           System.Action<SRF.UI.SRText>    LayoutDirty  // 0x118
METHODS:
  System.Void add_LayoutDirty(System.Action<SRF.UI.SRText> value)
  System.Void remove_LayoutDirty(System.Action<SRF.UI.SRText> value)
  System.Void SetLayoutDirty()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.StyleComponent
TYPE:  class
TOKEN: 0x2000035
EXTENDS: SRMonoBehaviour
FIELDS:
  private           SRF.UI.Style                    _activeStyle  // 0x48
  private           SRF.UI.StyleRoot                _cachedRoot  // 0x50
  private           UnityEngine.UI.Graphic          _graphic  // 0x58
  private           System.Boolean                  _hasStarted  // 0x60
  private           UnityEngine.UI.Image            _image  // 0x68
  private           UnityEngine.UI.Selectable       _selectable  // 0x70
  private           System.String                   _styleKey  // 0x78
  public            System.Boolean                  IgnoreImage  // 0x80
METHODS:
  System.String get_StyleKey()
  System.Void set_StyleKey(System.String value)
  System.Void Start()
  System.Void OnEnable()
  System.Void Refresh(System.Boolean invalidateCache)
  SRF.UI.StyleRoot GetStyleRoot()
  System.Void ApplyStyle()
  System.Void SRStyleDirty()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.StyleRoot
TYPE:  class
TOKEN: 0x2000036
EXTENDS: SRMonoBehaviour
FIELDS:
  private           SRF.UI.StyleSheet               _activeStyleSheet  // 0x48
  public            SRF.UI.StyleSheet               StyleSheet  // 0x50
METHODS:
  SRF.UI.Style GetStyle(System.String key)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void OnStyleSheetChanged()
  System.Void SetDirty()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Style
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  public            UnityEngine.Color               ActiveColor  // 0x10
  public            UnityEngine.Color               DisabledColor  // 0x20
  public            UnityEngine.Color               HoverColor  // 0x30
  public            UnityEngine.Sprite              Image  // 0x40
  public            UnityEngine.Color               NormalColor  // 0x48
METHODS:
  SRF.UI.Style Copy()
  System.Void CopyFrom(SRF.UI.Style style)
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.StyleSheet
TYPE:  class
TOKEN: 0x2000038
EXTENDS: ScriptableObject
FIELDS:
  private           System.Collections.Generic.List<System.String>_keys  // 0x18
  private           System.Collections.Generic.List<SRF.UI.Style>_styles  // 0x20
  public            SRF.UI.StyleSheet               Parent  // 0x28
METHODS:
  SRF.UI.Style GetStyle(System.String key, System.Boolean searchParent)
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Unselectable
TYPE:  class
TOKEN: 0x2000039
EXTENDS: SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _suspectedSelected  // 0x48
METHODS:
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Layout.FlowLayoutGroup
TYPE:  class
TOKEN: 0x200003A
EXTENDS: LayoutGroup
FIELDS:
  private   readonly System.Collections.Generic.IList<UnityEngine.RectTransform>_rowList  // 0x58
  private           System.Single                   _layoutHeight  // 0x60
  public            System.Boolean                  ChildForceExpandHeight  // 0x64
  public            System.Boolean                  ChildForceExpandWidth  // 0x65
  public            System.Single                   Spacing  // 0x68
METHODS:
  System.Boolean get_IsCenterAlign()
  System.Boolean get_IsRightAlign()
  System.Boolean get_IsMiddleAlign()
  System.Boolean get_IsLowerAlign()
  System.Void CalculateLayoutInputHorizontal()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void CalculateLayoutInputVertical()
  System.Single SetLayout(System.Single width, System.Int32 axis, System.Boolean layoutInput)
  System.Single CalculateRowVerticalOffset(System.Single groupHeight, System.Single yOffset, System.Single currentRowHeight)
  System.Void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, System.Single rowWidth, System.Single rowHeight, System.Single maxWidth, System.Single xOffset, System.Single yOffset, System.Int32 axis)
  System.Single GetGreatestMinimumChildWidth()
  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Layout.IVirtualView
TYPE:  interface
TOKEN: 0x200003B
FIELDS:
METHODS:
  System.Void SetDataContext(System.Object data)
END_CLASS

CLASS: SRF.UI.Layout.VirtualVerticalLayoutGroup
TYPE:  class
TOKEN: 0x200003C
EXTENDS: LayoutGroup
FIELDS:
  private   readonly SRF.SRList<System.Object>       _itemList  // 0x58
  private   readonly SRF.SRList<System.Int32>        _visibleItemList  // 0x60
  private           System.Boolean                  _isDirty  // 0x68
  private           SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row>_rowCache  // 0x70
  private           UnityEngine.UI.ScrollRect       _scrollRect  // 0x78
  private           System.Int32                    _selectedIndex  // 0x80
  private           System.Object                   _selectedItem  // 0x88
  private           SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent_selectedItemChanged  // 0x90
  private           System.Int32                    _visibleItemCount  // 0x98
  private           SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row>_visibleRows  // 0xA0
  public            SRF.UI.StyleSheet               AltRowStyleSheet  // 0xA8
  public            System.Boolean                  EnableSelection  // 0xB0
  public            UnityEngine.RectTransform       ItemPrefab  // 0xB8
  public            System.Int32                    RowPadding  // 0xC0
  public            SRF.UI.StyleSheet               RowStyleSheet  // 0xC8
  public            SRF.UI.StyleSheet               SelectedRowStyleSheet  // 0xD0
  public            System.Single                   Spacing  // 0xD8
  public            System.Boolean                  StickToBottom  // 0xDC
  private           System.Single                   _itemHeight  // 0xE0
METHODS:
  SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent get_SelectedItemChanged()
  System.Void set_SelectedItemChanged(SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent value)
  System.Object get_SelectedItem()
  System.Void set_SelectedItem(System.Object value)
  System.Single get_minHeight()
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Awake()
  System.Void OnScrollRectValueChanged(UnityEngine.Vector2 d)
  System.Void Start()
  System.Void OnEnable()
  System.Void Update()
  System.Void InvalidateItem(System.Int32 itemIndex)
  System.Void RefreshIndexCache()
  System.Void ScrollUpdate()
  System.Void CalculateLayoutInputVertical()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void SetDirty()
  System.Void AddItem(System.Object item)
  System.Void RemoveItem(System.Object item)
  System.Void ClearItems()
  UnityEngine.UI.ScrollRect get_ScrollRect()
  System.Boolean get_AlignBottom()
  System.Boolean get_AlignTop()
  System.Single get_ItemHeight()
  SRF.UI.Layout.VirtualVerticalLayoutGroup.Row GetRow(System.Int32 forIndex)
  System.Void RecycleRow(SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
  System.Void PopulateRow(System.Int32 index, SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
  SRF.UI.Layout.VirtualVerticalLayoutGroup.Row CreateRow()
  System.Void .ctor()
END_CLASS

