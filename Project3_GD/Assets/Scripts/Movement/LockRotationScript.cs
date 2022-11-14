using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotationScript : MonoBehaviour
{
    public Transform child;

    void Update()
    {
        child.transform.rotation = Quaternion.Euler(55f, 180f, gameObject.transform.rotation.z * -1.0f);
    }
}
