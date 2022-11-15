using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject spawn;
    float maxtim;
    private float crt;

    void Start()
    {
        maxtim = Random.Range(60f, 200f);
        crt = maxtim;
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
            crt = maxtim;
        }
    }

    void Spawn()
    {
        Instantiate(spawn, transform.position, transform.rotation);
    }
}
