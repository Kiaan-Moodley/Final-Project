using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : Interactable
{
    public Item item;
    public Item itemTwo;
    //public Item itemThree;
    //public Item itemFour;

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
            }


        }

    }
}

