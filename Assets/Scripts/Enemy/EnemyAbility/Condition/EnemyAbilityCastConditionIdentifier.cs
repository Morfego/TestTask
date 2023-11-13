using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy abilities/Condition identifier")]
public class EnemyAbilityCastConditionIdentifier : EnemyAbilityCastConditionBase
{
    [SerializeField] private List<EnemyAbilityIdentifierObjectData> _requiredIdentifiers;
    [SerializeField] private bool _requireAny;

    protected override bool EnemyFullfilsCondition(EnemyAbilityTarget target)
    {
        var tokens = target.GetIdentifiersTokens();

        if (_requireAny)
            return RequireAny(tokens);
        else
            return RequireAll(tokens);
    }

    private bool RequireAny(List<EnemyAbilityIdentifierObjectData> tokens)
    {
        foreach (var token in tokens)
        {
            if (_requiredIdentifiers.Contains(token))
                return true;
        }

        return false;
    }

    private bool RequireAll(List<EnemyAbilityIdentifierObjectData> tokens)
    {
        foreach (var requiredToken in _requiredIdentifiers)
        {
            if (!tokens.Contains(requiredToken))
                return false;
        }

        return true;
    }
}
