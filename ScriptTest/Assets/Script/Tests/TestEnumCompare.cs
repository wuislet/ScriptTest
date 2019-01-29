/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestEnumCompare.cs
   ScriptTest
   
   Created by WuIslet on 2019-01-29.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestEnumCompare : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestEnumCompare <<< ");
            var num1 = Foo.one;
            var num2 = Foo.one;
            var num3 = Foo.five;
            var num4 = Foo.three;
            DebugPrint.p("   ==   " + (num1 == num2));
            DebugPrint.p("   >    " + (num3 > num2));
            DebugPrint.p("   <    " + (num4 > num3));
            DebugPrint.p("  compare ==  " + (num1.CompareTo(num2)));
            DebugPrint.p("  compare >   " + (num3.CompareTo(num2)));
            DebugPrint.p("  compare <   " + (num4.CompareTo(num3)));
            DebugPrint.p("  compareInt ==  " + (((int)num1).CompareTo((int)num2)));
            DebugPrint.p("  compareInt >   " + (((int)num3).CompareTo((int)num2)));
            DebugPrint.p("  compareInt <   " + (((int)num4).CompareTo((int)num3)));
        }
    }

    public enum Foo
    {
        one = 1,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
    }
}
