using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject dialogueBox;
    public Talk the1;
    //public Dt2 d2;
   

    public void Interact()
    {


        the1.TriggerDialogue();
        dialogueBox.SetActive(true);


        //if(objectiveOne == false)
        //{
        //dialogue.TriggerDialogue();
        // dialogueBox.SetActive(true);
        //}

        //if (objectiveOne == true && objectiveTwo == false)
        //{
        //ialogueTwo.TriggerDialogue();
        //dialogueBox.SetActive(true);
        //}
    }
}
