using Enemy_Config;
using UnityEngine;
using Zenject;

namespace Enemy_Factory
{
    public sealed class EnemyFactory: MonoBehaviour
    {
        [Inject]private EnemyFactoryBase _enemyFactory;
        [Inject]private AllEnemys _allEnemys;
        
        private void Start()
        {
            
            foreach (var obj in _allEnemys.EnemysConfigs)
            {
                Instantiate(_enemyFactory.CreateEnemy(obj.Enemys));
            }
            
            
            Instantiate(_enemyFactory.GetEnemyWithType(EnemyTypes.SlimeBigLeaf));
            
        }
    }
}

