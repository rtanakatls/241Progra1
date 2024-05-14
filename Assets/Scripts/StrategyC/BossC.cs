using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossC : MonoBehaviour
{
    [SerializeField] private List<BossPhaseC> bossPhases;
    private int progression;


    void Start()
    {
        ChangeBossPhase(0);
        GameManagerC.Instance.OnProgressionChanged += Execute;
    }

    void Execute(int progression)
    {
        if (progression >= 10 && this.progression != 10)
        {
            this.progression = 10;
            ChangeBossPhase(1);
        }
        if (progression >= 20 && this.progression != 20)
        {
            this.progression = 20;
            ChangeBossPhase(2);
        }
    }

    void ChangeBossPhase(int index)
    {
        foreach(BossPhaseC phase in bossPhases)
        {
            phase.enabled = false;
        }
        bossPhases[index].enabled = true;
    }



    private void OnDestroy()
    {
        GameManagerC.Instance.OnProgressionChanged -= Execute;
    }
}
