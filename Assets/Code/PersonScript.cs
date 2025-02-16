using UnityEngine;

namespace Code
{

    public class Person : MonoBehaviour
    {
        public int Hp = 100;
        public MeshRenderer Renderer;
        public bool IsEnemy = false;

        [SerializeField] private bool _isDeath = false;

        public void SetColor()
        {
            if (IsEnemy)
            {
                Renderer.material.color = Color.red;
            }
            else
            {
                Renderer.material.color = Color.blue;
            }
        }

        public void CheckDeath()
        {
            if (Hp <= 0) 
            {
                _isDeath = true;
                Hp = 0;
            }
        }

        public void Start()
        {
            Renderer.material.color = Color.grey; // У вас есть персонаж, который имеет изначально серый цвет
        }

        public void OnValidate()
        {
            SetColor();
            CheckDeath();
        }
    }
}