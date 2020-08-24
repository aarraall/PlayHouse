using Intermediate_Practices_4.Command_Pattern.Commands;
using Intermediate_Practices_4.Command_Pattern.Interfaces;
using Intermediate_Practices_4.Command_Pattern.Managers;
using UnityEngine;


namespace Intermediate_Practices_4.Command_Pattern.Intro
{
    public class UserInput : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(rayOrigin, out RaycastHit hitInfo))
                {
                    if (hitInfo.collider.CompareTag("Cube"))
                    {
                        ICommand click = new ClickCommand(hitInfo.collider.gameObject,
                            new Color(Random.value, Random.value, Random.value));
                        click.Execute();
                        CommandManager.Instance().AddCommand(click);
                    }
                }
            }
        }
    }
}