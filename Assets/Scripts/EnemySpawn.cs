using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Pet_Proj
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _enemyObject;
        [SerializeField] private List<Transform> _enemySpawnPosition;


        private void Start()
        {
            var player = FindObjectOfType<Hero>();

            foreach (var spawnPos in _enemySpawnPosition)
            {
                var random = Random.Range(0,_enemyObject.Count);
                var enemy = Instantiate(_enemyObject[random], spawnPos.position,Quaternion.identity);
                enemy.GetComponent<Enemy>().Target = player.gameObject;
            }
        }
    }   
}
