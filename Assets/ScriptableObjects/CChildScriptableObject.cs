using UnityEditor;
using UnityEngine;

public class CChildScriptableObject : ScriptableObject
{
    public string childString = string.Empty;

    private const string PATH = "Assets/SampleAssets/ChildScriptableObject.asset";

    [MenuItem("Sample/Create Child Scriptable Object")]
    private static void CreateScriptableObject()
    {
        CChildScriptableObject child = ScriptableObject.CreateInstance<CChildScriptableObject>();

        AssetDatabase.CreateAsset(child, PATH);
        AssetDatabase.ImportAsset(PATH);
    }
}
