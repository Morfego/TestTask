using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Bullet data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private float _damage;
    [SerializeField] private float _flySpeed;
    [SerializeField] private float _liveTime;
    [SerializeField] private float _shootCooldown;
    [SerializeField] private GameObject _bulletObject;
    [SerializeField] private bool _destroyOnFirst;

    public float Damage => _damage;
    public float FlySpeed => _flySpeed;
    public float LiveTime => _liveTime;
    public float ShootCooldown => _shootCooldown;
    public GameObject BulletObject => _bulletObject;
    public bool DestroyOnFirst => _destroyOnFirst;
}
