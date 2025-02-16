using UnityEngine;

namespace Code
{
    public class DamageDealer: MonoBehaviour
    {
        public int IntDamage = 24;
        public float FloatDamage = 1.9f;
        public int Multiplier = 0;
        
        private int _intVariable = 65578;
        private float _floatVariable = 1.2f;
        private bool _boolVariable = true;
        private void Start()
        {
            DamageCalculation(IntDamage, FloatDamage, Multiplier);
        }
        private void Awake()
        {
            Debug.LogError($"Переменная с типом int имеет значение {_intVariable}");
            Debug.LogError($"Переменная с типом float имеет значение {_floatVariable}");
            Debug.LogError($"Переменная с типом bool имеет значение {_boolVariable}");
        }
        private void DamageCalculation(int damageInt, float damageFloat, int multiplition)
        {
            float baseDamage = damageInt + damageFloat;
            float damage = baseDamage * multiplition;

            Debug.Log($"Нанесено {damage} урона");
        }
    }
}
