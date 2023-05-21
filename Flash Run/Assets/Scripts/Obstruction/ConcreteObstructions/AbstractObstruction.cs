using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractObstruction : MonoBehaviour
{
    protected IScoreService _scoreService;
    protected IGameManager _gameManager;

    public void SetParameters(IScoreService scoreService, IGameManager gameManager)
    {
        _scoreService = scoreService;
        _gameManager = gameManager;
    }
}
