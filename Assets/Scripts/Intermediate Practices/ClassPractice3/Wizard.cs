using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spells[] spells;
    public int level;
    public int exp;
    private void Start()
    {
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        }
    }
}
