using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CClickCountUpdaterLink : MonoBehaviour
{
    [SerializeField]
    private CCountScriptableObject _clickCounter = null;

    private Text _label = null;

    private static StringBuilder _builder = new StringBuilder(3); 

    private void Awake()
    {
        _label = GetComponent<Text>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _builder.Length = 0;
        if (_clickCounter != null)
        {
            _builder.AppendFormat("{0:D3}", _clickCounter.count);
        }
        _label.text = _builder.ToString();
    }
}
