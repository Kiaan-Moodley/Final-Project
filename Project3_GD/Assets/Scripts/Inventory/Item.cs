using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item 
{
 public enum ItemType
    {
        Mushroom,
        Wood,
        Grass,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Mushroom: return ItemAssets.Instance.mushroomSprite;
            case ItemType.Grass: return ItemAssets.Instance.grassSprite;
            case ItemType.Wood: return ItemAssets.Instance.woodSprite;
        }
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.Mushroom: return false;
            case ItemType.Grass: return true;
            case ItemType.Wood: return true;
        }
    }

}
