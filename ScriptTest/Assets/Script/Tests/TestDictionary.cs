/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestDictionary.cs
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
    public class TestDictionary : MonoBehaviour, ITestScript
    {
        Dictionary<string, string> dic = new Dictionary<string, string>(); 

        public void StartTest()
        {
            DebugPrint.p(" >>> TestDictionary <<< ");

            dic.Add("11", "22");
            dic.Add("11", "33");
            DebugPrint.p(dic["11"]);
        }
    }
}
