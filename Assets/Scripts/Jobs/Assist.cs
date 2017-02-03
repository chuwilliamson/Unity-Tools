using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class Assist : JobState
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
        AttackSpeed = (int)(Dexterity / 5f);
    }

    public void CalculateCritChance()
    {
        CriticalHit = (int)(Dexterity / 7f);
    }

    public void CalculateDefense()
    {
        Defense = (int)(Stamina / 5f);
    }

    public void CalculateAttack()
    {
        AttackDamage = (int)(Strength * 2f);
    }
}
