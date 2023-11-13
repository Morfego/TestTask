using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public static EnemiesManager Instance;

    private List<EnemyAbilityTarget> _aliveEnemies = new List<EnemyAbilityTarget>();

    public List<EnemyAbilityTarget> GetAliveEnemies() => new List<EnemyAbilityTarget>(_aliveEnemies);

    public void RegisterAliveEnemy(EnemyAbilityTarget enemy) => _aliveEnemies.Add(enemy);
    public void UnregisterAliveEnemy(EnemyAbilityTarget enemy) => _aliveEnemies.Remove(enemy);

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
