using UnityEngine;

namespace Code
{
    public class Character : MonoBehaviour
    {
        public bool IsDead;


        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
            IsDead = isActive;
        }
    }
}