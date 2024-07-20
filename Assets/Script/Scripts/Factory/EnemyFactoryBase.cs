using Enemy_Config;
using UnityEngine;
using Zenject;


namespace Enemy_Factory
{
    public sealed class EnemyFactoryBase
    {
        [Inject] private AllEnemys _allEnemys;

        public GameObject CreateEnemy(EnemyTypes enemyTypes)
        {
            return _allEnemys.GetEnemyWithType(enemyTypes).Enemys.gameObject;

        }
    }
}
