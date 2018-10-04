using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CSceneSwitcher : MonoBehaviour {

    [SerializeField]
    private CKeyBoardConfig _keyConfig = null;

    [SerializeField]
    private Text _sceneNameText = null;

    public string changeSceneName = "ScriptableObjectTest";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(_keyConfig.sceneChange))
        {
            AsyncOperation ao = SceneManager.LoadSceneAsync(changeSceneName, LoadSceneMode.Single);
        }
	}

    private void OnEnable()
    {
        if (_sceneNameText != null)
        {
            _sceneNameText.text = SceneManager.GetActiveScene().name;
        }
    }
}
