using UnityEngine;

namespace Code
{
    public class MoveByRepeatObject : MonoBehaviour
    {
        public float Length = 3.0f;
        private void Update()
        {
            float x = Mathf.PingPong(Time.time, Length);
            float y = Mathf.Repeat(Time.time, Length);
            //transform.position.x = x;
            
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}