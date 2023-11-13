using UnityEngine;

public class BulletMovement : BulletBase
{
    [SerializeField] private Rigidbody _rigidbody;

    private float _currentFlewDistance;

    private void OnEnable()
    {
        _currentFlewDistance = 0;
    }

    private void FixedUpdate()
    {
        float distanceIncrease = _data.FlySpeed * Time.fixedDeltaTime;
        _currentFlewDistance += distanceIncrease;
        _rigidbody.MovePosition(transform.position + transform.forward * distanceIncrease);
    }
}
