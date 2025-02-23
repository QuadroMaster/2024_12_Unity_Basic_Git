using UnityEngine;
using UnityEngine.UIElements;

namespace Code
{
    public class ExampleRandom : MonoBehaviour
    {
        private float _height;
        private float _speed;
        private float _startY;

        private void Start()
        {
            _height = Random.Range(0.5f, 1.5f);
            _speed = Random.Range(1f, 5.0f);
            _startY = transform.position.y;
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        private void Update()
        {
            Vector3 position = transform.position;
            
            float newY = _startY + _height + Mathf.Sin(Time.time * _speed);
            transform.position = new Vector3(position.x, newY, position.z);
        }
    }
}

