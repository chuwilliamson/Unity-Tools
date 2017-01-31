using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class Acrobat : StateBehaviour, IStats
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            CalculateAtkSpeed();
            CalculateCritChance();
            CalculateDefense();
            CalculateAttack();
        }
    }

    public void CalculateAtkSpeed()
    {
        mAttackSpeed = GetComponent<StatModifiers>().Dexterity / 5;
    }

    public void CalculateCritChance()
    {
        mCritChance = GetComponent<StatModifiers>().Dexterity / 7f;
    }

    public void CalculateDefense()
    {
        mDefense = GetComponent<StatModifiers>().Stamina / 5;
    }

    public void CalculateAttack()
    {
        mAttack = (int)(GetComponent<StatModifiers>().Dexterity * 0.5f);
    }
}
