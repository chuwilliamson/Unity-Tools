using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree
{
    public Dictionary<ISkill, bool> Skills;
    public List<SkillNode> Nodes;

    public class SkillNode
    {
        public ISkill Previous;
        public ISkill Current; 

        public SkillNode(ISkill skill)
        {
            Current = skill;
            Previous = null;
        }

        public SkillNode(ISkill skill, ISkill previous)
        {
            Current = skill;
            Previous = previous;
        }

        public void Unlock()
        {
            if (Previous.IsUnlock())
                Current.LevelUp();
        }
    }
        
    public SkillTree()
    {
        Skills = new Dictionary<ISkill, bool>();
    }

    public void AddSkill(ISkill skill, ISkill previous)
    {
        if(Nodes == null)
        {
            Nodes = new List<SkillNode>();
            Nodes.Add(new SkillNode(skill));
            Skills.Add(skill, false);
        }
        else
        {
            if(Skills.ContainsKey(previous))
            {
                Nodes.Add(new SkillNode(skill, previous));
                Skills.Add(skill, false);
            }
        }
    }
}
