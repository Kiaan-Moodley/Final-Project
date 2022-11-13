using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TimeAgent : MonoBehaviour
{
    public Action onTimeTick;

    private void Start()
    {
        Manager.instance.timeController.Subscribe(this);
    }

    public void Invoke()
    {
        onTimeTick?.Invoke();
    }

    private void OnDestroy()
    {
        Manager.instance.timeController.Unsubscribe(this);
    }
}
