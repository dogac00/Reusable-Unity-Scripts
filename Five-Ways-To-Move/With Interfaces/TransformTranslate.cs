using UnityEngine;

public class TransformTranslate : MonoBehaviour, IMovable
{
    public void Move()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
