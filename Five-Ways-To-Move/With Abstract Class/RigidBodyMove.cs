using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMove : Movable
{
    private float force = 5;
    private Rigidbody rb;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        rb.AddForce(transform.forward * force);
    }
}
