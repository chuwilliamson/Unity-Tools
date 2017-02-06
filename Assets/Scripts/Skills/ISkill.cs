using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ISkill
{
    void Cast(IDamageable target);

    bool LevelUp();

    bool IsUnlock();

    void UnLock();

    bool MeetsCharacterRequirements();
}
