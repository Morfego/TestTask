using UnityEngine;

public class BulletRecastExplosion : MonoBehaviour
{
    [SerializeField] private BulletLevelData _bulletLevelData;
    [SerializeField] private KeyCode _inputRecast;

    private void Update()
    {
        if (Input.GetKeyDown(_inputRecast))
        {
            var bulletData = _bulletLevelData.GetDataOnLevel(PlayerManager.Instance.PlayerLevelController.Level);
            var bullet = PoolingManager.Instance.GetOrCreate(bulletData.BulletObject, transform.position);
            bullet.transform.rotation = transform.rotation;

            var bulletParts = bullet.GetComponentsInChildren<IBulletPart>();
            foreach (var bulletPart in bulletParts)
                bulletPart.SetBulletData(bulletData);

            gameObject.SetActive(false);
        }
    }
}
