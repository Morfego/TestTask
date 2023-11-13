using System;
using UnityEngine;

public class PlayerLevelController : MonoBehaviour
{
    public event Action ExpUpdated;

    [SerializeField] private LevelsData _levelsData;

    private float _exp;
    private int _level;

    public float Exp => _exp;
    public float ExpRequired => _levelsData.RequiredExp(_level);
    public int Level => _level;
    public int LevelToDisplay => _level + 1;
    public bool MaxLevel => _levelsData.IsMaxLevel(_level);

    public void ChangeExp(float change)
    {
        _exp += change;

        if (_levelsData.IsMaxLevel(_level) == false && _exp >= _levelsData.RequiredExp(_level))
        {
            _exp -= _levelsData.RequiredExp(_level);
            _level += 1;
        }

        ExpUpdated?.Invoke();
    }
}
