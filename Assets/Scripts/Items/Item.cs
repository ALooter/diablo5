using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemname;
    public Sprite icon;
    public bool isdefaultitem;

    public virtual void Use()
    {
        //using item script

        Debug.Log("Using " + itemname);
    }
    
    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
