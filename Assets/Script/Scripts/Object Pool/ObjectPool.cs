using System.Collections.Generic;
using UnityEngine;
using Enemy_Config;
using Zenject;

namespace Object_Pool
{
    public sealed class ObjectPool
    {
        [Inject] private AllEnemys _allEnemys;

        private Stack<GameObject> _pool;





    }
}
