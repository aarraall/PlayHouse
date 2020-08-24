using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Dictionary.Intro
{
    public class ItemDB : MonoBehaviour
    {
        public Dictionary<int,Item> itemDictionary = new Dictionary<int,Item>();

        private void Start()
        {
            Item sword = new Item();
            sword.name = "Sword";
            sword.id = 0;
            itemDictionary.Add(sword.id, sword);

            Item cape = new Item();
            cape.name = "Cape";
            cape.id = 1;
            itemDictionary.Add(cape.id, cape);
            
            Item bread = new Item();
            bread.name = "Cape";
            bread.id = 2;
            itemDictionary.Add(bread.id, bread);


            foreach (KeyValuePair<int,Item> item in itemDictionary)
            {
                Debug.Log("Item name is " + item.Value.name + " Item key is " + item.Key);
            }
        }
    }

}
