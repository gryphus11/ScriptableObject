using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataManager", menuName = "ScriptableObjects/Create DataManager")]
public class CDataManager : CResettableScriptableObject
{
    public float progress = 35.0f;

    protected override void OnEnable()
    {
        base.OnEnable();
        Debug.Log("Manager Called");
    }

    private void OnDisable()
    {
        Debug.Log("Manager Disabled");
    }
}
