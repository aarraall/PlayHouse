using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace IntermediatePractices4.LINQ_Querys.SyntaxTest
{
    public class SyntaxTest : MonoBehaviour
    {
        public int[] scores = new int[] { 97, 92, 81, 60, 120, 30 };
        // Start is called before the first frame update
        void Start()
        {
            var scoreQuery = scores.Where(score => score > 80).OrderByDescending(score=>score).Reverse();

            foreach(var score in scoreQuery)
            {
                Debug.Log("Score : " + score);
            }
        }
    }
}
