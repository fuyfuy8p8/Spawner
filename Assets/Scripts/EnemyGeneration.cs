using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemyPrefab;

    private IEnumerator SpawnEnemiesCoroutine()
    {
        while (true)
        {
            int _randomInt = Random.Range(0, _spawnPoints.Length );
            SpawnEnemy(_randomInt);

            yield return new WaitForSeconds(2f);
        }
    }

    private void SpawnEnemy(int spawnIndex)
    {
        Instantiate(_enemyPrefab, _spawnPoints[spawnIndex].position, Quaternion.identity);
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemiesCoroutine());
    }
}

