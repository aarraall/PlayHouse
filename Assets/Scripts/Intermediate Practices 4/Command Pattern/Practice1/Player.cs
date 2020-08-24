
using Intermediate_Practices_4.Command_Pattern.Practice1.Interfaces;
using Intermediate_Practices_4.Command_Pattern.Practice1.Managers;
using UnityEngine;

namespace Intermediate_Practices_4.Command_Pattern.Practice1
{
    public class Player : MonoBehaviour
    {
        private ICommand _moveUp, _moveDown, _moveLeft, _moveRight;
        [SerializeField]
        private float speed = 2.0f;

        private void Start()
        {
            _moveUp = new MoveUpCommand(this.transform, speed);
            _moveDown = new MoveDownCommand(this.transform,speed);
            _moveLeft = new MoveLeftCommand(this.transform,speed);
            _moveRight = new MoveRightCommand(this.transform,speed);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                //moveup
                _moveUp.Execute();
                CommandManager.Instance.AddCommand(_moveUp);

            }else if (Input.GetKey(KeyCode.S))
            {
                //move down
                _moveDown.Execute();
                CommandManager.Instance.AddCommand(_moveDown);
            }else if (Input.GetKey(KeyCode.A))
            {
                _moveLeft.Execute();
                CommandManager.Instance.AddCommand(_moveLeft);
                //move left
            }else if (Input.GetKey(KeyCode.D))
            {
                //move right
                _moveRight.Execute();
                CommandManager.Instance.AddCommand(_moveRight);
            }
        }
    }
}
