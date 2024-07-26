using Enemy_Config;
using Object_Pool;
using UnityEngine;
using Zenject;


namespace Enemy_Factory
{
    public class Factory: FactoryBase
    {
        [SerializeField] private PlayerController playerController;



        [Inject]public AllEnemys allEnemys { get; }
        [Inject]private ObjectPool _pool;
        [Inject]private EnemyCounter _enemyCounter;




        private void Start()
        {
            
            _enemyCounter.CountEnemy(_pool,this);
            TotalEnemyCountText.text = $"TOTAL ENEMY IS  {TotalEnemyCount}";
            for (int i = 0; i < TotalEnemyCount; i++)
            {
                var obj = _pool.GetFromPool();
                obj.SetActive(true);
                Instantiate(obj);
            }
        }
    }
}
