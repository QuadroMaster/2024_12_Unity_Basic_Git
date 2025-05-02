using UnityEngine;


namespace Code
{
    public class Player : MonoBehaviour
    {
        public Renderer Renderer;
        public bool IsDestroyLight;
        private void Awake()
        {
            Light light = transform.GetComponentInChildren<Light>();
            if (light != null)
            {
                if (IsDestroyLight)
                {
                    Destroy(light);
                }
                
                Color color = Random.ColorHSV();
                light.color = color;
                Renderer.material.color = color;
            }
        }
    }

}