using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable
{
    void Start()
    {

    }

    public void TakeDamage()
    {
        CurrentHealth--;
    }

    public uint CurrentHealth;
    public int MaxHealth;
    public uint Level;
    public string Name;
}
