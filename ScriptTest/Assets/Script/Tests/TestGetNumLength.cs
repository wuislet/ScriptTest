/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestGetNumLength.cs
   ScriptTest
   
   Created by WuIslet on 2019-03-06.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestGetNumLength : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            int time = 10000000;
            List<int> tmp = new List<int>();
            DebugPrint.p(" >>> GetNumLength <<< ");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < time; ++i)
            {
                var l = GetLengthWithString(i);
                tmp.Add(l);
            }
            sw.Stop();
            DebugPrint.p("     String  Time:   " + sw.Elapsed.TotalSeconds);
            
            sw.Reset();
            sw.Start();
            for (int i = 0; i < time; ++i)
            {
                var l = GetLengthWithMath(i);
                tmp.Add(l);
            }
            sw.Stop();
            DebugPrint.p("     Math  Time:   " + sw.Elapsed.TotalSeconds);

            sw.Reset();
            sw.Start();
            for (int i = 0; i < time; ++i)
            {
                var l = X2Math.GetIntLength2(i);
                tmp.Add(l);
            }
            sw.Stop();
            DebugPrint.p("     X2  Time:   " + sw.Elapsed.TotalSeconds);

            sw.Reset();
            sw.Start();
            for (int i = 0; i < time; ++i)
            {
                var l = (int)Mathf.Pow(i % 10, i % 10);
                tmp.Add(l);
            }
            sw.Stop();
            DebugPrint.p("     Math Pow:   " + sw.Elapsed.TotalSeconds);

            sw.Reset();
            sw.Start();
            for (int i = 0; i < time; ++i)
            {
                var l = FastPow(i % 10, i % 10);
                tmp.Add(l);
            }
            sw.Stop();
            DebugPrint.p("     Fast Pow:   " + sw.Elapsed.TotalSeconds);

            sw.Reset();
            sw.Start();
            for (int i = 0; i < time; ++i)
            {
                var l = FastPow2(i % 10, i % 10);
                tmp.Add(l);
            }
            sw.Stop();
            DebugPrint.p("     Fast Pow 2:   " + sw.Elapsed.TotalSeconds);

            DebugPrint.p("   -------------- >   test print  " + FastPow2(7, 6));
        }

        public int GetLengthWithString(int num)
        {
            return num.ToString().Length;
        }

        public int GetLengthWithMath(int num)
        {
            if (num < 1)
                return 0;
            return (int)Mathf.Pow(10, (int)Mathf.Log10(num - 1));
        }

        public int GetLengthWithFastPowMath(int num)
        {
            if (num < 1)
                return 0;
            return (int)Mathf.Pow(10, (int)Mathf.Log10(num - 1));
        }
        
        public int FastPow(int num, int pow)
        {
            if (pow < 1)
                return 0;

            if (pow == 1)
                return num;

            var tmp = FastPow(num, pow / 2);
            var ret = tmp * tmp;
            if ((pow & 1) == 1)
                ret *= num;

            return ret;
        }

        public int FastPow2(int num, int pow)
        {
            int[] stack2 = new int[20];
            int idx = 0;
            while (pow > 0)
            {
                stack2[idx] = pow;
                ++idx;
                pow >>= 1;
            }

            var ret = 0;
            for (int i = idx - 1; i >= 0; --i)
            {
                var now = stack2[i];
                if (now == 1)
                {
                    ret = num;
                }
                else
                {
                    ret = ret * ret;
                    if ((now & 1) == 1)
                        ret *= num;
                }
            }

            return ret;
        }
    }
}

public static class X2Math
{
    /// <summary>
    /// 获取数字位数
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static int GetIntLength(int num)
    {
        if (num < 1)
            return 0;

        if (num < 10)
            return 1;

        return FastPow(10, (int)Mathf.Log10(num));
    }

    /// <summary>
    /// 获取数字位数，刚好整的少数一位。如：10按1位，100按2位，1000按3位算。
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static int GetIntLength2(int num)
    {
        if (num < 1)
            return 0;

        if (num <= 10)
            return 1;

        return FastPow(10, (int)Mathf.Log10(num - 1));
    }

    public static int FastPow(int num, int pow)
    {
        if (pow < 1)
            return 0;

        if (pow == 1)
            return num;

        var tmp = FastPow(num, pow / 2);
        var ret = tmp * tmp;
        if ((pow & 1) == 1)
            ret *= num;

        return ret;
    }
}

