using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mlayer : MonoBehaviour
{
    Color color;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            ColorChangerUtility.ChangeColor(this.gameObject, color);
        }
    }
}
