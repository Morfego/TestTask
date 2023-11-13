using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy abilities/Effect change health")]
public class EnemyAbilityEffectChangeHealth : EnemyAbilityEffectBase
{
    [SerializeField] private float _healthValue;
    [SerializeField] private bool _isPercentageValue;
    [SerializeField] private bool _isMaxHealthPercentageValue;

    protected override void InvokeEffect(EnemyAbilityTarget target)
    {
        var health = target.GetComponentInChildren<EnemyHealth>();

        if (!health)
            return;

        if (_isMaxHealthPercentageValue)
            health.ChangeHealthByMaxHealthPercentage(_healthValue);
        else if (_isPercentageValue)
            health.ChangeHealthByPercentage(_healthValue);
        else
            health.ChangeHealth(_healthValue);
    }
}
