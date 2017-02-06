using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttacker
{
    void Attack(int skillIndex);

    IDamageable SelectTarget();

    uint GetCharacterLevel();
}
