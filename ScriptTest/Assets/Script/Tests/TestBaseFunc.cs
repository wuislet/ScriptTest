/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestBaseFunc.cs
   ScriptTest
   
   Created by WuIslet on 2019-02-14.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestBaseFunc : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestBaseFunc <<< ");
            SubClass subClass = new SubClass();
            subClass.Bar();
        }
    }

    public class BaseClass
    {
        public virtual void Foo()
        {
            DebugPrint.p(" - base foo - ");
        }

        public virtual void Bar()
        {
            DebugPrint.p(" - base bar - 1");
            Foo();
            DebugPrint.p(" - base bar - 2");
        }
    }

    public class SubClass : BaseClass
    {
        public override void Foo()
        {
            DebugPrint.p(" - sub foo - 1");
            base.Foo();
            DebugPrint.p(" - sub foo - 2");
        }

        public override void Bar()
        {
            DebugPrint.p(" - sub bar - 1");
            base.Bar();
            DebugPrint.p(" - sub bar - 2");
        }
    }

    public class BadBaseClass
    {
        public void Foo()
        {
            DebugPrint.p(" - bad base foo - ");
        }

        public void Bar()
        {
            DebugPrint.p(" - bad base bar - 1");
            Foo();
            DebugPrint.p(" - bad base bar - 2");
        }
    }

    public class BadSubClass : BadBaseClass
    {
        public void Foo()
        {
            DebugPrint.p(" - bad sub foo - 1");
            base.Foo();
            DebugPrint.p(" - bad sub foo - 2");
        }

        public void Bar()
        {
            DebugPrint.p(" - bad sub bar - 1");
            base.Bar();
            DebugPrint.p(" - bad sub bar - 2");
        }
    }
}
