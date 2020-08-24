using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Intermediate_Practices_4.Command_Pattern.Interfaces;
using UnityEngine;

namespace Intermediate_Practices_4.Command_Pattern.Managers
{
    public class CommandManager : MonoBehaviour
    {
        private static CommandManager _instance;

        public static CommandManager Instance()
        {
            if(_instance == null) 
                Debug.LogError("Command manager instance is null");
            return _instance;
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
        public void Play()
        {
            StartCoroutine(PlayRoutine());
        }
        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }
        public void Done()
        {
            var cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
        public void ResetSelection()
        {
            _commandBuffer.Clear();
        }
        IEnumerator PlayRoutine()
        {
            Debug.Log("Playing...");
            foreach (var command in _commandBuffer)
            {
                command.Execute();
                yield return new WaitForSeconds(1);
            }
        }
        IEnumerator RewindRoutine()
        {
            Debug.Log("Rewinding...");
            foreach (var command in Enumerable.Reverse(_commandBuffer))
            {
                command.Undue();
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
