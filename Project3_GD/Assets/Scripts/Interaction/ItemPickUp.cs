using System.Collections;
using UnityEngine;

public class ItemPickUp : Interactable
{
    public int count =1;
    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up "+item.name);

        bool wasPickedUp = Inventory.instance.Add(item);
        
        if(wasPickedUp)
            Destroy(gameObject);
    }

    public void Set(Item item, int count)
    {
        this.item = item;
        this.count = count;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = item.icon;
    }


}
