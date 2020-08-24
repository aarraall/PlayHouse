using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.LINQ_Querys.Challenge1
{
    public class LinqExample : MonoBehaviour
    {
        public int[] grades = { 44, 55, 32, 77, 95, 95, 99, 88 };

        private void Start()
        {
            var passingGrades = grades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();
            foreach(var grade in passingGrades)
            {
                Debug.Log("Grade : " + grade);
            }
        }

    }
}
