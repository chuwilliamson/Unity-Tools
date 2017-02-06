using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree
{
    List<ISkill> Skills;
    List<SkillLink> Links;

    class SkillLink
    {
        public List<ISkill> From;
        public List<ISkill> To;
        public bool IsLinked;

        public SkillLink()
        {

        }

        public bool UnLockSkills()
        {
            foreach(ISkill sn in From)
            {
                if (sn.IsUnlock() == false)
                    return false;
            }
            foreach(ISkill sn in To)
            {
                sn.UnLock();
            }
            return true;
        }

        public void AddFromSkill(ISkill skill)
        {
            if (!From.Contains(skill) && !To.Contains(skill))
                From.Add(skill);
        }

        public void AddToSkill(ISkill skill)
        {
            if (!From.Contains(skill) && !To.Contains(skill))
                To.Add(skill);
        }
    }

    public SkillTree()
    {
        Skills = new List<ISkill>();
    }

    public bool AddSkill(ISkill skill)
    {
        if (Skills.Contains(skill))
            return false;
        Skills.Add(skill);
        return true;
    }

    public void LinkSkill(ISkill to, ISkill from)
    {
        foreach(SkillLink link in Links)
        {
            link.AddFromSkill(from);
            link.AddToSkill(to);
        }
    }
}
