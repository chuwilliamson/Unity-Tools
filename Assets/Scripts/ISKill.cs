using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISkill
{
    void Cast(IDamageable target);

    bool LevelUp();
}
