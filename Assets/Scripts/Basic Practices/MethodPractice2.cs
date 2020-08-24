using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodPractice2 : MonoBehaviour
{
    float damageAmount;
    public float health = 100f;
    private void Start()
    {
        damageAmount = Random.Range(10, 20);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            Damage(damageAmount);
        }   
    }
    private void Damage(float damageAmount)
    {
        health -= damageAmount;
        if(IsDead() == true)
        {
            Debug.Log("Player is dead");
        }
        else
        {
            Debug.Log("Player is alive and has" + health + "hp");
        }
    }
    private bool IsDead()
    {
        return health < 1;
    }
}
