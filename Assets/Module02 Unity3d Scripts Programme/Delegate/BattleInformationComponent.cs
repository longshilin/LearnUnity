using System;
using UnityEngine;

public class BattleInformationComponent : MonoBehaviour
{
    public BaseUnit unit;

    private void Start()
    {
        this.unit = gameObject.GetComponent<BaseUnit>();
        this.AddListener();
    }

    private void Update()
    {
    }

    //订阅BaseUnit定义的事件OnSubHp
    private void AddListener()
    {
        //构造BaseUnit.SubHpHandler委托类型的一个实例
        //并且让它来引用BattleInformationComponent类的
        //OnSubHp方法，之后向BaseUnit的OnSubHp事件登记
        //该回调方法
        this.unit.OnSubHp += new BaseUnit.SubHpHandler(this.OnSubHp);
    }

    //取消对BaseUnit定义的事件OnSubHp的订阅
    private void RemoveListener()
    {
        //注销关注
        this.unit.OnSubHp -= new BaseUnit.SubHpHandler(this.OnSubHp);
    }

    //当BaseUnit被攻击时，会调用该回调事件
    private void OnSubHp(BaseUnit source, float subHp, DamageType damageType, HpShowType showType)
    {
        string unitName = string.Empty;
        string missStr = "闪避";
        string damageTypeStr = string.Empty;
        string damageHp = string.Empty;
        if (showType == HpShowType.Miss)
        {
            Debug.Log(missStr);
            return;
        }

        if (source.IsHero)
        {
            unitName = "英雄";
        }
        else
        {
            unitName = "士兵";
        }

        damageTypeStr = damageType == DamageType.Critical ? "暴击" : "普通攻击";
        damageHp = subHp.ToString();
        Debug.Log(unitName + damageTypeStr + damageHp);
    }
}