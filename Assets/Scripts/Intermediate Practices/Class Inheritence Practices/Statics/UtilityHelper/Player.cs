using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.Singleton.Intro
{
    public class Player : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UtilityHelper.CreateObject();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                UtilityHelper.SetPositionToZero(this.gameObject);
            }
        }
    }

}
