using UnityEngine;

public class BulletShootController : MonoBehaviour
{
    [SerializeField] private KeyCode _shootInput;
    [SerializeField] private BulletLevelData _bulletLevelData;
    [SerializeField] private Transform _spawnPoint;

    private float _currentCooldown;

    public float CurrentCooldown => _currentCooldown;

    private void Update()
    {
        if (Input.GetKey(_shootInput) && _currentCooldown <= 0)
            SpawnBullet();

        if (_currentCooldown > 0)
            _currentCooldown -= Time.deltaTime;
    }

    private void SpawnBullet()
    {
        var currentLevelData = _bulletLevelData.GetDataOnLevel(PlayerManager.Instance.PlayerLevelController.Level);
        _currentCooldown = currentLevelData.ShootCooldown;

        var bullet = PoolingManager.Instance.GetOrCreate(currentLevelData.BulletObject, _spawnPoint.position);
        bullet.transform.rotation = _spawnPoint.rotation;

        var bulletParts = bullet.GetComponentsInChildren<IBulletPart>();

        foreach (var bulletPart in bulletParts)
            bulletPart.SetBulletData(currentLevelData);
    }
}
