using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerLife : MonoBehaviour
{
    private static PlayerLife instance;
    public static PlayerLife Instance { get {  return instance; } }

    [SerializeField] private int life;
    public event Action<int> OnLifeChanged;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            life--;
            OnLifeChanged?.Invoke(life);
        }
    }
}
