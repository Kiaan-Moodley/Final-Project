using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> itemList;

    public event EventHandler OnItemChangedList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Mushroom, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Grass, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Wood, amount = 1 });


    }

    public void AddItem(Item item) 
    {
        if (item.IsStackable())
        {
            bool itemAlreadyInInventory = false;

            foreach(Item inventoryItem in itemList)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += item.amount;
                    itemAlreadyInInventory = true;
                }
            }
            if (!itemAlreadyInInventory)
            {
                itemList.Add(item);
            }
        }
        else
        {
            itemList.Add(item);
        }

       
        OnItemChangedList?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }

}
