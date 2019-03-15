/*************************************************************
   Copyright(C) 2017 by DefaultCompany
   All rights reserved.
   
   TestNewOutFor.cs
   ScriptTest
   
   Created by WuIslet on 2019-03-14.
   
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace isletspace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestNewOutFor : MonoBehaviour, ITestScript
    {
        public void StartTest()
        {
            DebugPrint.p(" >>> TestNewOutFor <<< ");
            List<int> itemIDs = new List<int>(){1, 3, 5, 7, 9, 11};
            List< int > itemNums = new List<int>() {2, 4, 6, 8, 10, 12};

            DebugPrint.p("  >>>  test  class  <<< ");

            List<ItemData> datas = new List<ItemData>();
            ItemData tmp = new ItemData();
            for (int i = 0; i < itemIDs.Count; ++i)
            {
                tmp.ID = itemIDs[i];
                tmp.num = itemNums[i];
                datas.Add(tmp);
            }

            DebugPrint.p("   test   list out  " + datas.Count);
            DebugPrint.pl(datas.ToArray());

            DebugPrint.p("  >>>  test  struct  <<< ");
            
            List<ItemDataStruct> dataStructs = new List<ItemDataStruct>();
            ItemDataStruct tmp2 = new ItemDataStruct();
            for (int i = 0; i < itemIDs.Count; ++i)
            {
                tmp2.ID = itemIDs[i];
                tmp2.num = itemNums[i];
                dataStructs.Add(tmp2);
            }

            DebugPrint.p("   test   list out  " + dataStructs.Count);
            DebugPrint.pl(dataStructs.ToArray());
        }
    }
    public class ItemData
    {
        public int ID;
        public int num;

        public ItemData(int id, int num)
        {
            ID = id;
            this.num = num;

        }
        public ItemData()
        {

        }

        public override string ToString()
        {
            return " , ID = <" + ID.ToString() + "> " + " , num = <" + num.ToString() + "> ";
        }
    }

    public struct ItemDataStruct
    {
        public int ID;
        public int num;

        public void ItemData(int id, int num)
        {
            ID = id;
            this.num = num;

        }
        public void ItemData()
        {

        }

        public override string ToString()
        {
            return " , ID = <" + ID.ToString() + "> " + " , num = <" + num.ToString() + "> ";
        }
    }
}
