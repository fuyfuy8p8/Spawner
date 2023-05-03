using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject enemyPrefab;

    private IEnumerator SpawnEnemiesCoroutine()
    {
        while (true)
        {
            int _randomInt = Random.Range(0, spawnPoints.Length );
            SpawnEnemy(_randomInt);

            yield return new WaitForSeconds(2f);
        }
    }

    private void SpawnEnemy(int spawnIndex)
    {
        Instantiate(enemyPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemiesCoroutine());
    }
}

