using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class Magician : StateBehaviour, IStats
{
    public float AttackSpeed;    
    public float CritChance;    
    public int Defense;    
    public int Attack;

    void OnEnable()
    {
        CalculateAttackSpeed();
        CalculateCritChance();
        CalculateDefense();
        CalculateAttack();
    }

    public void CalculateAttackSpeed()
    {
        mAttackSpeed = GetComponentInParent<StatModifiers>().Dexterity / 5;
    }

    public void CalculateCritChance()
    {
        mCritChance = GetComponentInParent<StatModifiers>().Dexterity / 7f;
    }

    public void CalculateDefense()
    {
        mDefense = GetComponentInParent<StatModifiers>().Stamina / 5;
    }

    public void CalculateAttack()
    {
        mAttack = (int)(GetComponentInParent<StatModifiers>().Intelligence * 3);
    }
}
