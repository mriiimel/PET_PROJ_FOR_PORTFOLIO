using Enemy_Config;
using Object_Pool;
using UnityEngine;
using Zenject;


namespace Enemy_Factory
{
    public class Factory: MonoBehaviour
    {
        [Inject]public AllEnemys allEnemys { get; }
        [Inject]private ObjectPool _pool;
        [Inject]private FactoryBase _enemyFactory;
        [Inject]private EnemyCounter _enemyCounter;
        public Factory()
        {
            
            _pool = new ObjectPool(_enemyFactory);
        }

        internal FactoryBase EnemyFactorys { get => _enemyFactory; set => _enemyFactory = value; }

        private void Start()
        {
            _enemyCounter.CountEnemy(_pool);
            for (int i = 0; i < 20; i++)
            {
                var obj = _pool.GetFromPool();
                obj.SetActive(true);
                Instantiate(obj);
            }
           
        }
    }
}
