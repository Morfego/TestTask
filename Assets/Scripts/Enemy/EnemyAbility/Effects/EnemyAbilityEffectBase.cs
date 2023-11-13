using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAbilityEffectBase : ScriptableObject
{
    [SerializeField] protected List<EnemyAbilityCastConditionBase> _conditions;

    public void TryInvokeEffect()
    {
        var possibleEnemies = EnemiesManager.Instance.GetAliveEnemies();

        if (possibleEnemies.Count == 0)
            return;

        foreach (var condition in _conditions)
        {
            possibleEnemies = condition.EnemiesFullfilingCondition(possibleEnemies);

            if (possibleEnemies.Count == 0)
                return;
        }

        possibleEnemies.ForEach(p => InvokeEffect(p));
    }

    protected abstract void InvokeEffect(EnemyAbilityTarget target);
}
