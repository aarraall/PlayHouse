using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.LINQ_Querys.Challenge2
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int id;
        public int buff;
    }
    public class LinqExample : MonoBehaviour
    {
        public List<Item> items;
        // Start is called before the first frame update
        void Start()
        {
            bool result = items.Any(item => item.id == 3);
            Debug.Log("If any item's id equals 3? : " + result);

            var result2 = items.Where(item => item.buff > 20);
            Debug.Log("Items that has buff more than 20 : " + result2);

            foreach (var item in items)
            {
                Debug.Log("Item name : " + item.name + " buff value : " + item.buff);
            }

            double result3 = items.Average(item => item.buff);

            Debug.Log("Average : " + result3);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
