using UnityEngine;

[CreateAssetMenu(menuName = "Adam Panowicz/Bullet level data")]
public class BulletLevelData : ScriptableObject
{
    [SerializeField] private BulletData[] _bulletData;

    public BulletData GetDataOnLevel(int level) => _bulletData[Mathf.Clamp(level, 0, _bulletData.Length - 1)];
}
