using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerC : MonoBehaviour
{
    private static GameManagerC instance;
    public static GameManagerC Instance { get { return instance; } }
    public event Action<int> OnProgressionChanged;
    
    private float timer;
    private int progression;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
            timer = 0;
        }
    }
}
