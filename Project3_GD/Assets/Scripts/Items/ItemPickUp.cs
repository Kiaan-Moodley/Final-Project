using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickUp : MonoBehaviour
{
    public float pickUpRadius = 1f;
    public InventoryItemData itemData;

    private SphereCollider myCollider;

    private void Awake()
    {
        myCollider = GetComponent<SphereCollider>();
        myCollider.isTrigger = true;
        myCollider.radius = pickUpRadius;
    }

    private void OnTriggerEnter(Collider other)
    {
        var invertory = other.transform.GetComponent<InventoryHolder>();

        if (!invertory)
        {
            return;
        }

        if(invertory.InventorySystem.AddToInventory(itemData, 1))
        {
            Destroy(this.gameObject);
        }
    }
}
