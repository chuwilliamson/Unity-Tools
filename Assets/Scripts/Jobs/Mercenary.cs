using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class Mercenary : StateBehaviour, IStats
{
    [SerializeField]
    float mAttackSpeed;
    [SerializeField]
    float mCritChance;
    [SerializeField]
    int mDefense;
    [SerializeField]
    int mAttack;

    public float AttackSpeed
    {
        get
        {
            return mAttackSpeed;
        }

        set
        {
            mAttackSpeed = value;
        }
    }

    public float CriticalChance
    {
        get
        {
            return mCritChance;
        }

        set
        {
            mCritChance = value;
        }
    }

    public int Defense
    {
        get
        {
            return mDefense;
        }

        set
        {
            mDefense = value;
        }
    }

    public int Attack
    {
        get
        {
            return mAttack;
        }

        set
        {
            mAttack = value;
        }
    }

    void OnEnable()
    {
        CalculateAttackSpeed();
        CalculateCritChance();
        CalculateDefense();
        CalculateAttack();
    }

    public void CalculateAttackSpeed()
    {
        mAttackSpeed = GetComponentInParent<StatModifiers>().Dexterity / 10;
    }

    public void CalculateCritChance()
    {
        mCritChance = GetComponentInParent<StatModifiers>().Dexterity / 5;
    }

    public void CalculateDefense()
    {
        mDefense = GetComponentInParent<StatModifiers>().Stamina / 2; 
    }

    public void CalculateAttack()
    {
        mAttack = GetComponentInParent<StatModifiers>().Strength * 5;
    }
}
