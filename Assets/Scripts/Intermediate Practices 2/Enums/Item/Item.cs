using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Enums.Item
{
    [System.Serializable]
    public class Item 
    {
        public string _name;
        public int id;
        public Sprite icon;
        public ItemType itemType;
        public enum ItemType
        {
            None,
            Weapon,
            Consumable
        }

        public void Action()
        {
            switch (itemType)
            {
                case ItemType.Weapon:
                    Debug.Log("This one is a : " + itemType);   
                    break;
                case ItemType.Consumable:
                    Debug.Log("This one is a : " + itemType);
                    break;
            }
        }
    }
}

