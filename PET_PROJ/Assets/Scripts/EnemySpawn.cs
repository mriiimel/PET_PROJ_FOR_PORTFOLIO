using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pet_Proj
{
    public class EnemySpawn : MonoBehaviour
    {
        
        [SerializeField] private List<GameObject> _pooledObj;
        [SerializeField] private GameObject _enemyGameObj;
        [SerializeField] private int _spawnCount;


        private void Start()
        {
            _pooledObj = new List<GameObject>();
            GameObject tmp;
            for (int i = 0; i < _spawnCount; i++)
            {
                tmp = Instantiate(_enemyGameObj, transform.position, Quaternion.identity);
                tmp.SetActive(true);
                _pooledObj.Add(tmp);
                
            }
        }

        
    }
}
