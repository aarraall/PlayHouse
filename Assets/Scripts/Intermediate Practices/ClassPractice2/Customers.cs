using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customers
{
    public string customer_name;
    public int customer_id;
    public int age;
    public string item_name;
    public int item_id;
    public string item_description;
    public Customers(string _name, int _id, int _age, string _item_name, int _item_id, string _item_description)
    {
        this.customer_name = _name;
        this.customer_id = _id;
        this.age = _age;
        this.item_name = _item_name;
        this.item_id = _item_id;
        this.item_description = _item_description;

    }
}
