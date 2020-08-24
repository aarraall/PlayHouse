using Intermediate_Practices_4.Command_Pattern.Interfaces;
using UnityEngine;

namespace Intermediate_Practices_4.Command_Pattern.Commands
{
    public class ClickCommand : ICommand
    {
        private GameObject _cube;
        private Color _color;
        private Color _previousColor;
        
        
        public ClickCommand(GameObject cube, Color color)
        {
            this._cube = cube;
            this._color = color;
        }
        public void Execute()
        {
            //change the color of the cube to random color 
            _previousColor = _cube.GetComponent<MeshRenderer>().material.color;
            _cube.GetComponent<MeshRenderer>().material.color = _color;
        }

        public void Undue()
        {
            _cube.GetComponent<MeshRenderer>().material.color = _previousColor;
        }
    }
}
