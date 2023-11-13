using UnityEngine;

public class BulletLiveTimer : BulletBase
{
    private float _currentLiveTime;

    private void OnEnable()
    {
        _currentLiveTime = 0;
    }

    private void Update()
    {
        _currentLiveTime += Time.deltaTime;

        if (_currentLiveTime >= _data.LiveTime)
            DeactivateBullet();
    }
}
