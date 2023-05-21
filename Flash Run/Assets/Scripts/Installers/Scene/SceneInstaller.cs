using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private GameManager _gameManager;
    public override void InstallBindings()
    {
        BindServices();
        BindGameObjects();
    }
    private void BindServices()
    {
        Container.BindInterfacesTo<ColldawnService>().AsSingle();
        Container.BindInterfacesTo<ExistCardsService>().AsSingle();
    }
    private void BindGameObjects()
    {
        Container.BindInterfacesTo<GameManager>().FromInstance(_gameManager).AsSingle();
    }
}