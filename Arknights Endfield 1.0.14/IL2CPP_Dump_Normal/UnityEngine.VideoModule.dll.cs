// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VideoModule.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000C
    public class EventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Video.VideoPlayer source) { }

    }

    // TypeToken: 0x200000D
    public class ErrorEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.String message) { }

    }

    // TypeToken: 0x200000E
    public class FrameReadyEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx) { }

    }

    // TypeToken: 0x200000F
    public class TimeEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Double seconds) { }

    }

namespace UnityEngine.Experimental.Video
{

    // TypeToken: 0x2000002
    public struct VideoClipPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean Equals(UnityEngine.Experimental.Video.VideoClipPlayable other) { }

    }

}

namespace UnityEngine.Video
{

    // TypeToken: 0x2000003
    public class VideoClip
    {
        // Methods
        private System.Void .ctor() { }
        private System.String get_originalPath() { }
        private System.UInt64 get_frameCount() { }
        private System.Double get_frameRate() { }
        private System.Double get_length() { }
        private System.UInt32 get_width() { }
        private System.UInt32 get_height() { }
        private System.UInt32 get_pixelAspectRatioNumerator() { }
        private System.UInt32 get_pixelAspectRatioDenominator() { }
        private System.Boolean get_sRGB() { }
        private System.UInt16 get_audioTrackCount() { }
        private System.UInt16 GetAudioChannelCount(System.UInt16 audioTrackIdx) { }
        private System.UInt32 GetAudioSampleRate(System.UInt16 audioTrackIdx) { }
        private System.String GetAudioLanguage(System.UInt16 audioTrackIdx) { }

    }

    // TypeToken: 0x2000004
    public struct VideoRenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.VideoRenderMode CameraFarPlane;        // 0x0
        public static UnityEngine.Video.VideoRenderMode CameraNearPlane;        // 0x0
        public static UnityEngine.Video.VideoRenderMode RenderTexture;        // 0x0
        public static UnityEngine.Video.VideoRenderMode MaterialOverride;        // 0x0
        public static UnityEngine.Video.VideoRenderMode APIOnly;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct Video3DLayout
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.Video3DLayout No3D;        // 0x0
        public static UnityEngine.Video.Video3DLayout SideBySide3D;        // 0x0
        public static UnityEngine.Video.Video3DLayout OverUnder3D;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct VideoAspectRatio
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.VideoAspectRatio NoScaling;        // 0x0
        public static UnityEngine.Video.VideoAspectRatio FitVertically;        // 0x0
        public static UnityEngine.Video.VideoAspectRatio FitHorizontally;        // 0x0
        public static UnityEngine.Video.VideoAspectRatio FitInside;        // 0x0
        public static UnityEngine.Video.VideoAspectRatio FitOutside;        // 0x0
        public static UnityEngine.Video.VideoAspectRatio Stretch;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct VideoTimeSource
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.VideoTimeSource AudioDSPTimeSource;        // 0x0
        public static UnityEngine.Video.VideoTimeSource GameTimeSource;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct VideoTimeReference
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.VideoTimeReference Freerun;        // 0x0
        public static UnityEngine.Video.VideoTimeReference InternalTime;        // 0x0
        public static UnityEngine.Video.VideoTimeReference ExternalTime;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct VideoSource
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.VideoSource VideoClip;        // 0x0
        public static UnityEngine.Video.VideoSource Url;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct VideoAudioOutputMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Video.VideoAudioOutputMode None;        // 0x0
        public static UnityEngine.Video.VideoAudioOutputMode AudioSource;        // 0x0
        public static UnityEngine.Video.VideoAudioOutputMode Direct;        // 0x0
        public static UnityEngine.Video.VideoAudioOutputMode APIOnly;        // 0x0

    }

    // TypeToken: 0x200000B
    public class VideoPlayer : Behaviour
    {
        // Fields
        private UnityEngine.Video.VideoPlayer.EventHandler prepareCompleted;        // 0x18
        private UnityEngine.Video.VideoPlayer.EventHandler loopPointReached;        // 0x20
        private UnityEngine.Video.VideoPlayer.EventHandler started;        // 0x28
        private UnityEngine.Video.VideoPlayer.EventHandler frameDropped;        // 0x30
        private UnityEngine.Video.VideoPlayer.ErrorEventHandler errorReceived;        // 0x38
        private UnityEngine.Video.VideoPlayer.EventHandler seekCompleted;        // 0x40
        private UnityEngine.Video.VideoPlayer.TimeEventHandler clockResyncOccurred;        // 0x48
        private UnityEngine.Video.VideoPlayer.FrameReadyEventHandler frameReady;        // 0x50

        // Methods
        private UnityEngine.Video.VideoSource get_source() { }
        private System.Void set_source(UnityEngine.Video.VideoSource value) { }
        private System.String get_url() { }
        private System.Void set_url(System.String value) { }
        private UnityEngine.Video.VideoClip get_clip() { }
        private System.Void set_clip(UnityEngine.Video.VideoClip value) { }
        private UnityEngine.Video.VideoRenderMode get_renderMode() { }
        private System.Void set_renderMode(UnityEngine.Video.VideoRenderMode value) { }
        private UnityEngine.Camera get_targetCamera() { }
        private System.Void set_targetCamera(UnityEngine.Camera value) { }
        private UnityEngine.RenderTexture get_targetTexture() { }
        private System.Void set_targetTexture(UnityEngine.RenderTexture value) { }
        private UnityEngine.Renderer get_targetMaterialRenderer() { }
        private System.Void set_targetMaterialRenderer(UnityEngine.Renderer value) { }
        private System.String get_targetMaterialProperty() { }
        private System.Void set_targetMaterialProperty(System.String value) { }
        private UnityEngine.Video.VideoAspectRatio get_aspectRatio() { }
        private System.Void set_aspectRatio(UnityEngine.Video.VideoAspectRatio value) { }
        private System.Single get_targetCameraAlpha() { }
        private System.Void set_targetCameraAlpha(System.Single value) { }
        private UnityEngine.Video.Video3DLayout get_targetCamera3DLayout() { }
        private System.Void set_targetCamera3DLayout(UnityEngine.Video.Video3DLayout value) { }
        private UnityEngine.Texture get_texture() { }
        private System.Void Prepare() { }
        private System.Boolean get_isPrepared() { }
        private System.Boolean get_waitForFirstFrame() { }
        private System.Void set_waitForFirstFrame(System.Boolean value) { }
        private System.Boolean get_playOnAwake() { }
        private System.Void set_playOnAwake(System.Boolean value) { }
        private System.Void Play() { }
        private System.Void Pause() { }
        private System.Void Stop() { }
        private System.Boolean get_isPlaying() { }
        private System.Boolean get_isPaused() { }
        private System.Boolean get_canSetTime() { }
        private System.Double get_time() { }
        private System.Void set_time(System.Double value) { }
        private System.Int64 get_frame() { }
        private System.Void set_frame(System.Int64 value) { }
        private System.Double get_clockTime() { }
        private System.Boolean get_canStep() { }
        private System.Void StepForward() { }
        private System.Boolean get_canSetPlaybackSpeed() { }
        private System.Single get_playbackSpeed() { }
        private System.Void set_playbackSpeed(System.Single value) { }
        private System.Boolean get_isLooping() { }
        private System.Void set_isLooping(System.Boolean value) { }
        private System.Boolean get_canSetTimeSource() { }
        private UnityEngine.Video.VideoTimeSource get_timeSource() { }
        private System.Void set_timeSource(UnityEngine.Video.VideoTimeSource value) { }
        private UnityEngine.Video.VideoTimeReference get_timeReference() { }
        private System.Void set_timeReference(UnityEngine.Video.VideoTimeReference value) { }
        private System.Double get_externalReferenceTime() { }
        private System.Void set_externalReferenceTime(System.Double value) { }
        private System.Boolean get_canSetSkipOnDrop() { }
        private System.Boolean get_skipOnDrop() { }
        private System.Void set_skipOnDrop(System.Boolean value) { }
        private System.UInt64 get_frameCount() { }
        private System.Single get_frameRate() { }
        private System.Double get_length() { }
        private System.UInt32 get_width() { }
        private System.UInt32 get_height() { }
        private System.UInt32 get_pixelAspectRatioNumerator() { }
        private System.UInt32 get_pixelAspectRatioDenominator() { }
        private System.UInt16 get_audioTrackCount() { }
        private System.String GetAudioLanguageCode(System.UInt16 trackIndex) { }
        private System.UInt16 GetAudioChannelCount(System.UInt16 trackIndex) { }
        private System.UInt32 GetAudioSampleRate(System.UInt16 trackIndex) { }
        private System.UInt16 get_controlledAudioTrackMaxCount() { }
        private System.UInt16 get_controlledAudioTrackCount() { }
        private System.Void set_controlledAudioTrackCount(System.UInt16 value) { }
        private System.UInt16 GetControlledAudioTrackCount() { }
        private System.Void SetControlledAudioTrackCount(System.UInt16 value) { }
        private System.Void EnableAudioTrack(System.UInt16 trackIndex, System.Boolean enabled) { }
        private System.Boolean IsAudioTrackEnabled(System.UInt16 trackIndex) { }
        private UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode() { }
        private System.Void set_audioOutputMode(UnityEngine.Video.VideoAudioOutputMode value) { }
        private System.Boolean get_canSetDirectAudioVolume() { }
        private System.Single GetDirectAudioVolume(System.UInt16 trackIndex) { }
        private System.Void SetDirectAudioVolume(System.UInt16 trackIndex, System.Single volume) { }
        private System.Boolean GetDirectAudioMute(System.UInt16 trackIndex) { }
        private System.Void SetDirectAudioMute(System.UInt16 trackIndex, System.Boolean mute) { }
        private UnityEngine.AudioSource GetTargetAudioSource(System.UInt16 trackIndex) { }
        private System.Void SetTargetAudioSource(System.UInt16 trackIndex, UnityEngine.AudioSource source) { }
        private System.Void add_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void remove_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void add_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void remove_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void add_started(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void remove_started(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void add_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void remove_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void add_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value) { }
        private System.Void remove_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value) { }
        private System.Void add_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void remove_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value) { }
        private System.Void add_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value) { }
        private System.Void remove_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value) { }
        private System.Boolean get_sendFrameReadyEvents() { }
        private System.Void set_sendFrameReadyEvents(System.Boolean value) { }
        private System.Void add_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value) { }
        private System.Void remove_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value) { }
        private System.Void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        private System.Void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx) { }
        private System.Void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        private System.Void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        private System.Void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        private System.Void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, System.String errorStr) { }
        private System.Void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        private System.Void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Double seconds) { }
        private System.Void .ctor() { }

    }

}

