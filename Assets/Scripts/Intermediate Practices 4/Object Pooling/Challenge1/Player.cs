using System.Collections;
using System.Collections.Generic;
using Intermediate_Practices_4.Object_Pooling.Challenge1;
using UnityEngine;

namespace IntermediatePractices4.ObjectPooling.Challenge1
{
    public class Player : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject bullet = PoolManager.Instance.RequestBullet();
                bullet.transform.position = Vector3.zero;
            }
        }
    }
}
