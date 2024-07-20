using System;
using UnityEngine;

namespace Enemy_Config
{
    [Serializable]
    public class EnemysConfig
    {
        public EnemyTypes enemyTypes;
        public Enemy Enemys;
        
        [Space(5)]
        public float EnemyHealth;
        [Space(5)]
        public float EnemyAttack;
        [Space(5)]
        public float EnemyDefence;
        [Space(5)]
        public float EnemyAttackRange;
        [Space(5)]
        public float EnemySpeed;
        [Space(5)]
        public float EnemyAttackSpeed;

        
    }
}
