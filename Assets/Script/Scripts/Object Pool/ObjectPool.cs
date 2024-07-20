using System.Collections.Generic;
using UnityEngine;
using EnemysConfig;
using Zenject;

namespace Object_Pool
{
    public sealed class ObjectPool
    {
        [Inject] private AllEnemys _allEnemys;

        private Stack<GameObject> _pool;





    }
}
