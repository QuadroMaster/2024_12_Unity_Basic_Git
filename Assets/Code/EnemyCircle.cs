using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code
{
    public class EnemyCircle : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        public float Distance = 15;
        public int Count = 30;

        private void Start()
        {
            Transform root = new GameObject("Root").transform;
            for (int i = 0; i < Count; i++)
            {
                float angle = i * Mathf.PI * 2 / Count;
                Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * Distance;
                GameObject temp = Instantiate(EnemyPrefab, pos, Quaternion.identity, root);
                temp.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }

            EnemyPrefab.SetActive(false);

        }
    }

}
