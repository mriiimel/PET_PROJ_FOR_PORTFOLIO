using Enemy_Config;
using UnityEngine;
using Zenject;

namespace Enemy_Factory
{
    public class EnemyFactoryBase
    {
        [Inject] private EnemyFactory _factory;
        

        public GameObject CreateEnemy(EnemyTypes enemyTypes)
        {
            return _factory.allEnemys.GetEnemyWithType(enemyTypes).Enemys.gameObject;
            
        }
    }
}
