using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    public GameObject spawne;
    float maxti;
    private float crt;

    void Start()
    {
        maxti = Random.Range(90f, 300f);
        crt = maxti;
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
            crt = maxti;
        }
    }

    void Spawn()
    {
        Instantiate(spawne, transform.position, transform.rotation);
    }
}

