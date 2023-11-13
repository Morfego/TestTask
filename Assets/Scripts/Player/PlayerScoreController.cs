using System;
using UnityEngine;

public class PlayerScoreController : MonoBehaviour
{
    public event Action ScoreUpdated;

    private int _score;

    public int Score => _score;

    public void ChangeScore(int change)
    {
        _score += change;
        ScoreUpdated?.Invoke();
    }
}
