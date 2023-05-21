using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractObstruction : MonoBehaviour
{
    protected IScoreService _scoreService;

    public void SetParameters(IScoreService scoreService)
    {
        _scoreService = scoreService;
    }
}
