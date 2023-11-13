using UnityEngine;
using System;

public class PlayerHealthController : MonoBehaviour
{
    public event Action HealthUpdated;

    [SerializeField] private PlayerData _playerData;

    private float _currentHealth;

    public float CurrentHealth => _currentHealth;
    public bool IsDead => _currentHealth <= 0;

    public void DealDamage(float damage)
    {
        _currentHealth -= damage;
        HealthUpdated?.Invoke();
    }

    private void Awake()
    {
        _currentHealth = _playerData.PlayerHealth;
    }
}
