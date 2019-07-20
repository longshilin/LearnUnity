using System;
using UnityEngine;

public enum DamageType
{
    Normal, //普通伤害
    Critical //暴击伤害
}

public enum HpShowType
{
    Null, //不显示
    Damage, //伤害
    Miss //闪避
}

public class BaseUnit : MonoBehaviour
{
    public delegate void SubHpHandler(BaseUnit source, float subHp, DamageType damageType, HpShowType showType);

    public event SubHpHandler OnSubHp;

    public void BeAttacked()
    {
        float possibility = UnityEngine.Random.value;
        bool isCritical = UnityEngine.Random.value > 0.5f;
        bool isMiss = UnityEngine.Random.value > 0.5f;
        float harmNumber = 10000f;
        //
        OnBeAttacked(harmNumber, isCritical, isMiss);
    }

    //OnBeAttacked方法需要3个参数，分别是
    //表示伤害数字的float型的harmNumber
    //表示是否是暴击伤害的bool型的isCritical
    //表示是否是闪避的bool型isMiss
    protected virtual void OnBeAttacked(float harmNumber, bool isCritical, bool isMiss)
    {
        DamageType damageType = DamageType.Normal;
        HpShowType showType = HpShowType.Damage;
        if (isCritical)
            damageType = DamageType.Critical;
        if (isMiss)
            showType = HpShowType.Miss;
        //首先判断是否有方法订阅了该事件，如果有则通知它们
        if (OnSubHp != null)
            OnSubHp(this, harmNumber, damageType, showType);
    }

    virtual public bool IsHero
    {
        get { return true; }
    }
}