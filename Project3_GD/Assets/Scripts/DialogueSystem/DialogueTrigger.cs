using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue1;
    public Dialogue dialogue2;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialoguesys>().StartDialogue(dialogue1);

    }

    public void TriggerDialogue2()
    {
        FindObjectOfType<Dialoguesys>().StartDialogue(dialogue2);
    }
}
