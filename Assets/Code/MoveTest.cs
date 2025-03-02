using UnityEngine;

namespace DefaultNamespace
{
    public class MoveTest : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] private float _pow;


        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            _rigidbody.AddForce(Vector3.forward * (_pow * Time.fixedDeltaTime));
        }
    }
    

}

