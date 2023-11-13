using UnityEngine;

public class EnemyAbilityCasterDied : EnemyAbilityCasterBase
{
    [SerializeField] private EnemyHealth _health;

    private void Awake()
    {
        _health.Died += InvokeEffects;
    }

    private void OnDestroy()
    {
        if (_health)
            _health.Died -= InvokeEffects;
    }
}
