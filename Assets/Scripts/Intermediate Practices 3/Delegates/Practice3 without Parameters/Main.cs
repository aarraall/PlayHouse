using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Practice3
{
    public class Main : MonoBehaviour
    {
        public Action onGetName;

        // Start is called before the first frame update
        void Start()
        {
            onGetName = () => Debug.Log("Name : " + gameObject.name);
            onGetName();
        }
    }
}
