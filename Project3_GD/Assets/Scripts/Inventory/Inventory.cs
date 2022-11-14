using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    void Awake()
    {
        if(instance = null)
        {
            Debug.LogWarning("More than one instance of inventory found");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangeCallBack;

    public List<Item> items = new List<Item>();

    public int space = 5;
    int counter = 0;

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Not enough room");
                return false;
            }
            items.Add(item);

            if(onItemChangeCallBack !=null)
                onItemChangeCallBack.Invoke();
        }
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
         
        if (onItemChangeCallBack != null)
            onItemChangeCallBack.Invoke();

    }
    public bool CheckItem()
    {
        if (items.Count < 5)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void RemoveFromInventory()
    {
        items.Clear();
    }

    // Mushroom Crafting check
    public void CheckMushrooms()
    {
        foreach (Item itm in items)
        {

            if (itm.ToString() == "MushroomTest (Item)")
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
        }
    }

    public bool CheckToMakeMushroomStew()
    {
        if (counter == 5)
        {
            counter = 0;
            return true;
        }
        else
        {
            //Debug.Log("");
            //Debug.Log(counter);
            counter = 0;
            return false;
        }
    }


    //Pot of Mushroom Stew
    public void CheckMushroomStew()
    {
        foreach (Item itm in items)
        {

            if (itm.ToString() == "MushroomStewTest (Item)")
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
        }
    }

 
    public bool CheckToMakePotOfMushroomStew()
    {
        if (counter == 5)
        {

            counter = 0;
            return true;
        }
        else
        {
            //Debug.Log("");
            //Debug.Log(counter);
            counter = 0;
            return false;
        }
    }



    // Wooden Plank Crafting check
    public void CheckWood()
    {
        foreach (Item itm in items)
        {

            if (itm.ToString() == "WoodTest (Item)")
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
        }
    }

    public bool CheckToMakeWoodenPlank()
    {
        if (counter == 5)
        {
            counter = 0;
            return true;
        }
        else
        {
            //Debug.Log("");
            //Debug.Log(counter);
            counter = 0;
            return false;
        }
    }

    public void CheckWoodenPlank()
    {
        foreach (Item itm in items)
        {

            if (itm.ToString() == "WoodPlankTest (Item)")
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
        }
    }


    public bool CheckToMakeWoodenLog()
    {
        if (counter == 5)
        {

            counter = 0;
            return true;
        }
        else
        {
            //Debug.Log("");
            //Debug.Log(counter);
            counter = 0;
            return false;
        }
    }
}
