using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IStats
{
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
