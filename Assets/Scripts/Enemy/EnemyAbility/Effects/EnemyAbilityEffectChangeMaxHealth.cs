using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy abilities/Effect change max health")]
public class EnemyAbilityEffectChangeMaxHealth : EnemyAbilityEffectBase
{
    [SerializeField] private float _healthValue;
    [SerializeField] private bool _isPercentageValue;

    protected override void InvokeEffect(EnemyAbilityTarget target)
    {
        var health = target.GetComponentInChildren<EnemyHealth>();

        if (!health)
            return;

        if (_isPercentageValue)
            health.ChangeMaxHealthByPercentage(_healthValue);
        else
            health.ChangeMaxHealth(_healthValue);
    }
}
