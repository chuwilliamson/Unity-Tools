using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable
{
    void Start()
    {
        Skills = new List<ISkill>();
        Skills.Add(new Fireball());
    }

    public void TakeDamage()
    {
        CurrentHealth--;
    }

    [ContextMenu("Fire")]
    void Attack()
    {
        Skills[0].Cast(Target);
    }

    public List<ISkill> Skills;
    public IDamageable Target;
    public uint CurrentHealth;
    public int MaxHealth;
    public uint Level;
    public string Name;
}
