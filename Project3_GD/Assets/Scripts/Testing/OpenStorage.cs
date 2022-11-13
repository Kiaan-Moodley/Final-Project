using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStorage : Interactable
{
    public GameObject storages;
    public Interactable inter;

    public override void Interact()
    {
        base.Interact();
        storages.SetActive(true);

    }
}
