using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour, IDamageable, IAttacker
{
    public Fireball a = new Fireball();
    public FrostBolt b = new FrostBolt();
    public Lighting c = new Lighting();
    public poly d = new poly();
    void Start()
    {
        Skills = new List<ISkill>();
        skillTree = new SkillTree();

         a = new Fireball();
         b = new FrostBolt();
         c = new Lighting();
         d = new poly();
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
            skillTree.LevelUpSkill(a);
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
