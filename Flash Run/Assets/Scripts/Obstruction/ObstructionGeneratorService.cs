using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObstructionGeneratorService : MonoBehaviour
{
    [Inject] private IObstructionsDataBase _obstructionsDataBase;
    [Inject] protected IAnotherObjectsDataBase _anotherObjectsDataBase;
    [Inject] private IScoreService _scoreService;
    [Inject] private IGameManager _gameManager;
    private void Start()
    {
        GenerateObstructions(Camera.main.transform.position, 1);
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
            obstruction.GetComponent<AbstractObstruction>().SetParameters(_scoreService, _gameManager);
        }
        obstructionPos.z += 3;
        var end = Instantiate(_anotherObjectsDataBase.Objects.Find(endLevel => endLevel.typeOfAnotherObject == ETypeOfAnotherObject.EndOfLevel).prefab, obstructionPos, Quaternion.identity);
    }
}