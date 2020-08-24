using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_
{
    public string _name;
    public int itemID;

    public static int itemCount;

    public Item_()
    {
        itemCount++;
    }

}
public class Jest : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Item_ sword = new Item_();
        Item_ bread = new Item_();
        Item_ cape = new Item_();
        Item_ fish = new Item_();

        Debug.Log(Item_.itemCount);
    }
}
