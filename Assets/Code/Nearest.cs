using TMPro;
using UnityEditor.SearchService;
using UnityEngine;


namespace Code
{
    public class Nearest : MonoBehaviour
    {
        public int Count = 5;
        public Transform Target;
        private Transform[] _enemies;

        private void Start()
        {
            Target.GetComponent<Renderer>().material.color = Color.green;
            CreateEnemies();
        }

        private void Update()
        {
            SearchEnemies();
        }

        private void CreateEnemies()
        {
            _enemies = new Transform[Count];
            for (int i = 0; i < _enemies.Length; i++)
            {
                Transform enemy = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
                enemy.position = new Vector3(Random.Range(-10, 10), Target.position.y,  Random.Range(-10, 10));
                enemy.name = $"Enemy {i}";
                enemy.parent = Target.parent;
                _enemies[i] = enemy;
            }
            
        }


        private void SearchEnemies()
        {
            Transform returnNearest = ReturnNearestObject(_enemies, Target);

            for (var index = 0; index < _enemies.Length; index++)
            {
                Transform enemy = _enemies[index];
                if (returnNearest == enemy)
                {
                    enemy.GetComponent<Renderer>().material.color = Color.red;
                }
                else
                {
                    enemy.GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }

        private Transform ReturnNearestObject(Transform[] nodes, Transform destination)
        {
            Transform result = null;
            float nearestDistance = Mathf.Infinity;
            int length = nodes.Length;
            for (var i = 0; i < length; i++)
            {
                Transform node = nodes[i];
                float distanceToNode = (destination.position - node.position).sqrMagnitude;
                if (nearestDistance < distanceToNode) continue;
                nearestDistance = distanceToNode;
                result = node;
            }
            return result;
        }


}
    
    

}
