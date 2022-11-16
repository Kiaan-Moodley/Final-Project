using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeD : MonoBehaviour
{
    public GameObject DBox;
    public void CloseFunc()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            DBox.SetActive(false);
        }
    }
}
