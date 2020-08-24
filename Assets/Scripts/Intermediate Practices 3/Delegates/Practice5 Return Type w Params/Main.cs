using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Practice5
{
    public class Main : MonoBehaviour
    {
        public Func<int, int, int> onCalculateSum;

        private void Start()
        {
            onCalculateSum = (num1, num2) => num1 + num2;
            Debug.Log(onCalculateSum(3, 5));
        }
    }
}

