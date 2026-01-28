// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.DirectorModule.dll
// Classes:  2
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.Playables.PlayableDirector
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Behaviour
FIELDS:
  private           System.Action<UnityEngine.Playables.PlayableDirector>played  // 0x18
  private           System.Action<UnityEngine.Playables.PlayableDirector>paused  // 0x20
  private           System.Action<UnityEngine.Playables.PlayableDirector>stopped  // 0x28
METHODS:
  UnityEngine.Playables.PlayState get_state()
  System.Void set_extrapolationMode(UnityEngine.Playables.DirectorWrapMode value)
  UnityEngine.Playables.DirectorWrapMode get_extrapolationMode()
  UnityEngine.Playables.PlayableAsset get_playableAsset()
  System.Void set_playableAsset(UnityEngine.Playables.PlayableAsset value)
  UnityEngine.Playables.PlayableGraph get_playableGraph()
  System.Boolean get_playOnAwake()
  System.Void set_playOnAwake(System.Boolean value)
  System.Void DeferredEvaluate()
  System.Void Play(UnityEngine.Playables.FrameRate frameRate)
  System.Void Play(UnityEngine.Playables.PlayableAsset asset)
  System.Void Play(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.DirectorWrapMode mode)
  System.Void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value)
  System.Void set_timeUpdateMode(UnityEngine.Playables.DirectorUpdateMode value)
  UnityEngine.Playables.DirectorUpdateMode get_timeUpdateMode()
  System.Void set_time(System.Double value)
  System.Double get_time()
  System.Void set_initialTime(System.Double value)
  System.Double get_initialTime()
  System.Double get_duration()
  System.Void Evaluate()
  System.Void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate)
  System.Void Play()
  System.Void Stop()
  System.Void Pause()
  System.Void Resume()
  System.Void RebuildGraph()
  System.Void ClearReferenceValue(UnityEngine.PropertyName id)
  System.Void SetReferenceValue(UnityEngine.PropertyName id, UnityEngine.Object value)
  UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, System.Boolean& idValid)
  UnityEngine.Object GetGenericBinding(UnityEngine.Object key)
  System.Void ClearGenericBinding(UnityEngine.Object key)
  System.Void RebindPlayableGraphOutputs()
  System.Void ProcessPendingGraphChanges()
  System.Boolean HasGenericBinding(UnityEngine.Object key)
  UnityEngine.Playables.PlayState GetPlayState()
  System.Void SetWrapMode(UnityEngine.Playables.DirectorWrapMode mode)
  UnityEngine.Playables.DirectorWrapMode GetWrapMode()
  System.Void EvaluateNextFrame()
  UnityEngine.Playables.PlayableGraph GetGraphHandle()
  System.Void SetPlayOnAwake(System.Boolean on)
  System.Boolean GetPlayOnAwake()
  System.Void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value)
  System.Void SetPlayableAsset(UnityEngine.ScriptableObject asset)
  UnityEngine.ScriptableObject Internal_GetPlayableAsset()
  System.Void add_played(System.Action<UnityEngine.Playables.PlayableDirector> value)
  System.Void remove_played(System.Action<UnityEngine.Playables.PlayableDirector> value)
  System.Void add_paused(System.Action<UnityEngine.Playables.PlayableDirector> value)
  System.Void remove_paused(System.Action<UnityEngine.Playables.PlayableDirector> value)
  System.Void add_stopped(System.Action<UnityEngine.Playables.PlayableDirector> value)
  System.Void remove_stopped(System.Action<UnityEngine.Playables.PlayableDirector> value)
  System.Void ResetFrameTiming()
  System.Void SendOnPlayableDirectorPlay()
  System.Void SendOnPlayableDirectorPause()
  System.Void SendOnPlayableDirectorStop()
  System.Void .ctor()
  System.Void PlayOnFrame_Injected(UnityEngine.Playables.FrameRate& frameRate)
  System.Void ClearReferenceValue_Injected(UnityEngine.PropertyName& id)
  System.Void SetReferenceValue_Injected(UnityEngine.PropertyName& id, UnityEngine.Object value)
  UnityEngine.Object GetReferenceValue_Injected(UnityEngine.PropertyName& id, System.Boolean& idValid)
  System.Void GetGraphHandle_Injected(UnityEngine.Playables.PlayableGraph& ret)
END_CLASS

