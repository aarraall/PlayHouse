using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.AbstractClasses.Interfaces
{
    public class Main : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if(Physics.Raycast(rayOrigin, out hitInfo))
                {
                    IDamagable<int> obj = hitInfo.collider.GetComponent<IDamagable<int>>();

                    if(obj != null)
                    {
                        obj.Damage(500);
                    }
                   
                }
            }
        }
    }
}

