
using UnityEngine;

namespace Code
{
    public class Character2 : MonoBehaviour
    {
        public MeshRenderer Renderer;

        public void SetColor(Color color)
        {
            Renderer.material.color = color;
        }
        
        
        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
        }
    }
}

