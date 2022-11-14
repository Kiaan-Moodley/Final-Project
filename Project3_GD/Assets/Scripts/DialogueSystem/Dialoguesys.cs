using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialoguesys : MonoBehaviour
{
    //https://www.youtube.com/watch?v=8oTYabhj248

    public TextMeshProUGUI textComponent;

    public string[] lines;
    public float textspeed;

    private int index;

     void Start()
    {
        textComponent.text = string.Empty;
        startDialogue();
    }

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                nextLIne();

            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }


    void startDialogue()
    {
        index = 0;
        StartCoroutine(typeLine());
    }

    IEnumerator typeLine()
    {
        //type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void nextLIne()
    {
        if(index <  lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(typeLine());
        }
    else
        {
            gameObject.SetActive(false);
        }
    }


}
