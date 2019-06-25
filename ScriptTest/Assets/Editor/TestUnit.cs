/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestUnit.cs
   ScriptTest
   
   Created by WuIslet on 2019-06-03.
   
*************************************************************/

//#define Timer
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestUnit : MonoBehaviour
    {
        #region Power2
        [Test]
        public void TestPower2()
        {
#if Timer
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 200000; ++i)
            {
                var test = Random.Range(100, 10000);
                var a = Power2Func1(test);
            }
            sw.Stop();
            UnityEngine.Debug.Log("Timer1:  " + sw.Elapsed.TotalSeconds); //TODO Del
            sw.Reset();
            sw.Start();
            for (int i = 0; i < 200000; ++i)
            {
                var test = Random.Range(100, 10000);
                var a = Power2Func2(test);
            }
            sw.Stop();
            UnityEngine.Debug.Log("Timer2:  " + sw.Elapsed.TotalSeconds); //TODO Del
#else
            for (int i = 0; i < 20; ++i)
            {
                var test = Random.Range(100, 10000);
                UnityEngine.Debug.Log(test + " :=> " + Power2Func1(test)); //TODO Del
                //Assert.AreEqual(true, Power2Func1(test) == Power2Func2(test));
                Assert.AreEqual(typeof(bool), (Power2Func2(test)).GetType()); //Timer
            }

            for (int i = 0; i < 5; ++i)
            {
                var test = (int)Mathf.Pow(2, Random.Range(1, 16));
                UnityEngine.Debug.Log(test + " :=> " + Power2Func1(test)); //TODO Del
                //Assert.AreEqual(true, Power2Func1(test) == Power2Func2(test));
                Assert.AreEqual(typeof(bool), (Power2Func2(test)).GetType()); //Timer
            }
#endif
            
        }

        private bool Power2Func1(int num)
        {
            int i = 1;
            while (true)
            {
                if (i > num)
                    return false;
                if (i == num)
                    return true;
                i = i * 2;
            }
        }

        private bool Power2Func2(int num)
        {
            return (num & (num - 1)) == 0;
        }
#endregion

#region Lowest1
        [Test]
        public void Lowest1()
        {
#if Timer
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 200000; ++i)
            {
                var test = Random.Range(100, 10000);
                var a = Lowest1Func1(test);
            }
            sw.Stop();
            UnityEngine.Debug.Log("Timer1:  " + sw.Elapsed.TotalSeconds); //TODO Del
            sw.Reset();
            sw.Start();
            for (int i = 0; i < 200000; ++i)
            {
                var test = Random.Range(100, 10000);
                var a = Lowest1Func2(test);
            }
            sw.Stop();
            UnityEngine.Debug.Log("Timer2:  " + sw.Elapsed.TotalSeconds); //TODO Del
#else
            for (int i = 0; i < 20; ++i)
            {
                var test = Random.Range(100, 10000);
                UnityEngine.Debug.Log(test + " :=> " + Lowest1Func1(test)); //TODO Del
                //Assert.AreEqual(true, Lowest1Func1(test) == Lowest1Func2(test));
                Assert.AreEqual(typeof(int), (Lowest1Func2(test)).GetType()); //Timer
            }

            for (int i = 0; i < 5; ++i)
            {
                var test = (int)Mathf.Pow(2, Random.Range(1, 16));
                UnityEngine.Debug.Log(test + " :=> " + Lowest1Func1(test)); //TODO Del
                //Assert.AreEqual(true, Lowest1Func1(test) == Lowest1Func2(test));
                Assert.AreEqual(typeof(int), (Lowest1Func2(test)).GetType()); //Timer
            }
#endif
        }

        private int Lowest1Func1(int num)
        {
            return ((num ^ (num - 1)) + 1) >> 1;
        }

        private int Lowest1Func2(int num)
        {
            return (num & (num - 1)) ^ num;
        }
#endregion

#region GreaterNearestPower2
        [Test]
        public void GreaterNearestPower2()
        {
#if Timer
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 200000; ++i)
            {
                var test = Random.Range(100, 10000);
                var a = GreaterNearestPower2Func1(test);
            }
            sw.Stop();
            UnityEngine.Debug.Log("Timer1:  " + sw.Elapsed.TotalSeconds); //TODO Del
            sw.Reset();
            sw.Start();
            for (int i = 0; i < 200000; ++i)
            {
                var test = Random.Range(100, 10000);
                var a = GreaterNearestPower2Func2(test);
            }
            sw.Stop();
            UnityEngine.Debug.Log("Timer2:  " + sw.Elapsed.TotalSeconds); //TODO Del
#else
            for (int i = 0; i < 20; ++i)
            {
                var test = Random.Range(100, 10000);
                UnityEngine.Debug.Log(test + " :=> " + GreaterNearestPower2Func1(test) + " == " + GreaterNearestPower2Func2(test)); //TODO Del
                //Assert.AreEqual(true, GreaterNearestPower2Func1(test) == GreaterNearestPower2Func2(test));
                Assert.AreEqual(typeof(int), (GreaterNearestPower2Func2(test)).GetType()); //Timer
            }

            for (int i = 0; i < 5; ++i)
            {
                var pow = Random.Range(2, 16);
                var test = (int)(Mathf.Pow(2, pow) + Mathf.Pow(2, pow - 1));
                UnityEngine.Debug.Log(test + " :=> " + GreaterNearestPower2Func1(test) + " == " + GreaterNearestPower2Func2(test)); //TODO Del
                Assert.AreEqual(true, GreaterNearestPower2Func1(test) == GreaterNearestPower2Func2(test));
            }

            for (int i = 0; i < 5; ++i)
            {
                var pow = Random.Range(2, 16);
                var test = (int)Mathf.Pow(2, pow);
                UnityEngine.Debug.Log(test + " :=> " + GreaterNearestPower2Func1(test) + " == " + GreaterNearestPower2Func2(test)); //TODO Del
                Assert.AreEqual(true, GreaterNearestPower2Func1(test) == GreaterNearestPower2Func2(test));
            }
#endif
        }

        private int GreaterNearestPower2Func1(int num)
        {
            return (int)(Mathf.Pow(2, Mathf.Ceil(Mathf.Log(num) / Mathf.Log(2))));
        }

        private int GreaterNearestPower2Func2(int num)
        {
            if (num <= 1)
                return 1;

            if ((num & (num - 1)) == 0) //¸ÕºÃÊÇ2´ÎÃÝ
                return num;

            while (true)
            {
                var next = (num & (num - 1));
                if (next == 0)
                    return num << 1;
                num = next;
            }
        }
        #endregion

        [Test]
        public void TestDeepCopy()
        {
            List<int> a = new List<int>() {1, 2, 3};
            List<int> b = new List<int>() {5, 6, 7};
            DeepCopyList(a, b);
            Assert.AreEqual(3, b.Count);
            Assert.AreEqual(1, b[0]);
            Assert.AreEqual(2, b[1]);
            Assert.AreEqual(3, b[2]);

            a = new List<int>() { 1, 2, 3 };
            b = new List<int>() { 5 };
            DeepCopyList(a, b);
            Assert.AreEqual(3, b.Count);
            Assert.AreEqual(1, b[0]);
            Assert.AreEqual(2, b[1]);
            Assert.AreEqual(3, b[2]);

            a = new List<int>() {1, 2, 3};
            b = new List<int>() {5, 6, 7, 8, 9};
            DeepCopyList(a, b);
            Assert.AreEqual(3, b.Count);
            Assert.AreEqual(1, b[0]);
            Assert.AreEqual(2, b[1]);
            Assert.AreEqual(3, b[2]);
            
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(1, a[0]);
            Assert.AreEqual(2, a[1]);
            Assert.AreEqual(3, a[2]);
        }

        private void DeepCopyList(List<int> from, List<int> to)
        {
            var fromCount = from.Count;
            var toCount = to.Count;
            for (int i = 0; i < fromCount; i++)
            {
                var hero = from[i];
                if (i < toCount)
                    to[i] = hero;
                else
                    to.Add(hero);
            }

            if (toCount > fromCount)
            {
                to.RemoveRange(fromCount, toCount - fromCount);
            }
        }
    }
}
