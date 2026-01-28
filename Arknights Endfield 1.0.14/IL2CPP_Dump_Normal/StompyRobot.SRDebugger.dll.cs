// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRDebugger.dll
// Classes:  159
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SRDebug
    {
        // Fields
        public static System.String Version;        // 0x0
        private static System.Boolean <IsInitialized>k__BackingField;        // 0x0
        public static System.Action<SRDebugger.Services.ConsoleEntry> CopyConsoleItemCallback;        // 0x8

        // Methods
        private System.Boolean get_IsInitialized() { }
        private System.Void set_IsInitialized(System.Boolean value) { }
        private SRDebugger.Services.IDebugService get_Instance() { }
        private System.Void Init() { }
        private System.Action<SRDebugger.Services.ConsoleEntry> GetDefaultCopyConsoleItemCallback() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public struct ShortcutActions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.Settings.ShortcutActions None;        // 0x0
        public static SRDebugger.Settings.ShortcutActions OpenSystemInfoTab;        // 0x0
        public static SRDebugger.Settings.ShortcutActions OpenConsoleTab;        // 0x0
        public static SRDebugger.Settings.ShortcutActions OpenOptionsTab;        // 0x0
        public static SRDebugger.Settings.ShortcutActions OpenProfilerTab;        // 0x0
        public static SRDebugger.Settings.ShortcutActions OpenBugReporterTab;        // 0x0
        public static SRDebugger.Settings.ShortcutActions ClosePanel;        // 0x0
        public static SRDebugger.Settings.ShortcutActions OpenPanel;        // 0x0
        public static SRDebugger.Settings.ShortcutActions TogglePanel;        // 0x0
        public static SRDebugger.Settings.ShortcutActions ShowBugReportPopover;        // 0x0
        public static SRDebugger.Settings.ShortcutActions ToggleDockedConsole;        // 0x0
        public static SRDebugger.Settings.ShortcutActions ToggleDockedProfiler;        // 0x0

    }

    // TypeToken: 0x2000019
    public struct TriggerBehaviours
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.Settings.TriggerBehaviours TripleTap;        // 0x0
        public static SRDebugger.Settings.TriggerBehaviours TapAndHold;        // 0x0
        public static SRDebugger.Settings.TriggerBehaviours DoubleTap;        // 0x0

    }

    // TypeToken: 0x200001A
    public struct TriggerEnableModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.Settings.TriggerEnableModes Enabled;        // 0x0
        public static SRDebugger.Settings.TriggerEnableModes MobileOnly;        // 0x0
        public static SRDebugger.Settings.TriggerEnableModes Off;        // 0x0
        public static SRDebugger.Settings.TriggerEnableModes DevelopmentBuildsOnly;        // 0x0

    }

    // TypeToken: 0x200001B
    public struct UIModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.Settings.UIModes NewInputSystem;        // 0x0
        public static SRDebugger.Settings.UIModes LegacyInputSystem;        // 0x0

    }

    // TypeToken: 0x200001C
    public class KeyboardShortcut
    {
        // Fields
        public SRDebugger.Settings.ShortcutActions Action;        // 0x10
        public System.Boolean Alt;        // 0x14
        public System.Boolean Control;        // 0x15
        public UnityEngine.KeyCode Key;        // 0x18
        public System.Boolean Shift;        // 0x1C
        public System.Nullable<UnityEngine.InputSystem.Key> Cached_KeyCode;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public struct CopyToClipboardStates
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates Hidden;        // 0x0
        public static SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates Visible;        // 0x0
        public static SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates Activated;        // 0x0

    }

    // TypeToken: 0x200002D
    public class CategoryInstance
    {
        // Fields
        private SRDebugger.UI.Other.CategoryGroup <CategoryGroup>k__BackingField;        // 0x10
        public readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> Options;        // 0x18

        // Methods
        private SRDebugger.UI.Other.CategoryGroup get_CategoryGroup() { }
        private System.Void set_CategoryGroup(SRDebugger.UI.Other.CategoryGroup value) { }
        private System.Void .ctor(SRDebugger.UI.Other.CategoryGroup group) { }

    }

    // TypeToken: 0x2000058
    public struct VerticalAlignments
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments Top;        // 0x0
        public static SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments Bottom;        // 0x0

    }

    // TypeToken: 0x200005E
    public struct ValueRange
    {
        // Fields
        public System.Double MaxValue;        // 0x10
        public System.Double MinValue;        // 0x18

    }

    // TypeToken: 0x2000081
    public class OptionContainerEventHandler, IDisposable
    {
        // Fields
        private readonly SRDebugger.Services.Implementation.OptionsServiceImpl _service;        // 0x10
        private readonly SRDebugger.IOptionContainer _container;        // 0x18

        // Methods
        private System.Void .ctor(SRDebugger.Services.Implementation.OptionsServiceImpl service, SRDebugger.IOptionContainer container) { }
        private System.Void ContainerOnOptionAdded(SRDebugger.OptionDefinition obj) { }
        private System.Void ContainerOnOptionRemoved(SRDebugger.OptionDefinition obj) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000082
    public class ReflectionOptionContainer, IOptionContainer
    {
        // Fields
        private System.Collections.Generic.List<SRDebugger.OptionDefinition> _options;        // 0x10
        private readonly System.Object _target;        // 0x18

        // Methods
        private System.Void add_OptionAdded(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void remove_OptionAdded(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void add_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void remove_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Boolean get_IsDynamic() { }
        private System.Collections.Generic.List<SRDebugger.OptionDefinition> get_Options() { }
        private System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions() { }
        private System.Void .ctor(System.Object target) { }
        private System.Boolean Equals(SRDebugger.Services.Implementation.OptionsServiceImpl.ReflectionOptionContainer other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000098
    public struct OptionType
    {
        // Fields
        public readonly System.Type Type;        // 0x10
        public readonly System.Boolean IsReadyOnly;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type, System.Boolean isReadyOnly) { }
        private System.Boolean Equals(SRDebugger.Internal.OptionControlFactory.OptionType other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200009F
    public struct __StaticArrayInitTypeSize=36
    {
    }

namespace Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation
{

    // TypeToken: 0x2000004
    public class ConsoleFilterStateService, IConsoleFilterState
    {
        // Fields
        private SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;        // 0x10
        private readonly System.Boolean[] _states;        // 0x18

        // Methods
        private System.Void add_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value) { }
        private System.Void remove_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value) { }
        private System.Void .ctor() { }
        private System.Void SetConsoleFilterState(UnityEngine.LogType type, System.Boolean newState) { }
        private System.Boolean GetConsoleFilterState(UnityEngine.LogType type) { }
        private UnityEngine.LogType GetType(UnityEngine.LogType type) { }

    }

}

namespace SRDebugger
{

    // TypeToken: 0x2000005
    public class AutoInitialize
    {
        // Fields
        private static UnityEngine.RuntimeInitializeLoadType InitializeLoadType;        // 0x0

        // Methods
        private System.Void OnLoadBeforeScene() { }
        private System.Void OnLoad() { }

    }

    // TypeToken: 0x2000006
    public class BugReport
    {
        // Fields
        public System.Collections.Generic.List<SRDebugger.Services.ConsoleEntry> ConsoleLog;        // 0x10
        public System.String Email;        // 0x18
        public System.Byte[] ScreenshotData;        // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> SystemInformation;        // 0x28
        public System.String UserDescription;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class BugReportSubmitResult
    {
        // Fields
        private readonly System.Boolean <IsSuccessful>k__BackingField;        // 0x10
        private readonly System.String <ErrorMessage>k__BackingField;        // 0x18

        // Methods
        private SRDebugger.BugReportSubmitResult get_Success() { }
        private SRDebugger.BugReportSubmitResult Error(System.String errorMessage) { }
        private System.Boolean get_IsSuccessful() { }
        private System.String get_ErrorMessage() { }
        private System.Void .ctor(System.Boolean successful, System.String error) { }

    }

    // TypeToken: 0x2000008
    public interface IBugReporterHandler
    {
        // Methods
        private System.Boolean get_IsUsable() { }
        private System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }

    }

    // TypeToken: 0x2000009
    public class CircularBuffer`1, IEnumerable`1, IEnumerable, IReadOnlyList`1, IReadOnlyCollection`1
    {
        // Fields
        private readonly T[] _buffer;        // 0x0
        private System.Int32 _end;        // 0x0
        private System.Int32 _count;        // 0x0
        private System.Int32 _start;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Int32 capacity, T[] items) { }
        private System.Int32 get_Capacity() { }
        private System.Boolean get_IsFull() { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void Clear() { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private T Front() { }
        private T Back() { }
        private System.Void PushBack(T item) { }
        private System.Void PushFront(T item) { }
        private System.Void PopBack() { }
        private System.Void PopFront() { }
        private T[] ToArray() { }
        private System.Void ThrowIfEmpty(System.String message) { }
        private System.Void Increment(System.Int32& index) { }
        private System.Void Decrement(System.Int32& index) { }
        private System.Int32 InternalIndex(System.Int32 index) { }
        private System.ArraySegment<T> ArrayOne() { }
        private System.ArraySegment<T> ArrayTwo() { }

    }

    // TypeToken: 0x200000B
    public class OptionDefinition
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private System.String <Category>k__BackingField;        // 0x18
        private System.Int32 <SortPriority>k__BackingField;        // 0x20
        private SRF.Helpers.MethodReference <Method>k__BackingField;        // 0x28
        private SRF.Helpers.PropertyReference <Property>k__BackingField;        // 0x30

        // Methods
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_Category() { }
        private System.Void set_Category(System.String value) { }
        private System.Int32 get_SortPriority() { }
        private System.Void set_SortPriority(System.Int32 value) { }
        private System.Boolean get_IsMethod() { }
        private System.Boolean get_IsProperty() { }
        private SRF.Helpers.MethodReference get_Method() { }
        private System.Void set_Method(SRF.Helpers.MethodReference value) { }
        private SRF.Helpers.PropertyReference get_Property() { }
        private System.Void set_Property(SRF.Helpers.PropertyReference value) { }
        private System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority) { }
        private System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.MethodReference method) { }
        private System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.PropertyReference property) { }
        private SRDebugger.OptionDefinition FromMethod(System.String name, System.Action callback, System.String category, System.Int32 sortPriority) { }
        private SRDebugger.OptionDefinition Create(System.String name, System.Func<T> getter, System.Action<T> setter, System.String category, System.Int32 sortPriority) { }

    }

    // TypeToken: 0x200000C
    public interface IOptionContainer
    {
        // Methods
        private System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions() { }
        private System.Boolean get_IsDynamic() { }
        private System.Void add_OptionAdded(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void remove_OptionAdded(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void add_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void remove_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value) { }

    }

    // TypeToken: 0x200000D
    public class DynamicOptionContainer, IOptionContainer
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.OptionDefinition> _options;        // 0x10
        private readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition> _optionsReadOnly;        // 0x18
        private System.Action<SRDebugger.OptionDefinition> OptionAdded;        // 0x20
        private System.Action<SRDebugger.OptionDefinition> OptionRemoved;        // 0x28

        // Methods
        private System.Collections.Generic.IList<SRDebugger.OptionDefinition> get_Options() { }
        private System.Void .ctor() { }
        private System.Void AddOption(SRDebugger.OptionDefinition option) { }
        private System.Boolean RemoveOption(SRDebugger.OptionDefinition option) { }
        private System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> SRDebugger.IOptionContainer.GetOptions() { }
        private System.Boolean get_IsDynamic() { }
        private System.Void add_OptionAdded(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void remove_OptionAdded(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void add_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value) { }
        private System.Void remove_OptionRemoved(System.Action<SRDebugger.OptionDefinition> value) { }

    }

    // TypeToken: 0x200000E
    public class VisibilityChangedDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Boolean isVisible) { }
        private System.IAsyncResult BeginInvoke(System.Boolean isVisible, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000F
    public class ActionCompleteCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Boolean success) { }
        private System.IAsyncResult BeginInvoke(System.Boolean success, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000010
    public class PinnedUiCanvasCreated : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.RectTransform canvasTransform) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.RectTransform canvasTransform, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000011
    public struct EntryCode, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        public readonly System.Int32 Digit1;        // 0x10
        public readonly System.Int32 Digit2;        // 0x14
        public readonly System.Int32 Digit3;        // 0x18
        public readonly System.Int32 Digit4;        // 0x1C

        // Methods
        private System.Void .ctor(System.Int32 digit1, System.Int32 digit2, System.Int32 digit3, System.Int32 digit4) { }
        private System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x2000012
    public class InfoEntry
    {
        // Fields
        private System.String <Title>k__BackingField;        // 0x10
        private System.Boolean <IsPrivate>k__BackingField;        // 0x18
        private System.Func<System.Object> _valueGetter;        // 0x20

        // Methods
        private System.String get_Title() { }
        private System.Void set_Title(System.String value) { }
        private System.Object get_Value() { }
        private System.Boolean get_IsPrivate() { }
        private System.Void set_IsPrivate(System.Boolean value) { }
        private SRDebugger.InfoEntry Create(System.String name, System.Func<System.Object> getter, System.Boolean isPrivate) { }
        private SRDebugger.InfoEntry Create(System.String name, System.Object value, System.Boolean isPrivate) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public struct DefaultTabs
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.DefaultTabs SystemInformation;        // 0x0
        public static SRDebugger.DefaultTabs Options;        // 0x0
        public static SRDebugger.DefaultTabs Console;        // 0x0
        public static SRDebugger.DefaultTabs Profiler;        // 0x0
        public static SRDebugger.DefaultTabs BugReporter;        // 0x0

    }

    // TypeToken: 0x2000015
    public struct PinAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.PinAlignment TopLeft;        // 0x0
        public static SRDebugger.PinAlignment TopRight;        // 0x0
        public static SRDebugger.PinAlignment BottomLeft;        // 0x0
        public static SRDebugger.PinAlignment BottomRight;        // 0x0
        public static SRDebugger.PinAlignment CenterLeft;        // 0x0
        public static SRDebugger.PinAlignment CenterRight;        // 0x0
        public static SRDebugger.PinAlignment TopCenter;        // 0x0
        public static SRDebugger.PinAlignment BottomCenter;        // 0x0

    }

    // TypeToken: 0x2000016
    public struct ConsoleAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static SRDebugger.ConsoleAlignment Top;        // 0x0
        public static SRDebugger.ConsoleAlignment Bottom;        // 0x0

    }

    // TypeToken: 0x2000017
    public class Settings : ScriptableObject
    {
        // Fields
        private static System.String ResourcesName;        // 0x0
        private static SRDebugger.Settings _instance;        // 0x0
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;        // 0x18
        private System.Boolean _isEnabled;        // 0x20
        private System.Boolean _disableWelcomePopup;        // 0x21
        private SRDebugger.Settings.UIModes _uiInputMode;        // 0x24
        private SRDebugger.DefaultTabs _defaultTab;        // 0x28
        private SRDebugger.Settings.TriggerEnableModes _triggerEnableMode;        // 0x2C
        private SRDebugger.Settings.TriggerBehaviours _triggerBehaviour;        // 0x30
        private System.Boolean _errorNotification;        // 0x34
        private System.Boolean _enableKeyboardShortcuts;        // 0x35
        private SRDebugger.Settings.KeyboardShortcut[] _keyboardShortcuts;        // 0x38
        private SRDebugger.Settings.KeyboardShortcut[] _newKeyboardShortcuts;        // 0x40
        private System.Boolean _keyboardModifierControl;        // 0x48
        private System.Boolean _keyboardModifierAlt;        // 0x49
        private System.Boolean _keyboardModifierShift;        // 0x4A
        private System.Boolean _keyboardEscapeClose;        // 0x4B
        private System.Boolean _enableBackgroundTransparency;        // 0x4C
        private System.Single _backgroundTransparency;        // 0x50
        private System.Boolean _collapseDuplicateLogEntries;        // 0x54
        private System.Boolean _richTextInConsole;        // 0x55
        private System.Boolean _requireEntryCode;        // 0x56
        private System.Boolean _requireEntryCodeEveryTime;        // 0x57
        private System.Int32[] _entryCode;        // 0x58
        private System.Boolean _useDebugCamera;        // 0x60
        private System.Int32 _debugLayer;        // 0x64
        private System.Single _debugCameraDepth;        // 0x68
        private System.String _apiKey;        // 0x70
        private System.Boolean _enableBugReporter;        // 0x78
        private System.Boolean _enableBugReportScreenshot;        // 0x79
        private SRDebugger.DefaultTabs[] _disabledTabs;        // 0x80
        private SRDebugger.PinAlignment _profilerAlignment;        // 0x88
        private SRDebugger.PinAlignment _optionsAlignment;        // 0x8C
        private SRDebugger.ConsoleAlignment _consoleAlignment;        // 0x90
        private SRDebugger.PinAlignment _triggerPosition;        // 0x94
        private System.Int32 _maximumConsoleEntries;        // 0x98
        private System.Boolean _enableEventSystemCreation;        // 0x9C
        private System.Boolean _automaticShowCursor;        // 0x9D
        private System.Single _uiScale;        // 0xA0
        private System.Boolean _unloadOnClose;        // 0xA4

        // Methods
        private SRDebugger.Settings get_Instance() { }
        private SRDebugger.Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts() { }
        private System.Void UpgradeKeyboardShortcuts() { }
        private System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Boolean get_IsEnabled() { }
        private SRDebugger.Settings.UIModes get_UIInputMode() { }
        private SRDebugger.DefaultTabs get_DefaultTab() { }
        private SRDebugger.Settings.TriggerEnableModes get_EnableTrigger() { }
        private SRDebugger.Settings.TriggerBehaviours get_TriggerBehaviour() { }
        private System.Boolean get_ErrorNotification() { }
        private System.Boolean get_EnableKeyboardShortcuts() { }
        private System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> get_KeyboardShortcuts() { }
        private System.Boolean get_KeyboardEscapeClose() { }
        private System.Boolean get_EnableBackgroundTransparency() { }
        private System.Single get_BackgroundTransparency() { }
        private System.Boolean get_RequireCode() { }
        private System.Boolean get_RequireEntryCodeEveryTime() { }
        private System.Collections.Generic.IList<System.Int32> get_EntryCode() { }
        private System.Void set_EntryCode(System.Collections.Generic.IList<System.Int32> value) { }
        private System.Boolean get_UseDebugCamera() { }
        private System.Int32 get_DebugLayer() { }
        private System.Single get_DebugCameraDepth() { }
        private System.Boolean get_CollapseDuplicateLogEntries() { }
        private System.Boolean get_RichTextInConsole() { }
        private System.String get_ApiKey() { }
        private System.Boolean get_EnableBugReporter() { }
        private System.Boolean get_EnableBugReportScreenshot() { }
        private System.Collections.Generic.IList<SRDebugger.DefaultTabs> get_DisabledTabs() { }
        private SRDebugger.PinAlignment get_TriggerPosition() { }
        private SRDebugger.PinAlignment get_ProfilerAlignment() { }
        private SRDebugger.PinAlignment get_OptionsAlignment() { }
        private SRDebugger.ConsoleAlignment get_ConsoleAlignment() { }
        private System.Void set_ConsoleAlignment(SRDebugger.ConsoleAlignment value) { }
        private System.Int32 get_MaximumConsoleEntries() { }
        private System.Void set_MaximumConsoleEntries(System.Int32 value) { }
        private System.Boolean get_EnableEventSystemGeneration() { }
        private System.Void set_EnableEventSystemGeneration(System.Boolean value) { }
        private System.Boolean get_AutomaticallyShowCursor() { }
        private System.Single get_UIScale() { }
        private System.Void set_UIScale(System.Single value) { }
        private System.Boolean get_UnloadOnClose() { }
        private System.Void OnPropertyChanged(System.String propertyName) { }
        private System.Void ClearCache() { }
        private SRDebugger.Settings GetInstance() { }
        private SRDebugger.Settings GetOrCreateInstance() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class SRDebuggerInit : SRMonoBehaviourEx
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class NumberRangeAttribute : Attribute
    {
        // Fields
        public readonly System.Double Max;        // 0x10
        public readonly System.Double Min;        // 0x18

        // Methods
        private System.Void .ctor(System.Double min, System.Double max) { }

    }

    // TypeToken: 0x2000020
    public class IncrementAttribute : Attribute
    {
        // Fields
        public readonly System.Double Increment;        // 0x10

        // Methods
        private System.Void .ctor(System.Double increment) { }

    }

    // TypeToken: 0x2000021
    public class SortAttribute : Attribute
    {
        // Fields
        public readonly System.Int32 SortPriority;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 priority) { }

    }

    // TypeToken: 0x2000022
    public class VersionInfo
    {
        // Fields
        public static System.String Version;        // 0x0

    }

}

namespace SRDebugger.Internal
{

    // TypeToken: 0x200008F
    public class SRDebugApi
    {
        // Fields
        public static System.String Protocol;        // 0x0
        public static System.String EndPoint;        // 0x0
        public static System.String BugReportEndPoint;        // 0x0

    }

    // TypeToken: 0x2000090
    public class SRDebugApiUtil
    {
        // Methods
        private System.String ParseErrorException(System.Net.WebException ex) { }
        private System.String ParseErrorResponse(System.String response, System.String fallback) { }
        private System.Boolean ReadResponse(System.Net.HttpWebRequest request, System.String& result) { }
        private System.String ReadResponseStream(System.Net.WebResponse stream) { }

    }

    // TypeToken: 0x2000091
    public class BugReportApi : MonoBehaviour
    {
        // Fields
        private System.String _apiKey;        // 0x18
        private SRDebugger.BugReport _bugReport;        // 0x20
        private System.Boolean _isBusy;        // 0x28
        private UnityEngine.Networking.UnityWebRequest _webRequest;        // 0x30
        private System.Action<SRDebugger.BugReportSubmitResult> _onComplete;        // 0x38
        private System.IProgress<System.Single> _progress;        // 0x40

        // Methods
        private System.Void Submit(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }
        private System.Void Init(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }
        private System.Void Update() { }
        private System.Collections.IEnumerator Submit() { }
        private System.Void SetCompletionState(SRDebugger.BugReportSubmitResult result) { }
        private System.String BuildJsonRequest(SRDebugger.BugReport report) { }
        private System.Collections.Generic.List<System.Collections.Generic.List<System.String>> CreateConsoleDump() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000093
    public class BugReportScreenshotUtil
    {
        // Fields
        public static System.Byte[] ScreenshotData;        // 0x0

        // Methods
        private System.Collections.IEnumerator ScreenshotCaptureCo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public class InternalBugReporterHandler, IBugReporterHandler
    {
        // Methods
        private System.Boolean get_IsUsable() { }
        private System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000096
    public class InternalOptionsRegistry
    {
        // Fields
        private System.Collections.Generic.List<System.Object> _registeredContainers;        // 0x10
        private System.Action<System.Object> _handler;        // 0x18

        // Methods
        private System.Void AddOptionContainer(System.Object obj) { }
        private System.Void SetHandler(System.Action<System.Object> action) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class OptionControlFactory
    {
        // Fields
        private static System.Collections.Generic.IList<SRDebugger.UI.Controls.DataBoundControl> _dataControlPrefabs;        // 0x0
        private static SRDebugger.UI.Controls.Data.ActionControl _actionControlPrefab;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionControlFactory.OptionType,SRDebugger.UI.Controls.DataBoundControl> TypeCache;        // 0x10

        // Methods
        private System.Boolean CanCreateControl(SRDebugger.OptionDefinition from) { }
        private SRDebugger.UI.Controls.OptionsControlBase CreateControl(SRDebugger.OptionDefinition from, System.String categoryPrefix) { }
        private System.Void PopulateDataControlPrefabs() { }
        private SRDebugger.UI.Controls.Data.ActionControl CreateActionControl(SRDebugger.OptionDefinition from, System.String categoryPrefix) { }
        private SRDebugger.UI.Controls.DataBoundControl CreateDataControl(SRDebugger.OptionDefinition from, System.String categoryPrefix) { }
        private SRDebugger.UI.Controls.DataBoundControl TryGetDataControlPrefab(SRDebugger.OptionDefinition from) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009A
    public class SRDebugPaths
    {
        // Fields
        public static System.String DataControlsResourcesPath;        // 0x0
        public static System.String TriggerPrefabPath;        // 0x0
        public static System.String DebugPanelPrefabPath;        // 0x0
        public static System.String PinnedUIPrefabPath;        // 0x0
        public static System.String DockConsolePrefabPath;        // 0x0
        public static System.String PinEntryPrefabPath;        // 0x0
        public static System.String BugReportPopoverPath;        // 0x0
        public static System.String BugReportSheetPath;        // 0x0

    }

    // TypeToken: 0x200009B
    public class Service
    {
        // Fields
        private static SRDebugger.Services.IConsoleService _consoleService;        // 0x0
        private static SRDebugger.Services.IDebugPanelService _debugPanelService;        // 0x8
        private static SRDebugger.Services.IDebugTriggerService _debugTriggerService;        // 0x10
        private static SRDebugger.Services.IPinnedUIService _pinnedUiService;        // 0x18
        private static SRDebugger.Services.IDebugCameraService _debugCameraService;        // 0x20
        private static SRDebugger.Services.IOptionsService _optionsService;        // 0x28
        private static SRDebugger.Services.IDockConsoleService _dockConsoleService;        // 0x30

        // Methods
        private SRDebugger.Services.IConsoleService get_Console() { }
        private SRDebugger.Services.IDockConsoleService get_DockConsole() { }
        private SRDebugger.Services.IDebugPanelService get_Panel() { }
        private SRDebugger.Services.IDebugTriggerService get_Trigger() { }
        private SRDebugger.Services.IPinnedUIService get_PinnedUI() { }
        private SRDebugger.Services.IDebugCameraService get_DebugCamera() { }
        private SRDebugger.Services.IOptionsService get_Options() { }

    }

    // TypeToken: 0x200009C
    public class SRDebugStrings
    {
        // Fields
        public static readonly SRDebugger.Internal.SRDebugStrings Current;        // 0x0
        public readonly System.String Console_MessageTruncated;        // 0x10
        public readonly System.String Console_NoStackTrace;        // 0x18
        public readonly System.String PinEntryPrompt;        // 0x20
        public readonly System.String Profiler_DisableProfilerInfo;        // 0x28
        public readonly System.String Profiler_EnableProfilerInfo;        // 0x30
        public readonly System.String Profiler_NoProInfo;        // 0x38
        public readonly System.String Profiler_NotSupported;        // 0x40
        public readonly System.String ProfilerCameraListenerHelp;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009D
    public class SRDebuggerUtil
    {
        // Methods
        private System.Boolean get_IsMobilePlatform() { }
        private System.Boolean EnsureEventSystemExists() { }
        private System.Void CreateDefaultEventSystem() { }
        private System.Void AddInputSystem(UnityEngine.GameObject go) { }
        private System.Void AddLegacyInputSystem(UnityEngine.GameObject go) { }
        private System.Collections.Generic.List<SRDebugger.OptionDefinition> ScanForOptions(System.Object obj) { }
        private System.String GetNumberString(System.Int32 value, System.Int32 max, System.String exceedsMaxString) { }
        private System.Void ConfigureCanvas(UnityEngine.Canvas canvas) { }

    }

}

namespace SRDebugger.Profiler
{

    // TypeToken: 0x200008B
    public class ProfilerLateUpdateListener : MonoBehaviour
    {
        // Fields
        public System.Action OnLateUpdate;        // 0x18

        // Methods
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public class ProfilerServiceImpl : SRServiceBase`1, IProfilerService
    {
        // Fields
        private System.Single <AverageFrameTime>k__BackingField;        // 0x48
        private System.Single <LastFrameTime>k__BackingField;        // 0x4C
        private static System.Int32 FrameBufferSize;        // 0x0
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> _frameBuffer;        // 0x50
        private SRDebugger.Profiler.ProfilerLateUpdateListener _lateUpdateListener;        // 0x58
        private readonly System.Diagnostics.Stopwatch _stopwatch;        // 0x60
        private System.Double _updateDuration;        // 0x68
        private System.Double _renderStartTime;        // 0x70
        private System.Double _renderDuration;        // 0x78
        private System.Int32 _camerasThisFrame;        // 0x80

        // Methods
        private System.Single get_AverageFrameTime() { }
        private System.Void set_AverageFrameTime(System.Single value) { }
        private System.Single get_LastFrameTime() { }
        private System.Void set_LastFrameTime(System.Single value) { }
        private SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer() { }
        private System.Void Awake() { }
        private System.Void Update() { }
        private System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime) { }
        private System.Void OnLateUpdate() { }
        private System.Void OnCameraPreRender(UnityEngine.Camera cam) { }
        private System.Void OnCameraPostRender(UnityEngine.Camera cam) { }
        private System.Void EndFrame() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008D
    public class SRPProfilerService : SRServiceBase`1, IProfilerService
    {
        // Fields
        private System.Single <AverageFrameTime>k__BackingField;        // 0x48
        private System.Single <LastFrameTime>k__BackingField;        // 0x4C
        private static System.Int32 FrameBufferSize;        // 0x0
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> _frameBuffer;        // 0x50
        private SRDebugger.Profiler.ProfilerLateUpdateListener _lateUpdateListener;        // 0x58
        private System.Double _updateDuration;        // 0x60
        private System.Double _renderStartTime;        // 0x68
        private System.Double _renderDuration;        // 0x70
        private readonly System.Diagnostics.Stopwatch _stopwatch;        // 0x78

        // Methods
        private System.Single get_AverageFrameTime() { }
        private System.Void set_AverageFrameTime(System.Single value) { }
        private System.Single get_LastFrameTime() { }
        private System.Void set_LastFrameTime(System.Single value) { }
        private SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer() { }
        private System.Void Awake() { }
        private System.Void Update() { }
        private System.Collections.IEnumerator EndOfFrameCoroutine() { }
        private System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime) { }
        private System.Void OnLateUpdate() { }
        private System.Void RenderPipelineOnBeginFrameRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void EndFrame() { }
        private System.Void .ctor() { }

    }

}

namespace SRDebugger.Scripts
{

    // TypeToken: 0x2000023
    public class DebuggerTabController : SRMonoBehaviourEx
    {
        // Fields
        private SRDebugger.UI.Other.SRTab _aboutTabInstance;        // 0x48
        private System.Nullable<SRDebugger.DefaultTabs> _activeTab;        // 0x50
        private System.Boolean _hasStarted;        // 0x58
        public SRDebugger.UI.Other.SRTab AboutTab;        // 0x60
        public SRDebugger.UI.Other.SRTabController TabController;        // 0x68

        // Methods
        private System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab() { }
        private System.Void Start() { }
        private System.Boolean OpenTab(SRDebugger.DefaultTabs tab) { }
        private System.Void ShowAboutTab() { }
        private System.Void .ctor() { }

    }

}

namespace SRDebugger.Services
{

    // TypeToken: 0x2000061
    public class ConsoleFilterStateService
    {
        // Fields
        private SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;        // 0x10
        private System.Boolean[] _states;        // 0x18

        // Methods
        private System.Void add_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value) { }
        private System.Void remove_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value) { }
        private System.Void .ctor() { }
        private System.Void SetState(UnityEngine.LogType type, System.Boolean newState) { }
        private System.Boolean GetState(UnityEngine.LogType type) { }
        private UnityEngine.LogType GetType(UnityEngine.LogType type) { }

    }

    // TypeToken: 0x2000062
    public class BugReportCompleteCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Boolean didSucceed, System.String errorMessage) { }
        private System.IAsyncResult BeginInvoke(System.Boolean didSucceed, System.String errorMessage, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000063
    public class BugReportProgressCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Single progress) { }
        private System.IAsyncResult BeginInvoke(System.Single progress, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000064
    public interface IBugReportService
    {
        // Methods
        private System.Boolean get_IsUsable() { }
        private System.Void SetHandler(SRDebugger.IBugReporterHandler handler) { }
        private System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progressCallback) { }

    }

    // TypeToken: 0x2000065
    public class ConsoleStateChangedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.LogType logType, System.Boolean newState) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.LogType logType, System.Boolean newState, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000066
    public interface IConsoleFilterState
    {
        // Methods
        private System.Void add_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value) { }
        private System.Void remove_FilterStateChange(SRDebugger.Services.ConsoleStateChangedEventHandler value) { }
        private System.Void SetConsoleFilterState(UnityEngine.LogType logType, System.Boolean enabled) { }
        private System.Boolean GetConsoleFilterState(UnityEngine.LogType logType) { }

    }

    // TypeToken: 0x2000067
    public class ConsoleUpdatedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(SRDebugger.Services.IConsoleService console) { }
        private System.IAsyncResult BeginInvoke(SRDebugger.Services.IConsoleService console, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000068
    public interface IConsoleService
    {
        // Methods
        private System.Int32 get_CriticalCount() { }
        private System.Int32 get_ErrorCount() { }
        private System.Int32 get_WarningCount() { }
        private System.Int32 get_InfoCount() { }
        private System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries() { }
        private System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries() { }
        private System.Void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Void add_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Void remove_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Boolean get_LoggingEnabled() { }
        private System.Void set_LoggingEnabled(System.Boolean value) { }
        private System.Boolean get_LogHandlerIsOverriden() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000069
    public class ConsoleEntry
    {
        // Fields
        private static System.Int32 MessagePreviewLength;        // 0x0
        private static System.Int32 StackTracePreviewLength;        // 0x0
        private System.String _messagePreview;        // 0x10
        private System.String _stackTracePreview;        // 0x18
        public System.Int32 Count;        // 0x20
        public UnityEngine.LogType LogType;        // 0x24
        public System.String Message;        // 0x28
        public System.String StackTrace;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(SRDebugger.Services.ConsoleEntry other) { }
        private System.String get_MessagePreview() { }
        private System.String get_StackTracePreview() { }
        private System.Boolean Matches(SRDebugger.Services.ConsoleEntry other) { }

    }

    // TypeToken: 0x200006A
    public interface IDebugCameraService
    {
        // Methods
        private UnityEngine.Camera get_Camera() { }

    }

    // TypeToken: 0x200006B
    public interface IDebugPanelService
    {
        // Methods
        private System.Boolean get_IsLoaded() { }
        private System.Boolean get_IsVisible() { }
        private System.Void set_IsVisible(System.Boolean value) { }
        private System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab() { }
        private System.Void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value) { }
        private System.Void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value) { }
        private System.Void Unload() { }
        private System.Void OpenTab(SRDebugger.DefaultTabs tab) { }

    }

    // TypeToken: 0x200006C
    public interface IDebugService
    {
        // Methods
        private SRDebugger.Settings get_Settings() { }
        private System.Boolean get_IsDebugPanelVisible() { }
        private System.Boolean get_IsTriggerEnabled() { }
        private System.Void set_IsTriggerEnabled(System.Boolean value) { }
        private System.Boolean get_IsTriggerErrorNotificationEnabled() { }
        private System.Void set_IsTriggerErrorNotificationEnabled(System.Boolean value) { }
        private SRDebugger.Services.IDockConsoleService get_DockConsole() { }
        private SRDebugger.Services.IConsoleFilterState get_ConsoleFilter() { }
        private System.Boolean get_IsProfilerDocked() { }
        private System.Void set_IsProfilerDocked(System.Boolean value) { }
        private System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category) { }
        private System.Void ShowDebugPanel(System.Boolean requireEntryCode) { }
        private System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode) { }
        private System.Void HideDebugPanel() { }
        private System.Void SetEntryCode(SRDebugger.EntryCode newCode) { }
        private System.Void DisableEntryCode() { }
        private System.Void DestroyDebugPanel() { }
        private System.Void AddOptionContainer(System.Object container) { }
        private System.Void RemoveOptionContainer(System.Object container) { }
        private System.Void AddOption(SRDebugger.OptionDefinition option) { }
        private System.Boolean RemoveOption(SRDebugger.OptionDefinition option) { }
        private System.Void PinAllOptions(System.String category) { }
        private System.Void UnpinAllOptions(System.String category) { }
        private System.Void PinOption(System.String name) { }
        private System.Void UnpinOption(System.String name) { }
        private System.Void ClearPinnedOptions() { }
        private System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent) { }
        private System.Void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value) { }
        private System.Void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value) { }
        private System.Void add_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value) { }
        private System.Void remove_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value) { }
        private UnityEngine.RectTransform EnableWorldSpaceMode() { }
        private System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler) { }

    }

    // TypeToken: 0x200006D
    public interface IDebugTriggerService
    {
        // Methods
        private System.Boolean get_IsEnabled() { }
        private System.Void set_IsEnabled(System.Boolean value) { }
        private System.Boolean get_ShowErrorNotification() { }
        private System.Void set_ShowErrorNotification(System.Boolean value) { }
        private SRDebugger.PinAlignment get_Position() { }
        private System.Void set_Position(SRDebugger.PinAlignment value) { }

    }

    // TypeToken: 0x200006E
    public interface IDockConsoleService
    {
        // Methods
        private System.Boolean get_IsVisible() { }
        private System.Void set_IsVisible(System.Boolean value) { }
        private System.Boolean get_IsExpanded() { }
        private System.Void set_IsExpanded(System.Boolean value) { }
        private SRDebugger.ConsoleAlignment get_Alignment() { }
        private System.Void set_Alignment(SRDebugger.ConsoleAlignment value) { }

    }

    // TypeToken: 0x200006F
    public interface IOptionsService
    {
        // Methods
        private System.Void add_OptionsUpdated(System.EventHandler value) { }
        private System.Void remove_OptionsUpdated(System.EventHandler value) { }
        private System.Collections.Generic.ICollection<SRDebugger.OptionDefinition> get_Options() { }
        private System.Void Scan(System.Object obj) { }
        private System.Void AddContainer(System.Object obj) { }
        private System.Void AddContainer(SRDebugger.IOptionContainer optionContainer) { }
        private System.Void RemoveContainer(System.Object obj) { }
        private System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer) { }

    }

    // TypeToken: 0x2000070
    public class PinEntryCompleteCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Boolean validPinEntered) { }
        private System.IAsyncResult BeginInvoke(System.Boolean validPinEntered, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000071
    public interface IPinEntryService
    {
        // Methods
        private System.Boolean get_IsShowingKeypad() { }
        private System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel) { }

    }

    // TypeToken: 0x2000072
    public interface IPinnedUIService
    {
        // Methods
        private System.Void add_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value) { }
        private System.Void remove_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value) { }
        private System.Void add_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value) { }
        private System.Void remove_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value) { }
        private System.Boolean get_IsProfilerPinned() { }
        private System.Void set_IsProfilerPinned(System.Boolean value) { }
        private System.Void Pin(SRDebugger.OptionDefinition option, System.Int32 order) { }
        private System.Void Unpin(SRDebugger.OptionDefinition option) { }
        private System.Void UnpinAll() { }
        private System.Boolean HasPinned(SRDebugger.OptionDefinition option) { }

    }

    // TypeToken: 0x2000073
    public class ProfilerServiceSelector
    {
        // Methods
        private System.Type GetProfilerServiceType() { }

    }

    // TypeToken: 0x2000074
    public struct ProfilerFrame
    {
        // Fields
        public System.Double FrameTime;        // 0x10
        public System.Double OtherTime;        // 0x18
        public System.Double RenderTime;        // 0x20
        public System.Double UpdateTime;        // 0x28

    }

    // TypeToken: 0x2000075
    public interface IProfilerService
    {
        // Methods
        private System.Single get_AverageFrameTime() { }
        private System.Single get_LastFrameTime() { }
        private SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer() { }

    }

    // TypeToken: 0x2000076
    public interface ISystemInformationService
    {
        // Methods
        private System.Collections.Generic.IEnumerable<System.String> GetCategories() { }
        private System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category) { }
        private System.Void Add(SRDebugger.InfoEntry info, System.String category) { }
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate) { }

    }

}

namespace SRDebugger.Services.Implementation
{

    // TypeToken: 0x2000077
    public class BugReportApiService, IBugReportService
    {
        // Fields
        private SRDebugger.IBugReporterHandler _handler;        // 0x10

        // Methods
        private System.Boolean get_IsUsable() { }
        private System.Void SetHandler(SRDebugger.IBugReporterHandler handler) { }
        private System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progress) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class BugReportPopoverService : SRServiceBase`1
    {
        // Fields
        private SRDebugger.Services.BugReportCompleteCallback _callback;        // 0x48
        private System.Boolean _isVisible;        // 0x50
        private SRDebugger.UI.Other.BugReportPopoverRoot _popover;        // 0x58
        private SRDebugger.UI.Other.BugReportSheetController _sheet;        // 0x60

        // Methods
        private System.Boolean get_IsShowingPopover() { }
        private System.Void ShowBugReporter(SRDebugger.Services.BugReportCompleteCallback callback, System.Boolean takeScreenshotFirst, System.String descriptionText) { }
        private System.Collections.IEnumerator OpenCo(System.Boolean takeScreenshot, System.String descriptionText) { }
        private System.Void SubmitComplete(System.Boolean didSucceed, System.String errorMessage) { }
        private System.Void CancelPressed() { }
        private System.Void OnComplete(System.Boolean success, System.String errorMessage, System.Boolean close) { }
        private System.Void TakingScreenshot() { }
        private System.Void ScreenshotComplete() { }
        private System.Void Awake() { }
        private System.Void Load() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class DebugCameraServiceImpl, IDebugCameraService
    {
        // Fields
        private UnityEngine.Camera _debugCamera;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Camera get_Camera() { }

    }

    // TypeToken: 0x200007C
    public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService, IDisposable
    {
        // Fields
        private SRDebugger.UI.DebugPanelRoot _debugPanelRootObject;        // 0x18
        private System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> VisibilityChanged;        // 0x20
        private System.Boolean _isVisible;        // 0x28
        private System.Nullable<System.Boolean> _cursorWasVisible;        // 0x29
        private System.Nullable<UnityEngine.CursorLockMode> _cursorLockMode;        // 0x2C

        // Methods
        private System.Void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value) { }
        private System.Void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> value) { }
        private SRDebugger.UI.DebugPanelRoot get_RootObject() { }
        private System.Boolean get_IsLoaded() { }
        private System.Boolean get_IsVisible() { }
        private System.Void set_IsVisible(System.Boolean value) { }
        private System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab() { }
        private System.Void OpenTab(SRDebugger.DefaultTabs tab) { }
        private System.Void Unload() { }
        private System.Void Load() { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class DebugTriggerImpl : SRServiceBase`1, IDebugTriggerService
    {
        // Fields
        private SRDebugger.PinAlignment _position;        // 0x48
        private SRDebugger.UI.Other.TriggerRoot _trigger;        // 0x50
        private SRDebugger.Services.IConsoleService _consoleService;        // 0x58
        private System.Boolean _showErrorNotification;        // 0x60

        // Methods
        private System.Boolean get_IsEnabled() { }
        private System.Void set_IsEnabled(System.Boolean value) { }
        private System.Boolean get_ShowErrorNotification() { }
        private System.Void set_ShowErrorNotification(System.Boolean value) { }
        private SRDebugger.PinAlignment get_Position() { }
        private System.Void set_Position(SRDebugger.PinAlignment value) { }
        private System.Void Awake() { }
        private System.Void OnError(SRDebugger.Services.IConsoleService console) { }
        private System.Void CreateTrigger() { }
        private System.Void OnDestroy() { }
        private System.Void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2) { }
        private System.Void OnTriggerButtonClick() { }
        private System.Void SetTriggerPosition(UnityEngine.RectTransform t, SRDebugger.PinAlignment position) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class DockConsoleServiceImpl, IDockConsoleService
    {
        // Fields
        private SRDebugger.ConsoleAlignment _alignment;        // 0x10
        private SRDebugger.UI.Other.DockConsoleController _consoleRoot;        // 0x18
        private System.Boolean _didSuspendTrigger;        // 0x20
        private System.Boolean _isExpanded;        // 0x21
        private System.Boolean _isVisible;        // 0x22

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_IsVisible() { }
        private System.Void set_IsVisible(System.Boolean value) { }
        private System.Boolean get_IsExpanded() { }
        private System.Void set_IsExpanded(System.Boolean value) { }
        private SRDebugger.ConsoleAlignment get_Alignment() { }
        private System.Void set_Alignment(SRDebugger.ConsoleAlignment value) { }
        private System.Void Load() { }
        private System.Void CheckTrigger() { }

    }

    // TypeToken: 0x200007F
    public class KeyboardShortcutListenerService : SRServiceBase`1
    {
        // Fields
        private System.Collections.Generic.List<SRDebugger.Settings.KeyboardShortcut> _shortcuts;        // 0x48

        // Methods
        private System.Void Awake() { }
        private System.Void ToggleTab(SRDebugger.DefaultTabs t) { }
        private System.Void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut) { }
        private System.Void Update() { }
        private System.Void UpdateInputSystem() { }
        private System.Void UpdateLegacyInputSystem() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class OptionsServiceImpl, IOptionsService
    {
        // Fields
        private System.EventHandler OptionsUpdated;        // 0x10
        private readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,System.Collections.Generic.List<SRDebugger.OptionDefinition>> _optionContainerLookup;        // 0x18
        private readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,SRDebugger.Services.Implementation.OptionsServiceImpl.OptionContainerEventHandler> _optionContainerEventHandlerLookup;        // 0x20
        private readonly System.Collections.Generic.List<SRDebugger.OptionDefinition> _options;        // 0x28
        private readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition> _optionsReadonly;        // 0x30

        // Methods
        private System.Void add_OptionsUpdated(System.EventHandler value) { }
        private System.Void remove_OptionsUpdated(System.EventHandler value) { }
        private System.Collections.Generic.ICollection<SRDebugger.OptionDefinition> get_Options() { }
        private System.Void OptionsContainerOnOptionAdded(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition) { }
        private System.Void OptionsContainerOnOptionRemoved(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition) { }
        private System.Void .ctor() { }
        private System.Void Scan(System.Object obj) { }
        private System.Void AddContainer(System.Object obj) { }
        private System.Void AddContainer(SRDebugger.IOptionContainer optionContainer) { }
        private System.Void RemoveContainer(System.Object obj) { }
        private System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer) { }
        private System.Void OnOptionsUpdated() { }

    }

    // TypeToken: 0x2000083
    public class PinEntryServiceImpl : SRServiceBase`1, IPinEntryService
    {
        // Fields
        private SRDebugger.Services.PinEntryCompleteCallback _callback;        // 0x48
        private System.Boolean _isVisible;        // 0x50
        private SRDebugger.UI.Controls.PinEntryControl _pinControl;        // 0x58
        private readonly System.Collections.Generic.List<System.Int32> _requiredPin;        // 0x60

        // Methods
        private System.Boolean get_IsShowingKeypad() { }
        private System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel) { }
        private System.Void Awake() { }
        private System.Void Load() { }
        private System.Void PinControlOnComplete(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel) { }
        private System.Void VerifyPin(System.Collections.Generic.IReadOnlyList<System.Int32> pin) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class PinnedUIServiceImpl : SRServiceBase`1, IPinnedUIService
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controlList;        // 0x48
        private readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase> _pinnedObjects;        // 0x50
        private System.Boolean _queueRefresh;        // 0x58
        private SRDebugger.UI.Other.PinnedUIRoot _uiRoot;        // 0x60
        private System.Action<SRDebugger.OptionDefinition,System.Boolean> OptionPinStateChanged;        // 0x68
        private System.Action<UnityEngine.RectTransform> OptionsCanvasCreated;        // 0x70

        // Methods
        private SRDebugger.UI.Other.DockConsoleController get_DockConsoleController() { }
        private System.Void add_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value) { }
        private System.Void remove_OptionPinStateChanged(System.Action<SRDebugger.OptionDefinition,System.Boolean> value) { }
        private System.Void add_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value) { }
        private System.Void remove_OptionsCanvasCreated(System.Action<UnityEngine.RectTransform> value) { }
        private System.Boolean get_IsProfilerPinned() { }
        private System.Void set_IsProfilerPinned(System.Boolean value) { }
        private System.Void Pin(SRDebugger.OptionDefinition obj, System.Int32 order) { }
        private System.Void Unpin(SRDebugger.OptionDefinition obj) { }
        private System.Void OnPinnedStateChanged(SRDebugger.OptionDefinition option, System.Boolean isPinned) { }
        private System.Void UnpinAll() { }
        private System.Boolean HasPinned(SRDebugger.OptionDefinition option) { }
        private System.Void Awake() { }
        private System.Void Load() { }
        private System.Void UpdateAnchors() { }
        private System.Void Update() { }
        private System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs) { }
        private System.Void OnDebugPanelVisibilityChanged(System.Boolean isVisible) { }
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public class SRDebugService, IDebugService
    {
        // Fields
        private SRDebugger.VisibilityChangedDelegate PanelVisibilityChanged;        // 0x10
        private SRDebugger.PinnedUiCanvasCreated PinnedUiCanvasCreated;        // 0x18
        private readonly SRDebugger.Services.IDebugPanelService _debugPanelService;        // 0x20
        private readonly SRDebugger.Services.IDebugTriggerService _debugTrigger;        // 0x28
        private readonly SRDebugger.Services.ISystemInformationService _informationService;        // 0x30
        private readonly SRDebugger.Services.IOptionsService _optionsService;        // 0x38
        private readonly SRDebugger.Services.IPinnedUIService _pinnedUiService;        // 0x40
        private SRDebugger.Services.IConsoleFilterState _consoleFilterState;        // 0x48
        private System.Nullable<SRDebugger.EntryCode> _entryCode;        // 0x50
        private System.Boolean _hasAuthorised;        // 0x64
        private System.Nullable<SRDebugger.DefaultTabs> _queuedTab;        // 0x68
        private UnityEngine.RectTransform _worldSpaceTransform;        // 0x70
        private SRDebugger.DynamicOptionContainer _looseOptionContainer;        // 0x78

        // Methods
        private SRDebugger.Services.IDockConsoleService get_DockConsole() { }
        private SRDebugger.Services.IConsoleFilterState get_ConsoleFilter() { }
        private System.Void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value) { }
        private System.Void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value) { }
        private System.Void add_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value) { }
        private System.Void remove_PinnedUiCanvasCreated(SRDebugger.PinnedUiCanvasCreated value) { }
        private System.Void .ctor() { }
        private SRDebugger.Settings get_Settings() { }
        private System.Boolean get_IsDebugPanelVisible() { }
        private System.Boolean get_IsTriggerEnabled() { }
        private System.Void set_IsTriggerEnabled(System.Boolean value) { }
        private System.Boolean get_IsTriggerErrorNotificationEnabled() { }
        private System.Void set_IsTriggerErrorNotificationEnabled(System.Boolean value) { }
        private System.Boolean get_IsProfilerDocked() { }
        private System.Void set_IsProfilerDocked(System.Boolean value) { }
        private System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category) { }
        private System.Void ShowDebugPanel(System.Boolean requireEntryCode) { }
        private System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode) { }
        private System.Void HideDebugPanel() { }
        private System.Void SetEntryCode(SRDebugger.EntryCode newCode) { }
        private System.Void DisableEntryCode() { }
        private System.Void DestroyDebugPanel() { }
        private System.Void AddOptionContainer(System.Object container) { }
        private System.Void RemoveOptionContainer(System.Object container) { }
        private System.Void AddOption(SRDebugger.OptionDefinition option) { }
        private System.Boolean RemoveOption(SRDebugger.OptionDefinition option) { }
        private System.Void PinAllOptions(System.String category) { }
        private System.Void UnpinAllOptions(System.String category) { }
        private System.Void PinOption(System.String name) { }
        private System.Void UnpinOption(System.String name) { }
        private System.Void ClearPinnedOptions() { }
        private System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent) { }
        private System.Void DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b) { }
        private System.Void PromptEntryCode() { }
        private UnityEngine.RectTransform EnableWorldSpaceMode() { }
        private System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler) { }
        private System.Void <.ctor>b__21_0(UnityEngine.RectTransform transform) { }
        private System.Void <PromptEntryCode>b__53_0(System.Boolean entered) { }

    }

    // TypeToken: 0x2000087
    public class StandardConsoleService, IConsoleService, IDisposable
    {
        // Fields
        private readonly System.Boolean _collapseEnabled;        // 0x10
        private System.Boolean _hasCleared;        // 0x11
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _allConsoleEntries;        // 0x18
        private SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _consoleEntries;        // 0x20
        private readonly System.Object _threadLock;        // 0x28
        private UnityEngine.ILogHandler _expectedLogHandler;        // 0x30
        private System.Int32 <CriticalCount>k__BackingField;        // 0x38
        private System.Int32 <ErrorCount>k__BackingField;        // 0x3C
        private System.Int32 <WarningCount>k__BackingField;        // 0x40
        private System.Int32 <InfoCount>k__BackingField;        // 0x44
        private SRDebugger.Services.ConsoleUpdatedEventHandler Updated;        // 0x48
        private SRDebugger.Services.ConsoleUpdatedEventHandler Error;        // 0x50

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Int32 get_CriticalCount() { }
        private System.Void set_CriticalCount(System.Int32 value) { }
        private System.Int32 get_ErrorCount() { }
        private System.Void set_ErrorCount(System.Int32 value) { }
        private System.Int32 get_WarningCount() { }
        private System.Void set_WarningCount(System.Int32 value) { }
        private System.Int32 get_InfoCount() { }
        private System.Void set_InfoCount(System.Int32 value) { }
        private System.Void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Void add_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Void remove_Error(SRDebugger.Services.ConsoleUpdatedEventHandler value) { }
        private System.Boolean get_LoggingEnabled() { }
        private System.Void set_LoggingEnabled(System.Boolean value) { }
        private System.Boolean get_LogHandlerIsOverriden() { }
        private System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries() { }
        private System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries() { }
        private System.Void Clear() { }
        private System.Void OnEntryAdded(SRDebugger.Services.ConsoleEntry entry) { }
        private System.Void OnEntryDuplicated(SRDebugger.Services.ConsoleEntry entry) { }
        private System.Void OnUpdated() { }
        private System.Void UnityLogCallback(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.Void AdjustCounter(UnityEngine.LogType type, System.Int32 amount) { }

    }

    // TypeToken: 0x2000088
    public class StandardSystemInformationService, ISystemInformationService
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.IList<SRDebugger.InfoEntry>> _info;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Collections.Generic.IEnumerable<System.String> GetCategories() { }
        private System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category) { }
        private System.Void Add(SRDebugger.InfoEntry info, System.String category) { }
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate) { }
        private System.Void CreateDefaultSet() { }
        private System.String GetCloudManifestPrettyName(System.String name) { }

    }

}

namespace SRDebugger.UI
{

    // TypeToken: 0x2000024
    public class ProfilerFPSLabel : SRMonoBehaviourEx
    {
        // Fields
        private System.Single _nextUpdate;        // 0x48
        private SRDebugger.Services.IProfilerService _profilerService;        // 0x50
        public System.Single UpdateFrequency;        // 0x58
        private UnityEngine.UI.Text _text;        // 0x60

        // Methods
        private System.Void Update() { }
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class DebugPanelRoot : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;        // 0x48
        public UnityEngine.CanvasGroup CanvasGroup;        // 0x50
        public SRDebugger.Scripts.DebuggerTabController TabController;        // 0x58

        // Methods
        private System.Void Close() { }
        private System.Void CloseAndDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class MobileMenuController : SRMonoBehaviourEx
    {
        // Fields
        private UnityEngine.UI.Button _closeButton;        // 0x48
        private System.Single _maxMenuWidth;        // 0x50
        private System.Single _peekAmount;        // 0x54
        private System.Single _targetXPosition;        // 0x58
        public UnityEngine.RectTransform Content;        // 0x60
        public UnityEngine.RectTransform Menu;        // 0x68
        public UnityEngine.UI.Button OpenButton;        // 0x70
        public SRDebugger.UI.Other.SRTabController TabController;        // 0x78

        // Methods
        private System.Single get_PeekAmount() { }
        private System.Single get_MaxMenuWidth() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void CreateCloseButton() { }
        private System.Void SetRectSize(UnityEngine.RectTransform rect) { }
        private System.Void CloseButtonClicked() { }
        private System.Void Update() { }
        private System.Void TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab) { }
        private System.Void Open() { }
        private System.Void Close() { }
        private System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Controls
{

    // TypeToken: 0x2000048
    public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
    {
        // Fields
        public static System.String ConsoleBlobInfo;        // 0x0
        public static System.String ConsoleBlobWarning;        // 0x0
        public static System.String ConsoleBlobError;        // 0x0
        public static System.String ConsoleBlobCritical;        // 0x0
        private System.Int32 _count;        // 0x48
        private System.Boolean _hasCount;        // 0x4C
        private SRDebugger.Services.ConsoleEntry _prevData;        // 0x50
        private UnityEngine.RectTransform _rectTransform;        // 0x58
        public UnityEngine.UI.Text Count;        // 0x60
        public UnityEngine.CanvasGroup CountContainer;        // 0x68
        public SRF.UI.StyleComponent ImageStyle;        // 0x70
        public UnityEngine.UI.Text Message;        // 0x78
        public UnityEngine.UI.Text StackTrace;        // 0x80

        // Methods
        private System.Void SetDataContext(System.Object data) { }
        private System.Void Awake() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class ConsoleLogControl : SRMonoBehaviourEx
    {
        // Fields
        private SRF.UI.Layout.VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;        // 0x48
        private UnityEngine.UI.ScrollRect _consoleScrollRect;        // 0x50
        private System.Boolean _isDirty;        // 0x58
        private System.Nullable<UnityEngine.Vector2> _scrollPosition;        // 0x5C
        private System.Boolean _showCriticals;        // 0x68
        private System.Boolean _showErrors;        // 0x69
        private System.Boolean _showInfo;        // 0x6A
        private System.Boolean _showWarnings;        // 0x6B
        public System.Action<SRDebugger.Services.ConsoleEntry> SelectedItemChanged;        // 0x70
        private System.String _filter;        // 0x78

        // Methods
        private System.Boolean get_ShowCriticals() { }
        private System.Void set_ShowCriticals(System.Boolean value) { }
        private System.Boolean get_ShowErrors() { }
        private System.Void set_ShowErrors(System.Boolean value) { }
        private System.Boolean get_ShowWarnings() { }
        private System.Void set_ShowWarnings(System.Boolean value) { }
        private System.Boolean get_ShowInfo() { }
        private System.Void set_ShowInfo(System.Boolean value) { }
        private System.Boolean get_EnableSelection() { }
        private System.Void set_EnableSelection(System.Boolean value) { }
        private System.String get_Filter() { }
        private System.Void set_Filter(System.String value) { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Collections.IEnumerator ScrollToBottom() { }
        private System.Void OnDestroy() { }
        private System.Void OnSelectedItemChanged(System.Object arg0) { }
        private System.Void Update() { }
        private System.Void Refresh() { }
        private System.Void SetIsDirty() { }
        private System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class DataBoundControl : OptionsControlBase
    {
        // Fields
        private System.Boolean _hasStarted;        // 0x60
        private System.Boolean _isReadOnly;        // 0x61
        private System.Object _prevValue;        // 0x68
        private SRF.Helpers.PropertyReference _prop;        // 0x70
        private System.String <PropertyName>k__BackingField;        // 0x78

        // Methods
        private SRF.Helpers.PropertyReference get_Property() { }
        private System.Boolean get_IsReadOnly() { }
        private System.String get_PropertyName() { }
        private System.Void set_PropertyName(System.String value) { }
        private System.Void Bind(System.String propertyName, SRF.Helpers.PropertyReference prop) { }
        private System.Void OnValueChanged(SRF.Helpers.PropertyReference property) { }
        private System.Void UpdateValue(System.Object newValue) { }
        private System.Void Refresh() { }
        private System.Void OnBind(System.String propertyName, System.Type t) { }
        private System.Void OnValueUpdated(System.Object newValue) { }
        private System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class OptionsControlBase : SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _selectionModeEnabled;        // 0x48
        public UnityEngine.UI.Toggle SelectionModeToggle;        // 0x50
        public SRDebugger.OptionDefinition Option;        // 0x58

        // Methods
        private System.Boolean get_SelectionModeEnabled() { }
        private System.Void set_SelectionModeEnabled(System.Boolean value) { }
        private System.Boolean get_IsSelected() { }
        private System.Void set_IsSelected(System.Boolean value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class InfoBlock : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.UI.Text Content;        // 0x48
        public UnityEngine.UI.Text Title;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class MultiTapButton : Button
    {
        // Fields
        private System.Single _lastTap;        // 0x188
        private System.Int32 _tapCount;        // 0x18C
        public System.Int32 RequiredTapCount;        // 0x190
        public System.Single ResetTime;        // 0x194

        // Methods
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class PinEntryControlCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel) { }
        private System.IAsyncResult BeginInvoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000050
    public class PinEntryControl : SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _isVisible;        // 0x48
        private System.Collections.Generic.List<System.Int32> _numbers;        // 0x50
        public UnityEngine.UI.Image Background;        // 0x58
        public System.Boolean CanCancel;        // 0x60
        public UnityEngine.UI.Button CancelButton;        // 0x68
        public UnityEngine.UI.Text CancelButtonText;        // 0x70
        public UnityEngine.CanvasGroup CanvasGroup;        // 0x78
        public UnityEngine.Animator DotAnimator;        // 0x80
        public UnityEngine.UI.Button[] NumberButtons;        // 0x88
        public UnityEngine.UI.Toggle[] NumberDots;        // 0x90
        public UnityEngine.UI.Text PromptText;        // 0x98
        private SRDebugger.UI.Controls.PinEntryControlCallback Complete;        // 0xA0

        // Methods
        private System.Void add_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value) { }
        private System.Void remove_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void HandleCharacter(System.Char i) { }
        private System.Void Show() { }
        private System.Void Hide() { }
        private System.Void Clear() { }
        private System.Void PlayInvalidCodeAnimation() { }
        private System.Void OnComplete() { }
        private System.Void OnCancel() { }
        private System.Void CancelButtonPressed() { }
        private System.Void PushNumber(System.Int32 number) { }
        private System.Void RefreshState() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class ProfilerMemoryBlock : SRMonoBehaviourEx
    {
        // Fields
        private System.Single _lastRefresh;        // 0x48
        public UnityEngine.UI.Text CurrentUsedText;        // 0x50
        public UnityEngine.UI.Slider Slider;        // 0x58
        public UnityEngine.UI.Text TotalAllocatedText;        // 0x60

        // Methods
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void TriggerRefresh() { }
        private System.Void TriggerCleanup() { }
        private System.Collections.IEnumerator CleanUp() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class ProfilerMonoBlock : SRMonoBehaviourEx
    {
        // Fields
        private System.Single _lastRefresh;        // 0x48
        public UnityEngine.UI.Text CurrentUsedText;        // 0x50
        public UnityEngine.GameObject NotSupportedMessage;        // 0x58
        public UnityEngine.UI.Slider Slider;        // 0x60
        public UnityEngine.UI.Text TotalAllocatedText;        // 0x68
        private System.Boolean _isSupported;        // 0x70

        // Methods
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void TriggerRefresh() { }
        private System.Void TriggerCollection() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class ProfilerEnableControl : SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _previousState;        // 0x48
        public UnityEngine.UI.Text ButtonText;        // 0x50
        public UnityEngine.UI.Button EnableButton;        // 0x58
        public UnityEngine.UI.Text Text;        // 0x60

        // Methods
        private System.Void Start() { }
        private System.Void UpdateLabels() { }
        private System.Void Update() { }
        private System.Void ToggleProfiler() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
    {
        // Fields
        private System.Single _prevFrameTime;        // 0x48
        private System.Nullable<System.Single> _queuedFrameTime;        // 0x4C
        private System.Single _yPosition;        // 0x54
        public UnityEngine.UI.Text Text;        // 0x58

        // Methods
        private System.Void Update() { }
        private System.Void SetValue(System.Single frameTime, System.Single yPosition) { }
        private System.Void SetValueInternal(System.Single frameTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000057
    public class ProfilerGraphControl : Graphic
    {
        // Fields
        public SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments VerticalAlignment;        // 0xB0
        private static readonly System.Single[] ScaleSteps;        // 0x0
        public System.Boolean FloatingScale;        // 0xB4
        public System.Boolean TargetFpsUseApplication;        // 0xB5
        public System.Boolean DrawAxes;        // 0xB6
        public System.Int32 TargetFps;        // 0xB8
        public System.Boolean Clip;        // 0xBC
        public static System.Single DataPointMargin;        // 0x0
        public static System.Single DataPointVerticalMargin;        // 0x0
        public static System.Single DataPointWidth;        // 0x0
        public System.Int32 VerticalPadding;        // 0xC0
        public static System.Int32 LineCount;        // 0x0
        public UnityEngine.Color[] LineColours;        // 0xC8
        private SRDebugger.Services.IProfilerService _profilerService;        // 0xD0
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel[] _axisLabels;        // 0xD8
        private UnityEngine.Rect _clipBounds;        // 0xE0
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> _meshVertices;        // 0xF0
        private readonly System.Collections.Generic.List<UnityEngine.Color32> _meshVertexColors;        // 0xF8
        private readonly System.Collections.Generic.List<System.Int32> _meshTriangles;        // 0x100

        // Methods
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void OnPopulateMesh(UnityEngine.Mesh m) { }
        private System.Void DrawDataPoint(System.Single xPosition, System.Single verticalScale, SRDebugger.Services.ProfilerFrame frame) { }
        private System.Void DrawAxis(System.Single frameTime, System.Single yPosition, SRDebugger.UI.Controls.ProfilerGraphAxisLabel label) { }
        private System.Void AddRect(UnityEngine.Vector3 tl, UnityEngine.Vector3 tr, UnityEngine.Vector3 bl, UnityEngine.Vector3 br, UnityEngine.Color c) { }
        private SRDebugger.Services.ProfilerFrame GetFrame(System.Int32 i) { }
        private System.Int32 CalculateVisibleDataPointCount() { }
        private System.Int32 GetFrameBufferCurrentSize() { }
        private System.Int32 GetFrameBufferMaxSize() { }
        private System.Single CalculateMaxFrameTime() { }
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel GetAxisLabel(System.Int32 index) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000059
    public class SRTabButton : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Behaviour ActiveToggle;        // 0x48
        public UnityEngine.UI.Button Button;        // 0x50
        public UnityEngine.RectTransform ExtraContentContainer;        // 0x58
        public SRF.UI.StyleComponent IconStyleComponent;        // 0x60
        public UnityEngine.UI.Text TitleText;        // 0x68

        // Methods
        private System.Boolean get_IsActive() { }
        private System.Void set_IsActive(System.Boolean value) { }
        private System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Controls.Data
{

    // TypeToken: 0x200005A
    public class ActionControl : OptionsControlBase
    {
        // Fields
        private SRF.Helpers.MethodReference _method;        // 0x60
        public UnityEngine.UI.Button Button;        // 0x68
        public UnityEngine.UI.Text Title;        // 0x70

        // Methods
        private SRF.Helpers.MethodReference get_Method() { }
        private System.Void Start() { }
        private System.Void ButtonOnClick() { }
        private System.Void SetMethod(System.String methodName, SRF.Helpers.MethodReference method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class BoolControl : DataBoundControl
    {
        // Fields
        public UnityEngine.UI.Text Title;        // 0x80
        public UnityEngine.UI.Toggle Toggle;        // 0x88

        // Methods
        private System.Void Start() { }
        private System.Void ToggleOnValueChanged(System.Boolean isOn) { }
        private System.Void OnBind(System.String propertyName, System.Type t) { }
        private System.Void OnValueUpdated(System.Object newValue) { }
        private System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class EnumControl : DataBoundControl
    {
        // Fields
        private System.Object _lastValue;        // 0x80
        private System.String[] _names;        // 0x88
        private System.Array _values;        // 0x90
        public UnityEngine.UI.LayoutElement ContentLayoutElement;        // 0x98
        public UnityEngine.GameObject[] DisableOnReadOnly;        // 0xA0
        public SRF.UI.SRSpinner Spinner;        // 0xA8
        public UnityEngine.UI.Text Title;        // 0xB0
        public UnityEngine.UI.Text Value;        // 0xB8

        // Methods
        private System.Void Start() { }
        private System.Void OnBind(System.String propertyName, System.Type t) { }
        private System.Void OnValueUpdated(System.Object newValue) { }
        private System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        private System.Void SetIndex(System.Int32 i) { }
        private System.Void GoToNext() { }
        private System.Void GoToPrevious() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class NumberControl : DataBoundControl
    {
        // Fields
        private static readonly System.Type[] IntegerTypes;        // 0x0
        private static readonly System.Type[] DecimalTypes;        // 0x8
        public static readonly System.Collections.Generic.Dictionary<System.Type,SRDebugger.UI.Controls.Data.NumberControl.ValueRange> ValueRanges;        // 0x10
        private System.String _lastValue;        // 0x80
        private System.Type _type;        // 0x88
        public UnityEngine.GameObject[] DisableOnReadOnly;        // 0x90
        public SRF.UI.SRNumberButton DownNumberButton;        // 0x98
        public SRF.UI.SRNumberSpinner NumberSpinner;        // 0xA0
        public UnityEngine.UI.Text Title;        // 0xA8
        public SRF.UI.SRNumberButton UpNumberButton;        // 0xB0

        // Methods
        private System.Void Start() { }
        private System.Void OnValueChanged(System.String newValue) { }
        private System.Void OnBind(System.String propertyName, System.Type t) { }
        private System.Void OnValueUpdated(System.Object newValue) { }
        private System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        private System.Boolean IsIntegerType(System.Type t) { }
        private System.Boolean IsDecimalType(System.Type t) { }
        private System.Double GetMaxValue(System.Type t) { }
        private System.Double GetMinValue(System.Type t) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005F
    public class ReadOnlyControl : DataBoundControl
    {
        // Fields
        public UnityEngine.UI.Text ValueText;        // 0x80
        public UnityEngine.UI.Text Title;        // 0x88

        // Methods
        private System.Void Start() { }
        private System.Void OnBind(System.String propertyName, System.Type t) { }
        private System.Void OnValueUpdated(System.Object newValue) { }
        private System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public class StringControl : DataBoundControl
    {
        // Fields
        public UnityEngine.UI.InputField InputField;        // 0x80
        public UnityEngine.UI.Text Title;        // 0x88

        // Methods
        private System.Void Start() { }
        private System.Void OnValueChanged(System.String newValue) { }
        private System.Void OnBind(System.String propertyName, System.Type t) { }
        private System.Void OnValueUpdated(System.Object newValue) { }
        private System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        private System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Other
{

    // TypeToken: 0x2000031
    public class BugReportPopoverRoot : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.CanvasGroup CanvasGroup;        // 0x48
        public UnityEngine.RectTransform Container;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class BugReportSheetController : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.GameObject ButtonContainer;        // 0x48
        public UnityEngine.UI.Text ButtonText;        // 0x50
        public UnityEngine.UI.Button CancelButton;        // 0x58
        public System.Action CancelPressed;        // 0x60
        public UnityEngine.UI.InputField DescriptionField;        // 0x68
        public UnityEngine.UI.InputField EmailField;        // 0x70
        public UnityEngine.UI.Slider ProgressBar;        // 0x78
        public UnityEngine.UI.Text ResultMessageText;        // 0x80
        public System.Action ScreenshotComplete;        // 0x88
        public UnityEngine.UI.Button SubmitButton;        // 0x90
        public System.Action<System.Boolean,System.String> SubmitComplete;        // 0x98
        public System.Action TakingScreenshot;        // 0xA0

        // Methods
        private System.Boolean get_IsCancelButtonEnabled() { }
        private System.Void set_IsCancelButtonEnabled(System.Boolean value) { }
        private System.Void Start() { }
        private System.Void Submit() { }
        private System.Void Cancel() { }
        private System.Collections.IEnumerator SubmitCo() { }
        private System.Void OnBugReportProgress(System.Single progress) { }
        private System.Void OnBugReportComplete(System.Boolean didSucceed, System.String errorMessage) { }
        private System.Void SetLoadingSpinnerVisible(System.Boolean visible) { }
        private System.Void ClearForm() { }
        private System.Void ShowErrorMessage(System.String userMessage, System.String serverMessage) { }
        private System.Void ClearErrorMessage() { }
        private System.Void SetFormEnabled(System.Boolean e) { }
        private System.String GetDefaultEmailFieldContents() { }
        private System.Void SetDefaultEmailFieldContents(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class CategoryGroup : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.RectTransform Container;        // 0x48
        public UnityEngine.UI.Text Header;        // 0x50
        public UnityEngine.GameObject Background;        // 0x58
        public UnityEngine.UI.Toggle SelectionToggle;        // 0x60
        public UnityEngine.GameObject[] EnabledDuringSelectionMode;        // 0x68
        private System.Boolean _selectionModeEnabled;        // 0x70

        // Methods
        private System.Boolean get_IsSelected() { }
        private System.Void set_IsSelected(System.Boolean value) { }
        private System.Boolean get_SelectionModeEnabled() { }
        private System.Void set_SelectionModeEnabled(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000035
    public class ConfigureCanvasFromSettings : SRMonoBehaviour
    {
        // Fields
        private UnityEngine.Canvas _canvas;        // 0x48
        private UnityEngine.UI.CanvasScaler _canvasScaler;        // 0x50
        private System.Single _originalScale;        // 0x58
        private System.Single _lastSetScale;        // 0x5C
        private SRDebugger.Settings _settings;        // 0x60

        // Methods
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void SettingsOnPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000036
    public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
    {
        // Fields
        private static System.Int32 Max;        // 0x0
        private static readonly System.String MaxString;        // 0x0
        private System.Int32 _prevCriticalCount;        // 0x48
        private System.Int32 _prevErrorCount;        // 0x4C
        private System.Int32 _prevInfoCount;        // 0x50
        private System.Int32 _prevWarningCount;        // 0x54
        public SRDebugger.Services.IConsoleService ConsoleService;        // 0x58
        public UnityEngine.UI.Text CriticalCountText;        // 0x60
        public UnityEngine.UI.Text ErrorCountText;        // 0x68
        public UnityEngine.UI.Text InfoCountText;        // 0x70
        public UnityEngine.UI.Text WarningCountText;        // 0x78

        // Methods
        private System.Void Awake() { }
        private System.Void Update() { }
        private System.Boolean HasChanged(System.Int32 newCount, System.Int32& oldCount, System.Int32 max) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000037
    public class DebugPanelBackgroundBehaviour : SRMonoBehaviour
    {
        // Fields
        private SRF.UI.StyleComponent _styleComponent;        // 0x48
        public System.String TransparentStyleKey;        // 0x50
        private SRF.UI.StyleSheet _styleSheet;        // 0x58

        // Methods
        private System.Void Awake() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        public static System.Single NonFocusOpacity;        // 0x0
        private System.Boolean _isDirty;        // 0x48
        private System.Boolean _isDragging;        // 0x49
        private System.Int32 _pointersOver;        // 0x4C
        public SRDebugger.Services.IConsoleFilterState FilterState;        // 0x50
        public UnityEngine.GameObject BottomHandle;        // 0x58
        public UnityEngine.CanvasGroup CanvasGroup;        // 0x60
        public SRDebugger.UI.Controls.ConsoleLogControl Console;        // 0x68
        public UnityEngine.GameObject Dropdown;        // 0x70
        public UnityEngine.UI.Image DropdownToggleSprite;        // 0x78
        public UnityEngine.UI.Text TextCriticals;        // 0x80
        public UnityEngine.UI.Text TextErrors;        // 0x88
        public UnityEngine.UI.Text TextInfo;        // 0x90
        public UnityEngine.UI.Text TextWarnings;        // 0x98
        public UnityEngine.UI.Toggle ToggleCriticals;        // 0xA0
        public UnityEngine.UI.Toggle ToggleErrors;        // 0xA8
        public UnityEngine.UI.Toggle ToggleInfo;        // 0xB0
        public UnityEngine.UI.Toggle ToggleWarnings;        // 0xB8
        public UnityEngine.GameObject TopBar;        // 0xC0
        public UnityEngine.GameObject TopHandle;        // 0xC8
        public UnityEngine.GameObject TopSafeAreaSpacer;        // 0xD0
        public UnityEngine.GameObject BottomSafeAreaSpacer;        // 0xD8

        // Methods
        private System.Boolean get_IsVisible() { }
        private System.Void set_IsVisible(System.Boolean value) { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void OnFilterStateChange(UnityEngine.LogType logType, System.Boolean newState) { }
        private System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console) { }
        private System.Void SetDropdownVisibility(System.Boolean visible) { }
        private System.Void SetAlignmentMode(SRDebugger.ConsoleAlignment alignment) { }
        private System.Void Refresh() { }
        private System.Void RefreshAlpha() { }
        private System.Void ToggleDropdownVisible() { }
        private System.Void MenuButtonPressed() { }
        private System.Void ClearButtonPressed() { }
        private System.Void TogglesUpdated() { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData e) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData e) { }
        private System.Void OnBeginDrag() { }
        private System.Void OnEndDrag() { }
        private System.Void .ctor() { }
        private System.Void <Start>b__25_0(System.Boolean isOn) { }
        private System.Void <Start>b__25_1(System.Boolean isOn) { }
        private System.Void <Start>b__25_2(System.Boolean isOn) { }
        private System.Void <Start>b__25_3(System.Boolean isOn) { }

    }

    // TypeToken: 0x2000039
    public class ErrorNotifier : MonoBehaviour
    {
        // Fields
        private static System.Single DisplayTime;        // 0x0
        private UnityEngine.Animator _animator;        // 0x18
        private System.Int32 _triggerHash;        // 0x20
        private System.Single _hideTime;        // 0x24
        private System.Boolean _isShowing;        // 0x28
        private System.Boolean _queueWarning;        // 0x29

        // Methods
        private System.Boolean get_IsVisible() { }
        private System.Void Awake() { }
        private System.Void ShowErrorWarning() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class FloatOverElement : UIBehaviour, ILayoutSelfController, ILayoutController
    {
        // Fields
        public UnityEngine.RectTransform CopyFrom;        // 0x18
        private UnityEngine.DrivenRectTransformTracker _tracker;        // 0x20

        // Methods
        private System.Void Copy() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class HandleManager : SRMonoBehaviour
    {
        // Fields
        private System.Boolean _hasSet;        // 0x48
        public UnityEngine.GameObject BottomHandle;        // 0x50
        public UnityEngine.GameObject BottomLeftHandle;        // 0x58
        public UnityEngine.GameObject BottomRightHandle;        // 0x60
        public SRDebugger.PinAlignment DefaultAlignment;        // 0x68
        public UnityEngine.GameObject LeftHandle;        // 0x70
        public UnityEngine.GameObject RightHandle;        // 0x78
        public UnityEngine.GameObject TopHandle;        // 0x80
        public UnityEngine.GameObject TopLeftHandle;        // 0x88
        public UnityEngine.GameObject TopRightHandle;        // 0x90

        // Methods
        private System.Void Start() { }
        private System.Void SetAlignment(SRDebugger.PinAlignment alignment) { }
        private System.Void SetActive(UnityEngine.GameObject obj, System.Boolean active) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public interface IEnableTab
    {
        // Methods
        private System.Boolean get_IsEnabled() { }

    }

    // TypeToken: 0x200003D
    public class LoadingSpinnerBehaviour : SRMonoBehaviour
    {
        // Fields
        private System.Single _dt;        // 0x48
        public System.Int32 FrameCount;        // 0x4C
        public System.Single SpinDuration;        // 0x50

        // Methods
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class PinnedUIRoot : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;        // 0x48
        public UnityEngine.RectTransform Container;        // 0x50
        public SRDebugger.UI.Other.DockConsoleController DockConsoleController;        // 0x58
        public UnityEngine.GameObject Options;        // 0x60
        public SRF.UI.Layout.FlowLayoutGroup OptionsLayoutGroup;        // 0x68
        public UnityEngine.GameObject Profiler;        // 0x70
        public SRDebugger.UI.Other.HandleManager ProfilerHandleManager;        // 0x78
        public UnityEngine.UI.VerticalLayoutGroup ProfilerVerticalLayoutGroup;        // 0x80

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class SafeAreaSizer : UIBehaviour, ILayoutElement
    {
        // Fields
        private UnityEngine.RectTransform.Edge _edge;        // 0x18
        public System.Single Scale;        // 0x1C
        private System.Single _height;        // 0x20
        private System.Single _width;        // 0x24

        // Methods
        private UnityEngine.RectTransform.Edge get_Edge() { }
        private System.Void set_Edge(UnityEngine.RectTransform.Edge value) { }
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_minWidth() { }
        private System.Single get_minHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Single get_flexibleHeight() { }
        private System.Single get_flexibleWidth() { }
        private System.Void Refresh() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class ScrollSettingsBehaviour : MonoBehaviour
    {
        // Fields
        public static System.Single ScrollSensitivity;        // 0x0

        // Methods
        private System.Void Awake() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class SetLayerFromSettings : SRMonoBehaviour
    {
        // Methods
        private System.Void Start() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class SRTab : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.RectTransform HeaderExtraContent;        // 0x48
        public UnityEngine.Sprite Icon;        // 0x50
        public UnityEngine.RectTransform IconExtraContent;        // 0x58
        public System.String IconStyleKey;        // 0x60
        public System.Int32 SortIndex;        // 0x68
        public SRDebugger.UI.Controls.SRTabButton TabButton;        // 0x70
        private System.String _title;        // 0x78
        private System.String _longTitle;        // 0x80
        private System.String _key;        // 0x88

        // Methods
        private System.String get_Title() { }
        private System.String get_LongTitle() { }
        private System.String get_Key() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class SRTabController : SRMonoBehaviourEx
    {
        // Fields
        private readonly SRF.SRList<SRDebugger.UI.Other.SRTab> _tabs;        // 0x48
        private SRDebugger.UI.Other.SRTab _activeTab;        // 0x50
        public UnityEngine.RectTransform TabButtonContainer;        // 0x58
        public SRDebugger.UI.Controls.SRTabButton TabButtonPrefab;        // 0x60
        public UnityEngine.RectTransform TabContentsContainer;        // 0x68
        public UnityEngine.RectTransform TabHeaderContentContainer;        // 0x70
        public UnityEngine.UI.Text TabHeaderText;        // 0x78
        private System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> ActiveTabChanged;        // 0x80

        // Methods
        private SRDebugger.UI.Other.SRTab get_ActiveTab() { }
        private System.Void set_ActiveTab(SRDebugger.UI.Other.SRTab value) { }
        private System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> get_Tabs() { }
        private System.Void add_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> value) { }
        private System.Void remove_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> value) { }
        private System.Void AddTab(SRDebugger.UI.Other.SRTab tab, System.Boolean visibleInSidebar) { }
        private System.Void MakeActive(SRDebugger.UI.Other.SRTab tab) { }
        private System.Void SortTabs() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class TriggerRoot : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;        // 0x48
        public SRF.UI.LongPressButton TapHoldButton;        // 0x50
        public UnityEngine.RectTransform TriggerTransform;        // 0x58
        public SRDebugger.UI.Other.ErrorNotifier ErrorNotifier;        // 0x60
        public SRDebugger.UI.Controls.MultiTapButton TripleTapButton;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class VersionTextBehaviour : SRMonoBehaviourEx
    {
        // Fields
        public System.String Format;        // 0x48
        public UnityEngine.UI.Text Text;        // 0x50

        // Methods
        private System.Void Start() { }
        private System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Tabs
{

    // TypeToken: 0x2000027
    public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
    {
        // Fields
        public SRDebugger.UI.Other.BugReportSheetController BugReportSheetPrefab;        // 0x48
        public UnityEngine.RectTransform Container;        // 0x50

        // Methods
        private System.Boolean get_IsEnabled() { }
        private System.Void Start() { }
        private System.Void TakingScreenshot() { }
        private System.Void ScreenshotComplete() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class ConsoleTabController : SRMonoBehaviourEx
    {
        // Fields
        private static System.Int32 MaxLength;        // 0x0
        private UnityEngine.Canvas _consoleCanvas;        // 0x48
        private System.Boolean _isDirty;        // 0x50
        private static System.Boolean _hasWarnedAboutLogHandler;        // 0x0
        private static System.Boolean _hasWarnedAboutLoggingDisabled;        // 0x1
        public SRDebugger.Services.IConsoleFilterState FilterState;        // 0x58
        public SRDebugger.UI.Controls.ConsoleLogControl ConsoleLogControl;        // 0x60
        public UnityEngine.UI.Toggle PinToggle;        // 0x68
        public UnityEngine.UI.ScrollRect StackTraceScrollRect;        // 0x70
        public UnityEngine.UI.Text StackTraceText;        // 0x78
        public UnityEngine.UI.Toggle ToggleCriticals;        // 0x80
        public UnityEngine.UI.Text ToggleCriticalsText;        // 0x88
        public UnityEngine.UI.Toggle ToggleErrors;        // 0x90
        public UnityEngine.UI.Text ToggleErrorsText;        // 0x98
        public UnityEngine.UI.Toggle ToggleInfo;        // 0xA0
        public UnityEngine.UI.Text ToggleInfoText;        // 0xA8
        public UnityEngine.UI.Toggle ToggleWarnings;        // 0xB0
        public UnityEngine.UI.Text ToggleWarningsText;        // 0xB8
        public UnityEngine.GameObject CopyToClipboardContainer;        // 0xC0
        public UnityEngine.GameObject CopyToClipboardButton;        // 0xC8
        public UnityEngine.GameObject CopyToClipboardMessage;        // 0xD0
        public UnityEngine.CanvasGroup CopyToClipboardMessageCanvasGroup;        // 0xD8
        public UnityEngine.GameObject LoggingIsDisabledCanvasGroup;        // 0xE0
        public UnityEngine.GameObject LogHandlerHasBeenOverridenGroup;        // 0xE8
        public UnityEngine.UI.Toggle FilterToggle;        // 0xF0
        public UnityEngine.UI.InputField FilterField;        // 0xF8
        public UnityEngine.GameObject FilterBarContainer;        // 0x100
        private SRDebugger.Services.ConsoleEntry _selectedItem;        // 0x108
        private UnityEngine.Coroutine _fadeButtonCoroutine;        // 0x110

        // Methods
        private System.Void Start() { }
        private System.Void OnFilterStateChange(UnityEngine.LogType logtype, System.Boolean newstate) { }
        private System.Void FilterToggleValueChanged(System.Boolean isOn) { }
        private System.Void FilterValueChanged(System.String filterText) { }
        private System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b) { }
        private System.Void PinToggleValueChanged(System.Boolean isOn) { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void ConsoleLogSelectedItemChanged(System.Object item) { }
        private System.Void Update() { }
        private System.Void PopulateStackTraceArea(SRDebugger.Services.ConsoleEntry entry) { }
        private System.Void CopyToClipboard() { }
        private System.Void SetCopyToClipboardButtonState(SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates state) { }
        private System.Collections.IEnumerator FadeCopyButton() { }
        private System.Void StopAnimations() { }
        private System.Void Refresh() { }
        private System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console) { }
        private System.Void Clear() { }
        private System.Void LogHandlerHasBeenOverridenOkayButtonPress() { }
        private System.Void LoggingDisableCloseAndIgnorePressed() { }
        private System.Void LoggingDisableReenablePressed() { }
        private System.Void .ctor() { }
        private System.Void <Start>b__29_0(System.Boolean isOn) { }
        private System.Void <Start>b__29_1(System.Boolean isOn) { }
        private System.Void <Start>b__29_2(System.Boolean isOn) { }
        private System.Void <Start>b__29_3(System.Boolean isOn) { }

    }

    // TypeToken: 0x200002B
    public class InfoTabController : SRMonoBehaviourEx
    {
        // Fields
        public static System.Char Tick;        // 0x0
        public static System.Char Cross;        // 0x0
        public static System.String NameColor;        // 0x0
        private System.Collections.Generic.Dictionary<System.String,SRDebugger.UI.Controls.InfoBlock> _infoBlocks;        // 0x48
        public SRDebugger.UI.Controls.InfoBlock InfoBlockPrefab;        // 0x50
        public UnityEngine.RectTransform LayoutContainer;        // 0x58
        public SRF.UI.FlashGraphic ToggleButton;        // 0x60
        private System.Boolean _updateEveryFrame;        // 0x68

        // Methods
        private System.Void OnEnable() { }
        private System.Void Refresh() { }
        private System.Void Update() { }
        private System.Void ActivateRefreshEveryFrame() { }
        private System.Void InternalRefresh() { }
        private System.Void FillInfoBlock(SRDebugger.UI.Controls.InfoBlock block, System.Collections.Generic.IList<SRDebugger.InfoEntry> info) { }
        private SRDebugger.UI.Controls.InfoBlock CreateBlock(System.String title) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class OptionsTabController : SRMonoBehaviourEx
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controls;        // 0x48
        private readonly System.Collections.Generic.List<SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance> _categories;        // 0x50
        private readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase> _options;        // 0x58
        private System.Boolean _queueRefresh;        // 0x60
        private System.Boolean _selectionModeEnabled;        // 0x61
        private UnityEngine.Canvas _optionCanvas;        // 0x68
        public SRDebugger.UI.Controls.Data.ActionControl ActionControlPrefab;        // 0x70
        public SRDebugger.UI.Other.CategoryGroup CategoryGroupPrefab;        // 0x78
        public UnityEngine.RectTransform ContentContainer;        // 0x80
        public UnityEngine.GameObject NoOptionsNotice;        // 0x88
        public UnityEngine.UI.Toggle PinButton;        // 0x90
        public UnityEngine.GameObject PinPromptSpacer;        // 0x98
        public UnityEngine.GameObject PinPromptText;        // 0xA0
        private System.Boolean _isTogglingCategory;        // 0xA8

        // Methods
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void OnOptionPinnedStateChanged(SRDebugger.OptionDefinition optionDefinition, System.Boolean isPinned) { }
        private System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b) { }
        private System.Void SetSelectionModeEnabled(System.Boolean isEnabled) { }
        private System.Void Refresh() { }
        private System.Void CommitPinnedOptions() { }
        private System.Void RefreshCategorySelection() { }
        private System.Void OnOptionSelectionToggle(System.Boolean selected) { }
        private System.Void OnCategorySelectionToggle(SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance category, System.Boolean selected) { }
        private System.Void Populate() { }
        private System.Void CreateCategory(System.String title, System.Collections.Generic.List<SRDebugger.OptionDefinition> options) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class ProfilerTabController : SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _isDirty;        // 0x48
        public UnityEngine.UI.Toggle PinToggle;        // 0x50

        // Methods
        private System.Void Start() { }
        private System.Void PinToggleValueChanged(System.Boolean isOn) { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void Refresh() { }
        private System.Void .ctor() { }

    }

}

