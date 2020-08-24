using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.Singleton.Challenge1
{
    public class SpawnManager : MonoBehaviour
    {
        private static SpawnManager _instance;
        public static SpawnManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("SpawnManager is null");
                return _instance;
            }

        }
        private void Awake()
        {
            _instance = this;
        }

        public void SpawnStarting()
        {
            Debug.Log("Spawning started");
        }
    }
}
