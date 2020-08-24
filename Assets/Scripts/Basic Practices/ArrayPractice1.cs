using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice1 : MonoBehaviour
{
   
    public string[] kids = new string[5];
    public string[] ages = new string[5];
    public string[] cars = new string[5];

    public int randomID;
    // Start is called before the first frame update
    void Start()
    {
        randomID = Random.Range(0, kids.Length);
        print(" Name : " + kids[randomID] +
           " Age : " + ages[randomID] +
           " Favorite car : " + cars[randomID]);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
