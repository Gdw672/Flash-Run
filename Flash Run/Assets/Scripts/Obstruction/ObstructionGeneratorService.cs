using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObstructionGeneratorService : MonoBehaviour
{
    [Inject] private IObstructionsDataBase _obstructionsDataBase;
    private void Start()
    {
        GenerateObstructions(Camera.main.transform.position, 20);
    }
    public void GenerateObstructions(Vector3 playerPos, int numOfObstr)
    {
        Vector3 obstructionPos = playerPos;
        for (int i = 0; i < numOfObstr; i++)
        {
            if(i == 0)
            {
                obstructionPos.z += 12;
                print(0);
            }
            else
                obstructionPos.z += 4;
            Instantiate(_obstructionsDataBase.Obstructions.Find(car => car.typeOfObstruction == ETypeOfObstruction.TestObst).prefab, obstructionPos, Quaternion.identity);
        }
    }
}