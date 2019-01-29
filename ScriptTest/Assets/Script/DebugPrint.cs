/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   DebugPrint.cs
   ScriptTest
   
   Created by WuIslet on 2018-12-10.
   
*************************************************************/

using System;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public static class DebugPrint
    {
        public static bool isEnable = true;
        private static Action<object> printer = UnityPrinter;

        #region basePrint
        public static void p(object str)
        {
            if (str == null)
            {
                str = "null";
            }
            printer(str);
        }

        public static void pp(object obj)
        {
            
        }

        public static void pl()
        {

        }
        #endregion

        #region printer
        public static void UnityPrinter(object str)
        {
            if (!isEnable) return;
            UnityEngine.Debug.Log(str.ToString());
        }

        public static void UnityGuiPrinter(object str)
        {
            if (!isEnable) return;
            GUILayout.Label(str.ToString());
        }

        public static void FilePrinter(object str)
        {
            if (!isEnable) return;
        }

        public static void ServerLogPrinter(object str)
        {
            if (!isEnable) return;
        }
        #endregion

        #region printerOperator
        public static void SetPrintPlan(Action<object> foo)
        {
            printer = foo;
        }

        public static void AddPrintPlan(Action<object> foo)
        {
            printer += foo;
        }

        public static void RemovePrintPlan(Action<object> foo)
        {
            try
            {
                printer -= foo;
            }
            catch {}
        }
        #endregion

        public static void DebugModeInit()
        {
            isEnable = Debug.isDebugBuild;
        }
    }
}
