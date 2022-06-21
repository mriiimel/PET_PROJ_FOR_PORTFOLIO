using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TEST_SCRIPT
{
    public class TestEnemySpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyToSpawn;
        [SerializeField] private List<Transform> _enemySpawnPoint;

        void Start()
        {
            foreach (var item in _enemySpawnPoint)
            {
                var spawn = Instantiate(_enemyToSpawn,item.position,Quaternion.identity);
                
                
            }
        }

        
        void Update()
        {

        }
    }
}
