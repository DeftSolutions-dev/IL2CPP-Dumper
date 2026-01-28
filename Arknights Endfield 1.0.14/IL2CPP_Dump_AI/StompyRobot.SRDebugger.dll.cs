// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRDebugger.dll
// Classes:  159
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SRDebug
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  public    static  System.String                   Version  // 0x0
  private   static  System.Boolean                  <IsInitialized>k__BackingField  // 0x0
  public    static  System.Action<SRDebugger.Services.ConsoleEntry>CopyConsoleItemCallback  // 0x8
METHODS:
  System.Boolean get_IsInitialized()
  System.Void set_IsInitialized(System.Boolean value)
  SRDebugger.Services.IDebugService get_Instance()
  System.Void Init()
  System.Action<SRDebugger.Services.ConsoleEntry> GetDefaultCopyConsoleItemCallback()
  System.Void .cctor()
END_CLASS

CLASS: ShortcutActions
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.ShortcutActionsNone  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsOpenSystemInfoTab  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsOpenConsoleTab  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsOpenOptionsTab  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsOpenProfilerTab  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsOpenBugReporterTab  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsClosePanel  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsOpenPanel  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsTogglePanel  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsShowBugReportPopover  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsToggleDockedConsole  // 0x0
  public    static  SRDebugger.Settings.ShortcutActionsToggleDockedProfiler  // 0x0
METHODS:
END_CLASS

CLASS: TriggerBehaviours
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.TriggerBehavioursTripleTap  // 0x0
  public    static  SRDebugger.Settings.TriggerBehavioursTapAndHold  // 0x0
  public    static  SRDebugger.Settings.TriggerBehavioursDoubleTap  // 0x0
METHODS:
END_CLASS

CLASS: TriggerEnableModes
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.TriggerEnableModesEnabled  // 0x0
  public    static  SRDebugger.Settings.TriggerEnableModesMobileOnly  // 0x0
  public    static  SRDebugger.Settings.TriggerEnableModesOff  // 0x0
  public    static  SRDebugger.Settings.TriggerEnableModesDevelopmentBuildsOnly  // 0x0
METHODS:
END_CLASS

CLASS: UIModes
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.UIModes     NewInputSystem  // 0x0
  public    static  SRDebugger.Settings.UIModes     LegacyInputSystem  // 0x0
METHODS:
END_CLASS

CLASS: KeyboardShortcut
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  public            SRDebugger.Settings.ShortcutActionsAction  // 0x10
  public            System.Boolean                  Alt  // 0x14
  public            System.Boolean                  Control  // 0x15
  public            UnityEngine.KeyCode             Key  // 0x18
  public            System.Boolean                  Shift  // 0x1C
  public            System.Nullable<UnityEngine.InputSystem.Key>Cached_KeyCode  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CopyToClipboardStates
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStatesHidden  // 0x0
  public    static  SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStatesVisible  // 0x0
  public    static  SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStatesActivated  // 0x0
METHODS:
END_CLASS

CLASS: CategoryInstance
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private           SRDebugger.UI.Other.CategoryGroup<CategoryGroup>k__BackingField  // 0x10
  public    readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>Options  // 0x18
METHODS:
  SRDebugger.UI.Other.CategoryGroup get_CategoryGroup()
  System.Void set_CategoryGroup(SRDebugger.UI.Other.CategoryGroup value)
  System.Void .ctor(SRDebugger.UI.Other.CategoryGroup group)
END_CLASS

CLASS: VerticalAlignments
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignmentsTop  // 0x0
  public    static  SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignmentsBottom  // 0x0
METHODS:
END_CLASS

CLASS: ValueRange
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  public            System.Double                   MaxValue  // 0x10
  public            System.Double                   MinValue  // 0x18
METHODS:
END_CLASS

CLASS: OptionContainerEventHandler
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private   readonly SRDebugger.Services.Implementation.OptionsServiceImpl_service  // 0x10
  private   readonly SRDebugger.IOptionContainer     _container  // 0x18
METHODS:
  System.Void .ctor(SRDebugger.Services.Implementation.OptionsServiceImpl service, SRDebugger.IOptionContainer container)
  System.Void ContainerOnOptionAdded(SRDebugger.OptionDefinition obj)
  System.Void ContainerOnOptionRemoved(SRDebugger.OptionDefinition obj)
  System.Void Dispose()
END_CLASS

CLASS: ReflectionOptionContainer
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private           System.Collections.Generic.List<SRDebugger.OptionDefinition>_options  // 0x10
  private   readonly System.Object                   _target  // 0x18
METHODS:
  System.Void add_OptionAdded(System.Action<SRDebugger.OptionDefinition> value)
  System.Void remove_OptionAdded(System.Action<SRDebugger.OptionDefinition> value)
  System.Void add_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value)
  System.Void remove_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value)
  System.Boolean get_IsDynamic()
  System.Collections.Generic.List<SRDebugger.OptionDefinition> get_Options()
  System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions()
  System.Void .ctor(System.Object target)
  System.Boolean Equals(SRDebugger.Services.Implementation.OptionsServiceImpl.ReflectionOptionContainer other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: OptionType
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public    readonly System.Type                     Type  // 0x10
  public    readonly System.Boolean                  IsReadyOnly  // 0x18
METHODS:
  System.Void .ctor(System.Type type, System.Boolean isReadyOnly)
  System.Boolean Equals(SRDebugger.Internal.OptionControlFactory.OptionType other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
METHODS:
END_CLASS

CLASS: Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation.ConsoleFilterStateService
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           SRDebugger.Services.ConsoleStateChangedEventHandlerFilterStateChange  // 0x10
  private   readonly System.Boolean[]                _states  // 0x18
METHODS:
  System.Void add_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value)
  System.Void remove_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value)
  System.Void .ctor()
  System.Void SetConsoleFilterState(UnityEngine.LogType type, System.Boolean newState)
  System.Boolean GetConsoleFilterState(UnityEngine.LogType type)
  UnityEngine.LogType GetType(UnityEngine.LogType type)
END_CLASS

CLASS: SRDebugger.AutoInitialize
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  UnityEngine.RuntimeInitializeLoadTypeInitializeLoadType  // 0x0
METHODS:
  System.Void OnLoadBeforeScene()
  System.Void OnLoad()
END_CLASS

CLASS: SRDebugger.BugReport
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  public            System.Collections.Generic.List<SRDebugger.Services.ConsoleEntry>ConsoleLog  // 0x10
  public            System.String                   Email  // 0x18
  public            System.Byte[]                   ScreenshotData  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>>SystemInformation  // 0x28
  public            System.String                   UserDescription  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.BugReportSubmitResult
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   readonly System.Boolean                  <IsSuccessful>k__BackingField  // 0x10
  private   readonly System.String                   <ErrorMessage>k__BackingField  // 0x18
METHODS:
  SRDebugger.BugReportSubmitResult get_Success()
  SRDebugger.BugReportSubmitResult Error(System.String errorMessage)
  System.Boolean get_IsSuccessful()
  System.String get_ErrorMessage()
  System.Void .ctor(System.Boolean successful, System.String error)
END_CLASS

CLASS: SRDebugger.IBugReporterHandler
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Boolean get_IsUsable()
  System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
END_CLASS

CLASS: SRDebugger.CircularBuffer`1
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   readonly T[]                             _buffer  // 0x0
  private           System.Int32                    _end  // 0x0
  private           System.Int32                    _count  // 0x0
  private           System.Int32                    _start  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Int32 capacity, T[] items)
  System.Int32 get_Capacity()
  System.Boolean get_IsFull()
  System.Boolean get_IsEmpty()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void Clear()
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T Front()
  T Back()
  System.Void PushBack(T item)
  System.Void PushFront(T item)
  System.Void PopBack()
  System.Void PopFront()
  T[] ToArray()
  System.Void ThrowIfEmpty(System.String message)
  System.Void Increment(System.Int32& index)
  System.Void Decrement(System.Int32& index)
  System.Int32 InternalIndex(System.Int32 index)
  System.ArraySegment<T> ArrayOne()
  System.ArraySegment<T> ArrayTwo()
END_CLASS

CLASS: SRDebugger.OptionDefinition
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.String                   <Category>k__BackingField  // 0x18
  private           System.Int32                    <SortPriority>k__BackingField  // 0x20
  private           SRF.Helpers.MethodReference     <Method>k__BackingField  // 0x28
  private           SRF.Helpers.PropertyReference   <Property>k__BackingField  // 0x30
METHODS:
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_Category()
  System.Void set_Category(System.String value)
  System.Int32 get_SortPriority()
  System.Void set_SortPriority(System.Int32 value)
  System.Boolean get_IsMethod()
  System.Boolean get_IsProperty()
  SRF.Helpers.MethodReference get_Method()
  System.Void set_Method(SRF.Helpers.MethodReference value)
  SRF.Helpers.PropertyReference get_Property()
  System.Void set_Property(SRF.Helpers.PropertyReference value)
  System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority)
  System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.MethodReference method)
  System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.PropertyReference property)
  SRDebugger.OptionDefinition FromMethod(System.String name, System.Action callback, System.String category, System.Int32 sortPriority)
  SRDebugger.OptionDefinition Create(System.String name, System.Func<T> getter, System.Action<T> setter, System.String category, System.Int32 sortPriority)
END_CLASS

CLASS: SRDebugger.IOptionContainer
TYPE:  interface
TOKEN: 0x200000C
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions()
  System.Boolean get_IsDynamic()
  System.Void add_OptionAdded(System.Action<SRDebugger.OptionDefinition> value)
  System.Void remove_OptionAdded(System.Action<SRDebugger.OptionDefinition> value)
  System.Void add_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value)
  System.Void remove_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value)
END_CLASS

CLASS: SRDebugger.DynamicOptionContainer
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   readonly System.Collections.Generic.List<SRDebugger.OptionDefinition>_options  // 0x10
  private   readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition>_optionsReadOnly  // 0x18
  private           System.Action<SRDebugger.OptionDefinition>OptionAdded  // 0x20
  private           System.Action<SRDebugger.OptionDefinition>OptionRemoved  // 0x28
METHODS:
  System.Collections.Generic.IList<SRDebugger.OptionDefinition> get_Options()
  System.Void .ctor()
  System.Void AddOption(SRDebugger.OptionDefinition option)
  System.Boolean RemoveOption(SRDebugger.OptionDefinition option)
  System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> SRDebugger.IOptionContainer.GetOptions()
  System.Boolean get_IsDynamic()
  System.Void add_OptionAdded(System.Action<SRDebugger.OptionDefinition> value)
  System.Void remove_OptionAdded(System.Action<SRDebugger.OptionDefinition> value)
  System.Void add_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value)
  System.Void remove_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value)
END_CLASS

CLASS: SRDebugger.VisibilityChangedDelegate
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Boolean isVisible)
  System.IAsyncResult BeginInvoke(System.Boolean isVisible, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.ActionCompleteCallback
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Boolean success)
  System.IAsyncResult BeginInvoke(System.Boolean success, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.PinnedUiCanvasCreated
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.RectTransform canvasTransform)
  System.IAsyncResult BeginInvoke(UnityEngine.RectTransform canvasTransform, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.EntryCode
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public    readonly System.Int32                    Digit1  // 0x10
  public    readonly System.Int32                    Digit2  // 0x14
  public    readonly System.Int32                    Digit3  // 0x18
  public    readonly System.Int32                    Digit4  // 0x1C
METHODS:
  System.Void .ctor(System.Int32 digit1, System.Int32 digit2, System.Int32 digit3, System.Int32 digit4)
  System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 get_Count()
  System.Int32 get_Item(System.Int32 index)
END_CLASS

CLASS: SRDebugger.InfoEntry
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private           System.String                   <Title>k__BackingField  // 0x10
  private           System.Boolean                  <IsPrivate>k__BackingField  // 0x18
  private           System.Func<System.Object>      _valueGetter  // 0x20
METHODS:
  System.String get_Title()
  System.Void set_Title(System.String value)
  System.Object get_Value()
  System.Boolean get_IsPrivate()
  System.Void set_IsPrivate(System.Boolean value)
  SRDebugger.InfoEntry Create(System.String name, System.Func<System.Object> getter, System.Boolean isPrivate)
  SRDebugger.InfoEntry Create(System.String name, System.Object value, System.Boolean isPrivate)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.DefaultTabs
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.DefaultTabs          SystemInformation  // 0x0
  public    static  SRDebugger.DefaultTabs          Options  // 0x0
  public    static  SRDebugger.DefaultTabs          Console  // 0x0
  public    static  SRDebugger.DefaultTabs          Profiler  // 0x0
  public    static  SRDebugger.DefaultTabs          BugReporter  // 0x0
METHODS:
END_CLASS

CLASS: SRDebugger.PinAlignment
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.PinAlignment         TopLeft  // 0x0
  public    static  SRDebugger.PinAlignment         TopRight  // 0x0
  public    static  SRDebugger.PinAlignment         BottomLeft  // 0x0
  public    static  SRDebugger.PinAlignment         BottomRight  // 0x0
  public    static  SRDebugger.PinAlignment         CenterLeft  // 0x0
  public    static  SRDebugger.PinAlignment         CenterRight  // 0x0
  public    static  SRDebugger.PinAlignment         TopCenter  // 0x0
  public    static  SRDebugger.PinAlignment         BottomCenter  // 0x0
METHODS:
END_CLASS

CLASS: SRDebugger.ConsoleAlignment
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.ConsoleAlignment     Top  // 0x0
  public    static  SRDebugger.ConsoleAlignment     Bottom  // 0x0
METHODS:
END_CLASS

CLASS: SRDebugger.Settings
TYPE:  class
TOKEN: 0x2000017
EXTENDS: ScriptableObject
FIELDS:
  private   static  System.String                   ResourcesName  // 0x0
  private   static  SRDebugger.Settings             _instance  // 0x0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x18
  private           System.Boolean                  _isEnabled  // 0x20
  private           System.Boolean                  _disableWelcomePopup  // 0x21
  private           SRDebugger.Settings.UIModes     _uiInputMode  // 0x24
  private           SRDebugger.DefaultTabs          _defaultTab  // 0x28
  private           SRDebugger.Settings.TriggerEnableModes_triggerEnableMode  // 0x2C
  private           SRDebugger.Settings.TriggerBehaviours_triggerBehaviour  // 0x30
  private           System.Boolean                  _errorNotification  // 0x34
  private           System.Boolean                  _enableKeyboardShortcuts  // 0x35
  private           SRDebugger.Settings.KeyboardShortcut[]_keyboardShortcuts  // 0x38
  private           SRDebugger.Settings.KeyboardShortcut[]_newKeyboardShortcuts  // 0x40
  private           System.Boolean                  _keyboardModifierControl  // 0x48
  private           System.Boolean                  _keyboardModifierAlt  // 0x49
  private           System.Boolean                  _keyboardModifierShift  // 0x4A
  private           System.Boolean                  _keyboardEscapeClose  // 0x4B
  private           System.Boolean                  _enableBackgroundTransparency  // 0x4C
  private           System.Single                   _backgroundTransparency  // 0x50
  private           System.Boolean                  _collapseDuplicateLogEntries  // 0x54
  private           System.Boolean                  _richTextInConsole  // 0x55
  private           System.Boolean                  _requireEntryCode  // 0x56
  private           System.Boolean                  _requireEntryCodeEveryTime  // 0x57
  private           System.Int32[]                  _entryCode  // 0x58
  private           System.Boolean                  _useDebugCamera  // 0x60
  private           System.Int32                    _debugLayer  // 0x64
  private           System.Single                   _debugCameraDepth  // 0x68
  private           System.String                   _apiKey  // 0x70
  private           System.Boolean                  _enableBugReporter  // 0x78
  private           System.Boolean                  _enableBugReportScreenshot  // 0x79
  private           SRDebugger.DefaultTabs[]        _disabledTabs  // 0x80
  private           SRDebugger.PinAlignment         _profilerAlignment  // 0x88
  private           SRDebugger.PinAlignment         _optionsAlignment  // 0x8C
  private           SRDebugger.ConsoleAlignment     _consoleAlignment  // 0x90
  private           SRDebugger.PinAlignment         _triggerPosition  // 0x94
  private           System.Int32                    _maximumConsoleEntries  // 0x98
  private           System.Boolean                  _enableEventSystemCreation  // 0x9C
  private           System.Boolean                  _automaticShowCursor  // 0x9D
  private           System.Single                   _uiScale  // 0xA0
  private           System.Boolean                  _unloadOnClose  // 0xA4
METHODS:
  SRDebugger.Settings get_Instance()
  SRDebugger.Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts()
  System.Void UpgradeKeyboardShortcuts()
  System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Boolean get_IsEnabled()
  SRDebugger.Settings.UIModes get_UIInputMode()
  SRDebugger.DefaultTabs get_DefaultTab()
  SRDebugger.Settings.TriggerEnableModes get_EnableTrigger()
  SRDebugger.Settings.TriggerBehaviours get_TriggerBehaviour()
  System.Boolean get_ErrorNotification()
  System.Boolean get_EnableKeyboardShortcuts()
  System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> get_KeyboardShortcuts()
  System.Boolean get_KeyboardEscapeClose()
  System.Boolean get_EnableBackgroundTransparency()
  System.Single get_BackgroundTransparency()
  System.Boolean get_RequireCode()
  System.Boolean get_RequireEntryCodeEveryTime()
  System.Collections.Generic.IList<System.Int32> get_EntryCode()
  System.Void set_EntryCode(System.Collections.Generic.IList<System.Int32> value)
  System.Boolean get_UseDebugCamera()
  System.Int32 get_DebugLayer()
  System.Single get_DebugCameraDepth()
  System.Boolean get_CollapseDuplicateLogEntries()
  System.Boolean get_RichTextInConsole()
  System.String get_ApiKey()
  System.Boolean get_EnableBugReporter()
  System.Boolean get_EnableBugReportScreenshot()
  System.Collections.Generic.IList<SRDebugger.DefaultTabs> get_DisabledTabs()
  SRDebugger.PinAlignment get_TriggerPosition()
  SRDebugger.PinAlignment get_ProfilerAlignment()
  SRDebugger.PinAlignment get_OptionsAlignment()
  SRDebugger.ConsoleAlignment get_ConsoleAlignment()
  System.Void set_ConsoleAlignment(SRDebugger.ConsoleAlignment value)
  System.Int32 get_MaximumConsoleEntries()
  System.Void set_MaximumConsoleEntries(System.Int32 value)
  System.Boolean get_EnableEventSystemGeneration()
  System.Void set_EnableEventSystemGeneration(System.Boolean value)
  System.Boolean get_AutomaticallyShowCursor()
  System.Single get_UIScale()
  System.Void set_UIScale(System.Single value)
  System.Boolean get_UnloadOnClose()
  System.Void OnPropertyChanged(System.String propertyName)
  System.Void ClearCache()
  SRDebugger.Settings GetInstance()
  SRDebugger.Settings GetOrCreateInstance()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.SRDebuggerInit
TYPE:  class
TOKEN: 0x200001E
EXTENDS: SRMonoBehaviourEx
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.NumberRangeAttribute
TYPE:  class
TOKEN: 0x200001F
EXTENDS: Attribute
FIELDS:
  public    readonly System.Double                   Max  // 0x10
  public    readonly System.Double                   Min  // 0x18
METHODS:
  System.Void .ctor(System.Double min, System.Double max)
END_CLASS

CLASS: SRDebugger.IncrementAttribute
TYPE:  class
TOKEN: 0x2000020
EXTENDS: Attribute
FIELDS:
  public    readonly System.Double                   Increment  // 0x10
METHODS:
  System.Void .ctor(System.Double increment)
END_CLASS

CLASS: SRDebugger.SortAttribute
TYPE:  class
TOKEN: 0x2000021
EXTENDS: Attribute
FIELDS:
  public    readonly System.Int32                    SortPriority  // 0x10
METHODS:
  System.Void .ctor(System.Int32 priority)
END_CLASS

CLASS: SRDebugger.VersionInfo
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  public    static  System.String                   Version  // 0x0
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.SRDebugApi
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  public    static  System.String                   Protocol  // 0x0
  public    static  System.String                   EndPoint  // 0x0
  public    static  System.String                   BugReportEndPoint  // 0x0
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.SRDebugApiUtil
TYPE:  class
TOKEN: 0x2000090
FIELDS:
METHODS:
  System.String ParseErrorException(System.Net.WebException ex)
  System.String ParseErrorResponse(System.String response, System.String fallback)
  System.Boolean ReadResponse(System.Net.HttpWebRequest request, System.String& result)
  System.String ReadResponseStream(System.Net.WebResponse stream)
END_CLASS

CLASS: SRDebugger.Internal.BugReportApi
TYPE:  class
TOKEN: 0x2000091
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   _apiKey  // 0x18
  private           SRDebugger.BugReport            _bugReport  // 0x20
  private           System.Boolean                  _isBusy  // 0x28
  private           UnityEngine.Networking.UnityWebRequest_webRequest  // 0x30
  private           System.Action<SRDebugger.BugReportSubmitResult>_onComplete  // 0x38
  private           System.IProgress<System.Single> _progress  // 0x40
METHODS:
  System.Void Submit(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
  System.Void Init(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
  System.Void Update()
  System.Collections.IEnumerator Submit()
  System.Void SetCompletionState(SRDebugger.BugReportSubmitResult result)
  System.String BuildJsonRequest(SRDebugger.BugReport report)
  System.Collections.Generic.List<System.Collections.Generic.List<System.String>> CreateConsoleDump()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.BugReportScreenshotUtil
TYPE:  class
TOKEN: 0x2000093
FIELDS:
  public    static  System.Byte[]                   ScreenshotData  // 0x0
METHODS:
  System.Collections.IEnumerator ScreenshotCaptureCo()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.InternalBugReporterHandler
TYPE:  class
TOKEN: 0x2000095
FIELDS:
METHODS:
  System.Boolean get_IsUsable()
  System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.InternalOptionsRegistry
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  private           System.Collections.Generic.List<System.Object>_registeredContainers  // 0x10
  private           System.Action<System.Object>    _handler  // 0x18
METHODS:
  System.Void AddOptionContainer(System.Object obj)
  System.Void SetHandler(System.Action<System.Object> action)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.OptionControlFactory
TYPE:  class
TOKEN: 0x2000097
FIELDS:
  private   static  System.Collections.Generic.IList<SRDebugger.UI.Controls.DataBoundControl>_dataControlPrefabs  // 0x0
  private   static  SRDebugger.UI.Controls.Data.ActionControl_actionControlPrefab  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionControlFactory.OptionType,SRDebugger.UI.Controls.DataBoundControl>TypeCache  // 0x10
METHODS:
  System.Boolean CanCreateControl(SRDebugger.OptionDefinition from)
  SRDebugger.UI.Controls.OptionsControlBase CreateControl(SRDebugger.OptionDefinition from, System.String categoryPrefix)
  System.Void PopulateDataControlPrefabs()
  SRDebugger.UI.Controls.Data.ActionControl CreateActionControl(SRDebugger.OptionDefinition from, System.String categoryPrefix)
  SRDebugger.UI.Controls.DataBoundControl CreateDataControl(SRDebugger.OptionDefinition from, System.String categoryPrefix)
  SRDebugger.UI.Controls.DataBoundControl TryGetDataControlPrefab(SRDebugger.OptionDefinition from)
  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.Internal.SRDebugPaths
TYPE:  class
TOKEN: 0x200009A
FIELDS:
  public    static  System.String                   DataControlsResourcesPath  // 0x0
  public    static  System.String                   TriggerPrefabPath  // 0x0
  public    static  System.String                   DebugPanelPrefabPath  // 0x0
  public    static  System.String                   PinnedUIPrefabPath  // 0x0
  public    static  System.String                   DockConsolePrefabPath  // 0x0
  public    static  System.String                   PinEntryPrefabPath  // 0x0
  public    static  System.String                   BugReportPopoverPath  // 0x0
  public    static  System.String                   BugReportSheetPath  // 0x0
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.Service
TYPE:  class
TOKEN: 0x200009B
FIELDS:
  private   static  SRDebugger.Services.IConsoleService_consoleService  // 0x0
  private   static  SRDebugger.Services.IDebugPanelService_debugPanelService  // 0x8
  private   static  SRDebugger.Services.IDebugTriggerService_debugTriggerService  // 0x10
  private   static  SRDebugger.Services.IPinnedUIService_pinnedUiService  // 0x18
  private   static  SRDebugger.Services.IDebugCameraService_debugCameraService  // 0x20
  private   static  SRDebugger.Services.IOptionsService_optionsService  // 0x28
  private   static  SRDebugger.Services.IDockConsoleService_dockConsoleService  // 0x30
METHODS:
  SRDebugger.Services.IConsoleService get_Console()
  SRDebugger.Services.IDockConsoleService get_DockConsole()
  SRDebugger.Services.IDebugPanelService get_Panel()
  SRDebugger.Services.IDebugTriggerService get_Trigger()
  SRDebugger.Services.IPinnedUIService get_PinnedUI()
  SRDebugger.Services.IDebugCameraService get_DebugCamera()
  SRDebugger.Services.IOptionsService get_Options()
END_CLASS

CLASS: SRDebugger.Internal.SRDebugStrings
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  public    static readonly SRDebugger.Internal.SRDebugStringsCurrent  // 0x0
  public    readonly System.String                   Console_MessageTruncated  // 0x10
  public    readonly System.String                   Console_NoStackTrace  // 0x18
  public    readonly System.String                   PinEntryPrompt  // 0x20
  public    readonly System.String                   Profiler_DisableProfilerInfo  // 0x28
  public    readonly System.String                   Profiler_EnableProfilerInfo  // 0x30
  public    readonly System.String                   Profiler_NoProInfo  // 0x38
  public    readonly System.String                   Profiler_NotSupported  // 0x40
  public    readonly System.String                   ProfilerCameraListenerHelp  // 0x48
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.Internal.SRDebuggerUtil
TYPE:  class
TOKEN: 0x200009D
FIELDS:
METHODS:
  System.Boolean get_IsMobilePlatform()
  System.Boolean EnsureEventSystemExists()
  System.Void CreateDefaultEventSystem()
  System.Void AddInputSystem(UnityEngine.GameObject go)
  System.Void AddLegacyInputSystem(UnityEngine.GameObject go)
  System.Collections.Generic.List<SRDebugger.OptionDefinition> ScanForOptions(System.Object obj)
  System.String GetNumberString(System.Int32 value, System.Int32 max, System.String exceedsMaxString)
  System.Void ConfigureCanvas(UnityEngine.Canvas canvas)
END_CLASS

CLASS: SRDebugger.Profiler.ProfilerLateUpdateListener
TYPE:  class
TOKEN: 0x200008B
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Action                   OnLateUpdate  // 0x18
METHODS:
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Profiler.ProfilerServiceImpl
TYPE:  class
TOKEN: 0x200008C
EXTENDS: SRServiceBase`1
FIELDS:
  private           System.Single                   <AverageFrameTime>k__BackingField  // 0x48
  private           System.Single                   <LastFrameTime>k__BackingField  // 0x4C
  private   static  System.Int32                    FrameBufferSize  // 0x0
  private   readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>_frameBuffer  // 0x50
  private           SRDebugger.Profiler.ProfilerLateUpdateListener_lateUpdateListener  // 0x58
  private   readonly System.Diagnostics.Stopwatch    _stopwatch  // 0x60
  private           System.Double                   _updateDuration  // 0x68
  private           System.Double                   _renderStartTime  // 0x70
  private           System.Double                   _renderDuration  // 0x78
  private           System.Int32                    _camerasThisFrame  // 0x80
METHODS:
  System.Single get_AverageFrameTime()
  System.Void set_AverageFrameTime(System.Single value)
  System.Single get_LastFrameTime()
  System.Void set_LastFrameTime(System.Single value)
  SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer()
  System.Void Awake()
  System.Void Update()
  System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime)
  System.Void OnLateUpdate()
  System.Void OnCameraPreRender(UnityEngine.Camera cam)
  System.Void OnCameraPostRender(UnityEngine.Camera cam)
  System.Void EndFrame()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Profiler.SRPProfilerService
TYPE:  class
TOKEN: 0x200008D
EXTENDS: SRServiceBase`1
FIELDS:
  private           System.Single                   <AverageFrameTime>k__BackingField  // 0x48
  private           System.Single                   <LastFrameTime>k__BackingField  // 0x4C
  private   static  System.Int32                    FrameBufferSize  // 0x0
  private   readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>_frameBuffer  // 0x50
  private           SRDebugger.Profiler.ProfilerLateUpdateListener_lateUpdateListener  // 0x58
  private           System.Double                   _updateDuration  // 0x60
  private           System.Double                   _renderStartTime  // 0x68
  private           System.Double                   _renderDuration  // 0x70
  private   readonly System.Diagnostics.Stopwatch    _stopwatch  // 0x78
METHODS:
  System.Single get_AverageFrameTime()
  System.Void set_AverageFrameTime(System.Single value)
  System.Single get_LastFrameTime()
  System.Void set_LastFrameTime(System.Single value)
  SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer()
  System.Void Awake()
  System.Void Update()
  System.Collections.IEnumerator EndOfFrameCoroutine()
  System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime)
  System.Void OnLateUpdate()
  System.Void RenderPipelineOnBeginFrameRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void EndFrame()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Scripts.DebuggerTabController
TYPE:  class
TOKEN: 0x2000023
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           SRDebugger.UI.Other.SRTab       _aboutTabInstance  // 0x48
  private           System.Nullable<SRDebugger.DefaultTabs>_activeTab  // 0x50
  private           System.Boolean                  _hasStarted  // 0x58
  public            SRDebugger.UI.Other.SRTab       AboutTab  // 0x60
  public            SRDebugger.UI.Other.SRTabControllerTabController  // 0x68
METHODS:
  System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
  System.Void Start()
  System.Boolean OpenTab(SRDebugger.DefaultTabs tab)
  System.Void ShowAboutTab()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.ConsoleFilterStateService
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private           SRDebugger.Services.ConsoleStateChangedEventHandlerFilterStateChange  // 0x10
  private           System.Boolean[]                _states  // 0x18
METHODS:
  System.Void add_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value)
  System.Void remove_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value)
  System.Void .ctor()
  System.Void SetState(UnityEngine.LogType type, System.Boolean newState)
  System.Boolean GetState(UnityEngine.LogType type)
  UnityEngine.LogType GetType(UnityEngine.LogType type)
END_CLASS

CLASS: SRDebugger.Services.BugReportCompleteCallback
TYPE:  class
TOKEN: 0x2000062
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Boolean didSucceed, System.String errorMessage)
  System.IAsyncResult BeginInvoke(System.Boolean didSucceed, System.String errorMessage, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.BugReportProgressCallback
TYPE:  class
TOKEN: 0x2000063
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Single progress)
  System.IAsyncResult BeginInvoke(System.Single progress, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IBugReportService
TYPE:  interface
TOKEN: 0x2000064
FIELDS:
METHODS:
  System.Boolean get_IsUsable()
  System.Void SetHandler(SRDebugger.IBugReporterHandler handler)
  System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progressCallback)
END_CLASS

CLASS: SRDebugger.Services.ConsoleStateChangedEventHandler
TYPE:  class
TOKEN: 0x2000065
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.LogType logType, System.Boolean newState)
  System.IAsyncResult BeginInvoke(UnityEngine.LogType logType, System.Boolean newState, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IConsoleFilterState
TYPE:  interface
TOKEN: 0x2000066
FIELDS:
METHODS:
  System.Void add_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value)
  System.Void remove_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value)
  System.Void SetConsoleFilterState(UnityEngine.LogType logType, System.Boolean enabled)
  System.Boolean GetConsoleFilterState(UnityEngine.LogType logType)
END_CLASS

CLASS: SRDebugger.Services.ConsoleUpdatedEventHandler
TYPE:  class
TOKEN: 0x2000067
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(SRDebugger.Services.IConsoleService console)
  System.IAsyncResult BeginInvoke(SRDebugger.Services.IConsoleService console, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IConsoleService
TYPE:  interface
TOKEN: 0x2000068
FIELDS:
METHODS:
  System.Int32 get_CriticalCount()
  System.Int32 get_ErrorCount()
  System.Int32 get_WarningCount()
  System.Int32 get_InfoCount()
  System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries()
  System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries()
  System.Void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Void add_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Void remove_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Boolean get_LoggingEnabled()
  System.Void set_LoggingEnabled(System.Boolean value)
  System.Boolean get_LogHandlerIsOverriden()
  System.Void Clear()
END_CLASS

CLASS: SRDebugger.Services.ConsoleEntry
TYPE:  class
TOKEN: 0x2000069
FIELDS:
  private   static  System.Int32                    MessagePreviewLength  // 0x0
  private   static  System.Int32                    StackTracePreviewLength  // 0x0
  private           System.String                   _messagePreview  // 0x10
  private           System.String                   _stackTracePreview  // 0x18
  public            System.Int32                    Count  // 0x20
  public            UnityEngine.LogType             LogType  // 0x24
  public            System.String                   Message  // 0x28
  public            System.String                   StackTrace  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(SRDebugger.Services.ConsoleEntry other)
  System.String get_MessagePreview()
  System.String get_StackTracePreview()
  System.Boolean Matches(SRDebugger.Services.ConsoleEntry other)
END_CLASS

CLASS: SRDebugger.Services.IDebugCameraService
TYPE:  interface
TOKEN: 0x200006A
FIELDS:
METHODS:
  UnityEngine.Camera get_Camera()
END_CLASS

CLASS: SRDebugger.Services.IDebugPanelService
TYPE:  interface
TOKEN: 0x200006B
FIELDS:
METHODS:
  System.Boolean get_IsLoaded()
  System.Boolean get_IsVisible()
  System.Void set_IsVisible(System.Boolean value)
  System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
  System.Void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value)
  System.Void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value)
  System.Void Unload()
  System.Void OpenTab(SRDebugger.DefaultTabs tab)
END_CLASS

CLASS: SRDebugger.Services.IDebugService
TYPE:  interface
TOKEN: 0x200006C
FIELDS:
METHODS:
  SRDebugger.Settings get_Settings()
  System.Boolean get_IsDebugPanelVisible()
  System.Boolean get_IsTriggerEnabled()
  System.Void set_IsTriggerEnabled(System.Boolean value)
  System.Boolean get_IsTriggerErrorNotificationEnabled()
  System.Void set_IsTriggerErrorNotificationEnabled(System.Boolean value)
  SRDebugger.Services.IDockConsoleService get_DockConsole()
  SRDebugger.Services.IConsoleFilterState get_ConsoleFilter()
  System.Boolean get_IsProfilerDocked()
  System.Void set_IsProfilerDocked(System.Boolean value)
  System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category)
  System.Void ShowDebugPanel(System.Boolean requireEntryCode)
  System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode)
  System.Void HideDebugPanel()
  System.Void SetEntryCode(SRDebugger.EntryCode newCode)
  System.Void DisableEntryCode()
  System.Void DestroyDebugPanel()
  System.Void AddOptionContainer(System.Object container)
  System.Void RemoveOptionContainer(System.Object container)
  System.Void AddOption(SRDebugger.OptionDefinition option)
  System.Boolean RemoveOption(SRDebugger.OptionDefinition option)
  System.Void PinAllOptions(System.String category)
  System.Void UnpinAllOptions(System.String category)
  System.Void PinOption(System.String name)
  System.Void UnpinOption(System.String name)
  System.Void ClearPinnedOptions()
  System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent)
  System.Void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
  System.Void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
  System.Void add_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value)
  System.Void remove_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value)
  UnityEngine.RectTransform EnableWorldSpaceMode()
  System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler)
END_CLASS

CLASS: SRDebugger.Services.IDebugTriggerService
TYPE:  interface
TOKEN: 0x200006D
FIELDS:
METHODS:
  System.Boolean get_IsEnabled()
  System.Void set_IsEnabled(System.Boolean value)
  System.Boolean get_ShowErrorNotification()
  System.Void set_ShowErrorNotification(System.Boolean value)
  SRDebugger.PinAlignment get_Position()
  System.Void set_Position(SRDebugger.PinAlignment value)
END_CLASS

CLASS: SRDebugger.Services.IDockConsoleService
TYPE:  interface
TOKEN: 0x200006E
FIELDS:
METHODS:
  System.Boolean get_IsVisible()
  System.Void set_IsVisible(System.Boolean value)
  System.Boolean get_IsExpanded()
  System.Void set_IsExpanded(System.Boolean value)
  SRDebugger.ConsoleAlignment get_Alignment()
  System.Void set_Alignment(SRDebugger.ConsoleAlignment value)
END_CLASS

CLASS: SRDebugger.Services.IOptionsService
TYPE:  interface
TOKEN: 0x200006F
FIELDS:
METHODS:
  System.Void add_OptionsUpdated(System.EventHandler value)
  System.Void remove_OptionsUpdated(System.EventHandler value)
  System.Collections.Generic.ICollection<SRDebugger.OptionDefinition> get_Options()
  System.Void Scan(System.Object obj)
  System.Void AddContainer(System.Object obj)
  System.Void AddContainer(SRDebugger.IOptionContainer optionContainer)
  System.Void RemoveContainer(System.Object obj)
  System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer)
END_CLASS

CLASS: SRDebugger.Services.PinEntryCompleteCallback
TYPE:  class
TOKEN: 0x2000070
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Boolean validPinEntered)
  System.IAsyncResult BeginInvoke(System.Boolean validPinEntered, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IPinEntryService
TYPE:  interface
TOKEN: 0x2000071
FIELDS:
METHODS:
  System.Boolean get_IsShowingKeypad()
  System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel)
END_CLASS

CLASS: SRDebugger.Services.IPinnedUIService
TYPE:  interface
TOKEN: 0x2000072
FIELDS:
METHODS:
  System.Void add_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value)
  System.Void remove_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value)
  System.Void add_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value)
  System.Void remove_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value)
  System.Boolean get_IsProfilerPinned()
  System.Void set_IsProfilerPinned(System.Boolean value)
  System.Void Pin(SRDebugger.OptionDefinition option, System.Int32 order)
  System.Void Unpin(SRDebugger.OptionDefinition option)
  System.Void UnpinAll()
  System.Boolean HasPinned(SRDebugger.OptionDefinition option)
END_CLASS

CLASS: SRDebugger.Services.ProfilerServiceSelector
TYPE:  class
TOKEN: 0x2000073
FIELDS:
METHODS:
  System.Type GetProfilerServiceType()
END_CLASS

CLASS: SRDebugger.Services.ProfilerFrame
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Double                   FrameTime  // 0x10
  public            System.Double                   OtherTime  // 0x18
  public            System.Double                   RenderTime  // 0x20
  public            System.Double                   UpdateTime  // 0x28
METHODS:
END_CLASS

CLASS: SRDebugger.Services.IProfilerService
TYPE:  interface
TOKEN: 0x2000075
FIELDS:
METHODS:
  System.Single get_AverageFrameTime()
  System.Single get_LastFrameTime()
  SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer()
END_CLASS

CLASS: SRDebugger.Services.ISystemInformationService
TYPE:  interface
TOKEN: 0x2000076
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<System.String> GetCategories()
  System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category)
  System.Void Add(SRDebugger.InfoEntry info, System.String category)
  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate)
END_CLASS

CLASS: SRDebugger.Services.Implementation.BugReportApiService
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  private           SRDebugger.IBugReporterHandler  _handler  // 0x10
METHODS:
  System.Boolean get_IsUsable()
  System.Void SetHandler(SRDebugger.IBugReporterHandler handler)
  System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progress)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.BugReportPopoverService
TYPE:  class
TOKEN: 0x2000079
EXTENDS: SRServiceBase`1
FIELDS:
  private           SRDebugger.Services.BugReportCompleteCallback_callback  // 0x48
  private           System.Boolean                  _isVisible  // 0x50
  private           SRDebugger.UI.Other.BugReportPopoverRoot_popover  // 0x58
  private           SRDebugger.UI.Other.BugReportSheetController_sheet  // 0x60
METHODS:
  System.Boolean get_IsShowingPopover()
  System.Void ShowBugReporter(SRDebugger.Services.BugReportCompleteCallback callback, System.Boolean takeScreenshotFirst, System.String descriptionText)
  System.Collections.IEnumerator OpenCo(System.Boolean takeScreenshot, System.String descriptionText)
  System.Void SubmitComplete(System.Boolean didSucceed, System.String errorMessage)
  System.Void CancelPressed()
  System.Void OnComplete(System.Boolean success, System.String errorMessage, System.Boolean close)
  System.Void TakingScreenshot()
  System.Void ScreenshotComplete()
  System.Void Awake()
  System.Void Load()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DebugCameraServiceImpl
TYPE:  class
TOKEN: 0x200007B
FIELDS:
  private           UnityEngine.Camera              _debugCamera  // 0x10
METHODS:
  System.Void .ctor()
  UnityEngine.Camera get_Camera()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DebugPanelServiceImpl
TYPE:  class
TOKEN: 0x200007C
EXTENDS: ScriptableObject
FIELDS:
  private           SRDebugger.UI.DebugPanelRoot    _debugPanelRootObject  // 0x18
  private           System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean>VisibilityChanged  // 0x20
  private           System.Boolean                  _isVisible  // 0x28
  private           System.Nullable<System.Boolean> _cursorWasVisible  // 0x29
  private           System.Nullable<UnityEngine.CursorLockMode>_cursorLockMode  // 0x2C
METHODS:
  System.Void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value)
  System.Void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value)
  SRDebugger.UI.DebugPanelRoot get_RootObject()
  System.Boolean get_IsLoaded()
  System.Boolean get_IsVisible()
  System.Void set_IsVisible(System.Boolean value)
  System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
  System.Void OpenTab(SRDebugger.DefaultTabs tab)
  System.Void Unload()
  System.Void Load()
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DebugTriggerImpl
TYPE:  class
TOKEN: 0x200007D
EXTENDS: SRServiceBase`1
FIELDS:
  private           SRDebugger.PinAlignment         _position  // 0x48
  private           SRDebugger.UI.Other.TriggerRoot _trigger  // 0x50
  private           SRDebugger.Services.IConsoleService_consoleService  // 0x58
  private           System.Boolean                  _showErrorNotification  // 0x60
METHODS:
  System.Boolean get_IsEnabled()
  System.Void set_IsEnabled(System.Boolean value)
  System.Boolean get_ShowErrorNotification()
  System.Void set_ShowErrorNotification(System.Boolean value)
  SRDebugger.PinAlignment get_Position()
  System.Void set_Position(SRDebugger.PinAlignment value)
  System.Void Awake()
  System.Void OnError(SRDebugger.Services.IConsoleService console)
  System.Void CreateTrigger()
  System.Void OnDestroy()
  System.Void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2)
  System.Void OnTriggerButtonClick()
  System.Void SetTriggerPosition(UnityEngine.RectTransform t, SRDebugger.PinAlignment position)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DockConsoleServiceImpl
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  private           SRDebugger.ConsoleAlignment     _alignment  // 0x10
  private           SRDebugger.UI.Other.DockConsoleController_consoleRoot  // 0x18
  private           System.Boolean                  _didSuspendTrigger  // 0x20
  private           System.Boolean                  _isExpanded  // 0x21
  private           System.Boolean                  _isVisible  // 0x22
METHODS:
  System.Void .ctor()
  System.Boolean get_IsVisible()
  System.Void set_IsVisible(System.Boolean value)
  System.Boolean get_IsExpanded()
  System.Void set_IsExpanded(System.Boolean value)
  SRDebugger.ConsoleAlignment get_Alignment()
  System.Void set_Alignment(SRDebugger.ConsoleAlignment value)
  System.Void Load()
  System.Void CheckTrigger()
END_CLASS

CLASS: SRDebugger.Services.Implementation.KeyboardShortcutListenerService
TYPE:  class
TOKEN: 0x200007F
EXTENDS: SRServiceBase`1
FIELDS:
  private           System.Collections.Generic.List<SRDebugger.Settings.KeyboardShortcut>_shortcuts  // 0x48
METHODS:
  System.Void Awake()
  System.Void ToggleTab(SRDebugger.DefaultTabs t)
  System.Void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut)
  System.Void Update()
  System.Void UpdateInputSystem()
  System.Void UpdateLegacyInputSystem()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.OptionsServiceImpl
TYPE:  class
TOKEN: 0x2000080
FIELDS:
  private           System.EventHandler             OptionsUpdated  // 0x10
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,System.Collections.Generic.List<SRDebugger.OptionDefinition>>_optionContainerLookup  // 0x18
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,SRDebugger.Services.Implementation.OptionsServiceImpl.OptionContainerEventHandler>_optionContainerEventHandlerLookup  // 0x20
  private   readonly System.Collections.Generic.List<SRDebugger.OptionDefinition>_options  // 0x28
  private   readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition>_optionsReadonly  // 0x30
METHODS:
  System.Void add_OptionsUpdated(System.EventHandler value)
  System.Void remove_OptionsUpdated(System.EventHandler value)
  System.Collections.Generic.ICollection<SRDebugger.OptionDefinition> get_Options()
  System.Void OptionsContainerOnOptionAdded(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition)
  System.Void OptionsContainerOnOptionRemoved(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition)
  System.Void .ctor()
  System.Void Scan(System.Object obj)
  System.Void AddContainer(System.Object obj)
  System.Void AddContainer(SRDebugger.IOptionContainer optionContainer)
  System.Void RemoveContainer(System.Object obj)
  System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer)
  System.Void OnOptionsUpdated()
END_CLASS

CLASS: SRDebugger.Services.Implementation.PinEntryServiceImpl
TYPE:  class
TOKEN: 0x2000083
EXTENDS: SRServiceBase`1
FIELDS:
  private           SRDebugger.Services.PinEntryCompleteCallback_callback  // 0x48
  private           System.Boolean                  _isVisible  // 0x50
  private           SRDebugger.UI.Controls.PinEntryControl_pinControl  // 0x58
  private   readonly System.Collections.Generic.List<System.Int32>_requiredPin  // 0x60
METHODS:
  System.Boolean get_IsShowingKeypad()
  System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel)
  System.Void Awake()
  System.Void Load()
  System.Void PinControlOnComplete(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel)
  System.Void VerifyPin(System.Collections.Generic.IReadOnlyList<System.Int32> pin)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.PinnedUIServiceImpl
TYPE:  class
TOKEN: 0x2000084
EXTENDS: SRServiceBase`1
FIELDS:
  private   readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>_controlList  // 0x48
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase>_pinnedObjects  // 0x50
  private           System.Boolean                  _queueRefresh  // 0x58
  private           SRDebugger.UI.Other.PinnedUIRoot_uiRoot  // 0x60
  private           System.Action<SRDebugger.OptionDefinition,System.Boolean>OptionPinStateChanged  // 0x68
  private           System.Action<UnityEngine.RectTransform>OptionsCanvasCreated  // 0x70
METHODS:
  SRDebugger.UI.Other.DockConsoleController get_DockConsoleController()
  System.Void add_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value)
  System.Void remove_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value)
  System.Void add_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value)
  System.Void remove_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value)
  System.Boolean get_IsProfilerPinned()
  System.Void set_IsProfilerPinned(System.Boolean value)
  System.Void Pin(SRDebugger.OptionDefinition obj, System.Int32 order)
  System.Void Unpin(SRDebugger.OptionDefinition obj)
  System.Void OnPinnedStateChanged(SRDebugger.OptionDefinition option, System.Boolean isPinned)
  System.Void UnpinAll()
  System.Boolean HasPinned(SRDebugger.OptionDefinition option)
  System.Void Awake()
  System.Void Load()
  System.Void UpdateAnchors()
  System.Void Update()
  System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs)
  System.Void OnDebugPanelVisibilityChanged(System.Boolean isVisible)
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.SRDebugService
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  private           SRDebugger.VisibilityChangedDelegatePanelVisibilityChanged  // 0x10
  private           SRDebugger.PinnedUiCanvasCreatedPinnedUiCanvasCreated  // 0x18
  private   readonly SRDebugger.Services.IDebugPanelService_debugPanelService  // 0x20
  private   readonly SRDebugger.Services.IDebugTriggerService_debugTrigger  // 0x28
  private   readonly SRDebugger.Services.ISystemInformationService_informationService  // 0x30
  private   readonly SRDebugger.Services.IOptionsService_optionsService  // 0x38
  private   readonly SRDebugger.Services.IPinnedUIService_pinnedUiService  // 0x40
  private           SRDebugger.Services.IConsoleFilterState_consoleFilterState  // 0x48
  private           System.Nullable<SRDebugger.EntryCode>_entryCode  // 0x50
  private           System.Boolean                  _hasAuthorised  // 0x64
  private           System.Nullable<SRDebugger.DefaultTabs>_queuedTab  // 0x68
  private           UnityEngine.RectTransform       _worldSpaceTransform  // 0x70
  private           SRDebugger.DynamicOptionContainer_looseOptionContainer  // 0x78
METHODS:
  SRDebugger.Services.IDockConsoleService get_DockConsole()
  SRDebugger.Services.IConsoleFilterState get_ConsoleFilter()
  System.Void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
  System.Void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
  System.Void add_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value)
  System.Void remove_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value)
  System.Void .ctor()
  SRDebugger.Settings get_Settings()
  System.Boolean get_IsDebugPanelVisible()
  System.Boolean get_IsTriggerEnabled()
  System.Void set_IsTriggerEnabled(System.Boolean value)
  System.Boolean get_IsTriggerErrorNotificationEnabled()
  System.Void set_IsTriggerErrorNotificationEnabled(System.Boolean value)
  System.Boolean get_IsProfilerDocked()
  System.Void set_IsProfilerDocked(System.Boolean value)
  System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category)
  System.Void ShowDebugPanel(System.Boolean requireEntryCode)
  System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode)
  System.Void HideDebugPanel()
  System.Void SetEntryCode(SRDebugger.EntryCode newCode)
  System.Void DisableEntryCode()
  System.Void DestroyDebugPanel()
  System.Void AddOptionContainer(System.Object container)
  System.Void RemoveOptionContainer(System.Object container)
  System.Void AddOption(SRDebugger.OptionDefinition option)
  System.Boolean RemoveOption(SRDebugger.OptionDefinition option)
  System.Void PinAllOptions(System.String category)
  System.Void UnpinAllOptions(System.String category)
  System.Void PinOption(System.String name)
  System.Void UnpinOption(System.String name)
  System.Void ClearPinnedOptions()
  System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent)
  System.Void DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b)
  System.Void PromptEntryCode()
  UnityEngine.RectTransform EnableWorldSpaceMode()
  System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler)
  System.Void <.ctor>b__21_0(UnityEngine.RectTransform transform)
  System.Void <PromptEntryCode>b__53_0(System.Boolean entered)
END_CLASS

CLASS: SRDebugger.Services.Implementation.StandardConsoleService
TYPE:  class
TOKEN: 0x2000087
FIELDS:
  private   readonly System.Boolean                  _collapseEnabled  // 0x10
  private           System.Boolean                  _hasCleared  // 0x11
  private   readonly SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry>_allConsoleEntries  // 0x18
  private           SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry>_consoleEntries  // 0x20
  private   readonly System.Object                   _threadLock  // 0x28
  private           UnityEngine.ILogHandler         _expectedLogHandler  // 0x30
  private           System.Int32                    <CriticalCount>k__BackingField  // 0x38
  private           System.Int32                    <ErrorCount>k__BackingField  // 0x3C
  private           System.Int32                    <WarningCount>k__BackingField  // 0x40
  private           System.Int32                    <InfoCount>k__BackingField  // 0x44
  private           SRDebugger.Services.ConsoleUpdatedEventHandlerUpdated  // 0x48
  private           SRDebugger.Services.ConsoleUpdatedEventHandlerError  // 0x50
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Int32 get_CriticalCount()
  System.Void set_CriticalCount(System.Int32 value)
  System.Int32 get_ErrorCount()
  System.Void set_ErrorCount(System.Int32 value)
  System.Int32 get_WarningCount()
  System.Void set_WarningCount(System.Int32 value)
  System.Int32 get_InfoCount()
  System.Void set_InfoCount(System.Int32 value)
  System.Void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Void add_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Void remove_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value)
  System.Boolean get_LoggingEnabled()
  System.Void set_LoggingEnabled(System.Boolean value)
  System.Boolean get_LogHandlerIsOverriden()
  System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries()
  System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries()
  System.Void Clear()
  System.Void OnEntryAdded(SRDebugger.Services.ConsoleEntry entry)
  System.Void OnEntryDuplicated(SRDebugger.Services.ConsoleEntry entry)
  System.Void OnUpdated()
  System.Void UnityLogCallback(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.Void AdjustCounter(UnityEngine.LogType type, System.Int32 amount)
END_CLASS

CLASS: SRDebugger.Services.Implementation.StandardSystemInformationService
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.IList<SRDebugger.InfoEntry>>_info  // 0x10
METHODS:
  System.Void .ctor()
  System.Collections.Generic.IEnumerable<System.String> GetCategories()
  System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category)
  System.Void Add(SRDebugger.InfoEntry info, System.String category)
  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate)
  System.Void CreateDefaultSet()
  System.String GetCloudManifestPrettyName(System.String name)
END_CLASS

CLASS: SRDebugger.UI.ProfilerFPSLabel
TYPE:  class
TOKEN: 0x2000024
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _nextUpdate  // 0x48
  private           SRDebugger.Services.IProfilerService_profilerService  // 0x50
  public            System.Single                   UpdateFrequency  // 0x58
  private           UnityEngine.UI.Text             _text  // 0x60
METHODS:
  System.Void Update()
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.DebugPanelRoot
TYPE:  class
TOKEN: 0x2000025
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Canvas              Canvas  // 0x48
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x50
  public            SRDebugger.Scripts.DebuggerTabControllerTabController  // 0x58
METHODS:
  System.Void Close()
  System.Void CloseAndDestroy()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.MobileMenuController
TYPE:  class
TOKEN: 0x2000026
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           UnityEngine.UI.Button           _closeButton  // 0x48
  private           System.Single                   _maxMenuWidth  // 0x50
  private           System.Single                   _peekAmount  // 0x54
  private           System.Single                   _targetXPosition  // 0x58
  public            UnityEngine.RectTransform       Content  // 0x60
  public            UnityEngine.RectTransform       Menu  // 0x68
  public            UnityEngine.UI.Button           OpenButton  // 0x70
  public            SRDebugger.UI.Other.SRTabControllerTabController  // 0x78
METHODS:
  System.Single get_PeekAmount()
  System.Single get_MaxMenuWidth()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void CreateCloseButton()
  System.Void SetRectSize(UnityEngine.RectTransform rect)
  System.Void CloseButtonClicked()
  System.Void Update()
  System.Void TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab)
  System.Void Open()
  System.Void Close()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ConsoleEntryView
TYPE:  class
TOKEN: 0x2000048
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public    static  System.String                   ConsoleBlobInfo  // 0x0
  public    static  System.String                   ConsoleBlobWarning  // 0x0
  public    static  System.String                   ConsoleBlobError  // 0x0
  public    static  System.String                   ConsoleBlobCritical  // 0x0
  private           System.Int32                    _count  // 0x48
  private           System.Boolean                  _hasCount  // 0x4C
  private           SRDebugger.Services.ConsoleEntry_prevData  // 0x50
  private           UnityEngine.RectTransform       _rectTransform  // 0x58
  public            UnityEngine.UI.Text             Count  // 0x60
  public            UnityEngine.CanvasGroup         CountContainer  // 0x68
  public            SRF.UI.StyleComponent           ImageStyle  // 0x70
  public            UnityEngine.UI.Text             Message  // 0x78
  public            UnityEngine.UI.Text             StackTrace  // 0x80
METHODS:
  System.Void SetDataContext(System.Object data)
  System.Void Awake()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ConsoleLogControl
TYPE:  class
TOKEN: 0x2000049
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           SRF.UI.Layout.VirtualVerticalLayoutGroup_consoleScrollLayoutGroup  // 0x48
  private           UnityEngine.UI.ScrollRect       _consoleScrollRect  // 0x50
  private           System.Boolean                  _isDirty  // 0x58
  private           System.Nullable<UnityEngine.Vector2>_scrollPosition  // 0x5C
  private           System.Boolean                  _showCriticals  // 0x68
  private           System.Boolean                  _showErrors  // 0x69
  private           System.Boolean                  _showInfo  // 0x6A
  private           System.Boolean                  _showWarnings  // 0x6B
  public            System.Action<SRDebugger.Services.ConsoleEntry>SelectedItemChanged  // 0x70
  private           System.String                   _filter  // 0x78
METHODS:
  System.Boolean get_ShowCriticals()
  System.Void set_ShowCriticals(System.Boolean value)
  System.Boolean get_ShowErrors()
  System.Void set_ShowErrors(System.Boolean value)
  System.Boolean get_ShowWarnings()
  System.Void set_ShowWarnings(System.Boolean value)
  System.Boolean get_ShowInfo()
  System.Void set_ShowInfo(System.Boolean value)
  System.Boolean get_EnableSelection()
  System.Void set_EnableSelection(System.Boolean value)
  System.String get_Filter()
  System.Void set_Filter(System.String value)
  System.Void Awake()
  System.Void Start()
  System.Collections.IEnumerator ScrollToBottom()
  System.Void OnDestroy()
  System.Void OnSelectedItemChanged(System.Object arg0)
  System.Void Update()
  System.Void Refresh()
  System.Void SetIsDirty()
  System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.DataBoundControl
TYPE:  class
TOKEN: 0x200004B
EXTENDS: OptionsControlBase
FIELDS:
  private           System.Boolean                  _hasStarted  // 0x60
  private           System.Boolean                  _isReadOnly  // 0x61
  private           System.Object                   _prevValue  // 0x68
  private           SRF.Helpers.PropertyReference   _prop  // 0x70
  private           System.String                   <PropertyName>k__BackingField  // 0x78
METHODS:
  SRF.Helpers.PropertyReference get_Property()
  System.Boolean get_IsReadOnly()
  System.String get_PropertyName()
  System.Void set_PropertyName(System.String value)
  System.Void Bind(System.String propertyName, SRF.Helpers.PropertyReference prop)
  System.Void OnValueChanged(SRF.Helpers.PropertyReference property)
  System.Void UpdateValue(System.Object newValue)
  System.Void Refresh()
  System.Void OnBind(System.String propertyName, System.Type t)
  System.Void OnValueUpdated(System.Object newValue)
  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.OptionsControlBase
TYPE:  class
TOKEN: 0x200004C
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _selectionModeEnabled  // 0x48
  public            UnityEngine.UI.Toggle           SelectionModeToggle  // 0x50
  public            SRDebugger.OptionDefinition     Option  // 0x58
METHODS:
  System.Boolean get_SelectionModeEnabled()
  System.Void set_SelectionModeEnabled(System.Boolean value)
  System.Boolean get_IsSelected()
  System.Void set_IsSelected(System.Boolean value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.InfoBlock
TYPE:  class
TOKEN: 0x200004D
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.UI.Text             Content  // 0x48
  public            UnityEngine.UI.Text             Title  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.MultiTapButton
TYPE:  class
TOKEN: 0x200004E
EXTENDS: Button
FIELDS:
  private           System.Single                   _lastTap  // 0x188
  private           System.Int32                    _tapCount  // 0x18C
  public            System.Int32                    RequiredTapCount  // 0x190
  public            System.Single                   ResetTime  // 0x194
METHODS:
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.PinEntryControlCallback
TYPE:  class
TOKEN: 0x200004F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel)
  System.IAsyncResult BeginInvoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.UI.Controls.PinEntryControl
TYPE:  class
TOKEN: 0x2000050
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _isVisible  // 0x48
  private           System.Collections.Generic.List<System.Int32>_numbers  // 0x50
  public            UnityEngine.UI.Image            Background  // 0x58
  public            System.Boolean                  CanCancel  // 0x60
  public            UnityEngine.UI.Button           CancelButton  // 0x68
  public            UnityEngine.UI.Text             CancelButtonText  // 0x70
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x78
  public            UnityEngine.Animator            DotAnimator  // 0x80
  public            UnityEngine.UI.Button[]         NumberButtons  // 0x88
  public            UnityEngine.UI.Toggle[]         NumberDots  // 0x90
  public            UnityEngine.UI.Text             PromptText  // 0x98
  private           SRDebugger.UI.Controls.PinEntryControlCallbackComplete  // 0xA0
METHODS:
  System.Void add_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value)
  System.Void remove_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void HandleCharacter(System.Char i)
  System.Void Show()
  System.Void Hide()
  System.Void Clear()
  System.Void PlayInvalidCodeAnimation()
  System.Void OnComplete()
  System.Void OnCancel()
  System.Void CancelButtonPressed()
  System.Void PushNumber(System.Int32 number)
  System.Void RefreshState()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerMemoryBlock
TYPE:  class
TOKEN: 0x2000052
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _lastRefresh  // 0x48
  public            UnityEngine.UI.Text             CurrentUsedText  // 0x50
  public            UnityEngine.UI.Slider           Slider  // 0x58
  public            UnityEngine.UI.Text             TotalAllocatedText  // 0x60
METHODS:
  System.Void OnEnable()
  System.Void Update()
  System.Void TriggerRefresh()
  System.Void TriggerCleanup()
  System.Collections.IEnumerator CleanUp()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerMonoBlock
TYPE:  class
TOKEN: 0x2000054
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _lastRefresh  // 0x48
  public            UnityEngine.UI.Text             CurrentUsedText  // 0x50
  public            UnityEngine.GameObject          NotSupportedMessage  // 0x58
  public            UnityEngine.UI.Slider           Slider  // 0x60
  public            UnityEngine.UI.Text             TotalAllocatedText  // 0x68
  private           System.Boolean                  _isSupported  // 0x70
METHODS:
  System.Void OnEnable()
  System.Void Update()
  System.Void TriggerRefresh()
  System.Void TriggerCollection()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerEnableControl
TYPE:  class
TOKEN: 0x2000055
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _previousState  // 0x48
  public            UnityEngine.UI.Text             ButtonText  // 0x50
  public            UnityEngine.UI.Button           EnableButton  // 0x58
  public            UnityEngine.UI.Text             Text  // 0x60
METHODS:
  System.Void Start()
  System.Void UpdateLabels()
  System.Void Update()
  System.Void ToggleProfiler()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerGraphAxisLabel
TYPE:  class
TOKEN: 0x2000056
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _prevFrameTime  // 0x48
  private           System.Nullable<System.Single>  _queuedFrameTime  // 0x4C
  private           System.Single                   _yPosition  // 0x54
  public            UnityEngine.UI.Text             Text  // 0x58
METHODS:
  System.Void Update()
  System.Void SetValue(System.Single frameTime, System.Single yPosition)
  System.Void SetValueInternal(System.Single frameTime)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerGraphControl
TYPE:  class
TOKEN: 0x2000057
EXTENDS: Graphic
FIELDS:
  public            SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignmentsVerticalAlignment  // 0xB0
  private   static readonly System.Single[]                 ScaleSteps  // 0x0
  public            System.Boolean                  FloatingScale  // 0xB4
  public            System.Boolean                  TargetFpsUseApplication  // 0xB5
  public            System.Boolean                  DrawAxes  // 0xB6
  public            System.Int32                    TargetFps  // 0xB8
  public            System.Boolean                  Clip  // 0xBC
  public    static  System.Single                   DataPointMargin  // 0x0
  public    static  System.Single                   DataPointVerticalMargin  // 0x0
  public    static  System.Single                   DataPointWidth  // 0x0
  public            System.Int32                    VerticalPadding  // 0xC0
  public    static  System.Int32                    LineCount  // 0x0
  public            UnityEngine.Color[]             LineColours  // 0xC8
  private           SRDebugger.Services.IProfilerService_profilerService  // 0xD0
  private           SRDebugger.UI.Controls.ProfilerGraphAxisLabel[]_axisLabels  // 0xD8
  private           UnityEngine.Rect                _clipBounds  // 0xE0
  private   readonly System.Collections.Generic.List<UnityEngine.Vector3>_meshVertices  // 0xF0
  private   readonly System.Collections.Generic.List<UnityEngine.Color32>_meshVertexColors  // 0xF8
  private   readonly System.Collections.Generic.List<System.Int32>_meshTriangles  // 0x100
METHODS:
  System.Void Awake()
  System.Void Start()
  System.Void Update()
  System.Void OnPopulateMesh(UnityEngine.Mesh m)
  System.Void DrawDataPoint(System.Single xPosition, System.Single verticalScale, SRDebugger.Services.ProfilerFrame frame)
  System.Void DrawAxis(System.Single frameTime, System.Single yPosition, SRDebugger.UI.Controls.ProfilerGraphAxisLabel label)
  System.Void AddRect(UnityEngine.Vector3 tl, UnityEngine.Vector3 tr, UnityEngine.Vector3 bl, UnityEngine.Vector3 br, UnityEngine.Color c)
  SRDebugger.Services.ProfilerFrame GetFrame(System.Int32 i)
  System.Int32 CalculateVisibleDataPointCount()
  System.Int32 GetFrameBufferCurrentSize()
  System.Int32 GetFrameBufferMaxSize()
  System.Single CalculateMaxFrameTime()
  SRDebugger.UI.Controls.ProfilerGraphAxisLabel GetAxisLabel(System.Int32 index)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.SRTabButton
TYPE:  class
TOKEN: 0x2000059
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Behaviour           ActiveToggle  // 0x48
  public            UnityEngine.UI.Button           Button  // 0x50
  public            UnityEngine.RectTransform       ExtraContentContainer  // 0x58
  public            SRF.UI.StyleComponent           IconStyleComponent  // 0x60
  public            UnityEngine.UI.Text             TitleText  // 0x68
METHODS:
  System.Boolean get_IsActive()
  System.Void set_IsActive(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.ActionControl
TYPE:  class
TOKEN: 0x200005A
EXTENDS: OptionsControlBase
FIELDS:
  private           SRF.Helpers.MethodReference     _method  // 0x60
  public            UnityEngine.UI.Button           Button  // 0x68
  public            UnityEngine.UI.Text             Title  // 0x70
METHODS:
  SRF.Helpers.MethodReference get_Method()
  System.Void Start()
  System.Void ButtonOnClick()
  System.Void SetMethod(System.String methodName, SRF.Helpers.MethodReference method)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.BoolControl
TYPE:  class
TOKEN: 0x200005B
EXTENDS: DataBoundControl
FIELDS:
  public            UnityEngine.UI.Text             Title  // 0x80
  public            UnityEngine.UI.Toggle           Toggle  // 0x88
METHODS:
  System.Void Start()
  System.Void ToggleOnValueChanged(System.Boolean isOn)
  System.Void OnBind(System.String propertyName, System.Type t)
  System.Void OnValueUpdated(System.Object newValue)
  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.EnumControl
TYPE:  class
TOKEN: 0x200005C
EXTENDS: DataBoundControl
FIELDS:
  private           System.Object                   _lastValue  // 0x80
  private           System.String[]                 _names  // 0x88
  private           System.Array                    _values  // 0x90
  public            UnityEngine.UI.LayoutElement    ContentLayoutElement  // 0x98
  public            UnityEngine.GameObject[]        DisableOnReadOnly  // 0xA0
  public            SRF.UI.SRSpinner                Spinner  // 0xA8
  public            UnityEngine.UI.Text             Title  // 0xB0
  public            UnityEngine.UI.Text             Value  // 0xB8
METHODS:
  System.Void Start()
  System.Void OnBind(System.String propertyName, System.Type t)
  System.Void OnValueUpdated(System.Object newValue)
  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  System.Void SetIndex(System.Int32 i)
  System.Void GoToNext()
  System.Void GoToPrevious()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.NumberControl
TYPE:  class
TOKEN: 0x200005D
EXTENDS: DataBoundControl
FIELDS:
  private   static readonly System.Type[]                   IntegerTypes  // 0x0
  private   static readonly System.Type[]                   DecimalTypes  // 0x8
  public    static readonly System.Collections.Generic.Dictionary<System.Type,SRDebugger.UI.Controls.Data.NumberControl.ValueRange>ValueRanges  // 0x10
  private           System.String                   _lastValue  // 0x80
  private           System.Type                     _type  // 0x88
  public            UnityEngine.GameObject[]        DisableOnReadOnly  // 0x90
  public            SRF.UI.SRNumberButton           DownNumberButton  // 0x98
  public            SRF.UI.SRNumberSpinner          NumberSpinner  // 0xA0
  public            UnityEngine.UI.Text             Title  // 0xA8
  public            SRF.UI.SRNumberButton           UpNumberButton  // 0xB0
METHODS:
  System.Void Start()
  System.Void OnValueChanged(System.String newValue)
  System.Void OnBind(System.String propertyName, System.Type t)
  System.Void OnValueUpdated(System.Object newValue)
  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  System.Boolean IsIntegerType(System.Type t)
  System.Boolean IsDecimalType(System.Type t)
  System.Double GetMaxValue(System.Type t)
  System.Double GetMinValue(System.Type t)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.ReadOnlyControl
TYPE:  class
TOKEN: 0x200005F
EXTENDS: DataBoundControl
FIELDS:
  public            UnityEngine.UI.Text             ValueText  // 0x80
  public            UnityEngine.UI.Text             Title  // 0x88
METHODS:
  System.Void Start()
  System.Void OnBind(System.String propertyName, System.Type t)
  System.Void OnValueUpdated(System.Object newValue)
  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.StringControl
TYPE:  class
TOKEN: 0x2000060
EXTENDS: DataBoundControl
FIELDS:
  public            UnityEngine.UI.InputField       InputField  // 0x80
  public            UnityEngine.UI.Text             Title  // 0x88
METHODS:
  System.Void Start()
  System.Void OnValueChanged(System.String newValue)
  System.Void OnBind(System.String propertyName, System.Type t)
  System.Void OnValueUpdated(System.Object newValue)
  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.BugReportPopoverRoot
TYPE:  class
TOKEN: 0x2000031
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x48
  public            UnityEngine.RectTransform       Container  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.BugReportSheetController
TYPE:  class
TOKEN: 0x2000032
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.GameObject          ButtonContainer  // 0x48
  public            UnityEngine.UI.Text             ButtonText  // 0x50
  public            UnityEngine.UI.Button           CancelButton  // 0x58
  public            System.Action                   CancelPressed  // 0x60
  public            UnityEngine.UI.InputField       DescriptionField  // 0x68
  public            UnityEngine.UI.InputField       EmailField  // 0x70
  public            UnityEngine.UI.Slider           ProgressBar  // 0x78
  public            UnityEngine.UI.Text             ResultMessageText  // 0x80
  public            System.Action                   ScreenshotComplete  // 0x88
  public            UnityEngine.UI.Button           SubmitButton  // 0x90
  public            System.Action<System.Boolean,System.String>SubmitComplete  // 0x98
  public            System.Action                   TakingScreenshot  // 0xA0
METHODS:
  System.Boolean get_IsCancelButtonEnabled()
  System.Void set_IsCancelButtonEnabled(System.Boolean value)
  System.Void Start()
  System.Void Submit()
  System.Void Cancel()
  System.Collections.IEnumerator SubmitCo()
  System.Void OnBugReportProgress(System.Single progress)
  System.Void OnBugReportComplete(System.Boolean didSucceed, System.String errorMessage)
  System.Void SetLoadingSpinnerVisible(System.Boolean visible)
  System.Void ClearForm()
  System.Void ShowErrorMessage(System.String userMessage, System.String serverMessage)
  System.Void ClearErrorMessage()
  System.Void SetFormEnabled(System.Boolean e)
  System.String GetDefaultEmailFieldContents()
  System.Void SetDefaultEmailFieldContents(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.CategoryGroup
TYPE:  class
TOKEN: 0x2000034
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.RectTransform       Container  // 0x48
  public            UnityEngine.UI.Text             Header  // 0x50
  public            UnityEngine.GameObject          Background  // 0x58
  public            UnityEngine.UI.Toggle           SelectionToggle  // 0x60
  public            UnityEngine.GameObject[]        EnabledDuringSelectionMode  // 0x68
  private           System.Boolean                  _selectionModeEnabled  // 0x70
METHODS:
  System.Boolean get_IsSelected()
  System.Void set_IsSelected(System.Boolean value)
  System.Boolean get_SelectionModeEnabled()
  System.Void set_SelectionModeEnabled(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.ConfigureCanvasFromSettings
TYPE:  class
TOKEN: 0x2000035
EXTENDS: SRMonoBehaviour
FIELDS:
  private           UnityEngine.Canvas              _canvas  // 0x48
  private           UnityEngine.UI.CanvasScaler     _canvasScaler  // 0x50
  private           System.Single                   _originalScale  // 0x58
  private           System.Single                   _lastSetScale  // 0x5C
  private           SRDebugger.Settings             _settings  // 0x60
METHODS:
  System.Void Start()
  System.Void OnDestroy()
  System.Void SettingsOnPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.ConsoleTabQuickViewControl
TYPE:  class
TOKEN: 0x2000036
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private   static  System.Int32                    Max  // 0x0
  private   static readonly System.String                   MaxString  // 0x0
  private           System.Int32                    _prevCriticalCount  // 0x48
  private           System.Int32                    _prevErrorCount  // 0x4C
  private           System.Int32                    _prevInfoCount  // 0x50
  private           System.Int32                    _prevWarningCount  // 0x54
  public            SRDebugger.Services.IConsoleServiceConsoleService  // 0x58
  public            UnityEngine.UI.Text             CriticalCountText  // 0x60
  public            UnityEngine.UI.Text             ErrorCountText  // 0x68
  public            UnityEngine.UI.Text             InfoCountText  // 0x70
  public            UnityEngine.UI.Text             WarningCountText  // 0x78
METHODS:
  System.Void Awake()
  System.Void Update()
  System.Boolean HasChanged(System.Int32 newCount, System.Int32& oldCount, System.Int32 max)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.UI.Other.DebugPanelBackgroundBehaviour
TYPE:  class
TOKEN: 0x2000037
EXTENDS: SRMonoBehaviour
FIELDS:
  private           SRF.UI.StyleComponent           _styleComponent  // 0x48
  public            System.String                   TransparentStyleKey  // 0x50
  private           SRF.UI.StyleSheet               _styleSheet  // 0x58
METHODS:
  System.Void Awake()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.DockConsoleController
TYPE:  class
TOKEN: 0x2000038
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public    static  System.Single                   NonFocusOpacity  // 0x0
  private           System.Boolean                  _isDirty  // 0x48
  private           System.Boolean                  _isDragging  // 0x49
  private           System.Int32                    _pointersOver  // 0x4C
  public            SRDebugger.Services.IConsoleFilterStateFilterState  // 0x50
  public            UnityEngine.GameObject          BottomHandle  // 0x58
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x60
  public            SRDebugger.UI.Controls.ConsoleLogControlConsole  // 0x68
  public            UnityEngine.GameObject          Dropdown  // 0x70
  public            UnityEngine.UI.Image            DropdownToggleSprite  // 0x78
  public            UnityEngine.UI.Text             TextCriticals  // 0x80
  public            UnityEngine.UI.Text             TextErrors  // 0x88
  public            UnityEngine.UI.Text             TextInfo  // 0x90
  public            UnityEngine.UI.Text             TextWarnings  // 0x98
  public            UnityEngine.UI.Toggle           ToggleCriticals  // 0xA0
  public            UnityEngine.UI.Toggle           ToggleErrors  // 0xA8
  public            UnityEngine.UI.Toggle           ToggleInfo  // 0xB0
  public            UnityEngine.UI.Toggle           ToggleWarnings  // 0xB8
  public            UnityEngine.GameObject          TopBar  // 0xC0
  public            UnityEngine.GameObject          TopHandle  // 0xC8
  public            UnityEngine.GameObject          TopSafeAreaSpacer  // 0xD0
  public            UnityEngine.GameObject          BottomSafeAreaSpacer  // 0xD8
METHODS:
  System.Boolean get_IsVisible()
  System.Void set_IsVisible(System.Boolean value)
  System.Void Start()
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void OnFilterStateChange(UnityEngine.LogType logType, System.Boolean newState)
  System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
  System.Void SetDropdownVisibility(System.Boolean visible)
  System.Void SetAlignmentMode(SRDebugger.ConsoleAlignment alignment)
  System.Void Refresh()
  System.Void RefreshAlpha()
  System.Void ToggleDropdownVisible()
  System.Void MenuButtonPressed()
  System.Void ClearButtonPressed()
  System.Void TogglesUpdated()
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData e)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData e)
  System.Void OnBeginDrag()
  System.Void OnEndDrag()
  System.Void .ctor()
  System.Void <Start>b__25_0(System.Boolean isOn)
  System.Void <Start>b__25_1(System.Boolean isOn)
  System.Void <Start>b__25_2(System.Boolean isOn)
  System.Void <Start>b__25_3(System.Boolean isOn)
END_CLASS

CLASS: SRDebugger.UI.Other.ErrorNotifier
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Single                   DisplayTime  // 0x0
  private           UnityEngine.Animator            _animator  // 0x18
  private           System.Int32                    _triggerHash  // 0x20
  private           System.Single                   _hideTime  // 0x24
  private           System.Boolean                  _isShowing  // 0x28
  private           System.Boolean                  _queueWarning  // 0x29
METHODS:
  System.Boolean get_IsVisible()
  System.Void Awake()
  System.Void ShowErrorWarning()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.FloatOverElement
TYPE:  class
TOKEN: 0x200003A
EXTENDS: UIBehaviour
FIELDS:
  public            UnityEngine.RectTransform       CopyFrom  // 0x18
  private           UnityEngine.DrivenRectTransformTracker_tracker  // 0x20
METHODS:
  System.Void Copy()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.HandleManager
TYPE:  class
TOKEN: 0x200003B
EXTENDS: SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _hasSet  // 0x48
  public            UnityEngine.GameObject          BottomHandle  // 0x50
  public            UnityEngine.GameObject          BottomLeftHandle  // 0x58
  public            UnityEngine.GameObject          BottomRightHandle  // 0x60
  public            SRDebugger.PinAlignment         DefaultAlignment  // 0x68
  public            UnityEngine.GameObject          LeftHandle  // 0x70
  public            UnityEngine.GameObject          RightHandle  // 0x78
  public            UnityEngine.GameObject          TopHandle  // 0x80
  public            UnityEngine.GameObject          TopLeftHandle  // 0x88
  public            UnityEngine.GameObject          TopRightHandle  // 0x90
METHODS:
  System.Void Start()
  System.Void SetAlignment(SRDebugger.PinAlignment alignment)
  System.Void SetActive(UnityEngine.GameObject obj, System.Boolean active)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.IEnableTab
TYPE:  interface
TOKEN: 0x200003C
FIELDS:
METHODS:
  System.Boolean get_IsEnabled()
END_CLASS

CLASS: SRDebugger.UI.Other.LoadingSpinnerBehaviour
TYPE:  class
TOKEN: 0x200003D
EXTENDS: SRMonoBehaviour
FIELDS:
  private           System.Single                   _dt  // 0x48
  public            System.Int32                    FrameCount  // 0x4C
  public            System.Single                   SpinDuration  // 0x50
METHODS:
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.PinnedUIRoot
TYPE:  class
TOKEN: 0x200003E
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Canvas              Canvas  // 0x48
  public            UnityEngine.RectTransform       Container  // 0x50
  public            SRDebugger.UI.Other.DockConsoleControllerDockConsoleController  // 0x58
  public            UnityEngine.GameObject          Options  // 0x60
  public            SRF.UI.Layout.FlowLayoutGroup   OptionsLayoutGroup  // 0x68
  public            UnityEngine.GameObject          Profiler  // 0x70
  public            SRDebugger.UI.Other.HandleManagerProfilerHandleManager  // 0x78
  public            UnityEngine.UI.VerticalLayoutGroupProfilerVerticalLayoutGroup  // 0x80
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SafeAreaSizer
TYPE:  class
TOKEN: 0x200003F
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.RectTransform.Edge  _edge  // 0x18
  public            System.Single                   Scale  // 0x1C
  private           System.Single                   _height  // 0x20
  private           System.Single                   _width  // 0x24
METHODS:
  UnityEngine.RectTransform.Edge get_Edge()
  System.Void set_Edge(UnityEngine.RectTransform.Edge value)
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Single get_minWidth()
  System.Single get_minHeight()
  System.Int32 get_layoutPriority()
  System.Single get_flexibleHeight()
  System.Single get_flexibleWidth()
  System.Void Refresh()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.ScrollSettingsBehaviour
TYPE:  class
TOKEN: 0x2000040
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.Single                   ScrollSensitivity  // 0x0
METHODS:
  System.Void Awake()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SetLayerFromSettings
TYPE:  class
TOKEN: 0x2000041
EXTENDS: SRMonoBehaviour
FIELDS:
METHODS:
  System.Void Start()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SRTab
TYPE:  class
TOKEN: 0x2000042
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.RectTransform       HeaderExtraContent  // 0x48
  public            UnityEngine.Sprite              Icon  // 0x50
  public            UnityEngine.RectTransform       IconExtraContent  // 0x58
  public            System.String                   IconStyleKey  // 0x60
  public            System.Int32                    SortIndex  // 0x68
  public            SRDebugger.UI.Controls.SRTabButtonTabButton  // 0x70
  private           System.String                   _title  // 0x78
  private           System.String                   _longTitle  // 0x80
  private           System.String                   _key  // 0x88
METHODS:
  System.String get_Title()
  System.String get_LongTitle()
  System.String get_Key()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SRTabController
TYPE:  class
TOKEN: 0x2000043
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private   readonly SRF.SRList<SRDebugger.UI.Other.SRTab>_tabs  // 0x48
  private           SRDebugger.UI.Other.SRTab       _activeTab  // 0x50
  public            UnityEngine.RectTransform       TabButtonContainer  // 0x58
  public            SRDebugger.UI.Controls.SRTabButtonTabButtonPrefab  // 0x60
  public            UnityEngine.RectTransform       TabContentsContainer  // 0x68
  public            UnityEngine.RectTransform       TabHeaderContentContainer  // 0x70
  public            UnityEngine.UI.Text             TabHeaderText  // 0x78
  private           System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab>ActiveTabChanged  // 0x80
METHODS:
  SRDebugger.UI.Other.SRTab get_ActiveTab()
  System.Void set_ActiveTab(SRDebugger.UI.Other.SRTab value)
  System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> get_Tabs()
  System.Void add_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> value)
  System.Void remove_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> value)
  System.Void AddTab(SRDebugger.UI.Other.SRTab tab, System.Boolean visibleInSidebar)
  System.Void MakeActive(SRDebugger.UI.Other.SRTab tab)
  System.Void SortTabs()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.TriggerRoot
TYPE:  class
TOKEN: 0x2000046
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Canvas              Canvas  // 0x48
  public            SRF.UI.LongPressButton          TapHoldButton  // 0x50
  public            UnityEngine.RectTransform       TriggerTransform  // 0x58
  public            SRDebugger.UI.Other.ErrorNotifierErrorNotifier  // 0x60
  public            SRDebugger.UI.Controls.MultiTapButtonTripleTapButton  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.VersionTextBehaviour
TYPE:  class
TOKEN: 0x2000047
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            System.String                   Format  // 0x48
  public            UnityEngine.UI.Text             Text  // 0x50
METHODS:
  System.Void Start()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.BugReportTabController
TYPE:  class
TOKEN: 0x2000027
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public            SRDebugger.UI.Other.BugReportSheetControllerBugReportSheetPrefab  // 0x48
  public            UnityEngine.RectTransform       Container  // 0x50
METHODS:
  System.Boolean get_IsEnabled()
  System.Void Start()
  System.Void TakingScreenshot()
  System.Void ScreenshotComplete()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.ConsoleTabController
TYPE:  class
TOKEN: 0x2000028
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private   static  System.Int32                    MaxLength  // 0x0
  private           UnityEngine.Canvas              _consoleCanvas  // 0x48
  private           System.Boolean                  _isDirty  // 0x50
  private   static  System.Boolean                  _hasWarnedAboutLogHandler  // 0x0
  private   static  System.Boolean                  _hasWarnedAboutLoggingDisabled  // 0x1
  public            SRDebugger.Services.IConsoleFilterStateFilterState  // 0x58
  public            SRDebugger.UI.Controls.ConsoleLogControlConsoleLogControl  // 0x60
  public            UnityEngine.UI.Toggle           PinToggle  // 0x68
  public            UnityEngine.UI.ScrollRect       StackTraceScrollRect  // 0x70
  public            UnityEngine.UI.Text             StackTraceText  // 0x78
  public            UnityEngine.UI.Toggle           ToggleCriticals  // 0x80
  public            UnityEngine.UI.Text             ToggleCriticalsText  // 0x88
  public            UnityEngine.UI.Toggle           ToggleErrors  // 0x90
  public            UnityEngine.UI.Text             ToggleErrorsText  // 0x98
  public            UnityEngine.UI.Toggle           ToggleInfo  // 0xA0
  public            UnityEngine.UI.Text             ToggleInfoText  // 0xA8
  public            UnityEngine.UI.Toggle           ToggleWarnings  // 0xB0
  public            UnityEngine.UI.Text             ToggleWarningsText  // 0xB8
  public            UnityEngine.GameObject          CopyToClipboardContainer  // 0xC0
  public            UnityEngine.GameObject          CopyToClipboardButton  // 0xC8
  public            UnityEngine.GameObject          CopyToClipboardMessage  // 0xD0
  public            UnityEngine.CanvasGroup         CopyToClipboardMessageCanvasGroup  // 0xD8
  public            UnityEngine.GameObject          LoggingIsDisabledCanvasGroup  // 0xE0
  public            UnityEngine.GameObject          LogHandlerHasBeenOverridenGroup  // 0xE8
  public            UnityEngine.UI.Toggle           FilterToggle  // 0xF0
  public            UnityEngine.UI.InputField       FilterField  // 0xF8
  public            UnityEngine.GameObject          FilterBarContainer  // 0x100
  private           SRDebugger.Services.ConsoleEntry_selectedItem  // 0x108
  private           UnityEngine.Coroutine           _fadeButtonCoroutine  // 0x110
METHODS:
  System.Void Start()
  System.Void OnFilterStateChange(UnityEngine.LogType logtype, System.Boolean newstate)
  System.Void FilterToggleValueChanged(System.Boolean isOn)
  System.Void FilterValueChanged(System.String filterText)
  System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b)
  System.Void PinToggleValueChanged(System.Boolean isOn)
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void ConsoleLogSelectedItemChanged(System.Object item)
  System.Void Update()
  System.Void PopulateStackTraceArea(SRDebugger.Services.ConsoleEntry entry)
  System.Void CopyToClipboard()
  System.Void SetCopyToClipboardButtonState(SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates state)
  System.Collections.IEnumerator FadeCopyButton()
  System.Void StopAnimations()
  System.Void Refresh()
  System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
  System.Void Clear()
  System.Void LogHandlerHasBeenOverridenOkayButtonPress()
  System.Void LoggingDisableCloseAndIgnorePressed()
  System.Void LoggingDisableReenablePressed()
  System.Void .ctor()
  System.Void <Start>b__29_0(System.Boolean isOn)
  System.Void <Start>b__29_1(System.Boolean isOn)
  System.Void <Start>b__29_2(System.Boolean isOn)
  System.Void <Start>b__29_3(System.Boolean isOn)
END_CLASS

CLASS: SRDebugger.UI.Tabs.InfoTabController
TYPE:  class
TOKEN: 0x200002B
EXTENDS: SRMonoBehaviourEx
FIELDS:
  public    static  System.Char                     Tick  // 0x0
  public    static  System.Char                     Cross  // 0x0
  public    static  System.String                   NameColor  // 0x0
  private           System.Collections.Generic.Dictionary<System.String,SRDebugger.UI.Controls.InfoBlock>_infoBlocks  // 0x48
  public            SRDebugger.UI.Controls.InfoBlockInfoBlockPrefab  // 0x50
  public            UnityEngine.RectTransform       LayoutContainer  // 0x58
  public            SRF.UI.FlashGraphic             ToggleButton  // 0x60
  private           System.Boolean                  _updateEveryFrame  // 0x68
METHODS:
  System.Void OnEnable()
  System.Void Refresh()
  System.Void Update()
  System.Void ActivateRefreshEveryFrame()
  System.Void InternalRefresh()
  System.Void FillInfoBlock(SRDebugger.UI.Controls.InfoBlock block, System.Collections.Generic.IList<SRDebugger.InfoEntry> info)
  SRDebugger.UI.Controls.InfoBlock CreateBlock(System.String title)
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.OptionsTabController
TYPE:  class
TOKEN: 0x200002C
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private   readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>_controls  // 0x48
  private   readonly System.Collections.Generic.List<SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance>_categories  // 0x50
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase>_options  // 0x58
  private           System.Boolean                  _queueRefresh  // 0x60
  private           System.Boolean                  _selectionModeEnabled  // 0x61
  private           UnityEngine.Canvas              _optionCanvas  // 0x68
  public            SRDebugger.UI.Controls.Data.ActionControlActionControlPrefab  // 0x70
  public            SRDebugger.UI.Other.CategoryGroupCategoryGroupPrefab  // 0x78
  public            UnityEngine.RectTransform       ContentContainer  // 0x80
  public            UnityEngine.GameObject          NoOptionsNotice  // 0x88
  public            UnityEngine.UI.Toggle           PinButton  // 0x90
  public            UnityEngine.GameObject          PinPromptSpacer  // 0x98
  public            UnityEngine.GameObject          PinPromptText  // 0xA0
  private           System.Boolean                  _isTogglingCategory  // 0xA8
METHODS:
  System.Void Start()
  System.Void OnDestroy()
  System.Void OnOptionPinnedStateChanged(SRDebugger.OptionDefinition optionDefinition, System.Boolean isPinned)
  System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b)
  System.Void SetSelectionModeEnabled(System.Boolean isEnabled)
  System.Void Refresh()
  System.Void CommitPinnedOptions()
  System.Void RefreshCategorySelection()
  System.Void OnOptionSelectionToggle(System.Boolean selected)
  System.Void OnCategorySelectionToggle(SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance category, System.Boolean selected)
  System.Void Populate()
  System.Void CreateCategory(System.String title, System.Collections.Generic.List<SRDebugger.OptionDefinition> options)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.ProfilerTabController
TYPE:  class
TOKEN: 0x2000030
EXTENDS: SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _isDirty  // 0x48
  public            UnityEngine.UI.Toggle           PinToggle  // 0x50
METHODS:
  System.Void Start()
  System.Void PinToggleValueChanged(System.Boolean isOn)
  System.Void OnEnable()
  System.Void Update()
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

