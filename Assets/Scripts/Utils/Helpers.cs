using UnityEngine;

public enum ValueConditionType
{
    LessThan,
    LessThanOrEqual,
    Equal,
    NotEqual,
    GreaterThan,
    GreaterThanOrEqual
}


public static class Helpers
{
    public static bool Compare(this float value, float compareValue, ValueConditionType condition)
    {
        switch (condition)
        {
            case ValueConditionType.LessThan:
                return value < compareValue;

            case ValueConditionType.LessThanOrEqual:
                return value <= compareValue;

            case ValueConditionType.Equal:
                return Mathf.Approximately(value, compareValue);

            case ValueConditionType.NotEqual:
                return !Mathf.Approximately(value, compareValue);

            case ValueConditionType.GreaterThan:
                return value > compareValue;

            case ValueConditionType.GreaterThanOrEqual:
                return value >= compareValue;

            default:
                return false;
        }
    }

    public static bool Compare(this int value, int compareValue, ValueConditionType condition)
    {
        switch (condition)
        {
            case ValueConditionType.LessThan:
                return value < compareValue;

            case ValueConditionType.LessThanOrEqual:
                return value <= compareValue;

            case ValueConditionType.Equal:
                return value == compareValue;

            case ValueConditionType.NotEqual:
                return value != compareValue;

            case ValueConditionType.GreaterThan:
                return value > compareValue;

            case ValueConditionType.GreaterThanOrEqual:
                return value >= compareValue;

            default:
                return false;
        }
    }
}
