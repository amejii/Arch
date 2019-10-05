using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour 
    where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance{
        get{
            if(_instance == null)
            {
                _instance = FindObjectOfType<T>();

                if(_instance == null)
                {
                    Debug.Log(string.Format("Can not find {0} !",typeof(T)));
                }
            }
            return _instance;
        }
    }
}
