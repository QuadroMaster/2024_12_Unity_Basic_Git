using UnityEngine;


namespace Code
{
    
    
    public class CharacterPresenter : MonoBehaviour
    {
        public Character Character;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                bool characterIsDead = !Character.IsDead;
                Character.SetActive(characterIsDead);
            }
        }
        
    }
    
        
    
    
}
