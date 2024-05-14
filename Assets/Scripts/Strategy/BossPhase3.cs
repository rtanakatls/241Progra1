using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase3 : IBossStrategy
{
    private float timer;
    private Transform transform;

    public BossPhase3(Transform transform)
    {
        this.transform = transform;
    }

    public void Execute()
    {
        timer += Time.deltaTime;
        transform.eulerAngles = new Vector3(1, 1, 1) * timer * 360;
    }
}
