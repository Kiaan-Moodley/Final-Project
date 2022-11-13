
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;

    public GameObject storage;
    public Storage slot;

    public Button removeButton;
    public Button AddButton;

    Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;

        removeButton.interactable = true;
        AddButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;

        removeButton.interactable = false;
        AddButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use(); 
        }
    }

    public void OnAddButton()
    {
        if (storage.activeSelf == true && slot.items.Count<15)
        {
            Storage.instance.Add(item);
            Inventory.instance.Remove(item);
        }

    }
}
