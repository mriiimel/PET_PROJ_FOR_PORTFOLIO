using EnemysConfig;
using Object_Pool;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private AllEnemys _enemysConfig;
    [SerializeField] private EnemyCounter _enemyCounter;
    public override void InstallBindings()
    {
        Container.Bind<AllEnemys>().FromInstance(_enemysConfig).AsCached().NonLazy();
        Container.Bind<ObjectPool>().AsCached().NonLazy();
        Container.Bind<EnemyCounter>().FromInstance(_enemyCounter).AsCached().NonLazy();
       
        
    }
}
