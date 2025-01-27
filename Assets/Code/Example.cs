using System;
using UnityEngine;

namespace Code
{
    public class Example : MonoBehaviour
    {
        //public int Y;
        private void Start()
        {
            First();
            Second();
            
        }

        private void First()
        {
            int a = 1;
            ulong l = 2l;
            float f = 2.34115151513616241f;
            double d = 2.34115151513616241d;
            decimal m = 2.34115151513616241m;
            bool b = true;
            char c = 'с';
            string s = "Roman";


            
            
            Debug.Log(a);
            Debug.Log(l);
            Debug.Log(f);
            Debug.Log(d);
            Debug.Log(m);
            Debug.Log(b);
            Debug.Log(c);
            Debug.Log(s);
            
        }

        private void Second()
        {
            float health = 99.9999999f;
            Debug.LogWarning("Player" + health + "hp");
            Debug.LogWarning(String.Format("Player {0} hp", health));
            Debug.LogWarning($"Player {health} hp");
            
        }

        public string A;
        public string B;
        public int Result;


        public float D;
        public float E;
        
        public float Result2;
        private int[] _array = { 1, 2, 3, 4, 5 };
        private int _currentIndex = 0;

        private void Fourth()
        {
            //%
            Result2 = D % E;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _currentIndex++;
                int index = _currentIndex % _array.Length;
                Debug.LogError(_array[index]);
                Debug.LogWarning(index);
                Debug.LogWarning(_currentIndex);
            }
        }
        
        private void Update()
        {
            
            
        }

        private void Third()
        {
            int a = 7;
            
            // + - * /
            int intA = Int32.Parse(A);
            int intB = Int32.Parse(B);
            Result = intA + intB;
            
        }

        private void OnValidate()
        {
            Debug.LogError("OnValidateUIIIII");
            Third();
            
        }
    }
}