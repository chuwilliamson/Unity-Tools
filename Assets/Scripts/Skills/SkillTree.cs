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
            From = new List<ISkill>();
            To = new List<ISkill>();
        }

        public bool UnLockSkills()
        {
            bool unlock = true;
            foreach(ISkill sn in From)
            {
                if (sn.IsUnlock() == false)
                    unlock = false;
            }            
            if(unlock == true)
            {
                foreach (ISkill sn in To)
                {
                    sn.UnLock();
                }
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
            //List are acting weird when it comes to Interfaces and it thinks
            //the item passed in to the function is all ready in the list when it
            //isn't. This does not happen all the time. 
            //Will devote more time to this problem later
            if(skill != null)
                To.Add(skill);
        }
    }

    public void UnLockSkill(ISkill a)
    {        
        if(Skills.Contains(a))
        {
            foreach(SkillLink link in Links)
            {
                link.UnLockSkills();
            }
            a.UnLock();
        }
    }

    public ISkill GetSkill(ISkill check)
    {
        if (check.IsUnlock())
            return check;
        return null;
    }

    public SkillTree()
    {
        Skills = new List<ISkill>();
        Links = new List<SkillLink>();
    }

    public bool AddSkill(ISkill skill)
    {
        //if (Skills.Contains(skill))
        //    return false;
        Skills.Add(skill);
        return true;
    }

    public void LinkSkill(ISkill from, ISkill to)
    {
        bool CreateNew = true;
        foreach(SkillLink l in Links)
        {
            if (l.From.Contains(from))
            {
                l.AddToSkill(to);
                CreateNew = false;
            }
        }
        if(CreateNew)
        {
            SkillLink link = new SkillLink();
            link.AddFromSkill(from);
            link.AddToSkill(to);
            Links.Add(link);
        }

    }
}
