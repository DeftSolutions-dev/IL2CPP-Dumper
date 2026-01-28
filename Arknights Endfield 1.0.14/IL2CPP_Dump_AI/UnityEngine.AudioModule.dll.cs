// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AudioModule.dll
// Classes:  19
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: AudioConfigurationChangeHandler
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Boolean deviceWasChanged)
END_CLASS

CLASS: PCMReaderCallback
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Single[] data)
END_CLASS

CLASS: PCMSetPositionCallback
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Int32 position)
END_CLASS

CLASS: SampleFramesHandler
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, System.UInt32 sampleFrameCount)
END_CLASS

CLASS: UnityEngine.AudioSettings
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  UnityEngine.AudioSettings.AudioConfigurationChangeHandlerOnAudioConfigurationChanged  // 0x0
  private   static  System.Action                   OnAudioSystemShuttingDown  // 0x8
  private   static  System.Action                   OnAudioSystemStartedUp  // 0x10
METHODS:
  System.Void InvokeOnAudioConfigurationChanged(System.Boolean deviceWasChanged)
  System.Void InvokeOnAudioSystemShuttingDown()
  System.Void InvokeOnAudioSystemStartedUp()
END_CLASS

CLASS: UnityEngine.AudioClip
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           UnityEngine.AudioClip.PCMReaderCallbackm_PCMReaderCallback  // 0x18
  private           UnityEngine.AudioClip.PCMSetPositionCallbackm_PCMSetPositionCallback  // 0x20
METHODS:
  System.Single get_length()
  System.Int32 get_samples()
  System.Int32 get_frequency()
  System.Void InvokePCMReaderCallback_Internal(System.Single[] data)
  System.Void InvokePCMSetPositionCallback_Internal(System.Int32 position)
END_CLASS

CLASS: UnityEngine.AudioBehaviour
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Behaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AudioListener
TYPE:  class
TOKEN: 0x2000008
EXTENDS: AudioBehaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AudioSource
TYPE:  class
TOKEN: 0x2000009
EXTENDS: AudioBehaviour
FIELDS:
METHODS:
  System.Void SetPitch(UnityEngine.AudioSource source, System.Single pitch)
  System.Void PlayHelper(UnityEngine.AudioSource source, System.UInt64 delay)
  System.Void PlayOneShotHelper(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single volumeScale)
  System.Void Stop(System.Boolean stopOneShots)
  System.Void set_volume(System.Single value)
  System.Void set_pitch(System.Single value)
  System.Single get_time()
  System.Void set_time(System.Single value)
  System.Void set_clip(UnityEngine.AudioClip value)
  System.Void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value)
  System.Void Play()
  System.Void PlayOneShot(UnityEngine.AudioClip clip, System.Single volumeScale)
  System.Void Stop()
  System.Boolean get_isPlaying()
  System.Void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position, System.Single volume)
  System.Void set_playOnAwake(System.Boolean value)
  System.Void set_panStereo(System.Single value)
  System.Void set_spatialBlend(System.Single value)
  System.Void set_bypassReverbZones(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Audio.AudioClipPlayable
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Audio.AudioClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, System.Boolean looping)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, System.Boolean looping)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioClipPlayable playable)
  UnityEngine.Audio.AudioClipPlayable op_Explicit(UnityEngine.Playables.Playable playable)
  System.Boolean Equals(UnityEngine.Audio.AudioClipPlayable other)
  System.Void SetVolume(System.Single value)
  System.Void SetStereoPan(System.Single value)
  System.Void SetSpatialBlend(System.Single value)
  System.Void Seek(System.Double startTime, System.Double startDelay, System.Double duration)
  System.Void SetVolumeInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single volume)
  System.Void SetStereoPanInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single stereoPan)
  System.Void SetSpatialBlendInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single spatialBlend)
  System.Void SetStartDelayInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Double delay)
  System.Void SetPauseDelayInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Double delay)
  System.Boolean InternalCreateAudioClipPlayable(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AudioClip clip, System.Boolean looping, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Audio.AudioMixer
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Void .ctor()
  UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(System.String name)
  System.Void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, System.Single timeToReach)
  System.Void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, System.Single timeToReach)
END_CLASS

CLASS: UnityEngine.Audio.AudioMixerGroup
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Audio.AudioMixerPlayable
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Audio.AudioMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeInputVolumes)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeInputVolumes)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioMixerPlayable playable)
  System.Boolean Equals(UnityEngine.Audio.AudioMixerPlayable other)
  System.Boolean CreateAudioMixerPlayableInternal(UnityEngine.Playables.PlayableGraph& graph, System.Boolean normalizeInputVolumes, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Audio.AudioMixerSnapshot
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Void .ctor()
  UnityEngine.Audio.AudioMixer get_audioMixer()
  System.Void TransitionTo(System.Single timeToReach)
END_CLASS

CLASS: UnityEngine.Audio.AudioPlayableBinding
TYPE:  class
TOKEN: 0x200000F
FIELDS:
METHODS:
  UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key)
  UnityEngine.Playables.PlayableOutput CreateAudioOutput(UnityEngine.Playables.PlayableGraph graph, System.String name)
END_CLASS

CLASS: UnityEngine.Audio.AudioPlayableGraphExtensions
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Boolean InternalCreateAudioOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle)
END_CLASS

CLASS: UnityEngine.Audio.AudioPlayableOutput
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           UnityEngine.Playables.PlayableOutputHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Audio.AudioPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.AudioSource target)
  System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle)
  UnityEngine.Audio.AudioPlayableOutput get_Null()
  UnityEngine.Playables.PlayableOutputHandle GetHandle()
  UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Audio.AudioPlayableOutput output)
  UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output)
  System.Void SetTarget(UnityEngine.AudioSource value)
  System.Void SetEvaluateOnSeek(System.Boolean value)
  System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.AudioSource target)
  System.Void InternalSetEvaluateOnSeek(UnityEngine.Playables.PlayableOutputHandle& output, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Experimental.Audio.AudioSampleProvider
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private           UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandlersampleFramesAvailable  // 0x10
  private           UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandlersampleFramesOverflow  // 0x18
METHODS:
  System.Void InvokeSampleFramesAvailable(System.Int32 sampleFrameCount)
  System.Void InvokeSampleFramesOverflow(System.Int32 droppedSampleFrameCount)
END_CLASS

