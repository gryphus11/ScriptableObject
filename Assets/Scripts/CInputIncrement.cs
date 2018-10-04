using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CInputIncrement : MonoBehaviour
{

    [SerializeField]
    private CDataManager _dataManager = null;

    [SerializeField]
    private Text _dataText = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_dataManager != null)
            {
                _dataManager.progress += Time.deltaTime;

                if (_dataManager.progress == 100.0f)
                {
                    _dataManager.progress = 0.0f;
                }
            }
        }

        if (_dataText != null)
        {
            _dataText.text = _dataManager.progress.ToString();
        }
    }
}
