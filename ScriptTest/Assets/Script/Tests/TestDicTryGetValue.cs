/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestDicTryGetValue.cs
   ScriptTest
   
   Created by WuIslet on 2020-02-26.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestDicTryGetValue : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestDicTryGetValue <<< ");
            Dictionary<int, bool> a = new Dictionary<int, bool>();
            a.Add(1, false);
            a.Add(2, false);
            a.Add(3, false);

            bool b = false;
            if (a.TryGetValue(2, out b))
            {
                b = true;
            }

            DebugPrint.p(" >>> 2 <<< ");

            DebugPrint.p(a[2]);
            Dictionary<int, List<bool>> a2 = new Dictionary<int, List<bool>>();
            a2.Add(1, new List<bool>() { false });
            a2.Add(2, new List<bool>() { false });
            a2.Add(3, new List<bool>() {false});

            List<bool> b2 = null;
            if (a2.TryGetValue(2, out b2))
            {
                b2[0] = true;
            }

            DebugPrint.p(a2[2][0]);
        }
    }
}
