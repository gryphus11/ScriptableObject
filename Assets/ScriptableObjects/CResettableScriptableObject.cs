using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CResettableScriptableObject : ScriptableObject
{
#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void CallBeforePlayScene()
    {
        // 플레이 전에 SaveProject 를 추천합니다.
        //UnityEditor.AssetDatabase.SaveAssets();
    }
#endif
    protected virtual void OnEnable()
    {
#if UNITY_EDITOR
        if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode == true)
        {
            UnityEditor.EditorApplication.playModeStateChanged += x =>
            {
                if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode == false)
                {
                    Debug.Log("Play Mode : " + x);
                    Resources.UnloadAsset(this);
                }
            };
        }
#endif
    }
}
