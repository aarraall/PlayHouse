using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IntermediatePractices2.Dictionary.UsingWPrimitives
{
    public class Main : MonoBehaviour
    {
        public Dictionary<int, string> books = new Dictionary<int, string>();
        private void Start()
        {
            books.Add(0, "Ultimate Guide to Game Development with Unity");
            books.Add(1, "Unity survival");
            books.Add(2, "Tanrıların Arabaları");

            foreach(KeyValuePair<int, string> book in books)
            {
                Debug.Log(book.Key + " " + book.Value);
            }
            
               
        }
    }
}

