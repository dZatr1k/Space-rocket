using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGameHarder : MonoBehaviour
{
    [SerializeField] private float _enemySpeedBooster;
    [SerializeField] private float _timeBetweenSpawnBooster;
    [SerializeField] private float _timeToMakeGameHarder;

    private float _elapsedTime;
    private List<GameObject> _enemies;
    private Spawner _spawner;

    private void Start()
    {
        _enemies = FindObjectOfType<ObjectPool>().ListOfEnimies;
        _spawner = FindObjectOfType<Spawner>();
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_timeToMakeGameHarder <= _elapsedTime)
        {
            _timeToMakeGameHarder = Mathf.Round(1.5f * _timeToMakeGameHarder);

            foreach (var enemyMover in _enemies)
            {
                enemyMover.GetComponent<EnemyMover>().ChangeEnemySpeed(_enemySpeedBooster);
            }

            _spawner.ChangeTimeBetweenSpawn(_timeBetweenSpawnBooster);
        }
    }
}
