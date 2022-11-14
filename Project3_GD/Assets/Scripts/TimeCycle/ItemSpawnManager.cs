using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnManager : MonoBehaviour
{
    public static ItemSpawnManager instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] GameObject itemspawn;


    public void SpawnItem(Vector3 position, Item item, int count)
    {
        GameObject obj = Instantiate(itemspawn, position, Quaternion.identity);
        obj.GetComponent<ItemPickUp>().Set(item, count);
    }
}
