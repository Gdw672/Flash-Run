using UnityEngine;
using Zenject;

public class SOInstaller : MonoInstaller
{
    [SerializeField] private TypeOfCardDataBase typeOfCardDataBase;
    [SerializeField] private ObstructionsDataBase obstructionsDataBase;
    public override void InstallBindings()
    {
        Container.Bind<ITypeOfCardDataBase>().FromInstance(typeOfCardDataBase).AsSingle();
        Container.Bind<IObstructionsDataBase>().FromInstance(obstructionsDataBase).AsSingle();
    }
}