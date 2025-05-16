using UnityEngine;


namespace Code
{
    public class RotateExampleScript : MonoBehaviour
    {
        public Transform Target;
        // Start is called before the first frame update
        void Start()
        {
            Vector3 pos = Target.position.normalized;
            float angle = Mathf.Acos(pos.z) * Mathf.Rad2Deg;
            Target.Rotate(Vector3.up, angle - Target.rotation.eulerAngles.y); // квартернионы всё это скрывают


            Vector3 newRotation = new Vector3(0.0f, 90.0f, 0.0f);
            Target.eulerAngles = newRotation; //1 способ
            Target.rotation = Quaternion.Euler(newRotation); //2 способ
            
            
            
        }

        private void Update()
        {
            
            RotationExampleThree();
        }
        
        private void RotationExampleThree()
        {
            transform.rotation = Quaternion.LookRotation(Target.position, Vector3.up); //1
            transform.LookAt(Target.position, Vector3.up); //2
        }

        private void RotationExampleFour()
        {
            Vector3 direction = Target.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 1);
        }
        
        
    }

    
}
