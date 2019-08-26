using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private IMovable _movable;

    // Start is called before the first frame update
    void Start()
    {
        _movable = this.GetComponent<IMovable>();
    }

    // Update is called once per frame
    void Update()
    {
        _movable.Move();
    }
}
