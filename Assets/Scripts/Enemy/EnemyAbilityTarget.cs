using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityTarget : MonoBehaviour
{
    [SerializeField] private List<EnemyAbilityIdentifierObjectData> _identifiersTokens;

    public List<EnemyAbilityIdentifierObjectData> GetIdentifiersTokens() => new List<EnemyAbilityIdentifierObjectData>(_identifiersTokens);

    private void OnEnable()
    {
        EnemiesManager.Instance.RegisterAliveEnemy(this);
    }

    private void OnDisable()
    {
        EnemiesManager.Instance.UnregisterAliveEnemy(this);
    }
}
