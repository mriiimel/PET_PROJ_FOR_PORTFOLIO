using System;
using System.Collections.Generic;
using UnityEngine;



namespace Pet_Proj
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _enemyObj;
        [SerializeField] private List<Transform> _enemySpawnPosition;

        public Action DestroyEnemy;

        public EnemySpawn(Action destroyEnemy)
        {
            DestroyEnemy = destroyEnemy;
        }

        private void Start()
        {
            Spawn();
        }
        private void Spawn()
        {
            var hero = FindObjectOfType<Hero>();
            foreach (var spawnPos in _enemySpawnPosition)
            {
                var random = UnityEngine.Random.Range(0, _enemyObj.Count);
                var m_enemy = Instantiate(_enemyObj[random], spawnPos.position, Quaternion.identity);
                m_enemy.GetComponent<Enemy>().Target = hero.gameObject;
            }

        }
    }
}
