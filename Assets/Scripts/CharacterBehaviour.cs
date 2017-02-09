using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour, IDamageable, IAttacker
{
    public Fireball a;
    public Fireball b;
    public Fireball c;
    public Fireball d;

    void Start()
    {
        Skills = new List<ISkill>();
        skillTree = new SkillTree();
    }

    public void TakeDamage(IAttacker attacker)
    {
        Target = attacker;
        CurrentHealth--;
    }

    [ContextMenu("Fire")]
    public void Attack(int skillIndex)
    {
        if(skillIndex < Skills.Count)
        {
            Skills[skillIndex].Cast((IDamageable)Target);
        }
    }

    public bool TryAddSkill(ISkill skill)
    {
        if(!Skills.Contains(skill))
        {
            Skills.Add(skill);
            return true;
        }
        Debug.Log("Spell allready exists");
        return false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            skillTree.UnLockSkill(a);
            if (skillTree.GetSkill(a) != null)
                Skills.Add(skillTree.GetSkill(a));
        }

        if(Input.GetMouseButtonDown(1))
        {
            a.LevelUp();
        }
    }

    public IDamageable SelectTarget()
    {
        IDamageable tar = null; 
        return tar;
    }

    public uint GetCharacterLevel()
    {
        return Level;
    }

    public SkillTree skillTree;
    public List<ISkill> Skills;
    public IAttacker Target;
    public uint CurrentHealth;
    public int MaxHealth;
    public uint Level;
    public string Name;
}
