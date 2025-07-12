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
