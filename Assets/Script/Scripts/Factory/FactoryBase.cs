using Enemy_Config;
using TMPro;
using UnityEngine;
using Zenject;

namespace Enemy_Factory
{
    public class FactoryBase:MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _totalEnemyCountText;


        private int _totalEnemyCount;


        [Inject] private Factory _factory;
       

        public TextMeshProUGUI TotalEnemyCountText { get => _totalEnemyCountText; set => _totalEnemyCountText = value; }
        public int TotalEnemyCount { get => _totalEnemyCount;  set => _totalEnemyCount = value; }

        public GameObject CreateEnemy(EnemyTypes enemyTypes)
        {
            return _factory.allEnemys.GetEnemyWithType(enemyTypes).Enemys.gameObject;
            
        }
    }
}
