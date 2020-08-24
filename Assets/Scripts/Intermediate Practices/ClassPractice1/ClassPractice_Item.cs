using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClassPractice_Item : MonoBehaviour
{
    public string _name;
    public int id;
    public string description;
    public Sprite icon;

    public ClassPractice_Item(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }

    

}
