/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   DebugPrint.cs
   ScriptTest
   
   Created by WuIslet on 2018-12-10.
   
*************************************************************/

using System;
using System.Collections.Generic;
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
        public static void p(object obj)
        {
            if (obj == null)
                obj = "null";
            printer(obj);
        }

        public static void pp(object obj)
        {
            var str = (obj == null) ? "null" : obj.ToString();
            var type = obj.GetType();
            printer(str);
        }

        public static void pl<T>(T[] list)
        {
            printer("========================= print list.  len: " + list.Length);
            for (int i = 0; i < list.Length; ++i)
            {
                printer("    >> for  " + i + " : " + list[i].ToString());
            }
            printer("========================= end ");
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
