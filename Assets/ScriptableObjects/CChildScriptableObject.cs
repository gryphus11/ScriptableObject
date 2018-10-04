using UnityEngine;

public class CChildScriptableObject : ScriptableObject
{
    public string childString = string.Empty;

    private const string PATH = "Assets/SampleAssets/ChildScriptableObject.asset";

#if UNITY_EDITOR
    [UnityEditor.MenuItem("Sample/Create Child Scriptable Object")]
    private static void CreateScriptableObject()
    {
        CChildScriptableObject child = ScriptableObject.CreateInstance<CChildScriptableObject>();

        UnityEditor.AssetDatabase.CreateAsset(child, PATH);
        UnityEditor.AssetDatabase.ImportAsset(PATH);
    }
#endif
}
