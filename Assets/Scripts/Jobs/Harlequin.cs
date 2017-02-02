using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harlequin : JobState
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
        AttackSpeed = (int)(Dexterity * 0.1f);
    }

    public void CalculateCritChance()
    {
        CriticalHit = (int)(Dexterity * 0.5f);
    }

    public void CalculateDefense()
    {
        Defense = (int)(Stamina * 0.5f);
    }

    public void CalculateAttack()
    {
        AttackDamage = (int)(Strength * 5.0f);
    }
}
