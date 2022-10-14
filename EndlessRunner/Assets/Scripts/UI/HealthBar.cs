using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Image _image;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }
    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        _image.DOFillAmount(health / 3f, 0.25f);
    }
}
