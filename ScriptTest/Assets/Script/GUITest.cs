/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   GUITest.cs
   ScriptTest
   
   Created by WuIslet on 2019-08-29.
   
*************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class GUITest : MonoBehaviour
    {
        public int LoopTime = 1000000;
        public string StrArg = "";
        public int IntArg = 0;
        public float FloatArg = 0;
        public GameObject ObjArg = null;

        [NonSerialized] public Color TestColor;

        void OnGUI()
        {
            Stopwatch sw = new Stopwatch();
            if (GUILayout.Button("EmptyTest"))
            {
                sw.Start();
                for (int i = 0; i < LoopTime; ++i)
                {
                    EmptyTest();
                }
                sw.Stop();
                DebugPrint.p("     > EmptyTest <  Time:   " + sw.Elapsed.TotalSeconds);
            }

            if (GUILayout.Button("Test1"))
            {
                sw.Start();
                for (int i = 0; i < LoopTime; ++i)
                {
                    Test1();
                }
                sw.Stop();
                DebugPrint.p("     > Test1 <  Time:   " + sw.Elapsed.TotalSeconds);
            }

            if (GUILayout.Button("Test2"))
            {
                sw.Start();
                for (int i = 0; i < LoopTime; ++i)
                {
                    Test2();
                }
                sw.Stop();
                DebugPrint.p("     > Test2 <  Time:   " + sw.Elapsed.TotalSeconds);
            }

            if (GUILayout.Button("Quick Test"))
            {
                DebugPrint.p(">>>>>>>>>>> " + TestColor + ", " + Color.black + ", " + Color.clear + ", " + default(Color));
            }
        }

        public void EmptyTest()
        {
            if (ObjArg != null)
            {

            }
        }

        public void Test1()
        {
            if (ObjArg != null)
            {
                if (ObjArg.name == "TestName")
                {
                    
                }
            }
        }

        public void Test2()
        {
            if (ObjArg != null)
            {
                if (ObjArg.CompareTag("TestTag"))
                {

                }
            }
        }
    }
}
