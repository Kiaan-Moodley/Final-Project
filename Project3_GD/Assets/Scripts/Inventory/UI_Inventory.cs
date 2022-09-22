using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;

    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    public void Awake()
    {
        itemSlotContainer = transform.Find("ItemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("ItemSlotTemplate"); 
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;

        inventory.OnItemChangedList += Inventory_OnItemListChanged; 
        RefreshItems(); 

    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
    {
        RefreshItems();
    }

    private void RefreshItems()
    {
        foreach(Transform child in itemSlotContainer)
        {
            if (child == itemSlotTemplate) continue;
            Destroy(child.gameObject);
        }


        int x = 0;
        int y = 0;
        float itemSlotCellSize = 100f;

        foreach(Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();

            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();

            TextMeshProUGUI uiText = itemSlotRectTransform.Find("text").GetComponent<TextMeshProUGUI>();
            if (item.amount > 1)
            {
                uiText.SetText(item.amount.ToString());
            }
            else
            {
                uiText.SetText("");
            }
            x++;

            if (x > 2) 
            {
                x = 0;
                y--;
            }
        }

    }
}
