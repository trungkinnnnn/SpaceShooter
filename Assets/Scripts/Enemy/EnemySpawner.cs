using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[System.Serializable]
public class EnemyWave
{
    public Transform enemyPrefab;
    public int numberOfEnemy;
    public Vector3 fomationOffset;
    public FlyPath flyPath;
    public float speed;
    public float nextWaveDelay;
}


public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;

    private int currentWave;

    private void Start() => SpawEnemyWave();
    
    private void SpawEnemyWave()
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
    }    

}
