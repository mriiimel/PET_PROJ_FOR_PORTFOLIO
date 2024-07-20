using UnityEngine;
using Zenject;

public class UntitledInstaller : Installer<UntitledInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<IPlayer>().To<PlayerBase>().AsSingle();
    }
}