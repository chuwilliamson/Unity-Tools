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
    void CalculateAtkSpeed();
}

public class StatModifiers : MonoBehaviour
{
    #region Fields
    [SerializeField]
    int mStrength;
    [SerializeField]
    int mStamina;
    [SerializeField]
    int mDexterity;
    [SerializeField]
    int mIntelligence;
    #endregion

    #region Properties
    public int Strength
    {
        get { return mStrength; }
    }

    public int Stamina
    {
        get { return mStrength; }
    }

    public int Dexterity
    {
        get { return mDexterity; }
    }

    public int Intelligence
    {
        get { return mIntelligence; }
    }
    #endregion
}
