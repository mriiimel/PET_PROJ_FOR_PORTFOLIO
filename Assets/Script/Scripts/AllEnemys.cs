using System.Collections.Generic;
using UnityEngine;

namespace Enemy_Config
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "ScriptableObject/EnemyConfig", order = 0)]
    public sealed class AllEnemys : ScriptableObject
    {
        public List<EnemysConfig> EnemysConfigs;
        private GameObject _gameObject;
        public EnemysConfig GetEnemyWithType(EnemyTypes enemyTypes)
        {
            
            for (int i = 0; i < EnemysConfigs.Count; i++)
            {
                var obj = EnemysConfigs[i];
                if (enemyTypes == obj.enemyTypes)
                    return obj;
            }
            return null;
        }
    }
}