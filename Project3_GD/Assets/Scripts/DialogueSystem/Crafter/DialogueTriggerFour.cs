using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerFour : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialoguesys>().StartDialogue(dialogue);

    }
}
