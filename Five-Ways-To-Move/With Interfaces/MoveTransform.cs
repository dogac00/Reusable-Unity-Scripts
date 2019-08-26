using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour, IMovable
{
    public void Move()
    {
        this.transform.position += transform.forward * Time.deltaTime;
    }
}
