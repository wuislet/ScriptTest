/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestInvoke.cs
   ScriptTest
   
   Created by WuIslet on 2019-01-07.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestInvoke : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestInvoke <<< ");
            Invoke("foo", 1);
        }

        public void foo(int bar = 3)
        {
            //int bar = 4;
            DebugPrint.p("  foo  :  " + bar);
        }
    }
}
