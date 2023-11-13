using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAbilityCastConditionBase : ScriptableObject
{
    public virtual List<EnemyAbilityTarget> EnemiesFullfilingCondition(List<EnemyAbilityTarget> possibleEnemies)
    {
        List<EnemyAbilityTarget> enemiesFullfilingCondition = new List<EnemyAbilityTarget>();

        foreach (var enemy in possibleEnemies)
        {
            if (EnemyFullfilsCondition(enemy))
                enemiesFullfilingCondition.Add(enemy);
        }

        return enemiesFullfilingCondition;
    }

    protected abstract bool EnemyFullfilsCondition(EnemyAbilityTarget target);
}
