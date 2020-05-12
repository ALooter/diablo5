using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryui;

    public GameObject skillbookui;
    public CharacterStats stats;
    public Text hp, armor, damage, attackspeed;

    Inventory inventory;

    public Transform itemsparent;

    InventorySlot[] slots;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onitemchangedcallback += UpdateUI;

        slots = itemsparent.GetComponentsInChildren<InventorySlot>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryui.SetActive(!inventoryui.activeSelf);
        }

        if (Input.GetButtonDown("Skillbook"))
        {
            inventoryui.SetActive(!skillbookui.activeSelf);
        }

        //update text - make 1 time updates instead of updating every second
        hp.text = stats.maxhealth.ToString();
        armor.text = stats.armor.ToString();
        damage.text = stats.damage.ToString();
        attackspeed.text = stats.attackspeed.ToString();

    }

    //placeholder code(((
    void healthUp()
    {
        //stats.maxhealth.AddModifier;
    }

    void armorUp()
    {
        //stats.armor += 4;
    }

    void damageUp()
    {
        //stats.damage += 3;
    }

    void attackspeedUp()
    {
        //stats.attackspeed += 2;
    }

    void UpdateUI()
    {
        for (int i=0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }

    }



}
