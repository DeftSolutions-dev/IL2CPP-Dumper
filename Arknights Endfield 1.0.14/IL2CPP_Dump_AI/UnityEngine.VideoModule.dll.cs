// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VideoModule.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: EventHandler
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Video.VideoPlayer source)
END_CLASS

CLASS: ErrorEventHandler
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.String message)
END_CLASS

CLASS: FrameReadyEventHandler
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx)
END_CLASS

CLASS: TimeEventHandler
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Double seconds)
END_CLASS

CLASS: UnityEngine.Experimental.Video.VideoClipPlayable
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean Equals(UnityEngine.Experimental.Video.VideoClipPlayable other)
END_CLASS

CLASS: UnityEngine.Video.VideoClip
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  System.Void .ctor()
  System.String get_originalPath()
  System.UInt64 get_frameCount()
  System.Double get_frameRate()
  System.Double get_length()
  System.UInt32 get_width()
  System.UInt32 get_height()
  System.UInt32 get_pixelAspectRatioNumerator()
  System.UInt32 get_pixelAspectRatioDenominator()
  System.Boolean get_sRGB()
  System.UInt16 get_audioTrackCount()
  System.UInt16 GetAudioChannelCount(System.UInt16 audioTrackIdx)
  System.UInt32 GetAudioSampleRate(System.UInt16 audioTrackIdx)
  System.String GetAudioLanguage(System.UInt16 audioTrackIdx)
END_CLASS

CLASS: UnityEngine.Video.VideoRenderMode
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoRenderModeCameraFarPlane  // 0x0
  public    static  UnityEngine.Video.VideoRenderModeCameraNearPlane  // 0x0
  public    static  UnityEngine.Video.VideoRenderModeRenderTexture  // 0x0
  public    static  UnityEngine.Video.VideoRenderModeMaterialOverride  // 0x0
  public    static  UnityEngine.Video.VideoRenderModeAPIOnly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.Video3DLayout
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.Video3DLayout No3D  // 0x0
  public    static  UnityEngine.Video.Video3DLayout SideBySide3D  // 0x0
  public    static  UnityEngine.Video.Video3DLayout OverUnder3D  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoAspectRatio
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoAspectRatioNoScaling  // 0x0
  public    static  UnityEngine.Video.VideoAspectRatioFitVertically  // 0x0
  public    static  UnityEngine.Video.VideoAspectRatioFitHorizontally  // 0x0
  public    static  UnityEngine.Video.VideoAspectRatioFitInside  // 0x0
  public    static  UnityEngine.Video.VideoAspectRatioFitOutside  // 0x0
  public    static  UnityEngine.Video.VideoAspectRatioStretch  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoTimeSource
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoTimeSourceAudioDSPTimeSource  // 0x0
  public    static  UnityEngine.Video.VideoTimeSourceGameTimeSource  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoTimeReference
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoTimeReferenceFreerun  // 0x0
  public    static  UnityEngine.Video.VideoTimeReferenceInternalTime  // 0x0
  public    static  UnityEngine.Video.VideoTimeReferenceExternalTime  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoSource
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoSource   VideoClip  // 0x0
  public    static  UnityEngine.Video.VideoSource   Url  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoAudioOutputMode
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoAudioOutputModeNone  // 0x0
  public    static  UnityEngine.Video.VideoAudioOutputModeAudioSource  // 0x0
  public    static  UnityEngine.Video.VideoAudioOutputModeDirect  // 0x0
  public    static  UnityEngine.Video.VideoAudioOutputModeAPIOnly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoPlayer
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Behaviour
FIELDS:
  private           UnityEngine.Video.VideoPlayer.EventHandlerprepareCompleted  // 0x18
  private           UnityEngine.Video.VideoPlayer.EventHandlerloopPointReached  // 0x20
  private           UnityEngine.Video.VideoPlayer.EventHandlerstarted  // 0x28
  private           UnityEngine.Video.VideoPlayer.EventHandlerframeDropped  // 0x30
  private           UnityEngine.Video.VideoPlayer.ErrorEventHandlererrorReceived  // 0x38
  private           UnityEngine.Video.VideoPlayer.EventHandlerseekCompleted  // 0x40
  private           UnityEngine.Video.VideoPlayer.TimeEventHandlerclockResyncOccurred  // 0x48
  private           UnityEngine.Video.VideoPlayer.FrameReadyEventHandlerframeReady  // 0x50
METHODS:
  UnityEngine.Video.VideoSource get_source()
  System.Void set_source(UnityEngine.Video.VideoSource value)
  System.String get_url()
  System.Void set_url(System.String value)
  UnityEngine.Video.VideoClip get_clip()
  System.Void set_clip(UnityEngine.Video.VideoClip value)
  UnityEngine.Video.VideoRenderMode get_renderMode()
  System.Void set_renderMode(UnityEngine.Video.VideoRenderMode value)
  UnityEngine.Camera get_targetCamera()
  System.Void set_targetCamera(UnityEngine.Camera value)
  UnityEngine.RenderTexture get_targetTexture()
  System.Void set_targetTexture(UnityEngine.RenderTexture value)
  UnityEngine.Renderer get_targetMaterialRenderer()
  System.Void set_targetMaterialRenderer(UnityEngine.Renderer value)
  System.String get_targetMaterialProperty()
  System.Void set_targetMaterialProperty(System.String value)
  UnityEngine.Video.VideoAspectRatio get_aspectRatio()
  System.Void set_aspectRatio(UnityEngine.Video.VideoAspectRatio value)
  System.Single get_targetCameraAlpha()
  System.Void set_targetCameraAlpha(System.Single value)
  UnityEngine.Video.Video3DLayout get_targetCamera3DLayout()
  System.Void set_targetCamera3DLayout(UnityEngine.Video.Video3DLayout value)
  UnityEngine.Texture get_texture()
  System.Void Prepare()
  System.Boolean get_isPrepared()
  System.Boolean get_waitForFirstFrame()
  System.Void set_waitForFirstFrame(System.Boolean value)
  System.Boolean get_playOnAwake()
  System.Void set_playOnAwake(System.Boolean value)
  System.Void Play()
  System.Void Pause()
  System.Void Stop()
  System.Boolean get_isPlaying()
  System.Boolean get_isPaused()
  System.Boolean get_canSetTime()
  System.Double get_time()
  System.Void set_time(System.Double value)
  System.Int64 get_frame()
  System.Void set_frame(System.Int64 value)
  System.Double get_clockTime()
  System.Boolean get_canStep()
  System.Void StepForward()
  System.Boolean get_canSetPlaybackSpeed()
  System.Single get_playbackSpeed()
  System.Void set_playbackSpeed(System.Single value)
  System.Boolean get_isLooping()
  System.Void set_isLooping(System.Boolean value)
  System.Boolean get_canSetTimeSource()
  UnityEngine.Video.VideoTimeSource get_timeSource()
  System.Void set_timeSource(UnityEngine.Video.VideoTimeSource value)
  UnityEngine.Video.VideoTimeReference get_timeReference()
  System.Void set_timeReference(UnityEngine.Video.VideoTimeReference value)
  System.Double get_externalReferenceTime()
  System.Void set_externalReferenceTime(System.Double value)
  System.Boolean get_canSetSkipOnDrop()
  System.Boolean get_skipOnDrop()
  System.Void set_skipOnDrop(System.Boolean value)
  System.UInt64 get_frameCount()
  System.Single get_frameRate()
  System.Double get_length()
  System.UInt32 get_width()
  System.UInt32 get_height()
  System.UInt32 get_pixelAspectRatioNumerator()
  System.UInt32 get_pixelAspectRatioDenominator()
  System.UInt16 get_audioTrackCount()
  System.String GetAudioLanguageCode(System.UInt16 trackIndex)
  System.UInt16 GetAudioChannelCount(System.UInt16 trackIndex)
  System.UInt32 GetAudioSampleRate(System.UInt16 trackIndex)
  System.UInt16 get_controlledAudioTrackMaxCount()
  System.UInt16 get_controlledAudioTrackCount()
  System.Void set_controlledAudioTrackCount(System.UInt16 value)
  System.UInt16 GetControlledAudioTrackCount()
  System.Void SetControlledAudioTrackCount(System.UInt16 value)
  System.Void EnableAudioTrack(System.UInt16 trackIndex, System.Boolean enabled)
  System.Boolean IsAudioTrackEnabled(System.UInt16 trackIndex)
  UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode()
  System.Void set_audioOutputMode(UnityEngine.Video.VideoAudioOutputMode value)
  System.Boolean get_canSetDirectAudioVolume()
  System.Single GetDirectAudioVolume(System.UInt16 trackIndex)
  System.Void SetDirectAudioVolume(System.UInt16 trackIndex, System.Single volume)
  System.Boolean GetDirectAudioMute(System.UInt16 trackIndex)
  System.Void SetDirectAudioMute(System.UInt16 trackIndex, System.Boolean mute)
  UnityEngine.AudioSource GetTargetAudioSource(System.UInt16 trackIndex)
  System.Void SetTargetAudioSource(System.UInt16 trackIndex, UnityEngine.AudioSource source)
  System.Void add_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void remove_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void add_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void remove_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void add_started(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void remove_started(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void add_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void remove_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void add_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value)
  System.Void remove_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value)
  System.Void add_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void remove_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value)
  System.Void add_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value)
  System.Void remove_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value)
  System.Boolean get_sendFrameReadyEvents()
  System.Void set_sendFrameReadyEvents(System.Boolean value)
  System.Void add_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value)
  System.Void remove_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value)
  System.Void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  System.Void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx)
  System.Void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  System.Void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  System.Void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  System.Void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, System.String errorStr)
  System.Void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  System.Void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Double seconds)
  System.Void .ctor()
END_CLASS

