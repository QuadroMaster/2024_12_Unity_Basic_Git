using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Code
{
    public class HealthBar : MonoBehaviour
    {
        public TMP_Text HealthText;
        public Slider Slider;
        
        public float CurrentHealth;

        private void Update()
        {
            HealthText.text = CurrentHealth.ToString();
            Slider.value = CurrentHealth;
        }
    }
}

