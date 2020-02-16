using UnityEngine;

public class ItemPickup : Interactable
{

    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("picking up " + item.name);
        bool waspickedup = Inventory.instance.Add(item);
        if (waspickedup)
        {
            Destroy(gameObject);
        }
    }
}
