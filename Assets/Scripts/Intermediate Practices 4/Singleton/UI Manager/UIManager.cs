using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.Singleton.Challenge1
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance;

        public static UIManager Instance
        {
            get
            {
                if (_instance = null)
                {
                    Debug.LogError("UI Manager is null");
                }
                return _instance;
            }
            set
            {

            }
        }

        private void Awake()
        {
            _instance = this;
        }

        public void UpdateScore(int score)
        {
            Debug.Log("Score: " + score);
            Debug.Log("Notifying Game Manager");
            GameManager.Instance.DisplayName();
        }
    }
}
