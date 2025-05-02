using Unity.VisualScripting;
using UnityEngine;


namespace Code
{
    public class SpawnPlayer : MonoBehaviour
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
                Destroy(_player.gameObject);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Rigidbody component = _player.gameObject.GetComponent<Rigidbody>();
                Destroy(component);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Rigidbody component = _player.gameObject.GetComponent<Rigidbody>();
                component.mass = 999;

            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (_player.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
                {
                    rb.mass = 9;
                }

            }
            
        }
    }

}