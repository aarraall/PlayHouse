using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice2 : MonoBehaviour
{
    public Vector3[] vectors;
    int _randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        vectors = GetVectors();
        _randomIndex = GetRandom();

        StartCoroutine(SetPositions());
        
    }

    IEnumerator SetPositions()
    {
        yield return new WaitForSeconds(1f);
        transform.position = GetPositions(_randomIndex);
    }

    Vector3[] GetVectors()
    {
        for(int i = 0; i < vectors.Length; i++)
        {
            vectors[i] = new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
        }
        return vectors;
    }
    int GetRandom()
    {
        return _randomIndex = Random.Range(0, vectors.Length);
    }
    Vector3 GetPositions(int index)
    {
        return vectors[index];
    }
}
