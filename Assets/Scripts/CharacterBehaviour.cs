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
        Fireball b = new Fireball();
        Fireball c = new Fireball();
        Fireball d = new Fireball();
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
        ////If the character is a player
        IDamageable tar = null;
        //RaycastHit hitInfo = new RaycastHit();
        //if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
        //{
        //    if (hitInfo.collider.GetComponent<CharacterBehaviour>() != null)
        //    {
        //        tar = hitInfo.collider.GetComponent<CharacterBehaviour>();
        //    }
        //}        
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
