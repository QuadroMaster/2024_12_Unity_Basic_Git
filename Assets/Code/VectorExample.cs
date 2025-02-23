using System;
using UnityEngine;


namespace Code
{
    public class VectorExample : MonoBehaviour
    {
        
        
        public Transform TargetFirst;
        public Transform TargetSecond;

        public float Dot;
        public float Speed = 3.0f;
        void Start()
        {
            Vector2 vector2 = new Vector2(1, 2);
            Vector3 vector3 = new Vector3(1, 2, 3);
            Vector4 vector4 = new Vector4(1, 2, 3, 4);
            Vector2Int vector2Int = new Vector2Int(1, 2);
            Vector3Int vector3Int = new Vector3Int(1, 2, 3);
            
            Example();
            
        }

        private void Update()
        {
            Dot = Vector3.Dot(TargetFirst.forward, TargetSecond.position);
            return;
            Move();
        }

        private void Example()
        {
            Vector3 firstPosition = TargetFirst.position;
            Vector3 secondPosition = TargetSecond.position;
    
            Transform primitive = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
            
            primitive.position = firstPosition + secondPosition;
            primitive!.position *= 5.0f;
        }

        private void Move()
        {
            float directionVertical = 0.0f;
            float directionHorizontal = 0.0f;

            if (Input.GetKey(KeyCode.W))
            {
                directionVertical = 1.0f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                directionVertical = -1.0f;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                directionHorizontal = -1.0f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                directionHorizontal = 1.0f;
            }

            Vector3 targetFirstVertical = TargetFirst.forward * directionVertical;
            Vector3 targetFirstHorizontal = TargetSecond.right * directionHorizontal;
            
            
            TargetFirst.position += (targetFirstVertical + targetFirstHorizontal) * Time.deltaTime * Speed;

        }
        
    }
}

