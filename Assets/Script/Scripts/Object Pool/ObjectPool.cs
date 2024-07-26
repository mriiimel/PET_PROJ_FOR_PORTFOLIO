using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Enemy_Factory;
using ModestTree;
using System;

namespace Object_Pool
{
    public class ObjectPool:IDisposable
    {
        [Inject]private FactoryBase _enemyFactoryBase;
        private Stack<GameObject> _pool;
        
        public ObjectPool()
        {
            _pool = new Stack<GameObject>();
        }
        
        public GameObject GetFromPool()
        {
            
            for(int i = 0;i<= _pool.Count; i++)
            {
                if(_pool.IsEmpty() == false)
                {
                    return _pool.Pop();
                }
            }
            return null;
        }

        public void AddToPool(EnemyTypes enemyTyps)
        {
            var gameObj = _enemyFactoryBase.CreateEnemy(enemyTyps);
            gameObj.gameObject.SetActive(false);
            _pool.Push(gameObj);
        }

        public void Dispose()
        {
            _pool.Clear();
        }
    }
}
