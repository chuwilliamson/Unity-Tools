using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class Acrobat : JobState
{    

    void OnEnable()
    {
        CalculateAttackSpeed();
        CalculateCritChance();
        CalculateDefense();
        CalculateAttack();
    }

    public void CalculateAttackSpeed()
    {
        AttackSpeed = (int)(Dexterity * 0.5);
    }

    public void CalculateCritChance()
    {
        CriticalHit = (int)(Dexterity * 0.7f);
    }

    public void CalculateDefense()
    {
        Defense = (int)(Stamina * 0.5f);
    }

    public void CalculateAttack()
    {
        AttackDamage = (int)(Dexterity * 0.5f);
    }
}
