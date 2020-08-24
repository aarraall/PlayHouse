using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.AbstractClasses.Interfaces
{
    public class Player : MonoBehaviour, IDamagable<int>
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            Health -= damageAmount;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}

