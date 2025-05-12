using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Code
{
    public class HealthBar : MonoBehaviour
    {
        // Start is called before the first frame update
      
            public Vector2Int MinAndMaxHealth = new Vector2Int(0, 100);
            public TMP_Text HealthText;
            public Slider Slider;
            public float Speed;
            
            public float CurrentHealth;
            public int MaxHealth;

            private int _minHealth = 0;
            private float _currentHealth;


            private void Start()
            {
                Slider.maxValue = MaxHealth;  //MinAndMaxHealth.x
                Slider.minValue = _minHealth; //MinAndMaxHealth.y
            }

            private int _a = 0;
            private int _b = 5;
            
            // Update is called once per frame
        void Update()
        {
            float currentHealth = Mathf.Clamp(CurrentHealth, _minHealth, MaxHealth);
            _currentHealth = Mathf.Lerp(_currentHealth, currentHealth, Time.deltaTime * Speed);
            
            HealthText.text = $"{currentHealth:#}";
            Slider.value = _currentHealth;

            if (_a != _b)
            {
                _a++;
            }
            
            
        }
    }
}
