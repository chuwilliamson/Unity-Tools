using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour, IDamageable, IAttacker
{
    void Start()
    {
        Skills = new List<ISkill>();
        skillTree = new SkillTree();
        Fireball a = new Fireball();
        FrostBolt b = new FrostBolt();
        Lighting c = new Lighting();
        poly d = new poly();

        skillTree.AddSkill(a);
        skillTree.AddSkill(b);
        skillTree.AddSkill(c);
        skillTree.AddSkill(d);
        skillTree.LinkSkill(a, b);
        skillTree.LinkSkill(a, c);
        skillTree.LinkSkill(c, d);
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
            //sTarget = SelectTarget();
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
