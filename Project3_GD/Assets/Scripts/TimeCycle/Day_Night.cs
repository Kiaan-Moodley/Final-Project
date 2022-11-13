using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day_Night : MonoBehaviour
{
    const float sec= 86400f;

    [SerializeField] Color night;
    [SerializeField] Color day;
    [SerializeField] AnimationCurve nightCurve; 

    float time;
    [SerializeField] float timescale = 6000f;
    [SerializeField] new Light light;
    private int days;

    List<TimeAgent> agents;

    private void Awake()
    {
        agents = new List<TimeAgent>();
    }

    public void Subscribe(TimeAgent timeAgent)
    {
        agents.Add(timeAgent);
    }

    public void Unsubscribe(TimeAgent timeAgent)
    {
        agents.Remove(timeAgent);
    }

    float Hours
    {
        get { return time/3600f; }
    }

    private void Update()
    {
        time += Time.deltaTime * timescale;
        float v = nightCurve.Evaluate(Hours);
        Color c = Color.Lerp(day, night, v);
        light.color = c;
        if (time> sec)
        {
            NextDay();
        }
    }

    private void NextDay()
    {
        time = 0;
        days += 1;
    }
}
