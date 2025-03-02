using System.Collections.Generic;
using UnityEngine;

public class PhysicsTestBoxCollider : MonoBehaviour
{
    
    private List<Rigidbody> _rigidbodies = new();
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out var rigidbody))
        {
            rigidbody.isKinematic = true;
            _rigidbodies.Add(rigidbody);
        }
    }

    private void OnDisable()
    {
        foreach (var rigidbody in _rigidbodies)
        {
            rigidbody.isKinematic = false;
        }
    }
}
