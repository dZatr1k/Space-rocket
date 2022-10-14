using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Player _player;

    private CanvasGroup _gameOverGroup;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _mainMenuButton.onClick.AddListener(OnMainMenuButtonClick);
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _mainMenuButton.onClick.RemoveListener(OnMainMenuButtonClick);
    }

    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0;
    }

    private void OnDied()
    {
        Time.timeScale = 0.5f;
        _gameOverGroup.DOFade(1, 1.5f);
    }

    private void OnRestartButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    private void OnMainMenuButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
