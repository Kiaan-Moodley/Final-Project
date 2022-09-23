using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory inventory;

    [SerializeField]
    private UI_Inventory uiInventory;

    [SerializeField]
    public GameObject inventoryDisplay;


    private void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        //Used to spawn item of a specific type into the world (Manually)

        //ItemWorld.SpawnItemWorld(new Vector3(2, 0), new Item { itemType = Item.ItemType.Grass, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(3, 0), new Item { itemType = Item.ItemType.Mushroom, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(4, 0), new Item { itemType = Item.ItemType.Wood, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(5, 0), new Item { itemType = Item.ItemType.Wood, amount = 1 });
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (inventoryDisplay.activeInHierarchy == false)
            {
                inventoryDisplay.SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (inventoryDisplay.activeInHierarchy == true)
            {
                inventoryDisplay.SetActive(false);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ItemWorld itemWorld = other.GetComponent<ItemWorld>();

        if(itemWorld != null)
        {

            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf(); 
        }
    }
}

