using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.Singleton.Challenge1
{
    public class Player : MonoBehaviour
    {
        private void Start()
        {
            UIManager.Instance.UpdateScore(40);
            SpawnManager.Instance.SpawnStarting();
        }
    }

}
