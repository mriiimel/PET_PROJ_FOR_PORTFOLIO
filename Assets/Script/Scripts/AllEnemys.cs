using System.Collections.Generic;
using UnityEngine;

namespace Enemy_Config
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "ScriptableObject/EnemyConfig", order = 0)]
    public sealed class AllEnemys : ScriptableObject
    {
        public List<EnemysConfig> EnemysConfigs = new List<EnemysConfig>();


    }
}