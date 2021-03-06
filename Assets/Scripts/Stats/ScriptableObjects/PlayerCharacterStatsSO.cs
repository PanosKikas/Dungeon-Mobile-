﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Stats/PlayerStats")]
public class PlayerCharacterStatsSO : CharacterStatsSO
{

    public CharacterStat ManualAttackRateStat;
    public CharacterStat MaxEnduranceStat;
    public CharacterStat MaxManaStat;
    public CharacterStat EnduranceRegenStat;
    public CharacterStat CriticalDamageStat;
    public CharacterStat CriticalChanceStat;
    public CharacterStat MagicDamageStat;
    public CharacterStat EvasionChanceStat;
    public CharacterStat PhysicalDefenseStat;
    public CharacterStat MagicalResistanceStat;
    public CharacterStat ItemDropRateStat;

    Experience experience;

    Attribute Vitality;
    Attribute Strength;
    Attribute Agility;
    Attribute Wisdom;
    Attribute Luck;

    [HideInInspector]
    public Attribute[] AttributeStats;

    #region StatGetters
    public float ManualAttackRate
    {
        get
        {
            
            return ManualAttackRateStat.Value;
        }

    }

    public int MaxEndurace
    {
        get
        {
            return (int)MaxEnduranceStat.Value;
        }

    }

    public float EndurancePerAttack = 4;

    public float EnduranceRechargeRate
    {
        get
        {
            return EnduranceRegenStat.Value;
        }
    }

    public int MaxMana
    {
        get
        {
            return (int)MaxManaStat.Value;
        }
      
    }

    #endregion

    public override void Initialize()
    {
        experience = new Experience();
     

        upgradableStatsList.Add(ManualAttackRateStat);
        upgradableStatsList.Add(MaxEnduranceStat);
        upgradableStatsList.Add(MaxManaStat);
        upgradableStatsList.Add(EnduranceRegenStat);
        upgradableStatsList.Add(CriticalDamageStat);
        upgradableStatsList.Add(CriticalChanceStat);
        upgradableStatsList.Add(MagicDamageStat);
        upgradableStatsList.Add(EvasionChanceStat);
        upgradableStatsList.Add(PhysicalDefenseStat);
        upgradableStatsList.Add(MagicalResistanceStat);
        upgradableStatsList.Add(ItemDropRateStat);

        Vitality = new Attribute(3);
            
        Strength = new Attribute(3);
        Agility = new Attribute(4);
        Wisdom = new Attribute(1);
        Luck = new Attribute(0);

        AttributeStats = new[]
        {
            Vitality, Strength, Agility, Wisdom, Luck
        };

        MaxHealthStat.AddDependantAttribute(Vitality, new StatModifier(10));
        MaxEnduranceStat.AddDependantAttribute(Vitality, new StatModifier(3));
        EnduranceRegenStat.AddDependantAttribute(Vitality, new StatModifier(.2f));


        AttackDamageStat.AddDependantAttribute(Strength, new StatModifier(1));
        CriticalDamageStat.AddDependantAttribute(Strength, new StatModifier(1));
        AutoAttackRateStat.AddDependantAttribute(Agility, new StatModifier(.1f));
        ManualAttackRateStat.AddDependantAttribute(Agility, new StatModifier(.05f));


        EvasionChanceStat.AddDependantAttribute(Luck, new StatModifier(.05f));
        CriticalChanceStat.AddDependantAttribute(Luck, new StatModifier(.05f));
        ItemDropRateStat.AddDependantAttribute(Luck, new StatModifier(.05f));
        base.Initialize();

    }

    
}
