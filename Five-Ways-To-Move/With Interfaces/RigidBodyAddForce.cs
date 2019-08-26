using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyAddForce : MonoBehaviour, IMovable
{
    public float Force = 5;
    private Rigidbody rb;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    public void Move()
    {
        rb.AddForce(transform.forward * Force);
    }
}
