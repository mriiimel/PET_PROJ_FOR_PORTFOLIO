using Enemy_Factory;
using Enemy_Config;
using Object_Pool;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private AllEnemys _enemysConfig;
    [SerializeField] private EnemyCounter _enemyCounter;
    [SerializeField] private EnemyFactory _enemyFactory;
    public override void InstallBindings()
    {
        Container.Bind<ObjectPool>().AsCached();
        Container.Bind<AllEnemys>().FromInstance(_enemysConfig).AsCached();
        Container.Bind<EnemyCounter>().FromInstance(_enemyCounter).AsSingle();
        Container.Bind<IEnemy>().To<Enemy>().AsSingle();
        Container.Bind<EnemyFactory>().FromInstance(_enemyFactory).AsSingle();
        Container.Bind<EnemyFactoryBase>().AsCached().NonLazy();
       



    }
}
