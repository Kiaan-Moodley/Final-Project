using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageUI : MonoBehaviour
{
    public Transform itemsParent;

    Storage storage;

    public GameObject storageUI;

    StorageSlot[] slots;

    void Start()
    {
        storage = Storage.instance;
        storage.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<StorageSlot>();
    }


    void Update()
    {

        //storageUI.SetActive(!storageUI.activeSelf);

    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < storage.items.Count)
            {
                slots[i].AddItem(storage.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }

        }

    }
}
