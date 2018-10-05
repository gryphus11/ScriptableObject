using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CClickCountAdd : MonoBehaviour
{
    [SerializeField]
    private CCountScriptableObject _counter = null;

    public void OnAddButtonClick()
    {
        if (_counter != null)
        {
            _counter.Add();
        }
    }
}
