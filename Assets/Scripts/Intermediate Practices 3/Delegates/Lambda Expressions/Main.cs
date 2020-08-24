using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.LambdaExpressions
{
    public class Main : MonoBehaviour
    {
        public Func<string, int> CharacterLength;

        private void Start()
        {
            CharacterLength = (name) => name.Length;
            int count = CharacterLength("Aral");

            Debug.Log("Length : " + count);
        }

        //int GetCharacters(string name)
        //{
        //    return name.Length;
        //}
    }


}
