using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] bool looping = false;

    private int startingWave = 0;

    private IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnAllWaves());
        } while (looping);
    }

    private IEnumerator SpawnAllWaves()
    {
        for (int waveIndex = startingWave; waveIndex < waveConfigs.Count; waveIndex++)
        {
            var currentWave = waveConfigs[waveIndex];
            yield return StartCoroutine(SpawnAllEnemiesOnWave(currentWave));
        }
    }

    private IEnumerator SpawnAllEnemiesOnWave(WaveConfig currentWave)
    {
        for (int enemyCounter = 0; enemyCounter < currentWave.GetNumberOfEnemies(); enemyCounter++)
        {
            var newEnemy = Instantiate(currentWave.GetEnemyPrefab(), currentWave.GetWaypoints()[0].transform.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyPathing>().SetWaveConfig(currentWave);
            yield return new WaitForSeconds(currentWave.GetTimeBetweenSpawns());
        }
    }

}
