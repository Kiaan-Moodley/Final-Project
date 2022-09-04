using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot 
{
    [SerializeField]
    private InventoryItemData itemData;

    [SerializeField]
    private int stackSize;

    public InventoryItemData ItemData => itemData;

    public int StackSize => stackSize;

    public InventorySlot(InventoryItemData source, int amount)
    {
        itemData = source;
        stackSize = amount;
    }

    public InventorySlot()
    {
        ClearSlot();
    }

    //Clearing the said item in the item slot
    public void ClearSlot()
    {
        itemData = null;
        stackSize = -1;
    }

    public void UpdateInventorySlot(InventoryItemData data, int amount)
    {
        itemData = data;
        stackSize = amount;
    }

    public bool RoomLeftInStack(int amountToAdd, out int amountRemaining)
    {
        amountRemaining = ItemData.MaxStacksSize - stackSize;

        return RoomLeftInStack(amountToAdd);
    }

    public bool RoomLeftInStack(int amountToAdd)
    {
        if(stackSize + amountToAdd <= itemData.MaxStacksSize)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Add the same item to the total item stack
    public void AddToStack(int amount)
    {
        stackSize += amount;
    }

    //Remove the same item to the total item stack
    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
    }
}
