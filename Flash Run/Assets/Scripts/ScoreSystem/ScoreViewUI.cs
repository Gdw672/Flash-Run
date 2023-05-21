using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Zenject;

public class ScoreViewUI : MonoBehaviour
{
    [Inject] private IScoreService _scoreService;
    private TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        _textMeshPro.text = _scoreService.GetScore().ToString();
    }
}
