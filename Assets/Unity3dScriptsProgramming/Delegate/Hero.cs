using UnityEngine;
using System.Collections;

public class Hero : BaseUnit
{
    public int id;
    public float currentHp;
    public float maxHp;
    public float attack;
    public float defence;

    public Hero()
    {
    }

    public Hero(int id, float maxHp, float attack, float defence)
    {
        this.id = id;
        this.maxHp = maxHp;
        this.currentHp = this.maxHp;
        this.attack = attack;
        this.defence = defence;
    }

    public float PowerRank
    {
        get { return 0.5f * maxHp + 0.2f * attack + 0.3f * defence; }
    }

    public override bool IsHero
    {
        get { return true; }
    }
}