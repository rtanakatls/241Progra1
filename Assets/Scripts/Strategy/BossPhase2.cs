using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase2 : IBossStrategy
{
    private float timer;
    private Transform transform;

    public BossPhase2(Transform transform)
    {
        this.transform = transform;
    }

    public void Execute()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            transform.localScale += Vector3.one;
            timer = 0;
        }
    }
}
