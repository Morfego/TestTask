using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Enemy data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _expRewardForKill;
    [SerializeField] private float _damage;
    [SerializeField] private int _score;

    public float MaxHealth => _maxHealth;
    public float MoveSpeed => _moveSpeed;
    public float ExpRewardForKill => _expRewardForKill;
    public float Damage => _damage;
    public int Score => _score;
}
