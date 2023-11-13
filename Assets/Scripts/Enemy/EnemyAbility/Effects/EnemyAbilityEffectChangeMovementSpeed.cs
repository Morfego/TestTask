using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy abilities/Effect change movement speed")]
public class EnemyAbilityEffectChangeMovementSpeed : EnemyAbilityEffectBase
{
    [SerializeField] private float _movementSpeedValue;
    [SerializeField] private bool _isPercentageValue;
    [SerializeField] private bool _isMaxSpeedPercentageValue;

    protected override void InvokeEffect(EnemyAbilityTarget target)
    {
        var movement = target.GetComponentInChildren<EnemyMovement>();

        if (!movement)
            return;

        if (_isMaxSpeedPercentageValue)
            movement.ChangeSpeedByMaxSpeedPercentage(_movementSpeedValue);
        else if (_isPercentageValue)
            movement.ChangeSpeedByCurrentSpeedPercentage(_movementSpeedValue);
        else
            movement.ChangeSpeed(_movementSpeedValue);
    }
}
