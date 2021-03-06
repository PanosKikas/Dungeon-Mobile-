﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum EquipmentType
{
    Head,
    Chest,
    Legs,
    Weapon,
    Potion
}


public abstract class EquipableSO : InventoryPickupSO
{

    public EquipmentType EquipmentType;    

    public void Equip()
    {
        CharacterEquipment.Instance.Equip(this);
    }

    public virtual void Unequip() { }
 
}
