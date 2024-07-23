using Enemy_Config;
using UnityEngine;
using Zenject;

namespace Enemy_Factory
{
    public class FactoryBase
    {
        [Inject] private Factory _factory;
        

        public GameObject CreateEnemy(EnemyTypes enemyTypes)
        {
            return _factory.allEnemys.GetEnemyWithType(enemyTypes).Enemys.gameObject;
            
        }
    }
}
