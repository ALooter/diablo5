using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    
    void Start()
    {
        EquipmentManager.instance.onequipmentchanged += OnEquipmentChanged;
    }

    void OnEquipmentChanged(Equipment newitem, Equipment olditem)
    {
        if (newitem != null)
        {
            armor.AddModifier(newitem.armorbonus);
            damage.AddModifier(newitem.damagebonus);
        }

        if (olditem != null)
        {
            armor.RemoveModifier(olditem.armorbonus);
            damage.RemoveModifier(olditem.damagebonus);
        }

    }

    public override void Die()
    {
        base.Die();

        PlayerManager.instance.KillPlayer();
    }
}
