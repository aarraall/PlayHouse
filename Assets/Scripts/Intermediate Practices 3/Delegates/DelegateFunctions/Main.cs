using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace IntermediatePractices3.Delegates.DelegateFunctions
{  
    public class Main : MonoBehaviour
    {
        //public delegate int CharacterLength(string text);
        //CharacterLength cl;

        public Func<string, int> CharacterLength;

        // Start is called before the first frame update
        void Start()
        {
            CharacterLength = GetCharacters;
            Debug.Log(CharacterLength("Aral"));
        }
        int GetCharacters(string name)
        {
            return name.Length;
        }
    }

}
