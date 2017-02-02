using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class Vagrant : JobState
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
        AttackSpeed = (int)(Dexterity);
    }

    public void CalculateCritChance()
    {
        CriticalHit = (int)(Dexterity);
    }

    public void CalculateDefense()
    {
        Defense = (int)(Stamina);
    }

    public void CalculateAttack()
    {
        AttackDamage = (int)(Strength);
    }
}
