using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase1 : IBossStrategy
{
    private float timer;
    private Vector3 direction;
    private Rigidbody rb;

    public BossPhase1(Rigidbody rb)
    {
        this.rb = rb;
        direction = rb.transform.forward;
    }

    public void Execute()
    {
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            direction *= -1;
            timer = 0;
        }
        rb.velocity=direction * 10;
    }
}
