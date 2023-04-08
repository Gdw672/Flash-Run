using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<ColldawnService>().AsSingle();
        Container.BindInterfacesTo<ExistCardsService>().AsSingle();
    }
}