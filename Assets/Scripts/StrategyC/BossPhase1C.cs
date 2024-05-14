using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase1C : BossPhaseC
{
    private float timer;
    private Vector3 direction;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        direction = rb.transform.forward;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            direction *= -1;
            timer = 0;
        }
        rb.velocity = direction * 10;
    }
}
