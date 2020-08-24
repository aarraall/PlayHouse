using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.AbstractClasses.Interfaces
{
    public class Enemy : MonoBehaviour, IDamagable<float>, Shoot
    {
        public int Health { get; set; }

        public void Damage(float damageAmount)
        {          
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        public void Shoot() 
        {
        
        }
    }
}

