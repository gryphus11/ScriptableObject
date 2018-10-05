using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Assets/Resources/Counter", menuName = "ScriptableObjects/Create Counter")]
public class CCountScriptableObject : CResettableScriptableObject
{
    public int count = 0;

    protected override void OnEnable()
    {
        base.OnEnable();
        hideFlags = HideFlags.DontUnloadUnusedAsset;
    }

    public void Add()
    {
        ++count;
    }

    public void ReleaseAsset()
    {
        Resources.UnloadAsset(this);
    }
}
