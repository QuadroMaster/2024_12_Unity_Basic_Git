using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Code
{
    public class DamageDealer: MonoBehaviour
    {

        
        private int intVariable = 65578;
        private float floatVariable = 1.2f;
        private bool boolVariable = true;
        
        
        
        
        public int int_damage = 24;
        public float float_damage = 1.9f;
        public int multiplier = 0;


        
        private void OnValidate()
        {
            DamageCalculation(int_damage, float_damage, multiplier);

            
        }

        private void Start()
        {
            Debug.LogError($"Переменная с типом int имеет значение {intVariable}");
            Debug.LogError($"Переменная с типом float имеет значение {floatVariable}");
            Debug.LogError($"Переменная с типом bool имеет значение {boolVariable}");
        }

        private void Update()
        {
                    
        }

        private void DamageCalculation(int int_damage, float float_damage, int multiplier)
        {

            if (multiplier == 0)
            {
                
            }

            else
            {

                float baseDamage = int_damage + float_damage;

                float damage = baseDamage * multiplier;

                Debug.Log($"Нанесено {damage} урона");
            }
        }
        
        
        
    }

        
        
        

       
}
      
    
