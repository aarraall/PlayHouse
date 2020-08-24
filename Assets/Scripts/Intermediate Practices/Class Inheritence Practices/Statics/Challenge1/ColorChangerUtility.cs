using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorChangerUtility
{
    public static void ChangeColor(GameObject obj, Color color)
    {      
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}
