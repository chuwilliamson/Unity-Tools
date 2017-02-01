using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IStats
{
    int Attack { get; set; }
    int Defense { get; set; }
    float CriticalChance { get; set; }
    float AttackSpeed { get; set; }

    void CalculateAttack();
    void CalculateDefense();
    void CalculateCritChance();
    void CalculateAttackSpeed();
}

public class StatModifiers : MonoBehaviour
{
    #region Fields    
    public int Strength;    
    public int Stamina;    
    public int Dexterity;
    public int Intelligence;
    #endregion
}
