using Enemy_Config;
using UnityEngine;
using Zenject;


namespace Enemy_Factory
{
    public sealed class EnemyFactoryBase
    {
        [Inject] private AllEnemys _allEnemys;
        private EnemysConfig _config;
        private GameObject _enemy;
        public GameObject CreateEnemy(Enemy enemy)
        {
            return enemy.gameObject;
            
        }

        public GameObject GetEnemyWithType(EnemyTypes enemyTypes)
        {
            
            foreach(var obj in _allEnemys.EnemysConfigs) 
            {
                _config = obj;
                if (enemyTypes == _config.enemyTypes)
                {
                    _enemy = _config.Enemys.gameObject;
                    break;
                }
            }
            Debug.Log($"{_config.EnemyHealth}");
            return _enemy;
        }
    }
}
