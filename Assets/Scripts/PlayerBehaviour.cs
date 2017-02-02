using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EventOnLevelUp : UnityEvent
{
}
public class PlayerBehaviour : MonoBehaviour
{    
    public void Awake()
    {
        onPlayerLevelUp = new EventOnLevelUp();
    }

    public void Start()
    {
        experience = 0;
        level = 1;
    }

    public void GainExperience(int num)
    {
        experience += num;
        var newLevel = (.5f * Mathf.Sqrt(experience));
        if(newLevel > level)
            onPlayerLevelUp.Invoke();
        level = (int)newLevel;
    }

    public int experience;
    public int level;
    public EventOnLevelUp onPlayerLevelUp;
}
