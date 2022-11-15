using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpawn : MonoBehaviour
{
    public GameObject spawnee;
    private float maxt = 10f;
    private float crt;

    void Start()
    {
        crt = maxt;
    }

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (crt > 0)
        {
            crt -= Time.deltaTime;
        }
        else
        {
            Spawn();
            crt = maxt;
        }
    }

    void Spawn()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
    }
}
