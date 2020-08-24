using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Lists.ItemDatabase
{
    public class Player : MonoBehaviour
    {
        public Item[] inventory = new Item[10];

        private ItemDB itemDatabase;

        private void Start()
        {
            itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                itemDatabase.AddItem(0, this);
            }else if (Input.GetKeyDown(KeyCode.R))
            {
                itemDatabase.RemoveItem(0, this);
            }
        }
    }
}

