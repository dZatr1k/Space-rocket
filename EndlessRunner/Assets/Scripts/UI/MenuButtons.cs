using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuButtons : MonoBehaviour
{
    private CanvasGroup _mainMenuGroup;

    private void Start()
    {
        _mainMenuGroup = GetComponent<CanvasGroup>();
    }

    public void LoadScene(int sceneNumber)
    {
        Tween tween = _mainMenuGroup.DOFade(0, 0.2f);
        SceneManager.LoadScene(sceneNumber);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
