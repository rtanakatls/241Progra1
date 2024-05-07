using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementC : MonoBehaviour
{
    private void Start()
    {
        GameManagerC.Instance.OnProgressionChanged += Execute;
    }
    public void Execute(int progression)
    {
        transform.localScale = Vector3.one * progression;
    }
    private void OnDestroy()
    {
        GameManagerC.Instance.OnProgressionChanged -= Execute;
    }
}
