using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour, IObserver
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    public void Execute(ISubject subject)
    {
        if(subject is GameManager)
        {
            GameManager gameManager = (GameManager)subject;
            speed = gameManager.Progression;
        }
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        GameManager.Instance.Attach(this);
    }


    void Update()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnDestroy()
    {
        GameManager.Instance.Detach(this);
    }
}