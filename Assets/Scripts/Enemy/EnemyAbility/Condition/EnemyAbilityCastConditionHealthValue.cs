using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy abilities/Condition health value")]
public class EnemyAbilityCastConditionHealthValue : EnemyAbilityCastConditionBase
{
    [SerializeField] private float _healthValue;
    [SerializeField] private bool _isPercentageValue;
    [SerializeField] private ValueConditionType _healthConditionType;

    protected override bool EnemyFullfilsCondition(EnemyAbilityTarget target)
    {
        var health = target.GetComponentInChildren<EnemyHealth>();

        if (health == null)
            return false;

        if (_isPercentageValue)
            return health.CurrentHealthPercentage.Compare(_healthValue, _healthConditionType);
        else
            return health.CurrentHealth.Compare(_healthValue, _healthConditionType);
    }
}
