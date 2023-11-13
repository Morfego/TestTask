using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAbilityCasterBase : MonoBehaviour
{
    [SerializeField] protected List<EnemyAbilityEffectBase> _effects;

    protected virtual void InvokeEffects() => _effects.ForEach(p => p.TryInvokeEffect());
}
