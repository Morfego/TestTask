using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy spawn data")]
public class EnemySpawnData : ScriptableObject
{
    [Serializable]
    private class EnemySpawnChances
    {
        public GameObject Prefab;
        public float Chance;
    }

    [SerializeField] private float _spawnInterval;
    [SerializeField] private float _spawnDistanceFromFinalLine;
    [SerializeField] private List<EnemySpawnChances> _spawnChances;

    public float SpawnInterval => _spawnInterval;
    public float SpawnDistanceFromFinalLine => _spawnDistanceFromFinalLine;

    public GameObject GetEnemy()
    {
        float totalChances = _spawnChances.Sum(p => p.Chance);
        float random = Random.Range(0f, totalChances);

        foreach (var spawnChance in _spawnChances)
        {
            if (spawnChance.Chance >= random)
                return spawnChance.Prefab;
            else
                random -= spawnChance.Chance;
        }

        return null;
    }
}
