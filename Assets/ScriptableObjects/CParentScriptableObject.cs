using UnityEngine;

public class CParentScriptableObject : ScriptableObject
{
    public CChildScriptableObject childScriptableObject = null;

    public float progress = 35.0f;

    public string name = "SJH";

    private const string PATH = "Assets/SampleAssets/ParentScriptableObject.asset";
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Sample/Create Parent Scriptable Object")]
    private static void CreateScriptableObject()
    {
        CParentScriptableObject parent = ScriptableObject.CreateInstance<CParentScriptableObject>();
        parent.childScriptableObject = ScriptableObject.CreateInstance<CChildScriptableObject>();

        parent.childScriptableObject.name = "new Child";
        parent.childScriptableObject.hideFlags = HideFlags.HideInHierarchy;

        UnityEditor.AssetDatabase.AddObjectToAsset(parent.childScriptableObject, PATH);
        UnityEditor.AssetDatabase.CreateAsset(parent, PATH);
        UnityEditor.AssetDatabase.ImportAsset(PATH);
    }

    [UnityEditor.MenuItem("Sample/Remove Child Scriptable Object")]
    private static void RemoveChildScriptableObject()
    {
        CParentScriptableObject parent = UnityEditor.AssetDatabase.LoadAssetAtPath<CParentScriptableObject>(PATH);

        Object.DestroyImmediate(parent.childScriptableObject, true);

        parent.childScriptableObject = null;

        UnityEditor.AssetDatabase.ImportAsset(PATH);
    }
#endif
}
