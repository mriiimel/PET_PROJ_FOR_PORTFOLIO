using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Enemy_Factory;

namespace Object_Pool
{
    public class ObjectPool
    {
        private EnemyFactoryBase _enemyFactoryBase;
        private Stack<GameObject> _pool;
        public ObjectPool(EnemyFactoryBase enemyFactoryBase)
        {
            _pool = new Stack<GameObject>();
            _enemyFactoryBase = enemyFactoryBase;
        }
        
        public GameObject GetPool()
        {
            return _pool.Peek();
        }

        public void AddToPool(EnemyTypes enemyTyps)
        {
            _pool.Push(_enemyFactoryBase.CreateEnemy(enemyTyps));
        }


    }
}
