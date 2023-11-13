using UnityEngine;

public abstract class BulletBase : MonoBehaviour, IBulletPart
{
    protected BulletData _data;

    public void SetBulletData(BulletData bulletData)
    {
        _data = bulletData;
    }

    protected virtual void DeactivateBullet()
    {
        gameObject.SetActive(false);
    }
}
