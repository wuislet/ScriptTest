/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestReflection.cs
   ScriptTest
   
   Created by WuIslet on 2019-03-15.
   
*************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestReflection : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestReflection <<< ");

            Program.Main();
        }


    }


    class Program
    {
        string name = "strA";
        string strA = "strB";
        string strB = "Hello World~";

        public static void Main()
        {
            string test = "wxd";
            //TODO 怎么打印test的变量名？

            Program p = new Program();
            p.GetTypeValue();

            p.GetStrValue(p.name);

            p.SetStrValue(p.strA);
        }
        //本文原址：http://www.cnblogs.com/Interkey/p/3460566.html

        /// <summary>
        /// 获取所有FieldInfo的值
        /// </summary>
        void GetTypeValue()
        {
            DebugPrint.p("Method: GetTypeValue");
            FieldInfo[] fis = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo fi in fis)
            {
                DebugPrint.p(fi.Name + " 的值为：" + fi.GetValue(this).ToString());
            }
        }

        /// <summary>
        /// 获取字符串str对应的变量名的变量值对应的变量值
        /// </summary>
        /// <param name="str"></param>
        void GetStrValue(string str)
        {
            DebugPrint.p("Method: GetStrValue");
            Type type = this.GetType();

            //获取字符串str对应的变量名的变量值
            DebugPrint.p(type.GetField(str, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this).ToString());

            DebugPrint.p(
                type.GetField(
                    type.GetField(str, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this).ToString(),
                    BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this).ToString()
            );
        }

        /// <summary>
        /// 设置字符串str对应的变量名的变量值
        /// </summary>
        /// <param name="str"></param>
        void SetStrValue(string str)
        {
            DebugPrint.p("Method: SetStrValue");

            //赋值前输出
            DebugPrint.p(this.GetType().GetField(str, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this));

            //进行赋值操作
            this.GetType().GetField(str, BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(this, "Hello Interkey~");

            //赋值后输出
            DebugPrint.p(this.GetType().GetField(str, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this));
        }

        //本文原址：http://www.cnblogs.com/Interkey/p/3460566.html
    }
}