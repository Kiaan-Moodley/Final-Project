using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInventoryButton : MonoBehaviour
{
    public GameObject storage;
    public void CloseInventory()
    {
        storage.SetActive(false);
    }
}
