using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Pet_Proj
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _objPool;
        //[SerializeField] private List<GameObject> _enemyGameObj;
        [SerializeField] private GameObject _enemyGameObj;
        [SerializeField] private int _spawnCount;
        [SerializeField] private List<Transform> _enemySpawnPosition;
        public Text _enemyCountText;
        
        

        private void Start()
        {
            //_enemyGameObj = new List<GameObject>();
            //_enemySpawnPosition = new List<Transform>();
        }
        private void Update()
        {
            Spawn();
            //float m_enemyCount = _enemyGameObj.Count +1;
            //_enemyCountText.text = $"Количество врагов: {m_enemyCount}";
        }
        private void Spawn()
        {
            for (int i = 0; i < _spawnCount; i++)
            {
                Instantiate(_enemyGameObj, transform.position, Quaternion.identity);
                gameObject.SetActive(true);
                _objPool.Add(_enemyGameObj);
            }

            //foreach (var item in _enemyGameObj)
            //{
            //    for (int i = 0; i < _spawnCount; i++)
            //    {
            //        Instantiate(item, transform.position, Quaternion.identity);
            //        gameObject.SetActive(true);
            //        _objPool.Add(item);
            //    }
            //}
        }
    }
}
