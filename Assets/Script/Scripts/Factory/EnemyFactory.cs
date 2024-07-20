using Enemy_Config;
using UnityEngine;
using Zenject;

namespace Enemy_Factory
{
    public sealed class EnemyFactory: MonoBehaviour
    {
        [Inject]private EnemyFactoryBase _enemyFactory;
       
        
        private void Start()
        {
            Instantiate(_enemyFactory.CreateEnemy(EnemyTypes.SlimeKing));
           
            
        }

        
    }
}

