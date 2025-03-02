using System;
using UnityEngine;

namespace Code
{
    public class PhysicsTest : MonoBehaviour
    {
        [SerializeField] private float _pow = 10;
        private void Start()
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * _pow, ForceMode.Impulse);
        }

        
    }
    
}
