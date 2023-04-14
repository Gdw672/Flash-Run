using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObstructionGeneratorService : IObstructionGeneratorService
{
    [Inject] private IObstructionsDataBase _obstructionsDataBase;
    public void GenerateObstructions()
    {
        var x = _obstructionsDataBase.Obstructions.Find(test => test.typeOfObstruction == ETypeOfObstruction.TestObst);
       UnityEngine.MonoBehaviour.print(x.prefab.name);
    }
    public void test()
    {
        UnityEngine.MonoBehaviour.print("Test");
    }

}
public interface IObstructionGeneratorService
{
    public void GenerateObstructions();
    public void test();
}