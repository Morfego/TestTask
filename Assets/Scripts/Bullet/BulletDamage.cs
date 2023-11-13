using UnityEngine;

public class BulletDamage : BulletBase
{
    private void OnTriggerEnter(Collider other)
    {
        var enemie = other.attachedRigidbody.gameObject.GetComponent<EnemyHealth>();

        if (!enemie)
            return;

        enemie.TakeDamage(_data.Damage);

        if (_data.DestroyOnFirst)
            DeactivateBullet();
    }
}
