using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ISkill
{
    void Cast(IDamageable target);

    bool LevelUp();

    void UnlockSkill(ISkill skill);

    bool IsUnlock();
}
