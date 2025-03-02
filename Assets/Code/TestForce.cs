using UnityEngine;

public class TestForce : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _pow;
    
    
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rigidbody.AddForce(Vector3.down * _pow);
    }
}
