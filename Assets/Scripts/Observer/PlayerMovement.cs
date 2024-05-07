using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IObserver
{
    private void Start()
    {
        GameManager.Instance.Attach(this);
    }
    public void Execute(ISubject subject)
    {
        if(subject is GameManager)
        {
            GameManager gameManager = (GameManager)subject;
            transform.localScale=Vector3.one*gameManager.Progression;
        }
    }
    private void OnDestroy()
    {
        GameManager.Instance.Detach(this);
    }
}
