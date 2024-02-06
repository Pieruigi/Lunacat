using Lunacat.Scriptables;
using UnityEditor;
using UnityEngine;

public class AssetBuilder
{

    static string resourceBaseFolder = "Assets/Resources";

    [MenuItem("Assets/Create/Scriptables/BuildableAsset")]
    public static void CreateBuildableAsset()
    {
        BuildableAsset asset = ScriptableObject.CreateInstance<BuildableAsset>();

        string name = "Buildable.asset";

        string folder = System.IO.Path.Combine(resourceBaseFolder, BuildableAsset.ResourceFolder);

        if (!System.IO.Directory.Exists(folder))
            System.IO.Directory.CreateDirectory(folder);

        AssetDatabase.CreateAsset(asset, System.IO.Path.Combine(folder, name));

        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

}
