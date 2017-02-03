using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour, ISkill
{
    public int ResourceCost;
    public int Damage;
    public int Level;
    public int MaxLevel;
    public int LevelUpCost;

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
}
