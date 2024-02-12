using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
namespace DefaultNamespace.ProjectData
{
    public class ProjectDataPostProcessing : AssetPostprocessor
    {
        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            foreach (string str in importedAssets)
            {
                //　IndexOfの引数は"/(読み込ませたいファイル名)"とする。
                if (str.IndexOf("/projects.csv") != -1)
                {
                    Debug.Log("CSVファイルがあった!!!");
                    //　Asset直下から読み込む（Resourcesではないので注意）
                    TextAsset textasset = AssetDatabase.LoadAssetAtPath<TextAsset>(str);
                    //　同名のScriptableObjectファイルを読み込む。ない場合は新たに作る。
                    string assetfile = str.Replace(".csv", ".asset");
                    ProjectDataSettings cd = AssetDatabase.LoadAssetAtPath<ProjectDataSettings>(assetfile);
                    if (cd == null){
                        cd = new ProjectDataSettings();
                        AssetDatabase.CreateAsset(cd, assetfile);
                    }

                    cd.DataList = CSVSerializer.Deserialize<ProjectData>(textasset.text);
                    EditorUtility.SetDirty(cd);
                    AssetDatabase.SaveAssets();
                }
            }
        }
    }
}
#endif