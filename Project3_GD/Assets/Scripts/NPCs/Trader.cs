using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader : Interactable
{
    public GameObject dialogueBox;
    public DTriggerTrader d1;
    public Dt2 d2;
    public Dt3 d3;

    //public DialogueTrigger dialogue;

    public Item item;
    public Item itemTwo;
    public Item itemThree;

    public InventorySlot one;
    public InventorySlot two;
    public InventorySlot three;
    public InventorySlot four;
    public InventorySlot five;

    public override void Interact()
    {
        base.Interact();

        TalkingTo();
        TalkingToTwo();
        TalkingToThree();

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

    void TalkingTo()
    {

        bool hasFiveItems = Inventory.instance.CheckItem();

        if (hasFiveItems == true)
        {
            Inventory.instance.CheckMushrooms();

            if (Inventory.instance.CheckToMakeMushroomStew() == true)
            {
                Inventory.instance.RemoveFromInventory();

                one.ClearSlot();
                two.ClearSlot();
                three.ClearSlot();
                four.ClearSlot();
                five.ClearSlot();

                one.AddItem(item);
                Inventory.instance.Add(item);

                d1.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }

    void TalkingToTwo()
    {


        bool hasFiveItems = Inventory.instance.CheckItem();

        if (hasFiveItems == true)
        {
            Inventory.instance.CheckWood();

            if (Inventory.instance.CheckToMakeWoodenPlank() == true)
            {
                Inventory.instance.RemoveFromInventory();

                one.ClearSlot();
                two.ClearSlot();
                three.ClearSlot();
                four.ClearSlot();
                five.ClearSlot();

                one.AddItem(itemTwo);
                Inventory.instance.Add(itemTwo);

                d2.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }

    void TalkingToThree()
    {


        bool hasFiveItems = Inventory.instance.CheckItem();

        if (hasFiveItems == true)
        {
            Inventory.instance.CheckStone();

            if (Inventory.instance.CheckToMakeGravel() == true)
            {
                Inventory.instance.RemoveFromInventory();

                one.ClearSlot();
                two.ClearSlot();
                three.ClearSlot();
                four.ClearSlot();
                five.ClearSlot();

                one.AddItem(itemThree);
                Inventory.instance.Add(itemThree);

                d3.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }

}
