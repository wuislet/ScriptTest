/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestIEnumerator.cs
   ScriptTest
   
   Created by WuIslet on 2018-12-10.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestIEnumerator : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestIEnumerator <<< ");
            DebugPrint.p(1);
            StartCoroutine("fun1");
            DebugPrint.p(666);
        }

        IEnumerator fun1()
        {
            DebugPrint.p(2);
            yield return fun2();
            DebugPrint.p(5);
            yield return StartCoroutine("fun3");
            DebugPrint.p(8);
            StartCoroutine("fun4");
            DebugPrint.p(10);
            fun5();
        }

        IEnumerator fun2()
        {
            DebugPrint.p(3);
            yield return 0;
            DebugPrint.p(4);
        }
        IEnumerator fun3()
        {
            DebugPrint.p(6);
            yield return 0;
            DebugPrint.p(7);
        }

        IEnumerator fun4()
        {
            DebugPrint.p(9);
            yield return 0;
            DebugPrint.p(12);
        }

        void fun5()
        {
            DebugPrint.p(11);
        }
    }
}