using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour
{
    [SerializeField] Item toSpawn;
    [SerializeField] int count;
    [SerializeField] float spread = 2f;
    [SerializeField] float prob = 0.5f;
    void Spawn()
    {
        if (UnityEngine.Random.value < prob)
        {
            Vector3 position = transform.position;
            position.x += spread * UnityEngine.Random.value - spread / 2;
            position.y += spread * UnityEngine.Random.value - spread / 2;
            //ItemSpawnManager.instance.SpawnItem(position, toSpawn, count);
        }
    }
}
