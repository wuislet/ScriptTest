/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestPrintAnything.cs
   ScriptTest
   
   Created by WuIslet on 2018-12-10.
   
*************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestPrintAnything : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestPrintAnything <<< ");
            TimeSpan ts = new TimeSpan(0, 0, 0, 10000);
            DateTime time = DateTime.Now.ToLocalTime();
            DebugPrint.p(time.ToString());
            var foo = warplog(this.foo);
            foo();

            string[] lst = new string[3];
            DebugPrint.p(lst.Length);
            lst[1] = "1234";
            lst[4] = "wxd";
            foreach (var s in lst)
            {
                DebugPrint.p(s);
            }
            DebugPrint.p(lst.Length);
        }

        public void foo()
        {
            DebugPrint.p("foo");
        }

        public Action warplog(Action foo)
        {
            return () => { DebugPrint.p("start log"); foo(); DebugPrint.p("end log"); };
        } 
    }
}
