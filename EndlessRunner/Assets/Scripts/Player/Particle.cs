using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _target;

    private void OnEnable()
    {
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }

    private void Start()
    {
        transform.position = _target.position;
    }

    private void Update()
    {
        transform.position = _target.position;
    }

    private void OnDied()
    {
        gameObject.SetActive(false);
    }
}
