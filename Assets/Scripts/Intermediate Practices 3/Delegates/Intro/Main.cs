﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Intro
{
    public class Main : MonoBehaviour
    {
        public delegate void ChangeColor(Color newColor);
        public ChangeColor onColorChange;

        public delegate void OnComplete();
        public OnComplete onComplete;

        private void Start()
        {
            onColorChange = UpdateColor;
            onColorChange(Color.green);
            onComplete += Task;
            onComplete += Task2;
            onComplete += Task3;

            onComplete -= Task;
            onComplete -= Task2;
            onComplete -= Task3;

            if (onComplete != null)
                onComplete();


            onComplete();
        }
        public void UpdateColor(Color newColor)
        {
            Debug.Log("Changing color to : " + newColor.ToString());
        }
        public void Task()
        {
            Debug.Log("Task finished");
        }
        public void Task2()
        {
            Debug.Log("Task2 finished");
        }
        public void Task3()
        {
            Debug.Log("Task3 finished");
        }
    }
}

