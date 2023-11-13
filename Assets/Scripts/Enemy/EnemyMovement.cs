using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public event Action ReachedFinalPoint;

    [SerializeField] private EnemyData _enemyData;
    [SerializeField] private Rigidbody _rigidbody;

    private float _currentMoveSpeed;

    public void ChangeSpeed(float value) => _currentMoveSpeed += value;

    public void ChangeSpeedByCurrentSpeedPercentage(float value) => _currentMoveSpeed += value * _currentMoveSpeed;

    public void ChangeSpeedByMaxSpeedPercentage(float value) => _currentMoveSpeed += value * _enemyData.MoveSpeed;

    private void OnEnable()
    {
        _currentMoveSpeed = _enemyData.MoveSpeed;
    }

    private void FixedUpdate()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        _rigidbody.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime * _currentMoveSpeed);

        if (transform.position.z <= 0)
            DamagePlayer();
    }

    private void DamagePlayer()
    {
        PlayerManager.Instance.PlayerHealthController.DealDamage(_enemyData.Damage);
        gameObject.SetActive(false);
        ReachedFinalPoint?.Invoke();
    }
}
