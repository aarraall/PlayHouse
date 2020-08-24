using System;
using System.Collections;
using System.Collections.Generic;
using Intermediate_Practices_4.Command_Pattern.Practice1.Interfaces;
using UnityEngine;
using System.Linq;

namespace Intermediate_Practices_4.Command_Pattern.Practice1.Managers
{
    public class CommandManager : MonoBehaviour
    {
        private static CommandManager _instance;

        public static CommandManager Instance
        {
            get
            {
                if (_instance != null)
                    Debug.LogError("Instance is null");
                return _instance;
            }
            set { }
        }

        private List<ICommand> _commandBuffer = new List<ICommand>();

        private void Awake()
        {
            _instance = this;
        }

        public void AddCommand(ICommand command)
        {
            _commandBuffer.Add(command);
        }

        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }

        IEnumerator RewindRoutine()
        {
            Debug.Log("Rewinding...");
            foreach (var command in Enumerable.Reverse(_commandBuffer))
            {
                command.Undue();
                yield return new WaitForEndOfFrame();
            }

            Debug.Log("Finished...");
        }

        public void Play()
        {
            StartCoroutine(PlayRoutine());
        }

        IEnumerator PlayRoutine()
        {
            Debug.Log("Playing...");
            foreach (var command in _commandBuffer)
            {
                command.Execute();
                yield return new WaitForEndOfFrame();
            }
        }

        public void Done()
        {
            GameObject.FindWithTag("Player").transform.position = Vector3.zero;
        }

        public void ResetSequence()
        {
            _commandBuffer.Clear();
        }
    }
}