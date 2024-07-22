using Enemy_Config;
using Object_Pool;
using UnityEngine;
using Zenject;


namespace Enemy_Factory
{
    public class EnemyFactory: MonoBehaviour
    {
        [Inject] public AllEnemys allEnemys { get; }
        [Inject]private ObjectPool _pool;
        [Inject]private EnemyFactoryBase _enemyFactory;
        public EnemyFactory()
        {
            
            _pool = new ObjectPool(_enemyFactory);
        }

        internal EnemyFactoryBase EnemyFactorys { get => _enemyFactory; set => _enemyFactory = value; }

        private void Start()
        {
            //allEnemys.DoSomething();
            _pool.AddToPool(EnemyTypes.TinySlime);
            Instantiate(_pool.GetPool());
        }
    }
}
