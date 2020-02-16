using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryui;

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
