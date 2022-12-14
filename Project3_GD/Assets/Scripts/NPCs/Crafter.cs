using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : Interactable
{

    public GameObject dialogueBox;

    public DialogueTrigger dialogue;
    public DialogueTriggerTwo dialogueTwo;
    public DialogueTriggerThree dialogueThree;
    public DialogueTriggerFour dialogueFour;
    public DialogueTriggerFive dialogueFive;
    public DialogueTriggerSix dialogueSix;

    public Item item;
    public Item itemTwo;
    public Item itemThree;
    public Item itemFour;
    public Item itemFive;
    public Item itemSix;

    public InventorySlot one;
    public InventorySlot two;
    public InventorySlot three;
    public InventorySlot four;
    public InventorySlot five;

    /*private bool objectiveOne = false;
    private bool objectiveTwo = false;
    private bool objectiveThree = false;
    private bool objectiveFour = false;
    private bool objectiveFive = false;
    private bool objectiveSix = false;
    private bool objectiveSeven = false;
    private bool objectiveEight = false;*/


    public override void Interact()
    {
        base.Interact();

            TalkingTo();
            TalkingToTwo();
            TalkingToThree();
            TalkingToFour();
            TalkingToFive();
            TalkingToSix();

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

                dialogue.TriggerDialogue();
                dialogueBox.SetActive(true);

            }


        }

    }

    void TalkingToTwo()
    {

        bool hasFiveItems = Inventory.instance.CheckItem();

        if (hasFiveItems == true)
        {
            Inventory.instance.CheckMushroomStew();

            if (Inventory.instance.CheckToMakePotOfMushroomStew() == true)
            {
                Inventory.instance.RemoveFromInventory();

                one.ClearSlot();
                two.ClearSlot();
                three.ClearSlot();
                four.ClearSlot();
                five.ClearSlot();

                one.AddItem(itemTwo);
                Inventory.instance.Add(itemTwo);

                dialogueTwo.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }

    void TalkingToThree()
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

                one.AddItem(itemThree);
                Inventory.instance.Add(itemThree);

                //objectiveOne = true;
               // objectiveTwo = false;

                dialogueThree.TriggerDialogue();
                dialogueBox.SetActive(true);

            }



        }

    }

    void TalkingToFour()
    {

        bool hasFiveItems = Inventory.instance.CheckItem();

        if (hasFiveItems == true)
        {
            Inventory.instance.CheckWoodenPlank();

            if (Inventory.instance.CheckToMakeWoodenLog() == true)
            {
                Inventory.instance.RemoveFromInventory();

                one.ClearSlot();
                two.ClearSlot();
                three.ClearSlot();
                four.ClearSlot();
                five.ClearSlot();

                one.AddItem(itemFour);
                Inventory.instance.Add(itemFour);

                dialogueFour.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }

    void TalkingToFive()
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

                one.AddItem(itemFive);
                Inventory.instance.Add(itemFive);

                dialogueFive.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }

    void TalkingToSix()
    {

        bool hasFiveItems = Inventory.instance.CheckItem();

        if (hasFiveItems == true)
        {
            Inventory.instance.CheckGravel();

            if (Inventory.instance.CheckToMakeCement() == true)
            {
                Inventory.instance.RemoveFromInventory();

                one.ClearSlot();
                two.ClearSlot();
                three.ClearSlot();
                four.ClearSlot();
                five.ClearSlot();

                one.AddItem(itemSix);
                Inventory.instance.Add(itemSix);

                dialogueSix.TriggerDialogue();
                dialogueBox.SetActive(true);
            }


        }

    }
}

