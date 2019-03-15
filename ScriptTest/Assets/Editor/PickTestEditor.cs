/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   PickTestEditor.cs
   ScriptTest
   
   Created by WuIslet on 2019-03-14.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    [CustomEditor(typeof(PickTest))]
    public class PickTestEditor : Editor
    {
        private int Index;
        private int Max;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            PickTest data = target as PickTest;
            var childs = data.transform.GetComponentsInChildren<ITestScript>();
            List<string> selects = new List<string>();
            for (int i = 0; i < childs.Length; i++)
            {
                var testScript = childs[i];
                selects.Add(i + ": " + testScript.GetType().Name);
            }

            if (Max != selects.Count)
            {
                Max = selects.Count;
                Index = Max - 1;
            }

            Index = EditorGUILayout.Popup("Select Code To Test", Index, selects.ToArray());
            data.script = childs[Index];
        }
    }
}
