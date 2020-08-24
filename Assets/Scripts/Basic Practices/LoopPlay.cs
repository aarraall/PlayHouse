using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPlay : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {

        maxSpeed = Random.Range(60, 120);
        
        StartCoroutine(IncreaseEachSecs());
        
    }

    IEnumerator IncreaseEachSecs()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
            speed += 5;
            Debug.Log("speed is" + speed + "and max Speed is" + maxSpeed);

            if (speed >= maxSpeed)
            {
                speed = maxSpeed;
                Debug.Log("You've reached to max speed");
                break;                
            }
        }
        
    }
}
