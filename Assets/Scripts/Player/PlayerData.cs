using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Player data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float _playerMinPositionX;
    [SerializeField] private float _playerMaxPositionX;
    [SerializeField] private float _playerMoveSpeed;
    [SerializeField] private float _playerHealth;

    public float PlayerMinPositionX => _playerMinPositionX;
    public float PlayerMaxPositionX => _playerMaxPositionX;
    public float PlayerMoveSpeed => _playerMoveSpeed;
    public float PlayerHealth => _playerHealth;
}
