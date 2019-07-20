using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    private int heroCount;
    private int soldierCount;

    // Use this for initialization
    private void Start()
    {
        var bList = new List<Hero>();
        bList.Add(new Hero(1, 1000f, 50f, 100f));
        bList.Add(new Hero(2, 1200f, 20f, 123f));
        bList.Add(new Hero(2, 800f, 100f, 125f));
        bList.Add(new Hero(3, 600f, 54f, 120f));
        bList.Add(new Hero(4, 2000f, 5f, 110f));
        bList.Add(new Hero(6, 3000f, 65f, 105f));

        //按英雄的ID排序
        SortHeros(bList,
            delegate(Hero Obj, Hero Obj2)
            {
                return !Obj.id.Equals(Obj2.id) ? Obj.id.CompareTo(Obj2.id) : Obj.maxHp.CompareTo(Obj2.maxHp);
            }, "按英雄的ID排序");
        //按英雄的maxHp排序
//        SortHeros(bList, delegate(Hero Obj, Hero Obj2) { return Obj.maxHp.CompareTo(Obj2.maxHp); }, "按英雄的maxHp排序");
//        //按英雄的attack排序
//        SortHeros(bList, delegate(Hero Obj, Hero Obj2) { return Obj.attack.CompareTo(Obj2.attack); },
//            "按英雄的attack排序");
//        //按英雄的defense排序
//        SortHeros(bList, delegate(Hero Obj, Hero Obj2) { return Obj.defence.CompareTo(Obj2.defence); },
//            "按英雄的defense排序");
//        //按英雄的powerRank排序
//        SortHeros(bList, delegate(Hero Obj, Hero Obj2) { return Obj.PowerRank.CompareTo(Obj2.PowerRank); },
//            "按英雄的powerRank排序");
    }

    public void SortHeros(List<Hero> targets, Comparison<Hero> sortOrder, string orderTitle)
    {
        //    targets.Sort(sortOrder);
        var bUnits = targets.ToArray();
        Array.Sort(bUnits, sortOrder);
        Debug.Log(orderTitle);
        foreach (var unit in bUnits)
        {
            Debug.Log("id:" + unit.id);
            Debug.Log("maxHp:" + unit.maxHp);
            Debug.Log("attack:" + unit.attack);
            Debug.Log("defense:" + unit.defence);
            Debug.Log("powerRank:" + unit.PowerRank);
        }
    }


    // Update is called once per frame
    private void Update()
    {
    }
}