using UnityEngine;

public class EnemyAbilityCasterTookDamage : EnemyAbilityCasterBase
{
    [SerializeField] private EnemyHealth _health;

    private void Awake()
    {
        _health.TookDamage += InvokeEffects;
    }

    private void OnDestroy()
    {
        if (_health)
            _health.TookDamage -= InvokeEffects;
    }
}
