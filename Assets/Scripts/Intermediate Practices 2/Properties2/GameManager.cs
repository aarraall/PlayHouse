using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Properties.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public float Speed { get; private set; }
        public string Name { get; set; }
        // Start is called before the first frame update
        void Start()
        {
            Speed = 101f;
            Debug.Log(Speed);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
