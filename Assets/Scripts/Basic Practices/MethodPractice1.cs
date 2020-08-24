using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodPractice1 : MonoBehaviour
{
    public GameObject cube;
    public Color black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cube.GetComponent<MeshRenderer>().material.color = black;
        }
    }
}
