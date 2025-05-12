using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform TargetFirst;
    public Transform TargetSecond;

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

    // Update is called once per frame
    private void Example()
    {
        Vector3 firstPosition = TargetFirst.position;
        Vector3 secondPosition = TargetSecond.position;
        
        

        Transform primitive = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;

        primitive.position = firstPosition + secondPosition;

    }

    private void Update()
    {
        return;
        Move();
    }

    private void Move()
    {
        float directionVertical = 0.0f;
        float directionHorizontal = 0.0f;

        
        
        if (Input.GetKey(KeyCode.W))
        {
            directionVertical = 1.0f;
            Speed += 0.1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            directionVertical = -1.0f;
            Speed += 0.1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionHorizontal = -1.0f;
            Speed += 0.1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            directionHorizontal = 1.0f;
            Speed += 0.1f;
        }
        
        Vector3 targetFirstVertical = TargetFirst.forward * directionVertical;
        Vector3 targetFirstHorizontal = TargetSecond.right * directionHorizontal;
        
        
        TargetFirst.position += (targetFirstVertical + targetFirstHorizontal) * Speed * Time.deltaTime;
        
        
        

    }
}
