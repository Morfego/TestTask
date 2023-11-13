using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public event Action Died;
    public event Action TookDamage;

    [SerializeField] private EnemyData _data;

    private float _maxHealth;
    private float _currentHealth;

    public float CurrentHealth => _currentHealth;
    public float CurrentHealthPercentage => _currentHealth / _maxHealth;

    public void ChangeMaxHealth(float value) => _maxHealth += value;

    public void ChangeMaxHealthByPercentage(float value) => _maxHealth += value * _maxHealth;

    public void ChangeHealth(float value) => _currentHealth += value;

    public void ChangeHealthByPercentage(float value) => _currentHealth += value * _currentHealth;
    public void ChangeHealthByMaxHealthPercentage(float value) => _currentHealth += value * _maxHealth;

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        TookDamage?.Invoke();

        if (_currentHealth <= 0)
            Kill();
    }

    private void OnEnable()
    {
        _currentHealth = _data.MaxHealth;
        _maxHealth = _data.MaxHealth;
    }

    private void Kill()
    {
        PlayerManager.Instance.PlayerLevelController.ChangeExp(_data.ExpRewardForKill);
        PlayerManager.Instance.PlayerScoreController.ChangeScore(_data.Score);
        gameObject.SetActive(false);
        Died?.Invoke();
    }
}
