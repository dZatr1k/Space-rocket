using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreCount;
    [SerializeField] private Player _player;

    private float _loopTime;
    private float _score;
    private bool _isDied = true;

    private void OnEnable()
    {
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }

    private void Update()
    {
        _loopTime += Time.deltaTime;
        if(_loopTime >= 1 && _isDied)
        {
            _loopTime = 0;
            _score++; 
            _scoreCount.text = _score.ToString();
        }
    }

    private void OnDied()
    {
        _isDied = false;
    }
}
