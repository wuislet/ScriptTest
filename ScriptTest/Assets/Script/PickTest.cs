/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   PickTest.cs
   ScriptTest
   
   Created by WuIslet on 2019-01-05.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class PickTest : MonoBehaviour
    {
        public ITestScript script;

        public void DoTest()
        {
            if (script != null)
                script.StartTest();
            else
                DebugPrint.p("  ！！！ No Test Find ！！！  ");
        }
    }
}
