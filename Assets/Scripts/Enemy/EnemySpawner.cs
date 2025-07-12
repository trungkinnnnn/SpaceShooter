using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Wave data")]
    public EnemyWaveConfig waveConfig;

    private int currentWave;

    private void Start() => SpawnEnemyWave();


    private void SpawnEnemyWave()
    {
        if (waveConfig == null || waveConfig.enemyWaves.Length == 0) return;

        var waveInfo = waveConfig.enemyWaves[currentWave];
        var startPostion = waveInfo.flyPath[0];

        for(int i = 0; i < waveInfo.numberOfEnemy; i+=1)
        {
            var enemy = Instantiate(waveInfo.enemyPrefab, startPostion, Quaternion.identity);

            var agent = enemy.GetComponent<FlyPathAgent>();

            agent.flyPath = waveInfo.flyPath;
            agent.flySpeed = waveInfo.speed;

            startPostion += waveInfo.fomationOffset;
        }
        currentWave += 1;

        if(currentWave < waveConfig.enemyWaves.Length)
        {
            Invoke(nameof(SpawnEnemyWave), waveInfo.nextWaveDelay);
        }

    }

    
   /* private void SpawEnemyWave()
    {
        var waveInfo = enemyWaves[currentWave];
        var startPostion = waveInfo.flyPath[0];

        for(int i = 0; i < waveInfo.numberOfEnemy; i += 1)
        {
            var enemy = Instantiate(waveInfo.enemyPrefab, startPostion, Quaternion.identity);
            
            var agent = enemy.GetComponent<FlyPathAgent>(); 

            agent.flyPath = waveInfo.flyPath;
            agent.flySpeed = waveInfo.speed;

            startPostion += waveInfo.fomationOffset;
        }
        currentWave += 1;

        if(currentWave < enemyWaves.Length)
        {
            Invoke(nameof(SpawEnemyWave), waveInfo.nextWaveDelay);
        }
    }    */

}
