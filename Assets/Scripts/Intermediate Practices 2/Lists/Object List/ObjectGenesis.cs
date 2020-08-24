using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenesis : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public List<GameObject> objectsCreated = new List<GameObject>();
    private int gameObjectIndex;

    private void Start()
    {
        gameObjectIndex = Random.Range(0, 2);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && objectsCreated.Count < 10)
        {
             GameObject spawnedObject = Instantiate(gameObjects[gameObjectIndex],
                 new Vector3(Random.Range(-10,10),Random.Range(-10,10), 0), 
                 Quaternion.identity);
            objectsCreated.Add(spawnedObject);

            if (objectsCreated.Count == 10)
            {
                foreach (GameObject createdObject in objectsCreated)
                {
                    createdObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    
                }
                objectsCreated.Clear();

            }
        } 
    }
}
