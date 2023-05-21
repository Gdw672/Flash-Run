using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObstructionGeneratorService : MonoBehaviour
{
    [Inject] private IObstructionsDataBase _obstructionsDataBase;
    [Inject] private IScoreService _scoreService;
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
            }
            else
                obstructionPos.z += 4;
            var obstruction = Instantiate(_obstructionsDataBase.Obstructions.Find(car => car.typeOfObstruction == ETypeOfObstruction.Move).prefab, obstructionPos, Quaternion.identity);
            obstruction.GetComponent<AbstractObstruction>().SetParameters(_scoreService);
        }
    }
}