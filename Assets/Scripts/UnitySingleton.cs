using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitySingleton : MonoBehaviour
{
    public static UnitySingleton Instance { get; private set; } 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
