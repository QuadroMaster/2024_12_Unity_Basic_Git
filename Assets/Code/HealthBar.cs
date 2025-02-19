using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


namespace Code
{
    public class HealthBar : MonoBehaviour
    {
        public TMP_Text HealthText;
        public Slider Slider;
        public float Speed;
        
        public float CurrentHealth;
        public int MaxHealth;

        private int _minHealth = 0;
        private float _currentHealth;

        private void Update()
        {
            float currentHealth = Mathf.Clamp(CurrentHealth, _minHealth, MaxHealth); //смотрит, входит ли значение в
            //проомежуток от _minHealth до MaxHealth. Если нет, то все значения меньше _minHealth будет возвращать _minHealth,
            //а все значения больше MaxHealth будет возвращать MaxHealth
            _currentHealth = Mathf.Lerp(_currentHealth, currentHealth, Time.deltaTime * Speed); //Lerp - интерполяция ВАЖНО!!!!! ОЧЕНЬ!!!!!!


            HealthText.text = $"{currentHealth:#}";
            Slider.value = _currentHealth;
        }
    }
}

