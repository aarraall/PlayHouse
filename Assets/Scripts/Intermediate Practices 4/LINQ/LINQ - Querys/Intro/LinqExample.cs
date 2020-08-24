using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace IntermediatePractices4.LINQ_Querys.Intro
{
    public class LinqExample : MonoBehaviour
    {
        public string[] names = { "jon", "jon", "alex", "alex", "aral", "julie", "julie", "burak", "burak", "doğan", "mubarak","abdallah" };

        private void Start()
        {
            //bool nameFound = names.Any(name => name == "aral");
            //bool nameFound = names.Contains("Aral");
            //var uniqueNames = names.Distinct();

            IEnumerable result = names.Where(n => n.Length > 5);

            foreach(string name in result)
            {
                Debug.Log("Names : " + name);
            }
        }
    }
}


