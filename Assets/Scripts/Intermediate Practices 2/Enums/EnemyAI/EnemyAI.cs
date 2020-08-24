using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Enums.EnemyAI
{
    public class EnemyAI : MonoBehaviour
    {
        public enum EnemyState
        {
            Patrolling,
            Attacking, 
            Chasing,
            Dead
        }

        public EnemyState currentState;
        private void Update()
        {
            switch (currentState)
            {
                case EnemyState.Patrolling:
                    Debug.Log("Patrolling...");
                    if(Time.time > 5)
                    {
                        currentState = EnemyState.Chasing;
                    }
                    break;
                case EnemyState.Attacking:
                    Debug.Log("Attacking...");
                    break;
                case EnemyState.Chasing:
                    Debug.Log("Chasing...");
                    break;
                case EnemyState.Dead:
                    Debug.Log("Dead...");
                    break;


            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentState = EnemyState.Attacking;
            }
        }

    }

    
}

