using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformWithClass : Movable
{
    // Update is called once per frame
    protected override void Update()
    {
        this.transform.position += transform.forward * Time.deltaTime;
    }
}
