// ========================================================
// Dumped by @desirepro
// Assembly: Slate.dll
// Classes:  273
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000004
    public class SubtitlesGUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String text, UnityEngine.Color color) { }
        private System.IAsyncResult BeginInvoke(System.String text, UnityEngine.Color color, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000005
    public class TextOverlayGUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor alignment, UnityEngine.Vector2 position) { }
        private System.IAsyncResult BeginInvoke(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor alignment, UnityEngine.Vector2 position, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000006
    public class ImageOverlayGUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000007
    public class ScreenFadeGUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Color color) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Color color, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000008
    public class LetterboxGUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Single completion) { }
        private System.IAsyncResult BeginInvoke(System.Single completion, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000009
    public class CameraDissolveDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Texture texture, System.Single completion) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Texture texture, System.Single completion, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000C
    public struct TrackingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.DynamicCameraController.Transposer.TrackingMode None;        // 0x0
        public static Slate.DynamicCameraController.Transposer.TrackingMode OffsetTracking;        // 0x0
        public static Slate.DynamicCameraController.Transposer.TrackingMode RailTracking;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct OffsetMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.DynamicCameraController.Transposer.OffsetMode LocalSpace;        // 0x0
        public static Slate.DynamicCameraController.Transposer.OffsetMode WorldSpace;        // 0x0

    }

    // TypeToken: 0x200000B
    public class Transposer
    {
        // Fields
        public Slate.DynamicCameraController.Transposer.TrackingMode trackingMode;        // 0x10
        public UnityEngine.Transform target;        // 0x18
        public UnityEngine.Vector3 targetOffset;        // 0x20
        public Slate.DynamicCameraController.Transposer.OffsetMode offsetMode;        // 0x2C
        public UnityEngine.Vector3 railStart;        // 0x30
        public UnityEngine.Vector3 railEnd;        // 0x3C
        public System.Single railOffset;        // 0x48
        public System.Single smoothDamping;        // 0x4C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public struct TrackingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.DynamicCameraController.Composer.TrackingMode None;        // 0x0
        public static Slate.DynamicCameraController.Composer.TrackingMode FrameComposition;        // 0x0

    }

    // TypeToken: 0x200000E
    public class Composer
    {
        // Fields
        public Slate.DynamicCameraController.Composer.TrackingMode trackingMode;        // 0x10
        public UnityEngine.Transform target;        // 0x18
        public UnityEngine.Vector3 targetOffset;        // 0x20
        public System.Single targetSize;        // 0x2C
        public UnityEngine.Vector2 frameCenter;        // 0x30
        public UnityEngine.Vector2 frameExtends;        // 0x38
        public System.Single dutchTilt;        // 0x40
        public System.Boolean zoomAtTargetFrame;        // 0x44
        public System.Single smoothDamping;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public struct BlendInEffectType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.CameraShot.BlendInEffectType None;        // 0x0
        public static Slate.CameraShot.BlendInEffectType FadeFromColor;        // 0x0
        public static Slate.CameraShot.BlendInEffectType CrossDissolve;        // 0x0
        public static Slate.CameraShot.BlendInEffectType EaseIn;        // 0x0

    }

    // TypeToken: 0x2000038
    public struct BlendOutEffectType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.CameraShot.BlendOutEffectType None;        // 0x0
        public static Slate.CameraShot.BlendOutEffectType FadeToColor;        // 0x0

    }

    // TypeToken: 0x200004E
    public class SerializationMetaData
    {
        // Fields
        public System.String parameterName;        // 0x10
        public System.String declaringTypeName;        // 0x18
        public System.String transformHierarchyPath;        // 0x20
        public Slate.AnimatedParameter.ParameterType parameterType;        // 0x28
        private System.Type <declaringType>k__BackingField;        // 0x30
        private System.Reflection.PropertyInfo <property>k__BackingField;        // 0x38
        private System.Reflection.FieldInfo <field>k__BackingField;        // 0x40
        private System.Type <animatedType>k__BackingField;        // 0x48

        // Methods
        private System.Type get_declaringType() { }
        private System.Void set_declaringType(System.Type value) { }
        private System.Reflection.PropertyInfo get_property() { }
        private System.Void set_property(System.Reflection.PropertyInfo value) { }
        private System.Reflection.FieldInfo get_field() { }
        private System.Void set_field(System.Reflection.FieldInfo value) { }
        private System.Type get_animatedType() { }
        private System.Void set_animatedType(System.Type value) { }
        private System.Void Deserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public struct ParameterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.AnimatedParameter.ParameterType NotSet;        // 0x0
        public static Slate.AnimatedParameter.ParameterType Property;        // 0x0
        public static Slate.AnimatedParameter.ParameterType Field;        // 0x0

    }

    // TypeToken: 0x200005D
    public class AddParameterDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Type type, System.String memberPath, System.String transformPath) { }
        private System.IAsyncResult BeginInvoke(System.Type type, System.String memberPath, System.String transformPath, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000065
    public struct WrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.Cutscene.WrapMode Once;        // 0x0
        public static Slate.Cutscene.WrapMode Loop;        // 0x0
        public static Slate.Cutscene.WrapMode PingPong;        // 0x0

    }

    // TypeToken: 0x2000066
    public struct StopMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.Cutscene.StopMode Skip;        // 0x0
        public static Slate.Cutscene.StopMode Rewind;        // 0x0
        public static Slate.Cutscene.StopMode Hold;        // 0x0
        public static Slate.Cutscene.StopMode SkipRewindNoUndo;        // 0x0

    }

    // TypeToken: 0x2000067
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.Cutscene.UpdateMode Normal;        // 0x0
        public static Slate.Cutscene.UpdateMode AnimatePhysics;        // 0x0
        public static Slate.Cutscene.UpdateMode UnscaledTime;        // 0x0
        public static Slate.Cutscene.UpdateMode Manual;        // 0x0

    }

    // TypeToken: 0x2000068
    public struct PlayingDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.Cutscene.PlayingDirection Forwards;        // 0x0
        public static Slate.Cutscene.PlayingDirection Backwards;        // 0x0

    }

    // TypeToken: 0x200006F
    public struct ActorReferenceMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.CutsceneGroup.ActorReferenceMode UseOriginal;        // 0x0
        public static Slate.CutsceneGroup.ActorReferenceMode UseInstanceHideOriginal;        // 0x0

    }

    // TypeToken: 0x2000070
    public struct ActorInitialTransformation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.CutsceneGroup.ActorInitialTransformation UseOriginal;        // 0x0
        public static Slate.CutsceneGroup.ActorInitialTransformation UseLocal;        // 0x0

    }

    // TypeToken: 0x2000071
    public class CustomToggleInfo
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public System.Int32 endIndex;        // 0x14
        public System.String desc;        // 0x18
        public System.Boolean isCollapsed;        // 0x20
        private System.Int32 <index>k__BackingField;        // 0x24
        private Slate.CutsceneGroup <group>k__BackingField;        // 0x28

        // Methods
        private System.Int32 get_index() { }
        private System.Void set_index(System.Int32 value) { }
        private Slate.CutsceneGroup get_group() { }
        private System.Void set_group(Slate.CutsceneGroup value) { }
        private System.Void _OnToggleChanged() { }
        private System.Collections.IEnumerable _GetAllTrackNames() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public struct ExitMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.Section.ExitMode Continue;        // 0x0
        public static Slate.Section.ExitMode Loop;        // 0x0

    }

    // TypeToken: 0x200008A
    public struct HandleStyle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.BezierPoint.HandleStyle Connected;        // 0x0
        public static Slate.BezierPoint.HandleStyle Broken;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct SampleSettings
    {
        // Fields
        public System.Single volume;        // 0x10
        public System.Single pitch;        // 0x14
        public System.Single pan;        // 0x18
        public System.Single spatialBlend;        // 0x1C
        public System.Boolean ignoreTimescale;        // 0x20
        public System.Boolean bypassReverb;        // 0x21

        // Methods
        private Slate.AudioSampler.SampleSettings Default() { }

    }

    // TypeToken: 0x20000A6
    public struct StoreMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.TransformSnapshot.StoreMode All;        // 0x0
        public static Slate.TransformSnapshot.StoreMode RootOnly;        // 0x0
        public static Slate.TransformSnapshot.StoreMode ChildrenOnly;        // 0x0

    }

    // TypeToken: 0x20000A7
    public struct TransformData
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public UnityEngine.Transform parent;        // 0x18
        public UnityEngine.Vector3 pos;        // 0x20
        public UnityEngine.Quaternion rot;        // 0x2C
        public UnityEngine.Vector3 scale;        // 0x3C

        // Methods
        private System.Void .ctor(UnityEngine.Transform transform, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale) { }

    }

    // TypeToken: 0x20000AB
    public struct VideoRenderTarget
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.VideoSampler.VideoRenderTarget CameraBackground;        // 0x0
        public static Slate.VideoSampler.VideoRenderTarget CameraForeground;        // 0x0

    }

    // TypeToken: 0x20000AC
    public struct SampleSettings
    {
        // Fields
        public Slate.VideoSampler.VideoRenderTarget renderTarget;        // 0x10
        public System.Single playbackSpeed;        // 0x14
        public System.Single alpha;        // 0x18
        public UnityEngine.Video.VideoAspectRatio aspectRatio;        // 0x1C
        public System.Single audioVolume;        // 0x20

        // Methods
        private Slate.VideoSampler.SampleSettings Default() { }

    }

    // TypeToken: 0x2000103
    public struct StartingTransformsMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.ActionClips.PlayAnimatorClip.StartingTransformsMode AutoMatchTransforms;        // 0x0
        public static Slate.ActionClips.PlayAnimatorClip.StartingTransformsMode ManualSetTransforms;        // 0x0

    }

    // TypeToken: 0x2000104
    public struct ClipWrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.ActionClips.PlayAnimatorClip.ClipWrapMode Loop;        // 0x0
        public static Slate.ActionClips.PlayAnimatorClip.ClipWrapMode PingPong;        // 0x0

    }

namespace Slate
{

    // TypeToken: 0x2000002
    public class DirectorCamera : MonoBehaviour, IDirectableCamera
    {
        // Fields
        private System.Boolean _matchMainWhenActive;        // 0x18
        private System.Boolean _setMainWhenActive;        // 0x19
        private System.Boolean _autoHandleActiveState;        // 0x1A
        private System.Boolean _ignoreFOVChanges;        // 0x1B
        private System.Boolean _dontDestroyOnLoad;        // 0x1C
        public static System.Single MAX_DAMP;        // 0x0
        private static System.Action<Slate.IDirectableCamera> onCut;        // 0x0
        private static System.Action onActivate;        // 0x8
        private static System.Action onDeactivate;        // 0x10
        private static Slate.DirectorCamera _current;        // 0x18
        private static UnityEngine.Camera _cam;        // 0x20
        private static Slate.IDirectableCamera lastTargetShot;        // 0x28
        private System.Single <focalDistance>k__BackingField;        // 0x20
        private System.Single <focalLength>k__BackingField;        // 0x24
        private System.Single <focalAperture>k__BackingField;        // 0x28
        private static Slate.GameCamera <gameCamera>k__BackingField;        // 0x30
        private static System.Boolean <isEnabled>k__BackingField;        // 0x38
        private static System.Single noiseTimer;        // 0x3C
        private static UnityEngine.Vector3 noisePosOffset;        // 0x40
        private static UnityEngine.Vector3 noiseRotOffset;        // 0x4C
        private static UnityEngine.Vector3 noiseTargetPosOffset;        // 0x58
        private static UnityEngine.Vector3 noiseTargetRotOffset;        // 0x64
        private static UnityEngine.Vector3 noiseCamPosVel;        // 0x70
        private static UnityEngine.Vector3 noiseCamRotVel;        // 0x7C

        // Methods
        private System.Void add_onCut(System.Action<Slate.IDirectableCamera> value) { }
        private System.Void remove_onCut(System.Action<Slate.IDirectableCamera> value) { }
        private System.Void add_onActivate(System.Action value) { }
        private System.Void remove_onActivate(System.Action value) { }
        private System.Void add_onDeactivate(System.Action value) { }
        private System.Void remove_onDeactivate(System.Action value) { }
        private Slate.DirectorCamera get_current() { }
        private UnityEngine.Camera get_cam() { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private System.Single get_fieldOfView() { }
        private System.Void set_fieldOfView(System.Single value) { }
        private System.Single get_focalDistance() { }
        private System.Void set_focalDistance(System.Single value) { }
        private System.Single get_focalLength() { }
        private System.Void set_focalLength(System.Single value) { }
        private System.Single get_focalAperture() { }
        private System.Void set_focalAperture(System.Single value) { }
        private System.Boolean get_matchMainWhenActive() { }
        private System.Void set_matchMainWhenActive(System.Boolean value) { }
        private System.Boolean get_setMainWhenActive() { }
        private System.Void set_setMainWhenActive(System.Boolean value) { }
        private System.Boolean get_autoHandleActiveState() { }
        private System.Void set_autoHandleActiveState(System.Boolean value) { }
        private System.Boolean get_ignoreFOVChanges() { }
        private System.Void set_ignoreFOVChanges(System.Boolean value) { }
        private System.Boolean get_dontDestroyOnLoad() { }
        private System.Void set_dontDestroyOnLoad(System.Boolean value) { }
        private UnityEngine.Camera get_renderCamera() { }
        private Slate.GameCamera get_gameCamera() { }
        private System.Void set_gameCamera(Slate.GameCamera value) { }
        private System.Boolean get_isEnabled() { }
        private System.Void set_isEnabled(System.Boolean value) { }
        private System.Void Awake() { }
        private UnityEngine.Camera CreateRenderCamera() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Void Update(Slate.IDirectableCamera source, Slate.IDirectableCamera target, Slate.EaseType interpolation, System.Single weight, System.Single damping) { }
        private System.Void ApplyNoise(System.Single magnitude, System.Single weight) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject() { }

    }

    // TypeToken: 0x2000003
    public class DirectorGUI : MonoBehaviour
    {
        // Fields
        private static Slate.DirectorGUI.SubtitlesGUIDelegate OnSubtitlesGUI;        // 0x0
        private static Slate.DirectorGUI.TextOverlayGUIDelegate OnTextOverlayGUI;        // 0x8
        private static Slate.DirectorGUI.ImageOverlayGUIDelegate OnImageOverlayGUI;        // 0x10
        private static Slate.DirectorGUI.ScreenFadeGUIDelegate OnScreenFadeGUI;        // 0x18
        private static Slate.DirectorGUI.LetterboxGUIDelegate OnLetterboxGUI;        // 0x20
        private static Slate.DirectorGUI.CameraDissolveDelegate OnCameraDissolve;        // 0x28
        private static System.Action OnGUIEnable;        // 0x30
        private static System.Action OnGUIDisable;        // 0x38
        private static Slate.DirectorGUI _current;        // 0x40
        private static UnityEngine.Color <lastFadeColor>k__BackingField;        // 0x48

        // Methods
        private System.Void add_OnSubtitlesGUI(Slate.DirectorGUI.SubtitlesGUIDelegate value) { }
        private System.Void remove_OnSubtitlesGUI(Slate.DirectorGUI.SubtitlesGUIDelegate value) { }
        private System.Void add_OnTextOverlayGUI(Slate.DirectorGUI.TextOverlayGUIDelegate value) { }
        private System.Void remove_OnTextOverlayGUI(Slate.DirectorGUI.TextOverlayGUIDelegate value) { }
        private System.Void add_OnImageOverlayGUI(Slate.DirectorGUI.ImageOverlayGUIDelegate value) { }
        private System.Void remove_OnImageOverlayGUI(Slate.DirectorGUI.ImageOverlayGUIDelegate value) { }
        private System.Void add_OnScreenFadeGUI(Slate.DirectorGUI.ScreenFadeGUIDelegate value) { }
        private System.Void remove_OnScreenFadeGUI(Slate.DirectorGUI.ScreenFadeGUIDelegate value) { }
        private System.Void add_OnLetterboxGUI(Slate.DirectorGUI.LetterboxGUIDelegate value) { }
        private System.Void remove_OnLetterboxGUI(Slate.DirectorGUI.LetterboxGUIDelegate value) { }
        private System.Void add_OnCameraDissolve(Slate.DirectorGUI.CameraDissolveDelegate value) { }
        private System.Void remove_OnCameraDissolve(Slate.DirectorGUI.CameraDissolveDelegate value) { }
        private System.Void add_OnGUIEnable(System.Action value) { }
        private System.Void remove_OnGUIEnable(System.Action value) { }
        private System.Void add_OnGUIDisable(System.Action value) { }
        private System.Void remove_OnGUIDisable(System.Action value) { }
        private Slate.DirectorGUI get_current() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void UpdateLetterbox(System.Single completion) { }
        private System.Void UpdateDissolve(UnityEngine.Texture texture, System.Single completion) { }
        private UnityEngine.Color get_lastFadeColor() { }
        private System.Void set_lastFadeColor(UnityEngine.Color value) { }
        private System.Void UpdateFade(UnityEngine.Color color) { }
        private System.Void UpdateSubtitles(System.String text, UnityEngine.Color color) { }
        private System.Void UpdateOverlayText(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 pos) { }
        private System.Void UpdateOverlayImage(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 positionOffset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class DynamicCameraController
    {
        // Fields
        private static System.Single MIN_DAMP;        // 0x0
        private static System.Single MAX_DAMP;        // 0x0
        private Slate.DynamicCameraController.Transposer _transposer;        // 0x10
        private Slate.DynamicCameraController.Composer _composer;        // 0x18
        private System.Int32 lastUpdateFrame;        // 0x20

        // Methods
        private Slate.DynamicCameraController.Transposer get_transposer() { }
        private Slate.DynamicCameraController.Composer get_composer() { }
        private System.Boolean get_controlsPosition() { }
        private System.Boolean get_controlsRotation() { }
        private System.Boolean get_controlsFieldOfView() { }
        private System.Void UpdateControllerHard(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable) { }
        private System.Void UpdateControllerSoft(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable) { }
        private System.Void UpdateController(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable, System.Boolean isHard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class GameCamera : MonoBehaviour, IDirectableCamera
    {
        // Fields
        private UnityEngine.Camera _cam;        // 0x18

        // Methods
        private UnityEngine.Camera get_cam() { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private System.Single get_fieldOfView() { }
        private System.Void set_fieldOfView(System.Single value) { }
        private System.Single get_focalDistance() { }
        private System.Void set_focalDistance(System.Single value) { }
        private System.Single get_focalLength() { }
        private System.Void set_focalLength(System.Single value) { }
        private System.Single get_focalAperture() { }
        private System.Void set_focalAperture(System.Single value) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject() { }

    }

    // TypeToken: 0x2000011
    public interface IDirectableCamera
    {
        // Methods
        private UnityEngine.GameObject get_gameObject() { }
        private UnityEngine.Camera get_cam() { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private System.Single get_fieldOfView() { }
        private System.Void set_fieldOfView(System.Single value) { }
        private System.Single get_focalDistance() { }
        private System.Void set_focalDistance(System.Single value) { }
        private System.Single get_focalLength() { }
        private System.Void set_focalLength(System.Single value) { }
        private System.Single get_focalAperture() { }
        private System.Void set_focalAperture(System.Single value) { }

    }

    // TypeToken: 0x2000012
    public class ShotCamera : MonoBehaviour, IDirectableCamera
    {
        // Fields
        public static System.String DEFAULT_NAME;        // 0x0
        private Slate.DynamicCameraController _dynamicController;        // 0x18
        private System.Single _focalDistance;        // 0x20
        private System.Single _focalLength;        // 0x24
        private System.Single _focalAperture;        // 0x28
        private UnityEngine.Camera _cam;        // 0x30

        // Methods
        private UnityEngine.Camera get_cam() { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_localPosition() { }
        private System.Void set_localPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_localEulerAngles() { }
        private System.Void set_localEulerAngles(UnityEngine.Vector3 value) { }
        private System.Single get_fieldOfView() { }
        private System.Void set_fieldOfView(System.Single value) { }
        private System.Single get_focalDistance() { }
        private System.Void set_focalDistance(System.Single value) { }
        private System.Single get_focalLength() { }
        private System.Void set_focalLength(System.Single value) { }
        private System.Single get_focalAperture() { }
        private System.Void set_focalAperture(System.Single value) { }
        private Slate.DynamicCameraController get_dynamicController() { }
        private System.Boolean get_dynamicControlledPosition() { }
        private System.Boolean get_dynamicControlledRotation() { }
        private System.Boolean get_dynamicControlledFieldOfView() { }
        private System.Void Awake() { }
        private System.Void UpdateDynamicControllerHard(Slate.IDirectable directable) { }
        private System.Void UpdateDynamicControllerSoft(Slate.IDirectable directable) { }
        private System.Void SetDynamicControllerTargets(UnityEngine.Transform target) { }
        private System.Void SetDynamicControllerTargets(UnityEngine.Transform transposerTarget, UnityEngine.Transform composerTarget) { }
        private UnityEngine.RenderTexture GetRenderTexture(System.Int32 width, System.Int32 height) { }
        private Slate.ShotCamera Create(UnityEngine.Transform targetParent) { }
        private Slate.ShotCamera Find(System.String shotName) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject() { }

    }

    // TypeToken: 0x2000014
    public class BlendShape
    {
        // Fields
        private UnityEngine.SkinnedMeshRenderer _skin;        // 0x10
        private System.String _name;        // 0x18
        private System.Single _weight;        // 0x20

        // Methods
        private UnityEngine.SkinnedMeshRenderer get_skin() { }
        private System.Void set_skin(UnityEngine.SkinnedMeshRenderer value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private System.Void SetRealWeight(System.Single modWeight) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class BlendShapeGroup
    {
        // Fields
        private System.String _UID;        // 0x10
        private System.String _name;        // 0x18
        private System.Single _weight;        // 0x20
        private System.Collections.Generic.List<Slate.BlendShape> _blendShapes;        // 0x28

        // Methods
        private System.String get_UID() { }
        private System.Void set_UID(System.String value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private System.Collections.Generic.List<Slate.BlendShape> get_blendShapes() { }
        private System.Void .ctor() { }
        private System.Void SetBlendWeights() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000016
    public class Character : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Slate.BlendShapeGroup> _expressions;        // 0x18
        private UnityEngine.Transform _neckTransform;        // 0x20
        private UnityEngine.Transform _headTransform;        // 0x28
        private UnityEngine.Vector3 _upVector;        // 0x30
        private UnityEngine.Vector3 _rotationOffset;        // 0x3C

        // Methods
        private UnityEngine.Transform get_neck() { }
        private System.Void set_neck(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_head() { }
        private System.Void set_head(UnityEngine.Transform value) { }
        private UnityEngine.Vector3 get_upVector() { }
        private System.Void set_upVector(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_rotationOffset() { }
        private System.Void set_rotationOffset(UnityEngine.Vector3 value) { }
        private System.Collections.Generic.List<Slate.BlendShapeGroup> get_expressions() { }
        private Slate.BlendShapeGroup FindExpressionByName(System.String name) { }
        private Slate.BlendShapeGroup FindExpressionByUID(System.String UID) { }
        private System.Void SetExpressionWeightByName(System.String name, System.Single weight) { }
        private System.Void SetExpressionWeightByUID(System.String UID, System.Single weight) { }
        private System.Void ResetExpressions() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class NameAttribute : Attribute
    {
        // Fields
        public readonly System.String name;        // 0x10

        // Methods
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x200001A
    public class CategoryAttribute : Attribute
    {
        // Fields
        public readonly System.String category;        // 0x10

        // Methods
        private System.Void .ctor(System.String category) { }

    }

    // TypeToken: 0x200001B
    public class DescriptionAttribute : Attribute
    {
        // Fields
        public readonly System.String description;        // 0x10

        // Methods
        private System.Void .ctor(System.String description) { }

    }

    // TypeToken: 0x200001C
    public class IconAttribute : Attribute
    {
        // Fields
        public readonly System.String iconName;        // 0x10
        public readonly System.Type fromType;        // 0x18

        // Methods
        private System.Void .ctor(System.String iconName) { }
        private System.Void .ctor(System.Type fromType) { }

    }

    // TypeToken: 0x200001D
    public class AttachableAttribute : Attribute
    {
        // Fields
        public readonly System.Type[] types;        // 0x10

        // Methods
        private System.Void .ctor(System.Type[] types) { }

    }

    // TypeToken: 0x200001E
    public class UniqueElementAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class ShowTrajectoryAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class PositionHandleAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class RotationHandleAttribute : Attribute
    {
        // Fields
        public readonly System.String positionPropertyName;        // 0x10

        // Methods
        private System.Void .ctor(System.String positionPropertyName) { }

    }

    // TypeToken: 0x2000022
    public class AnimatableParameterAttribute : PropertyAttribute
    {
        // Fields
        public System.String link;        // 0x10
        public readonly System.Nullable<System.Single> min;        // 0x18
        public readonly System.Nullable<System.Single> max;        // 0x20
        public readonly System.String customName;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String customName) { }
        private System.Void .ctor(System.String customName, System.Single min, System.Single max) { }
        private System.Void .ctor(System.Single min, System.Single max) { }

    }

    // TypeToken: 0x2000023
    public class ParseAnimatableParametersAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class ShaderPropertyPopupAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Type propertyType;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type propertyType) { }

    }

    // TypeToken: 0x2000025
    public class LeftToggleAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class MinAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Single min;        // 0x10

        // Methods
        private System.Void .ctor(System.Single min) { }

    }

    // TypeToken: 0x2000027
    public class ExampleTextAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String text;        // 0x10

        // Methods
        private System.Void .ctor(System.String text) { }

    }

    // TypeToken: 0x2000028
    public class HelpBoxAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String text;        // 0x10

        // Methods
        private System.Void .ctor(System.String text) { }

    }

    // TypeToken: 0x2000029
    public class ShowIfAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String propertyName;        // 0x10
        public readonly System.Int32 value;        // 0x18

        // Methods
        private System.Void .ctor(System.String propertyName, System.Int32 value) { }

    }

    // TypeToken: 0x200002A
    public class EnabledIfAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String propertyName;        // 0x10
        public readonly System.Int32 value;        // 0x18

        // Methods
        private System.Void .ctor(System.String propertyName, System.Int32 value) { }

    }

    // TypeToken: 0x200002B
    public class CallbackAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String methodName;        // 0x10

        // Methods
        private System.Void .ctor(System.String methodName) { }

    }

    // TypeToken: 0x200002C
    public class RequiredAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class PlaybackProtectedAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class ReadOnlyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002F
    public class SortingLayerAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class ActorGroupPopupAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class DirectorActionClip : ActionClip
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public interface IEvent
    {
        // Methods
        private System.String get_name() { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000033
    public struct TransformSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.TransformSpace CutsceneSpace;        // 0x0
        public static Slate.TransformSpace ActorSpace;        // 0x0
        public static Slate.TransformSpace WorldSpace;        // 0x0
        public static Slate.TransformSpace ParentSpace;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct MiniTransformSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.MiniTransformSpace CutsceneSpace;        // 0x0
        public static Slate.MiniTransformSpace WorldSpace;        // 0x0
        public static Slate.MiniTransformSpace ParentSpace;        // 0x0

    }

    // TypeToken: 0x2000035
    public struct ActiveState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.ActiveState Disable;        // 0x0
        public static Slate.ActiveState Enable;        // 0x0
        public static Slate.ActiveState Toggle;        // 0x0

    }

    // TypeToken: 0x2000036
    public class CameraShot : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        private Slate.ShotCamera _targetShot;        // 0x50
        public Slate.CameraShot.BlendInEffectType blendInEffect;        // 0x58
        public Slate.CameraShot.BlendOutEffectType blendOutEffect;        // 0x5C
        public System.Single steadyCamEffect;        // 0x60
        public UnityEngine.Color fadeToColor;        // 0x64
        public UnityEngine.Color fadeFromColor;        // 0x74
        public Slate.ActorGroup overrideShotTargetActorGroup;        // 0x88
        private UnityEngine.Color lastFadeColor;        // 0x90
        private Slate.CameraShot <previousShot>k__BackingField;        // 0xA0

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private UnityEngine.GameObject get_actor() { }
        private Slate.CameraShot get_previousShot() { }
        private System.Void set_previousShot(Slate.CameraShot value) { }
        private Slate.ShotCamera get_targetShot() { }
        private System.Void set_targetShot(Slate.ShotCamera value) { }
        private Slate.CameraTrack get_track() { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_rotation() { }
        private System.Void set_rotation(UnityEngine.Vector3 value) { }
        private System.Single get_fieldOfView() { }
        private System.Void set_fieldOfView(System.Single value) { }
        private System.Single get_focalPoint() { }
        private System.Void set_focalPoint(System.Single value) { }
        private System.Single get_focalRange() { }
        private System.Void set_focalRange(System.Single value) { }
        private System.Single get_focalAperture() { }
        private System.Void set_focalAperture(System.Single value) { }
        private System.Void OnAfterValidate() { }
        private System.Void OnRootEnabled() { }
        private System.Void OnRootDisabled() { }
        private System.Void OnRootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void TryUpdateShotTargetOverride() { }
        private System.Boolean OnInitialize() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class PlayVideo : ActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.Video.VideoClip videoClip;        // 0x50
        private Slate.VideoSampler.SampleSettings settings;        // 0x58

        // Methods
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private Slate.VideoTrack get_track() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void Enable() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void Disable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class ActorGroup : CutsceneGroup
    {
        // Fields
        private System.String _name;        // 0x70
        private UnityEngine.GameObject _actor;        // 0x78
        private Slate.CutsceneGroup.ActorReferenceMode _referenceMode;        // 0x80
        private Slate.CutsceneGroup.ActorInitialTransformation _initialCoordinates;        // 0x84
        private UnityEngine.Vector3 _initialLocalPosition;        // 0x88
        private UnityEngine.Vector3 _initialLocalRotation;        // 0x94
        private System.Boolean _displayVirtualMeshGizmo;        // 0xA0

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.GameObject get_actor() { }
        private System.Void set_actor(UnityEngine.GameObject value) { }
        private Slate.CutsceneGroup.ActorReferenceMode get_referenceMode() { }
        private System.Void set_referenceMode(Slate.CutsceneGroup.ActorReferenceMode value) { }
        private Slate.CutsceneGroup.ActorInitialTransformation get_initialTransformation() { }
        private System.Void set_initialTransformation(Slate.CutsceneGroup.ActorInitialTransformation value) { }
        private UnityEngine.Vector3 get_initialLocalPosition() { }
        private System.Void set_initialLocalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_initialLocalRotation() { }
        private System.Void set_initialLocalRotation(UnityEngine.Vector3 value) { }
        private System.Boolean get_displayVirtualMeshGizmo() { }
        private System.Void set_displayVirtualMeshGizmo(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public class DirectorGroup : CutsceneGroup
    {
        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.GameObject get_actor() { }
        private System.Void set_actor(UnityEngine.GameObject value) { }
        private Slate.CutsceneGroup.ActorReferenceMode get_referenceMode() { }
        private System.Void set_referenceMode(Slate.CutsceneGroup.ActorReferenceMode value) { }
        private Slate.CutsceneGroup.ActorInitialTransformation get_initialTransformation() { }
        private System.Void set_initialTransformation(Slate.CutsceneGroup.ActorInitialTransformation value) { }
        private UnityEngine.Vector3 get_initialLocalPosition() { }
        private System.Void set_initialLocalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_initialLocalRotation() { }
        private System.Void set_initialLocalRotation(UnityEngine.Vector3 value) { }
        private System.Boolean get_displayVirtualMeshGizmo() { }
        private System.Void set_displayVirtualMeshGizmo(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class ActionTrack : CutsceneTrack
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class ActorActionTrack : ActionTrack
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class ActorAudioTrack : AudioTrack
    {
        // Fields
        protected System.Boolean _useAudioSourceOnActor;        // 0x90

        // Methods
        private System.Boolean get_useAudioSourceOnActor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class ActorPropertiesTrack : PropertiesTrack
    {
        // Methods
        private System.Void OnCreate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class AnimationTrack : CutsceneTrack
    {
        // Fields
        private System.Single _weight;        // 0x50
        private System.Single _blendIn;        // 0x54
        private System.Single _blendOut;        // 0x58
        private UnityEngine.AnimationBlendMode _animationBlendMode;        // 0x5C
        private System.String _mixTransformName;        // 0x60
        private UnityEngine.Animation anim;        // 0x68
        private UnityEngine.AnimationState state;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Single get_blendIn() { }
        private System.Single get_blendOut() { }
        private System.Single get_weight() { }
        private UnityEngine.AnimationBlendMode get_animationBlendMode() { }
        private System.Void set_animationBlendMode(UnityEngine.AnimationBlendMode value) { }
        private System.String get_mixTransformName() { }
        private System.Void set_mixTransformName(System.String value) { }
        private System.Boolean OnInitialize() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private UnityEngine.Transform GetMixTransform() { }
        private System.Void .ctor() { }
        private System.Boolean <GetMixTransform>b__27_0(UnityEngine.Transform t) { }

    }

    // TypeToken: 0x2000042
    public class AnimatorTrack : CutsceneTrack
    {
        // Fields
        private static System.Int32 ROOTMOTION_FRAMERATE;        // 0x0
        public UnityEngine.AvatarMask mask;        // 0x50
        public UnityEngine.AnimationBlendMode blendMode;        // 0x58
        public System.Single weight;        // 0x5C
        public System.Boolean useRootMotion;        // 0x60
        public System.Boolean applyFootIK;        // 0x61
        public System.Boolean isRootMotionPreBaked;        // 0x62
        private System.Collections.Generic.List<UnityEngine.Vector3> rmPositions;        // 0x68
        private System.Collections.Generic.List<UnityEngine.Quaternion> rmRotations;        // 0x70
        private System.Int32 activeClips;        // 0x78
        private System.Single activeClipsWeight;        // 0x7C
        private System.Collections.Generic.Dictionary<Slate.ActionClips.PlayAnimatorClip,System.Int32> ports;        // 0x80
        private UnityEngine.Playables.PlayableGraph graph;        // 0x88
        private UnityEngine.Animations.AnimationPlayableOutput animationOutput;        // 0x98
        private UnityEngine.Animations.AnimationLayerMixerPlayable masterMixer;        // 0xA8
        private UnityEngine.Animations.AnimationMixerPlayable clipsMixer;        // 0xB8
        private UnityEngine.Animations.AnimatorControllerPlayable animatorPlayable;        // 0xC8
        private System.Collections.Generic.List<Slate.AnimatorTrack> siblingTracks;        // 0xD8
        private System.Boolean wasRootMotion;        // 0xE0
        private UnityEngine.AnimatorCullingMode wasCullingMode;        // 0xE4
        private System.Boolean useBakedRootMotion;        // 0xE8
        private UnityEngine.Animator _animator;        // 0xF0

        // Methods
        private UnityEngine.Animator get_animator() { }
        private System.String get_info() { }
        private System.Boolean get_isLocked() { }
        private Slate.AnimatorTrack get_masterTrack() { }
        private System.Boolean get_isMasterTrack() { }
        private System.Boolean get_isLastTrack() { }
        private System.Single get_compoundTrackWeight() { }
        private System.Boolean OnInitialize() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void PostUpdateMasterTrack(System.Single time, System.Single previousTime) { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void PostExitMasterTrack() { }
        private System.Void OnReverse() { }
        private System.Void EnableClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single blendWeight, System.Single subClipWeight) { }
        private System.Void UpdateClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single clipTime, System.Single clipPrevious, System.Single blendWeight, System.Single subClipWeight) { }
        private System.Void DisableClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single blendWeight, System.Single subClipWeight) { }
        private System.Void CreateAndPlayTree() { }
        private UnityEngine.Playables.Playable CreateClipsMixer(UnityEngine.Playables.PlayableGraph graph) { }
        private System.Void PreBakeRootMotion() { }
        private System.Void ClearPreBakeRootMotion() { }
        private System.Void BakeRootMotion() { }
        private System.Void EvaluateTrackClips(System.Single time, System.Single previousTime, System.Int32& tempActiveClips) { }
        private System.Void ApplyBakedRootMotion(System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public class MecanimTrack : CutsceneTrack
    {
        // Fields
        private UnityEngine.Animator animator;        // 0x50

        // Methods
        private System.Boolean OnInitialize() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void DestroyDispatcher() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class AudioTrack : CutsceneTrack
    {
        // Fields
        protected UnityEngine.Audio.AudioMixerGroup _outputMixer;        // 0x50
        protected System.Single _masterVolume;        // 0x58
        protected System.Single _masterPitch;        // 0x5C
        protected System.Single _masterStereoPan;        // 0x60
        protected System.Single _masterSpatialBlend;        // 0x64
        protected System.Boolean _ignoreTimeScale;        // 0x68
        protected System.Boolean _bypassReverb;        // 0x69
        private UnityEngine.AudioSource <source>k__BackingField;        // 0x70
        private Slate.AudioSampler.SampleSettings <sampleSettings>k__BackingField;        // 0x78

        // Methods
        private System.String get_info() { }
        private UnityEngine.AudioSource get_source() { }
        private System.Void set_source(UnityEngine.AudioSource value) { }
        private Slate.AudioSampler.SampleSettings get_sampleSettings() { }
        private System.Void set_sampleSettings(Slate.AudioSampler.SampleSettings value) { }
        private UnityEngine.Audio.AudioMixerGroup get_mixer() { }
        private System.Boolean get_useAudioSourceOnActor() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Void SetAndApplySettings() { }
        private System.Void SetVolume(System.Single volume) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class CameraTrack : CutsceneTrack
    {
        // Fields
        private static Slate.CameraTrack activeCameraTrack;        // 0x0
        private System.Single _startTimeOffset;        // 0x50
        private System.Single _endTimeOffset;        // 0x54
        public System.Single _blendIn;        // 0x58
        public System.Single _blendOut;        // 0x5C
        public Slate.EaseType interpolation;        // 0x60
        public System.Single cineBoxFadeTime;        // 0x64
        public System.Single appliedSmoothing;        // 0x68
        public UnityEngine.Camera exitCameraOverride;        // 0x70
        private Slate.GameCamera entryCamera;        // 0x78
        private Slate.CameraShot <firstShot>k__BackingField;        // 0x80
        private Slate.CameraShot <lastShot>k__BackingField;        // 0x88
        private Slate.CameraShot <currentShot>k__BackingField;        // 0x90

        // Methods
        private Slate.CameraShot get_firstShot() { }
        private System.Void set_firstShot(Slate.CameraShot value) { }
        private Slate.CameraShot get_lastShot() { }
        private System.Void set_lastShot(Slate.CameraShot value) { }
        private Slate.CameraShot get_currentShot() { }
        private System.Void set_currentShot(Slate.CameraShot value) { }
        private System.String get_info() { }
        private System.Single get_startTime() { }
        private System.Void set_startTime(System.Single value) { }
        private System.Single get_endTime() { }
        private System.Void set_endTime(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }
        private System.Boolean <OnEnter>b__36_0(Slate.ActionClip s) { }
        private System.Boolean <OnEnter>b__36_1(Slate.ActionClip s) { }

    }

    // TypeToken: 0x2000047
    public class DirectorActionTrack : ActionTrack
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000048
    public class DirectorAudioTrack : AudioTrack
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class DirectorPropertiesTrack : PropertiesTrack
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public class VideoTrack : CutsceneTrack
    {
        // Fields
        public Slate.VideoSampler.VideoRenderTarget renderTarget;        // 0x50
        public UnityEngine.Video.VideoAspectRatio aspectRatio;        // 0x54
        private UnityEngine.Video.VideoPlayer <source>k__BackingField;        // 0x58

        // Methods
        private UnityEngine.Video.VideoPlayer get_source() { }
        private System.Void set_source(UnityEngine.Video.VideoPlayer value) { }
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class PropertiesTrack : CutsceneTrack, IKeyable, IDirectable
    {
        // Fields
        private Slate.AnimationDataCollection _animationData;        // 0x50

        // Methods
        private Slate.AnimationDataCollection get_animationData() { }
        private System.Object get_animatedParametersTarget() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class ActionClip : MonoBehaviour, IDirectable, IKeyable
    {
        // Fields
        private System.Single _startTime;        // 0x18
        private Slate.AnimationDataCollection _animationData;        // 0x20
        private Slate.IDirectable <parent>k__BackingField;        // 0x28
        private System.Boolean <isHighlight>k__BackingField;        // 0x30
        private System.String[] _cachedAnimParamPaths;        // 0x38

        // Methods
        private Slate.IDirector get_root() { }
        private Slate.IDirectable get_parent() { }
        private System.Void set_parent(Slate.IDirectable value) { }
        private UnityEngine.GameObject get_actor() { }
        private System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirectable.get_children() { }
        private Slate.AnimationDataCollection get_animationData() { }
        private System.Void set_animationData(Slate.AnimationDataCollection value) { }
        private System.Single get_startTime() { }
        private System.Void set_startTime(System.Single value) { }
        private System.Single get_endTime() { }
        private System.Void set_endTime(System.Single value) { }
        private System.Boolean get_isActive() { }
        private System.Boolean get_isCollapsed() { }
        private System.Boolean get_isLocked() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private UnityEngine.Color get_color() { }
        private UnityEngine.Color get_textColor() { }
        private System.Int32 get_textSizeInner() { }
        private System.Int32 get_textSizeOuter() { }
        private System.Single get_interval() { }
        private System.String get_url() { }
        private System.Boolean get_isHighlight() { }
        private System.Void set_isHighlight(System.Boolean value) { }
        private System.Boolean get_isReadOnly() { }
        private Slate.TransformSpace get_defaultTransformSpace() { }
        private System.String[] get_animatedParameterPaths() { }
        private System.Boolean get_handleParametersRegistrationManually() { }
        private System.Object get_animatedParametersTarget() { }
        private Slate.EaseType get_animatedParametersInterpolation() { }
        private System.Boolean get_useWeightInParameters() { }
        private System.Boolean get_hasParameters() { }
        private System.Boolean get_hasActiveParameters() { }
        private System.Boolean get_needActor() { }
        private System.Boolean get_canSample() { }
        private System.Int32 get_updateOrder() { }
        private System.Boolean Slate.IDirectable.Initialize() { }
        private System.Void Slate.IDirectable.Enter() { }
        private System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime) { }
        private System.Void Slate.IDirectable.Exit() { }
        private System.Void Slate.IDirectable.ReverseEnter() { }
        private System.Void Slate.IDirectable.Reverse() { }
        private System.Void Slate.IDirectable.RootEnabled() { }
        private System.Void Slate.IDirectable.RootDisabled() { }
        private System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void Slate.IDirectable.RootDestroyed() { }
        private System.Void PostCreate(Slate.IDirectable parent) { }
        private System.Void Validate() { }
        private System.Void Validate(Slate.IDirector root, Slate.IDirectable parent) { }
        private System.Boolean OnInitialize() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void OnSceneGUI() { }
        private System.Void OnCreate() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnRootEnabled() { }
        private System.Void OnRootDisabled() { }
        private System.Void OnRootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void OnRootDestroyed() { }
        private System.Boolean RootTimeWithinRange() { }
        private UnityEngine.Vector3 TransformPosition(UnityEngine.Vector3 point, Slate.TransformSpace space) { }
        private UnityEngine.Vector3 InverseTransformPosition(UnityEngine.Vector3 point, Slate.TransformSpace space) { }
        private UnityEngine.Quaternion TransformRotation(UnityEngine.Vector3 euler, Slate.TransformSpace space) { }
        private UnityEngine.Vector3 InverseTransformRotation(UnityEngine.Quaternion rot, Slate.TransformSpace space) { }
        private UnityEngine.Vector3 ActorPositionInSpace(Slate.TransformSpace space) { }
        private UnityEngine.Transform GetSpaceTransform(Slate.TransformSpace space, UnityEngine.GameObject actorOverride) { }
        private Slate.ActionClip GetPreviousClip() { }
        private Slate.ActionClip GetNextClip() { }
        private System.Single GetClipWeight() { }
        private System.Single GetClipWeight(System.Single time) { }
        private System.Single GetClipWeight(System.Single time, System.Single blendInOut) { }
        private System.Single GetClipWeight(System.Single time, System.Single blendIn, System.Single blendOut) { }
        private System.Void TryMatchSubClipLength() { }
        private System.Void TryMatchPreviousSubClipLoop() { }
        private System.Void TryMatchNexSubClipLoop() { }
        private System.String GetParameterName(System.Linq.Expressions.Expression<System.Func<T,TResult>> func) { }
        private Slate.AnimatedParameter GetParameter(System.Linq.Expressions.Expression<System.Func<T,TResult>> func) { }
        private Slate.AnimatedParameter GetParameter(System.String paramName) { }
        private System.Void SetParameterEnabled(System.Linq.Expressions.Expression<System.Func<T,TResult>> func, System.Boolean enabled) { }
        private System.Void SetParameterEnabled(System.String paramName, System.Boolean enabled) { }
        private System.Void ResetAnimatedParameters() { }
        private System.Void CreateAnimationDataCollection() { }
        private System.Void ValidateAnimParams() { }
        private System.Void SetAnimParamsSnapshot() { }
        private System.Void UpdateAnimParams(System.Single time, System.Single previousTime) { }
        private System.Void RestoreAnimParamsSnapshot() { }
        private System.Void .ctor() { }
        private System.String Slate.IDirectable.get_name() { }

    }

    // TypeToken: 0x200004D
    public class AnimatedParameter, IAnimatableData, ISerializationCallbackReceiver
    {
        // Fields
        private static System.Action<Slate.IAnimatableData> onParameterChanged;        // 0x0
        private System.String _serializedData;        // 0x10
        private System.Boolean _isDisabled;        // 0x18
        private UnityEngine.AnimationCurve[] _curves;        // 0x20
        private System.String _scriptExpression;        // 0x28
        private Slate.AnimatedParameter.SerializationMetaData _data;        // 0x30
        private Slate.IAnimatedParameterModel _parameterModel;        // 0x38
        private Slate.IKeyable <keyable>k__BackingField;        // 0x40
        private System.Single[] <snapshot>k__BackingField;        // 0x48
        private System.Single[] <lastEval>k__BackingField;        // 0x50
        private UnityEngine.Transform <virtualTransformParent>k__BackingField;        // 0x58
        private static System.Collections.Generic.Dictionary<System.Type,System.Type> parameterModelsMap;        // 0x8
        public static readonly System.Type[] supportedTypes;        // 0x10
        private System.Object _animatableAttribute;        // 0x60
        private System.Object _resolvedMemberObject;        // 0x68

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void add_onParameterChanged(System.Action<Slate.IAnimatableData> value) { }
        private System.Void remove_onParameterChanged(System.Action<Slate.IAnimatableData> value) { }
        private System.Boolean get_enabled() { }
        private System.Void SetEnabled(System.Boolean value, System.Single time) { }
        private System.String get_serializedData() { }
        private System.Void set_serializedData(System.String value) { }
        private Slate.AnimatedParameter.SerializationMetaData get_data() { }
        private Slate.IAnimatedParameterModel get_parameterModel() { }
        private UnityEngine.AnimationCurve[] get_curves() { }
        private System.Void set_curves(UnityEngine.AnimationCurve[] value) { }
        private System.String get_scriptExpression() { }
        private System.Void set_scriptExpression(System.String value) { }
        private System.Boolean get_hasActiveExpression() { }
        private System.String get_parameterName() { }
        private System.Type get_animatedType() { }
        private Slate.AnimatedParameter.ParameterType get_parameterType() { }
        private System.String get_transformHierarchyPath() { }
        private System.Type get_declaringType() { }
        private System.Reflection.PropertyInfo get_property() { }
        private System.Reflection.FieldInfo get_field() { }
        private System.Boolean get_isProperty() { }
        private Slate.IKeyable get_keyable() { }
        private System.Void set_keyable(Slate.IKeyable value) { }
        private System.Single[] get_snapshot() { }
        private System.Void set_snapshot(System.Single[] value) { }
        private System.Single[] get_lastEval() { }
        private System.Void set_lastEval(System.Single[] value) { }
        private UnityEngine.Transform get_virtualTransformParent() { }
        private System.Void set_virtualTransformParent(UnityEngine.Transform value) { }
        private System.Object get_targetObject() { }
        private Slate.AnimatableParameterAttribute get_animatableAttribute() { }
        private System.Boolean get_isExternal() { }
        private System.Boolean get_isValid() { }
        private System.Void .cctor() { }
        private System.Void .ctor(Slate.IKeyable keyable, System.Type type, System.String memberPath, System.String transformPath) { }
        private System.Void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, System.String memberPath, System.String transformPath) { }
        private System.Void ConstructWithProperty(System.Reflection.PropertyInfo targetProperty, System.Type type, System.String memberPath, System.String transformPath) { }
        private System.Reflection.MemberInfo GetMemberInfo() { }
        private UnityEngine.AnimationCurve[] GetCurves() { }
        private System.Boolean CompareTo(Slate.AnimatedParameter other) { }
        private System.Void InitializeCurves() { }
        private System.Void Validate(Slate.IKeyable keyable) { }
        private System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent) { }
        private System.Void SetSnapshot() { }
        private System.Boolean TryAutoKey(System.Single time) { }
        private System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight) { }
        private System.Void Evaluate_1_Curves(System.Single time, System.Single previousTime, System.Single weight) { }
        private System.Boolean Evaluate_2_Expression(System.Single time, System.Single previousTime, System.Single weight) { }
        private System.Void RestoreSnapshot() { }
        private System.Object GetEvalValue(System.Single time) { }
        private System.Object ResolvedMemberObject() { }
        private System.Object GetCurrentValueAsObject() { }
        private System.Single[] GetCurrentValueAsFloats() { }
        private System.Void SetCurrentValue(System.Object value) { }
        private System.Void SetCurrentValue(System.Single[] floats) { }
        private System.Boolean HasChanged() { }
        private System.Boolean HasAnyKey() { }
        private System.Boolean HasKey(System.Single time) { }
        private System.Single GetKeyNext(System.Single time) { }
        private System.Single GetKeyPrevious(System.Single time) { }
        private System.Boolean TryKeyIdentity(System.Single time) { }
        private System.Void SetKeyCurrent(System.Single time) { }
        private System.Void RemoveKey(System.Single time) { }
        private System.Void SetPreWrapMode(UnityEngine.WrapMode mode) { }
        private System.Void SetPostWrapMode(UnityEngine.WrapMode mode) { }
        private System.Void OffsetValue(System.Object deltaValue) { }
        private System.Void Reset() { }
        private System.Void ChangeMemberType(Slate.AnimatedParameter.ParameterType newType) { }
        private System.String ToString() { }
        private System.String FriendlyName() { }
        private System.String GetKeyLabel(System.Single time) { }
        private System.Void RecordUndo() { }
        private System.Void NotifyChange() { }

    }

    // TypeToken: 0x2000051
    public interface IAnimatedParameterModel
    {
        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000052
    public struct Animated_Bool, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,System.Boolean> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000053
    public struct Animated_Int, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,System.Int32> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000054
    public struct Animated_Float, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,System.Single> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000055
    public struct Animated_Vector2, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Vector2> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000056
    public struct Animated_Vector3, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Vector3> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000057
    public struct Animated_Color, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Color> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000058
    public struct Animated_Vector4, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Vector4> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x2000059
    public struct Animated_Quaternion, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Quaternion> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x200005A
    public struct Animated_Rect, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Rect> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x200005B
    public struct Animated_Bounds, IAnimatedParameterModel
    {
        // Fields
        private System.Action<System.Object,UnityEngine.Bounds> setter;        // 0x10

        // Methods
        private System.Boolean ForceStepMode() { }
        private System.Int32 RequiredCurvesCount() { }
        private System.Object ConvertToObject(System.Single[] floats) { }
        private System.Single[] ConvertToFloats(System.Object value) { }
        private System.String GetKeyLabel(System.Single[] floats) { }
        private System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats) { }
        private System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info) { }

    }

    // TypeToken: 0x200005C
    public class AnimationDataCollection, IAnimatableData
    {
        // Fields
        private System.Collections.Generic.List<Slate.AnimatedParameter> _animatedParameters;        // 0x10

        // Methods
        private System.Collections.Generic.List<Slate.AnimatedParameter> get_animatedParameters() { }
        private System.Boolean get_isValid() { }
        private Slate.AnimatedParameter get_Item(System.Int32 i) { }
        private Slate.AnimatedParameter get_Item(System.String name) { }
        private System.Void .ctor() { }
        private System.Void .ctor(Slate.IKeyable keyable, System.Type type, System.String[] memberPaths, System.String transformPath) { }
        private System.Boolean TryAddParameter(Slate.IKeyable keyable, System.Type type, System.String memberPath, System.String transformPath) { }
        private System.Void RemoveParameter(Slate.AnimatedParameter animParam) { }
        private System.Void ReOrderParameters() { }
        private Slate.AnimatedParameter GetParameterOfName(System.String name) { }
        private UnityEngine.AnimationCurve[] GetCurves() { }
        private UnityEngine.AnimationCurve[] GetCurvesAll() { }
        private UnityEngine.AnimationCurve[] Internal_GetCurves(System.Boolean enabledParamsOnly) { }
        private System.Void Validate(Slate.IKeyable keyable) { }
        private System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent) { }
        private System.Void SetSnapshot() { }
        private System.Boolean TryAutoKey(System.Single time) { }
        private System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight) { }
        private System.Void RestoreSnapshot() { }
        private System.Boolean TryKeyIdentity(System.Single time) { }
        private System.Void RemoveKey(System.Single time) { }
        private System.Boolean HasChanged() { }
        private System.Boolean HasKey(System.Single time) { }
        private System.Boolean HasAnyKey() { }
        private System.Void SetKeyCurrent(System.Single time) { }
        private System.Single GetKeyNext(System.Single time) { }
        private System.Single GetKeyPrevious(System.Single time) { }
        private System.String GetKeyLabel(System.Single time) { }
        private System.Void SetPreWrapMode(UnityEngine.WrapMode mode) { }
        private System.Void SetPostWrapMode(UnityEngine.WrapMode mode) { }
        private System.Void Reset() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000064
    public class Cutscene : MonoBehaviour, IDirector
    {
        // Fields
        public static System.Single VERSION_NUMBER;        // 0x0
        private static System.Action<Slate.Cutscene> OnCutsceneStarted;        // 0x0
        private static System.Action<Slate.Cutscene> OnCutsceneStopped;        // 0x8
        private System.Action<Slate.Section> OnSectionReached;        // 0x18
        private System.Action<System.String,System.Object> OnGlobalMessageSend;        // 0x20
        private System.Action OnStop;        // 0x28
        private Slate.Cutscene.UpdateMode _updateMode;        // 0x30
        private Slate.Cutscene.WrapMode _defaultWrapMode;        // 0x34
        private Slate.Cutscene.StopMode _defaultStopMode;        // 0x38
        private System.Single _playbackSpeed;        // 0x3C
        private System.Boolean _playOnStart;        // 0x40
        private System.Boolean _explicitActiveLayers;        // 0x41
        private UnityEngine.LayerMask _activeLayers;        // 0x44
        public System.Collections.Generic.List<Slate.CutsceneGroup> groups;        // 0x48
        private System.Single _length;        // 0x50
        private System.Single _viewTimeMin;        // 0x54
        private System.Single _viewTimeMax;        // 0x58
        private System.Single _currentTime;        // 0x5C
        private System.Single _playTimeMin;        // 0x60
        private System.Single _playTimeMax;        // 0x64
        private UnityEngine.Transform _groupsRoot;        // 0x68
        private System.Collections.Generic.List<Slate.IDirectableTimePointer> timePointers;        // 0x70
        private System.Collections.Generic.List<Slate.IDirectableTimePointer> unsortedStartTimePointers;        // 0x78
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> affectedLayerGOStates;        // 0x80
        private static System.Collections.Generic.Dictionary<System.String,Slate.Cutscene> allSceneCutscenes;        // 0x10
        private System.Boolean preInitialized;        // 0x88
        private System.Boolean _isReSampleFrame;        // 0x89
        private System.Boolean <isBakingRootMotion>k__BackingField;        // 0x8A
        private Slate.Cutscene.PlayingDirection <playingDirection>k__BackingField;        // 0x8C
        private Slate.Cutscene.WrapMode <playingWrapMode>k__BackingField;        // 0x90
        private System.Collections.Generic.List<Slate.IDirectable> <directables>k__BackingField;        // 0x98
        private System.Boolean <isActive>k__BackingField;        // 0xA0
        private System.Boolean <isPaused>k__BackingField;        // 0xA1
        private System.Single <previousTime>k__BackingField;        // 0xA4

        // Methods
        private System.Void add_OnCutsceneStarted(System.Action<Slate.Cutscene> value) { }
        private System.Void remove_OnCutsceneStarted(System.Action<Slate.Cutscene> value) { }
        private System.Void add_OnCutsceneStopped(System.Action<Slate.Cutscene> value) { }
        private System.Void remove_OnCutsceneStopped(System.Action<Slate.Cutscene> value) { }
        private System.Void add_OnSectionReached(System.Action<Slate.Section> value) { }
        private System.Void remove_OnSectionReached(System.Action<Slate.Section> value) { }
        private System.Void add_OnGlobalMessageSend(System.Action<System.String,System.Object> value) { }
        private System.Void remove_OnGlobalMessageSend(System.Action<System.String,System.Object> value) { }
        private System.Void add_OnStop(System.Action value) { }
        private System.Void remove_OnStop(System.Action value) { }
        private UnityEngine.Transform get_groupsRoot() { }
        private Slate.Cutscene.UpdateMode get_updateMode() { }
        private System.Void set_updateMode(Slate.Cutscene.UpdateMode value) { }
        private Slate.Cutscene.WrapMode get_defaultWrapMode() { }
        private System.Void set_defaultWrapMode(Slate.Cutscene.WrapMode value) { }
        private Slate.Cutscene.StopMode get_defaultStopMode() { }
        private System.Void set_defaultStopMode(Slate.Cutscene.StopMode value) { }
        private System.Boolean get_playOnStart() { }
        private System.Void set_playOnStart(System.Boolean value) { }
        private System.Boolean get_explicitActiveLayers() { }
        private System.Void set_explicitActiveLayers(System.Boolean value) { }
        private UnityEngine.LayerMask get_activeLayers() { }
        private System.Void set_activeLayers(UnityEngine.LayerMask value) { }
        private Slate.DirectorGroup get_directorGroup() { }
        private Slate.ActorGroup get_actorGroup() { }
        private System.Boolean get_abortDirectorCamera() { }
        private System.Boolean get_multiSelectOverlapCheck() { }
        private System.Boolean get_isBakingRootMotion() { }
        private System.Void set_isBakingRootMotion(System.Boolean value) { }
        private Slate.CameraTrack get_cameraTrack() { }
        private System.Single get_currentTime() { }
        private System.Void set_currentTime(System.Single value) { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_viewTimeMin() { }
        private System.Void set_viewTimeMin(System.Single value) { }
        private System.Single get_viewTimeMax() { }
        private System.Void set_viewTimeMax(System.Single value) { }
        private System.Single get_playTimeMin() { }
        private System.Void set_playTimeMin(System.Single value) { }
        private System.Single get_playTimeMax() { }
        private System.Void set_playTimeMax(System.Single value) { }
        private System.Single get_playbackSpeed() { }
        private System.Void set_playbackSpeed(System.Single value) { }
        private Slate.Cutscene.PlayingDirection get_playingDirection() { }
        private System.Void set_playingDirection(Slate.Cutscene.PlayingDirection value) { }
        private Slate.Cutscene.WrapMode get_playingWrapMode() { }
        private System.Void set_playingWrapMode(Slate.Cutscene.WrapMode value) { }
        private System.Collections.Generic.List<Slate.IDirectable> get_directables() { }
        private System.Void set_directables(System.Collections.Generic.List<Slate.IDirectable> value) { }
        private System.Boolean get_isActive() { }
        private System.Void set_isActive(System.Boolean value) { }
        private System.Boolean get_isPaused() { }
        private System.Void set_isPaused(System.Boolean value) { }
        private System.Single get_previousTime() { }
        private System.Void set_previousTime(System.Single value) { }
        private System.Boolean Slate.IDirector.get_isReSampleFrame() { }
        private UnityEngine.GameObject Slate.IDirector.get_context() { }
        private System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirector.get_children() { }
        private System.Single get_remainingTime() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void ManualUpdate(System.Single deltaTime) { }
        private System.Void LateUpdate() { }
        private System.Void FixedUpdate() { }
        private System.Void DirectorSectionReached(Slate.Section section) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.GameObject> GetAffectedActors() { }
        private System.Single[] GetPointerTimes() { }
        private System.Void Play() { }
        private System.Void Play(System.Action callback) { }
        private System.Void Play(System.Single startTime) { }
        private System.Void Play(System.Single startTime, System.Action callback) { }
        private System.Void Play(System.Single startTime, System.Single endTime, Slate.Cutscene.WrapMode wrapMode, System.Action callback, Slate.Cutscene.PlayingDirection playDirection) { }
        private System.Void Stop() { }
        private System.Void Stop(Slate.Cutscene.StopMode stopMode) { }
        private System.Void PlayReverse() { }
        private System.Void PlayReverse(System.Single startTime, System.Single endTime) { }
        private System.Void Pause() { }
        private System.Void Resume() { }
        private System.Void SkipAll() { }
        private System.Void Rewind() { }
        private System.Void RewindNoUndo() { }
        private System.Void BreakCutsceneLoop() { }
        private System.Void BreakSectionLoop(System.Boolean alsoSkip) { }
        private System.Void Skip() { }
        private System.Void SkipCurrentSection() { }
        private System.Boolean JumpToSection(System.String name) { }
        private System.Boolean JumpToSection(Slate.Section section) { }
        private System.Boolean PlayFromSection(System.String name) { }
        private System.Boolean PlayFromSection(System.String name, Slate.Cutscene.WrapMode wrap, System.Action callback) { }
        private System.Boolean PlayFromSection(Slate.Section section) { }
        private System.Boolean PlayFromSection(Slate.Section section, Slate.Cutscene.WrapMode wrap, System.Action callback) { }
        private System.Boolean PlaySection(System.String name) { }
        private System.Boolean PlaySection(System.String name, Slate.Cutscene.WrapMode wrap, System.Action callback) { }
        private System.Boolean PlaySection(Slate.Section section) { }
        private System.Boolean PlaySection(Slate.Section section, Slate.Cutscene.WrapMode wrap, System.Action callback) { }
        private System.Void Sample() { }
        private System.Void Sample(System.Single time) { }
        private System.Void Internal_SamplePointers(System.Single currentTime, System.Single previousTime) { }
        private System.Void ReSample() { }
        private System.Void Validate() { }
        private System.Void InitializeTimePointers() { }
        private System.Void OnSampleStarted() { }
        private System.Void OnSampleEnded() { }
        private System.Void SetLayersActive() { }
        private System.Void RestoreLayersActive() { }
        private System.Void UpdateCutscene(System.Single delta) { }
        private Slate.Cutscene Play(System.String name) { }
        private Slate.Cutscene Play(System.String name, System.Action callback) { }
        private Slate.Cutscene FindFromResources(System.String name) { }
        private Slate.Cutscene Find(System.String name) { }
        private System.Void StopAllCutscenes() { }
        private System.Void SendGlobalMessage(System.String message, System.Object value) { }
        private System.Void SetGroupActorOfName(System.String groupName, UnityEngine.GameObject newActor) { }
        private T FindElement(System.String path) { }
        private Slate.IDirectable FindElement(System.String path) { }
        private System.String ToString() { }
        private Slate.Section GetSectionByName(System.String name) { }
        private Slate.Section GetSectionByUID(System.String UID) { }
        private Slate.Section[] GetSections() { }
        private System.Single GetSectionLength(System.String name) { }
        private System.String[] GetSectionNames() { }
        private System.String[] GetDefinedEventNames() { }
        private System.Void PreInitialize() { }
        private System.Void RenderCutscene(System.Int32 width, System.Int32 height, System.Int32 frameRate, System.Action<UnityEngine.Texture2D[]> callback) { }
        private System.Collections.IEnumerator Internal_RenderCutscene(System.Int32 width, System.Int32 height, System.Int32 frameRate, System.Action<UnityEngine.Texture2D[]> callback) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public class CutsceneGroup : MonoBehaviour, IDirectable
    {
        // Fields
        private System.Action<Slate.Section> OnSectionReached;        // 0x18
        private System.Collections.Generic.List<Slate.CutsceneTrack> _tracks;        // 0x20
        private System.Collections.Generic.List<Slate.Section> _sections;        // 0x28
        private System.Boolean _isCollapsed;        // 0x30
        private System.Boolean _active;        // 0x31
        private System.Boolean _isLocked;        // 0x32
        private System.Boolean _isReadOnly;        // 0x33
        private Slate.TransformSnapshot transformSnapshot;        // 0x38
        private Slate.ObjectSnapshot objectSnapshot;        // 0x40
        private UnityEngine.GameObject refDuplicateActor;        // 0x48
        private static System.Int32 totalCustomToggleNum;        // 0x0
        public System.Collections.Generic.List<Slate.CutsceneGroup.CustomToggleInfo> customToggle;        // 0x50
        private System.Boolean m_customToggleValid;        // 0x58
        private System.Boolean m_customToggleCheckDirty;        // 0x59
        public System.Collections.Generic.Dictionary<System.Int32,Slate.CutsceneGroup.CustomToggleInfo> customInfoCache;        // 0x60
        private Slate.IDirector <root>k__BackingField;        // 0x68

        // Methods
        private System.Void add_OnSectionReached(System.Action<Slate.Section> value) { }
        private System.Void remove_OnSectionReached(System.Action<Slate.Section> value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.GameObject get_actor() { }
        private System.Void set_actor(UnityEngine.GameObject value) { }
        private Slate.CutsceneGroup.ActorReferenceMode get_referenceMode() { }
        private System.Void set_referenceMode(Slate.CutsceneGroup.ActorReferenceMode value) { }
        private Slate.CutsceneGroup.ActorInitialTransformation get_initialTransformation() { }
        private System.Void set_initialTransformation(Slate.CutsceneGroup.ActorInitialTransformation value) { }
        private UnityEngine.Vector3 get_initialLocalPosition() { }
        private System.Void set_initialLocalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_initialLocalRotation() { }
        private System.Void set_initialLocalRotation(UnityEngine.Vector3 value) { }
        private System.Boolean get_displayVirtualMeshGizmo() { }
        private System.Void set_displayVirtualMeshGizmo(System.Boolean value) { }
        private System.Boolean get_needActor() { }
        private System.Int32 get_updateOrder() { }
        private System.Void SetCustomToggleDirty() { }
        private System.Boolean get_customToggleValid() { }
        private System.Void _OnCustomToggleValueChanged() { }
        private System.Boolean CheckCustomCollapsed(System.Int32 index) { }
        private System.Void _TryRefreshCustomToggleInfo() { }
        private System.Collections.Generic.List<Slate.CutsceneTrack> get_tracks() { }
        private System.Void set_tracks(System.Collections.Generic.List<Slate.CutsceneTrack> value) { }
        private System.Collections.Generic.List<Slate.Section> get_sections() { }
        private System.Void set_sections(System.Collections.Generic.List<Slate.Section> value) { }
        private System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirectable.get_children() { }
        private System.Single Slate.IDirectable.get_startTime() { }
        private System.Single Slate.IDirectable.get_endTime() { }
        private System.Single Slate.IDirectable.get_blendIn() { }
        private System.Single Slate.IDirectable.get_blendOut() { }
        private System.Boolean Slate.IDirectable.get_canCrossBlend() { }
        private Slate.IDirectable Slate.IDirectable.get_parent() { }
        private Slate.IDirector get_root() { }
        private System.Void set_root(Slate.IDirector value) { }
        private System.Boolean get_isActive() { }
        private System.Void set_isActive(System.Boolean value) { }
        private System.Boolean get_isCollapsed() { }
        private System.Void set_isCollapsed(System.Boolean value) { }
        private System.Boolean get_isLocked() { }
        private System.Void set_isLocked(System.Boolean value) { }
        private System.Boolean get_isReadOnly() { }
        private System.Void set_isReadOnly(System.Boolean value) { }
        private System.String ToString() { }
        private System.Void Validate(Slate.IDirector root, Slate.IDirectable parent) { }
        private Slate.Section GetSectionByName(System.String name) { }
        private Slate.Section GetSectionByUID(System.String UID) { }
        private Slate.Section GetSectionAfter(System.Single time) { }
        private Slate.Section GetSectionBefore(System.Single time) { }
        private System.Boolean Slate.IDirectable.Initialize() { }
        private System.Void Slate.IDirectable.Enter() { }
        private System.Void Slate.IDirectable.Reverse() { }
        private System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime) { }
        private System.Void Slate.IDirectable.Exit() { }
        private System.Void Slate.IDirectable.ReverseEnter() { }
        private System.Void Slate.IDirectable.RootEnabled() { }
        private System.Void Slate.IDirectable.RootDisabled() { }
        private System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void Slate.IDirectable.RootDestroyed() { }
        private System.Void StoreActorState() { }
        private System.Void RestoreActorState() { }
        private System.Void TryInstantiateLocalActor() { }
        private System.Void ReleaseLocalActorInstance() { }
        private System.Void SetActorLocalCoords() { }
        private UnityEngine.GameObject ResolveActor(UnityEngine.GameObject original) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000077
    public class CutsceneTrack : MonoBehaviour, IDirectable
    {
        // Fields
        private System.String _name;        // 0x18
        private UnityEngine.Color _color;        // 0x20
        private System.Boolean _active;        // 0x30
        private System.Boolean _isLocked;        // 0x31
        private System.Collections.Generic.List<Slate.ActionClip> _actionClips;        // 0x38
        private System.Boolean _isReadOnly;        // 0x40
        private System.Int32 <layerOrder>k__BackingField;        // 0x44
        private Slate.IDirectable <parent>k__BackingField;        // 0x48

        // Methods
        private UnityEngine.GameObject get_actor() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.Color get_color() { }
        private System.Collections.Generic.List<Slate.ActionClip> get_clips() { }
        private System.Void set_clips(System.Collections.Generic.List<Slate.ActionClip> value) { }
        private System.String get_info() { }
        private System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirectable.get_children() { }
        private System.Int32 get_layerOrder() { }
        private System.Void set_layerOrder(System.Int32 value) { }
        private Slate.IDirector get_root() { }
        private Slate.IDirectable get_parent() { }
        private System.Void set_parent(Slate.IDirectable value) { }
        private System.Boolean get_isCollapsed() { }
        private System.Boolean get_isActive() { }
        private System.Void set_isActive(System.Boolean value) { }
        private System.Boolean get_isLocked() { }
        private System.Void set_isLocked(System.Boolean value) { }
        private System.Single get_startTime() { }
        private System.Void set_startTime(System.Single value) { }
        private System.Single get_endTime() { }
        private System.Void set_endTime(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private System.Boolean get_needActor() { }
        private System.Int32 get_updateOrder() { }
        private System.Boolean get_isReadOnly() { }
        private System.Void set_isReadOnly(System.Boolean value) { }
        private System.Boolean Slate.IDirectable.Initialize() { }
        private System.Void Slate.IDirectable.Enter() { }
        private System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime) { }
        private System.Void Slate.IDirectable.Exit() { }
        private System.Void Slate.IDirectable.ReverseEnter() { }
        private System.Void Slate.IDirectable.Reverse() { }
        private System.Void Slate.IDirectable.RootEnabled() { }
        private System.Void Slate.IDirectable.RootDisabled() { }
        private System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void Slate.IDirectable.RootDestroyed() { }
        private System.Void PostCreate(Slate.IDirectable parent) { }
        private System.Void Validate(Slate.IDirector root, Slate.IDirectable parent) { }
        private System.Void OnCreate() { }
        private System.Void OnAfterValidate() { }
        private System.Boolean OnInitialize() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void OnSceneGUI() { }
        private System.Void OnRootEnabled() { }
        private System.Void OnRootDisabled() { }
        private System.Void OnRootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void OnRootDestroyed() { }
        private System.Single GetTrackWeight() { }
        private System.Single GetTrackWeight(System.Single time) { }
        private System.Single GetTrackWeight(System.Single time, System.Single blendInOut) { }
        private System.Single GetTrackWeight(System.Single time, System.Single blendIn, System.Single blendOut) { }
        private T AddAction(System.Single time) { }
        private Slate.ActionClip AddAction(System.Type type, System.Single time) { }
        private System.Void .ctor() { }
        private System.Boolean <Validate>b__70_1(Slate.IDirectable t) { }

    }

    // TypeToken: 0x200007A
    public interface IAnimatableData
    {
        // Methods
        private System.Boolean get_isValid() { }
        private UnityEngine.AnimationCurve[] GetCurves() { }
        private System.Void Validate(Slate.IKeyable keyable) { }
        private System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent) { }
        private System.Void SetSnapshot() { }
        private System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight) { }
        private System.Void RestoreSnapshot() { }
        private System.Void SetKeyCurrent(System.Single time) { }
        private System.Boolean TryAutoKey(System.Single time) { }
        private System.Boolean TryKeyIdentity(System.Single time) { }
        private System.Void RemoveKey(System.Single time) { }
        private System.Boolean HasKey(System.Single time) { }
        private System.Boolean HasAnyKey() { }
        private System.Boolean HasChanged() { }
        private System.Single GetKeyNext(System.Single time) { }
        private System.Single GetKeyPrevious(System.Single time) { }
        private System.String GetKeyLabel(System.Single time) { }
        private System.Void SetPreWrapMode(UnityEngine.WrapMode mode) { }
        private System.Void SetPostWrapMode(UnityEngine.WrapMode mode) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x200007B
    public interface IDirectable
    {
        // Methods
        private Slate.IDirector get_root() { }
        private Slate.IDirectable get_parent() { }
        private System.Collections.Generic.IEnumerable<Slate.IDirectable> get_children() { }
        private UnityEngine.GameObject get_actor() { }
        private System.String get_name() { }
        private System.Boolean get_isActive() { }
        private System.Boolean get_isCollapsed() { }
        private System.Boolean get_isLocked() { }
        private System.Single get_startTime() { }
        private System.Single get_endTime() { }
        private System.Single get_blendIn() { }
        private System.Single get_blendOut() { }
        private System.Boolean get_canCrossBlend() { }
        private System.Void Validate(Slate.IDirector root, Slate.IDirectable parent) { }
        private System.Boolean Initialize() { }
        private System.Void Enter() { }
        private System.Void Exit() { }
        private System.Void Update(System.Single time, System.Single previousTime) { }
        private System.Void ReverseEnter() { }
        private System.Void Reverse() { }
        private System.Void RootEnabled() { }
        private System.Void RootUpdated(System.Single time, System.Single previousTime) { }
        private System.Void RootDisabled() { }
        private System.Void RootDestroyed() { }
        private System.Boolean get_needActor() { }
        private System.Int32 get_updateOrder() { }
        private System.Boolean get_isReadOnly() { }

    }

    // TypeToken: 0x200007C
    public interface IKeyable : IDirectable
    {
        // Methods
        private Slate.AnimationDataCollection get_animationData() { }
        private System.Object get_animatedParametersTarget() { }

    }

    // TypeToken: 0x200007D
    public interface ISubClipContainable : IDirectable
    {
        // Methods
        private System.Single get_subClipOffset() { }
        private System.Void set_subClipOffset(System.Single value) { }
        private System.Single get_subClipSpeed() { }
        private System.Single get_subClipLength() { }

    }

    // TypeToken: 0x200007E
    public class IDirectableExtensions
    {
        // Methods
        private System.Single GetLength(Slate.IDirectable directable) { }
        private System.Single RootTimeToLocalTime(Slate.IDirectable directable) { }
        private System.Single RootTimeToLocalTimeUnclamped(Slate.IDirectable directable) { }
        private System.Boolean IsRootTimeWithinClip(Slate.IDirectable directable) { }
        private System.Single ToLocalTime(Slate.IDirectable directable, System.Single time) { }
        private System.Single ToLocalTimeUnclamped(Slate.IDirectable directable, System.Single time) { }
        private System.Boolean IsTimeWithinClip(Slate.IDirectable directable, System.Single time) { }
        private System.Boolean CanCrossBlend(Slate.IDirectable directable, Slate.IDirectable other) { }
        private System.Boolean CanBlendIn(Slate.IDirectable directable) { }
        private System.Boolean CanBlendOut(Slate.IDirectable directable) { }
        private System.Boolean CanScale(Slate.IDirectable directable) { }
        private System.Boolean WithinBufferTriggerRange(Slate.IDirectable directable, System.Single time, System.Single previousTime, System.Boolean bypass) { }
        private Slate.IDirectable FindChild(Slate.IDirectable directable, System.String name) { }
        private T GetPreviousSibling(Slate.IDirectable directable) { }
        private Slate.IDirectable GetPreviousSibling(Slate.IDirectable directable) { }
        private T GetNextSibling(Slate.IDirectable directable) { }
        private Slate.IDirectable GetNextSibling(Slate.IDirectable directable) { }
        private T GetFirstParentOfType(Slate.IDirectable directable) { }
        private System.Single GetWeight(Slate.IDirectable directable) { }
        private System.Single GetWeight(Slate.IDirectable directable, System.Single time) { }
        private System.Single GetWeight(Slate.IDirectable directable, System.Single time, System.Single blendInOut) { }
        private System.Single GetWeight(Slate.IDirectable directable, System.Single time, System.Single blendIn, System.Single blendOut) { }
        private UnityEngine.Transform GetSpaceTransform(Slate.IDirectable directable, Slate.TransformSpace space, UnityEngine.GameObject actorOverride) { }
        private UnityEngine.Vector3 TransformPosition(Slate.IDirectable directable, UnityEngine.Vector3 point, Slate.TransformSpace space) { }
        private UnityEngine.Vector3 InverseTransformPosition(Slate.IDirectable directable, UnityEngine.Vector3 point, Slate.TransformSpace space) { }
        private UnityEngine.Quaternion TransformRotation(Slate.IDirectable directable, UnityEngine.Vector3 euler, Slate.TransformSpace space) { }
        private UnityEngine.Vector3 InverseTransformRotation(Slate.IDirectable directable, UnityEngine.Quaternion rot, Slate.TransformSpace space) { }
        private UnityEngine.Vector3 ActorPositionInSpace(Slate.IDirectable directable, Slate.TransformSpace space) { }
        private System.Single GetPreviousLoopLocalTime(Slate.ISubClipContainable clip) { }
        private System.Single GetNextLoopLocalTime(Slate.ISubClipContainable clip) { }
        private UnityEngine.AnimationCurve[] GetCurvesAll(Slate.IKeyable keyable) { }

    }

    // TypeToken: 0x2000082
    public interface IDirector
    {
        // Methods
        private System.Collections.Generic.IEnumerable<Slate.IDirectable> get_children() { }
        private UnityEngine.GameObject get_context() { }
        private System.Single get_length() { }
        private System.Single get_currentTime() { }
        private System.Void set_currentTime(System.Single value) { }
        private System.Single get_previousTime() { }
        private System.Single get_playbackSpeed() { }
        private System.Void set_playbackSpeed(System.Single value) { }
        private System.Boolean get_isActive() { }
        private System.Boolean get_isPaused() { }
        private System.Boolean get_isReSampleFrame() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.GameObject> GetAffectedActors() { }
        private System.Void Play() { }
        private System.Void Pause() { }
        private System.Void Stop() { }
        private System.Void Sample(System.Single time) { }
        private System.Void ReSample() { }
        private System.Void Validate() { }
        private System.Void SendGlobalMessage(System.String message, System.Object value) { }

    }

    // TypeToken: 0x2000083
    public class Section
    {
        // Fields
        public static readonly UnityEngine.Color DEFAULT_COLOR;        // 0x0
        private System.String _UID;        // 0x10
        private System.String _name;        // 0x18
        private System.Single _time;        // 0x20
        private Slate.Section.ExitMode _exitMode;        // 0x24
        private System.Int32 _loopCount;        // 0x28
        private UnityEngine.Color _color;        // 0x2C
        private System.Boolean _colorizeBackground;        // 0x3C
        private System.Int32 <currentLoopIteration>k__BackingField;        // 0x40

        // Methods
        private System.Int32 get_currentLoopIteration() { }
        private System.Void set_currentLoopIteration(System.Int32 value) { }
        private System.String get_UID() { }
        private System.Void set_UID(System.String value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Single get_time() { }
        private System.Void set_time(System.Single value) { }
        private Slate.Section.ExitMode get_exitMode() { }
        private System.Void set_exitMode(Slate.Section.ExitMode value) { }
        private System.Int32 get_loopCount() { }
        private System.Void set_loopCount(System.Int32 value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Boolean get_colorizeBackground() { }
        private System.Void set_colorizeBackground(System.Boolean value) { }
        private System.Void .ctor(System.String name, System.Single time) { }
        private System.Void ResetLoops() { }
        private System.Void BreakLoop() { }
        private System.Boolean TryUpdateLoop() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000085
    public interface IDirectableTimePointer
    {
        // Methods
        private Slate.IDirectable get_target() { }
        private System.Single get_time() { }
        private System.Void TriggerForward(System.Single currentTime, System.Single previousTime) { }
        private System.Void TriggerBackward(System.Single currentTime, System.Single previousTime) { }
        private System.Void Update(System.Single currentTime, System.Single previousTime) { }

    }

    // TypeToken: 0x2000086
    public struct StartTimePointer, IDirectableTimePointer
    {
        // Fields
        private System.Boolean triggered;        // 0x10
        private System.Single lastTargetStartTime;        // 0x14
        private Slate.IDirectable <target>k__BackingField;        // 0x18

        // Methods
        private Slate.IDirectable get_target() { }
        private System.Void set_target(Slate.IDirectable value) { }
        private System.Single Slate.IDirectableTimePointer.get_time() { }
        private System.Void .ctor(Slate.IDirectable target) { }
        private System.Void Slate.IDirectableTimePointer.TriggerForward(System.Single currentTime, System.Single previousTime) { }
        private System.Void Slate.IDirectableTimePointer.Update(System.Single currentTime, System.Single previousTime) { }
        private System.Void Slate.IDirectableTimePointer.TriggerBackward(System.Single currentTime, System.Single previousTime) { }

    }

    // TypeToken: 0x2000087
    public struct EndTimePointer, IDirectableTimePointer
    {
        // Fields
        private System.Boolean triggered;        // 0x10
        private Slate.IDirectable <target>k__BackingField;        // 0x18

        // Methods
        private Slate.IDirectable get_target() { }
        private System.Void set_target(Slate.IDirectable value) { }
        private System.Single Slate.IDirectableTimePointer.get_time() { }
        private System.Void .ctor(Slate.IDirectable target) { }
        private System.Void Slate.IDirectableTimePointer.TriggerForward(System.Single currentTime, System.Single previousTime) { }
        private System.Void Slate.IDirectableTimePointer.Update(System.Single currentTime, System.Single previousTime) { }
        private System.Void Slate.IDirectableTimePointer.TriggerBackward(System.Single currentTime, System.Single previousTime) { }

    }

    // TypeToken: 0x2000088
    public class BezierPath : Path
    {
        // Fields
        public System.Int32 resolution;        // 0x18
        private System.Collections.Generic.List<Slate.BezierPoint> _points;        // 0x20
        private UnityEngine.Vector3[] _sampledPathPoints;        // 0x28
        private System.Single _length;        // 0x30

        // Methods
        private System.Collections.Generic.List<Slate.BezierPoint> get_points() { }
        private Slate.BezierPoint get_Item(System.Int32 index) { }
        private System.Int32 get_pointCount() { }
        private System.Single get_length() { }
        private System.Void Awake() { }
        private System.Void OnValidate() { }
        private System.Void Compute() { }
        private System.Void SetDirty() { }
        private System.Void ComputeLength() { }
        private System.Void ComputeSampledPathPoints() { }
        private Slate.BezierPath Create(UnityEngine.Transform targetParent) { }
        private Slate.BezierPoint AddPointAt(UnityEngine.Vector3 position, System.Int32 index) { }
        private System.Void RemovePoint(Slate.BezierPoint point) { }
        private System.Int32 GetPointIndex(Slate.BezierPoint point) { }
        private UnityEngine.Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, System.Int32 resolution) { }
        private UnityEngine.Vector3 GetPositionAt(System.Single t) { }
        private UnityEngine.Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, System.Single t) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000089
    public class BezierPoint
    {
        // Fields
        private Slate.BezierPath _path;        // 0x10
        public UnityEngine.Vector3 _position;        // 0x18
        private UnityEngine.Vector3 _handle1;        // 0x24
        private UnityEngine.Vector3 _handle2;        // 0x30
        private Slate.BezierPoint.HandleStyle _handleStyle;        // 0x3C

        // Methods
        private System.Void .ctor(Slate.BezierPath path, UnityEngine.Vector3 position) { }
        private Slate.BezierPoint.HandleStyle get_handleStyle() { }
        private System.Void set_handleStyle(Slate.BezierPoint.HandleStyle value) { }
        private Slate.BezierPath get_path() { }
        private System.Void set_path(Slate.BezierPath value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_handle1LocalPosition() { }
        private System.Void set_handle1LocalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_handle2LocalPosition() { }
        private System.Void set_handle2LocalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_handle1Position() { }
        private System.Void set_handle1Position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_handle2Position() { }
        private System.Void set_handle2Position(UnityEngine.Vector3 value) { }

    }

    // TypeToken: 0x200008B
    public class Path : MonoBehaviour
    {
        // Methods
        private System.Single get_length() { }
        private UnityEngine.Vector3 GetPositionAt(System.Single t) { }
        private System.Void Compute() { }
        private UnityEngine.Vector3 GetPositionAlongCurve(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 fromTangent, UnityEngine.Vector3 toTangent, System.Single t) { }
        private UnityEngine.Vector3 GetPosition(System.Single t, UnityEngine.Vector3[] path) { }
        private System.Single GetLength(UnityEngine.Vector3[] path) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public class AnimationDataUtility
    {
        // Methods
        private System.String[] GetAnimatableMemberPaths(System.Object root) { }
        private System.String[] Internal_GetAnimatableMemberPaths(System.Type type, System.String path) { }

    }

    // TypeToken: 0x200008D
    public class AnimatorDispatcher : MonoBehaviour
    {
        // Fields
        private System.Action<System.Int32> onAnimatorIK;        // 0x18
        private UnityEngine.Animator _animator;        // 0x20

        // Methods
        private System.Void add_onAnimatorIK(System.Action<System.Int32> value) { }
        private System.Void remove_onAnimatorIK(System.Action<System.Int32> value) { }
        private UnityEngine.Animator get_animator() { }
        private System.Void OnAnimatorIK(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008E
    public class AudioSampler
    {
        // Fields
        private static System.String ROOT_NAME;        // 0x0
        private static UnityEngine.GameObject root;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Object,UnityEngine.AudioSource> sources;        // 0x8

        // Methods
        private UnityEngine.AudioSource GetSourceForID(System.Object keyID) { }
        private System.Void ReleaseSourceForID(System.Object keyID) { }
        private System.Void SampleForID(System.Object keyID, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, System.Single volume) { }
        private System.Void SampleForID(System.Object keyID, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, Slate.AudioSampler.SampleSettings settings) { }
        private System.Void Sample(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, System.Single volume) { }
        private System.Void Sample(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, Slate.AudioSampler.SampleSettings settings) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000090
    public class ColorUtility
    {
        // Methods
        private UnityEngine.Color Grey(System.Single value) { }
        private UnityEngine.Color WithAlpha(UnityEngine.Color color, System.Single alpha) { }

    }

    // TypeToken: 0x2000091
    public struct TangentMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.TangentMode Editable;        // 0x0
        public static Slate.TangentMode Smooth;        // 0x0
        public static Slate.TangentMode Linear;        // 0x0
        public static Slate.TangentMode Constant;        // 0x0

    }

    // TypeToken: 0x2000092
    public class CurveUtility
    {
        // Fields
        private static System.Single KEY_PROXIMITY_TOLERANCE;        // 0x0

        // Methods
        private System.Single GetKeyNext(System.Single time, UnityEngine.AnimationCurve[] curves) { }
        private System.Single GetKeyPrevious(System.Single time, UnityEngine.AnimationCurve[] curves) { }
        private System.Boolean HasKey(System.Single time, UnityEngine.AnimationCurve[] curves) { }
        private System.Boolean HasAnyKey(UnityEngine.AnimationCurve[] curves) { }
        private System.Void OffsetCurveValue(UnityEngine.AnimationCurve curve, System.Single deltaValue) { }
        private System.Void OffsetCurveTime(UnityEngine.AnimationCurve curve, System.Single deltaTime) { }
        private System.Void RemoveNegativeKeys(UnityEngine.AnimationCurve curve) { }
        private System.Void RemoveKeysOffRange(UnityEngine.AnimationCurve curve, System.Single min, System.Single max) { }

    }

    // TypeToken: 0x2000097
    public class DecoratorAttribute : Attribute
    {
        // Fields
        public readonly System.Type targetType;        // 0x10

        // Methods
        private System.Void .ctor(System.Type targetType) { }

    }

    // TypeToken: 0x2000098
    public interface IDecorator
    {
        // Methods
        private System.Object get_Target() { }
        private System.Void set_Target(System.Object value) { }

    }

    // TypeToken: 0x2000099
    public class DecoratorFactory
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.Type> decoratorsTypeMap;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Object,Slate.IDecorator> decoratorsInstanceMap;        // 0x8

        // Methods
        private T Decorator(System.Object target) { }
        private T GetDecorator(System.Object target) { }
        private T CreateDecorator(System.Type targetType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009A
    public struct EaseType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Slate.EaseType Linear;        // 0x0
        public static Slate.EaseType QuadraticIn;        // 0x0
        public static Slate.EaseType QuadraticOut;        // 0x0
        public static Slate.EaseType QuadraticInOut;        // 0x0
        public static Slate.EaseType QuarticIn;        // 0x0
        public static Slate.EaseType QuarticOut;        // 0x0
        public static Slate.EaseType QuarticInOut;        // 0x0
        public static Slate.EaseType QuinticIn;        // 0x0
        public static Slate.EaseType QuinticOut;        // 0x0
        public static Slate.EaseType QuinticInOut;        // 0x0
        public static Slate.EaseType CubicIn;        // 0x0
        public static Slate.EaseType CubicOut;        // 0x0
        public static Slate.EaseType CubicInOut;        // 0x0
        public static Slate.EaseType ExponentialIn;        // 0x0
        public static Slate.EaseType ExponentialOut;        // 0x0
        public static Slate.EaseType ExponentialInOut;        // 0x0
        public static Slate.EaseType CircularIn;        // 0x0
        public static Slate.EaseType CircularOut;        // 0x0
        public static Slate.EaseType CircularInOut;        // 0x0
        public static Slate.EaseType SinusoidalIn;        // 0x0
        public static Slate.EaseType SinusoidalOut;        // 0x0
        public static Slate.EaseType SinusoidalInOut;        // 0x0
        public static Slate.EaseType ElasticIn;        // 0x0
        public static Slate.EaseType ElasticOut;        // 0x0
        public static Slate.EaseType ElasticInOut;        // 0x0
        public static Slate.EaseType BounceIn;        // 0x0
        public static Slate.EaseType BounceOut;        // 0x0
        public static Slate.EaseType BounceInOut;        // 0x0
        public static Slate.EaseType BackIn;        // 0x0
        public static Slate.EaseType BackOut;        // 0x0
        public static Slate.EaseType BackInOut;        // 0x0

    }

    // TypeToken: 0x200009B
    public class Easing
    {
        // Methods
        private System.Single Ease(Slate.EaseType type, System.Single from, System.Single to, System.Single t) { }
        private UnityEngine.Vector3 Ease(Slate.EaseType type, UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t) { }
        private UnityEngine.Quaternion Ease(Slate.EaseType type, UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single t) { }
        private UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, System.Single t) { }
        private System.Func<System.Single,System.Single> Function(Slate.EaseType type) { }
        private System.Single Linear(System.Single t) { }
        private System.Single QuadraticIn(System.Single t) { }
        private System.Single QuadraticOut(System.Single t) { }
        private System.Single QuadraticInOut(System.Single t) { }
        private System.Single QuarticIn(System.Single t) { }
        private System.Single QuarticOut(System.Single t) { }
        private System.Single QuarticInOut(System.Single t) { }
        private System.Single QuinticIn(System.Single t) { }
        private System.Single QuinticOut(System.Single t) { }
        private System.Single QuinticInOut(System.Single t) { }
        private System.Single CubicIn(System.Single t) { }
        private System.Single CubicOut(System.Single t) { }
        private System.Single CubicInOut(System.Single t) { }
        private System.Single SinusoidalIn(System.Single t) { }
        private System.Single SinusoidalOut(System.Single t) { }
        private System.Single SinusoidalInOut(System.Single t) { }
        private System.Single ExponentialIn(System.Single t) { }
        private System.Single ExponentialOut(System.Single t) { }
        private System.Single ExponentialInOut(System.Single t) { }
        private System.Single CircularIn(System.Single t) { }
        private System.Single CircularOut(System.Single t) { }
        private System.Single CircularInOut(System.Single t) { }
        private System.Single ElasticIn(System.Single t) { }
        private System.Single ElasticOut(System.Single t) { }
        private System.Single ElasticInOut(System.Single t) { }
        private System.Single BounceIn(System.Single t) { }
        private System.Single BounceOut(System.Single t) { }
        private System.Single BounceInOut(System.Single t) { }
        private System.Single BackIn(System.Single t) { }
        private System.Single BackOut(System.Single t) { }
        private System.Single BackInOut(System.Single t) { }

    }

    // TypeToken: 0x200009C
    public interface ITransformRefParameter
    {
        // Methods
        private UnityEngine.Transform get_transform() { }
        private Slate.TransformSpace get_space() { }
        private System.Boolean get_useAnimation() { }

    }

    // TypeToken: 0x200009D
    public class ObjectSnapshot
    {
        // Fields
        private static System.Collections.Generic.List<System.Type> ignoreTypes;        // 0x0
        private System.Collections.Generic.Dictionary<UnityEngine.Object,System.String> serialized;        // 0x10

        // Methods
        private System.Void AppendIgnoreType(System.Type type) { }
        private System.Void .ctor(UnityEngine.Object target, System.Boolean fullObjectHierarchy) { }
        private System.Void Store(UnityEngine.Object target, System.Boolean fullObjectHierarchy) { }
        private System.Void Restore() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009E
    public class RectUtility
    {
        // Methods
        private UnityEngine.Rect GetBoundRect(UnityEngine.Rect[] rects) { }
        private UnityEngine.Rect GetBoundRect(UnityEngine.Vector2[] positions) { }
        private System.Boolean Encapsulates(UnityEngine.Rect a, UnityEngine.Rect b) { }
        private UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single margin) { }
        private UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single xMargin, System.Single yMargin) { }
        private UnityEngine.Rect TransformSpace(UnityEngine.Rect rect, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer) { }
        private UnityEngine.Rect ToViewRect(UnityEngine.Bounds b, UnityEngine.Camera cam) { }

    }

    // TypeToken: 0x200009F
    public class ReflectionTools
    {
        // Fields
        private static System.Reflection.BindingFlags flagsEverything;        // 0x0
        private static System.Collections.Generic.List<System.Reflection.Assembly> _loadedAssemblies;        // 0x0
        private static System.Collections.Generic.Dictionary<System.String,System.Type> typeMap;        // 0x8
        private static System.Collections.Generic.Dictionary<System.Type,System.Type[]> subTypesMap;        // 0x10

        // Methods
        private System.Collections.Generic.List<System.Reflection.Assembly> get_loadedAssemblies() { }
        private System.Type GetType(System.String typeName) { }
        private System.Type[] GetAllTypes() { }
        private System.Type[] GetImplementationsOf(System.Type type) { }
        private System.Type[] RTGetExportedTypes(System.Reflection.Assembly asm) { }
        private System.String FriendlyName(System.Type type) { }
        private System.Boolean RTIsStatic(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Boolean RTIsAbstract(System.Type type) { }
        private System.Boolean RTIsSubclassOf(System.Type type, System.Type other) { }
        private System.Boolean RTIsAssignableFrom(System.Type type, System.Type second) { }
        private System.Reflection.FieldInfo RTGetField(System.Type type, System.String name) { }
        private System.Reflection.PropertyInfo RTGetProperty(System.Type type, System.String name) { }
        private System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name) { }
        private System.Reflection.FieldInfo[] RTGetFields(System.Type type) { }
        private System.Reflection.PropertyInfo[] RTGetProperties(System.Type type) { }
        private System.Reflection.MethodInfo RTGetGetMethod(System.Reflection.PropertyInfo prop) { }
        private System.Reflection.MethodInfo RTGetSetMethod(System.Reflection.PropertyInfo prop) { }
        private System.Type RTReflectedType(System.Type type) { }
        private System.Type RTReflectedType(System.Reflection.MemberInfo member) { }
        private T RTGetAttribute(System.Type type, System.Boolean inherited) { }
        private T RTGetAttribute(System.Reflection.MemberInfo member, System.Boolean inherited) { }
        private System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Boolean inherited) { }
        private T RTCreateDelegate(System.Reflection.MethodInfo method, System.Object instance) { }
        private System.Action<T,TValue> GetFieldOrPropSetter(System.Reflection.MemberInfo info) { }
        private System.Reflection.MemberInfo[] RTGetFieldsAndProps(System.Type type) { }
        private System.Reflection.MemberInfo RTGetFieldOrProp(System.Type type, System.String name) { }
        private System.Object RTGetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Int32 index) { }
        private System.Void RTSetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Object value, System.Int32 index) { }
        private System.Type RTGetFieldOrPropType(System.Reflection.MemberInfo member) { }
        private System.Reflection.MemberInfo GetRelativeMember(System.Object root, System.String path) { }
        private System.Reflection.MemberInfo GetRelativeMember(System.Type type, System.String path) { }
        private System.Object GetRelativeMemberParent(System.Object root, System.String path) { }
        private System.String GetMemberPath(System.Linq.Expressions.Expression<System.Func<T,TResult>> func) { }
        private System.String[] GetMemberPaths(System.Type type, System.Predicate<System.Type> shouldInclude, System.Predicate<System.Type> shouldContinue, System.String currentPath, System.Collections.Generic.List<System.Type> recursionCheck) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A2
    public class StringUtility
    {
        // Methods
        private System.String SplitCamelCase(System.String s) { }
        private System.String AbsToRelativePath(System.String absolutepath) { }

    }

    // TypeToken: 0x20000A3
    public struct TransformRefPosition, ITransformRefParameter
    {
        // Fields
        private Slate.CutsceneGroup _group;        // 0x10
        private UnityEngine.Transform _transform;        // 0x18
        private UnityEngine.Vector3 _vector;        // 0x20
        private Slate.TransformSpace _space;        // 0x2C

        // Methods
        private System.Boolean get_useAnimation() { }
        private Slate.CutsceneGroup get_group() { }
        private System.Void set_group(Slate.CutsceneGroup value) { }
        private UnityEngine.Transform get_transform() { }
        private System.Void set_transform(UnityEngine.Transform value) { }
        private UnityEngine.Vector3 get_value() { }
        private System.Void set_value(UnityEngine.Vector3 value) { }
        private Slate.TransformSpace get_space() { }
        private System.Void set_space(Slate.TransformSpace value) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000A4
    public struct TransformRefPositionRotation, ITransformRefParameter
    {
        // Fields
        private Slate.CutsceneGroup _group;        // 0x10
        private UnityEngine.Transform _transform;        // 0x18
        private UnityEngine.Vector3 _position;        // 0x20
        private UnityEngine.Vector3 _rotation;        // 0x2C
        private Slate.TransformSpace _space;        // 0x38

        // Methods
        private System.Boolean get_useAnimation() { }
        private Slate.CutsceneGroup get_group() { }
        private System.Void set_group(Slate.CutsceneGroup value) { }
        private UnityEngine.Transform get_transform() { }
        private System.Void set_transform(UnityEngine.Transform value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_rotation() { }
        private System.Void set_rotation(UnityEngine.Vector3 value) { }
        private Slate.TransformSpace get_space() { }
        private System.Void set_space(Slate.TransformSpace value) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000A5
    public class TransformSnapshot
    {
        // Fields
        private System.Collections.Generic.List<Slate.TransformSnapshot.TransformData> data;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.GameObject root, Slate.TransformSnapshot.StoreMode mode) { }
        private System.Void Store(UnityEngine.GameObject root, Slate.TransformSnapshot.StoreMode mode) { }
        private System.Void Restore() { }

    }

    // TypeToken: 0x20000A8
    public class UnityObjectUtility
    {
        // Fields
        private static System.Reflection.MethodInfo _getLocalEulerAngles;        // 0x0
        private static System.Reflection.MethodInfo _setLocalEulerAngles;        // 0x8
        private static System.Reflection.PropertyInfo _rotationOrder;        // 0x10
        private static System.Object[] _rotationOrderArgGet;        // 0x18
        private static System.Object[] _rotationOrderArgSet;        // 0x20

        // Methods
        private System.Void .cctor() { }
        private UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.Transform transform) { }
        private System.Void SetLocalEulerAngles(UnityEngine.Transform transform, UnityEngine.Vector3 value) { }
        private System.String CalculateTransformPath(UnityEngine.Transform root, UnityEngine.Transform child) { }
        private UnityEngine.Transform ResolveTransformPath(UnityEngine.Transform root, System.String path) { }
        private UnityEngine.Transform FindInChildren(UnityEngine.Transform root, System.String name, System.Boolean includeHidden) { }
        private System.Void ResetLocalCoords(UnityEngine.Transform transform, System.Boolean includeScale) { }
        private System.Void SetLocalCoordsFrom(UnityEngine.Transform transform, UnityEngine.Transform source) { }
        private UnityEngine.Transform InsertParentInChain(UnityEngine.Transform transform, System.String name) { }
        private T GetAddComponent(UnityEngine.GameObject go) { }
        private T GetAddComponent(UnityEngine.Component comp) { }
        private UnityEngine.Component GetAddComponent(UnityEngine.GameObject go, System.Type type) { }
        private System.Collections.Generic.List<System.String> GetBlendShapeNames(UnityEngine.SkinnedMeshRenderer skinnedMesh) { }
        private System.Int32 GetBlendShapeIndex(UnityEngine.SkinnedMeshRenderer skinnedMesh, System.String shapeName) { }

    }

    // TypeToken: 0x20000AA
    public class VideoSampler
    {
        // Fields
        private static System.String ROOT_NAME;        // 0x0
        private static UnityEngine.GameObject root;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Object,UnityEngine.Video.VideoPlayer> sources;        // 0x8

        // Methods
        private UnityEngine.Video.VideoPlayer GetSourceForID(System.Object keyID) { }
        private System.Void ReleaseSourceForID(System.Object keyID) { }
        private System.Void SampleForID(System.Object keyID, UnityEngine.Video.VideoClip clip, System.Single time, System.Single previousTime, Slate.VideoSampler.SampleSettings settings) { }
        private System.Void Sample(UnityEngine.Video.VideoPlayer source, UnityEngine.Video.VideoClip clip, System.Single time, System.Single previousTime, Slate.VideoSampler.SampleSettings settings) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD
    public class CutsceneSequencePlayer : MonoBehaviour
    {
        // Fields
        public System.Boolean playOnStart;        // 0x18
        public System.Collections.Generic.List<Slate.Cutscene> cutscenes;        // 0x20
        public UnityEngine.Events.UnityEvent onFinish;        // 0x28
        private System.Int32 currentIndex;        // 0x30
        private System.Boolean isPlaying;        // 0x34

        // Methods
        private System.Void Start() { }
        private System.Void Play() { }
        private System.Void Stop() { }
        private System.Void MoveNext() { }
        private UnityEngine.GameObject Create() { }
        private System.Void .ctor() { }
        private System.Void <MoveNext>b__8_0() { }

    }

    // TypeToken: 0x20000AE
    public class DirectorGUITemplate : MonoBehaviour
    {
        // Fields
        public System.Boolean dontDestroyOnLoad;        // 0x18
        public UnityEngine.UI.CanvasScaler absScaler;        // 0x20
        public UnityEngine.UI.CanvasScaler refScaler;        // 0x28
        public UnityEngine.CanvasGroup cameraDissolveGroup;        // 0x30
        public UnityEngine.UI.RawImage dissolverImage;        // 0x38
        public UnityEngine.CanvasGroup letterboxGroup;        // 0x40
        public UnityEngine.UI.RawImage letterboxTop;        // 0x48
        public UnityEngine.UI.RawImage letterboxBottom;        // 0x50
        public UnityEngine.CanvasGroup screenFadeGroup;        // 0x58
        public UnityEngine.UI.RawImage screenFadeImage;        // 0x60
        public UnityEngine.CanvasGroup overlayImageGroup;        // 0x68
        public UnityEngine.UI.RawImage overlayImage;        // 0x70
        public UnityEngine.CanvasGroup overlayTextGroup;        // 0x78
        public UnityEngine.UI.Text overlayText;        // 0x80
        public UnityEngine.CanvasGroup subtitlesGroup;        // 0x88
        public UnityEngine.UI.Text subtitlesText;        // 0x90
        private static Slate.DirectorGUITemplate _current;        // 0x0

        // Methods
        private System.Void Awake() { }
        private System.Void ShowAll() { }
        private System.Void HideAll() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void OnCameraDissolve(UnityEngine.Texture texture, System.Single completion) { }
        private System.Void OnImageOverlayGUI(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position) { }
        private System.Void OnLetterboxGUI(System.Single completion) { }
        private System.Void OnScreenFadeGUI(UnityEngine.Color color) { }
        private System.Void OnTextOverlayGUI(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 position) { }
        private System.Void OnSubtitlesGUI(System.String text, UnityEngine.Color color) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF
    public class PlayCutsceneOnClick : MonoBehaviour
    {
        // Fields
        public Slate.Cutscene cutscene;        // 0x18
        public System.Single startTime;        // 0x20
        public UnityEngine.Events.UnityEvent onFinish;        // 0x28

        // Methods
        private System.Void OnMouseDown() { }
        private System.Void Reset() { }
        private UnityEngine.GameObject Create() { }
        private System.Void .ctor() { }
        private System.Void <OnMouseDown>b__3_0() { }

    }

    // TypeToken: 0x20000B0
    public class PlayCutsceneOnStart : MonoBehaviour
    {
        // Fields
        public Slate.Cutscene cutscene;        // 0x18
        public System.Single startTime;        // 0x20
        public UnityEngine.Events.UnityEvent onFinish;        // 0x28

        // Methods
        private System.Void Start() { }
        private UnityEngine.GameObject Create() { }
        private System.Void .ctor() { }
        private System.Void <Start>b__3_0() { }

    }

    // TypeToken: 0x20000B1
    public class PlayCutsceneOnTrigger : MonoBehaviour
    {
        // Fields
        public Slate.Cutscene cutscene;        // 0x18
        public System.Single startTime;        // 0x20
        public System.Boolean checkSpecificTagOnly;        // 0x24
        public System.String tagName;        // 0x28
        public System.Boolean once;        // 0x30
        public UnityEngine.Events.UnityEvent onFinish;        // 0x38

        // Methods
        private System.Void OnTriggerEnter(UnityEngine.Collider other) { }
        private System.Void Reset() { }
        private UnityEngine.GameObject Create() { }
        private System.Void .ctor() { }
        private System.Void <OnTriggerEnter>b__6_0() { }

    }

    // TypeToken: 0x20000B2
    public class StopCutsceneOnClick : MonoBehaviour
    {
        // Fields
        public Slate.Cutscene cutscene;        // 0x18
        public Slate.Cutscene.StopMode stopMode;        // 0x20

        // Methods
        private System.Void OnMouseDown() { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class StopCutsceneOnTrigger : MonoBehaviour
    {
        // Fields
        public Slate.Cutscene cutscene;        // 0x18
        public System.Boolean checkSpecificTagOnly;        // 0x20
        public System.String tagName;        // 0x28
        public Slate.Cutscene.StopMode stopMode;        // 0x30

        // Methods
        private System.Void OnTriggerEnter(UnityEngine.Collider other) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

}

namespace Slate.ActionClips
{

    // TypeToken: 0x20000B4
    public class ActorActionClip : ActionClip
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5
    public class ActorActionClip`1 : ActionClip
    {
        // Fields
        private T _actorComponent;        // 0x0

        // Methods
        private T get_actor() { }
        private System.Boolean get_isValid() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public class AnimateProperties : ActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        protected System.String _name;        // 0x50
        public Slate.EaseType interpolation;        // 0x58

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private System.Object get_animatedParametersTarget() { }
        private Slate.EaseType get_animatedParametersInterpolation() { }
        private System.Boolean get_useWeightInParameters() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public class AnimateBlendShape : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        private System.String _skinName;        // 0x50
        private System.String _shapeName;        // 0x58
        public System.Single weight;        // 0x60
        private System.Single originalWeight;        // 0x64
        private System.Int32 index;        // 0x68
        private UnityEngine.SkinnedMeshRenderer _skinnedMesh;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private System.String get_skinName() { }
        private System.Void set_skinName(System.String value) { }
        private System.String get_shapeName() { }
        private System.Void set_shapeName(System.String value) { }
        private UnityEngine.SkinnedMeshRenderer get_skinnedMesh() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }
        private System.Boolean <get_skinnedMesh>b__31_0(UnityEngine.SkinnedMeshRenderer s) { }

    }

    // TypeToken: 0x20000B8
    public class CharacterExpression : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.String expressionName;        // 0x58
        public System.String expressionUID;        // 0x60
        public System.Single weight;        // 0x68
        private System.Single originalWeight;        // 0x6C
        private Slate.BlendShapeGroup expression;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private Slate.BlendShapeGroup ResolveExpression() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public class CharacterLookAt : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public Slate.EaseType interpolation;        // 0x54
        public System.Single weight;        // 0x58
        public Slate.TransformRefPosition targetPosition;        // 0x60
        private UnityEngine.Quaternion wasNeckRot;        // 0x80
        private UnityEngine.Quaternion wasHeadRot;        // 0x90

        // Methods
        private UnityEngine.Vector3 get_targetPositionVector() { }
        private System.Void set_targetPositionVector(UnityEngine.Vector3 value) { }
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public class SendMessage`1 : SendMessage
    {
        // Fields
        public T value;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Type get_parameterType() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public class SendMessage : ActorActionClip
    {
        // Fields
        public System.String message;        // 0x40
        public System.Int32 componentIndex;        // 0x48

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Type get_parameterType() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC
    public class SendMessageBoolean : SendMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class SendMessageFloat : SendMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE
    public class SendMessageInteger : SendMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF
    public class SendMessageObject : SendMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public class SendMessageString : SendMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class AnimateActorVisibility : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public System.Boolean visible;        // 0x44
        private System.Boolean wasVisible;        // 0x45

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C2
    public class MakeCameraTarget : ActorActionClip
    {
        // Fields
        public System.Boolean setTransposerTarget;        // 0x40
        public System.Boolean setComposerTarget;        // 0x41
        private UnityEngine.Transform wasTransposerTarget;        // 0x48
        private UnityEngine.Transform wasComposerTarget;        // 0x50

        // Methods
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3
    public class SetActorActiveState : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public Slate.ActiveState activeState;        // 0x44
        private System.Boolean lastState;        // 0x48
        private System.Boolean currentState;        // 0x49
        private System.Boolean temporary;        // 0x4A

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C4
    public class SetActorVisibilityTemporary : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public Slate.ActiveState activeState;        // 0x44
        private System.Boolean lastState;        // 0x48
        private System.Boolean currentState;        // 0x49
        private System.Boolean temporary;        // 0x4A

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class SetBehavioursActiveState : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public System.Collections.Generic.List<System.String> behaviourNames;        // 0x48
        public Slate.ActiveState activeState;        // 0x50
        private System.Collections.Generic.Dictionary<UnityEngine.Behaviour,System.Boolean> originalStates;        // 0x58
        private System.Collections.Generic.Dictionary<UnityEngine.Behaviour,System.Boolean> currentStates;        // 0x60
        private System.Boolean temporary;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }
        private System.Boolean <OnEnter>b__11_0(UnityEngine.Behaviour c) { }

    }

    // TypeToken: 0x20000C6
    public class AnimateOnPath : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        public Slate.Path path;        // 0x48
        public System.Single positionOnPath;        // 0x50
        public UnityEngine.Vector3 lookAtTargetPosition;        // 0x54
        public Slate.EaseType blendInterpolation;        // 0x60
        private UnityEngine.Vector3 wasPosition;        // 0x64
        private UnityEngine.Quaternion wasRotation;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Boolean get_isValid() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7
    public class FollowPath : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public Slate.Path path;        // 0x50
        public System.Boolean useSpeed;        // 0x58
        public System.Single speed;        // 0x5C
        public System.Single lookAhead;        // 0x60
        public UnityEngine.Vector3 upVector;        // 0x64
        public Slate.EaseType blendInterpolation;        // 0x70
        private UnityEngine.Vector3 lastPos;        // 0x74
        private UnityEngine.Quaternion lastRot;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_isValid() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8
    public class PathfindFromTo : ActorActionClip
    {
        // Fields
        private System.Single _blendIn;        // 0x40
        public System.Single speed;        // 0x44
        public Slate.TransformRefPosition sourcePosition;        // 0x48
        public Slate.TransformRefPosition targetPosition;        // 0x68
        private UnityEngine.Vector3[] pathPoints;        // 0x88
        private UnityEngine.Vector3 wasPosition;        // 0x90
        private UnityEngine.Quaternion wasRotation;        // 0x9C
        private UnityEngine.Vector3 lastFrom;        // 0xAC
        private UnityEngine.Vector3 lastTo;        // 0xB8

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void TryCalculatePath() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class PathfindTo : ActorActionClip
    {
        // Fields
        private System.Single _blendIn;        // 0x40
        public System.Single speed;        // 0x44
        public Slate.TransformRefPosition targetPosition;        // 0x48
        private UnityEngine.Vector3[] pathPoints;        // 0x68
        private UnityEngine.Vector3 wasPosition;        // 0x70
        private UnityEngine.Quaternion wasRotation;        // 0x7C
        private UnityEngine.Vector3 lastFrom;        // 0x8C
        private UnityEngine.Vector3 lastTo;        // 0x98

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void TryCalculatePath() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class AnimateMaterialColor : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.String propertyName;        // 0x58
        public UnityEngine.Color color;        // 0x60
        public Slate.EaseType interpolation;        // 0x70
        private UnityEngine.Color originalColor;        // 0x74

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private UnityEngine.Material get_targetMaterial() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void DoSet() { }
        private System.Void DoReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB
    public class AnimateMaterialFloat : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.String propertyName;        // 0x58
        public System.Single value;        // 0x60
        public Slate.EaseType interpolation;        // 0x64
        private System.Single originalValue;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private UnityEngine.Material get_targetMaterial() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void DoSet() { }
        private System.Void DoReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CC
    public class AnimateMaterialTexture : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.String propertyName;        // 0x58
        public UnityEngine.Vector2 offset;        // 0x60
        public UnityEngine.Vector2 scale;        // 0x68
        public Slate.EaseType interpolation;        // 0x70
        private UnityEngine.Vector2 originalOffset;        // 0x74
        private UnityEngine.Vector2 originalScale;        // 0x7C

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private UnityEngine.Material get_targetMaterial() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void DoSet() { }
        private System.Void DoReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD
    public class ScrollMaterialTexture : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        public System.String propertyName;        // 0x50
        public UnityEngine.Vector2 speed;        // 0x58
        public Slate.EaseType interpolation;        // 0x60
        private UnityEngine.Vector2 originalOffset;        // 0x64

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private UnityEngine.Material get_targetMaterial() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE
    public class SetMaterial : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        public UnityEngine.Material material;        // 0x50
        private UnityEngine.Material sharedMat;        // 0x58
        private System.Boolean temporary;        // 0x60

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void DoSet() { }
        private System.Void DoReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class SetMaterialTexture : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        public System.String propertyName;        // 0x50
        public UnityEngine.Texture texture;        // 0x58
        private UnityEngine.Texture originalTexture;        // 0x60
        private System.Boolean temporary;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private UnityEngine.Material get_targetMaterial() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void DoSet() { }
        private System.Void DoReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class SetSortingLayer : ActorActionClip`1
    {
        // Fields
        public System.Int32 sortingOrder;        // 0x48
        public System.Int32 sortingLayerID;        // 0x4C
        private System.String _lastLayer;        // 0x50
        private System.Int32 _lastOrder;        // 0x58

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1
    public class SetSprite : ActorActionClip`1
    {
        // Fields
        public UnityEngine.Sprite sprite;        // 0x48
        public UnityEngine.Color color;        // 0x50
        public System.Boolean flipX;        // 0x60
        public System.Boolean flipY;        // 0x61
        public System.Boolean changeSorting;        // 0x62
        public System.Int32 sortingLayerID;        // 0x64
        public System.Int32 sortingOrder;        // 0x68
        private UnityEngine.Sprite lastSprite;        // 0x70
        private UnityEngine.Color lastColor;        // 0x78
        private System.Boolean lastFlipX;        // 0x88
        private System.Boolean lastFlipY;        // 0x89
        private System.Int32 lastSortingLayerID;        // 0x8C
        private System.Int32 lastSortingOrder;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class SpriteFlipbook : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        public System.Int32 loops;        // 0x4C
        public System.Collections.Generic.List<UnityEngine.Sprite> sprites;        // 0x50
        public System.Boolean endWithPrevious;        // 0x58
        private UnityEngine.Sprite lastSprite;        // 0x60

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Boolean get_isValid() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class AttachObject : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Transform targetObject;        // 0x48
        public System.String childTransformName;        // 0x50
        public UnityEngine.Vector3 localPosition;        // 0x58
        public UnityEngine.Vector3 localRotation;        // 0x64
        public UnityEngine.Vector3 localScale;        // 0x70
        private Slate.TransformSnapshot snapshot;        // 0x80
        private System.Boolean temporary;        // 0x88

        // Methods
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void Do() { }
        private System.Void UnDo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class AttachObjectPrefab : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Transform targetPrefab;        // 0x48
        public System.String childTransformName;        // 0x50
        public UnityEngine.Vector3 localPosition;        // 0x58
        public UnityEngine.Vector3 localRotation;        // 0x64
        public UnityEngine.Vector3 localScale;        // 0x70
        private UnityEngine.Transform instance;        // 0x80
        private Slate.TransformSnapshot snapshot;        // 0x88
        private System.Boolean temporary;        // 0x90

        // Methods
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void Do() { }
        private System.Void UnDo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5
    public class LookAt : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.Boolean verticalOnly;        // 0x4C
        public Slate.EaseType interpolation;        // 0x50
        public Slate.TransformRefPosition targetPosition;        // 0x58
        private UnityEngine.Quaternion wasRotation;        // 0x78

        // Methods
        private UnityEngine.Vector3 get_targetPositionVector() { }
        private System.Void set_targetPositionVector(UnityEngine.Vector3 value) { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6
    public class MatchTransformsToTarget : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.Transform targetObject;        // 0x50
        public Slate.EaseType interpolation;        // 0x58
        public System.Boolean matchPosition;        // 0x5C
        public UnityEngine.Vector3 positionOffset;        // 0x60
        public System.Boolean matchRotation;        // 0x6C
        public UnityEngine.Vector3 rotationOffset;        // 0x70
        public System.Boolean matchScale;        // 0x7C
        public UnityEngine.Vector3 scaleOffset;        // 0x80
        private UnityEngine.Vector3 lastPos;        // 0x8C
        private UnityEngine.Quaternion lastRot;        // 0x98
        private UnityEngine.Vector3 lastScale;        // 0xA8

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_isValid() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class Noise : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.Vector3 seed;        // 0x4C
        public UnityEngine.Vector3 amplitude;        // 0x58
        public System.Single frequency;        // 0x64
        private UnityEngine.Vector3 wasPosition;        // 0x68

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8
    public class RotateAround : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 rotation;        // 0x44
        public System.Boolean perSecond;        // 0x50
        public System.Boolean lookTarget;        // 0x51
        public Slate.EaseType interpolation;        // 0x54
        public Slate.TransformRefPosition targetPosition;        // 0x58
        private UnityEngine.Vector3 wasPosition;        // 0x78
        private UnityEngine.Quaternion wasRotation;        // 0x84
        private UnityEngine.Vector3 targetWasPosition;        // 0x94

        // Methods
        private UnityEngine.Vector3 get_targetPositionVector() { }
        private System.Void set_targetPositionVector(UnityEngine.Vector3 value) { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class RotateBy : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 rotation;        // 0x44
        public System.Boolean perSecond;        // 0x50
        public Slate.EaseType interpolation;        // 0x54
        private UnityEngine.Vector3 originalRot;        // 0x58

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA
    public class RotateTo : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 targetRotation;        // 0x44
        public Slate.EaseType interpolation;        // 0x50
        private UnityEngine.Vector3 originalRot;        // 0x54

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DB
    public class ScaleBy : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 scale;        // 0x44
        public System.Boolean perSecond;        // 0x50
        public Slate.EaseType interpolation;        // 0x54
        private UnityEngine.Vector3 originalScale;        // 0x58

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public class ScaleTo : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 targetScale;        // 0x44
        public Slate.EaseType interpolation;        // 0x50
        private UnityEngine.Vector3 originalPos;        // 0x54

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DD
    public class SetParentTemporary : ActorActionClip
    {
        // Fields
        public System.Single _length;        // 0x40
        public UnityEngine.Transform newParent;        // 0x48
        public System.Boolean matchPosition;        // 0x50
        public System.Boolean matchRotation;        // 0x51
        public System.Boolean matchScale;        // 0x52
        private UnityEngine.Transform originalParent;        // 0x58
        private UnityEngine.Vector3 originalPos;        // 0x60
        private UnityEngine.Quaternion originalRot;        // 0x6C
        private UnityEngine.Vector3 originalScale;        // 0x7C

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class SetTransformParent : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Transform newParent;        // 0x48
        public System.Boolean resetPosition;        // 0x50
        public System.Boolean resetRotation;        // 0x51
        public System.Boolean resetScale;        // 0x52
        private UnityEngine.Transform originalParent;        // 0x58
        private UnityEngine.Vector3 originalPos;        // 0x60
        private UnityEngine.Quaternion originalRot;        // 0x6C
        private UnityEngine.Vector3 originalScale;        // 0x7C
        private System.Boolean temporary;        // 0x88

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void Do() { }
        private System.Void UnDo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DF
    public class SetTransformValues : ActorActionClip
    {
        // Fields
        public Slate.MiniTransformSpace space;        // 0x40
        public System.Boolean setPosition;        // 0x44
        public UnityEngine.Vector3 position;        // 0x48
        public System.Boolean setRotation;        // 0x54
        public UnityEngine.Vector3 rotation;        // 0x58
        public System.Boolean setScale;        // 0x64
        public UnityEngine.Vector3 scale;        // 0x68
        private Slate.TransformSnapshot undo;        // 0x78

        // Methods
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0
    public class SimpleGrounder : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public System.Single maxCheckDistance;        // 0x44
        public System.Single offset;        // 0x48
        private UnityEngine.RaycastHit hit;        // 0x50
        private UnityEngine.Vector3 lastPos;        // 0x90

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E1
    public class TranslateBy : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 translation;        // 0x44
        public System.Boolean perSecond;        // 0x50
        public Slate.EaseType interpolation;        // 0x54
        private UnityEngine.Vector3 originalPos;        // 0x58

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class TranslateTo : ActorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Vector3 targetPosition;        // 0x44
        public Slate.MiniTransformSpace space;        // 0x50
        public Slate.EaseType interpolation;        // 0x54
        private UnityEngine.Vector3 wasPosition;        // 0x58

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E3
    public class AdditiveScene : DirectorActionClip, ISubClipContainable, IDirectable
    {
        // Fields
        private System.Single _length;        // 0x40
        protected System.String _scenePath;        // 0x48
        public UnityEngine.Vector3 scenePosition;        // 0x50
        public UnityEngine.Vector3 sceneRotation;        // 0x5C
        public Slate.MiniTransformSpace space;        // 0x68
        public System.Boolean updateRootCutscenes;        // 0x6C
        public System.Single timeOffset;        // 0x70
        private UnityEngine.SceneManagement.Scene subScene;        // 0x74
        private System.Collections.Generic.List<Slate.Cutscene> rootCutscenes;        // 0x78
        private System.Boolean temporary;        // 0x80
        private System.Boolean waitLoad;        // 0x81

        // Methods
        private System.Single Slate.ISubClipContainable.get_subClipOffset() { }
        private System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value) { }
        private System.Single Slate.ISubClipContainable.get_subClipLength() { }
        private System.Single Slate.ISubClipContainable.get_subClipSpeed() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void Activate() { }
        private System.Void Deactivate() { }
        private System.String CleanPath(System.String path) { }
        private System.Void InitializeSubSceneCutscenes() { }
        private System.Void DenitializeSubSceneCutscenes(System.Boolean forward) { }
        private System.Void .ctor() { }
        private System.String Slate.IDirectable.get_name() { }

    }

    // TypeToken: 0x20000E4
    public class SubCutscene : DirectorActionClip, ISubClipContainable, IDirectable
    {
        // Fields
        private System.Single _length;        // 0x40
        public Slate.Cutscene subCutscene;        // 0x48
        public System.Single subCutsceneTimeOffset;        // 0x50
        private System.Boolean wasCamTrackActive;        // 0x54

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private UnityEngine.GameObject get_actor() { }
        private System.Single Slate.ISubClipContainable.get_subClipOffset() { }
        private System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value) { }
        private System.Single Slate.ISubClipContainable.get_subClipLength() { }
        private System.Single Slate.ISubClipContainable.get_subClipSpeed() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void .ctor() { }
        private System.String Slate.IDirectable.get_name() { }

    }

    // TypeToken: 0x20000E5
    public class DestroyGameObjects : DirectorActionClip
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GameObject> targetObjects;        // 0x40

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E6
    public class DirectorDisableGameObjects : DirectorActionClip
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GameObject> targetObjects;        // 0x40
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> states;        // 0x48

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E7
    public class DirectorEnableGameObjects : DirectorActionClip
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GameObject> targetObjects;        // 0x40
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> states;        // 0x48

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8
    public class InstantiateObject : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.GameObject targetObject;        // 0x50
        public UnityEngine.Transform optionalParent;        // 0x58
        public UnityEngine.Vector3 targetPosition;        // 0x60
        public UnityEngine.Vector3 targetRotation;        // 0x6C
        public Slate.MiniTransformSpace space;        // 0x78
        public Slate.EaseType popupInterpolation;        // 0x7C
        private UnityEngine.GameObject instance;        // 0x80
        private UnityEngine.Vector3 wasScale;        // 0x88

        // Methods
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.String get_info() { }
        private UnityEngine.GameObject get_actor() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E9
    public class SampleParticleSystem : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.ParticleSystem particles;        // 0x48
        public System.Boolean simulationSync;        // 0x50
        private UnityEngine.ParticleSystem.EmissionModule em;        // 0x58

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Boolean get_loop() { }
        private System.Single get_duration() { }
        private System.Single get_startLifetime() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void OnRootEnabled() { }
        private System.Void OnRootDisabled() { }
        private System.Void Play() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void Stop() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EA
    public class TransitAudioMixerSnapshot : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        public UnityEngine.Audio.AudioMixer audioMixer;        // 0x48
        public System.String snapshotName;        // 0x50
        private UnityEngine.Audio.AudioMixerSnapshot snapshot;        // 0x58

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Boolean get_isValid() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnEnter() { }
        private System.Void Do() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB
    public class AnimateAmbientLighting : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.Single ambientIntensity;        // 0x4C
        public UnityEngine.Color ambientColor;        // 0x50
        private System.Single wasIntensity;        // 0x60
        private UnityEngine.Color wasColor;        // 0x64

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EC
    public class AnimateFog : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.Color fogColor;        // 0x4C
        public System.Single fogDensity;        // 0x5C
        public System.Single linearFogStartDistance;        // 0x60
        public System.Single linearFogEndDistance;        // 0x64
        private UnityEngine.Color wasColor;        // 0x68
        private System.Single wasDensity;        // 0x78
        private System.Single wasStartDistance;        // 0x7C
        private System.Single wasEndDistance;        // 0x80

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000ED
    public class AnimateGravity : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.Vector3 gravity;        // 0x4C
        private UnityEngine.Vector3 wasGravity;        // 0x58

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EE
    public class AnimateTimeScale : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.Single timeScale;        // 0x4C
        public Slate.EaseType interpolation;        // 0x50
        private System.Single wasScale;        // 0x54

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF
    public class EasySlowMotion : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.Single timeScale;        // 0x4C
        public Slate.EaseType interpolation;        // 0x50
        private System.Single lastTimeScale;        // 0x54

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F0
    public class RaiseUnityEvent : DirectorActionClip
    {
        // Fields
        public System.String customLabel;        // 0x40
        public UnityEngine.Events.UnityEvent forwardEvent;        // 0x48
        public UnityEngine.Events.UnityEvent reverseEvent;        // 0x50

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F1
    public class SendGlobalMessage`1 : SendGlobalMessage
    {
        // Fields
        public T value;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2
    public class SendGlobalMessage : DirectorActionClip, IEvent
    {
        // Fields
        public System.String message;        // 0x40

        // Methods
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.String Slate.IEvent.get_name() { }
        private System.Void Slate.IEvent.Invoke() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class SendGlobalMessageBoolean : SendGlobalMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4
    public class SendGlobalMessageFloat : SendGlobalMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F5
    public class SendGlobalMessageInteger : SendGlobalMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F6
    public class SendGlobalMessageObject : SendGlobalMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F7
    public class SendGlobalMessageString : SendGlobalMessage`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F8
    public class Captions : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.String text;        // 0x50
        public UnityEngine.Color color;        // 0x58
        public Slate.EaseType interpolation;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F9
    public class CineBox : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FA
    public class OverlayText : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.String text;        // 0x50
        public UnityEngine.TextAnchor anchor;        // 0x58
        public Slate.EaseType interpolation;        // 0x5C
        public UnityEngine.Color color;        // 0x60
        public System.Single size;        // 0x70
        public UnityEngine.Vector2 position;        // 0x74

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB
    public class OverlayTexture : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.Texture texture;        // 0x50
        public UnityEngine.Color color;        // 0x58
        public UnityEngine.Vector2 scale;        // 0x68
        public UnityEngine.Vector2 position;        // 0x70
        public Slate.EaseType interpolation;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC
    public class ScreenFader : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.Single fade;        // 0x4C
        public UnityEngine.Color outColor;        // 0x50
        public Slate.EaseType interpolation;        // 0x60
        private UnityEngine.Color lastColor;        // 0x64

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class AnimatePlaybackSpeed : DirectorActionClip
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public System.Single speed;        // 0x4C
        public Slate.EaseType interpolation;        // 0x50
        private System.Single wasSpeed;        // 0x54

        // Methods
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FE
    public class DebugLog : DirectorActionClip
    {
        // Fields
        public System.Boolean neverSkip;        // 0x40
        public System.String text;        // 0x48

        // Methods
        private System.String get_info() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class PauseCutscene : DirectorActionClip
    {
        // Methods
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000100
    public class ScreenCapture : DirectorActionClip
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000101
    public class PlayAnimationClip : ActorActionClip`1, ISubClipContainable, IDirectable
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public UnityEngine.AnimationClip animationClip;        // 0x58
        public System.Single clipOffset;        // 0x60
        public System.Single playbackSpeed;        // 0x64
        private Slate.TransformSnapshot snapShot;        // 0x68
        private UnityEngine.Transform mixTransform;        // 0x70
        private UnityEngine.AnimationState state;        // 0x78
        private System.Boolean isListClip;        // 0x80

        // Methods
        private System.Single Slate.ISubClipContainable.get_subClipOffset() { }
        private System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value) { }
        private System.Single Slate.ISubClipContainable.get_subClipLength() { }
        private System.Single Slate.ISubClipContainable.get_subClipSpeed() { }
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private Slate.AnimationTrack get_track() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void OnReverseEnter() { }
        private System.Void .ctor() { }
        private System.String Slate.IDirectable.get_name() { }

    }

    // TypeToken: 0x2000102
    public class PlayAnimatorClip : ActorActionClip, ISubClipContainable, IDirectable
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.AnimationClip animationClip;        // 0x50
        public System.Single clipOffset;        // 0x58
        public Slate.ActionClips.PlayAnimatorClip.ClipWrapMode clipWrapMode;        // 0x5C
        public System.Single clipWeight;        // 0x60
        public System.Single playbackSpeed;        // 0x64
        public Slate.ActionClips.PlayAnimatorClip.StartingTransformsMode startingTransformsMode;        // 0x68
        public Slate.MiniTransformSpace transformSpace;        // 0x6C
        public UnityEngine.Vector3 startingPosition;        // 0x70
        public UnityEngine.Vector3 startingRotation;        // 0x7C
        public UnityEngine.Vector2 steerLocalRotation;        // 0x88
        protected UnityEngine.Vector3 wasPosition;        // 0x90
        protected UnityEngine.Quaternion wasRotation;        // 0x9C

        // Methods
        private System.Boolean get_isMasterAndManualSet() { }
        private System.Single Slate.ISubClipContainable.get_subClipOffset() { }
        private System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value) { }
        private System.Single Slate.ISubClipContainable.get_subClipLength() { }
        private System.Single Slate.ISubClipContainable.get_subClipSpeed() { }
        private System.String get_info() { }
        private System.Boolean get_isValid() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_canCrossBlend() { }
        private Slate.AnimatorTrack get_track() { }
        private UnityEngine.Animator get_animator() { }
        private System.Boolean get_isMasterTrack() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }
        private System.String Slate.IDirectable.get_name() { }

    }

    // TypeToken: 0x2000105
    public class PlayAudio : ActionClip, ISubClipContainable, IDirectable
    {
        // Fields
        private System.Single _length;        // 0x40
        private System.Single _blendIn;        // 0x44
        private System.Single _blendOut;        // 0x48
        public UnityEngine.AudioClip audioClip;        // 0x50
        public System.Single volume;        // 0x58
        public System.Single pitch;        // 0x5C
        public System.Single stereoPan;        // 0x60
        public System.Single clipOffset;        // 0x64
        public System.String subtitlesText;        // 0x68
        public UnityEngine.Color subtitlesColor;        // 0x70

        // Methods
        private System.Single Slate.ISubClipContainable.get_subClipOffset() { }
        private System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value) { }
        private System.Single Slate.ISubClipContainable.get_subClipLength() { }
        private System.Single Slate.ISubClipContainable.get_subClipSpeed() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private Slate.AudioTrack get_track() { }
        private UnityEngine.AudioSource get_source() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void Do() { }
        private System.Void OnUpdate(System.Single time, System.Single previousTime) { }
        private System.Void Undo() { }
        private System.Void .ctor() { }
        private System.String Slate.IDirectable.get_name() { }

    }

    // TypeToken: 0x2000106
    public class AnimateBoolParameter : MecanimBaseClip
    {
        // Fields
        private System.Single _length;        // 0x48
        public System.String parameterName;        // 0x50
        public System.Boolean value;        // 0x58
        private System.Boolean lastValue;        // 0x59

        // Methods
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void OnExit() { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000107
    public class AnimateFloatParameter : MecanimBaseClip
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.String parameterName;        // 0x58
        public System.Single value;        // 0x60
        private System.Single lastValue;        // 0x64

        // Methods
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000108
    public class AnimateIntegerParameter : MecanimBaseClip
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.String parameterName;        // 0x58
        public System.Int32 value;        // 0x60
        private System.Int32 lastValue;        // 0x64

        // Methods
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000109
    public class AnimateLayerWeight : MecanimBaseClip
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.Int32 layerIndex;        // 0x54
        public System.Single weight;        // 0x58
        private System.Single lastValue;        // 0x5C

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate(System.Single deltaTime) { }
        private System.Void OnReverse() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010A
    public class AnimateLimbIK : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public UnityEngine.AvatarIKGoal IKGoal;        // 0x54
        public System.Single weight;        // 0x58
        public Slate.TransformRefPositionRotation IKTarget;        // 0x60
        private Slate.AnimatorDispatcher dispatcher;        // 0x90

        // Methods
        private UnityEngine.Vector3 get_targetPosition() { }
        private System.Void set_targetPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_targetRotation() { }
        private System.Void set_targetRotation(UnityEngine.Vector3 value) { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void OnRootDisabled() { }
        private System.Void OnAnimatorIK(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010C
    public class AnimateLookAtIK : ActorActionClip`1
    {
        // Fields
        private System.Single _length;        // 0x48
        private System.Single _blendIn;        // 0x4C
        private System.Single _blendOut;        // 0x50
        public System.Single weight;        // 0x54
        public System.Single bodyWeight;        // 0x58
        public System.Single headWeight;        // 0x5C
        public System.Single eyesWeight;        // 0x60
        public Slate.TransformRefPosition targetPosition;        // 0x68
        private Slate.AnimatorDispatcher dispatcher;        // 0x88

        // Methods
        private UnityEngine.Vector3 get_targetPositionVector() { }
        private System.Void set_targetPositionVector(UnityEngine.Vector3 value) { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void set_blendIn(System.Single value) { }
        private System.Single get_blendOut() { }
        private System.Void set_blendOut(System.Single value) { }
        private System.Void OnCreate() { }
        private System.Void OnAfterValidate() { }
        private System.Void OnEnter() { }
        private System.Void OnReverseEnter() { }
        private System.Void OnReverse() { }
        private System.Void OnExit() { }
        private System.Void OnRootDisabled() { }
        private System.Void OnAnimatorIK(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010E
    public class AnimateTrigger : MecanimBaseClip
    {
        // Fields
        private System.Single _length;        // 0x48
        public System.String triggerName;        // 0x50
        public System.Boolean value;        // 0x58

        // Methods
        private System.Boolean get_isValid() { }
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Void OnUpdate(System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010F
    public class CrossFadeState : MecanimBaseClip
    {
        // Fields
        private System.Single _length;        // 0x48
        public System.String stateName;        // 0x50

        // Methods
        private System.String get_info() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_blendIn() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000110
    public class MecanimBaseClip : ActorActionClip`1
    {
        // Methods
        private System.Boolean get_isValid() { }
        private System.Boolean HasParameter(System.String name) { }
        private System.Void .ctor() { }

    }

}

