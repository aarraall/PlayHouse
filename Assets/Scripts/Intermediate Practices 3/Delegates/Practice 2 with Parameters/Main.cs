using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Practice2
{
    public class Main : MonoBehaviour
    {
        public Func<int, int, int> Sum;

        void Start()
        {
            Sum = (num1, num2) => num1 + num2;

            Debug.Log(Sum(3,5));
        }
    }
}
