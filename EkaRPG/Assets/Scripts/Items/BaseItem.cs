using UnityEngine;
using System.Collections;

public class BaseItem {

    // root item class, variables that every item has

    private string itemName;
    private string itemDescription;
    private int itemID;

    public enum ItemTypes
    {
        WEAPON,
        EQUIPMENT,
        ITEM
    }

    private ItemTypes itemType;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}