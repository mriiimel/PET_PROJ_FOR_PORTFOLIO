using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pet_Proj
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _enemyGameObj;
        [SerializeField] private int _spawnCount;
        [SerializeField] private List<Transform> _enemySpawnPosition;
        

        private void Start()
        {
            _enemyGameObj = new List<GameObject>();
            _enemySpawnPosition = new List<Transform>();
        }
        //private void Update()
        //{
        //    float count = _enemySpawnPosition.Count;
        //    foreach (var item in _enemyGameObj)
        //    {
        //        for (int i = 0; i < _spawnCount; i++)
        //        {
        //            Instantiate(item, Random.Range(0f,count), Quaternion.identity);
        //            gameObject.SetActive(true);
        //            _pooledObj.Add(item);
        //        }
        //    }
        //}
    }
}
