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
    public IAttacker Owner;
    public int CharacterLevelRequirements;
    public bool IsLearnable;
    string Name;

    public void Cast(IDamageable target)
    {
        target.TakeDamage(Owner);
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

    public bool IsUnlock()
    {
        return IsLearnable;
    }

       

    public bool MeetsCharacterRequirements()
    {
        if (Owner.GetCharacterLevel() >= CharacterLevelRequirements)
            return true;
        return false;
    }

    public void UnLock()
    {
        IsLearnable = true;
    }
}
