using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class Mercenary : StateBehaviour, IStats
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
