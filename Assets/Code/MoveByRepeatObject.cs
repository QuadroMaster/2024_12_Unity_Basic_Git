using Unity.VisualScripting;
using UnityEngine;


namespace Code
{
    public class MoveByRepeatObject : MonoBehaviour
    {
        public float Length = 3.0f;

        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }
        
        
        private void Update()
        {
            float x = Mathf.PingPong(Time.time, Length);
            float y = Mathf.Repeat(Time.time, Length);
            
            //transform.position.x = new Vector3(x, 0, transform.position.z);
            
            //Vector3 position = _transform.position;
            
            _transform.position = new Vector3(x, y, transform.position.z);
            
            
        }
    }

    
    
}
