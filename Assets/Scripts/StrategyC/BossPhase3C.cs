using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase3C : BossPhaseC
{
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        transform.eulerAngles = new Vector3(1, 1, 1) * timer * 360;
    }
}
