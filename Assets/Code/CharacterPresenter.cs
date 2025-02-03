using UnityEngine;
using UnityEngine.Serialization;


namespace Code
{
    
    
    public class CharacterPresenter : MonoBehaviour
    {
        [FormerlySerializedAs("Character")] public Character_old characterOld;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                bool characterIsDead = !characterOld.IsDead;
                characterOld.SetActive(characterIsDead);
            }
        }
        
    }
    
        
    
    
}
