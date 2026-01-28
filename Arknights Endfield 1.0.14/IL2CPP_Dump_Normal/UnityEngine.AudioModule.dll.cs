// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AudioModule.dll
// Classes:  19
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public class AudioConfigurationChangeHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Boolean deviceWasChanged) { }

    }

    // TypeToken: 0x2000005
    public class PCMReaderCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Single[] data) { }

    }

    // TypeToken: 0x2000006
    public class PCMSetPositionCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Int32 position) { }

    }

    // TypeToken: 0x2000013
    public class SampleFramesHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, System.UInt32 sampleFrameCount) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class AudioSettings
    {
        // Fields
        private static UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;        // 0x0
        private static System.Action OnAudioSystemShuttingDown;        // 0x8
        private static System.Action OnAudioSystemStartedUp;        // 0x10

        // Methods
        private System.Void InvokeOnAudioConfigurationChanged(System.Boolean deviceWasChanged) { }
        private System.Void InvokeOnAudioSystemShuttingDown() { }
        private System.Void InvokeOnAudioSystemStartedUp() { }

    }

    // TypeToken: 0x2000004
    public class AudioClip
    {
        // Fields
        private UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;        // 0x18
        private UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;        // 0x20

        // Methods
        private System.Single get_length() { }
        private System.Int32 get_samples() { }
        private System.Int32 get_frequency() { }
        private System.Void InvokePCMReaderCallback_Internal(System.Single[] data) { }
        private System.Void InvokePCMSetPositionCallback_Internal(System.Int32 position) { }

    }

    // TypeToken: 0x2000007
    public class AudioBehaviour : Behaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class AudioListener : AudioBehaviour
    {
    }

    // TypeToken: 0x2000009
    public class AudioSource : AudioBehaviour
    {
        // Methods
        private System.Void SetPitch(UnityEngine.AudioSource source, System.Single pitch) { }
        private System.Void PlayHelper(UnityEngine.AudioSource source, System.UInt64 delay) { }
        private System.Void PlayOneShotHelper(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single volumeScale) { }
        private System.Void Stop(System.Boolean stopOneShots) { }
        private System.Void set_volume(System.Single value) { }
        private System.Void set_pitch(System.Single value) { }
        private System.Single get_time() { }
        private System.Void set_time(System.Single value) { }
        private System.Void set_clip(UnityEngine.AudioClip value) { }
        private System.Void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value) { }
        private System.Void Play() { }
        private System.Void PlayOneShot(UnityEngine.AudioClip clip, System.Single volumeScale) { }
        private System.Void Stop() { }
        private System.Boolean get_isPlaying() { }
        private System.Void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position, System.Single volume) { }
        private System.Void set_playOnAwake(System.Boolean value) { }
        private System.Void set_panStereo(System.Single value) { }
        private System.Void set_spatialBlend(System.Single value) { }
        private System.Void set_bypassReverbZones(System.Boolean value) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Audio
{

    // TypeToken: 0x200000A
    public struct AudioClipPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Audio.AudioClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, System.Boolean looping) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, System.Boolean looping) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioClipPlayable playable) { }
        private UnityEngine.Audio.AudioClipPlayable op_Explicit(UnityEngine.Playables.Playable playable) { }
        private System.Boolean Equals(UnityEngine.Audio.AudioClipPlayable other) { }
        private System.Void SetVolume(System.Single value) { }
        private System.Void SetStereoPan(System.Single value) { }
        private System.Void SetSpatialBlend(System.Single value) { }
        private System.Void Seek(System.Double startTime, System.Double startDelay, System.Double duration) { }
        private System.Void SetVolumeInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single volume) { }
        private System.Void SetStereoPanInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single stereoPan) { }
        private System.Void SetSpatialBlendInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single spatialBlend) { }
        private System.Void SetStartDelayInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Double delay) { }
        private System.Void SetPauseDelayInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Double delay) { }
        private System.Boolean InternalCreateAudioClipPlayable(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AudioClip clip, System.Boolean looping, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200000B
    public class AudioMixer
    {
        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(System.String name) { }
        private System.Void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, System.Single timeToReach) { }
        private System.Void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, System.Single timeToReach) { }

    }

    // TypeToken: 0x200000C
    public class AudioMixerGroup
    {
    }

    // TypeToken: 0x200000D
    public struct AudioMixerPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Audio.AudioMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeInputVolumes) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeInputVolumes) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioMixerPlayable playable) { }
        private System.Boolean Equals(UnityEngine.Audio.AudioMixerPlayable other) { }
        private System.Boolean CreateAudioMixerPlayableInternal(UnityEngine.Playables.PlayableGraph& graph, System.Boolean normalizeInputVolumes, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200000E
    public class AudioMixerSnapshot
    {
        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Audio.AudioMixer get_audioMixer() { }
        private System.Void TransitionTo(System.Single timeToReach) { }

    }

    // TypeToken: 0x200000F
    public class AudioPlayableBinding
    {
        // Methods
        private UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key) { }
        private UnityEngine.Playables.PlayableOutput CreateAudioOutput(UnityEngine.Playables.PlayableGraph graph, System.String name) { }

    }

    // TypeToken: 0x2000010
    public class AudioPlayableGraphExtensions
    {
        // Methods
        private System.Boolean InternalCreateAudioOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle) { }

    }

    // TypeToken: 0x2000011
    public struct AudioPlayableOutput, IPlayableOutput
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Audio.AudioPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.AudioSource target) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle) { }
        private UnityEngine.Audio.AudioPlayableOutput get_Null() { }
        private UnityEngine.Playables.PlayableOutputHandle GetHandle() { }
        private UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Audio.AudioPlayableOutput output) { }
        private UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output) { }
        private System.Void SetTarget(UnityEngine.AudioSource value) { }
        private System.Void SetEvaluateOnSeek(System.Boolean value) { }
        private System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.AudioSource target) { }
        private System.Void InternalSetEvaluateOnSeek(UnityEngine.Playables.PlayableOutputHandle& output, System.Boolean value) { }

    }

}

namespace UnityEngine.Experimental.Audio
{

    // TypeToken: 0x2000012
    public class AudioSampleProvider
    {
        // Fields
        private UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;        // 0x10
        private UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;        // 0x18

        // Methods
        private System.Void InvokeSampleFramesAvailable(System.Int32 sampleFrameCount) { }
        private System.Void InvokeSampleFramesOverflow(System.Int32 droppedSampleFrameCount) { }

    }

}

