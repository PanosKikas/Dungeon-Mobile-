﻿using UnityEngine;


public abstract class CharacterStats : ScriptableObject
{
    
    public int CurrentHealth;
    public int MaxHealth = 500;
    
    public int AttackDamage = 50;

    public float AutoAttackRate = .5f;
    
    void OnEnable()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        CurrentHealth = MaxHealth;
        
    }

}
