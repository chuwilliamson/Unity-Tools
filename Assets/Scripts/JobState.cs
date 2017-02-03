using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;

public class JobState : StateBehaviour
{
    public int Dexterity = 0;
    public int Stamina = 0;
    public int Defense = 0;
    public int CriticalHit = 0;
    public int AttackSpeed = 0;
    public int AttackDamage = 0;
    public int Strength = 0;
    public int Intelligence = 0;

    void Awake()
    {
        Dexterity = 15;
        Strength = 15;
        Stamina = 15;
        Intelligence = 15;

        CriticalHit = 0;
        Defense = 0;
        AttackDamage = 0;
        AttackSpeed = 0;
    }
}
