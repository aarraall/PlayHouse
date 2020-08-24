using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spells
{
    public string name;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;
    

    public Spells(string name, int levReq, int itemIdReq, int exp)
    {
        this.name = name;
        this.levelRequired = levReq;
        this.itemIdRequired = itemIdReq;
        this.expGained = exp;
    }

    public void Cast()
    {
        Debug.Log("Spell casted");


    }
}
