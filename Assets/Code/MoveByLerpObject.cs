using UnityEngine;

public class MoveByLerpObject : MonoBehaviour
{
    public float Speed = 0.3f;
    public Transform StartPoint;
    public Transform EndPoint;
    public Transform Target;

    private void Start()
    {
        Target.position = StartPoint.position;
    }

    private void Update()
    {
        Target.position = Vector3.Lerp(Target.position, EndPoint.position, Time.deltaTime * Speed);
    }
    
}
