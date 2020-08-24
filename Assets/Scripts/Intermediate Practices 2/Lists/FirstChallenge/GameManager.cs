using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Lists
{
    public class GameManager : MonoBehaviour
    {
        public List<string> names = new List<string>();
        

        private void Start()
        {
            names.Add("Aral");
            names.Add("Burak");
            names.Add("Doğan");
            names.Add("Cöccu");
            names.Add("Culfa");

            foreach(string name in names)
            {
                print (name);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                names.Remove(names[Random.Range(0, names.Count)]);
                foreach(string name in names)
                {
                    print(name);
                }
            }
        }
    }
}

