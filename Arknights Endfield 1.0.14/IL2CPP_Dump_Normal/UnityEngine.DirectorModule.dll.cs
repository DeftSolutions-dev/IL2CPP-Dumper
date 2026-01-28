// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.DirectorModule.dll
// Classes:  2
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine.Playables
{

    // TypeToken: 0x2000002
    public class PlayableDirector : Behaviour, IExposedPropertyTable
    {
        // Fields
        private System.Action<UnityEngine.Playables.PlayableDirector> played;        // 0x18
        private System.Action<UnityEngine.Playables.PlayableDirector> paused;        // 0x20
        private System.Action<UnityEngine.Playables.PlayableDirector> stopped;        // 0x28

        // Methods
        private UnityEngine.Playables.PlayState get_state() { }
        private System.Void set_extrapolationMode(UnityEngine.Playables.DirectorWrapMode value) { }
        private UnityEngine.Playables.DirectorWrapMode get_extrapolationMode() { }
        private UnityEngine.Playables.PlayableAsset get_playableAsset() { }
        private System.Void set_playableAsset(UnityEngine.Playables.PlayableAsset value) { }
        private UnityEngine.Playables.PlayableGraph get_playableGraph() { }
        private System.Boolean get_playOnAwake() { }
        private System.Void set_playOnAwake(System.Boolean value) { }
        private System.Void DeferredEvaluate() { }
        private System.Void Play(UnityEngine.Playables.FrameRate frameRate) { }
        private System.Void Play(UnityEngine.Playables.PlayableAsset asset) { }
        private System.Void Play(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.DirectorWrapMode mode) { }
        private System.Void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) { }
        private System.Void set_timeUpdateMode(UnityEngine.Playables.DirectorUpdateMode value) { }
        private UnityEngine.Playables.DirectorUpdateMode get_timeUpdateMode() { }
        private System.Void set_time(System.Double value) { }
        private System.Double get_time() { }
        private System.Void set_initialTime(System.Double value) { }
        private System.Double get_initialTime() { }
        private System.Double get_duration() { }
        private System.Void Evaluate() { }
        private System.Void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate) { }
        private System.Void Play() { }
        private System.Void Stop() { }
        private System.Void Pause() { }
        private System.Void Resume() { }
        private System.Void RebuildGraph() { }
        private System.Void ClearReferenceValue(UnityEngine.PropertyName id) { }
        private System.Void SetReferenceValue(UnityEngine.PropertyName id, UnityEngine.Object value) { }
        private UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, System.Boolean& idValid) { }
        private UnityEngine.Object GetGenericBinding(UnityEngine.Object key) { }
        private System.Void ClearGenericBinding(UnityEngine.Object key) { }
        private System.Void RebindPlayableGraphOutputs() { }
        private System.Void ProcessPendingGraphChanges() { }
        private System.Boolean HasGenericBinding(UnityEngine.Object key) { }
        private UnityEngine.Playables.PlayState GetPlayState() { }
        private System.Void SetWrapMode(UnityEngine.Playables.DirectorWrapMode mode) { }
        private UnityEngine.Playables.DirectorWrapMode GetWrapMode() { }
        private System.Void EvaluateNextFrame() { }
        private UnityEngine.Playables.PlayableGraph GetGraphHandle() { }
        private System.Void SetPlayOnAwake(System.Boolean on) { }
        private System.Boolean GetPlayOnAwake() { }
        private System.Void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) { }
        private System.Void SetPlayableAsset(UnityEngine.ScriptableObject asset) { }
        private UnityEngine.ScriptableObject Internal_GetPlayableAsset() { }
        private System.Void add_played(System.Action<UnityEngine.Playables.PlayableDirector> value) { }
        private System.Void remove_played(System.Action<UnityEngine.Playables.PlayableDirector> value) { }
        private System.Void add_paused(System.Action<UnityEngine.Playables.PlayableDirector> value) { }
        private System.Void remove_paused(System.Action<UnityEngine.Playables.PlayableDirector> value) { }
        private System.Void add_stopped(System.Action<UnityEngine.Playables.PlayableDirector> value) { }
        private System.Void remove_stopped(System.Action<UnityEngine.Playables.PlayableDirector> value) { }
        private System.Void ResetFrameTiming() { }
        private System.Void SendOnPlayableDirectorPlay() { }
        private System.Void SendOnPlayableDirectorPause() { }
        private System.Void SendOnPlayableDirectorStop() { }
        private System.Void .ctor() { }
        private System.Void PlayOnFrame_Injected(UnityEngine.Playables.FrameRate& frameRate) { }
        private System.Void ClearReferenceValue_Injected(UnityEngine.PropertyName& id) { }
        private System.Void SetReferenceValue_Injected(UnityEngine.PropertyName& id, UnityEngine.Object value) { }
        private UnityEngine.Object GetReferenceValue_Injected(UnityEngine.PropertyName& id, System.Boolean& idValid) { }
        private System.Void GetGraphHandle_Injected(UnityEngine.Playables.PlayableGraph& ret) { }

    }

}

