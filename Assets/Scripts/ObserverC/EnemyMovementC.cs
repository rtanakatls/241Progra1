using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementC : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    public void Execute(int progression)
    {
        speed = progression;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        GameManagerC.Instance.OnProgressionChanged += Execute;
    }


    void Update()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnDestroy()
    {
        GameManagerC.Instance.OnProgressionChanged -= Execute;
    }
}