using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IntermediatePractices3.Delegates.Actions
{
    public class Player : MonoBehaviour
    {
        public static Action<int> onDamageReceived;
        public int Health { get; set; }
        // Start is called before the first frame update
        void Start()
        {
            Health = 10;
        }

        void Damage()
        {
            Health--;
            if(onDamageReceived != null)
            {
                onDamageReceived(Health);
            }
        }
    }

}
