using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Fireball : ISkill
{
    public int ResourceCost;
    public int Damage;
    public int Level;
    public int MaxLevel;
    public int LevelUpCost;
    public IAttacker Owner;
    public int CharacterLevelRequirements;
    public bool IsLearnable;
    public string Name;

    public Fireball(IAttacker owner, string name)
    {
        Owner = owner;
        Name = name;
    }

    public void Cast(IDamageable target)
    {
        target.TakeDamage(Owner);
    }

    public bool LevelUp()
    {
        if (Level < MaxLevel && Owner.GetCharacterLevel() >= CharacterLevelRequirements)
        {
            Level++;
            return true;
        }
        return false;
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
        LevelUp();
    }
}
