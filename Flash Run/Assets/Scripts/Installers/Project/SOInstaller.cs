using UnityEngine;
using Zenject;

public class SOInstaller : MonoInstaller
{
    [SerializeField] private TypeOfCardDataBase typeOfCardDataBase;
    [SerializeField] private ObstructionsDataBase obstructionsDataBase;
    [SerializeField] protected AnotherObjectsDataBase anotherObjectsDataBase;
    public override void InstallBindings()
    {
        Container.Bind<ITypeOfCardDataBase>().FromInstance(typeOfCardDataBase).AsSingle();
        Container.Bind<IObstructionsDataBase>().FromInstance(obstructionsDataBase).AsSingle();
        Container.Bind<IAnotherObjectsDataBase>().FromInstance(anotherObjectsDataBase).AsSingle();
    }
}