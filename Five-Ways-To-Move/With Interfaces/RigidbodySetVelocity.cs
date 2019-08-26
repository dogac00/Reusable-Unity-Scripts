using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor;
using UnityEngine;

public class RigidbodySetVelocity : MonoBehaviour, IMovable
{
    private float force = 5;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * Time.deltaTime * force;
    }

    public void Move() { }
}
