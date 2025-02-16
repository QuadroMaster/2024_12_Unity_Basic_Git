using UnityEngine;

namespace Code
{
    public class PersonSpawner: MonoBehaviour
    {
        public Person Person;
        
        private int _countPerson = 7;

        private void Start()
        {
            for (int i = 0; i < _countPerson; i++)
            {
                Person instantiate = Instantiate(Person, new Vector3(14 + i, -39, 48 + i), Quaternion.identity);
                instantiate.name = $"Person{i}";
            }
        }
    }
}