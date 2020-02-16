using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{

    #region Singleton

    public static EquipmentManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    Equipment[] currentequipment;

    public delegate void OnEquipmentChanged(Equipment newitem, Equipment olditem);
    public OnEquipmentChanged onequipmentchanged;

    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;

        int slotsnum = System.Enum.GetNames(typeof(EquipmentSlots)).Length;
        currentequipment = new Equipment[slotsnum];
    }

    public void Equip(Equipment newitem)
    {
        int slotindex = (int)newitem.equipmentslot;

        Equipment olditem = null;

        if (currentequipment[slotindex] != null)
        {
            olditem = currentequipment[slotindex];
            inventory.Add(olditem);
        }

        if (onequipmentchanged != null)
        {
            onequipmentchanged.Invoke(newitem, olditem);
        }

        currentequipment[slotindex] = newitem;
    }

    public void Unequip(int slotindex)
    {
        if (currentequipment[slotindex] != null)
        {
            Equipment olditem = currentequipment[slotindex];
            inventory.Add(olditem);

            currentequipment[slotindex] = null;

            if (onequipmentchanged != null)
            {
                onequipmentchanged.Invoke(null, olditem);
            }
        }
    }
}
