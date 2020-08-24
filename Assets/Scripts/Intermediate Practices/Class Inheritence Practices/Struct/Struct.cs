using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item2 // VALUE --- STACK
{
    public string name;
    public int itemID;

    public Item2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}
public class Items // REFERENCE --- HEAP
{
    public string itemName;
    public int _itemID;

    public Items(string itemName, int _itemID)
    {
        this.itemName = itemName;
        this._itemID = _itemID;
    }
}
public class Struct : MonoBehaviour
{
    Items sword = new Items("Sword", 1);

    Item2 bread;
    private void Start()
    {
        bread.name = "Bread";
        bread.itemID = 2;


        Debug.Log("Current bread name : " +  bread.name);
        ChangeValue(bread);
        Debug.Log("Bread name (after method) : " + bread.name);
    }
    void ChangeValue(Item2 structItem) //value type
    {
        structItem.name = "Dirty bread";
        Debug.Log(structItem.name);
    }

    protected void ChangeValue(Items classItem) //reference type
    {
        classItem.itemName = "Master Sword";
    }

   
}
