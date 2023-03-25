using UnityEngine;
using Zenject;

public class SOInstaller : MonoInstaller
{
    [SerializeField] private TypeOfCardDataBase typeOfCardDataBase;
    public override void InstallBindings()
    {
        Container.Bind<ITypeOfCardDataBase>().FromInstance(typeOfCardDataBase).AsSingle();
    }
}