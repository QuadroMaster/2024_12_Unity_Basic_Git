using UnityEngine;


namespace Code
{
    public class ExamplePerlinNoise : MonoBehaviour
    {
        public float Multiplier = 5;
        public float Refinement = 0.3f;
        public int Count = 50;


        private void Start()
        {
            Transform root = new GameObject("Root").transform;
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    float y = Mathf.PerlinNoise(i * Refinement, j * Refinement) * Multiplier;
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(i, y, j);
                    cube.transform.SetParent(root);
                    ExampleRandom exampleRandom = cube.AddComponent<ExampleRandom>();
                }
            }
        }
        
        
    }

}
