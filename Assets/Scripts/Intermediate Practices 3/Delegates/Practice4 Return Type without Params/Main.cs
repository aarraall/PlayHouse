using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Practice4
{
    public class Main : MonoBehaviour
    {
        public Func<int> onGetName;
        private void Start()
        {
            onGetName = () => this.gameObject.name.Length;

            int characterCount = onGetName();

            Debug.Log("Character name count :" + characterCount);
        }
    }


}
