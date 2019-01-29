using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

namespace isletspace
{
    public class TemplateCreation
    {
        [MenuItem("Assets/Create Script/Test Script", false, 0)]
        public static void CreateTestScript()
        {
            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0,
                ScriptableObject.CreateInstance<EndNameEdit>(),
                GetSelectPath() + "/Test.cs", null,
                "Assets/Editor/Template/TestScriptTemplate.txt");
        }

        private static string GetSelectPath()
        {
            string path = "Assets";
            foreach (UnityEngine.Object obj in Selection.GetFiltered(typeof(UnityEngine.Object), SelectionMode.Assets))
            {
                path = AssetDatabase.GetAssetPath(obj);
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    path = Path.GetDirectoryName(path);
                    break;
                }
            }
            return path;
        }
    }

    public class EndNameEdit : EndNameEditAction
    {
        public override void Action(int instanceId, string pathName, string resourceFile)
        {
            UnityEngine.Object obj = CreateScriptAssetFromTemplate(pathName, resourceFile);
            ProjectWindowUtil.ShowCreatedAsset(obj);
        }

        internal static UnityEngine.Object CreateScriptAssetFromTemplate(string pathName, string resourceFile)
        {
            try
            {
                string fullPath = Path.GetFullPath(pathName);
                StreamReader streamReader = new StreamReader(resourceFile);
                string text = streamReader.ReadToEnd();
                streamReader.Close();

                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathName);
                text = Regex.Replace(text, "#SCRIPTNAME#", fileNameWithoutExtension);

                bool append = false;
                StreamWriter streamWriter = new StreamWriter(fullPath, append, Encoding.ASCII);
                streamWriter.Write(text);
                streamWriter.Close();
                AssetDatabase.ImportAsset(pathName);
                AssetDatabase.Refresh();
                return AssetDatabase.LoadAssetAtPath(pathName, typeof(UnityEngine.Object));
            }
            catch (FileNotFoundException)
            {
                UnityEngine.Debug.LogError("Create Script Error ----> Could not find file " +  resourceFile);
                return null;
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError("Create Script Error ----> " + e.Message);
                return null;
            }
        }
    }

}