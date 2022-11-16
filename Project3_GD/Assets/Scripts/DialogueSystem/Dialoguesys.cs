using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Dialoguesys : MonoBehaviour
{
    /*https://www.youtube.com/watch?v=8oTYabhj248

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
    *
    *
    *
    *
    private Queue<string> sentences;
    public GameObject Panel;
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI DialogueTxt;

    private void Start()
    {
        sentences = new Queue<string>();
        nameTxt = GetComponent<TextMeshProUGUI>();
        DialogueTxt = GetComponent<TextMeshProUGUI>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Panel.SetActive(true);
        Debug.Log("Starting convo with ");
        nameTxt.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        DialogueTxt.text = sentence;
    }

    public void EndDialogue()
    {
        Panel.SetActive(false);
        Debug.Log("end convo");
    }
}
*/

    public Queue<string> Sentences;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    void Start()
    {
        Sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        Sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            Sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = Sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
}
