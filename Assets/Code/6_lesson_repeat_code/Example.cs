using System;
using UnityEngine;

namespace Code
{


    public class Example : MonoBehaviour
    {
        private void Awake()
        {
            Debug.LogError(nameof(Awake));
        }

        private void Start()
        {
            Debug.LogError("Start");
        }

        private void OnEnable()
        {
            Debug.LogError("OnEnable");
        }

        private void OnDisable()
        {
            Debug.LogError("OnDisable");
        }
        private void OnDestroy()
        {
            Debug.LogError("OnDestroy");
        }
        private void Update()
        {
            Debug.LogError("Update");
        }
        
    }
}