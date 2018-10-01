using UnityEditor;
using UnityEngine;

public class CSampleScriptableObject : ScriptableObject
{
    [SerializeField]
    private string _context = string.Empty;

    [SerializeField, Range(5, 100)]
    private int _line = 100;

    [Range (0.0f, 100.0f)]
    public float progress = 0.0f;

    [MenuItem("Sample/Create SampleAsset")]
    private static void CreateSampleAsset()
    {
        CSampleScriptableObject sampleAsset = CreateInstance<CSampleScriptableObject>();

        AssetDatabase.CreateAsset(sampleAsset, "Assets/SampleAssets/SampleAsset.asset");
        AssetDatabase.Refresh();
    }

    [MenuItem("Sample/Load SampleAsset")]
    private static void LoadSampleAsset()
    {
        CSampleScriptableObject sampleAsset = AssetDatabase.
            LoadAssetAtPath<CSampleScriptableObject>("Assets/SampleAssets/SampleAsset.asset");

        Debug.Log(sampleAsset._line);
    }
}
