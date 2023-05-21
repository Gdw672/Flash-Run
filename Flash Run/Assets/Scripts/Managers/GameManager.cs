using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IGameManager
{
   [SerializeField] private Button _startButton, _replayButton;
   [SerializeField] private GameObject _game;
   [SerializeField] private GameObject _startUI;
    [SerializeField] private GameObject _results;

    private void Awake()
    {
        _startButton.onClick.AddListener(StartGame);
        _replayButton.onClick.AddListener(Restart);
    }

    public void StartGame()
    {
        _game.SetActive(true);
        _startUI.SetActive(false);
    }

    public void ShowResults()
    {
        _game.SetActive(false);
        _results.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneName: "MainScene");
    }
}
public interface IGameManager
{
    public void StartGame();
    public void ShowResults();
}