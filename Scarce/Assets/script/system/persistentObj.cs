using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistentObj : MonoBehaviour
{
    [SerializeField]
    bool ok;
    private void Start()
    {

        if (ok)
        {
            GameObject.DontDestroyOnLoad(this);
        }
    }
}
