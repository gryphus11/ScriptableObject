using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CClickSceneChange : MonoBehaviour
{
    [SerializeField]
    private Text _sceneNameText = null;

    private void OnEnable()
    {
        if (_sceneNameText != null)
        {
            _sceneNameText.text = SceneManager.GetActiveScene().name;
        }
    }

    public void OnSceneChangeButtonClick(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}
