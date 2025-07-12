using UnityEngine;

[CreateAssetMenu(fileName = "EnemyWaveConfig", menuName = "ScriptableObjects/EnemyWaveConfig", order = 1)]
public class EnemyWaveConfig : ScriptableObject
{
    public EnemyWave[] enemyWaves;
}
