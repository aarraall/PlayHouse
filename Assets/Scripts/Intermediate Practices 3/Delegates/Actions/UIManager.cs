using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Actions 
{
    public class UIManager : MonoBehaviour
    {
        private void OnEnable()
        {
            Player.onDamageReceived += UpdateHealth;
        }
        public void UpdateHealth(int health)
        {
            Debug.Log("Current health : " + health);
        }
    }
}
