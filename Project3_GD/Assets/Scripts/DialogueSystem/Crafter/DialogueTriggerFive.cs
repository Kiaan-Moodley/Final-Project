using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerFive : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialoguesys>().StartDialogue(dialogue);

    }
}
