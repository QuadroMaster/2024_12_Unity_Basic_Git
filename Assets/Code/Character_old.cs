using UnityEngine;

namespace Code
{
    public class Character_old : MonoBehaviour
    {
        public bool IsDead;


        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
            IsDead = isActive;
        }
    }
}