using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Levels data")]
public class LevelsData : ScriptableObject
{
    [SerializeField] private float[] _requredExp;

    public float RequiredExp(int level) => IsMaxLevel(level) ? _requredExp[_requredExp.Length - 1] : _requredExp[level];
    public bool IsMaxLevel(int level) => level >= _requredExp.Length;
}
