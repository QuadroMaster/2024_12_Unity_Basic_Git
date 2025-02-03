using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Code
{
    public class CharacterSpawner: MonoBehaviour
    {
        public Character2 Character2;
        public int CountCharacter;
        private void Start()
        {
            for (int i = 0; i < CountCharacter; i++)
            {
                Character2 instantiate = Instantiate(Character2, new Vector3(i, i, 0), 
                    Quaternion.identity);
                instantiate.name = $"Character{i}";
                instantiate.SetColor(Random.ColorHSV());
                
                
                //Instantiate(Character, new Vector3(i, i, 0), Quaternion.identity);
            }
            
            Character2.SetActive(false);
        }
    }


}