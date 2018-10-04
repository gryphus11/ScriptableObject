using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataManager", menuName = "ScriptableObjects/Create DataManager")]
public class CDataManager : ScriptableObject
{
    public float progress = 35.0f;

    private void OnEnable()
    {
        Debug.Log("Manager Called");
    }

    private void OnDisable()
    {
        Debug.Log("Manager Disabled");
    }
}
