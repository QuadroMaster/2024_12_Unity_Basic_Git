using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MoveByMouseObject : MonoBehaviour
{
    public Transform Target;
    public Camera Camera;
    
    void Update()
    {
        Vector3 screenToWorldPoint = Camera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);
        
        //screenToWorldPoint.x = Mathf.Ceil(screenToWorldPoint.x);
        //screenToWorldPoint.y = Mathf.Ceil(screenToWorldPoint.y);
        Target.position = new Vector3(screenToWorldPoint.x, Target.position.z);
        // https://docs.unity3d.com/ScriptReference/Mathf.Round.html
    }
}
