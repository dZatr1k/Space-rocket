using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenspawn;
    [SerializeField] private float _startCooldown;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_prefab);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _timeBetweenspawn && TryGetObject(out GameObject enemy))
        {
            _elapsedTime = 0;
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
        }
    }
    private void SetEnemy(GameObject enemy, Vector3 spawnPointPosition)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPointPosition;
    }
    public void ChangeTimeBetweenSpawn(float deltaTime)
    {
        _timeBetweenspawn -= deltaTime;
    }
}
