using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByMouseObject : MonoBehaviour
{
    public Transform Target;
    public Camera Camera;

    private void Update()
    {
        Vector3 screenToWorldPoint = Camera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);
        
        //screenToWorldPoint.x = screenToWorldPoint.x;
        //screenToWorldPoint.y = screenToWorldPoint.y;
        Target.position = new Vector3(screenToWorldPoint.x, screenToWorldPoint.y, Target.position.z);
    }
}
