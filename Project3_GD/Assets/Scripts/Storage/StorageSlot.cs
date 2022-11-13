using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageSlot : MonoBehaviour
{
    public Image icon;
    Item item;

    public Button AddButton;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;

        AddButton.interactable = true;
    }
    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;

        AddButton.interactable = false;
    }

    public void OnAddButton()
    {
        if (Inventory.instance.items.Count < 5)
        {
            Inventory.instance.Add(item);
            Storage.instance.Remove(item);
        }

    }
}
