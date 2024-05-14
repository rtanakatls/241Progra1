using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase2C : BossPhaseC
{
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            transform.localScale += Vector3.one;
            timer = 0;
        }
    }
}
