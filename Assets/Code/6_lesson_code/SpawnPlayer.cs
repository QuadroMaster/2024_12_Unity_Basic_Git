using UnityEngine;

namespace Code
{
    public class SpawnPlayer: MonoBehaviour
    {
        public Player PlayerPrefab;
        public Transform SpawnPoint;
        public Transform PlayerParent;
        private Player _player;

        private void Start()
        {
            _player = Instantiate(PlayerPrefab, SpawnPoint.position, SpawnPoint.rotation, PlayerParent);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Destroy(_player); <--- удалит всего лишь его свойста (скрипт), сам объект останется на сцене со всеми своими параметрами)
                Destroy(_player.gameObject); //удалит весь объект
            }

            if (Input.GetKeyDown((KeyCode.Alpha1)))
            {
                Rigidbody component = _player.gameObject.GetComponent<Rigidbody>();
                
                Destroy(component);
            }
            
            if (Input.GetKeyDown((KeyCode.Alpha2)))
            {
                Rigidbody component = _player.gameObject.GetComponent<Rigidbody>();
                if (component != null)
                {
                    component.mass = 999;
                }
            }
            
            if (Input.GetKeyDown((KeyCode.Alpha3)))
            {
                if(_player.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))//ВАЖНО! Пытается взять компонент rigidbody,
                                                                                   //если он его берёт, то кладёт в переменную rb
                {
                    rb.mass = 999;
                }
            }
            
            
        }
    }
}