using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject spawnee;

    void Start()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
    }

    void Update()
    {

    }
}
