using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EndOfLevel : MonoBehaviour
{
    [Inject] private IGameManager _gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndOfLevel")
            _gameManager.ShowResults();
    }
}

