/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   ButtonClick.cs
   ScriptTest
   
   Created by WuIslet on 2018-12-10.
   
*************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class ButtonClick : MonoBehaviour
    {
        public PickTest script;

        void Awake()
        {
            GetComponent<Button>().onClick.AddListener(OnClick);
        }

        public void OnClick()
        {
            DebugPrint.p("============== button click ==============");
            script.DoTest();
            DebugPrint.p("============== test end ==============");
        }
    }
}
