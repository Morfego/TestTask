using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private EnemySpawnData _enemySpawnData;

    private float _timeToSpawn;

    private void OnEnable()
    {
        RestartTimer();
    }

    private void Update()
    {
        _timeToSpawn -= Time.deltaTime;

        if (_timeToSpawn <= 0)
            SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(_playerData.PlayerMinPositionX, _playerData.PlayerMaxPositionX), 0, _enemySpawnData.SpawnDistanceFromFinalLine);
        var enemy = PoolingManager.Instance.GetOrCreate(_enemySpawnData.GetEnemy(), spawnPosition);
        RestartTimer();
    }

    private void RestartTimer()
    {
        _timeToSpawn = _enemySpawnData.SpawnInterval;
    }
}