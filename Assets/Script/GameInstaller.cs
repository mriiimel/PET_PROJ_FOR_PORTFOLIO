using Enemy_Factory;
using Enemy_Config;
using Object_Pool;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private AllEnemys _enemysConfig;
    [SerializeField] private EnemyCounter _enemyCounter;
    [SerializeField] private Factory _enemyFactory;
    [SerializeField] private PlayerController _playerController;
    
    public override void InstallBindings()
    {
        Container.Bind<ObjectPool>().AsCached();
        Container.Bind<AllEnemys>().FromInstance(_enemysConfig).AsCached();
        Container.Bind<EnemyCounter>().FromInstance(_enemyCounter).AsSingle();
        Container.Bind<Factory>().FromInstance(_enemyFactory).AsSingle();
        Container.Bind<FactoryBase>().FromInstance(_enemyFactory).AsCached().NonLazy();
        Container.Bind<PlayerControllerBase>().FromInstance(_playerController).AsSingle();
        Container.Bind<PlayerController>().FromInstance(_playerController).AsCached();
        
        
    }
}
