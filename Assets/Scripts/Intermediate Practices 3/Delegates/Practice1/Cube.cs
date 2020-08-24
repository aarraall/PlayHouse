using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.Delegates.Practice1
{
    public class Cube : MonoBehaviour
    {
        private void Start()
        {
            Main.onTeleport += Spawn;
        }
        public void Spawn(Vector3 pos)
        {
            transform.position = pos;
        }

        private void OnDisable()
        {
            Main.onTeleport -= Spawn;
        }
    }
}

