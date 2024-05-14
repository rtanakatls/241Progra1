using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private IBossStrategy bossStrategy; 
    private int progression;
    

    void Start()
    {
        bossStrategy = new BossPhase1(GetComponent<Rigidbody>());
        GameManagerC.Instance.OnProgressionChanged += Execute;
    }

    void Execute(int progression)
    {
        if (progression >= 10 && this.progression != 10)
        {
            this.progression = 10;
            bossStrategy = new BossPhase2(transform);
        }
        if (progression >= 20 && this.progression != 20)
        {
            this.progression = 20;
            bossStrategy = new BossPhase3(transform);
        }
    }


    void Update()
    {
        bossStrategy.Execute();
    }

    private void OnDestroy()
    {
        GameManagerC.Instance.OnProgressionChanged -= Execute;
    }
}
