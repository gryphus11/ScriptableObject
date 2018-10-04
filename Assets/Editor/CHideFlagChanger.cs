using UnityEditor;
using UnityEngine;

public class CHideFlagChanger
{
    [MenuItem("Assets/Set to HideFlags.None")]
    private static void ChangeHideFlagNone()
    {
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        Object[] objects = AssetDatabase.LoadAllAssetsAtPath(path);

        foreach (Object obj in objects)
        {
            obj.hideFlags = HideFlags.None;
        }

        AssetDatabase.ImportAsset(path);
    }

    [MenuItem("Assets/Set to HideFlags.HideInHierarchy")]
    private static void ChangeHideFlagHideInHierarchy()
    {
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        Object[] objects = AssetDatabase.LoadAllAssetsAtPath(path);

        foreach (Object obj in objects)
        {
            obj.hideFlags = HideFlags.HideInHierarchy;
        }

        AssetDatabase.ImportAsset(path);
    }

    [MenuItem("Assets/Set to HideFlags.HideInInspector")]
    private static void ChangeHideFlagHideInInspector()
    {
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        Object[] objects = AssetDatabase.LoadAllAssetsAtPath(path);

        foreach (Object obj in objects)
        {
            obj.hideFlags = HideFlags.HideInInspector;
        }

        AssetDatabase.ImportAsset(path);
    }
}
