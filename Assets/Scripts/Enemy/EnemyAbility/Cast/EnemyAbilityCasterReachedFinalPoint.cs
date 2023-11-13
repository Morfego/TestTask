using UnityEngine;

public class EnemyAbilityCasterReachedFinalPoint : EnemyAbilityCasterBase
{
    [SerializeField] private EnemyMovement _movement;

    private void Awake()
    {
        _movement.ReachedFinalPoint += InvokeEffects;
    }

    private void OnDestroy()
    {
        if (_movement)
            _movement.ReachedFinalPoint -= InvokeEffects;
    }
}
