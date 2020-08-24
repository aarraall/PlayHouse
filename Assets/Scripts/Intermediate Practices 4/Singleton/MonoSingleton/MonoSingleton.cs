using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MonoSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;
    private static T Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError(typeof(T).ToString() + "Instance is null");
            }
            return _instance;
        }
        set
        {

        }
    }

    private void Awake()
    {
        _instance = this as T;
        Init();
    }

    public virtual void Init() { }
}
