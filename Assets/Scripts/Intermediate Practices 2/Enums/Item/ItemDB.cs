using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Enums.Item
{
    public class ItemDB : MonoBehaviour
    {
        public List<Item> itemDB = new List<Item>();


        private void Start()
        {
            itemDB[1].Action();
        }
    }
}

