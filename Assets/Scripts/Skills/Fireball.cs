using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : ISkill
{
    public int ResourceCost;
    public int Damage;
    public int Level;
    public int MaxLevel;
    public int LevelUpCost;
    public ISkill PreviousSkill;

    public void Cast(IDamageable target)
    {
        target.TakeDamage();
    }

    public bool LevelUp()
    {
        if (Level < MaxLevel)
        {
            Level++;
            return true;
        }
        return false;
    }

    public void UnlockSkill(ISkill skill)
    {
        if (skill == PreviousSkill)
            Level++;
    }
}
