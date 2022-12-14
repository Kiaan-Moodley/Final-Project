using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpawn : MonoBehaviour
{
    public GameObject spawnee;
    float maxt;
    private float crt;

    void Start()
    {
        maxt = Random.Range(120f, 400f);
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
